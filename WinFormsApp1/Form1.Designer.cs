namespace TpdNoche
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            txt_user = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_pass = new TextBox();
            label3 = new Label();
            txt_mail = new TextBox();
            label4 = new Label();
            lbl_mensaje = new Label();
            btn_crear = new Button();
            btn_actualizar = new Button();
            btn_eliminar = new Button();
            btn_cancelar = new Button();
            dgw_users = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_users).BeginInit();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.Location = new Point(135, 33);
            txt_user.Margin = new Padding(3, 2, 3, 2);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(168, 23);
            txt_user.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 63);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 5;
            label2.Text = "CONTRASEÑA";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(135, 58);
            txt_pass.Margin = new Padding(3, 2, 3, 2);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(168, 23);
            txt_pass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 92);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "CORREO";
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(135, 89);
            txt_mail.Margin = new Padding(3, 2, 3, 2);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(168, 23);
            txt_mail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 123);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "RESPUESTA";
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.Location = new Point(135, 123);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(218, 88);
            lbl_mensaje.TabIndex = 9;
            lbl_mensaje.Text = "CORREO";
            // 
            // btn_crear
            // 
            btn_crear.Location = new Point(31, 238);
            btn_crear.Margin = new Padding(3, 2, 3, 2);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(82, 22);
            btn_crear.TabIndex = 10;
            btn_crear.Text = "INSERTAR";
            btn_crear.UseVisualStyleBackColor = true;
            btn_crear.Click += btn_crear_Click;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(118, 238);
            btn_actualizar.Margin = new Padding(3, 2, 3, 2);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(82, 22);
            btn_actualizar.TabIndex = 11;
            btn_actualizar.Text = "ACTUALIZAR";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(206, 238);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(82, 22);
            btn_eliminar.TabIndex = 12;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(293, 238);
            btn_cancelar.Margin = new Padding(3, 2, 3, 2);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(82, 22);
            btn_cancelar.TabIndex = 13;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // dgw_users
            // 
            dgw_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_users.Location = new Point(465, 13);
            dgw_users.Name = "dgw_users";
            dgw_users.RowTemplate.Height = 25;
            dgw_users.Size = new Size(429, 367);
            dgw_users.TabIndex = 14;
            dgw_users.CellClick += dgw_users_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 392);
            Controls.Add(dgw_users);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_actualizar);
            Controls.Add(btn_crear);
            Controls.Add(lbl_mensaje);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_mail);
            Controls.Add(label2);
            Controls.Add(txt_pass);
            Controls.Add(label1);
            Controls.Add(txt_user);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Button button1;
        private TextBox txt_user;
        private Label label1;
        private Label label2;
        private TextBox txt_pass;
        private Label label3;
        private TextBox txt_mail;
        private Label label4;
        private Label lbl_mensaje;
        private Button btn_crear;
        private Button btn_actualizar;
        private Button btn_eliminar;
        private Button btn_cancelar;
        private DataGridView dgw_users;
        private ContextMenuStrip contextMenuStrip1;
    }
}