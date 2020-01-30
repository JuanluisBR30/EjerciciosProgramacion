/*
 * Created by SharpDevelop.
 * User: Juan Barrios
 * Date: 29/01/2020
 * Time: 11:11 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rockola
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		int indice = 0; 
		
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Form1Load(object sender, EventArgs e)
		{
			llenar();
			llenarGrupos();
			btnOk.Enabled = false;
		}
		
		public void llenar(){
			
			dataGridView1.Rows.Add("Afuera", "Caifanes", "1994", "4:50");
            dataGridView1.Rows.Add("No dejes que", "Caifanes", "1992", "4:30");
            dataGridView1.Rows.Add("Maldito duende", "Heroes del silencio", "1990", "4:05");
            dataGridView1.Rows.Add("Entre dos tierras", "Heroes del silencio", "1990", "6:05");
            dataGridView1.Rows.Add("Nada", "zoe", "2008", "3:30");
            dataGridView1.Rows.Add("Nieves de enero", "Chalino Sanchez", "1992", "4:20");
            dataGridView1.Rows.Add("Laurita Garza", "invasores", "1981", "4:10");
            
		}
		
		public void llenarGrupos(){
			
			dgvArtistas.Rows.Add( "Caifanes");
            dgvArtistas.Rows.Add( "Heroes del silencio");
            dgvArtistas.Rows.Add("zoe");
            dgvArtistas.Rows.Add( "Chalino Sanchez");
            dgvArtistas.Rows.Add( "invasores");
            
		}
		
		bool IsTheSameCellValue(int column, int row)
		{
		    DataGridViewCell cell1 = dataGridView1[column, row];
		    DataGridViewCell cell2 = dataGridView1[column, row - 1];
		    if (cell1.Value == null || cell2.Value == null)
		    {
		       return false;
		    }
		    return cell1.Value.ToString() == cell2.Value.ToString();
		}
		
		bool IsTheSameCellValu(int column, int row)
		{
		    DataGridViewCell cell1 = dgvArtistas[column, row];
		    DataGridViewCell cell2 = dgvArtistas[column, row - 1];
		    if (cell1.Value == null || cell2.Value == null)
		    {
		       return false;
		    }
		    return cell1.Value.ToString() == cell2.Value.ToString();
		}
		void BtnAbajoClick(object sender, EventArgs e)
		{
		
				int siguiente = indice + 1;
				if (siguiente < dataGridView1.Rows.Count - 1)
				{
					if (IsTheSameCellValue(0, siguiente))
				        {
				            indice++;
				            BtnAbajoClick(sender, e);
				        }
					else
                     dataGridView1.CurrentCell = dataGridView1.Rows[siguiente].Cells[dataGridView1.CurrentCell.ColumnIndex];
				}
				
		  
		}
		void BtnArribaClick(object sender, EventArgs e)
		{
			int anterior = indice - 1;

		     if (anterior <= 0)
		     {
		         indice = 0;
		         anterior = 0;
		         dataGridView1.CurrentCell = dataGridView1.Rows[anterior].Cells[dataGridView1.CurrentCell.ColumnIndex];
		         return;
		     }
		     if (IsTheSameCellValue(0, anterior))
		     {
		         indice--;
		         BtnArribaClick(sender, e);
		     }
		     else
		     {
		         indice--;
		         dataGridView1.CurrentCell = dataGridView1.Rows[anterior].Cells[dataGridView1.CurrentCell.ColumnIndex];
		     }
					
			
		}
		
		void DataGridView1CurrentCellChanged(object sender, EventArgs e)
		{
				if (dataGridView1.CurrentRow != null)
        		indice = dataGridView1.CurrentRow.Index;
		}
		void BtnOkClick(object sender, EventArgs e)
		{
			//string nomCancion;
			Reproductor rep = new Reproductor();
			rep.Show();
			
			rep.lbcancion.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			rep.lbgrupo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			rep.Show();
		}
		void BtnDerechaClick(object sender, EventArgs e)
		{
			
			dgvArtistas.Visible = false;
			dataGridView1.Visible = true;
			btnArriba.Visible = true;
			btnAbajo.Visible = true;
			btnarribaA.Visible = false;
			btnAbajoA.Visible = false;
			btnOk.Enabled = true;
			
		}
		void BtnIzquierdaClick(object sender, EventArgs e)
		{
			dgvArtistas.Visible = true;
			dataGridView1.Visible = false;
			btnArriba.Visible = false;
			btnAbajo.Visible = false;
			btnarribaA.Visible = true;
			btnAbajoA.Visible = true;
			btnOk.Enabled = false;
		}
		void BtnAbajoAClick(object sender, EventArgs e)
		{
			int siguiente = indice + 1;
				if (siguiente < dgvArtistas.Rows.Count - 1)
				{
					if (IsTheSameCellValue(0, siguiente))
				        {
				            indice++;
				            BtnAbajoClick(sender, e);
				        }
					else
                     dgvArtistas.CurrentCell = dgvArtistas.Rows[siguiente].Cells[dgvArtistas.CurrentCell.ColumnIndex];
				}
				
		}
		void BtnarribaAClick(object sender, EventArgs e)
		{
			int anterior = indice - 1;

		     if (anterior <= 0)
		     {
		         indice = 0;
		         anterior = 0;
		         dgvArtistas.CurrentCell = dgvArtistas.Rows[anterior].Cells[dgvArtistas.CurrentCell.ColumnIndex];
		         return;
		     }
		     if (IsTheSameCellValu(0, anterior))
		     {
		         indice--;
		         BtnArribaClick(sender, e);
		     }
		     else
		     {
		         indice--;
		         dgvArtistas.CurrentCell = dgvArtistas.Rows[anterior].Cells[dgvArtistas.CurrentCell.ColumnIndex];
		     }
					
		}
		void DgvArtistasCurrentCellChanged(object sender, EventArgs e)
		{
			if (dgvArtistas.CurrentRow != null)
        		indice = dgvArtistas.CurrentRow.Index;
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
