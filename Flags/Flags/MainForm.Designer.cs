/*
 * Created by SharpDevelop.
 * User: 23mvandehey
 * Date: 9/11/2019
 * Time: 1:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Flags
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.instructionLabel = new System.Windows.Forms.Label();
			this.countryLabel = new System.Windows.Forms.Label();
			this.finlandPictureBox = new System.Windows.Forms.PictureBox();
			this.francePictureBox = new System.Windows.Forms.PictureBox();
			this.germanyPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.germanyPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// instructionLabel
			// 
			this.instructionLabel.Location = new System.Drawing.Point(34, 9);
			this.instructionLabel.Name = "instructionLabel";
			this.instructionLabel.Size = new System.Drawing.Size(218, 23);
			this.instructionLabel.TabIndex = 0;
			this.instructionLabel.Text = "Click a flag to see the name of the country.";
			this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// countryLabel
			// 
			this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.countryLabel.Location = new System.Drawing.Point(34, 209);
			this.countryLabel.Name = "countryLabel";
			this.countryLabel.Size = new System.Drawing.Size(218, 26);
			this.countryLabel.TabIndex = 1;
			this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// finlandPictureBox
			// 
			this.finlandPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.finlandPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("finlandPictureBox.Image")));
			this.finlandPictureBox.Location = new System.Drawing.Point(12, 44);
			this.finlandPictureBox.Name = "finlandPictureBox";
			this.finlandPictureBox.Size = new System.Drawing.Size(100, 67);
			this.finlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.finlandPictureBox.TabIndex = 2;
			this.finlandPictureBox.TabStop = false;
			this.finlandPictureBox.Click += new System.EventHandler(this.FinlandPictureBox_Click);
			// 
			// francePictureBox
			// 
			this.francePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.francePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("francePictureBox.Image")));
			this.francePictureBox.Location = new System.Drawing.Point(152, 44);
			this.francePictureBox.Name = "francePictureBox";
			this.francePictureBox.Size = new System.Drawing.Size(100, 67);
			this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.francePictureBox.TabIndex = 3;
			this.francePictureBox.TabStop = false;
			this.francePictureBox.Click += new System.EventHandler(this.FrancePictureBox_Click);
			// 
			// germanyPictureBox
			// 
			this.germanyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.germanyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("germanyPictureBox.Image")));
			this.germanyPictureBox.Location = new System.Drawing.Point(78, 117);
			this.germanyPictureBox.Name = "germanyPictureBox";
			this.germanyPictureBox.Size = new System.Drawing.Size(100, 81);
			this.germanyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.germanyPictureBox.TabIndex = 4;
			this.germanyPictureBox.TabStop = false;
			this.germanyPictureBox.Click += new System.EventHandler(this.GermanyPictureBox_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.germanyPictureBox);
			this.Controls.Add(this.francePictureBox);
			this.Controls.Add(this.finlandPictureBox);
			this.Controls.Add(this.countryLabel);
			this.Controls.Add(this.instructionLabel);
			this.Name = "MainForm";
			this.Text = "Flags";
			((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.germanyPictureBox)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox germanyPictureBox;
		private System.Windows.Forms.PictureBox francePictureBox;
		private System.Windows.Forms.PictureBox finlandPictureBox;
		private System.Windows.Forms.Label countryLabel;
		private System.Windows.Forms.Label instructionLabel;
	}
}
