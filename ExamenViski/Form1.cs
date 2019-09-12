using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConvertorCore;

namespace ExamenViski
{
    public partial class ConvertorCore : Form
    {
        Culc convertor = new Culc();
        public ConvertorCore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDegree.Text.ToString() != null)
            {                
                tbRadian.Text = convertor.CulcRadian(Convert.ToDouble(tbDegree.Text.ToString())).ToString();
            }
            if (tbRadian.Text.ToString() != null)
            {
                tbDegree.Text = convertor.CulcDegree(Convert.ToDouble(tbRadian.Text.ToString())).ToString();
            }
            if (tbKm.Text.ToString() != null)
            {
                tbMille.Text = convertor.CulcMill(Convert.ToInt32(tbKm.Text.ToString())).ToString();
            }
            if (tbMille.Text.ToString() != null)
            {
                tbKm.Text = convertor.CulcKM(Convert.ToDouble(tbMille.Text.ToString())).ToString();
            }            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
