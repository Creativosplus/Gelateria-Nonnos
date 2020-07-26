using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace GelateriaNonnos.CapaDatos
{
    class Dcategoria
    {
        private int _Idcategoria;
        private string _Nombre;
        private string _Descripcion;
        private string _TextoBuscar;

        public int Idcategoria
        {
            get => _Idcategoria;
            set => _Idcategoria = value;
        }

        public string Nombre
        {
            get => _Nombre;
            set => _Nombre = value;
        }

        public string Descripcion
        {
            get => _Descripcion;
            set => _Descripcion = value;
        }

        public string TextoBuscar
        {
            get => _TextoBuscar;
            set => _TextoBuscar = value;
        }

        //Constructor vacio publico 
        public Dcategoria()
        {

        }

        //Constructor con todos los parametros 

        public Dcategoria(int idcategoria, string nombre, string descripcion, string textobuscar)
        {
            this.Idcategoria = idcategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.TextoBuscar = textobuscar;

        }

        //Metodo insertar en la categoria 

        public string Insertar(Dcategoria Categoria)
        {
            string resp = "";
            SqlConnection Sqlconect = new SqlConnection();
            try
            {
                //codigo para la conexion 
                Sqlconect.ConnectionString = conexion.Cn;
                Sqlconect.Open();

                //Establecer comandos para ejecutar sentencias en sql
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Sqlconect;
                SqlCmd.CommandText = "spinsertar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros que recibe el procedimieento almacenado 
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcategoria);

                //Parameto de nombre que recibe almacenado 
                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Categoria.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                //Parameto de descripcion que recibe almacenado 
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Categoria.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecutamos el comando 

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ingreso el registro";



            }
            catch (Exception ex)
            {
                //Por si captura algun posible error 
                resp = ex.Message;
            }
            //Para finalizar la conexion con la base de datos
            finally
            {
                if (Sqlconect.State == ConnectionState.Open) Sqlconect.Close();
            }
            return resp;
        }

        //Metodo para editar en la categoria 
        public string Editar(Dcategoria Categoria)
        {
            string resp = "";
            SqlConnection Sqlconect = new SqlConnection();
            try
            {
                //codigo para la conexion 
                Sqlconect.ConnectionString = conexion.Cn;
                Sqlconect.Open();

                //Establecer comandos para ejecutar sentencias en sql
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Sqlconect;
                SqlCmd.CommandText = "speditar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros que recibe el procedimieento almacenado 
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);

                //Parameto de nombre que recibe almacenado 
                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Categoria.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                //Parameto de descripcion que recibe almacenado 
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Categoria.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecutamos el comando 

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se actualizo el registro";



            }
            catch (Exception ex)
            {
                //Por si captura algun posible error 
                resp = ex.Message;
            }
            //Para finalizar la conexion con la base de datos
            finally
            {
                if (Sqlconect.State == ConnectionState.Open) Sqlconect.Close();
            }
            return resp;

        }

        //Metodo para eliminar 

        public string Eliminar(Dcategoria Categoria)
        {
            string resp = "";
            SqlConnection Sqlconect = new SqlConnection();
            try
            {
                //codigo para la conexion 
                Sqlconect.ConnectionString = conexion.Cn;
                Sqlconect.Open();

                //Establecer comandos para ejecutar sentencias en sql
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Sqlconect;
                SqlCmd.CommandText = "speliminar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros que recibe el procedimieento almacenado 
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);



                //Ejecutamos el comando 

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se elimino el registro";



            }
            catch (Exception ex)
            {
                //Por si captura algun posible error 
                resp = ex.Message;
            }
            //Para finalizar la conexion con la base de datos
            finally
            {
                if (Sqlconect.State == ConnectionState.Open) Sqlconect.Close();
            }
            return resp;
        }

        //Mostrar todos los valores 

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Categoria");
            SqlConnection Sqlconect = new SqlConnection();
            try
            {
                Sqlconect.ConnectionString = conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Sqlconect;
                SqlCmd.CommandText = "spmostrar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //ejecutar el comando y llenar la tabla de datos
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;

            }
            return DtResultado;

        }

        //Mostrar Buscar por nombre

        public DataTable BuscarNombre(Dcategoria Categoria)
        {
            DataTable DtResultado = new DataTable("Categoria");
            SqlConnection Sqlconect = new SqlConnection();
            try
            {
                Sqlconect.ConnectionString = conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Sqlconect;
                SqlCmd.CommandText = "spbuscar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Categoria.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                //ejecutar el comando y llenar la tabla de datos
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;

            }
            return DtResultado;
        }
    }
}
