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
            cardProduct1 = new Componentes.CardProduct();
            cardProduct2 = new Componentes.CardProduct();
            cardProduct3 = new Componentes.CardProduct();
            SuspendLayout();
            // 
            // cardProduct1
            // 
            cardProduct1.BackColor = Color.White;
            cardProduct1.CardButonBack = Color.Cyan;
            cardProduct1.CardColor = Color.Cyan;
            cardProduct1.CardDescripcion = "Laptop AlienWare de 64Gb";
            cardProduct1.CardImage = Properties.Resources.pluma_hand;
            cardProduct1.CardPrecio = "$5000.00";
            cardProduct1.CardPriceColor = Color.Blue;
            cardProduct1.CardTitulo = "LAPTOP GAMER";
            cardProduct1.Location = new Point(56, 36);
            cardProduct1.Name = "cardProduct1";
            cardProduct1.Padding = new Padding(10);
            cardProduct1.Size = new Size(169, 320);
            cardProduct1.TabIndex = 0;
            // 
            // cardProduct2
            // 
            cardProduct2.BackColor = Color.White;
            cardProduct2.CardButonBack = Color.FromArgb(255, 128, 0);
            cardProduct2.CardColor = Color.FromArgb(255, 128, 0);
            cardProduct2.CardDescripcion = "Laptop AlienWare de 32Gb";
            cardProduct2.CardImage = Properties.Resources.hombre;
            cardProduct2.CardPrecio = "$100.00";
            cardProduct2.CardPriceColor = Color.FromArgb(255, 128, 0);
            cardProduct2.CardTitulo = "LAPTOP";
            cardProduct2.Location = new Point(259, 36);
            cardProduct2.Name = "cardProduct2";
            cardProduct2.Padding = new Padding(10);
            cardProduct2.Size = new Size(180, 320);
            cardProduct2.TabIndex = 1;
            // 
            // cardProduct3
            // 
            cardProduct3.BackColor = Color.White;
            cardProduct3.CardButonBack = Color.Lime;
            cardProduct3.CardColor = Color.Lime;
            cardProduct3.CardDescripcion = "Laptop AlienWare de 32Gb";
            cardProduct3.CardImage = (Image)resources.GetObject("cardProduct3.CardImage");
            cardProduct3.CardPrecio = "$100.00";
            cardProduct3.CardPriceColor = SystemColors.ControlText;
            cardProduct3.CardTitulo = "LAPTOP";
            cardProduct3.Location = new Point(458, 36);
            cardProduct3.Name = "cardProduct3";
            cardProduct3.Padding = new Padding(10);
            cardProduct3.Size = new Size(180, 315);
            cardProduct3.TabIndex = 2;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cardProduct3);
            Controls.Add(cardProduct2);
            Controls.Add(cardProduct1);
            Name = "TestForm";
            Text = "TestForm";
            ResumeLayout(false);
        }

        #endregion

        private Componentes.CardProduct cardProduct1;
        private Componentes.CardProduct cardProduct2;
        private Componentes.CardProduct cardProduct3;
    }
}