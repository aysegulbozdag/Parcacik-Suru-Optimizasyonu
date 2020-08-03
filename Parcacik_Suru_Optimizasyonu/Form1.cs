using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcacik_Suru_Optimizasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Titles.Add("Yakınsama Grafiği");
        }
        int low_limit, top_limit, d_swarm, size_swarm, iteration, epoch;

        double c1, c2;


        Particle p;

        private void btnSırala_Click(object sender, EventArgs e)
        {
            getTextValue();
            p = new Particle(low_limit, top_limit, size_swarm, d_swarm, iteration);
            drawChart();
            setDataTable();
        }

        public void getTextValue()
        {
            low_limit = Convert.ToInt32(txtLow.Text);
            top_limit = Convert.ToInt32(txtTop.Text);
            d_swarm = Convert.ToInt32(txtD.Text);
            size_swarm = Convert.ToInt32(txtSize.Text);
            c1 = Convert.ToDouble(txtC1.Text);
            c2 = Convert.ToDouble(txtC2.Text);
            iteration = Convert.ToInt32(txtIteration.Text);
            epoch = Convert.ToInt32(txtSize.Text);

        }

        public void drawChart()
        {

            foreach (var gbest in p.objListGbest)
            {
                chart1.Series["gbest değerleri"].Points.Add((gbest));

            }
        }

        public void setDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("No");
            dt.Columns.Add("En iyi gbest değerleri");

            for (int i = 0; i < iteration; i++)
            {
                dt.Rows.Add(i + 1, p.objListGbest[i]);
            }
            dataGridView1.DataSource = dt;
        }
    }
}
