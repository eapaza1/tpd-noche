namespace TpdNoche.presentacion
{
    partial class FormProductos
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
            panel_productos = new FlowLayoutPanel();
            label1 = new Label();
            txt_nombre = new TextBox();
            txt_descripcion = new TextBox();
            label2 = new Label();
            txt_precio = new TextBox();
            label3 = new Label();
            txt_stock = new TextBox();
            label4 = new Label();
            txt_categoria = new TextBox();
            label5 = new Label();
            img_producto = new PictureBox();
            label6 = new Label();
            btn_cambiar_imagen = new Button();
            btn_agregar = new Button();
            btn_cancelar = new Button();
            label7 = new Label();
            txt_buscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)img_producto).BeginInit();
            SuspendLayout();
            // 
            // panel_productos
            // 
            panel_productos.AutoScroll = true;
            panel_productos.Location = new Point(303, 73);
            panel_productos.Name = "panel_productos";
            panel_productos.Size = new Size(485, 365);
            panel_productos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 47);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "NOMBRE";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(86, 44);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(166, 23);
            txt_nombre.TabIndex = 2;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(86, 73);
            txt_descripcion.Multiline = true;
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(166, 56);
            txt_descripcion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 76);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "DESC.";
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(86, 135);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(166, 23);
            txt_precio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 138);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "PRECIO";
            // 
            // txt_stock
            // 
            txt_stock.Location = new Point(86, 164);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(166, 23);
            txt_stock.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 167);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "STOCK";
            // 
            // txt_categoria
            // 
            txt_categoria.Location = new Point(86, 193);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(166, 23);
            txt_categoria.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 196);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "CATEGORIA";
            // 
            // img_producto
            // 
            img_producto.Image = Properties.Resources.agregar_producto;
            img_producto.Location = new Point(86, 219);
            img_producto.Name = "img_producto";
            img_producto.Size = new Size(166, 93);
            img_producto.SizeMode = PictureBoxSizeMode.Zoom;
            img_producto.TabIndex = 11;
            img_producto.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 256);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 12;
            label6.Text = "IMAGEN";
            // 
            // btn_cambiar_imagen
            // 
            btn_cambiar_imagen.Location = new Point(26, 318);
            btn_cambiar_imagen.Name = "btn_cambiar_imagen";
            btn_cambiar_imagen.Size = new Size(226, 25);
            btn_cambiar_imagen.TabIndex = 13;
            btn_cambiar_imagen.Text = "CAMBIAR IMAGEN";
            btn_cambiar_imagen.UseVisualStyleBackColor = true;
            btn_cambiar_imagen.Click += btn_cambiar_imagen_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(46, 374);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 36);
            btn_agregar.TabIndex = 14;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(159, 374);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(84, 37);
            btn_cancelar.TabIndex = 15;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(228, 0);
            label7.Name = "label7";
            label7.Size = new Size(310, 26);
            label7.TabIndex = 16;
            label7.Text = "MANTENIMIENTO DE PRODUCTOS";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(312, 44);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(226, 23);
            txt_buscar.TabIndex = 17;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_buscar);
            Controls.Add(label7);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cambiar_imagen);
            Controls.Add(label6);
            Controls.Add(img_producto);
            Controls.Add(txt_categoria);
            Controls.Add(label5);
            Controls.Add(txt_stock);
            Controls.Add(label4);
            Controls.Add(txt_precio);
            Controls.Add(label3);
            Controls.Add(txt_descripcion);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Controls.Add(panel_productos);
            Name = "FormProductos";
            Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)img_producto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panel_productos;
        private Label label1;
        private TextBox txt_nombre;
        private TextBox txt_descripcion;
        private Label label2;
        private TextBox txt_precio;
        private Label label3;
        private TextBox txt_stock;
        private Label label4;
        private TextBox txt_categoria;
        private Label label5;
        private PictureBox img_producto;
        private Label label6;
        private Button btn_cambiar_imagen;
        private Button btn_agregar;
        private Button btn_cancelar;
        private Label label7;
        private TextBox txt_buscar;
    }
}