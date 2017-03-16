using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class PizzaParty : Form
    {
        List<String> toppings = new List<String>();//all toppings for current pizza (remember to clear when starting new pizza)
        List<String> extras = new List<String>(); //all extras associated with current pizza (remember to clear when starting a new pizza)
        decimal Subtotal = 0;
        
        public PizzaParty()
        {
            InitializeComponent();
        }

        //on load page will have droplist of pizza sizes 
        private void frmPizzaParty_Load(object sender, EventArgs e)
        {
            string[] sizes =
                {"Select a size..." ,"Small", "Medium", "Large" };
            foreach (string size in sizes)
            {
                cboSize.Items.Add(size);
            }
            cboSize.SelectedIndex = 0;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //checks if size was chosen 
            if (IsValidChoice())
            {
                //goes through checkboxes to see which ones were selected 
                //adds them to the topping list 
                if (boxPepperoni.Checked) toppings.Add("Pepperoni");
                if (boxSausage.Checked) toppings.Add("Sausage");
                if (boxChicken.Checked) toppings.Add("Chicken");
                if (boxOnions.Checked) toppings.Add("Onions");
                if (boxMushrooms.Checked) toppings.Add("Mushrooms");
                if (boxBlackOlives.Checked) toppings.Add("Black Olives");
                //adds extras to extra list is selected 
                if (boxCookie.Checked) extras.Add("Cookie");
                if (boxBrownie.Checked) extras.Add("Brownie");
                if (boxCheeseBread.Checked) extras.Add("Cheese Bread");
                if (boxSoda.Checked) extras.Add("Soda");

                //gets the size of pizza selected 
                string sizeSelected = cboSize.Text;

                //depending on size selected adds that price to subtotal 
                if (cboSize.Text == "Small") Subtotal += 12;
                else if (cboSize.Text == "Medium") Subtotal += 15;
                else if (cboSize.Text == "Large") Subtotal += 18;
                //sets the price of one topping
                decimal toppingCost = .50m;
                //multiplies number of toppings by price 
                decimal toppingPrice = (toppings.Count) * toppingCost;
                //sets price of extras
                decimal extraCost = 1.5m;
                //multiplies number of extras by price 
                decimal extraPrice = (extras.Count) * extraCost;
                //gets the amount of toppings and extras price wise 
                decimal otherStuff = extraPrice + toppingPrice;
                //adds this to the subtotal 
                Subtotal += otherStuff;
                //creates string of order to display 
                string order = cboSize.Text + " ";
                foreach (string top in toppings)
                {
                    order += top + ", ";
                }
                //displays pizza toppings and the clears list to display extras on
                //seperate line 
                lstOrderSummary.Items.Add(order);
                order = "";
                foreach (string extra in extras)
                {
                    order += extra + ", ";
                }
                //adds it to the listbox to display order 
                lstOrderSummary.Items.Add(order);
                //displays a running subtotal 
                txtSubtotal.Text = Subtotal.ToString("c2");
                //clears selection 
                ClearSelection();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearSelection()
        {
            //clears selection when adding something new to order  
            cboSize.SelectedIndex = 0;
            boxPepperoni.Checked = false;
            boxSausage.Checked = false;
            boxChicken.Checked = false;
            boxOnions.Checked = false;
            boxMushrooms.Checked = false;
            boxBlackOlives.Checked = false;

            boxCookie.Checked = false;
            boxBrownie.Checked = false;
            boxCheeseBread.Checked = false;
            boxSoda.Checked = false;
            toppings.Clear();
            extras.Clear();
            cboSize.Focus();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //calculates tax and final total 
            decimal tax = Subtotal * .10775m;
            txtTax.Text = tax.ToString("c2");
            txtFinalTotal.Text = (tax + Subtotal).ToString("c2");
        }
        private bool IsValidChoice()
        {
            //makes sure user has selected a size 
            bool isValid = true;
            if (cboSize.SelectedIndex == 0)
            {
                MessageBox.Show("You must select a size", "Selection Error");
                cboSize.Focus();
                isValid = false;
            }
            return isValid;
         }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears out everything from you order 
            lstOrderSummary.Items.Clear();
            txtSubtotal.Text = "";
            txtFinalTotal.Text = "";
            txtTax.Text = "";
            Subtotal = 0;
        }
    }
}
