using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;
using System.IO;

namespace BitMobile
{
    using StoreDataService;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < availablePlansListBox.Items.Count; i++)
            {
                planRegisterCustomerComboBox.Items.Add(availablePlansListBox.Items[i]);
            }

            //var storeDataService = new StoreDataService.StoreDataQuery();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            planNameExistingPlanTextBox.Text = "iPhone 5 $49 Cap";
            payoutFigureExistingPlanTextBox.Text = "$" + (49 * 12);
            endDateExistingPlanTextBox.Text = "October 2013";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            planNameExistingPlanTextBox.Text = null;
            payoutFigureExistingPlanTextBox.Text = null;
            endDateExistingPlanTextBox.Text = null;
            firstNameExistingPlanTextBox.Text = null;
            surnameExistingPlanTextBox.Text = null;
            companyComboBox.Text = null;
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstNameRegisterCustomerTextBox.Text = null;
            surnameRegisterCustomerTextBox.Text = null;
            streetAddressRegisterCustomerTextBox.Text = null;
            suburbRegisterCustomerTextBox.Text = null;
            postcodeRegisterCustomerTextBox.Text = null;
            emailRegisterCustomerTextBox.Text = null;
            contactNumberRegisterCustomerTextBox.Text = null;
            stateRegisterCustomerComboBox.Text = null;
            planRegisterCustomerComboBox.Text = null;
            transferNumberRegisterCustomerComboBox.Text = null;
            existingPlanRegisterCustomerCheckBox.Checked = false;
         }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            phoneModelPlaceOrderComboBox.Text = null;
            phoneModelLocalStockComboBox.Text = null;
            quantityPlaceOrderTextBox.Text = null;
            deliveryTimeTextBox.Text = null;
            quantityLocalStockTextBox.Text = null;
        }
    }
}
