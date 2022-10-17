namespace Cwiki2AZ
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_komp = new System.Windows.Forms.Label();
            this.labelmonitor = new System.Windows.Forms.Label();
            this.labelkolor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_komp
            // 
            this.label_komp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_komp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label_komp.Location = new System.Drawing.Point(12, 9);
            this.label_komp.Name = "label_komp";
            this.label_komp.Size = new System.Drawing.Size(150, 80);
            this.label_komp.TabIndex = 0;
            this.label_komp.Text = "KOMPUTER";
            this.label_komp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_komp.Click += new System.EventHandler(this.label_komp_Click);
            // 
            // labelmonitor
            // 
            this.labelmonitor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelmonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelmonitor.Location = new System.Drawing.Point(168, 9);
            this.labelmonitor.Name = "labelmonitor";
            this.labelmonitor.Size = new System.Drawing.Size(150, 80);
            this.labelmonitor.TabIndex = 1;
            this.labelmonitor.Text = "MONITOR";
            this.labelmonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelmonitor.Click += new System.EventHandler(this.labelmonitor_Click);
            // 
            // labelkolor
            // 
            this.labelkolor.BackColor = System.Drawing.Color.Lime;
            this.labelkolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelkolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelkolor.Location = new System.Drawing.Point(324, 9);
            this.labelkolor.Name = "labelkolor";
            this.labelkolor.Size = new System.Drawing.Size(150, 80);
            this.labelkolor.TabIndex = 2;
            this.labelkolor.Text = "CENA ŁĄCZNA";
            this.labelkolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelkolor.Click += new System.EventHandler(this.labelkolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 106);
            this.Controls.Add(this.labelkolor);
            this.Controls.Add(this.labelmonitor);
            this.Controls.Add(this.label_komp);
            this.Name = "Form1";
            this.Text = "Lab2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_komp;
        private System.Windows.Forms.Label labelmonitor;
        private System.Windows.Forms.Label labelkolor;
    }
}

