using System;
using System.Collections.Generic;

namespace TraductorPOO
{
    // Clase que encapsula la lógica del diccionario y la traducción
    public class Traductor
    {
        // Se declara el diccionario privado para que no sea modificado directamente desde fuera
        private Dictionary<string, string> diccionario;

        // Constructor: se ejecuta automáticamente al crear un objeto de esta clase
        public Traductor()
        {
            // Inicializamos el diccionario ignorando mayúsculas y minúsculas
            diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            CargarPalabrasIniciales();
        }

        // Método privado para cargar las palabras base solicitadas en la tarea
        private void CargarPalabrasIniciales()
        {
            diccionario.Add("tiempo", "time");
            diccionario.Add("persona", "person");
            diccionario.Add("año", "year");
            diccionario.Add("camino", "way");
            diccionario.Add("forma", "way");
            diccionario.Add("día", "day");
            diccionario.Add("cosa", "thing");
            diccionario.Add("hombre", "man");
            diccionario.Add("mundo", "world");
            diccionario.Add("vida", "life");
            diccionario.Add("mano", "hand");
            diccionario.Add("parte", "part");
            diccionario.Add("niño", "child");
            diccionario.Add("ojo", "eye");
            diccionario.Add("mujer", "woman");
            diccionario.Add("lugar", "place");
            diccionario.Add("trabajo", "work");
            diccionario.Add("semana", "week");
            diccionario.Add("caso", "case");
            diccionario.Add("punto", "point");
            diccionario.Add("tema", "point");
            diccionario.Add("gobierno", "government");
            diccionario.Add("empresa", "company");
            diccionario.Add("compañía", "company");
        }

        // Método para agregar una nueva palabra validando que no exista previamente
        public bool AgregarPalabra(string espanol, string ingles)
        {
            if (!diccionario.ContainsKey(espanol))
            {
                diccionario.Add(espanol, ingles);
                return true; // Retorna verdadero si se agregó con éxito
            }
            return false; // Retorna falso si la palabra ya existe
        }

        // Método para procesar y traducir la frase palabra por palabra
        public string TraducirFrase(string frase)
        {
            // Separamos la frase en palabras usando el espacio
            string[] palabras = frase.Split(' ');
            
            for (int i = 0; i < palabras.Length; i++)
            {
                // Limpiamos la palabra de signos de puntuación básicos para buscarla en el diccionario
                string palabraLimpia = palabras[i].Trim(new char[] { ',', '.', ';', ':', '!', '?' });

                // Si la palabra está en el diccionario, la reemplazamos
                if (diccionario.ContainsKey(palabraLimpia))
                {
                    string traduccion = diccionario[palabraLimpia];
                    // Reemplazamos conservando los signos de puntuación originales
                    palabras[i] = palabras[i].Replace(palabraLimpia, traduccion, StringComparison.OrdinalIgnoreCase);
                }
            }

            // Unimos nuevamente el arreglo en una sola cadena de texto
            return string.Join(" ", palabras);
        }
    }
}