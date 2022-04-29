/*
 * Created by SharpDevelop.
 * User: 23mvandehey
 * Date: 9/11/2019
 * Time: 1:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Flags
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FinlandPictureBox_Click(object sender, EventArgs e)
		{
			countryLabel.Text = "Finland";
		}
		
		void FrancePictureBox_Click(object sender, EventArgs e)
		{
			countryLabel.Text = "France";
		}
		
		void GermanyPictureBox_Click(object sender, EventArgs e)
		{
			countryLabel.Text = "Germany";
		}
	}
}
