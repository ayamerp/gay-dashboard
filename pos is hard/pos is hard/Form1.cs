using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_is_hard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Cost_of_Products()
        {
            double sum = 0;
            int i = 0; // For loop 
            for (i = 0; i < (dataGridView1.Rows.Count);
            i++)
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }

        private void AddCost()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                textBox5.Text = String.Format("{0:c2}", (Cost_of_Products()));
            }

        }

        private void Change()
        {
            Double q, c;
            if (dataGridView1.Rows.Count > 0)
            {
                q = Cost_of_Products();
                c = Convert.ToInt32(textBox3.Text);
                textBox4.Text = String.Format("{0:c2}", c - q);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
                AddCost();
            }      
        }

        private void button26_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            AddCost();
            Change();
        }

        private void brgerbtn_Click(object sender, EventArgs e)
        {
            Double CostofProduct = 120;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Burger"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofProduct;
                }
            }
            dataGridView1.Rows.Add("Burger", "1", CostofProduct);
            AddCost();
        }

        private void CashCost(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox3.Text == "0")
            {
                textBox3.Text = "";
                textBox3.Text = b.Text;
            }
            else if (b.Text == ".")
            {
                if (! textBox3.Text.Contains("."))
                {
                    textBox3.Text = textBox3.Text + b.Text;
                }
                    
            }
            else
                textBox3.Text = textBox3.Text + b.Text;
        } // Numeric Pad

        private void button22_Click(object sender, EventArgs e) // Clear button numeric pad
        {
            textBox3.Text = "0";
            Change();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Change();
            button24.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;

        } // Enter payment

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button23.Enabled = true;
        } // Enabling Compute Change button

        private void button24_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double CostofProduct = 200;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Double Cheese Burger"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofProduct;
                }
            }
            dataGridView1.Rows.Add("Double Cheese Burger", "1", CostofProduct);
            AddCost();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double CostofProduct = 150;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Chicken Burger"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofProduct;
                }
            }
            dataGridView1.Rows.Add("Chicken Burger", "1", CostofProduct);
            AddCost();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double CostofProduct = 200;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Bacon Cheese Burger"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofProduct;
                }
            }
            dataGridView1.Rows.Add("Bacon Cheese Burger", "1", CostofProduct);
            AddCost();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Double CostofProduct = 130;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "1 Pc Chicken"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofProduct;
                }
            }
            dataGridView1.Rows.Add("1 Pc Chicken", "1", CostofProduct);
            AddCost();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Double CostofProduct = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "2 Pc Chicken"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofProduct;
                }
            }
            dataGridView1.Rows.Add("2 Pc Chicken", "1", CostofProduct);
            AddCost();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Double CostofProduct = 350;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "1 Bucket Chicken"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofProduct;
                }
            }
            dataGridView1.Rows.Add("1 Bucket Chicken", "1", CostofProduct);
            AddCost();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Double CostofProduct = 60;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Coke"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofProduct;
                }
            }
            dataGridView1.Rows.Add("Coke", "1", CostofProduct);
            AddCost();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Double CostofProduct = 60;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sprite"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofProduct;
                }
            }
            dataGridView1.Rows.Add("Sprite", "1", CostofProduct);
            AddCost();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Double CostofProduct = 60;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Fanta"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofProduct;
                }
            }
            dataGridView1.Rows.Add("Fanta", "1", CostofProduct);
            AddCost();
        }
    }  
}
