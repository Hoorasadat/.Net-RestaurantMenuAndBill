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
        double hamburgerAddOnPrice = 0.75;
        double pizzaPrice = 5.95;
        double pizzaAddOnPrice = 0.5;
        double saladPrice = 4.95;
        double saladAddOnPrice = 0.25;


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

        // function for placing the order - event handler for "place order" button:
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // calculate the cost for order based on the selected radio button
            totalCost = 0;

            if (rdbHamburger.Checked)
            {
                totalCost += hamburgerPrice;

                if (chbxLettuce.Checked)
                    totalCost += hamburgerAddOnPrice;

                if (chbxKetchup.Checked)
                    totalCost += hamburgerAddOnPrice;

                if (chbxFries.Checked)
                    totalCost += hamburgerAddOnPrice;

            }

            if (rdbPizza.Checked)
            {
                totalCost += pizzaPrice;

                if (chbxPepperoni.Checked)
                    totalCost += pizzaAddOnPrice;

                if (chbxSausage.Checked)
                    totalCost += pizzaAddOnPrice;

                if (chbxOlives.Checked)
                    totalCost += pizzaAddOnPrice;
            }

            if (rdbSalad.Checked)
            {
                totalCost += saladPrice;

                if (chbxCrouton.Checked)
                    totalCost += saladAddOnPrice;

                if (chbxBacon.Checked)
                    totalCost += saladAddOnPrice;

                if (chbxBread.Checked)
                    totalCost += saladAddOnPrice;
            }

            // calculate and show the subtotal, tax, and total cost
            txbSubtotal.Text = totalCost.ToString();
            txbTax.Text = Math.Round(totalCost * taxRate, 2).ToString();
            txbTotal.Text = Math.Round(totalCost * (1+ taxRate), 2).ToString();
        }

        // functions for showing/ hiding related add-on for each item in the menue:

        // event handler for selecting the first item in the menue:
        private void rdbHamburger_CheckedChanged(object sender, EventArgs e)
        {
            resetTxtBoxes();
            resetChkBoxes();

            if (rdbHamburger.Checked)
            {
                gbxHamburger.Show();
                gbxPizza.Hide();
                gbxSalad.Hide();
            }
        }

        // event handler for selecting the second item in the menue:
        private void rdbPizza_CheckedChanged(object sender, EventArgs e)
        {
            resetTxtBoxes();
            resetChkBoxes();

            if (rdbPizza.Checked)
            {
                gbxHamburger.Hide();
                gbxPizza.Show();
                gbxSalad.Hide();
            }
        }

        
        // event handler for selecting the third item in the menue:
        private void rdbSalad_CheckedChanged(object sender, EventArgs e)
        {
            resetTxtBoxes();
            resetChkBoxes();

            if (rdbSalad.Checked)
            {
                gbxHamburger.Hide();
                gbxPizza.Hide();
                gbxSalad.Show();
            }
        }


        // function for reseting the order - event handler for "reset" button:
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetTxtBoxes();
            resetChkBoxes();
        }


        // function for exiting the order - event handler for "exit" button:
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Environment.Exit(0);
        }

        private void resetTxtBoxes()
        {
            txbSubtotal.Text = "";
            txbTax.Text = "";
            txbTotal.Text = "";
        }

        private void resetChkBoxes()
        {
            chbxLettuce.Checked = false;
            chbxKetchup.Checked = false;
            chbxFries.Checked = false;

            chbxPepperoni.Checked = false;
            chbxSausage.Checked = false;
            chbxOlives.Checked = false;

            chbxCrouton.Checked = false;
            chbxBacon.Checked = false;
            chbxBread.Checked = false;
        }
    }
}
