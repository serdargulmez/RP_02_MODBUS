using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace Test_01
{
    public partial class Form1 : Form
    {
        EasyModbus.ModbusServer modbusServer;
        EasyModbus.ModbusClient modbusClient;
        int syc = 1;
        int glb_1_ex = 0x0;
        bool keyCont = false;   // test edilecek. Tekrar olacak.
        bool adr =  false;


        public Form1()
        {
            InitializeComponent();
            modbusServerStart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sv1_pasif.Checked = true;
            sv1_hzdegil.Checked = true;
            sv2_pasif.Checked = true;
            sv2_hzdegil.Checked = true;
            occs_watchdog.Text = "0";
            mj_yok.Checked = true;
            mn_yok.Checked = true;
            tx_tren_id.Text = "0";
            tx_vagon_id.Text = "0";
            tx_dedek_id.Text = "0";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Server IP adresini enter tuşuna basarak giriniz.");
        }


        public void modbusServerStart()
        {
            modbusServer = new EasyModbus.ModbusServer();
        }

        private void bt_baslat_Click(object sender, EventArgs e)
        {
            modbusServer.Listen();
            label3.Text = "Modbus Server Aktif";
            label3.ForeColor = Color.Green;
        }

        private void bt_durdur_Click(object sender, EventArgs e)
        {
            modbusServer.StopListening();
            label3.Text = "Modbus Server Pasif";
            label3.ForeColor = Color.Red;
        }

        private void occs_client_ip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                modbusClient = new EasyModbus.ModbusClient(occs_client_ip.Text, 502);
                occs_client_ip.Enabled = false;
            }

        }

        private void bt_baglan_Click(object sender, EventArgs e)
        {
            modbusClient.Connect();

            if (modbusClient.Connected == true)
            {
                label4.Text = "Modbus Client Aktif";
                label4.ForeColor = Color.Green;
                timer1.Interval = 1000;
                timer1.Enabled = true;
                

            }

        }

        private void bt_baglantiyiKes_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            label4.Text = "Modbus Client Pasif";
            label4.ForeColor = Color.Red;
            timer1.Enabled = false;
            syc = 1;
            occs_client_ip.Enabled = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (syc == 11) syc = 1;
            if (modbusClient.Connected == true && syc <= 10)
            {
                modbusClient.WriteSingleRegister(1, syc);
                occs_watchdog.Text = Convert.ToString(syc);
                syc++;
            }

            timer1.Enabled = true;
        }

        private void sv1_aktif_CheckedChanged(object sender, EventArgs e)
        {
            glb_1_ex = 0x0;
            if (modbusClient.Connected == true)
            {
                if (sv1_aktif.Checked == true) glb_1_ex = glb_1_ex + 0x1; else glb_1_ex = glb_1_ex + 0x0;
                if (sv1_hazir.Checked == true) glb_1_ex = glb_1_ex + 0x2; else glb_1_ex = glb_1_ex + 0x0;

                if (sv2_aktif.Checked == true) glb_1_ex = glb_1_ex + 0x4; else glb_1_ex = glb_1_ex + 0x0;
                if (sv2_hazir.Checked == true) glb_1_ex = glb_1_ex + 0x8; else glb_1_ex = glb_1_ex + 0x0;

                modbusClient.WriteSingleRegister(0, glb_1_ex);

                if (mj_var.Checked == true)
                {
                    modbusClient.WriteSingleRegister(2, 1);
                }
                else
                    modbusClient.WriteSingleRegister(2, 0);

                if (mn_var.Checked == true)
                {
                    modbusClient.WriteSingleRegister(3, 1);
                }
                else
                    modbusClient.WriteSingleRegister(3, 0);
            }
            else
                return;

        }

        private void bt_gonder_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected == true)
            {
                int tr_ID, vg_ID, de_ID;

                tr_ID = Convert.ToInt16(tx_tren_id.Text);
                vg_ID = Convert.ToInt16(tx_vagon_id.Text);
                de_ID = Convert.ToInt16(tx_dedek_id.Text);

                modbusClient.WriteSingleRegister(10, tr_ID);
                modbusClient.WriteSingleRegister(11, vg_ID);
                modbusClient.WriteSingleRegister(12, de_ID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_tren_id.Text = "0";
            tx_vagon_id.Text = "0";
            tx_dedek_id.Text = "0";

        }
    }
}
