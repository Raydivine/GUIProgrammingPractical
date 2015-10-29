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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();

        }

        private void txtQlty_TextChanged(object sender, EventArgs e)
        {
            double prize = 15.00;
            int qlty = 1;


            try
            {
                 qlty = Convert.ToInt16(txtQlty.Text);

                if(qlty<0)
                    MessageBox.Show("it is negative number");

                lblPrice.Text = "RM: " + (prize*qlty).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.ToString());
            }

          
    
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

          public class MyException : Exception
        {
              public MyException(string s)
              {

              

            }
        }

          private void txtCoupunID_TextChanged(object sender, EventArgs e)
          {
              try
              {
                  int id = Convert.ToInt32(txtCoupunID.Text);

                  if (id < 0)
                      MessageBox.Show("it is negative number");
              }
              catch (FormatException ex)
              {
                  MessageBox.Show(ex.ToString());
              }
              catch (OverflowException ex)
              {
                  MessageBox.Show(ex.ToString());
              }
          }

          private void comboPayMethod_SelectedIndexChanged(object sender, EventArgs e)
          {
              if (comboPayMethod.Items.Equals("Credit Card"))
                  txtCreditCard.Enabled = true;
          }

          private void txtCreditCard_TextChanged(object sender, EventArgs e)
          {
            
          }

          private void groupBox5_Enter(object sender, EventArgs e)
          {
             
          }

          private void btnConfirm_Click(object sender, EventArgs e)
          {
              Application.Exit(); 
          }
    }
}
