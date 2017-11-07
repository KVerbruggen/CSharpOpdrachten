using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagsOfTheWorld
{
    public partial class FormCategoryPicker : Form
    {
        Form parentForm;

        public FormCategoryPicker()
        {
            InitializeComponent();
        }

        public FormCategoryPicker(Form parentForm)
        {
            this.parentForm = parentForm;

            this.StartPosition = new FormStartPosition();
            Main.ConvertCoordinates(parentForm, this);

            InitializeComponent();
        }


        private void FormCategoryPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.ConvertCoordinates(this, parentForm);
            parentForm.Visible = true;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gbCategory_Click(object sender, EventArgs e)
        {
            Control control_sender = (Control)sender;
            while (control_sender.GetType() != typeof(CategoryGroupBox) && sender.GetType() != typeof(FormCategoryPicker))
            {
                control_sender = control_sender.Parent;
            }
            if (control_sender.GetType() == typeof(CategoryGroupBox))
            {
                CategoryGroupBox groupbox_sender = (CategoryGroupBox)control_sender;
                FormQuiz quizForm = new FormQuiz(this, groupbox_sender.Category);
                quizForm.Show();
                this.Visible = false;
            }
        }

        private void FormCategoryPicker_Load(object sender, EventArgs e)
        {
            foreach (Category category in Main.categories)
            {

                CategoryGroupBox gbCategory;
                System.Windows.Forms.Label lblCategory;
                System.Windows.Forms.PictureBox pbCategory;

                gbCategory = new CategoryGroupBox();
                lblCategory = new System.Windows.Forms.Label();
                pbCategory = new System.Windows.Forms.PictureBox();

                // 
                // label
                // 
                lblCategory.BackColor = System.Drawing.Color.Transparent;
                lblCategory.Location = new System.Drawing.Point(0, 85);
                lblCategory.Name = "lblCategory"+ category.Name.Replace(" ", String.Empty);
                lblCategory.Size = new System.Drawing.Size(110, 30);
                lblCategory.TabIndex = 2;
                lblCategory.Text = category.Name;
                lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblCategory.Click += new System.EventHandler(gbCategory_Click);
                // 
                // picturebox
                // 
                pbCategory.BackColor = System.Drawing.SystemColors.ControlLightLight;
                pbCategory.BackgroundImage = category.Icon;
                pbCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                pbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pbCategory.Location = new System.Drawing.Point(5, 10);
                pbCategory.Name = "pbCategory" + category.Name.Replace(" ", String.Empty);
                pbCategory.Size = new System.Drawing.Size(100, 75);
                pbCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pbCategory.TabIndex = 1;
                pbCategory.TabStop = false;
                pbCategory.Click += new System.EventHandler(gbCategory_Click);
                // 
                // groupbox
                //
                gbCategory.Controls.Add(lblCategory);
                gbCategory.Controls.Add(pbCategory);
                gbCategory.Location = new System.Drawing.Point(3, 3);
                gbCategory.Name = "gbCategory" + category.Name.Replace(" ", String.Empty);
                gbCategory.Size = new System.Drawing.Size(110, 120);
                gbCategory.TabIndex = 0;
                gbCategory.TabStop = false;
                gbCategory.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.ControlLightLight);
                gbCategory.Margin = new Padding(0, 5, 5, 5);
                gbCategory.Click += new System.EventHandler(gbCategory_Click);

                gbCategory.Category = category;

                // Add flag to the flowLayoutPanel
                this.flowLayoutPanelMain.Controls.Add(gbCategory);
            }
        }
    }
}
