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
        int Nattributes;
        PerceptronTeaching perceptron;

        public FormMain()
        {
            InitializeComponent();
            this.Width = 629;
        }

        private void buttonFindFunctions_Click(object sender, EventArgs e)
        {
            if (textBoxNclasses.Text == String.Empty ||
                textBoxNobjects.Text == String.Empty ||
                textBoxNattributes.Text == String.Empty)
            {
                MessageBox.Show("Enter numbers!");
                return;
            }
            Nclasses = int.Parse(textBoxNclasses.Text);
            Nobjects = int.Parse(textBoxNobjects.Text);
            Nattributes = int.Parse(textBoxNattributes.Text);

            textBoxClasses.Text = String.Empty;
            textBoxFunctions.Text = String.Empty;
            if (Nclasses != 0 && Nobjects != 0 && Nattributes != 0)
            {
                perceptron = new PerceptronTeaching(this, Nclasses, Nobjects, Nattributes);
                dataGridViewTest.Rows.Clear();
                for (int i = 0; i < Nattributes - 1; i++ )
                    dataGridViewTest.Rows.Add();
                this.Width = 889;
                labelAnswer.Text = "";
            }
        }

        private void textBoxNclasses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    e.KeyChar = '\0';
        }

        private void dataGridViewTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    e.KeyChar = '\0';
        }

        private void buttonClassify_Click(object sender, EventArgs e)
        {
            int[] attributes = new int[Nattributes + 1];

            for (int i = 0; i < Nattributes; i++)
            {
                attributes[i] = Convert.ToInt32(dataGridViewTest.Rows[i].Cells[0].Value);
            }
            attributes[Nattributes] = 1;
            perceptron.Classify(attributes);
        }

    }
}
