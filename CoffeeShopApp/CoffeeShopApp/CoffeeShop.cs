using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (nameTextBox.Text == "" || contactTextBox.Text == "" || addressTextBox.Text == "" || orderComboBox.Text == "" ||
                quantityTextBox.Text == "")
            {
                MessageBox.Show("Please fill every field");
            }
            else
            {
                int price;
                string name = nameTextBox.Text;
                string contact = contactTextBox.Text;
                string address = addressTextBox.Text;
                int quantity = Convert.ToInt32(quantityTextBox.Text);
                string order = orderComboBox.Text;
                if (orderComboBox.Text == "Black")
                    price = 120;
                else if (orderComboBox.Text == "Cold")
                    price = 100;
                else if (orderComboBox.Text == "Hot")
                    price = 90;
                else
                    price = 80;

                string message = "\t\tPurchase Information\n\n\n";
                message = message + "\t\t\tInvoice\n\n";
                message = message + "Customer Name \t: " + name + "\n";
                message = message + "Contact No \t\t: " + contact + "\n";
                message = message + "Address \t\t: " + address + "\n";
                message = message + "Coffee ordered \t: " + order + "\n";
                message = message + "Price per item \t\t: " + price + "\n";
                message = message + "Quantity \t\t: " + quantity + "\n\n";

                message = message + name + " sir, you have to pay " + price*quantity + " Taka";




                MessageBox.Show("Purchase successful.");
                purchaseInformationRichTextBox.Text = message;
            }
        }
    }
}
