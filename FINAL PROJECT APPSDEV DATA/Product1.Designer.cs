namespace WindowsFormsAppMilkyWay
{
	partial class Product1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product1));
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.Product1panel = new System.Windows.Forms.Panel();
			this.back = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.contact_seller1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.Product1panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(23, 371);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(727, 495);
			this.richTextBox1.TabIndex = 30;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// Product1panel
			// 
			this.Product1panel.Controls.Add(this.back);
			this.Product1panel.Controls.Add(this.label1);
			this.Product1panel.Controls.Add(this.contact_seller1);
			this.Product1panel.Controls.Add(this.richTextBox1);
			this.Product1panel.Controls.Add(this.label2);
			this.Product1panel.Controls.Add(this.label4);
			this.Product1panel.Controls.Add(this.panel6);
			this.Product1panel.Location = new System.Drawing.Point(0, 0);
			this.Product1panel.Name = "Product1panel";
			this.Product1panel.Size = new System.Drawing.Size(773, 925);
			this.Product1panel.TabIndex = 31;
			// 
			// back
			// 
			this.back.AllowDrop = true;
			this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
			this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.back.FlatAppearance.BorderSize = 0;
			this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.back.Location = new System.Drawing.Point(33, 24);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(40, 36);
			this.back.TabIndex = 36;
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 326);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 25);
			this.label1.TabIndex = 35;
			this.label1.Text = "Product Description";
			// 
			// contact_seller1
			// 
			this.contact_seller1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.contact_seller1.FlatAppearance.BorderSize = 0;
			this.contact_seller1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.contact_seller1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contact_seller1.ForeColor = System.Drawing.Color.Black;
			this.contact_seller1.Location = new System.Drawing.Point(300, 188);
			this.contact_seller1.Name = "contact_seller1";
			this.contact_seller1.Size = new System.Drawing.Size(180, 46);
			this.contact_seller1.TabIndex = 34;
			this.contact_seller1.Text = "Message Seller";
			this.contact_seller1.UseVisualStyleBackColor = false;
			this.contact_seller1.Click += new System.EventHandler(this.contact_seller1_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(298, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "Quezon City, Metro Manila";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(296, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(280, 24);
			this.label4.TabIndex = 32;
			this.label4.Text = "Cowhead Pure Milk 200ml x3";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
			this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel6.Location = new System.Drawing.Point(33, 88);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(218, 182);
			this.panel6.TabIndex = 21;
			// 
			// Product1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(773, 925);
			this.Controls.Add(this.Product1panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Product1";
			this.Text = "Product1";
			this.Product1panel.ResumeLayout(false);
			this.Product1panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel Product1panel;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button contact_seller1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button back;
	}
}