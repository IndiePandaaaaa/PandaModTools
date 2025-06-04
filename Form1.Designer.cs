namespace PandaModTools
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.Button ButtonTest;
        
        private const string WindowName = "PandaModTools";

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonTest = new System.Windows.Forms.Button();        
            this.SuspendLayout();

            // PandaModTools window
            this.Name = WindowName;
            this.Text = WindowName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.ResumeLayout(false);

            // FlowLayout
            this.FlowLayout.Controls.Add(ButtonTest);
            this.FlowLayout.Location = new System.Drawing.Point(42, 55);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.TabIndex = 0;

            // ButtonTest
            this.ButtonTest.Location = new System.Drawing.Point(3, 3);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.TabIndex = 0;
            this.ButtonTest.Text = "ButtonTest";
        }

        #endregion
    }
}

