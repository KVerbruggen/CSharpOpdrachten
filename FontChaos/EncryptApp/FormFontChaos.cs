using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontChaos
{
    public partial class FormFontChaos : Form
    {
        public FormFontChaos()
        {
            InitializeComponent();

            this.tbInput.Focus();
            this.tbInput.Select();
        }

        private void AppendRichText(RichString output, RichTextBox richTextBox)
        {
            int selectionStart = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionStart - selectionStart + 1;
            richTextBox.Select(selectionStart, selectionLength);
            richTextBox.SelectionFont = output.Font;
            richTextBox.AppendText(output.Content);
        }

        private void btChaos_Click(object sender, EventArgs e)
        {
            RichString[] output = FontChaos.Chaotify(tbInput.Text);
            tbOutput.Text = String.Empty;
            foreach (RichString substring in output)
            {
                AppendRichText(substring, tbOutput);
            }
        }
    }
}
