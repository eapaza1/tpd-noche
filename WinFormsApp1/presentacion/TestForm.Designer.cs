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
            panel_dinamico = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel_dinamico
            // 
            panel_dinamico.AutoScroll = true;
            panel_dinamico.Dock = DockStyle.Fill;
            panel_dinamico.FlowDirection = FlowDirection.TopDown;
            panel_dinamico.Location = new Point(0, 0);
            panel_dinamico.Name = "panel_dinamico";
            panel_dinamico.Size = new Size(800, 450);
            panel_dinamico.TabIndex = 0;
            panel_dinamico.WrapContents = false;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_dinamico);
            Name = "TestForm";
            Text = "TestForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel_dinamico;
    }
}