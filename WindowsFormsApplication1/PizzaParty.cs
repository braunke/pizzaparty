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
            if (boxPepperoni.Checked) toppings.Add("Pepperoni");
            if (boxSausage.Checked) toppings.Add("Sausage");
            if (boxChicken.Checked) toppings.Add("Chicken");
            if (boxOnions.Checked) toppings.Add("Onions");
            if (boxMushrooms.Checked) toppings.Add("Mushrooms");
            if (boxBlackOlives.Checked) toppings.Add("BlackOlives");

            if (boxCookie.Checked) extras.Add("Cookie");
            if (boxBrownie.Checked) extras.Add("Brownie");
            if (boxCheeseBread.Checked) extras.Add("CheeseBread");
            if (boxSoda.Checked) extras.Add("Soda");

            if (cboSize.SelectedIndex == 0)
            {
                MessageBox.Show("You must select a size", "Selection Error");
                cboSize.Focus();
            }
            else
            {
                string sizeSelected = cboSize.Text;
            }
            
            if (cboSize.Text == "Small") Subtotal += 12;
            else if (cboSize.Text == "Medium") Subtotal += 15;
            else if (cboSize.Text == "Large") Subtotal += 18;
            decimal toppingCost = .50m;
            decimal toppingPrice = (toppings.Count) * toppingCost;
            decimal extraCost = 1.5m;
            decimal extraPrice = (extras.Count) * extraCost;
            decimal otherStuff = extraPrice + toppingPrice;
            Subtotal += otherStuff;

            string order = cboSize.Text + " ";
            foreach (string top in toppings)
            {
                order += top + ", ";
            }
            
            foreach (string extra in extras)
            {
                order += extra + ", ";
            }
            lstOrderSummary.Items.Add(order);

            txtSubtotal.Text = Subtotal.ToString("c2");
            ClearSelection();
        }

   
        
      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearSelection()
        {
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
            decimal tax = Subtotal * .10775m;
            txtTax.Text = tax.ToString("c2");
            txtFinalTotal.Text = (tax + Subtotal).ToString("c2"); 
        }
    }
}
