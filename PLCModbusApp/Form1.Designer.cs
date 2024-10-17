namespace PLCModbusApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPlcIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnectAndAttack;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblPort;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPlcIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnectAndAttack = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlcIp
            // 
            this.txtPlcIp.Location = new System.Drawing.Point(120, 28);
            this.txtPlcIp.Name = "txtPlcIp";
            this.txtPlcIp.Size = new System.Drawing.Size(100, 22);
            this.txtPlcIp.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(120, 64);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 1;
            // 
            // btnConnectAndAttack
            // 
            this.btnConnectAndAttack.Location = new System.Drawing.Point(74, 104);
            this.btnConnectAndAttack.Name = "btnConnectAndAttack";
            this.btnConnectAndAttack.Size = new System.Drawing.Size(146, 33);
            this.btnConnectAndAttack.TabIndex = 2;
            this.btnConnectAndAttack.Text = "Connect & Attack";
            this.btnConnectAndAttack.UseVisualStyleBackColor = true;
            this.btnConnectAndAttack.Click += new System.EventHandler(this.btnConnectAndAttack_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(118, 176);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(29, 12);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "結果";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(60, 31);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(55, 12);
            this.lblIp.TabIndex = 4;
            this.lblIp.Text = "IP Address";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(60, 67);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(24, 12);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConnectAndAttack);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtPlcIp);
            this.Name = "Form1";
            this.Text = "模擬攻擊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
