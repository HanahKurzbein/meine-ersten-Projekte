namespace FILE_FOLDER_INVENTORY
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
            this.buttonDBget = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.btnDBsend = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnEinfügen = new System.Windows.Forms.Button();
            this.btnPrintList = new System.Windows.Forms.Button();
            this.btnÄndern = new System.Windows.Forms.Button();
            this.btnPrintSelected = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.buttonDBget);
            this.panel1.Controls.Add(this.buttonBeenden);
            this.panel1.Controls.Add(this.btnDBsend);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnEinfügen);
            this.panel1.Controls.Add(this.btnPrintList);
            this.panel1.Controls.Add(this.btnÄndern);
            this.panel1.Controls.Add(this.btnPrintSelected);
            this.panel1.Controls.Add(this.btnLöschen);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 581);
            this.panel1.TabIndex = 0;
            // 
            // buttonDBget
            // 
            this.buttonDBget.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDBget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDBget.Location = new System.Drawing.Point(3, 3);
            this.buttonDBget.Name = "buttonDBget";
            this.buttonDBget.Size = new System.Drawing.Size(102, 58);
            this.buttonDBget.TabIndex = 0;
            this.buttonDBget.Text = "DB Get Data\r\n";
            this.buttonDBget.UseVisualStyleBackColor = false;
            this.buttonDBget.Click += new System.EventHandler(this.buttonDBget_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeenden.Location = new System.Drawing.Point(3, 518);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(102, 58);
            this.buttonBeenden.TabIndex = 9;
            this.buttonBeenden.Text = "close program";
            this.buttonBeenden.UseVisualStyleBackColor = false;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // btnDBsend
            // 
            this.btnDBsend.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDBsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBsend.Location = new System.Drawing.Point(3, 67);
            this.btnDBsend.Name = "btnDBsend";
            this.btnDBsend.Size = new System.Drawing.Size(102, 58);
            this.btnDBsend.TabIndex = 3;
            this.btnDBsend.Text = "Send Data to DB";
            this.btnDBsend.UseVisualStyleBackColor = false;
            this.btnDBsend.Visible = false;
            this.btnDBsend.Click += new System.EventHandler(this.btnDBsend_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdmin.Image = global::FILE_FOLDER_INVENTORY.Properties.Resources.database_cog;
            this.btnAdmin.Location = new System.Drawing.Point(3, 451);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(102, 58);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnEinfügen
            // 
            this.btnEinfügen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEinfügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinfügen.Location = new System.Drawing.Point(3, 131);
            this.btnEinfügen.Name = "btnEinfügen";
            this.btnEinfügen.Size = new System.Drawing.Size(102, 58);
            this.btnEinfügen.TabIndex = 4;
            this.btnEinfügen.Text = "create a new record";
            this.btnEinfügen.UseVisualStyleBackColor = false;
            this.btnEinfügen.Visible = false;
            this.btnEinfügen.Click += new System.EventHandler(this.btnEinfügen_Click);
            // 
            // btnPrintList
            // 
            this.btnPrintList.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPrintList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintList.Location = new System.Drawing.Point(3, 387);
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(102, 58);
            this.btnPrintList.TabIndex = 8;
            this.btnPrintList.Text = "print selcted list";
            this.btnPrintList.UseVisualStyleBackColor = false;
            this.btnPrintList.Visible = false;
            this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
            // 
            // btnÄndern
            // 
            this.btnÄndern.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnÄndern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnÄndern.Location = new System.Drawing.Point(3, 195);
            this.btnÄndern.Name = "btnÄndern";
            this.btnÄndern.Size = new System.Drawing.Size(102, 58);
            this.btnÄndern.TabIndex = 5;
            this.btnÄndern.Text = "change record";
            this.btnÄndern.UseVisualStyleBackColor = false;
            this.btnÄndern.Visible = false;
            this.btnÄndern.Click += new System.EventHandler(this.btnÄndern_Click);
            // 
            // btnPrintSelected
            // 
            this.btnPrintSelected.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPrintSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSelected.Location = new System.Drawing.Point(3, 323);
            this.btnPrintSelected.Name = "btnPrintSelected";
            this.btnPrintSelected.Size = new System.Drawing.Size(102, 58);
            this.btnPrintSelected.TabIndex = 7;
            this.btnPrintSelected.Text = "print selected record";
            this.btnPrintSelected.UseVisualStyleBackColor = false;
            this.btnPrintSelected.Visible = false;
            this.btnPrintSelected.Click += new System.EventHandler(this.btnPrintSelected_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLöschen.Location = new System.Drawing.Point(3, 259);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(102, 58);
            this.btnLöschen.TabIndex = 6;
            this.btnLöschen.Text = "delete record";
            this.btnLöschen.UseVisualStyleBackColor = false;
            this.btnLöschen.Visible = false;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 34);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILE_FOLDER";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            " At first you have to click on button \"Get Data\".",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.listBox1.Location = new System.Drawing.Point(126, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1022, 576);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrintList;
        private System.Windows.Forms.Button btnPrintSelected;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.Button btnÄndern;
        private System.Windows.Forms.Button btnEinfügen;
        private System.Windows.Forms.Button btnDBsend;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonDBget;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label2;
    }
}

