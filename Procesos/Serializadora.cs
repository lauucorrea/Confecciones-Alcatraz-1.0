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
                string jsonString = System.Text.Json.JsonSerializer.Serialize(GestionDatos.ConfeccionesPorFecha, opciones);

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
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                // Escribir las cabeceras de las columnas
                writer.WriteLine("Fecha Inicio,FechaFinal,Estado Confeccion,Talle,Identificador");

                // Escribir los datos de cada confección en el archivo CSV
                foreach (KeyValuePair<DateTime, List<Confeccion>> par in GestionDatos.ConfeccionesPorFecha)
                {
                    DateTime fecha = par.Key;
                    List<Confeccion> confecciones = par.Value;

                    foreach (Confeccion confeccion in confecciones)
                    {
                        if (confeccion is not null)
                        {
                            DateTime fechaInicio = confeccion.FechaInicio;
                            DateTime fechaFinal = confeccion.FechaFinal;
                            CondicionEntrega condicion = confeccion.Condicion;
                            TallePrenda talle = confeccion.Talle;
                            int idConfeccion = confeccion.IdentificadorDeConfeccion;

                            // Escribir los datos en una línea separada por comas
                            writer.WriteLine($"{fechaInicio}, {fechaFinal}, {condicion}, {talle}, {idConfeccion}");
                        }
                    }
                }
            }
        }

        public void LevantarConfeccionesJSON()
        {
            rutaArchivo = Path.Combine(rutaBase, RutaConfeccionesJSON);
            string jsonString = File.ReadAllText(rutaArchivo);

            Dictionary<DateTime, List<Confeccion>>? dict = JsonConvert.DeserializeObject<Dictionary<DateTime, List<Confeccion>>>(jsonString);

            if (dict is not null)
            {
                GestionDatos.ConfeccionesPorFecha = dict;
            }
            else
            {
                throw new Exception("No se pudo desearlizar las confecciones");
            }
            }

        }
    }
