namespace YilanOyunu
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
			components = new System.ComponentModel.Container();
			pnlSaha = new Panel();
			label1 = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			lblPuan = new Label();
			pnlSaha.SuspendLayout();
			SuspendLayout();
			// 
			// pnlSaha
			// 
			pnlSaha.BackColor = Color.Black;
			pnlSaha.Controls.Add(label1);
			pnlSaha.Location = new Point(28, 37);
			pnlSaha.Name = "pnlSaha";
			pnlSaha.Size = new Size(450, 450);
			pnlSaha.TabIndex = 0;
			pnlSaha.Paint += pnlSaha_Paint;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(34, -9);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 1;
			label1.Text = "label1";
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// lblPuan
			// 
			lblPuan.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblPuan.Location = new Point(50, 1);
			lblPuan.Name = "lblPuan";
			lblPuan.Size = new Size(415, 31);
			lblPuan.TabIndex = 1;
			lblPuan.Text = "Puan:00000";
			lblPuan.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(517, 523);
			Controls.Add(lblPuan);
			Controls.Add(pnlSaha);
			Name = "Form1";
			Text = "Yılan Oyunu";
			pnlSaha.ResumeLayout(false);
			pnlSaha.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlSaha;
		private System.Windows.Forms.Timer timer1;
		private Label label1;
		private Label lblPuan;
	}
}