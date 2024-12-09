namespace sis457_tiendaropa
{
    partial class frmDetalleVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLES VENTAS";
            // 
            // dgvdata
            // 
            this.dgvdata.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idUsuario,
            this.Documento,
            this.numeroDocumento,
            this.documentoCliente,
            this.nombreCliente,
            this.montoPago,
            this.montoCambio,
            this.montoTotal,
            this.usuarioRegistro,
            this.fechaRegistro,
            this.estado});
            this.dgvdata.Location = new System.Drawing.Point(47, 106);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.Size = new System.Drawing.Size(775, 372);
            this.dgvdata.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "Usuario";
            this.idUsuario.MinimumWidth = 6;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Width = 125;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "tipoDocumento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.Width = 125;
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.HeaderText = "numeroDocumento";
            this.numeroDocumento.MinimumWidth = 6;
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.Width = 125;
            // 
            // documentoCliente
            // 
            this.documentoCliente.HeaderText = "documentoCliente";
            this.documentoCliente.MinimumWidth = 6;
            this.documentoCliente.Name = "documentoCliente";
            this.documentoCliente.Width = 125;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "nombreCliente";
            this.nombreCliente.MinimumWidth = 6;
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Width = 125;
            // 
            // montoPago
            // 
            this.montoPago.HeaderText = "montoPago";
            this.montoPago.MinimumWidth = 6;
            this.montoPago.Name = "montoPago";
            this.montoPago.Width = 125;
            // 
            // montoCambio
            // 
            this.montoCambio.HeaderText = "montoCambio";
            this.montoCambio.MinimumWidth = 6;
            this.montoCambio.Name = "montoCambio";
            this.montoCambio.Width = 125;
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "montoTotal";
            this.montoTotal.MinimumWidth = 6;
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.Width = 125;
            // 
            // usuarioRegistro
            // 
            this.usuarioRegistro.HeaderText = "usuario";
            this.usuarioRegistro.MinimumWidth = 6;
            this.usuarioRegistro.Name = "usuarioRegistro";
            this.usuarioRegistro.Width = 125;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "fechaRegistro";
            this.fechaRegistro.MinimumWidth = 6;
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // frmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetalleVentas";
            this.Text = "frmDetalleVentas";
            this.Load += new System.EventHandler(this.frmDetalleVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}