namespace WindowsForms_IPCalc
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox_network = new System.Windows.Forms.TextBox();
            this.button_aggregate = new System.Windows.Forms.Button();
            this.richTextBox_networks = new System.Windows.Forms.RichTextBox();
            this.textBox_sizes = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_local_value = new System.Windows.Forms.Label();
            this.label_local = new System.Windows.Forms.Label();
            this.label_class_value = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.label_hosts_value = new System.Windows.Forms.Label();
            this.label_hosts = new System.Windows.Forms.Label();
            this.label_broad_value = new System.Windows.Forms.Label();
            this.label_broad = new System.Windows.Forms.Label();
            this.label_net_value = new System.Windows.Forms.Label();
            this.label_net = new System.Windows.Forms.Label();
            this.label_submask_value = new System.Windows.Forms.Label();
            this.label_submask = new System.Windows.Forms.Label();
            this.label_mask = new System.Windows.Forms.Label();
            this.label_ip = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_network
            // 
            this.textBox_network.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_network.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_network.Location = new System.Drawing.Point(759, 769);
            this.textBox_network.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_network.Name = "textBox_network";
            this.textBox_network.Size = new System.Drawing.Size(594, 29);
            this.textBox_network.TabIndex = 52;
            // 
            // button_aggregate
            // 
            this.button_aggregate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_aggregate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_aggregate.ForeColor = System.Drawing.Color.Black;
            this.button_aggregate.Location = new System.Drawing.Point(1211, 821);
            this.button_aggregate.Margin = new System.Windows.Forms.Padding(6);
            this.button_aggregate.Name = "button_aggregate";
            this.button_aggregate.Size = new System.Drawing.Size(142, 34);
            this.button_aggregate.TabIndex = 51;
            this.button_aggregate.Text = "Вычислить";
            this.button_aggregate.UseVisualStyleBackColor = false;
            this.button_aggregate.Click += new System.EventHandler(this.button_aggregate_Click);
            // 
            // richTextBox_networks
            // 
            this.richTextBox_networks.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox_networks.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_networks.Location = new System.Drawing.Point(759, 504);
            this.richTextBox_networks.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox_networks.Name = "richTextBox_networks";
            this.richTextBox_networks.Size = new System.Drawing.Size(594, 231);
            this.richTextBox_networks.TabIndex = 50;
            this.richTextBox_networks.Text = "192.168.1.0/24\n192.168.0.0/24\n192.168.0.0/25";
            // 
            // textBox_sizes
            // 
            this.textBox_sizes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_sizes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_sizes.Location = new System.Drawing.Point(55, 433);
            this.textBox_sizes.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_sizes.Name = "textBox_sizes";
            this.textBox_sizes.Size = new System.Drawing.Size(335, 29);
            this.textBox_sizes.TabIndex = 48;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(57, 504);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(618, 294);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_status.Location = new System.Drawing.Point(51, 208);
            this.label_status.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 21);
            this.label_status.TabIndex = 44;
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(453, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 30;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.DisplayMember = "24";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.Location = new System.Drawing.Point(269, 64);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 28);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "24";
            // 
            // label_local_value
            // 
            this.label_local_value.AutoSize = true;
            this.label_local_value.BackColor = System.Drawing.Color.Transparent;
            this.label_local_value.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_local_value.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_local_value.Location = new System.Drawing.Point(487, 361);
            this.label_local_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_local_value.Name = "label_local_value";
            this.label_local_value.Size = new System.Drawing.Size(108, 21);
            this.label_local_value.TabIndex = 43;
            this.label_local_value.Text = "Глобальный";
            // 
            // label_local
            // 
            this.label_local.AutoSize = true;
            this.label_local.BackColor = System.Drawing.Color.Transparent;
            this.label_local.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_local.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_local.Location = new System.Drawing.Point(51, 361);
            this.label_local.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_local.Name = "label_local";
            this.label_local.Size = new System.Drawing.Size(201, 21);
            this.label_local.TabIndex = 42;
            this.label_local.Text = "Локальный/глобальный";
            // 
            // label_class_value
            // 
            this.label_class_value.AutoSize = true;
            this.label_class_value.BackColor = System.Drawing.Color.Transparent;
            this.label_class_value.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_class_value.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_class_value.Location = new System.Drawing.Point(572, 310);
            this.label_class_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_class_value.Name = "label_class_value";
            this.label_class_value.Size = new System.Drawing.Size(23, 21);
            this.label_class_value.TabIndex = 41;
            this.label_class_value.Text = "A";
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.BackColor = System.Drawing.Color.Transparent;
            this.label_class.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_class.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_class.Location = new System.Drawing.Point(51, 310);
            this.label_class.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(116, 21);
            this.label_class.TabIndex = 40;
            this.label_class.Text = "Класс адреса";
            // 
            // label_hosts_value
            // 
            this.label_hosts_value.AutoSize = true;
            this.label_hosts_value.BackColor = System.Drawing.Color.Transparent;
            this.label_hosts_value.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hosts_value.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_hosts_value.Location = new System.Drawing.Point(558, 268);
            this.label_hosts_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_hosts_value.Name = "label_hosts_value";
            this.label_hosts_value.Size = new System.Drawing.Size(37, 21);
            this.label_hosts_value.TabIndex = 39;
            this.label_hosts_value.Text = "254";
            // 
            // label_hosts
            // 
            this.label_hosts.AutoSize = true;
            this.label_hosts.BackColor = System.Drawing.Color.Transparent;
            this.label_hosts.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hosts.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_hosts.Location = new System.Drawing.Point(51, 268);
            this.label_hosts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_hosts.Name = "label_hosts";
            this.label_hosts.Size = new System.Drawing.Size(283, 21);
            this.label_hosts.TabIndex = 38;
            this.label_hosts.Text = "Максимальное количество хостов";
            // 
            // label_broad_value
            // 
            this.label_broad_value.AutoSize = true;
            this.label_broad_value.BackColor = System.Drawing.Color.Transparent;
            this.label_broad_value.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_broad_value.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_broad_value.Location = new System.Drawing.Point(480, 224);
            this.label_broad_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_broad_value.Name = "label_broad_value";
            this.label_broad_value.Size = new System.Drawing.Size(115, 21);
            this.label_broad_value.TabIndex = 37;
            this.label_broad_value.Text = "95.189.76.255";
            this.label_broad_value.Click += new System.EventHandler(this.label_broad_value_Click);
            // 
            // label_broad
            // 
            this.label_broad.AutoSize = true;
            this.label_broad.BackColor = System.Drawing.Color.Transparent;
            this.label_broad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_broad.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_broad.Location = new System.Drawing.Point(51, 224);
            this.label_broad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_broad.Name = "label_broad";
            this.label_broad.Size = new System.Drawing.Size(232, 21);
            this.label_broad.TabIndex = 36;
            this.label_broad.Text = "Широковещательный адрес";
            // 
            // label_net_value
            // 
            this.label_net_value.AutoSize = true;
            this.label_net_value.BackColor = System.Drawing.Color.Transparent;
            this.label_net_value.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_net_value.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_net_value.Location = new System.Drawing.Point(498, 180);
            this.label_net_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_net_value.Name = "label_net_value";
            this.label_net_value.Size = new System.Drawing.Size(97, 21);
            this.label_net_value.TabIndex = 35;
            this.label_net_value.Text = "95.189.76.0";
            // 
            // label_net
            // 
            this.label_net.AutoSize = true;
            this.label_net.BackColor = System.Drawing.Color.Transparent;
            this.label_net.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_net.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_net.Location = new System.Drawing.Point(53, 180);
            this.label_net.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_net.Name = "label_net";
            this.label_net.Size = new System.Drawing.Size(116, 21);
            this.label_net.TabIndex = 34;
            this.label_net.Text = "IP адрес сети";
            // 
            // label_submask_value
            // 
            this.label_submask_value.AutoSize = true;
            this.label_submask_value.BackColor = System.Drawing.Color.Transparent;
            this.label_submask_value.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_submask_value.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_submask_value.Location = new System.Drawing.Point(480, 139);
            this.label_submask_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_submask_value.Name = "label_submask_value";
            this.label_submask_value.Size = new System.Drawing.Size(115, 21);
            this.label_submask_value.TabIndex = 33;
            this.label_submask_value.Text = "255.255.255.0";
            // 
            // label_submask
            // 
            this.label_submask.AutoSize = true;
            this.label_submask.BackColor = System.Drawing.Color.Transparent;
            this.label_submask.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_submask.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_submask.Location = new System.Drawing.Point(51, 139);
            this.label_submask.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_submask.Name = "label_submask";
            this.label_submask.Size = new System.Drawing.Size(129, 21);
            this.label_submask.TabIndex = 31;
            this.label_submask.Text = "Маска подсети";
            // 
            // label_mask
            // 
            this.label_mask.AutoSize = true;
            this.label_mask.BackColor = System.Drawing.Color.Transparent;
            this.label_mask.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mask.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_mask.Location = new System.Drawing.Point(265, 32);
            this.label_mask.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_mask.Name = "label_mask";
            this.label_mask.Size = new System.Drawing.Size(60, 21);
            this.label_mask.TabIndex = 29;
            this.label_mask.Text = "Маска";
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.BackColor = System.Drawing.Color.Transparent;
            this.label_ip.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ip.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_ip.Location = new System.Drawing.Point(51, 32);
            this.label_ip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(95, 21);
            this.label_ip.TabIndex = 28;
            this.label_ip.Text = "IPv4 адрес";
            // 
            // textBox_ip
            // 
            this.textBox_ip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_ip.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ip.Location = new System.Drawing.Point(56, 64);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(201, 29);
            this.textBox_ip.TabIndex = 26;
            this.textBox_ip.Text = "51.159.210.136";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(462, 429);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 34);
            this.button2.TabIndex = 54;
            this.button2.Text = "Вычислить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_subnetting_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(759, 58);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 80);
            this.button3.TabIndex = 55;
            this.button3.Text = "Калькулятор IPv6";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1449, 982);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_network);
            this.Controls.Add(this.button_aggregate);
            this.Controls.Add(this.richTextBox_networks);
            this.Controls.Add(this.textBox_sizes);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_local_value);
            this.Controls.Add(this.label_local);
            this.Controls.Add(this.label_class_value);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.label_hosts_value);
            this.Controls.Add(this.label_hosts);
            this.Controls.Add(this.label_broad_value);
            this.Controls.Add(this.label_broad);
            this.Controls.Add(this.label_net_value);
            this.Controls.Add(this.label_net);
            this.Controls.Add(this.label_submask_value);
            this.Controls.Add(this.label_submask);
            this.Controls.Add(this.label_mask);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.textBox_ip);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_network;
        private System.Windows.Forms.Button button_aggregate;
        private System.Windows.Forms.RichTextBox richTextBox_networks;
        private System.Windows.Forms.TextBox textBox_sizes;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_local_value;
        private System.Windows.Forms.Label label_local;
        private System.Windows.Forms.Label label_class_value;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label_hosts_value;
        private System.Windows.Forms.Label label_hosts;
        private System.Windows.Forms.Label label_broad_value;
        private System.Windows.Forms.Label label_broad;
        private System.Windows.Forms.Label label_net_value;
        private System.Windows.Forms.Label label_net;
        private System.Windows.Forms.Label label_submask_value;
        private System.Windows.Forms.Label label_submask;
        private System.Windows.Forms.Label label_mask;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}