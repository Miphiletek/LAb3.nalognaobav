using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LAb3.NDC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void proc10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int x = 10;
            Procent.Text =Convert.ToString(x);
            
        }

        private void Raschet_Click(object sender, EventArgs e)
        {
            if (KNOPKA1.Checked == true)
            {
                new Thread(() =>

                {
                    Action action = () =>
                    {
                        double xut = Convert.ToDouble(Chislo.Text);
                        int proc = Convert.ToInt32(Procent.Text);
                        double result = xut * proc / 100;
                        MessageBox.Show("Начисление НДС = ", result.ToString());



                    };
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();







                }).Start();
            }
            else if (KNOPKA2.Checked == true)
            {
                new Thread(() =>

                {
                    Action action = () =>
                    {
                        double xut = Convert.ToDouble(Chislo.Text);
                        int proc = Convert.ToInt32(Procent.Text);
                        double result = xut /100*proc;
                        MessageBox.Show("Выделенное  НДС = ", result.ToString());



                    };
                    if (InvokeRequired)
                        Invoke(action);
                    else
                        action();







                }).Start();

            }

        }

        private void KNOPKA1_CheckedChanged(object sender, EventArgs e)
        {
            if(KNOPKA1.Checked==true)
            {
                KNOPKA2.Checked = false;
            }
        }
       

        private void proc18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int x = 18;
            Procent.Text = Convert.ToString(x);

        }

        private void proc20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int x = 20;
            Procent.Text = Convert.ToString(x);
        }

        private void KNOPKA2_CheckedChanged(object sender, EventArgs e)
        {
            if(KNOPKA2.Checked==true)
            {
                KNOPKA1.Checked = false;
            }
        }
    }
}
