
namespace Projet_GRX_RxTx_Hedia_CSharp
{
    partial class EcranPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LB_serial = new System.Windows.Forms.Label();
            this.GB_Envoi = new System.Windows.Forms.GroupBox();
            this.GB_Reception = new System.Windows.Forms.GroupBox();
            this.CB_serialport = new System.Windows.Forms.ComboBox();
            this.B_valider = new System.Windows.Forms.Button();
            this.TB_bauds = new System.Windows.Forms.TextBox();
            this.LB_bauds = new System.Windows.Forms.Label();
            this.B_envoi = new System.Windows.Forms.Button();
            this.B_clear = new System.Windows.Forms.Button();
            this.TB_TX = new System.Windows.Forms.TextBox();
            this.TB_RX = new System.Windows.Forms.TextBox();
            this.B_close = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.GB_Envoi.SuspendLayout();
            this.GB_Reception.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_serial
            // 
            this.LB_serial.AutoSize = true;
            this.LB_serial.Location = new System.Drawing.Point(12, 9);
            this.LB_serial.Name = "LB_serial";
            this.LB_serial.Size = new System.Drawing.Size(60, 13);
            this.LB_serial.TabIndex = 0;
            this.LB_serial.Text = "Serial port :";
            // 
            // GB_Envoi
            // 
            this.GB_Envoi.Controls.Add(this.TB_TX);
            this.GB_Envoi.Location = new System.Drawing.Point(12, 37);
            this.GB_Envoi.Name = "GB_Envoi";
            this.GB_Envoi.Size = new System.Drawing.Size(175, 100);
            this.GB_Envoi.TabIndex = 1;
            this.GB_Envoi.TabStop = false;
            this.GB_Envoi.Text = "Envoi (TX)";
            // 
            // GB_Reception
            // 
            this.GB_Reception.Controls.Add(this.TB_RX);
            this.GB_Reception.Location = new System.Drawing.Point(12, 149);
            this.GB_Reception.Name = "GB_Reception";
            this.GB_Reception.Size = new System.Drawing.Size(175, 100);
            this.GB_Reception.TabIndex = 2;
            this.GB_Reception.TabStop = false;
            this.GB_Reception.Text = "Reception (RX)";
            // 
            // CB_serialport
            // 
            this.CB_serialport.FormattingEnabled = true;
            this.CB_serialport.Location = new System.Drawing.Point(78, 6);
            this.CB_serialport.Name = "CB_serialport";
            this.CB_serialport.Size = new System.Drawing.Size(140, 21);
            this.CB_serialport.TabIndex = 3;
            this.CB_serialport.SelectedIndexChanged += new System.EventHandler(this.CB_serialport_SelectedIndexChanged);
            // 
            // B_valider
            // 
            this.B_valider.Enabled = false;
            this.B_valider.Location = new System.Drawing.Point(225, 6);
            this.B_valider.Name = "B_valider";
            this.B_valider.Size = new System.Drawing.Size(47, 23);
            this.B_valider.TabIndex = 4;
            this.B_valider.Text = "OK";
            this.B_valider.UseVisualStyleBackColor = true;
            this.B_valider.Click += new System.EventHandler(this.B_valider_Click);
            // 
            // TB_bauds
            // 
            this.TB_bauds.Location = new System.Drawing.Point(196, 91);
            this.TB_bauds.Name = "TB_bauds";
            this.TB_bauds.Size = new System.Drawing.Size(67, 20);
            this.TB_bauds.TabIndex = 5;
            this.TB_bauds.Text = "9600";
            this.TB_bauds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_bauds
            // 
            this.LB_bauds.AutoSize = true;
            this.LB_bauds.Location = new System.Drawing.Point(193, 75);
            this.LB_bauds.Name = "LB_bauds";
            this.LB_bauds.Size = new System.Drawing.Size(61, 13);
            this.LB_bauds.TabIndex = 6;
            this.LB_bauds.Text = "Bauds rate:";
            // 
            // B_envoi
            // 
            this.B_envoi.Enabled = false;
            this.B_envoi.Location = new System.Drawing.Point(193, 114);
            this.B_envoi.Name = "B_envoi";
            this.B_envoi.Size = new System.Drawing.Size(79, 23);
            this.B_envoi.TabIndex = 7;
            this.B_envoi.Text = "Envoi";
            this.B_envoi.UseVisualStyleBackColor = true;
            this.B_envoi.Click += new System.EventHandler(this.B_envoi_Click);
            // 
            // B_clear
            // 
            this.B_clear.Location = new System.Drawing.Point(193, 226);
            this.B_clear.Name = "B_clear";
            this.B_clear.Size = new System.Drawing.Size(79, 23);
            this.B_clear.TabIndex = 8;
            this.B_clear.Text = "Clear console";
            this.B_clear.UseVisualStyleBackColor = true;
            this.B_clear.Click += new System.EventHandler(this.B_clear_Click);
            // 
            // TB_TX
            // 
            this.TB_TX.BackColor = System.Drawing.SystemColors.InfoText;
            this.TB_TX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_TX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TB_TX.Location = new System.Drawing.Point(3, 16);
            this.TB_TX.Multiline = true;
            this.TB_TX.Name = "TB_TX";
            this.TB_TX.Size = new System.Drawing.Size(169, 81);
            this.TB_TX.TabIndex = 0;
            // 
            // TB_RX
            // 
            this.TB_RX.BackColor = System.Drawing.SystemColors.InfoText;
            this.TB_RX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_RX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TB_RX.Location = new System.Drawing.Point(3, 16);
            this.TB_RX.Multiline = true;
            this.TB_RX.Name = "TB_RX";
            this.TB_RX.Size = new System.Drawing.Size(169, 81);
            this.TB_RX.TabIndex = 1;
            // 
            // B_close
            // 
            this.B_close.Enabled = false;
            this.B_close.Location = new System.Drawing.Point(225, 30);
            this.B_close.Name = "B_close";
            this.B_close.Size = new System.Drawing.Size(47, 23);
            this.B_close.TabIndex = 9;
            this.B_close.Text = "Fermer";
            this.B_close.UseVisualStyleBackColor = true;
            this.B_close.Click += new System.EventHandler(this.B_close_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.B_close);
            this.Controls.Add(this.B_clear);
            this.Controls.Add(this.B_envoi);
            this.Controls.Add(this.LB_bauds);
            this.Controls.Add(this.TB_bauds);
            this.Controls.Add(this.B_valider);
            this.Controls.Add(this.CB_serialport);
            this.Controls.Add(this.GB_Reception);
            this.Controls.Add(this.GB_Envoi);
            this.Controls.Add(this.LB_serial);
            this.Name = "EcranPrincipal";
            this.Text = "Form1";
            this.GB_Envoi.ResumeLayout(false);
            this.GB_Envoi.PerformLayout();
            this.GB_Reception.ResumeLayout(false);
            this.GB_Reception.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_serial;
        private System.Windows.Forms.GroupBox GB_Envoi;
        private System.Windows.Forms.GroupBox GB_Reception;
        private System.Windows.Forms.ComboBox CB_serialport;
        private System.Windows.Forms.Button B_valider;
        private System.Windows.Forms.TextBox TB_bauds;
        private System.Windows.Forms.Label LB_bauds;
        private System.Windows.Forms.TextBox TB_TX;
        private System.Windows.Forms.TextBox TB_RX;
        private System.Windows.Forms.Button B_envoi;
        private System.Windows.Forms.Button B_clear;
        private System.Windows.Forms.Button B_close;
        private System.Windows.Forms.Timer timer;
    }
}

