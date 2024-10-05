namespace TpdNoche.presentacion
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            panel_dinamico = new FlowLayoutPanel();
            cardProduct1 = new Componentes.CardProduct();
            panel_dinamico.SuspendLayout();
            SuspendLayout();
            // 
            // panel_dinamico
            // 
            panel_dinamico.Controls.Add(cardProduct1);
            panel_dinamico.Dock = DockStyle.Fill;
            panel_dinamico.Location = new Point(0, 0);
            panel_dinamico.Name = "panel_dinamico";
            panel_dinamico.Size = new Size(800, 450);
            panel_dinamico.TabIndex = 0;
            // 
            // cardProduct1
            // 
            cardProduct1.BackColor = Color.White;
            cardProduct1.CardButonBack = Color.Lime;
            cardProduct1.CardColor = Color.Lime;
            cardProduct1.CardDescripcion = "Laptop AlienWare de 32Gb";
            cardProduct1.CardImage = (Image)resources.GetObject("cardProduct1.CardImage");
            cardProduct1.CardPrecio = "$100.00";
            cardProduct1.CardPriceColor = SystemColors.ControlText;
            cardProduct1.CardTitulo = "LAPTOP";
            cardProduct1.Location = new Point(3, 3);
            cardProduct1.Name = "cardProduct1";
            cardProduct1.Padding = new Padding(10);
            cardProduct1.Size = new Size(180, 339);
            cardProduct1.TabIndex = 0;
            cardProduct1.CardAddClick += cardProduct1_CardAddClick;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_dinamico);
            Name = "TestForm";
            Text = "TestForm";
            panel_dinamico.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_dinamico;
        private Componentes.CardProduct cardProduct1;
    }
}