using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace PH1;

public class Encryption
{
    private static int _keySize = 256;
    private static int _KeyLength = _keySize / 8;

    /*?
         * Tạo khóa chính bằng cách đan xen các số trong mã nhân viên và các từ trong họ tên
         *
         * Ví dụ:
         * Id: NV001, Name: Công Tằng Tôn Nữ Đỗ Thị Thu Hương
         * Master key: Công0Tằng0Tôn1Nữ0Đỗ0Thị1Thu0Hương0
         */

    private static string GenerateEncryptionKey(string id, string name)
    {
        var numbers = id[2..].ToCharArray();
        var words = name.Split(' ');
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
        // Padding key to be 32 bytes
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

    public static void EncryptSalaryAndAllowance(DataRow employee, DataTable encryptedTable)
    {
        // Lấy thông tin
        var id = employee["MANV"].ToString();
        var name = employee["TENNV"].ToString();
        var salary = employee["LUONG"].ToString();
        var allowance = employee["PHUCAP"].ToString();

        // Tạo khóa
        if (id == null || name == null) return;

        var encryptionKey = GenerateEncryptionKey(id, name);
        var hashedKey = Hash(encryptionKey);
        var aes = CreateAES(hashedKey);

        // Debug.WriteLine($"Id: {id}, Name: {name}, Salary: {salary}, Allowance: {allowance}");
        // Debug.WriteLine($"Hashed key: {ToHex(hashedKey)}");

        // Mã hóa trường LUONG và PHUCAP
        var encryptedSalary = Encrypt(aes, salary);
        var encryptedAllowance = Encrypt(aes, allowance);

        DataRow row = encryptedTable.NewRow();
        row["MANV"] = id;
        row["TENNV"] = name;
        row["LUONG"] = ToHex(encryptedSalary);
        row["PHUCAP"] = ToHex(encryptedAllowance);
        encryptedTable.Rows.Add(row);
    }

    public static void DecryptSalaryAndAllowance(DataRow encryptedEmployee, DataTable decryptedTable)
    {
        // Lấy thông tin
        var id = encryptedEmployee["MANV"].ToString();
        var name = encryptedEmployee["TENNV"].ToString();
        var encryptedSalary = encryptedEmployee["LUONG"].ToString();
        var encryptedAllowance = encryptedEmployee["PHUCAP"].ToString();

        // Tạo khóa
        if (id == null || name == null) return;

        var encryptionKey = GenerateEncryptionKey(id, name);
        var hashedKey = Hash(encryptionKey);
        var aes = CreateAES(hashedKey);

        // Debug.WriteLine($"Id: {id}, Name: {name}, Salary: {encryptedSalary}, Allowance: {encryptedAllowance}");
        // Debug.WriteLine($"Hashed key: {ToHex(hashedKey)}");

        // Giải mã trường LUONG và PHUCAP
        var decryptedSalary = Decrypt(aes, ToBytes(encryptedSalary));
        var decryptedAllowance = Decrypt(aes, ToBytes(encryptedAllowance));

        DataRow row = decryptedTable.NewRow();
        row["MANV"] = id;
        row["TENNV"] = name;
        row["LUONG"] = decryptedSalary;
        row["PHUCAP"] = decryptedAllowance;
        decryptedTable.Rows.Add(row);
    }
}