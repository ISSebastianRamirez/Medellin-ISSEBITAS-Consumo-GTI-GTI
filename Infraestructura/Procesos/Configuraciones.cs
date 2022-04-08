using Infraestructura.CRUD;
using System;
using System.Data;

namespace Infraestructura.Procesos
{
    public class Configuraciones: BDConsulta
    {
        public static WSGTI.wsGenerarPlano _WebServiceGTI = new WSGTI.wsGenerarPlano();
        public static int IdDocumento;
        public static string NombreDocumento;
        public static int IdCompañia;
        public static int StrCompañia;
        public static string StrUsuario;
        public static string StrClave;
        public static string Ruta;
        public void Obtener()
        {
            //Se crea un DataSet para ejecutar el procedimiento almacenado
            DataSet DsConfiguraciones = EjecutarSP("sp_ObtenerPropiedades");
            //Se le mandan las variables al procedimiento almacenado para que pueda realizar la conexion
            //con el web service de siesa y la base de datos
            IdDocumento = Convert.ToInt32(DsConfiguraciones.Tables[0].Rows[0]["IdDocumento"]);
            NombreDocumento = Convert.ToString(DsConfiguraciones.Tables[0].Rows[0]["NombreDocumento"]);
            IdCompañia = Convert.ToInt32(DsConfiguraciones.Tables[0].Rows[0]["IdCompañia"]);
            StrCompañia = Convert.ToInt32(DsConfiguraciones.Tables[0].Rows[0]["StrCompañia"]);
            StrUsuario = Convert.ToString(DsConfiguraciones.Tables[0].Rows[0]["StrUsuario"]);
            StrClave = Convert.ToString(DsConfiguraciones.Tables[0].Rows[0]["StrClave"]);
            Ruta = Convert.ToString(DsConfiguraciones.Tables[0].Rows[0]["Ruta"]);

        }
    }
}
