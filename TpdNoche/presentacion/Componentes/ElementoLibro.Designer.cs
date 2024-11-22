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
            this.pb_portada.Location = new System.Drawing.Point(25, 18);
            this.pb_portada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_portada.Name = "pb_portada";
            this.pb_portada.Size = new System.Drawing.Size(207, 129);
            this.pb_portada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_portada.TabIndex = 0;
            this.pb_portada.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Location = new System.Drawing.Point(25, 151);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(207, 33);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(141, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(84, 236);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 28);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "button1";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // ElementoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pb_portada);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ElementoLibro";
            this.Size = new System.Drawing.Size(252, 294);
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
