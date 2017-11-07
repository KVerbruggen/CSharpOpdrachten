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
        public FormEncryptApp()
        {
            InitializeComponent();
            this.cbEncryptionAlgorithms.DataSource = Enum.GetValues(typeof(Algorithms));
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
            SaveFileDialog dialogGetSaveLocation = new SaveFileDialog
            {
                CheckPathExists = true,
                OverwritePrompt = true
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            cbEncryptionAlgorithms.Width = tbInput.Width - 56;
            tbKey.Width = tbInput.Width - 158;
        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            tbOutput.Text = Encryption.Encrypt((Algorithms)cbEncryptionAlgorithms.SelectedValue, tbInput.Text, tbKey.Text);
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            tbOutput.Text = Encryption.Decrypt((Algorithms)cbEncryptionAlgorithms.SelectedValue, tbInput.Text, tbKey.Text);
        }

        private void btEncryptToFile_Click(object sender, EventArgs e)
        {
            string encrypted = Encryption.Encrypt((Algorithms)cbEncryptionAlgorithms.SelectedValue, tbInput.Text, tbKey.Text);
            string savelocation = SaveFileLocation();
            if (savelocation == null || savelocation == String.Empty)
            {
                return;
            }
            FileHandler.WriteFile(SaveFileLocation(), encrypted);
            MessageBox.Show("Encrypted file saved at " + savelocation);
        }

        private void btEncryptFile_Click(object sender, EventArgs e)
        {
            string fileLocation = OpenFileLocation();
            if (fileLocation == null || fileLocation == String.Empty)
            {
                return;
            }
            string encrypted = Encryption.Encrypt((Algorithms)cbEncryptionAlgorithms.SelectedValue, FileHandler.ReadFile(fileLocation), tbKey.Text);
            string savelocation = SaveFileLocation();
            if (savelocation != null && savelocation != String.Empty)
            {
                FileHandler.WriteFile(savelocation, encrypted);
                MessageBox.Show("Encrypted file saved at " + savelocation);
            }
        }

        private void btDecryptToFile_Click(object sender, EventArgs e)
        {
            string decrypted = Encryption.Decrypt((Algorithms)cbEncryptionAlgorithms.SelectedValue, tbInput.Text, tbKey.Text);
            string savelocation = SaveFileLocation();
            if (savelocation != null && savelocation != String.Empty)
            {
                FileHandler.WriteFile(savelocation, decrypted);
                MessageBox.Show("Decrypted file saved at " + savelocation);
            }

        }

        private void btDecryptFile_Click(object sender, EventArgs e)
        {
            string fileLocation = OpenFileLocation();
            if (fileLocation == null || fileLocation == String.Empty)
            {
                return;
            }
            string decrypted = Encryption.Decrypt((Algorithms)cbEncryptionAlgorithms.SelectedValue, FileHandler.ReadFile(fileLocation), tbKey.Text);
            string savelocation = SaveFileLocation();
            if (savelocation == null || savelocation == String.Empty)
            {
                return;
            }
            FileHandler.WriteFile(savelocation, decrypted);
            MessageBox.Show("Decrypted file saved at " + savelocation);
        }

        private void btLoadKeyFromFile_Click(object sender, EventArgs e)
        {
            string fileLocation = OpenFileLocation();
            if (fileLocation == null || fileLocation == String.Empty)
            {
                return;
            }
            tbKey.Text = FileHandler.ReadFile(fileLocation);
        }
    }
}
