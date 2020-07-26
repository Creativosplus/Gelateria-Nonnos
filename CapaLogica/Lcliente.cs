using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;



namespace GelateriaNonnos.CapaLogica
{
    class Lcliente
    {
        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase DCliente 
        //de la CapaDatos
        public static string Insertar(string nombre, string apellidos, string sexo,
            string tipo_documento, string num_documento,
            string direccion, string telefono, string email)
        {
            Dcliente Obj = new Dcliente();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DCliente
        //de la CapaDatos
        public static string Editar(int idcliente, string nombre, string apellidos, string sexo,
            string tipo_documento, string num_documento,
            string direccion, string telefono, string email)
        {
            Dcliente Obj = new Dcliente();
            Obj.Idcliente = idcliente;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DCliente
        //de la CapaDatos
        public static string Eliminar(int idcliente)
        {
            Dcliente Obj = new Dcliente();
            Obj.Idcliente = idcliente;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DCliente
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Dcliente().Mostrar();
        }

        //Método BuscarApellidos que llama al método BuscarApellidos
        //de la clase DCLiente de la CapaDatos

        public static DataTable BuscarApellidos(string textobuscar)
        {
            Dcliente Obj = new Dcliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }

        //Método BuscarNum_Documento que llama al método BuscarNum_Documento
        //de la clase DCliente de la CapaDatos

        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            Dcliente Obj = new Dcliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
    }
}
