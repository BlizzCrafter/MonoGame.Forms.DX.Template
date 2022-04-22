namespace MonoGame.Forms.DX
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.sampleControl1 = new MonoGame.Forms.DX.Controls.SampleControl();
            this.SuspendLayout();
            // 
            // sampleControl1
            // 
            this.sampleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleControl1.Location = new System.Drawing.Point(0, 0);
            this.sampleControl1.MouseHoverUpdatesOnly = false;
            this.sampleControl1.Name = "sampleControl1";
            this.sampleControl1.Size = new System.Drawing.Size(282, 253);
            this.sampleControl1.TabIndex = 0;
            this.sampleControl1.Text = "sampleControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.sampleControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SampleControl sampleControl1;
    }
}

