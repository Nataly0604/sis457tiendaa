using System.Drawing;
using System.Windows.Forms;

namespace sis457_tiendaropa
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.userActual = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrar = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetalle = new FontAwesome.Sharp.IconMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistraventa = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menumantenedor,
            this.menuventas,
            this.menucompras,
            this.menuclientes,
            this.menuproveedores,
            this.menureportes});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 73);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(114, 557);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.DeepPink;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1148, 73);
            this.menuTitulo.TabIndex = 3;
            this.menuTitulo.Text = "JANDRA LENCERIA";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuTitulo_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(343, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jandra Lenceria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.pictureBox1);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.ImeMode = System.Windows.Forms.ImeMode.On;
            this.contenedor.Location = new System.Drawing.Point(114, 73);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1034, 557);
            this.contenedor.TabIndex = 5;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // userActual
            // 
            this.userActual.AutoSize = true;
            this.userActual.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userActual.Font = new System.Drawing.Font("MT Extra", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.userActual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userActual.Location = new System.Drawing.Point(987, 27);
            this.userActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userActual.Name = "userActual";
            this.userActual.Size = new System.Drawing.Size(113, 25);
            this.userActual.TabIndex = 6;
            this.userActual.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::sis457_tiendaropa.Properties.Resources.ffo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1034, 557);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuusuarios
            // 
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 30;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(97, 54);
            this.menuusuarios.Text = "usuarios ";
            this.menuusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuarios.Click += new System.EventHandler(this.menuusuario_Click);
            // 
            // menumantenedor
            // 
            this.menumantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuCategoria,
            this.submenuProducto});
            this.menumantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.menumantenedor.IconColor = System.Drawing.Color.Black;
            this.menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenedor.IconSize = 30;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Size = new System.Drawing.Size(97, 54);
            this.menumantenedor.Text = "mantenedor";
            this.menumantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuCategoria
            // 
            this.submenuCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submenuCategoria.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.submenuCategoria.IconColor = System.Drawing.Color.Black;
            this.submenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuCategoria.Name = "submenuCategoria";
            this.submenuCategoria.Size = new System.Drawing.Size(157, 26);
            this.submenuCategoria.Text = "Categoria";
            this.submenuCategoria.Click += new System.EventHandler(this.submenuCategoria_Click_1);
            // 
            // submenuProducto
            // 
            this.submenuProducto.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.submenuProducto.IconColor = System.Drawing.Color.Black;
            this.submenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuProducto.Name = "submenuProducto";
            this.submenuProducto.Size = new System.Drawing.Size(157, 26);
            this.submenuProducto.Text = "producto";
            this.submenuProducto.Click += new System.EventHandler(this.submenuProducto_Click_1);
            // 
            // menuventas
            // 
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrar,
            this.submenuverdetalle});
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 30;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(97, 54);
            this.menuventas.Text = "ventas";
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuventas.Click += new System.EventHandler(this.menuventas_Click);
            // 
            // submenuregistrar
            // 
            this.submenuregistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrar.IconColor = System.Drawing.Color.Black;
            this.submenuregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrar.Name = "submenuregistrar";
            this.submenuregistrar.Size = new System.Drawing.Size(168, 26);
            this.submenuregistrar.Text = "registrar";
            this.submenuregistrar.Click += new System.EventHandler(this.submenuregistrar_Click);
            // 
            // submenuverdetalle
            // 
            this.submenuverdetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalle.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalle.Name = "submenuverdetalle";
            this.submenuverdetalle.Size = new System.Drawing.Size(168, 26);
            this.submenuverdetalle.Text = "ver detalles";
            this.submenuverdetalle.Click += new System.EventHandler(this.submenuverdetalle_Click);
            // 
            // menucompras
            // 
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistraventa,
            this.submenuverdetallecompra});
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menucompras.IconColor = System.Drawing.Color.Black;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompras.IconSize = 30;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(97, 54);
            this.menucompras.Text = "compras";
            this.menucompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuregistraventa
            // 
            this.submenuregistraventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistraventa.IconColor = System.Drawing.Color.Black;
            this.submenuregistraventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistraventa.Name = "submenuregistraventa";
            this.submenuregistraventa.Size = new System.Drawing.Size(165, 26);
            this.submenuregistraventa.Text = "Registrar";
            this.submenuregistraventa.Click += new System.EventHandler(this.submenuregistraventa_Click);
            // 
            // submenuverdetallecompra
            // 
            this.submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetallecompra.IconColor = System.Drawing.Color.Black;
            this.submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetallecompra.Name = "submenuverdetallecompra";
            this.submenuverdetallecompra.Size = new System.Drawing.Size(165, 26);
            this.submenuverdetallecompra.Text = "Ver Detalle";
            this.submenuverdetallecompra.Click += new System.EventHandler(this.submenuverdetallecompra_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 30;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(97, 54);
            this.menuclientes.Text = "clientes";
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 30;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(97, 54);
            this.menuproveedores.Text = "proveedores";
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menureportes
            // 
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 30;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(97, 54);
            this.menureportes.Text = "reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 630);
            this.Controls.Add(this.userActual);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label userActual;
        private FontAwesome.Sharp.IconMenuItem submenuProducto;
        private FontAwesome.Sharp.IconMenuItem submenuregistrar;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalle;
        private FontAwesome.Sharp.IconMenuItem submenuregistraventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
        private FontAwesome.Sharp.IconMenuItem submenuCategoria;
        private PictureBox pictureBox1;
    }
}

