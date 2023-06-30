using Entidades;
using Newtonsoft.Json;
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
                string jsonString = System.Text.Json.JsonSerializer.Serialize(GestionDatos.CortesPorFecha, opciones);

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
                foreach (KeyValuePair<DateTime, List<Corte>> par in GestionDatos.CortesPorFecha)
                {
                    DateTime fecha = par.Key;
                    List<Corte> confecciones = par.Value;

                    foreach (Corte confeccion in confecciones)
                    {
                        if (confeccion is not null)
                        {
                            DateTime fechaInicio = confeccion.FechaInicio;
                            DateTime fechaFinal = confeccion.FechaFinal;
                            EtapaCorte condicion = confeccion.Etapa;
                            int idConfeccion = confeccion.IdentificadorDeConfeccion;

                            // Escribir los datos en una línea separada por comas
                            writer.WriteLine($"{fechaInicio}, {fechaFinal}, {condicion}, {idConfeccion}");
                        }
                    }
                }
            }
        }

        public void LevantarConfeccionesJSON()
        {
            rutaArchivo = Path.Combine(rutaBase, RutaConfeccionesJSON);
            string jsonString = File.ReadAllText(rutaArchivo);

            Dictionary<DateTime, List<Corte>>? dict = JsonConvert.DeserializeObject<Dictionary<DateTime, List<Corte>>>(jsonString);

            if (dict is not null)
            {
                GestionDatos.CortesPorFecha = dict;
            }
            else
            {
                throw new Exception("No se pudo desearlizar las confecciones");
            }
            }

        }
    }
