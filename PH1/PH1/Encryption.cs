using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace PH1;

public class Encryption
{
    private static string _salt = "Lâm Bích Phước Quân";
    private static int _keySize = 256;
    private static int _KeyLength = _keySize / 8;

    /*?
         * Tạo khóa chính bằng cách đan xen các số trong mã nhân viên và các từ trong họ tên của nhóm
         *
         * Ví dụ:
         * Id: NV001, Name: Công Tằng Tôn Nữ Đỗ Thị Thu Hương
         * Master key: Công0Tằng0Tôn1Nữ0Đỗ0Thị1Thu0Hương0
         */

    private static string GenerateEncryptionKey(string id)
    {
        var numbers = id[2..].ToCharArray();
        var words = _salt.Split(' ');
        var masterKey = new StringBuilder();

        // Đan xen mã nhân viên và các từ trong họ tên
        for (var i = 0; i < Math.Min(numbers.Length, words.Length); i++)
        {
            var word = words[i];
            var number = numbers[i];
            masterKey.Append(word).Append(number);
        }

        // Nếu họ tên có nhiều từ hơn mã số nhân viên thì lặp lại mã số nhân viên
        if (words.Length > numbers.Length)
        {
            for (var i = numbers.Length; i < words.Length; i++)
            {
                var word = words[i];
                var number = numbers[i % numbers.Length];
                masterKey.Append(word).Append(number);
            }
        }

        return masterKey.ToString();
    }

    private static byte[] Hash(string encryptionKey)
    {
        var bytes = Encoding.UTF8.GetBytes(encryptionKey);
        var hash = SHA256.HashData(bytes);
        return hash;
    }

    private static byte[] PadByteArray(byte[] input, int desiredLength)
    {
        if (input.Length >= desiredLength)
            return input[..desiredLength];

        byte[] paddedArray = new byte[desiredLength];
        Array.Copy(input, paddedArray, input.Length);
        return paddedArray;
    }

    private static Aes CreateAES(byte[] encryptionKey)
    {
        var aes = Aes.Create();
        aes.KeySize = _keySize;
        aes.Key = PadByteArray(encryptionKey, _KeyLength);
        aes.IV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        return aes;
    }

    private static byte[] Encrypt(Aes aes, string? plainText)
    {
        var encryptor = aes.CreateEncryptor();

        using var msEncrypt = new MemoryStream();
        using var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
        using (var swEncrypt = new StreamWriter(csEncrypt))
        {
            swEncrypt.Write(plainText);
        }
        var encrypted = msEncrypt.ToArray();

        return encrypted;
    }

    private static string Decrypt(Aes aes, byte[] cipherText)
    {
        string plaintext = "";

        ICryptoTransform decryptor = aes.CreateDecryptor();

        using var msDecrypt = new MemoryStream(cipherText);
        using var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
        using (var srDecrypt = new StreamReader(csDecrypt))
        {
            plaintext = srDecrypt.ReadToEnd();
        }

        return plaintext;
    }

    private static string ToHex(byte[] bytes)
    {
        return $"0x{Convert.ToHexString(bytes)}";
    }

    private static byte[] ToBytes(string? hex)
    {
        return hex == null ? Array.Empty<byte>() : Convert.FromHexString(hex[2..]);
    }

    public static void EncryptEmployee(DataRow employeeRow, DataTable encryptedTable)
    {
        var employee = EmployeeServices.GetEmployeeInfo(employeeRow);

        // Tạo khóa
        if (employee.Id == "" || employee.Name == "") return;

        var encryptionKey = GenerateEncryptionKey(employee.Id);
        var hashedKey = Hash(encryptionKey);
        var aes = CreateAES(hashedKey);

        // Debug.WriteLine($"Id: {id}, Name: {name}, Salary: {salary}, Allowance: {allowance}");
        // Debug.WriteLine($"Hashed key: {ToHex(hashedKey)}");

        // Mã hóa trường LUONG và PHUCAP
        var encryptedSalary = Encrypt(aes, employee.Salary);
        var encryptedAllowance = Encrypt(aes, employee.Allowance);

        var encryptedRow = EmployeeServices.SetEmployeeInfo(employee, encryptedTable);
        encryptedRow["LUONG"] = ToHex(encryptedSalary);
        encryptedRow["PHUCAP"] = ToHex(encryptedAllowance);
        encryptedTable.Rows.Add(encryptedRow);
    }

    public static void DecryptEmployee(DataRow encryptedEmployeeRow, DataTable decryptedTable)
    {
        var encryptedEmployee = EmployeeServices.GetEmployeeInfo(encryptedEmployeeRow);

        // Tạo khóa
        if (encryptedEmployee.Id == "" || encryptedEmployee.Name == "") return;

        var encryptionKey = GenerateEncryptionKey(encryptedEmployee.Id);
        var hashedKey = Hash(encryptionKey);
        var aes = CreateAES(hashedKey);

        // Debug.WriteLine($"Id: {id}, Name: {name}, Salary: {encryptedSalary}, Allowance: {encryptedAllowance}");
        // Debug.WriteLine($"Hashed key: {ToHex(hashedKey)}");

        // Giải mã trường LUONG và PHUCAP
        var decryptedSalary = Decrypt(aes, ToBytes(encryptedEmployee.Salary.Contains("0x") ? encryptedEmployee.Salary : "0x" + encryptedEmployee.Salary));
        var decryptedAllowance = Decrypt(aes, ToBytes(encryptedEmployee.Allowance.Contains("0x") ? encryptedEmployee.Allowance : "0x" + encryptedEmployee.Allowance));

        //var decryptedSalary = Decrypt(aes, ToBytes(encryptedEmployee.Salary));
        //var decryptedAllowance = Decrypt(aes, ToBytes(encryptedEmployee.Allowance));


        DataRow decryptedRow = EmployeeServices.SetEmployeeInfo(encryptedEmployee, decryptedTable);
        decryptedRow["LUONG"] = decryptedSalary;
        decryptedRow["PHUCAP"] = decryptedAllowance;
        decryptedTable.Rows.Add(decryptedRow);
    }
}