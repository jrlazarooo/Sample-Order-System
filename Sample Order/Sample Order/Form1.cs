using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Order
{
    public partial class Form1 : Form
    {
        int item1 = 120, item2 = 110, item3 = 125, item4 = 150, item5 = 90, item6 = 135, item7 = 155, item8 = 162;

        
        private void chkCreamy_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCreamy.Checked)
            {
                nuD1.Enabled = false;
                nuD1.Value = 0;
            }
                else
                {
                    nuD1.Enabled = true;
                    nuD1.Value = 1;
                }
        }

        private void chkSalted_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSalted.Checked)
            {
                nuD2.Enabled = false;
                nuD2.Value = 0;
            }
                else
                {
                    nuD2.Enabled = true;
                    nuD2.Value = 1;
                }
        }

        private void chkVanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkVanilla.Checked)
            {
                nuD3.Enabled = false;
                nuD3.Value = 0;
            }
                else
                {
                    nuD3.Enabled = true;
                    nuD3.Value = 1;
                }
        }

        private void chkBurnt_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBurnt.Checked)
            {
                nuD4.Enabled = false;
                nuD4.Value = 0;
            }
                else
                {
                    nuD4.Enabled = true;
                    nuD4.Value = 1;
                }
        }

        private void chkHot_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkHot.Checked)
            {
                nuD5.Enabled = false;
                nuD5.Value = 0;
            }
                else
                {
                    nuD5.Enabled = true;
                    nuD5.Value = 1;
                }
        }

        private void chkIced_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkIced.Checked)
            {
                nuD6.Enabled = false;
                nuD6.Value = 0;
            }
                else
                {
                    nuD6.Enabled = true;
                    nuD6.Value = 1;
                }
        }

        private void chkGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkGreen.Checked)
            {
                nuD7.Enabled = false;
                nuD7.Value = 0;
            }
                else
                {
                    nuD7.Enabled = true;
                    nuD7.Value = 1;
                }
        }

        private void chkJava_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkJava.Checked)
            {
                nuD8.Enabled = false;
                nuD8.Value = 0;
            }
                else
                {
                    nuD8.Enabled = true;
                    nuD8.Value = 1;
                }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chkCreamy.Enabled = false;
            nuD1.Value = 0;

            chkSalted.Enabled = false;
            nuD2.Value = 0;
            
            chkVanilla.Enabled = false;
            nuD3.Value = 0;
            
            chkBurnt.Enabled = false;
            nuD4.Value = 0; 
            
            chkHot.Enabled = false;
            nuD5.Value = 0;
            
            chkIced.Enabled = false;
            nuD6.Value = 0;
            
            chkGreen.Enabled = false;
            nuD7.Value= 0;
            
            chkJava.Enabled = false; 
            nuD8.Value = 0;
            
            chkMember.Enabled = false;
            rdoDine.Enabled = false;
            rdoGO.Enabled = false;

            lblTotal.Text = "Total: ";
            lblPoints.Text = "Points: ";
        }

        int discount = 50;
        int addfee = 10;
        double pts;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            double total = 0;
            double pts = 0.03;

            if (chkCreamy.Checked)
            {
                total += item1 * (int)nuD1.Value;
            }

            if (chkSalted.Checked)
            {
                total += item2 * (int)nuD2.Value;
            }

            if (chkVanilla.Checked)
            {
                total += item3 * (int)nuD3.Value;
            }

            if (chkBurnt.Checked)
            {
                total += item4 * (int)nuD4.Value;
            }

            if (chkHot.Checked)
            {
                total += item5 * (int)nuD5.Value;
            }

            if (chkIced.Checked)
            {
                total += item6 * (int)nuD6.Value;
            }

            if (chkGreen.Checked)
            {
                total += item7 * (int)nuD7.Value;
            }

            if (chkJava.Checked)
            {
                total += item8 * (int)nuD8.Value;
            }

            if (chkMember.Checked)
            {
                if (rdoDine.Checked)
                {
                    total -= discount;
                }
                    else 
                    {
                        total -= discount;
                        total += addfee;
                    }
            }
                else
                {
                    if (rdoGO.Checked)
                    {
                    total += addfee;
                    }
                }

            if (!chkCreamy.Checked && !chkSalted.Checked && !chkVanilla.Checked && !chkBurnt.Checked &&
                !chkHot.Checked && !chkIced.Checked && !chkGreen.Checked && !chkJava.Checked)
            {
                MessageBox.Show("Bibili ka? Bibili ka?!", "Ay?! Hindi ka Bibili ng KaPe?!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                else 
                {
                    if(chkMember.Checked) 
                    {
                        if (rdoDine.Checked || rdoGO.Checked)
                        {
                            lblTotal.Text = "Total: " + total.ToString();
                            lblPoints.Text = "Points: " + (total * pts).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ano? Ober der? o Sa kabilang Bangerr?", "So, Saan tayo???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (rdoDine.Checked || rdoGO.Checked)
                        {
                            lblTotal.Text = "Total: " + total.ToString();
                            lblPoints.Text = "Points: 0";
                        }
                        else
                        {
                            MessageBox.Show("Ano? Ober der? o Sa kabilang Bangerr?", "So, Saan tayo???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
        }
    }
}
