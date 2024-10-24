namespace TpdNoche.presentacion
{
    partial class FomrVentas
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
            comboBox1 = new ComboBox();
            panel_productos = new FlowLayoutPanel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            listView1 = new ListView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(panel_productos);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(22, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 627);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(498, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 33);
            comboBox1.TabIndex = 2;
            // 
            // panel_productos
            // 
            panel_productos.Location = new Point(19, 71);
            panel_productos.Name = "panel_productos";
            panel_productos.Size = new Size(729, 538);
            panel_productos.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 31);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(listView1);
            panel2.Location = new Point(818, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 627);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(222, 559);
            button2.Name = "button2";
            button2.Size = new Size(146, 38);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(39, 559);
            button1.Name = "button1";
            button1.Size = new Size(146, 38);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 511);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 31);
            textBox2.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Location = new Point(19, 121);
            listView1.Name = "listView1";
            listView1.Size = new Size(385, 387);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FomrVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FomrVentas";
            Text = "FomrVentas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel panel_productos;
        private TextBox textBox1;
        private Panel panel2;
        private ListView listView1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
    }
}