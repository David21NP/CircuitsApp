using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircuitsApp
{
    public partial class FormLista3 : Form
    {
        public List<long> R1 { get; set; }
        public List<long> R2 { get; set; }
        public List<long> R3 { get; set; }
        public List<float> Err { get; set; }

        public List<string> showLs { get; set; }

        public string BestAns { get; set; }

        public FormLista3(List<long> r1, List<long> r2, List<long> r3, List<float> err, string bst)
        {
            InitializeComponent();

            R1 = r1;
            R2 = r2;
            R3 = r3;
            Err = err;
            BestAns = bst;

            showLs = new List<string>();

            for (int i = 0; i < R1.Count; i++)
            {
                showLs.Add(R1[i].ToString() + "                        " + R2[i].ToString() + "                        " + R3[i].ToString() + "                        " + Err[i].ToString());
            }

            listBox1.DataSource = showLs;

            NumRes.Text = (R1.Count.ToString());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BestAns, "Mejor resultado", MessageBoxButtons.OK);
        }
    }
}
