using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_lolo_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            float s0 = float.Parse(tb_s0.Text);
            float V = float.Parse(tb_vel.Text);
            float T = float.Parse(tb_Temp.Text);
            bool alive = false;
            float res;

            res = s0 + V * T;

            label2.Text = String.Format("Resultado: {0}",res);

            if (rb_MT.Checked)
            {
                alive = true;
            }

            if(alive == true)
            {
                lb_init.Text = s0.ToString();
                lb_final.Text = res.ToString();

                pb_Trajeto.Value = 100;
                rb_MT.Checked = false;
            }
            
        }
    }
}
