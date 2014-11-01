using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAppPerceptron
{
    public partial class FormMain : Form
    {
        int Nclasses;
        int Nobjects;
        int Nsigns;

        public FormMain()
        {
            InitializeComponent();
            this.Width = 629;
        }

        private void buttonFindFunctions_Click(object sender, EventArgs e)
        {
            if (textBoxNclasses.Text == String.Empty ||
                textBoxNobjects.Text == String.Empty ||
                textBoxNsigns.Text == String.Empty)
            {
                MessageBox.Show("Enter numbers!");
                return;
            }
            Nclasses = int.Parse(textBoxNclasses.Text);
            Nobjects = int.Parse(textBoxNobjects.Text);
            Nsigns = int.Parse(textBoxNsigns.Text);

            textBoxClasses.Text = String.Empty;
            textBoxFunctions.Text = String.Empty;
            if (Nclasses != 0 && Nobjects != 0 && Nsigns != 0)
            {
                PerceptronTeaching perceptron = new PerceptronTeaching(this, Nclasses, Nobjects, Nsigns);
                this.Width = 889;
            }
        }

        private void textBoxNclasses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    e.KeyChar = '\0';
        }

        private void textBoxTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    if (e.KeyChar != ' ')
                        if (e.KeyChar != ',')
                            e.KeyChar = '\0';
        }
    }
}
