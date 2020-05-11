using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInputinteger.Text = txtRange.Text = rtbAnswer.Text = "";
            txtInputinteger.ReadOnly = false;
            txtRange.ReadOnly = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                int a, i, r, b;
                a = Convert.ToInt32(txtInputinteger.Text);
                r = Convert.ToInt32(txtRange.Text);
                
                for (i = 1; i <= r; i++)
                {
                    b = a * i;
                    rtbAnswer.SelectedText = a + " x " + i + " = " + b + "\n";
                }
                txtInputinteger.ReadOnly = true;
                txtRange.ReadOnly = true;
            }
            catch(Exception ex)
            {
                if (txtInputinteger.Text == "")
                {
                    errorProvider1.SetError(txtInputinteger, "This field is mandatory!");
                }

                if (txtRange.Text == "")
                {
                    errorProvider1.SetError(txtRange, "This field is mandatory!");
                }
            }
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.Bisque;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.White;
        }

        private void btnGenerate_MouseEnter(object sender, EventArgs e)
        {
            btnGenerate.BackColor = Color.Bisque;
        }

        private void btnGenerate_MouseLeave(object sender, EventArgs e)
        {
            btnGenerate.BackColor = Color.White;
        }
    }
}
