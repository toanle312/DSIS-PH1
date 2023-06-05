using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1
{
    public class Encryption
    {
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

        /*?
         * Thiết lập thuật toán AES256
         */

        private static AesCryptoServiceProvider CreateCryptoProvider(byte[] encryptionKey)
        {
            var cryptoProvider = new AesCryptoServiceProvider
            {
                // Ensure the key has the correct size
                Key = encryptionKey[..32],
                IV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
            return cryptoProvider;
        }

        /*?
         * Mã hóa chuỗi plaintext
         */

        private static byte[] Encrypt(AesCryptoServiceProvider cryptoServiceProvider, string? plainText)
        {
            var encryptor = cryptoServiceProvider.CreateEncryptor();

            using var msEncrypt = new MemoryStream();
            using var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                swEncrypt.Write(plainText);
            }
            var encrypted = msEncrypt.ToArray();

            return encrypted;
        }

        /*?
         * Mã hóa trường LUONG và PHUCAP bằng thuật toán AES256
         */

        public static void EncryptSalaryAndAllowance(DataRow employee)
        {
            var id = employee["MANV"].ToString();
            var name = employee["TENNV"].ToString();
            Debug.WriteLine($"Id: {id}, Name: {name}");

            if (id == null || name == null) return;

            var encryptionKey = GenerateEncryptionKey(id, name);
            var hashedKey = Hash(encryptionKey);
            var cryptoServiceProvider = CreateCryptoProvider(hashedKey);

            // Mã hóa trường LUONG
            var salary = employee["LUONG"].ToString();
            var encryptedSalary = Encrypt(cryptoServiceProvider, salary);
            Debug.WriteLine($"Encrypted salary: {Convert.ToHexString(encryptedSalary)}");

            // Mã hóa trường PHUCAP
            var allowance = employee["PHUCAP"].ToString();
            var encryptedAllowance = Encrypt(cryptoServiceProvider, allowance);
            Debug.WriteLine($"Encrypted allowance: {Convert.ToHexString(encryptedAllowance)}");

            // Ghi dữ liệu đã mã hóa vào DataRow
            //employee["LUONG"] = encryptedSalary;
            //employee["PHUCAP"] = encryptedAllowance;
        }
    }

    public partial class fEncryption : Form
    {
        public fEncryption()
        {
            InitializeComponent();
        }

        private void ViewEmployeeButton_OnClick(object sender, EventArgs e)
        {
            const string query = "select * from U_AD_QLNV.NHANVIEN$";
            var employeeList = DataProvider.Instance.ExcuteQuery(query);
            DataGridView.DataSource = employeeList;

            // Loop over employeeList new Employee object and print it
            foreach (DataRow row in employeeList.Rows)
            {
                Encryption.EncryptSalaryAndAllowance(row);
            }
        }
    }
}