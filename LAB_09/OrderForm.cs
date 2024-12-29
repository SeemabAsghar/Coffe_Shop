using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB_09
{
    public partial class OrderForm : Form
    {
        decimal coffeePrice = 5.0m;
        decimal sandwichPrice = 7.0m;
        public OrderForm()
        {
            InitializeComponent();
            textBox1.Text = coffeePrice.ToString();
            textBox2.Text = sandwichPrice.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = CalculateTotal(checkBox1.Checked, checkBox2.Checked);
            textBox3.Text = total.ToString("C");
            MessageBox.Show("Order Placed. Total: " + total.ToString("C"));
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal newPrice))
                coffeePrice = newPrice;
        }
        private void label2_Click(object sender, EventArgs e)
        {}
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out decimal newPrice))
                sandwichPrice = newPrice;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {}
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {}
        private void label5_Click(object sender, EventArgs e)
        {}
        private void textBox3_TextChanged(object sender, EventArgs e)
        {}
        public decimal CalculateTotal(bool coffeeSelected, bool sandwichSelected)
        {
            decimal total = 0;
            if (coffeeSelected)
                total += coffeePrice;
            if (sandwichSelected)
                total += sandwichPrice;
            return total;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}