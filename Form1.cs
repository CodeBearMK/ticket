using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticket
{
    public partial class Form1 : Form
    {

        int people_count = 0;
        int people_grpcount = 0;
        double total_price = 0;
        bool isGroup = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isGroup)
            {
                if (radioButton1.Checked)
                {
                    if (people_grpcount >= 10)
                    {
                        if (checkBox3.Checked && checkBox4.Checked)
                        {
                            total_price = (120 * people_grpcount) * 0.9 + 120 * people_count;
                        }
                        else if (checkBox3.Checked)
                        {
                            total_price = (70 * people_grpcount) * 0.9 + 70 * people_count;
                        }
                        else if (checkBox4.Checked)
                        {
                            total_price = (100 * people_grpcount) * 0.9 + 100 * people_count;
                        }
                        else
                        {
                            total_price = (50 * people_grpcount) * 0.9 + 50 * people_count;
                        }
                    }
                    else
                    {
                        MessageBox.Show("團體價至少要10(含)人", "提示", MessageBoxButtons.OK);
                        if (checkBox3.Checked && checkBox4.Checked)
                        {
                            total_price = 120 * people_grpcount + 120 * people_count;
                        }
                        else if (checkBox3.Checked)
                        {
                            total_price = 70 * people_grpcount + 70 * people_count;
                        }
                        else if (checkBox4.Checked)
                        {
                            total_price = 100 * people_grpcount + 100 * people_count;
                        }
                        else
                        {
                            total_price = 50 * people_grpcount + 50 * people_count;
                        }
                    }
                    
                }
                else if (radioButton2.Checked)
                {
                    if (people_grpcount >= 10)
                    {
                        if (checkBox3.Checked && checkBox4.Checked)
                        {
                            total_price = (160 * people_grpcount) * 0.9 + 160 * people_count;
                        }
                        else if (checkBox3.Checked)
                        {
                            total_price = (110 * people_grpcount) * 0.9 + 110 * people_count;
                        }
                        else if (checkBox4.Checked)
                        {
                            total_price = (140 * people_grpcount) * 0.9 + 140 * people_count;
                        }
                        else
                        {
                            total_price = (90 * people_grpcount) * 0.9 + 90 * people_count;
                        }
                    }
                    else
                    {
                        MessageBox.Show("團體價至少要10(含)人", "提示", MessageBoxButtons.OK);
                        if (checkBox3.Checked && checkBox4.Checked)
                        {
                            total_price = 160 * people_grpcount + 160 * people_count;
                        }
                        else if (checkBox3.Checked)
                        {
                            total_price = 110 * people_grpcount + 110 * people_count;
                        }
                        else if (checkBox4.Checked)
                        {
                            total_price = 140 * people_grpcount + 140 * people_count;
                        }
                        else
                        {
                            total_price = 90 * people_grpcount + 90 * people_count;
                        }
                    }
                }
            }
            else
            {
                if (radioButton1.Checked)
                {
                    if (checkBox3.Checked && checkBox4.Checked)
                    {
                        total_price = 120 * people_count;
                    }
                    else if (checkBox3.Checked)
                    {
                        total_price = 70 * people_count;
                    }
                    else if (checkBox4.Checked)
                    {
                        total_price = 100 * people_count;
                    }
                    else
                    {
                        total_price = 50 * people_count;
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (checkBox3.Checked && checkBox4.Checked)
                    {
                        total_price = 160 * people_count;
                    }
                    else if (checkBox3.Checked)
                    {
                        total_price = 110 * people_count;
                    }
                    else if (checkBox4.Checked)
                    {
                        total_price = 140 * people_count;
                    }
                    else
                    {
                        total_price = 90 * people_count;
                    }
                }
            }
            label2.Text = "總計： " + total_price.ToString() + " 元";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            people_count = 0;
            people_grpcount = 0;
            total_price = 0;
            isGroup = false;
            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox1.Text = "";
            textBox1.Enabled = false;
            label2.Text = "";
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("星期日只能訂一日券", "提示", MessageBoxButtons.OK);
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Monday)
            {
                MessageBox.Show("星期一休館不能訂票", "提示", MessageBoxButtons.OK);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { 
                radioButton3.Checked = true;
            }
            else
            {
                people_count = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Enabled = true;
                textBox1.Text = Convert.ToString(12);
                people_grpcount = Convert.ToInt32(textBox1.Text);
                isGroup = true;
            }
            else
            {
                textBox1.Text = "";
                textBox1.Enabled = false;
                people_grpcount = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                people_count = 1;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                people_count = 2;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                people_count = 3;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                people_count = 4;
            }
        }
    }
}
