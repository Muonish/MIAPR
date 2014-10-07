using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAppMax_Min
{
    public partial class FormMain : Form
    {
        const int DiapasonColorMax = 200;
        const int DiapasonColorMin = 20;

        public struct PointInfo
        {
            public Point coord;
            public int father;
            public Color color;
            public bool isChanged;
        }

        public static int Npoint;
        public static int Nclass;
        public static bool сentersIsChanged;
        PointInfo[] vectorPoint;
        int[] vectorKernel;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Npoint = 0;
            Nclass = 0;
            panelHolst.Refresh();

            if (comboBoxPoints.Text == string.Empty)
            {
                MessageBox.Show("Enter the numbers.");
            }
            else
            {
                try
                {
                    Npoint = int.Parse(comboBoxPoints.Text);
                }
                catch
                {
                    MessageBox.Show("Error! Out of int!");
                }
                
                var kmeans = new ClassMaximin(Npoint, this);
               
            }
        }
    }
}
