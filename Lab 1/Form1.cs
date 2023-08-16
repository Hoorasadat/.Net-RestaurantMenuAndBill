using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        double totalCost = 0;
        double taxRate = 0.05;
        double hamburgerPrice = 6.95;
        double pizzaPrice = 5.95;
        double saladPrice = 4.95;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbHamburger.Checked = true;
            gbxHamburger.Show();
            gbxPizza.Hide();
            gbxSalad.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            totalCost = 0;

            if (rdbHamburger.Checked)
                totalCost += hamburgerPrice;
            if (rdbPizza.Checked)
                totalCost += pizzaPrice;
            if (rdbSalad.Checked)
                totalCost += saladPrice;

            txbSubtotal.Text = totalCost.ToString();
            txbTax.Text = Math.Round(totalCost * taxRate, 2).ToString();
            txbTotal.Text = Math.Round(totalCost * (1+ taxRate), 2).ToString();
        }

        private void rdbHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHamburger.Checked)
            {
                gbxHamburger.Show();
                gbxPizza.Hide();
                gbxSalad.Hide();
            }
        }

        private void rdbPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPizza.Checked)
            {
                gbxHamburger.Hide();
                gbxPizza.Show();
                gbxSalad.Hide();
            }
        }

        private void rdbSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSalad.Checked)
            {
                gbxHamburger.Hide();
                gbxPizza.Hide();
                gbxSalad.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbSubtotal.Text = "";
            txbTax.Text = "";
            txbTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Environment.Exit(0);
        }
    }
}
