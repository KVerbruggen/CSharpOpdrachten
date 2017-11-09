using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountCharacters
{
    public partial class FormCountCharacters : Form
    {

        public FormCountCharacters()
        {
            InitializeComponent();
            InitializeCharacterFrequencyView();
        }

        private void InitializeCharacterFrequencyView()
        {
        }

        private void SetLoading()
        {
            CharacterFrequencyView.Rows.Clear();
            DataGridViewRow rowLoading = new DataGridViewRow();
            rowLoading.CreateCells(CharacterFrequencyView);
            rowLoading.SetValues(null, "Loading...");

            CharacterFrequencyView.Rows.Add(rowLoading);
            tbFilenames.Text = String.Empty;
            lblCharacterCount.Text = String.Empty;

            this.Refresh();
        }

        private int LoadRows(string[] fileLocations)
        {
            int characterCount = 0;

            CharacterFrequencyView.Rows.Clear();

            Dictionary<string, int> characterFrequencies;
            characterCount = Main.LoadFile(fileLocations, out characterFrequencies);

            if (characterFrequencies != null)
            {
                foreach (KeyValuePair<string, int> singleCharacterData in characterFrequencies)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(CharacterFrequencyView);
                    row.SetValues(singleCharacterData.Key, singleCharacterData.Value);
                    CharacterFrequencyView.Rows.Add(row);
                    CharacterFrequencyView.Sort(CharacterFrequencyView.Columns[1], ListSortDirection.Descending);
                }
                CharacterFrequencyView.Rows[0].Selected = true;
            }

            return characterCount;
        }

        private string BuildFilenameString(string[] fileNames)
        {
            bool firstFile = true;
            string fileNameString = String.Empty;
            foreach (string filename in fileNames)
            {
                if (firstFile)
                {
                    firstFile = false;
                }
                else
                {
                    fileNameString += ", ";
                }
                fileNameString += "\"" + filename + "\"";
            }
            return fileNameString;
        }

        private void ResetControls()
        {
            CharacterFrequencyView.Rows.Clear();

            lblCharacterCount.Text = String.Empty;
            tbFilenames.Text = String.Empty;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = true,
            };
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            SetLoading();

            try
            {
                lblCharacterCount.Text = LoadRows(openFileDialog.FileNames).ToString();
                tbFilenames.Text = BuildFilenameString(openFileDialog.SafeFileNames);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found");
                ResetControls();
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Something went wrong while reading a file.");
                ResetControls();
            }
            
            return;
        }
    }
}
