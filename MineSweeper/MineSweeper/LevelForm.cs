using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class LevelForm : Form
    {
        public LevelForm()
        {
            InitializeComponent();
        }

        private void beginnerButton_Click(object sender, EventArgs e)
        {
            FieldForm field = new FieldForm(9, 9, 10, 60);
            field.Show();
            this.Hide();
        }

        private void intermediateButton_Click(object sender, EventArgs e)
        {
            FieldForm field = new FieldForm(16, 16, 40, 40);
            field.Show();
            this.Hide();
        }

        private void expertButton_Click(object sender, EventArgs e)
        {
            FieldForm field = new FieldForm(30, 16, 99, 20);
            field.Show();
            this.Hide();
        }
    }
}
