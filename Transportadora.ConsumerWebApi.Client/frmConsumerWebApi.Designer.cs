namespace Transportadora.ConsumerWebApi.Client
{
    partial class frmConsumerWebApi
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
            this.dgvTransportadoras = new System.Windows.Forms.DataGridView();
            this.btnNova = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btngAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportadoras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransportadoras
            // 
            this.dgvTransportadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportadoras.Location = new System.Drawing.Point(8, 63);
            this.dgvTransportadoras.Name = "dgvTransportadoras";
            this.dgvTransportadoras.Size = new System.Drawing.Size(822, 327);
            this.dgvTransportadoras.TabIndex = 0;
            // 
            // btnNova
            // 
            this.btnNova.Location = new System.Drawing.Point(8, 392);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(113, 39);
            this.btnNova.TabIndex = 1;
            this.btnNova.Text = "Nova";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(157, 392);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 39);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btngAlterar
            // 
            this.btngAlterar.Location = new System.Drawing.Point(304, 392);
            this.btngAlterar.Name = "btngAlterar";
            this.btngAlterar.Size = new System.Drawing.Size(113, 39);
            this.btngAlterar.TabIndex = 3;
            this.btngAlterar.Text = "Alterar";
            this.btngAlterar.UseVisualStyleBackColor = true;
            this.btngAlterar.Click += new System.EventHandler(this.btngAlterar_Click);
            // 
            // frmConsumerWebApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 438);
            this.Controls.Add(this.btngAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.dgvTransportadoras);
            this.Name = "frmConsumerWebApi";
            this.Text = "Transportadoras Consumer Web Api 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsumerWebApi_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsumerWebApi_FormClosed);
            this.Load += new System.EventHandler(this.frmConsumerWebApi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportadoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransportadoras;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btngAlterar;
    }
}

