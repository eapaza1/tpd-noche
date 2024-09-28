namespace TpdNoche.presentacion
{
    partial class LoginForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txt_usuario = new TextBox();
            txt_password = new TextBox();
            btn_acceder = new Button();
            btn_cancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 452);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hombre;
            pictureBox1.Location = new Point(34, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(476, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(397, 115);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(223, 31);
            txt_usuario.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(397, 190);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(223, 31);
            txt_password.TabIndex = 3;
            // 
            // btn_acceder
            // 
            btn_acceder.Location = new Point(416, 277);
            btn_acceder.Name = "btn_acceder";
            btn_acceder.Size = new Size(75, 23);
            btn_acceder.TabIndex = 4;
            btn_acceder.Text = "ACCEDER";
            btn_acceder.UseVisualStyleBackColor = true;
            btn_acceder.Click += btn_acceder_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(530, 277);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 452);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_acceder);
            Controls.Add(txt_password);
            Controls.Add(txt_usuario);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txt_usuario;
        private TextBox txt_password;
        private Button btn_acceder;
        private Button btn_cancelar;
    }
}