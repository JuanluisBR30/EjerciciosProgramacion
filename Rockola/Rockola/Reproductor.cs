/*
 * Created by SharpDevelop.
 * User: Juan Barrios
 * Date: 29/01/2020
 * Time: 01:01 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rockola
{
	/// <summary>
	/// Description of Reproductor.
	/// </summary>
	public partial class Reproductor : Form
	{
		public Reproductor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ReproductorLoad(object sender, EventArgs e)
		{
			
				
				
		}
		void PbplayClick(object sender, EventArgs e)
		{
			
            pbplay.Visible = false;
            pbpause.Visible = true;
		}
		void PbpauseClick(object sender, EventArgs e)
		{
			pbplay.Visible = true;
			pbpause.Visible = false;
		}
	}
}
