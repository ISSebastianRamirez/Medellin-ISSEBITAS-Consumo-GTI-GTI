using Infraestructura.Procesos;
using System.Data;
namespace Dominio.Terceros
{
    public class Terceros:Configuraciones
    {
        public string ActualizarTercero()
        {
            var strXML =
                                 $"<MyDataSet>" +
                                  $"<Inicial>" +
                                  $"<F_CIA>003</F_CIA>" +
                                  $"</Inicial>" +
                                  $"<Terceros>" +
                                  $"<F_CIA>003</F_CIA>" +
                                  $"<F200_ID>1000213668</F200_ID>" +
                                  $"<F200_NIT>100213668</F200_NIT>" +
                                  $"<F200_ID_TIPO_IDENT>C</F200_ID_TIPO_IDENT>" +
                                  $"<F200_IND_TIPO_TERCERO >1</F200_IND_TIPO_TERCERO>" +
                                  $"<F200_RAZON_SOCIAL>PEREZ GUAYACAN JERONIMO</F200_RAZON_SOCIAL>" +
                                  $"<F200_APELLIDO1>PEREZ</F200_APELLIDO1>" +
                                  $"<F200_APELLIDO2>GUAYACAN</F200_APELLIDO2>" +
                                  $"<F200_NOMBRES>JERONIMO</F200_NOMBRES>" +
                                  $"<F200_NOMBRE_EST>CARCAJADAS DEL SABOR</F200_NOMBRE_EST>" +
                                  $"<F015_CONTACTO>SEBASTIAN</F015_CONTACTO>" +
                                  $"<F015_DIRECCION1>BOSQUES DE SAN CARLOS</F015_DIRECCION1>" +
                                  $"<F015_ID_PAIS>169</F015_ID_PAIS>" +
                                  $"<F015_ID_DEPTO>05</F015_ID_DEPTO>" +
                                  $"<F015_ID_CIUDAD>001</F015_ID_CIUDAD>" +
                                  $"<F015_ID_BARRIO>AGUACATALA</F015_ID_BARRIO>" +
                                  $"<F015_TELEFONO>5084269</F015_TELEFONO>" +
                                  $"<F015_EMAIL>jeroperez@hotmail.com</F015_EMAIL>" +
                                  $"<F200_FECHA_NACIMIENTO>20011014</F200_FECHA_NACIMIENTO>" +
                                  $"<F015_CELULAR>3054684344</F015_CELULAR>" +
                                  $"</Terceros>" +
                                  $"<Final>" +
                                  $"<F_CIA>003</F_CIA>" +
                                  $"</Final>" +
                                  $"</MyDataSet>";

            var conexion = new Infraestructura.WSGTI.wsGenerarPlano();

            var DsResponse = conexion.ImportarDatosXML(IdDocumento, NombreDocumento, IdCompañia, StrCompañia.ToString(), StrUsuario, StrClave, strXML.ToString(),ref Ruta);

            return DsResponse;
        }
    }
}
