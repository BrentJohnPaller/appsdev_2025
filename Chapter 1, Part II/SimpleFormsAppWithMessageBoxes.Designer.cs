namespace SimpleFormsAppWithMessageBoxes
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Suffix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MiddleName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(256, 126);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(196, 20);
            this.FirstName.TabIndex = 2;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(256, 193);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(196, 20);
            this.MiddleName.TabIndex = 3;
            this.MiddleName.TextChanged += new System.EventHandler(this.MiddleName_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(256, 379);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(196, 35);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LastName";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(256, 260);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(196, 20);
            this.LastName.TabIndex = 6;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Suffix";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Suffix
            // 
            this.Suffix.Location = new System.Drawing.Point(256, 320);
            this.Suffix.Name = "Suffix";
            this.Suffix.Size = new System.Drawing.Size(196, 20);
            this.Suffix.TabIndex = 8;
            this.Suffix.TextChanged += new System.EventHandler(this.Suffix_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "SIMPLE FORM APPLICATION";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Suffix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SimpleFormsAppWithMessageBoxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Suffix;
        private System.Windows.Forms.Label label5;
    }
}

