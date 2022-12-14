namespace KURZBEIN_DATENERFASSUNG
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.btnÄndern = new System.Windows.Forms.Button();
            this.btnEinfügen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnAbbrechen);
            this.panel1.Controls.Add(this.btnLöschen);
            this.panel1.Controls.Add(this.btnÄndern);
            this.panel1.Controls.Add(this.btnEinfügen);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 446);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(277, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(488, 303);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel5.Location = new System.Drawing.Point(277, 384);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(495, 59);
            this.panel5.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Location = new System.Drawing.Point(14, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 59);
            this.panel3.TabIndex = 9;
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.Color.Thistle;
            this.btnAbbrechen.Image = global::KURZBEIN_DATENERFASSUNG.Properties.Resources.StarTrek;
            this.btnAbbrechen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbbrechen.Location = new System.Drawing.Point(14, 299);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(207, 72);
            this.btnAbbrechen.TabIndex = 8;
            this.btnAbbrechen.Text = "  Abbrechen";
            this.btnAbbrechen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.BackColor = System.Drawing.Color.Thistle;
            this.btnLöschen.Image = global::KURZBEIN_DATENERFASSUNG.Properties.Resources.StarTrek;
            this.btnLöschen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLöschen.Location = new System.Drawing.Point(14, 221);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(207, 72);
            this.btnLöschen.TabIndex = 7;
            this.btnLöschen.Text = "  Löschen";
            this.btnLöschen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLöschen.UseVisualStyleBackColor = false;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // btnÄndern
            // 
            this.btnÄndern.BackColor = System.Drawing.Color.Thistle;
            this.btnÄndern.Image = global::KURZBEIN_DATENERFASSUNG.Properties.Resources.StarTrek;
            this.btnÄndern.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnÄndern.Location = new System.Drawing.Point(14, 143);
            this.btnÄndern.Name = "btnÄndern";
            this.btnÄndern.Size = new System.Drawing.Size(207, 72);
            this.btnÄndern.TabIndex = 6;
            this.btnÄndern.Text = "  Ändern";
            this.btnÄndern.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnÄndern.UseVisualStyleBackColor = false;
            this.btnÄndern.Click += new System.EventHandler(this.btnÄndern_Click);
            // 
            // btnEinfügen
            // 
            this.btnEinfügen.BackColor = System.Drawing.Color.Thistle;
            this.btnEinfügen.Image = global::KURZBEIN_DATENERFASSUNG.Properties.Resources.StarTrek;
            this.btnEinfügen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEinfügen.Location = new System.Drawing.Point(14, 65);
            this.btnEinfügen.Name = "btnEinfügen";
            this.btnEinfügen.Size = new System.Drawing.Size(207, 72);
            this.btnEinfügen.TabIndex = 1;
            this.btnEinfügen.Text = "  Einfügen";
            this.btnEinfügen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEinfügen.UseVisualStyleBackColor = false;
            this.btnEinfügen.Click += new System.EventHandler(this.btnEinfügen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Location = new System.Drawing.Point(14, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 59);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel4.Location = new System.Drawing.Point(289, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(495, 59);
            this.panel4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEinfügen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.Button btnÄndern;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listBox1;
    }
}

