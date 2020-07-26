using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta mierda no agarra :( 
using System.Data;
using CapaDatos;


namespace GelateriaNonnos.CapaLogica
{
    class Lingreso
    {
        public static string Insertar(int idtrabajador, int idproveedor, DateTime fecha,
           string tipo_comprobante, string serie, string correlativo, decimal impuesto, DataTable dtDetalles)
        {
            Dingreso Obj = new Dingreso();
            Obj.Idtrabajador = idtrabajador;
            Obj.Idproveedor = idproveedor;
            Obj.Fecha = fecha;
            Obj.Tipo_Comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Impuesto = impuesto;
            
            List<Ddetalle_ingreso> detalles = new List<Ddetalle_ingreso>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                Ddetalle_ingreso detalle = new Ddetalle_ingreso();
                detalle.Idarticulo = Convert.ToInt32(row["idarticulo"].ToString());
                detalle.Precio_Compra = Convert.ToDecimal(row["precio_compra"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Stock_Inicial = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Stock_Actual = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Fecha_Produccion = Convert.ToDateTime(row["fecha_produccion"].ToString());
                detalle.Fecha_Vencimiento = Convert.ToDateTime(row["fecha_vencimiento"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }
        public static string Anular(int idingreso)
        {
            Dingreso Obj = new Dingreso();
            Obj.Idingreso = idingreso;
            return Obj.Anular(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DIngreso
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Dingreso().Mostrar();
        }

        //Método BuscarFecha que llama al método BuscarNombre
        //de la clase DIngreso de la CapaDatos

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            Dingreso Obj = new Dingreso();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        public static DataTable MostrarDetalle(string textobuscar)
        {
            Dingreso Obj = new Dingreso();
            return Obj.MostrarDetalle(textobuscar);
        }
    }
}
