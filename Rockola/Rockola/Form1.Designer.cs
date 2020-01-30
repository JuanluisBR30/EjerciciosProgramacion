/*
 * Created by SharpDevelop.
 * User: Juan Barrios
 * Date: 29/01/2020
 * Time: 11:11 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rockola
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnAbajo;
		private System.Windows.Forms.Button btnDerecha;
		private System.Windows.Forms.Button btnArriba;
		private System.Windows.Forms.Button btnIzquierda;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cancion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
		private System.Windows.Forms.DataGridViewTextBoxColumn año;
		private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
		private System.Windows.Forms.DataGridView dgvArtistas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Button btnarribaA;
		private System.Windows.Forms.Button btnAbajoA;
		private System.Windows.Forms.DataGridViewImageColumn Column2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnAbajo = new System.Windows.Forms.Button();
			this.btnDerecha = new System.Windows.Forms.Button();
			this.btnArriba = new System.Windows.Forms.Button();
			this.btnIzquierda = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Cancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvArtistas = new System.Windows.Forms.DataGridView();
			this.btnarribaA = new System.Windows.Forms.Button();
			this.btnAbajoA = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvArtistas)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(37, 361);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 13;
			this.btnCancelar.Text = "Cancelar ";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(367, 301);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(48, 23);
			this.btnOk.TabIndex = 12;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// btnAbajo
			// 
			this.btnAbajo.Location = new System.Drawing.Point(353, 361);
			this.btnAbajo.Name = "btnAbajo";
			this.btnAbajo.Size = new System.Drawing.Size(75, 23);
			this.btnAbajo.TabIndex = 11;
			this.btnAbajo.Text = "Abajo";
			this.btnAbajo.UseVisualStyleBackColor = true;
			this.btnAbajo.Visible = false;
			this.btnAbajo.Click += new System.EventHandler(this.BtnAbajoClick);
			// 
			// btnDerecha
			// 
			this.btnDerecha.Location = new System.Drawing.Point(455, 301);
			this.btnDerecha.Name = "btnDerecha";
			this.btnDerecha.Size = new System.Drawing.Size(75, 23);
			this.btnDerecha.TabIndex = 10;
			this.btnDerecha.Text = "Derecha";
			this.btnDerecha.UseVisualStyleBackColor = true;
			this.btnDerecha.Click += new System.EventHandler(this.BtnDerechaClick);
			// 
			// btnArriba
			// 
			this.btnArriba.Location = new System.Drawing.Point(353, 242);
			this.btnArriba.Name = "btnArriba";
			this.btnArriba.Size = new System.Drawing.Size(75, 23);
			this.btnArriba.TabIndex = 9;
			this.btnArriba.Text = "Arriba";
			this.btnArriba.UseVisualStyleBackColor = true;
			this.btnArriba.Visible = false;
			this.btnArriba.Click += new System.EventHandler(this.BtnArribaClick);
			// 
			// btnIzquierda
			// 
			this.btnIzquierda.Location = new System.Drawing.Point(249, 301);
			this.btnIzquierda.Name = "btnIzquierda";
			this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
			this.btnIzquierda.TabIndex = 8;
			this.btnIzquierda.Text = " Izquierda";
			this.btnIzquierda.UseVisualStyleBackColor = true;
			this.btnIzquierda.Click += new System.EventHandler(this.BtnIzquierdaClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Cancion,
			this.Artista,
			this.año,
			this.Duracion});
			this.dataGridView1.Location = new System.Drawing.Point(172, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(443, 194);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.Visible = false;
			this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.DataGridView1CurrentCellChanged);
			// 
			// Cancion
			// 
			this.Cancion.HeaderText = "Cancion";
			this.Cancion.Name = "Cancion";
			this.Cancion.ReadOnly = true;
			// 
			// Artista
			// 
			this.Artista.HeaderText = "Artista o Grupo";
			this.Artista.Name = "Artista";
			this.Artista.ReadOnly = true;
			// 
			// año
			// 
			this.año.HeaderText = "Año de lanzamiento";
			this.año.Name = "año";
			this.año.ReadOnly = true;
			// 
			// Duracion
			// 
			this.Duracion.HeaderText = "Duracion";
			this.Duracion.Name = "Duracion";
			this.Duracion.ReadOnly = true;
			// 
			// dgvArtistas
			// 
			this.dgvArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvArtistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.Column2});
			this.dgvArtistas.Location = new System.Drawing.Point(172, 12);
			this.dgvArtistas.Name = "dgvArtistas";
			this.dgvArtistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvArtistas.Size = new System.Drawing.Size(443, 194);
			this.dgvArtistas.TabIndex = 14;
			this.dgvArtistas.CurrentCellChanged += new System.EventHandler(this.DgvArtistasCurrentCellChanged);
			// 
			// btnarribaA
			// 
			this.btnarribaA.Location = new System.Drawing.Point(353, 242);
			this.btnarribaA.Name = "btnarribaA";
			this.btnarribaA.Size = new System.Drawing.Size(75, 23);
			this.btnarribaA.TabIndex = 15;
			this.btnarribaA.Text = "Arriba";
			this.btnarribaA.UseVisualStyleBackColor = true;
			this.btnarribaA.Click += new System.EventHandler(this.BtnarribaAClick);
			// 
			// btnAbajoA
			// 
			this.btnAbajoA.Location = new System.Drawing.Point(353, 361);
			this.btnAbajoA.Name = "btnAbajoA";
			this.btnAbajoA.Size = new System.Drawing.Size(75, 23);
			this.btnAbajoA.TabIndex = 16;
			this.btnAbajoA.Text = "Abajo";
			this.btnAbajoA.UseVisualStyleBackColor = true;
			this.btnAbajoA.Click += new System.EventHandler(this.BtnAbajoAClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Artista o Grupo";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "imagen";
			this.Column2.Image = ((System.Drawing.Image)(resources.GetObject("Column2.Image")));
			this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column2.Name = "Column2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 414);
			this.Controls.Add(this.btnAbajoA);
			this.Controls.Add(this.btnarribaA);
			this.Controls.Add(this.dgvArtistas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnAbajo);
			this.Controls.Add(this.btnDerecha);
			this.Controls.Add(this.btnArriba);
			this.Controls.Add(this.btnIzquierda);
			this.Controls.Add(this.dataGridView1);
			this.MaximumSize = new System.Drawing.Size(759, 452);
			this.Name = "Form1";
			this.Text = "Rockola";
			this.Load += new System.EventHandler(this.Form1Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvArtistas)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
