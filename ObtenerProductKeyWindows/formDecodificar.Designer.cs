namespace ProductKeyWindowsProyectoA
{
    partial class formDecodificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDecodificar));
            this.txtValorHex = new System.Windows.Forms.TextBox();
            this.labDigitalProductId = new System.Windows.Forms.Label();
            this.btnParseDigitalProductId = new System.Windows.Forms.Button();
            this.txtProductKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearDigitalProductId = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.lsSO = new System.Windows.Forms.ComboBox();
            this.txtHexadecimalFormateado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btObtenerDPId = new System.Windows.Forms.Button();
            this.btObtenerDPId4 = new System.Windows.Forms.Button();
            this.btCopiarHex = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorHex
            // 
            this.txtValorHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorHex.Location = new System.Drawing.Point(18, 74);
            this.txtValorHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorHex.Multiline = true;
            this.txtValorHex.Name = "txtValorHex";
            this.txtValorHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValorHex.Size = new System.Drawing.Size(1087, 262);
            this.txtValorHex.TabIndex = 0;
            this.txtValorHex.TextChanged += new System.EventHandler(this.tbDigitalProductId_TextChanged);
            // 
            // labDigitalProductId
            // 
            this.labDigitalProductId.AutoSize = true;
            this.labDigitalProductId.Location = new System.Drawing.Point(14, 12);
            this.labDigitalProductId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDigitalProductId.Name = "labDigitalProductId";
            this.labDigitalProductId.Size = new System.Drawing.Size(513, 20);
            this.labDigitalProductId.TabIndex = 1;
            this.labDigitalProductId.Text = "Introduzca el valor de DigitalProductId exportado de la clave de registro:";
            // 
            // btnParseDigitalProductId
            // 
            this.btnParseDigitalProductId.Location = new System.Drawing.Point(261, 346);
            this.btnParseDigitalProductId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParseDigitalProductId.Name = "btnParseDigitalProductId";
            this.btnParseDigitalProductId.Size = new System.Drawing.Size(135, 35);
            this.btnParseDigitalProductId.TabIndex = 2;
            this.btnParseDigitalProductId.Text = "Decodificar";
            this.btnParseDigitalProductId.UseVisualStyleBackColor = true;
            this.btnParseDigitalProductId.Click += new System.EventHandler(this.btnParseDigitalProductId_Click);
            // 
            // txtProductKey
            // 
            this.txtProductKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProductKey.Location = new System.Drawing.Point(18, 444);
            this.txtProductKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.Size = new System.Drawing.Size(996, 39);
            this.txtProductKey.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 415);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clave de producto:";
            // 
            // btnClearDigitalProductId
            // 
            this.btnClearDigitalProductId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearDigitalProductId.Location = new System.Drawing.Point(1019, 346);
            this.btnClearDigitalProductId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearDigitalProductId.Name = "btnClearDigitalProductId";
            this.btnClearDigitalProductId.Size = new System.Drawing.Size(86, 35);
            this.btnClearDigitalProductId.TabIndex = 5;
            this.btnClearDigitalProductId.Text = "Limpiar";
            this.btnClearDigitalProductId.UseVisualStyleBackColor = true;
            this.btnClearDigitalProductId.Click += new System.EventHandler(this.btnClearDigitalProductId_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCerrar.Location = new System.Drawing.Point(22, 890);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(178, 49);
            this.btCerrar.TabIndex = 10;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopiar.Location = new System.Drawing.Point(1023, 444);
            this.btCopiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(82, 39);
            this.btCopiar.TabIndex = 7;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // lsSO
            // 
            this.lsSO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lsSO.FormattingEnabled = true;
            this.lsSO.Items.AddRange(new object[] {
            "Windows 7 o inferior",
            "Windows 8 o superior"});
            this.lsSO.Location = new System.Drawing.Point(18, 350);
            this.lsSO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsSO.Name = "lsSO";
            this.lsSO.Size = new System.Drawing.Size(235, 28);
            this.lsSO.TabIndex = 1;
            // 
            // txtHexadecimalFormateado
            // 
            this.txtHexadecimalFormateado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHexadecimalFormateado.Location = new System.Drawing.Point(18, 533);
            this.txtHexadecimalFormateado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHexadecimalFormateado.Multiline = true;
            this.txtHexadecimalFormateado.Name = "txtHexadecimalFormateado";
            this.txtHexadecimalFormateado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHexadecimalFormateado.Size = new System.Drawing.Size(1087, 340);
            this.txtHexadecimalFormateado.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 508);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor hexadecimal a decodificar formateado:";
            // 
            // btObtenerDPId
            // 
            this.btObtenerDPId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btObtenerDPId.Location = new System.Drawing.Point(581, 346);
            this.btObtenerDPId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btObtenerDPId.Name = "btObtenerDPId";
            this.btObtenerDPId.Size = new System.Drawing.Size(189, 35);
            this.btObtenerDPId.TabIndex = 3;
            this.btObtenerDPId.Text = "Obtener DPId equipo";
            this.btObtenerDPId.UseVisualStyleBackColor = true;
            this.btObtenerDPId.Click += new System.EventHandler(this.btObtenerDPId_Click);
            // 
            // btObtenerDPId4
            // 
            this.btObtenerDPId4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btObtenerDPId4.Location = new System.Drawing.Point(779, 346);
            this.btObtenerDPId4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btObtenerDPId4.Name = "btObtenerDPId4";
            this.btObtenerDPId4.Size = new System.Drawing.Size(201, 35);
            this.btObtenerDPId4.TabIndex = 4;
            this.btObtenerDPId4.Text = "Obtener DPId4 equipo";
            this.btObtenerDPId4.UseVisualStyleBackColor = true;
            this.btObtenerDPId4.Click += new System.EventHandler(this.btObtenerDPId4_Click);
            // 
            // btCopiarHex
            // 
            this.btCopiarHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopiarHex.Location = new System.Drawing.Point(927, 890);
            this.btCopiarHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCopiarHex.Name = "btCopiarHex";
            this.btCopiarHex.Size = new System.Drawing.Size(178, 49);
            this.btCopiarHex.TabIndex = 9;
            this.btCopiarHex.Text = "Copiar";
            this.btCopiarHex.UseVisualStyleBackColor = true;
            this.btCopiarHex.Click += new System.EventHandler(this.btCopiarHex_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(50, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(681, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\DigitalProductId";
            // 
            // formDecodificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCerrar;
            this.ClientSize = new System.Drawing.Size(1129, 953);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCopiarHex);
            this.Controls.Add(this.btObtenerDPId4);
            this.Controls.Add(this.btObtenerDPId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHexadecimalFormateado);
            this.Controls.Add(this.lsSO);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btnClearDigitalProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.btnParseDigitalProductId);
            this.Controls.Add(this.labDigitalProductId);
            this.Controls.Add(this.txtValorHex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formDecodificar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Decodificar valor de DigitalProductKey";
            this.Load += new System.EventHandler(this.DigitalProductIdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorHex;
        private System.Windows.Forms.Label labDigitalProductId;
        private System.Windows.Forms.Button btnParseDigitalProductId;
        private System.Windows.Forms.TextBox txtProductKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearDigitalProductId;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.ComboBox lsSO;
        private System.Windows.Forms.TextBox txtHexadecimalFormateado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btObtenerDPId;
        private System.Windows.Forms.Button btObtenerDPId4;
        private System.Windows.Forms.Button btCopiarHex;
        private System.Windows.Forms.Label label3;
    }
}