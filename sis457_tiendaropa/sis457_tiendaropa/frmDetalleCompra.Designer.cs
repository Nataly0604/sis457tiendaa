namespace sis457_tiendaropa
{
    partial class frmDetalleCompra
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
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombdocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioregistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idUsuario,
            this.idProveedor,
            this.documento,
            this.nombdocumento,
            this.montoTotal,
            this.usuarioregistro,
            this.fecharegistro,
            this.estado});
            this.dgvCompras.Location = new System.Drawing.Point(55, 116);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.Size = new System.Drawing.Size(767, 386);
            this.dgvCompras.TabIndex = 0;
            this.dgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.MinimumWidth = 6;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Width = 125;
            // 
            // idProveedor
            // 
            this.idProveedor.HeaderText = "idProveedor";
            this.idProveedor.MinimumWidth = 6;
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.Width = 125;
            // 
            // documento
            // 
            this.documento.HeaderText = "tipodocumento";
            this.documento.MinimumWidth = 6;
            this.documento.Name = "documento";
            this.documento.Width = 125;
            // 
            // nombdocumento
            // 
            this.nombdocumento.HeaderText = "documento";
            this.nombdocumento.MinimumWidth = 6;
            this.nombdocumento.Name = "nombdocumento";
            this.nombdocumento.Width = 125;
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "montoTotal";
            this.montoTotal.MinimumWidth = 6;
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.Width = 125;
            // 
            // usuarioregistro
            // 
            this.usuarioregistro.HeaderText = "usuario";
            this.usuarioregistro.MinimumWidth = 6;
            this.usuarioregistro.Name = "usuarioregistro";
            this.usuarioregistro.Width = 125;
            // 
            // fecharegistro
            // 
            this.fecharegistro.HeaderText = "fecha";
            this.fecharegistro.MinimumWidth = 6;
            this.fecharegistro.Name = "fecharegistro";
            this.fecharegistro.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "DETALLES DE COMPRAS";
            // 
            // frmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCompras);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetalleCompra";
            this.Text = "frmDetalleCompra";
            this.Load += new System.EventHandler(this.frmDetalleCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombdocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label label1;
    }
}