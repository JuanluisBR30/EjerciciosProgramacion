/*
 * Created by SharpDevelop.
 * User: Juan Barrios
 * Date: 29/01/2020
 * Time: 01:01 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rockola
{
	partial class Reproductor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Label lbcancion;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pbplay;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pbpause;
		public System.Windows.Forms.Label lbgrupo;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
			this.lbcancion = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pbplay = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pbpause = new System.Windows.Forms.PictureBox();
			this.lbgrupo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbplay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbpause)).BeginInit();
			this.SuspendLayout();
			// 
			// lbcancion
			// 
			this.lbcancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbcancion.Location = new System.Drawing.Point(72, 9);
			this.lbcancion.Name = "lbcancion";
			this.lbcancion.Size = new System.Drawing.Size(124, 29);
			this.lbcancion.TabIndex = 0;
			this.lbcancion.Text = "Nombre de la cancion ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(62, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(56, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pbplay
			// 
			this.pbplay.Image = ((System.Drawing.Image)(resources.GetObject("pbplay.Image")));
			this.pbplay.Location = new System.Drawing.Point(175, 74);
			this.pbplay.Name = "pbplay";
			this.pbplay.Size = new System.Drawing.Size(56, 40);
			this.pbplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbplay.TabIndex = 2;
			this.pbplay.TabStop = false;
			this.pbplay.Click += new System.EventHandler(this.PbplayClick);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(307, 74);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(56, 40);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// pbpause
			// 
			this.pbpause.Image = ((System.Drawing.Image)(resources.GetObject("pbpause.Image")));
			this.pbpause.Location = new System.Drawing.Point(175, 74);
			this.pbpause.Name = "pbpause";
			this.pbpause.Size = new System.Drawing.Size(56, 40);
			this.pbpause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbpause.TabIndex = 4;
			this.pbpause.TabStop = false;
			this.pbpause.Visible = false;
			this.pbpause.Click += new System.EventHandler(this.PbpauseClick);
			// 
			// lbgrupo
			// 
			this.lbgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbgrupo.Location = new System.Drawing.Point(238, 9);
			this.lbgrupo.Name = "lbgrupo";
			this.lbgrupo.Size = new System.Drawing.Size(185, 29);
			this.lbgrupo.TabIndex = 5;
			this.lbgrupo.Text = "grupo";
			// 
			// Reproductor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 126);
			this.Controls.Add(this.lbgrupo);
			this.Controls.Add(this.pbpause);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pbplay);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbcancion);
			this.MaximumSize = new System.Drawing.Size(443, 164);
			this.Name = "Reproductor";
			this.Text = "Reproductor";
			this.Load += new System.EventHandler(this.ReproductorLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbplay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbpause)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
