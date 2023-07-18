using Entidades;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
namespace Procesos
{
    public class Serializadora
    {
        static string rutaBase = string.Empty;
        static string rutaArchivo = string.Empty;
        public Serializadora()
        {
            rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        }
        public static string RutaPrendasJSON
        {
            get { return Path.Combine(rutaBase, "ArchivosJson/Prendas.json"); }
        }
        public static string RutaConfeccionesJSON
        {
            get { return Path.Combine(rutaBase, "ArchivosJson/Confecciones.json"); }
        }
        public static string RutaConfeccionesCSV
        {
            get { return Path.Combine(rutaBase, "ArchivosCsv/Confecciones.csv"); }
        }

        public static void GuardarPrendasJSON()
        {
            try
            {
                JsonSerializerOptions opciones = new();
                opciones.WriteIndented = true;
                rutaArchivo = Path.Combine(RutaPrendasJSON);
                string jsonString = System.Text.Json.JsonSerializer.Serialize(GestionDatos.PrendasSistema, opciones);

                File.WriteAllText(rutaArchivo, jsonString);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void GuardarConfeccionesJSON()
        {
            try
            {
                JsonSerializerOptions opciones = new();
                opciones.WriteIndented = true;
                rutaArchivo = Path.Combine(RutaConfeccionesJSON);
                string jsonString = System.Text.Json.JsonSerializer.Serialize(GestionDatos.CortesSistema, opciones);

                File.WriteAllText(rutaArchivo, jsonString);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void GuardarConfeccionesCSV()
        {
            rutaArchivo = Path.Combine(RutaConfeccionesCSV);
            // Crear un StreamWriter para escribir en el archivo CSV
            using (StreamWriter writer = new(rutaArchivo))
            {
                // Escribir las cabeceras de las columnas
                writer.WriteLine("Fecha Inicio,FechaFinal,Estado Confeccion,Talle,Identificador");

                // Escribir los datos de cada confección en el archivo CSV

                foreach (Corte corte in GestionDatos.CortesSistema)
                {
                    if (corte is not null)
                    {
                        DateTime fechaInicio = corte.FechaInicio;
                        DateTime fechaFinal = corte.FechaFinal;
                        int idConfeccion = corte.IdentificadorDeCorte;
                        StringBuilder sb = new();
                        List<Prenda> listaPrendasCorte = Administracion.ObtenerPrendasCorte(corte);
                        for (int i = 0; i < listaPrendasCorte.Count; i++)
                        {
                            if (i != listaPrendasCorte.Count - 1)
                            {
                                sb.Append(",");
                            }
                            sb.Append(listaPrendasCorte[i].ToString());
                        }
                        // Escribir los datos en una línea separada por comas
                        writer.WriteLine($"{fechaInicio}, {fechaFinal}, {sb.ToString()}, {idConfeccion}");
                    }
                }

            }
        }

        public void LevantarConfeccionesJSON()
        {
            rutaArchivo = Path.Combine(rutaBase, RutaConfeccionesJSON);
            string jsonString = File.ReadAllText(rutaArchivo);

            List<Corte> cortes = JsonConvert.DeserializeObject<List<Corte>>(jsonString);

            if (cortes is not null)
            {
                GestionDatos.CortesSistema = cortes;
            }
            else
            {
                throw new Exception("No se pudo desearlizar las confecciones");
            }
        }

    }
}
