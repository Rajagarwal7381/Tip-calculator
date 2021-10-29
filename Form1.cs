using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        // Check Null Value
            if (txttip.Text.Trim() != null && txttip.Text.Trim() != "")
            {
                double rmvper = rmvpr(txttip.Text.Trim());
               
                    txttip.Text = (Convert.ToInt32(rmvper) + 1).ToString() + "%";
            }
            calculate(txttip.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
        // Check Null Value
            if (txttip.Text.Trim() != null && txttip.Text.Trim() != "")
            {
                double rmvper = rmvpr(txttip.Text.Trim());
                if(rmvper!=0)
                txttip.Text = (Convert.ToInt32(rmvper) - 1).ToString()+"%";
            }
            calculate(txttip.Text.Trim());
        }
        private double rmvpr(string str)
        {
            char c = str.Last();
            string tips = txttip.Text.Trim();
            if (c == '%')
            {
                str = str.Remove(str.Length - 1);
            }
            return Convert.ToDouble(str);
        }
        // To Calculate Tip per person Doller 
        private double tpp(double bill, double tip, double ppl)
        {
            double res = bill * tip / 100;
            res = res / ppl;
            lbltip.Text = "$"+res.ToString("0.00");
            return res;
        }
        // To Calculate Total per person Doller 
        private void totalp(double bill, double tip, double tpper)
        {
            double tepp = tpp(bill, tip, tpper);
            double res = bill / tpper;
            res = res + tepp;

            lbltotal.Text = "$"+res.ToString("0.00");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculate(txtbill.Text.Trim());
        }
        private void calculate(string txtstr)
        {
        // To handle Exception
            try
            {
                if (txtstr != null && txtstr != "")
                {
                    double bill = Convert.ToDouble(txtbill.Text.Trim());
                    double ppl = Convert.ToDouble(txtppl.Text.Trim());
                    string tip = txttip.Text.Trim();
                    double tp = rmvpr(tip);
                     // To Calculate Tip per person Doller
                    tpp(bill, tp, ppl);
                    // To Calculate per person Doller 
                    totalp(bill, tp, ppl);
                }
            }
            catch (Exception ex)
            {
            // To Show Message
                MessageBox.Show("Something went wrong! please try again later...");
     
            }
        }
        private void txtppl_TextChanged(object sender, EventArgs e)
        {
            calculate(txtppl.Text.Trim());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtppl.Text.Trim() != null && txtppl.Text.Trim() != "" && txtppl.Text.Trim() != "1")
                {
                    txtppl.Text = (Convert.ToInt32(txtppl.Text.Trim()) - 1).ToString();
                }
                calculate(txtppl.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! please try again later...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtppl.Text.Trim() != null && txtppl.Text.Trim() != "")
                {
                    txtppl.Text = (Convert.ToInt32(txtppl.Text.Trim()) + 1).ToString();
                }
                calculate(txtppl.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! please try again later...");

            }
        }

        private void txttip_TextChanged(object sender, EventArgs e)
        {
            calculate(txttip.Text.Trim());
        }
    }
}
