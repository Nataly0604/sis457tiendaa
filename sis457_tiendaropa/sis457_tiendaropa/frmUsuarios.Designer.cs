namespace sis457_tiendaropa
{
    partial class frmUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.textclave = new System.Windows.Forms.TextBox();
            this.textconfirmarclave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combrol = new System.Windows.Forms.ComboBox();
            this.combestado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadovalor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 516);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "nombre usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "clave";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(49, 160);
            this.labe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(94, 16);
            this.labe.TabIndex = 3;
            this.labe.Text = "repetir clave";
            // 
            // textusuario
            // 
            this.textusuario.Location = new System.Drawing.Point(49, 84);
            this.textusuario.Margin = new System.Windows.Forms.Padding(4);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(209, 22);
            this.textusuario.TabIndex = 4;
            // 
            // textclave
            // 
            this.textclave.Location = new System.Drawing.Point(49, 132);
            this.textclave.Margin = new System.Windows.Forms.Padding(4);
            this.textclave.Name = "textclave";
            this.textclave.PasswordChar = '*';
            this.textclave.Size = new System.Drawing.Size(209, 22);
            this.textclave.TabIndex = 5;
            // 
            // textconfirmarclave
            // 
            this.textconfirmarclave.Location = new System.Drawing.Point(49, 180);
            this.textconfirmarclave.Margin = new System.Windows.Forms.Padding(4);
            this.textconfirmarclave.Name = "textconfirmarclave";
            this.textconfirmarclave.PasswordChar = '*';
            this.textconfirmarclave.Size = new System.Drawing.Size(209, 22);
            this.textconfirmarclave.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "rol";
            // 
            // combrol
            // 
            this.combrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combrol.FormattingEnabled = true;
            this.combrol.Location = new System.Drawing.Point(49, 288);
            this.combrol.Margin = new System.Windows.Forms.Padding(4);
            this.combrol.Name = "combrol";
            this.combrol.Size = new System.Drawing.Size(209, 24);
            this.combrol.TabIndex = 8;
            // 
            // combestado
            // 
            this.combestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combestado.FormattingEnabled = true;
            this.combestado.Location = new System.Drawing.Point(49, 353);
            this.combestado.Margin = new System.Windows.Forms.Padding(4);
            this.combestado.Name = "combestado";
            this.combestado.Size = new System.Drawing.Size(209, 24);
            this.combestado.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Detalles de usuario";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.usuario,
            this.usuarioRegistro,
            this.estado,
            this.estadovalor,
            this.idRol,
            this.clave});
            this.dgvdata.Location = new System.Drawing.Point(383, 110);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(636, 341);
            this.dgvdata.TabIndex = 15;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
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
            this.id.HeaderText = "id_usuario";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "nombre Usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 125;
            // 
            // usuarioRegistro
            // 
            this.usuarioRegistro.HeaderText = "rol ";
            this.usuarioRegistro.MinimumWidth = 6;
            this.usuarioRegistro.Name = "usuarioRegistro";
            this.usuarioRegistro.ReadOnly = true;
            this.usuarioRegistro.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 125;
            // 
            // estadovalor
            // 
            this.estadovalor.HeaderText = "estadovalor";
            this.estadovalor.MinimumWidth = 6;
            this.estadovalor.Name = "estadovalor";
            this.estadovalor.ReadOnly = true;
            this.estadovalor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estadovalor.Width = 125;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "idRol";
            this.idRol.MinimumWidth = 6;
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            this.idRol.Width = 125;
            // 
            // clave
            // 
            this.clave.HeaderText = "clave";
            this.clave.MinimumWidth = 6;
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            this.clave.Width = 125;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(703, 41);
            this.label7.TabIndex = 16;
            this.label7.Text = "LISTA DE USUARIOS";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(204, 46);
            this.textid.Margin = new System.Windows.Forms.Padding(4);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(55, 22);
            this.textid.TabIndex = 17;
            this.textid.Text = "0";
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
            this.btneliminar.Location = new System.Drawing.Point(160, 457);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 28);
            this.btneliminar.TabIndex = 13;
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
            this.btnguardar.Location = new System.Drawing.Point(49, 406);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(211, 28);
            this.btnguardar.TabIndex = 12;
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
            this.btneditar.Location = new System.Drawing.Point(49, 457);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 28);
            this.btneditar.TabIndex = 11;
            this.btneditar.Text = "editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1057, 516);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combestado);
            this.Controls.Add(this.combrol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textconfirmarclave);
            this.Controls.Add(this.textclave);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.TextBox textclave;
        private System.Windows.Forms.TextBox textconfirmarclave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combrol;
        private System.Windows.Forms.ComboBox combestado;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadovalor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;

    }
}