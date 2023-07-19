using Entidades;
using System.Text;
using System.Text.Json;
namespace Procesos
{
    public static class Serializadora
    {
        static string rutaBase = string.Empty;
        static string rutaArchivo = string.Empty;
        static Serializadora()
        {
            rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            rutaBase = Path.Combine(rutaBase, "ArchivosJson/");
        }
        public static string RutaPrendasJSON
        {
            get { return Path.Combine(rutaBase, "Prendas.json"); }
        }
        public static string RutaCortesJSON
        {
            get { return Path.Combine(rutaBase, "Cortes.json"); }
        }
        public static string RutaPersonasJSON
        {
            get { return Path.Combine(rutaBase, "Personas.json"); }
        }
        public static string RutaCortesCSV
        {
            get { return Path.Combine(rutaBase, "Cortes.csv"); }
        }

        public static void GuardarCortesJSON()
        {
            try
            {
                if (!Directory.Exists(rutaBase))
                {
                    Directory.CreateDirectory(rutaBase);
                }

                JsonSerializerOptions opciones = new();
                opciones.WriteIndented = true;
                rutaArchivo = Path.Combine(RutaCortesJSON);
                string jsonString = JsonSerializer.Serialize(GestionDatos.CortesSistema, opciones);

                File.WriteAllText(rutaArchivo, jsonString);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void GuardarPrendasJSON()
        {
            try
            {
                JsonSerializerOptions opciones = new();
                opciones.WriteIndented = true;
                rutaArchivo = Path.Combine(RutaPrendasJSON);
                string jsonString = JsonSerializer.Serialize(GestionDatos.PrendasSistema, opciones);

                File.WriteAllText(rutaArchivo, jsonString);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void GuardarPersonasJSON()
        {
            try
            {
                JsonSerializerOptions opciones = new();
                opciones.WriteIndented = true;
                rutaArchivo = Path.Combine(RutaPersonasJSON);
                string jsonString = JsonSerializer.Serialize(GestionDatos.PersonasSistema, opciones);

                File.WriteAllText(rutaArchivo, jsonString);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void GuardarCortesCSV()
        {
            rutaArchivo = Path.Combine(RutaCortesCSV);
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

        public static void LevantarCortesJSON()
        {
            rutaArchivo = Path.Combine(rutaBase, RutaCortesJSON);
            string jsonString = File.ReadAllText(rutaArchivo);

            List<Corte>? cortes = JsonSerializer.Deserialize<List<Corte>>(jsonString);

            if (cortes is not null)
            {
                GestionDatos.CortesSistema = cortes;
            }
            else
            {
                throw new Exception("No se pudo deserializar las confecciones");
            }
        }
        public static void LevantarPrendasJSON()
        {
            rutaArchivo = Path.Combine(rutaBase, RutaPrendasJSON);
            string jsonString = File.ReadAllText(rutaArchivo);

            List<Prenda>? prendas = JsonSerializer.Deserialize<List<Prenda>>(jsonString);

            if (prendas is not null)
            {
                GestionDatos.PrendasSistema = prendas;
            }
            else
            {
                throw new Exception("No se pudo deserializar las prendas");
            }
        }

        public static void LevantarPersonasJSON()
        {
            rutaArchivo = Path.Combine(rutaBase, RutaPersonasJSON);
            string jsonString = File.ReadAllText(rutaArchivo);

            List<Persona>? personas = JsonSerializer.Deserialize<List<Persona>>(jsonString);

            if (personas is not null)
            {
                GestionDatos.PersonasSistema = personas;
            }
            else
            {
                throw new Exception("No se pudo deserializar los usuarios");
            }
        }

    }
}
