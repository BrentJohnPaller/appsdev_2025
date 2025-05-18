namespace WindowsFormsAppMilkyWay
{
	partial class About_Us2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_Us2));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Location = new System.Drawing.Point(44, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(123, 116);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(183, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 37);
			this.label1.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.panel5.Controls.Add(this.richTextBox1);
			this.panel5.Location = new System.Drawing.Point(34, 171);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(732, 456);
			this.panel5.TabIndex = 6;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.ForeColor = System.Drawing.Color.Navy;
			this.richTextBox1.Location = new System.Drawing.Point(12, 22);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(703, 414);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(191, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 37);
			this.label2.TabIndex = 7;
			this.label2.Text = "About Us";
			// 
			// About_Us2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(778, 682);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "About_Us2";
			this.Text = "About_Us2";
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
	}
}