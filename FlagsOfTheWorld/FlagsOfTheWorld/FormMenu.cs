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
    public partial class FormMenu : Form
    {

        public FormMenu()
        {
            Main.LoadFlags();
            Main.LoadCategories();

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btOpenOverview_Click(object sender, EventArgs e)
        {
            Form overviewForm = new FormOverview(this);
            overviewForm.Show();
            this.Visible = false;
        }

        private void btStartTest_Click(object sender, EventArgs e)
        {
            Form categoryPicker = new FormCategoryPicker(this);
            categoryPicker.Show();
            this.Visible = false;
        }
    }
}
