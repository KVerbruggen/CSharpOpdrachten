using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptApp
{
    public partial class FormEncryptApp : Form
    {
        private Encoding encoding = Encoding.UTF8;

        public FormEncryptApp()
        {
            InitializeComponent();
            this.cbEncryptionAlgorithms.DataSource = Encryption.encryptionAlgorithms;
            this.tbInput.Focus();
            this.tbInput.Select();
        }

        private string OpenFileLocation()
        {
            OpenFileDialog dialogGetFile = new OpenFileDialog
            {
                Multiselect = false,
                CheckFileExists = true
            };
            return GetLocation(dialogGetFile);
        }

        private string SaveFileLocation()
        {
            string filter = "Text Files (*.txt)|*.txt";
            List<string> extraExtensions = Encryption.GetFileExtensions();
            foreach (string extension in extraExtensions)
            {
                filter += "|" + extension;
            }
            filter += "|All Files (*.*)|*.* ";
            SaveFileDialog dialogGetSaveLocation = new SaveFileDialog
            {
                CheckPathExists = true,
                OverwritePrompt = true,
                Filter = filter
            };
            return GetLocation(dialogGetSaveLocation);

        }

        private string GetLocation(FileDialog fileDialog)
        {
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            else
            {
                return fileDialog.FileName;
            }
        }

        private byte[] GetBytes(string input)
        {
            return encoding.GetBytes(input);
        }

        private string GetString(byte[] input)
        {
            return encoding.GetString(input);
        }

        private byte[] GetKey()
        {
            if (((Algorithm)cbEncryptionAlgorithms.SelectedValue).Name == "ROT-n" && Int32.TryParse(tbKey.Text, out int intKey))
            {
                return new byte[] { (byte)intKey };
            }
            else
            {
                return GetBytes(tbKey.Text);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            cbEncryptionAlgorithms.Width = tbInput.Width - 56;
            tbKey.Width = tbInput.Width - 158;
        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] key = GetKey();
                tbOutput.Text = GetString(Encryption.Encrypt(((Algorithm)cbEncryptionAlgorithms.SelectedValue), GetBytes(tbInput.Text), key));
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Input could not be encrypted");
            }
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] key = GetKey();
                tbOutput.Text = GetString(Encryption.Decrypt(((Algorithm)cbEncryptionAlgorithms.SelectedValue), GetBytes(tbInput.Text), key));
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Input could not be decrypted");
            }
        }

        private void btEncryptToFile_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] key = GetKey();
                byte[] encrypted = Encryption.Encrypt(((Algorithm)cbEncryptionAlgorithms.SelectedValue), GetBytes(tbInput.Text), key);
                string savelocation = SaveFileLocation();
                if (Encryption.SaveToFile(savelocation, encrypted))
                {
                    MessageBox.Show("Encrypted file saved at " + savelocation);
                }
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Input could not be encrypted");
            }
        }

        private void btDecryptToFile_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] key = GetKey();
                byte[] decrypted = Encryption.Decrypt((Algorithm)cbEncryptionAlgorithms.SelectedValue, GetBytes(tbInput.Text), key);
                string savelocation = SaveFileLocation();
                if (Encryption.SaveToFile(savelocation, decrypted))
                {
                    MessageBox.Show("Decrypted file saved at " + savelocation);
                }
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Input could not be decrypted");
            }

        }

        private void btEncryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileLocation = OpenFileLocation();
                if (fileLocation == null || fileLocation == String.Empty)
                {
                    return;
                }
                byte[] key = GetKey();
                byte[] encrypted = Encryption.Encrypt((Algorithm)cbEncryptionAlgorithms.SelectedValue, FileHandler.ReadFile(fileLocation), key);
                string savelocation = SaveFileLocation();
                if (Encryption.SaveToFile(savelocation, encrypted))
                {
                    MessageBox.Show("Encrypted file saved at " + savelocation);
                }
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Input could not be encrypted");
            }
        }

        private void btDecryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileLocation = OpenFileLocation();
                if (fileLocation == null || fileLocation == String.Empty)
                {
                    return;
                }
                byte[] key = GetKey();
                byte[] decrypted = Encryption.Decrypt((Algorithm)cbEncryptionAlgorithms.SelectedValue, FileHandler.ReadFile(fileLocation), key);
                string savelocation = SaveFileLocation();
                if (Encryption.SaveToFile(savelocation, decrypted))
                {
                    MessageBox.Show("Decrypted file saved at " + savelocation);
                }
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Input could not be encrypted");
            }
        }

        private void btLoadKeyFromFile_Click(object sender, EventArgs e)
        {
            string fileLocation = OpenFileLocation();
            if (fileLocation == null || fileLocation == String.Empty)
            {
                return;
            }
            tbKey.Text = GetString(FileHandler.ReadFile(fileLocation));
        }
    }
}
