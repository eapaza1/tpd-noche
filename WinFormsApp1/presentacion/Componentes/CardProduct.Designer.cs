namespace TpdNoche.presentacion.Componentes
{
    partial class CardProduct
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            img_producto = new PictureBox();
            lbl_titulo = new Label();
            lbl_descripcion = new Label();
            btn_add = new Button();
            lbl_precio = new Label();
            ((System.ComponentModel.ISupportInitialize)img_producto).BeginInit();
            SuspendLayout();
            // 
            // img_producto
            // 
            img_producto.Dock = DockStyle.Top;
            img_producto.Image = Properties.Resources.usuario;
            img_producto.Location = new Point(14, 17);
            img_producto.Margin = new Padding(14, 17, 14, 17);
            img_producto.Name = "img_producto";
            img_producto.Size = new Size(129, 144);
            img_producto.SizeMode = PictureBoxSizeMode.Zoom;
            img_producto.TabIndex = 0;
            img_producto.TabStop = false;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(14, 163);
            lbl_titulo.Margin = new Padding(4, 0, 4, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(129, 58);
            lbl_titulo.TabIndex = 1;
            lbl_titulo.Text = "LAPTOP";
            lbl_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_descripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_descripcion.Location = new Point(14, 221);
            lbl_descripcion.Margin = new Padding(4, 0, 4, 0);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(129, 63);
            lbl_descripcion.TabIndex = 2;
            lbl_descripcion.Text = "Laptop AlienWare de 32Gb";
            lbl_descripcion.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Lime;
            btn_add.Dock = DockStyle.Bottom;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Location = new Point(14, 276);
            btn_add.Margin = new Padding(4, 5, 4, 5);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(129, 57);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add Cart";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // lbl_precio
            // 
            lbl_precio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_precio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_precio.Location = new Point(14, 280);
            lbl_precio.Margin = new Padding(4, 0, 4, 0);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(129, 43);
            lbl_precio.TabIndex = 3;
            lbl_precio.Text = "$100.00";
            lbl_precio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_add);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_descripcion);
            Controls.Add(lbl_titulo);
            Controls.Add(img_producto);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CardProduct";
            Padding = new Padding(14, 17, 14, 17);
            Size = new Size(157, 350);
            ((System.ComponentModel.ISupportInitialize)img_producto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox img_producto;
        private Label lbl_titulo;
        private Label lbl_descripcion;
        private Button btn_add;
        private Label lbl_precio;
    }
}
