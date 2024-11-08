namespace TpdNoche.presentacion.Componentes
{
    partial class ElementoLibro
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
            this.pb_portada = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_portada)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_portada
            // 
            this.pb_portada.Image = global::TpdNoche.Properties.Resources.agregar_producto;
            this.pb_portada.Location = new System.Drawing.Point(19, 15);
            this.pb_portada.Name = "pb_portada";
            this.pb_portada.Size = new System.Drawing.Size(155, 105);
            this.pb_portada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_portada.TabIndex = 0;
            this.pb_portada.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Location = new System.Drawing.Point(19, 123);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(155, 27);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(106, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(63, 192);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "button1";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // ElementoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pb_portada);
            this.Name = "ElementoLibro";
            this.Size = new System.Drawing.Size(189, 239);
            ((System.ComponentModel.ISupportInitialize)(this.pb_portada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_portada;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregar;
    }
}
