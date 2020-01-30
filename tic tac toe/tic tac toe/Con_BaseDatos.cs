/*
 * Created by SharpDevelop.
 * User: Juan Barrios
 * Date: 29/01/2020
 * Time: 01:52 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
	
	 class Con_BaseDatos
	{
		public string servidor = "localhost";
        public string puerto = "3306";
        public string usuario = "root";
        public string password = "";
        public string database = "bd_tic_tac_toe";
        public string dbtable = "puntosT";
        
        public string conectar()
        {
            Con_BaseDatos conexion = new Con_BaseDatos();
            string connStr =
                String.Format("server={0};port={1};user id={2}; password={3}; " +
                "database={4}; pooling=false;" +
                "Allow Zero Datetime=False;Convert Zero Datetime=True",
                conexion.servidor, conexion.puerto, conexion.usuario, conexion.password, conexion.database);

            return connStr;
        }
	 
	  public void consultar()
        {
            MySqlConnection con = new MySqlConnection(conectar());
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consultar;
            con.Open();
            Query.CommandText = "select * from puntosT";
            Query.Connection = con;
            consultar = Query.ExecuteReader();
            Console.WriteLine("Puntuacion");
            while (consultar.Read())
            {
               
                string nombre = consultar.GetString(1);
                int puntuacion = consultar.GetInt32(2);
                Console.WriteLine(" " + nombre + ":" + puntuacion);
            }
            con.Close();
            Console.WriteLine("\nPresione cualquier tecla para terminar");
            Console.ReadKey();
        }
	  
	  public void insertar(string nom)
        {
            Boolean existe = false;
            int supuntaje = 0;
            int puntaje = 1;
            int suid = 0;
            MySqlConnection con = new MySqlConnection(conectar());
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consultar;
            con.Open();
            Query.CommandText = "select * from puntosT";
            Query.Connection = con;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                int idbd = consultar.GetInt32(0);
                string nombrebd = consultar.GetString(1);
                int puntajebd= consultar.GetInt32(2);
                if (nombrebd == nom)
                {
                    existe = true;
                    suid = idbd;
                    supuntaje = puntajebd + 1;
                    Console.WriteLine(nom);
                    Console.WriteLine(nombrebd);
                }
            }
            con.Close();
            if (existe){
                con.Open();
                Query.CommandText = "UPDATE puntosT set nombre='" + nom + "', puntuacion='" + supuntaje + "' where id=" + suid + ";";
                consultar = Query.ExecuteReader();
                con.Close();
            }
            else
            {
                con.Open();
                Query.CommandText = "INSERT INTO puntosT (nombre,puntuacion) value ("+"'"+ nom + "'," + "'"+ puntaje +"')";
                consultar = Query.ExecuteReader();
                con.Close();
            }
        }
        
        
	}
	  
}
