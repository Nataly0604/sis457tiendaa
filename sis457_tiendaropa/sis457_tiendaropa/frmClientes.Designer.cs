namespace sis457_tiendaropa
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.textireccion = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combestado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.texttelefono = new System.Windows.Forms.TextBox();
            this.textnombrecompleto = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.labe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textdocumento = new System.Windows.Forms.TextBox();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Email";
            // 
            // textireccion
            // 
            this.textireccion.Location = new System.Drawing.Point(511, 74);
            this.textireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textireccion.Name = "textireccion";
            this.textireccion.Size = new System.Drawing.Size(209, 22);
            this.textireccion.TabIndex = 59;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(128, 74);
            this.textid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(55, 22);
            this.textid.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 31);
            this.label7.TabIndex = 57;
            this.label7.Text = "lista de clientes";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.id,
            this.documento,
            this.nombrecompleto,
            this.email,
            this.telefono,
            this.direccion,
            this.estado});
            this.dgvdata.Location = new System.Drawing.Point(61, 187);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 40;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(887, 325);
            this.dgvdata.TabIndex = 44;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.FillWeight = 30F;
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.MinimumWidth = 6;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // documento
            // 
            this.documento.HeaderText = "documento";
            this.documento.MinimumWidth = 6;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 125;
            // 
            // nombrecompleto
            // 
            this.nombrecompleto.HeaderText = "Nombre Completo";
            this.nombrecompleto.MinimumWidth = 6;
            this.nombrecompleto.Name = "nombrecompleto";
            this.nombrecompleto.ReadOnly = true;
            this.nombrecompleto.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.direccion.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Estado";
            // 
            // combestado
            // 
            this.combestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combestado.FormattingEnabled = true;
            this.combestado.Location = new System.Drawing.Point(511, 123);
            this.combestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combestado.Name = "combestado";
            this.combestado.Size = new System.Drawing.Size(209, 24);
            this.combestado.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Direccion";
            // 
            // texttelefono
            // 
            this.texttelefono.Location = new System.Drawing.Point(511, 26);
            this.texttelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texttelefono.Name = "texttelefono";
            this.texttelefono.Size = new System.Drawing.Size(209, 22);
            this.texttelefono.TabIndex = 48;
            // 
            // textnombrecompleto
            // 
            this.textnombrecompleto.Location = new System.Drawing.Point(237, 74);
            this.textnombrecompleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textnombrecompleto.Name = "textnombrecompleto";
            this.textnombrecompleto.Size = new System.Drawing.Size(209, 22);
            this.textnombrecompleto.TabIndex = 47;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(237, 122);
            this.textemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(209, 22);
            this.textemail.TabIndex = 46;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(507, 6);
            this.labe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(69, 16);
            this.labe.TabIndex = 45;
            this.labe.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Documento";
            // 
            // textdocumento
            // 
            this.textdocumento.Location = new System.Drawing.Point(237, 25);
            this.textdocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textdocumento.Name = "textdocumento";
            this.textdocumento.Size = new System.Drawing.Size(209, 22);
            this.textdocumento.TabIndex = 63;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 17;
            this.btneliminar.Location = new System.Drawing.Point(864, 84);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 28);
            this.btneliminar.TabIndex = 55;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Green;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnguardar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 17;
            this.btnguardar.Location = new System.Drawing.Point(753, 48);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(211, 28);
            this.btnguardar.TabIndex = 54;
            this.btnguardar.Text = "guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.DarkCyan;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btneditar.IconColor = System.Drawing.Color.White;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.IconSize = 17;
            this.btneditar.Location = new System.Drawing.Point(753, 84);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 28);
            this.btneditar.TabIndex = 53;
            this.btneditar.Text = "editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textdocumento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textireccion);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combestado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texttelefono);
            this.Controls.Add(this.textnombrecompleto);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textireccion;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combestado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texttelefono;
        private System.Windows.Forms.TextBox textnombrecompleto;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textdocumento;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}