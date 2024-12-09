namespace sis457_tiendaropa
{
    partial class frmProducto
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
            this.textid = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combestado = new System.Windows.Forms.ComboBox();
            this.combcategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textdescripcion = new System.Windows.Forms.TextBox();
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.labe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textstock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textprecioventa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(205, 44);
            this.textid.Margin = new System.Windows.Forms.Padding(4);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(55, 22);
            this.textid.TabIndex = 35;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.MistyRose;
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
            this.nombre,
            this.codigo,
            this.descripcion,
            this.categoria,
            this.stock,
            this.precioventa,
            this.estado});
            this.dgvdata.Location = new System.Drawing.Point(355, 97);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 40;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(659, 325);
            this.dgvdata.TabIndex = 20;
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
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 125;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 125;
            // 
            // stock
            // 
            this.stock.HeaderText = "stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stock.Width = 125;
            // 
            // precioventa
            // 
            this.precioventa.HeaderText = "precio Venta";
            this.precioventa.MinimumWidth = 6;
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Width = 125;
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
            this.label4.Location = new System.Drawing.Point(49, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(47, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Estado";
            // 
            // combestado
            // 
            this.combestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combestado.FormattingEnabled = true;
            this.combestado.Location = new System.Drawing.Point(51, 398);
            this.combestado.Margin = new System.Windows.Forms.Padding(4);
            this.combestado.Name = "combestado";
            this.combestado.Size = new System.Drawing.Size(209, 24);
            this.combestado.TabIndex = 27;
            // 
            // combcategoria
            // 
            this.combcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combcategoria.FormattingEnabled = true;
            this.combcategoria.Location = new System.Drawing.Point(51, 97);
            this.combcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.combcategoria.Name = "combcategoria";
            this.combcategoria.Size = new System.Drawing.Size(209, 24);
            this.combcategoria.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(47, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Stock";
            // 
            // textdescripcion
            // 
            this.textdescripcion.Location = new System.Drawing.Point(51, 254);
            this.textdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.textdescripcion.Name = "textdescripcion";
            this.textdescripcion.Size = new System.Drawing.Size(209, 22);
            this.textdescripcion.TabIndex = 24;
            // 
            // textcodigo
            // 
            this.textcodigo.Location = new System.Drawing.Point(51, 146);
            this.textcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(209, 22);
            this.textcodigo.TabIndex = 23;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(51, 194);
            this.textnombre.Margin = new System.Windows.Forms.Padding(4);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(209, 22);
            this.textnombre.TabIndex = 22;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labe.Location = new System.Drawing.Point(47, 234);
            this.labe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(79, 16);
            this.labe.TabIndex = 21;
            this.labe.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(47, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 554);
            this.label1.TabIndex = 18;
            // 
            // textstock
            // 
            this.textstock.Location = new System.Drawing.Point(51, 302);
            this.textstock.Margin = new System.Windows.Forms.Padding(4);
            this.textstock.Name = "textstock";
            this.textstock.Size = new System.Drawing.Size(209, 22);
            this.textstock.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(47, 330);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Precio Venta";
            // 
            // textprecioventa
            // 
            this.textprecioventa.Location = new System.Drawing.Point(51, 350);
            this.textprecioventa.Margin = new System.Windows.Forms.Padding(4);
            this.textprecioventa.Name = "textprecioventa";
            this.textprecioventa.Size = new System.Drawing.Size(209, 22);
            this.textprecioventa.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(47, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Nombre";
            // 
            // textbuscar
            // 
            this.textbuscar.Location = new System.Drawing.Point(594, 479);
            this.textbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(55, 22);
            this.textbuscar.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 56);
            this.label7.TabIndex = 43;
            this.label7.Text = "PRODUCTOS";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Maroon;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton1.IconColor = System.Drawing.Color.Snow;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 17;
            this.iconButton1.Location = new System.Drawing.Point(672, 466);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(122, 35);
            this.iconButton1.TabIndex = 41;
            this.iconButton1.Text = "buscar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.btneliminar.Location = new System.Drawing.Point(161, 466);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 28);
            this.btneliminar.TabIndex = 31;
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
            this.btnguardar.Location = new System.Drawing.Point(51, 431);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(211, 28);
            this.btnguardar.TabIndex = 30;
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
            this.btneditar.Location = new System.Drawing.Point(51, 466);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(100, 28);
            this.btneditar.TabIndex = 29;
            this.btneditar.Text = "editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textbuscar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textprecioventa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textstock);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combestado);
            this.Controls.Add(this.combcategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textdescripcion);
            this.Controls.Add(this.textcodigo);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combestado;
        private System.Windows.Forms.ComboBox combcategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textdescripcion;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textstock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textprecioventa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Label label7;
    }
}