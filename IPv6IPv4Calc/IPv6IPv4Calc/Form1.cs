using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsForms_IPCalc
{
    public partial class Form1 : Form
    {
        IPv6Calculator ipCalc;
        string ipAddress;
        int prefix;
        public Form1()
        {
            InitializeComponent();
            // Добавляем элементы в ComboBox в цикле
            for (int i = 1; i <= 128; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 8; i <= 127; i++)
            {
                comboBox_prefix_subnets.Items.Add(i);
            }
            comboBox1.SelectedItem = 64;
            comboBox_prefix_subnets.SelectedItem = 65;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ipAddress = textBox_ip.Text;
            prefix = comboBox1.SelectedIndex + 1;
            if (IPv6Calculator.IsValidIPv6Address(ipAddress))
            {
                ipCalc = new IPv6Calculator(ipAddress, prefix);
                label_compressed.Text = ipCalc.CompressedIPv6Address();
                label_expanded.Text = ipCalc.ExpandedIPv6Address();
                label_prefix.Text = ipCalc.HexSubnetMask();
                label_range_a.Text = ipCalc.NetworkAddress();
                label_range_b.Text = ipCalc.BroadcastAddress();
                label_subnet.Text = ipCalc.NumberOfHostsFormatted();
                textBox_ip.BackColor = Color.White;
            }
            else textBox_ip.BackColor = Color.LightPink;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string ipAddressString = textBox_ip.Text;
            //int prefixLength = int.Parse(comboBox1.SelectedItem.ToString());
            //int subnetCount = int.Parse(textBox_count.Text);

            //ipAddress = textBox_ip.Text;
            //prefix = comboBox1.SelectedIndex + 1;
            //ipCalc = new IPv6Calculator(ipAddress, prefix);

            //byte[] ipAddressBytes = IPv6Calculator.ParseIPv6Address(ipAddressString);
            //if (ipAddressBytes == null)
            //{
            //    MessageBox.Show("Invalid IP address.");
            //    return;
            //}

            //if (prefixLength < 0 || prefixLength > 128)
            //{
            //    MessageBox.Show("Invalid prefix length.");
            //    return;
            //}

            //if (subnetCount < 2 || Math.Pow(2, prefixLength) / subnetCount < 2)
            //{
            //    MessageBox.Show("Invalid subnet count.");
            //    return;
            //}

            ////string subnets = ipCalc.CalculateIPv6Subnets(subnetCount);

            ////richTextBox1.Text = subnets;

            string ipAddressString = textBox_ip.Text;
            int prefixLength = int.Parse(comboBox1.SelectedItem.ToString());
            int subnetCount = int.Parse(textBox_count.Text);

            ipAddress = textBox_ip.Text;
            prefix = comboBox1.SelectedIndex + 1;
            ipCalc = new IPv6Calculator(ipAddress, prefix);
            int subnetsPrefix = prefixLength + ExponentOfNextPowerOfTwo(subnetCount - 1);

            string subnets = ipCalc.GenerateSubnets(subnetsPrefix);
            richTextBox1.Text = subnets;
        }

        private void button_divide2_Click(object sender, EventArgs e)
        {
            ipAddress = textBox_ip.Text;
            prefix = comboBox1.SelectedIndex + 1;
            int subnetsPrefix = Convert.ToInt32(comboBox_prefix_subnets.SelectedItem);
            ipCalc = new IPv6Calculator(ipAddress, prefix);
            string subnets = ipCalc.GenerateSubnets(subnetsPrefix);
            //label_range_a.Text = subnetsPrefix.ToString();
            //label_range_b.Text = prefix.ToString();
            richTextBox1.Text = subnets;

        }
        public int ExponentOfNextPowerOfTwo(int number)
        {
            int power = 0;
            int result = 1;
            while (result <= number)
            {
                result *= 2;
                power++;
            }
            return power;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button_aggregate_Click(object sender, EventArgs e)
        {
            string[] networks = richTextBox2.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            IPv6Calculator calculator = new IPv6Calculator(textBox_ip.Text, Int32.Parse(comboBox1.Text));

            string supernet = calculator.AggregateNetworks(networks);
          
            textBox_network.Text = supernet;
        }

        private void label_range_b_Click(object sender, EventArgs e)
        {

        }

        private void textBox_network_TextChanged(object sender, EventArgs e)
        {

        }
    }
}