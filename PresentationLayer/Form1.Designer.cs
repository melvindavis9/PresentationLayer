
namespace PresentationLayer
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
            this.dataGridViewP = new System.Windows.Forms.DataGridView();
            this.labelC = new System.Windows.Forms.Label();
            this.listBoxC = new System.Windows.Forms.ListBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.btnNewC = new System.Windows.Forms.Button();
            this.btnSaveC = new System.Windows.Forms.Button();
            this.btnRemoveC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.comboBoxUpdate = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.btnNewP = new System.Windows.Forms.Button();
            this.btnSaveP = new System.Windows.Forms.Button();
            this.btnRemoveP = new System.Windows.Forms.Button();
            this.labelPE = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelChosenEpisode = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNameP = new System.Windows.Forms.TextBox();
            this.labelNameP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewP
            // 
            this.dataGridViewP.AccessibleName = "dataGridViewP";
            this.dataGridViewP.AllowUserToAddRows = false;
            this.dataGridViewP.AllowUserToDeleteRows = false;
            this.dataGridViewP.AllowUserToResizeColumns = false;
            this.dataGridViewP.AllowUserToResizeRows = false;
            this.dataGridViewP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewP.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewP.MultiSelect = false;
            this.dataGridViewP.Name = "dataGridViewP";
            this.dataGridViewP.ReadOnly = true;
            this.dataGridViewP.RowHeadersVisible = false;
            this.dataGridViewP.RowTemplate.Height = 25;
            this.dataGridViewP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewP.Size = new System.Drawing.Size(535, 178);
            this.dataGridViewP.TabIndex = 0;
            this.dataGridViewP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelC.Location = new System.Drawing.Point(599, 12);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(85, 21);
            this.labelC.TabIndex = 1;
            this.labelC.Text = "Kategorier:";
            this.labelC.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxC
            // 
            this.listBoxC.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxC.FormattingEnabled = true;
            this.listBoxC.ItemHeight = 30;
            this.listBoxC.Location = new System.Drawing.Point(599, 36);
            this.listBoxC.Name = "listBoxC";
            this.listBoxC.Size = new System.Drawing.Size(295, 154);
            this.listBoxC.TabIndex = 3;
            this.listBoxC.SelectedIndexChanged += new System.EventHandler(this.listBoxC_SelectedIndexChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(599, 196);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(295, 23);
            this.textBoxC.TabIndex = 4;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // btnNewC
            // 
            this.btnNewC.Location = new System.Drawing.Point(599, 225);
            this.btnNewC.Name = "btnNewC";
            this.btnNewC.Size = new System.Drawing.Size(75, 23);
            this.btnNewC.TabIndex = 5;
            this.btnNewC.Text = "Ny";
            this.btnNewC.UseVisualStyleBackColor = true;
            this.btnNewC.Click += new System.EventHandler(this.btnNewC_Click);
            // 
            // btnSaveC
            // 
            this.btnSaveC.Location = new System.Drawing.Point(708, 224);
            this.btnSaveC.Name = "btnSaveC";
            this.btnSaveC.Size = new System.Drawing.Size(75, 23);
            this.btnSaveC.TabIndex = 6;
            this.btnSaveC.Text = "Spara";
            this.btnSaveC.UseVisualStyleBackColor = true;
            this.btnSaveC.Click += new System.EventHandler(this.btnSaveC_Click);
            // 
            // btnRemoveC
            // 
            this.btnRemoveC.Location = new System.Drawing.Point(819, 224);
            this.btnRemoveC.Name = "btnRemoveC";
            this.btnRemoveC.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveC.TabIndex = 7;
            this.btnRemoveC.Text = "Ta bort";
            this.btnRemoveC.UseVisualStyleBackColor = true;
            this.btnRemoveC.Click += new System.EventHandler(this.btnRemoveC_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 23);
            this.textBox1.TabIndex = 8;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelURL.Location = new System.Drawing.Point(12, 200);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(42, 21);
            this.labelURL.TabIndex = 9;
            this.labelURL.Text = "URL:";
            // 
            // comboBoxUpdate
            // 
            this.comboBoxUpdate.FormattingEnabled = true;
            this.comboBoxUpdate.Items.AddRange(new object[] {
            "30s",
            "1min",
            "5min",
            "10min"});
            this.comboBoxUpdate.Location = new System.Drawing.Point(211, 224);
            this.comboBoxUpdate.Name = "comboBoxUpdate";
            this.comboBoxUpdate.Size = new System.Drawing.Size(189, 23);
            this.comboBoxUpdate.TabIndex = 10;
            this.comboBoxUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(426, 224);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCategory.TabIndex = 11;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUpdate.Location = new System.Drawing.Point(211, 200);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(143, 19);
            this.labelUpdate.TabIndex = 12;
            this.labelUpdate.Text = "Uppdateringsfrekvens";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(426, 202);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 19);
            this.labelCategory.TabIndex = 13;
            this.labelCategory.Text = "Kategori";
            // 
            // btnNewP
            // 
            this.btnNewP.Location = new System.Drawing.Point(290, 268);
            this.btnNewP.Name = "btnNewP";
            this.btnNewP.Size = new System.Drawing.Size(75, 23);
            this.btnNewP.TabIndex = 14;
            this.btnNewP.Text = "Ny";
            this.btnNewP.UseVisualStyleBackColor = true;
            // 
            // btnSaveP
            // 
            this.btnSaveP.Location = new System.Drawing.Point(381, 268);
            this.btnSaveP.Name = "btnSaveP";
            this.btnSaveP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveP.TabIndex = 15;
            this.btnSaveP.Text = "Spara";
            this.btnSaveP.UseVisualStyleBackColor = true;
            // 
            // btnRemoveP
            // 
            this.btnRemoveP.Location = new System.Drawing.Point(472, 268);
            this.btnRemoveP.Name = "btnRemoveP";
            this.btnRemoveP.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveP.TabIndex = 16;
            this.btnRemoveP.Text = "Ta bort";
            this.btnRemoveP.UseVisualStyleBackColor = true;
            // 
            // labelPE
            // 
            this.labelPE.AutoSize = true;
            this.labelPE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPE.Location = new System.Drawing.Point(12, 314);
            this.labelPE.Name = "labelPE";
            this.labelPE.Size = new System.Drawing.Size(176, 21);
            this.labelPE.TabIndex = 17;
            this.labelPE.Text = "*vald podcast visas här*";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(12, 338);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(535, 244);
            this.listBox1.TabIndex = 18;
            // 
            // labelChosenEpisode
            // 
            this.labelChosenEpisode.AutoSize = true;
            this.labelChosenEpisode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChosenEpisode.Location = new System.Drawing.Point(599, 314);
            this.labelChosenEpisode.Name = "labelChosenEpisode";
            this.labelChosenEpisode.Size = new System.Drawing.Size(164, 21);
            this.labelChosenEpisode.TabIndex = 19;
            this.labelChosenEpisode.Text = "*valt avsnitt visas här*";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(599, 338);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(295, 243);
            this.richTextBox.TabIndex = 20;
            this.richTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(572, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 574);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(572, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 1);
            this.panel2.TabIndex = 22;
            // 
            // textBoxNameP
            // 
            this.textBoxNameP.Location = new System.Drawing.Point(12, 279);
            this.textBoxNameP.Name = "textBoxNameP";
            this.textBoxNameP.Size = new System.Drawing.Size(193, 23);
            this.textBoxNameP.TabIndex = 23;
            // 
            // labelNameP
            // 
            this.labelNameP.AutoSize = true;
            this.labelNameP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameP.Location = new System.Drawing.Point(12, 257);
            this.labelNameP.Name = "labelNameP";
            this.labelNameP.Size = new System.Drawing.Size(46, 19);
            this.labelNameP.TabIndex = 24;
            this.labelNameP.Text = "Namn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 598);
            this.Controls.Add(this.labelNameP);
            this.Controls.Add(this.textBoxNameP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.labelChosenEpisode);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelPE);
            this.Controls.Add(this.btnRemoveP);
            this.Controls.Add(this.btnSaveP);
            this.Controls.Add(this.btnNewP);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxUpdate);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRemoveC);
            this.Controls.Add(this.btnSaveC);
            this.Controls.Add(this.btnNewC);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.listBoxC);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.dataGridViewP);
            this.Name = "Form1";
            this.Text = "Podcasts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewP;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.ListBox listBoxC;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button btnNewC;
        private System.Windows.Forms.Button btnSaveC;
        private System.Windows.Forms.Button btnRemoveC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.ComboBox comboBoxUpdate;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button btnNewP;
        private System.Windows.Forms.Button btnSaveP;
        private System.Windows.Forms.Button btnRemoveP;
        private System.Windows.Forms.Label labelPE;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelChosenEpisode;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxNameP;
        private System.Windows.Forms.Label labelNameP;
    }
}

