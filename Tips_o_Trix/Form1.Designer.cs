﻿namespace Tips_o_Trix {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.lbl_message = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(26, 35);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 400);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(518, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(270, 33);
			this.button1.TabIndex = 1;
			this.button1.Text = "Läs data från textfil";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbl_message
			// 
			this.lbl_message.Location = new System.Drawing.Point(27, 459);
			this.lbl_message.Name = "lbl_message";
			this.lbl_message.Size = new System.Drawing.Size(761, 23);
			this.lbl_message.TabIndex = 2;
			this.lbl_message.Text = "label1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(518, 113);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(270, 33);
			this.button2.TabIndex = 3;
			this.button2.Text = "skriv data till textfil";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 490);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lbl_message);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lbl_message;
		private System.Windows.Forms.Button button2;
	}
}

