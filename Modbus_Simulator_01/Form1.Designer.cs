namespace Test_01
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_baglantiyiKes = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.mn_yok = new System.Windows.Forms.RadioButton();
            this.mn_var = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.mj_yok = new System.Windows.Forms.RadioButton();
            this.mj_var = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sv2_hzdegil = new System.Windows.Forms.RadioButton();
            this.sv2_hazir = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sv2_pasif = new System.Windows.Forms.RadioButton();
            this.sv2_aktif = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sv1_hzdegil = new System.Windows.Forms.RadioButton();
            this.sv1_hazir = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sv1_pasif = new System.Windows.Forms.RadioButton();
            this.sv1_aktif = new System.Windows.Forms.RadioButton();
            this.bt_durdur = new System.Windows.Forms.Button();
            this.bt_baslat = new System.Windows.Forms.Button();
            this.tx_dedek_id = new System.Windows.Forms.TextBox();
            this.tx_vagon_id = new System.Windows.Forms.TextBox();
            this.tx_tren_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.occs_watchdog = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_gonder = new System.Windows.Forms.Button();
            this.occs_client_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.occs_client_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_baglan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 28);
            this.button1.TabIndex = 96;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(552, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Modbus Client Pasif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(326, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Modbus Server Pasif";
            // 
            // bt_baglantiyiKes
            // 
            this.bt_baglantiyiKes.Location = new System.Drawing.Point(622, 62);
            this.bt_baglantiyiKes.Name = "bt_baglantiyiKes";
            this.bt_baglantiyiKes.Size = new System.Drawing.Size(94, 24);
            this.bt_baglantiyiKes.TabIndex = 93;
            this.bt_baglantiyiKes.Text = "Baglantiyi Kes";
            this.bt_baglantiyiKes.UseVisualStyleBackColor = true;
            this.bt_baglantiyiKes.Click += new System.EventHandler(this.bt_baglantiyiKes_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Controls.Add(this.mn_yok);
            this.groupBox8.Controls.Add(this.mn_var);
            this.groupBox8.Location = new System.Drawing.Point(134, 221);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(90, 65);
            this.groupBox8.TabIndex = 92;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Minor Alarm";
            // 
            // mn_yok
            // 
            this.mn_yok.AutoSize = true;
            this.mn_yok.Location = new System.Drawing.Point(6, 39);
            this.mn_yok.Name = "mn_yok";
            this.mn_yok.Size = new System.Drawing.Size(44, 17);
            this.mn_yok.TabIndex = 73;
            this.mn_yok.TabStop = true;
            this.mn_yok.Text = "Yok";
            this.mn_yok.UseVisualStyleBackColor = true;
            // 
            // mn_var
            // 
            this.mn_var.AutoSize = true;
            this.mn_var.Location = new System.Drawing.Point(6, 16);
            this.mn_var.Name = "mn_var";
            this.mn_var.Size = new System.Drawing.Size(41, 17);
            this.mn_var.TabIndex = 72;
            this.mn_var.TabStop = true;
            this.mn_var.Text = "Var";
            this.mn_var.UseVisualStyleBackColor = true;
            this.mn_var.CheckedChanged += new System.EventHandler(this.sv1_aktif_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.mj_yok);
            this.groupBox7.Controls.Add(this.mj_var);
            this.groupBox7.Location = new System.Drawing.Point(19, 221);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(90, 65);
            this.groupBox7.TabIndex = 91;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Major Alarm";
            // 
            // mj_yok
            // 
            this.mj_yok.AutoSize = true;
            this.mj_yok.Location = new System.Drawing.Point(6, 38);
            this.mj_yok.Name = "mj_yok";
            this.mj_yok.Size = new System.Drawing.Size(44, 17);
            this.mj_yok.TabIndex = 71;
            this.mj_yok.TabStop = true;
            this.mj_yok.Text = "Yok";
            this.mj_yok.UseVisualStyleBackColor = true;
            // 
            // mj_var
            // 
            this.mj_var.AutoSize = true;
            this.mj_var.Location = new System.Drawing.Point(6, 16);
            this.mj_var.Name = "mj_var";
            this.mj_var.Size = new System.Drawing.Size(41, 17);
            this.mj_var.TabIndex = 70;
            this.mj_var.TabStop = true;
            this.mj_var.Text = "Var";
            this.mj_var.UseVisualStyleBackColor = true;
            this.mj_var.CheckedChanged += new System.EventHandler(this.sv1_aktif_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Location = new System.Drawing.Point(261, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(219, 107);
            this.groupBox6.TabIndex = 90;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SERVER_2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.sv2_hzdegil);
            this.groupBox3.Controls.Add(this.sv2_hazir);
            this.groupBox3.Location = new System.Drawing.Point(107, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 65);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            // 
            // sv2_hzdegil
            // 
            this.sv2_hzdegil.AutoSize = true;
            this.sv2_hzdegil.Location = new System.Drawing.Point(6, 35);
            this.sv2_hzdegil.Name = "sv2_hzdegil";
            this.sv2_hzdegil.Size = new System.Drawing.Size(79, 17);
            this.sv2_hzdegil.TabIndex = 71;
            this.sv2_hzdegil.TabStop = true;
            this.sv2_hzdegil.Text = "Hazir_Degil";
            this.sv2_hzdegil.UseVisualStyleBackColor = true;
            // 
            // sv2_hazir
            // 
            this.sv2_hazir.AutoSize = true;
            this.sv2_hazir.Location = new System.Drawing.Point(6, 12);
            this.sv2_hazir.Name = "sv2_hazir";
            this.sv2_hazir.Size = new System.Drawing.Size(49, 17);
            this.sv2_hazir.TabIndex = 70;
            this.sv2_hazir.TabStop = true;
            this.sv2_hazir.Text = "Hazir";
            this.sv2_hazir.UseVisualStyleBackColor = true;
            this.sv2_hazir.CheckedChanged += new System.EventHandler(this.sv1_aktif_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.sv2_pasif);
            this.groupBox4.Controls.Add(this.sv2_aktif);
            this.groupBox4.Location = new System.Drawing.Point(11, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(90, 65);
            this.groupBox4.TabIndex = 69;
            this.groupBox4.TabStop = false;
            // 
            // sv2_pasif
            // 
            this.sv2_pasif.AutoSize = true;
            this.sv2_pasif.Location = new System.Drawing.Point(5, 36);
            this.sv2_pasif.Name = "sv2_pasif";
            this.sv2_pasif.Size = new System.Drawing.Size(48, 17);
            this.sv2_pasif.TabIndex = 70;
            this.sv2_pasif.TabStop = true;
            this.sv2_pasif.Text = "Pasif";
            this.sv2_pasif.UseVisualStyleBackColor = true;
            // 
            // sv2_aktif
            // 
            this.sv2_aktif.AutoSize = true;
            this.sv2_aktif.Location = new System.Drawing.Point(5, 12);
            this.sv2_aktif.Name = "sv2_aktif";
            this.sv2_aktif.Size = new System.Drawing.Size(46, 17);
            this.sv2_aktif.TabIndex = 69;
            this.sv2_aktif.TabStop = true;
            this.sv2_aktif.Text = "Aktif";
            this.sv2_aktif.UseVisualStyleBackColor = true;
            this.sv2_aktif.CheckedChanged += new System.EventHandler(this.sv1_aktif_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Location = new System.Drawing.Point(17, 101);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(219, 107);
            this.groupBox5.TabIndex = 89;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SERVER_1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.sv1_hzdegil);
            this.groupBox2.Controls.Add(this.sv1_hazir);
            this.groupBox2.Location = new System.Drawing.Point(112, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 65);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            // 
            // sv1_hzdegil
            // 
            this.sv1_hzdegil.AutoSize = true;
            this.sv1_hzdegil.Location = new System.Drawing.Point(6, 36);
            this.sv1_hzdegil.Name = "sv1_hzdegil";
            this.sv1_hzdegil.Size = new System.Drawing.Size(79, 17);
            this.sv1_hzdegil.TabIndex = 71;
            this.sv1_hzdegil.TabStop = true;
            this.sv1_hzdegil.Text = "Hazir_Degil";
            this.sv1_hzdegil.UseVisualStyleBackColor = true;
            // 
            // sv1_hazir
            // 
            this.sv1_hazir.AutoSize = true;
            this.sv1_hazir.Location = new System.Drawing.Point(6, 13);
            this.sv1_hazir.Name = "sv1_hazir";
            this.sv1_hazir.Size = new System.Drawing.Size(49, 17);
            this.sv1_hazir.TabIndex = 70;
            this.sv1_hazir.TabStop = true;
            this.sv1_hazir.Text = "Hazir";
            this.sv1_hazir.UseVisualStyleBackColor = true;
            this.sv1_hazir.CheckedChanged += new System.EventHandler(this.sv1_aktif_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.sv1_pasif);
            this.groupBox1.Controls.Add(this.sv1_aktif);
            this.groupBox1.Location = new System.Drawing.Point(11, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 65);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // sv1_pasif
            // 
            this.sv1_pasif.AutoSize = true;
            this.sv1_pasif.Location = new System.Drawing.Point(5, 35);
            this.sv1_pasif.Name = "sv1_pasif";
            this.sv1_pasif.Size = new System.Drawing.Size(48, 17);
            this.sv1_pasif.TabIndex = 70;
            this.sv1_pasif.TabStop = true;
            this.sv1_pasif.Text = "Pasif";
            this.sv1_pasif.UseVisualStyleBackColor = true;
            // 
            // sv1_aktif
            // 
            this.sv1_aktif.AutoSize = true;
            this.sv1_aktif.Location = new System.Drawing.Point(5, 12);
            this.sv1_aktif.Name = "sv1_aktif";
            this.sv1_aktif.Size = new System.Drawing.Size(46, 17);
            this.sv1_aktif.TabIndex = 69;
            this.sv1_aktif.TabStop = true;
            this.sv1_aktif.Text = "Aktif";
            this.sv1_aktif.UseVisualStyleBackColor = true;
            this.sv1_aktif.CheckedChanged += new System.EventHandler(this.sv1_aktif_CheckedChanged);
            // 
            // bt_durdur
            // 
            this.bt_durdur.Location = new System.Drawing.Point(176, 21);
            this.bt_durdur.Name = "bt_durdur";
            this.bt_durdur.Size = new System.Drawing.Size(144, 33);
            this.bt_durdur.TabIndex = 88;
            this.bt_durdur.Text = "Modbus Server\' i Durdur";
            this.bt_durdur.UseVisualStyleBackColor = true;
            this.bt_durdur.Click += new System.EventHandler(this.bt_durdur_Click);
            // 
            // bt_baslat
            // 
            this.bt_baslat.Location = new System.Drawing.Point(16, 21);
            this.bt_baslat.Name = "bt_baslat";
            this.bt_baslat.Size = new System.Drawing.Size(144, 33);
            this.bt_baslat.TabIndex = 87;
            this.bt_baslat.Text = "Modbus Server\' i Baslat";
            this.bt_baslat.UseVisualStyleBackColor = true;
            this.bt_baslat.Click += new System.EventHandler(this.bt_baslat_Click);
            // 
            // tx_dedek_id
            // 
            this.tx_dedek_id.BackColor = System.Drawing.SystemColors.Window;
            this.tx_dedek_id.Location = new System.Drawing.Point(335, 270);
            this.tx_dedek_id.Name = "tx_dedek_id";
            this.tx_dedek_id.Size = new System.Drawing.Size(100, 20);
            this.tx_dedek_id.TabIndex = 86;
            // 
            // tx_vagon_id
            // 
            this.tx_vagon_id.BackColor = System.Drawing.SystemColors.Window;
            this.tx_vagon_id.Location = new System.Drawing.Point(335, 243);
            this.tx_vagon_id.Name = "tx_vagon_id";
            this.tx_vagon_id.Size = new System.Drawing.Size(100, 20);
            this.tx_vagon_id.TabIndex = 85;
            // 
            // tx_tren_id
            // 
            this.tx_tren_id.BackColor = System.Drawing.SystemColors.Window;
            this.tx_tren_id.Location = new System.Drawing.Point(335, 213);
            this.tx_tren_id.Name = "tx_tren_id";
            this.tx_tren_id.Size = new System.Drawing.Size(100, 20);
            this.tx_tren_id.TabIndex = 84;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "Dedektor ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 82;
            this.label11.Text = "Vagon ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Tren ID";
            // 
            // occs_watchdog
            // 
            this.occs_watchdog.BackColor = System.Drawing.SystemColors.Window;
            this.occs_watchdog.Enabled = false;
            this.occs_watchdog.Location = new System.Drawing.Point(74, 66);
            this.occs_watchdog.Name = "occs_watchdog";
            this.occs_watchdog.Size = new System.Drawing.Size(100, 20);
            this.occs_watchdog.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Watchdog:";
            // 
            // bt_gonder
            // 
            this.bt_gonder.Location = new System.Drawing.Point(474, 213);
            this.bt_gonder.Name = "bt_gonder";
            this.bt_gonder.Size = new System.Drawing.Size(144, 37);
            this.bt_gonder.TabIndex = 78;
            this.bt_gonder.Text = "Modbus Server\' a Gonder";
            this.bt_gonder.UseVisualStyleBackColor = true;
            this.bt_gonder.Click += new System.EventHandler(this.bt_gonder_Click);
            // 
            // occs_client_port
            // 
            this.occs_client_port.Enabled = false;
            this.occs_client_port.Location = new System.Drawing.Point(716, 28);
            this.occs_client_port.Name = "occs_client_port";
            this.occs_client_port.Size = new System.Drawing.Size(41, 20);
            this.occs_client_port.TabIndex = 77;
            this.occs_client_port.Text = "502";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Port:";
            // 
            // occs_client_ip
            // 
            this.occs_client_ip.Location = new System.Drawing.Point(579, 28);
            this.occs_client_ip.Name = "occs_client_ip";
            this.occs_client_ip.Size = new System.Drawing.Size(100, 20);
            this.occs_client_ip.TabIndex = 75;
            this.occs_client_ip.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Modbus Server IP:";
            // 
            // bt_baglan
            // 
            this.bt_baglan.Location = new System.Drawing.Point(487, 62);
            this.bt_baglan.Name = "bt_baglan";
            this.bt_baglan.Size = new System.Drawing.Size(92, 24);
            this.bt_baglan.TabIndex = 73;
            this.bt_baglan.Text = "Baglan";
            this.bt_baglan.UseVisualStyleBackColor = true;
            this.bt_baglan.Click += new System.EventHandler(this.bt_baglan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(655, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 97;
            this.label5.Text = "Copyright © 2020 by SEGU ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(487, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 98;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(616, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "READ_HOLD_20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(619, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "READ_BOOL_0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_baglantiyiKes);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.bt_durdur);
            this.Controls.Add(this.bt_baslat);
            this.Controls.Add(this.tx_dedek_id);
            this.Controls.Add(this.tx_vagon_id);
            this.Controls.Add(this.tx_tren_id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.occs_watchdog);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_gonder);
            this.Controls.Add(this.occs_client_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.occs_client_ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_baglan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_baglantiyiKes;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton mn_yok;
        private System.Windows.Forms.RadioButton mn_var;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton mj_yok;
        private System.Windows.Forms.RadioButton mj_var;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton sv2_hzdegil;
        private System.Windows.Forms.RadioButton sv2_hazir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton sv2_pasif;
        private System.Windows.Forms.RadioButton sv2_aktif;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sv1_hzdegil;
        private System.Windows.Forms.RadioButton sv1_hazir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sv1_pasif;
        private System.Windows.Forms.RadioButton sv1_aktif;
        private System.Windows.Forms.Button bt_durdur;
        private System.Windows.Forms.Button bt_baslat;
        private System.Windows.Forms.TextBox tx_dedek_id;
        private System.Windows.Forms.TextBox tx_vagon_id;
        private System.Windows.Forms.TextBox tx_tren_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox occs_watchdog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_gonder;
        private System.Windows.Forms.TextBox occs_client_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox occs_client_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_baglan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

