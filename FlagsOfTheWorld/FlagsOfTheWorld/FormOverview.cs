using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlagsOfTheWorld
{
    public partial class FormOverview : Form
    {
        Form parentForm;

        public FormOverview(Form parentForm)
        {
            this.parentForm = parentForm;
            StartPosition = new FormStartPosition();
            Top = parentForm.Top;
            Left = parentForm.Left;

            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Top = Top;
            parentForm.Left = Left;
            parentForm.Visible = true;
        }

        private void FormOverview_Load(object sender, EventArgs e)
        {
            foreach (Flag flag in Main.flags)
            {
                System.Windows.Forms.GroupBox gbNation;
                System.Windows.Forms.Label lblNation;
                System.Windows.Forms.PictureBox pbNation;

                gbNation = new System.Windows.Forms.GroupBox();
                lblNation = new System.Windows.Forms.Label();
                pbNation = new System.Windows.Forms.PictureBox();

                // 
                // label
                // 
                lblNation.BackColor = System.Drawing.Color.Transparent;
                lblNation.Location = new System.Drawing.Point(0, 75);
                lblNation.Name = "lblNation" + flag.Id;
                lblNation.Size = new System.Drawing.Size(100, 30);
                lblNation.TabIndex = 0;
                lblNation.Text = flag.Name;
                lblNation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // picturebox
                // 
                pbNation.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.ControlLight);
                pbNation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pbNation.Location = new System.Drawing.Point(5, 10);
                pbNation.Name = "pbNation" + flag.Id;
                pbNation.Size = new System.Drawing.Size(90, 65);
                pbNation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pbNation.TabIndex = 1;
                pbNation.TabStop = false;
                pbNation.Image = flag.Image;
                // 
                // groupbox
                // 
                gbNation.Controls.Add(lblNation);
                gbNation.Controls.Add(pbNation);
                gbNation.Location = new System.Drawing.Point(3, 3);
                gbNation.Name = "gbNation" + flag.Id;
                gbNation.Size = new System.Drawing.Size(100, 110);
                gbNation.TabIndex = 1;
                gbNation.TabStop = false;

                // Add flag to the flowLayoutPanel
                this.flowLayoutPanelMain.Controls.Add(gbNation);

            }

        }
    }
}
