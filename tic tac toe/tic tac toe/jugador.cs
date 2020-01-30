/*
 * Created by SharpDevelop.
 * User: Juan Barrios
 * Date: 29/01/2020
 * Time: 01:44 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
	
	 class jugador
	{
		public string nombre { get; set; }
        public string caracter{ get; set; }
        public int puntos { get; set; }
	}
	 
	 class tablero {
	 	public string[] position = new string[9];
	 }
}
