using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratical1Q2
{
    public partial class Order : Form
    {
        

        public Order()
        {
            InitializeComponent();

            double smallPizzaPrice = 11.00;
            double mediumPizzaPrice = 15.00;
            double bigPizzaPrice = 18.00;
            double price = 0;


            if (rbLarge.Checked == true)
            {
                price = bigPizzaPrice;
                lblPrice.Text = price.ToString();
            }

            else if (rbMedium.Checked == true)
            {
                price = mediumPizzaPrice;
                lblPrice.Text = price.ToString();
            }

            else if (rbSmall.Checked == true)
            {
                price = smallPizzaPrice;
                lblPrice.Text = price.ToString();
            }

            

 
                
        }

        private void button2_Click(object sender, EventArgs e)
        {  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbPizzaSize_Enter(object sender, EventArgs e)
        {

     
        }

        private void lblMsgPrice_Click(object sender, EventArgs e)
        {
         

        }
        private void Order_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Payment pay = new Payment();

            pay.Show(); 
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {

        }

   
    }
}
