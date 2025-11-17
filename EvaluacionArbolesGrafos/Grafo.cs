using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionArbolesGrafos
{
    public class GrafoRutas
    {
        // Grafo NO dirigido y Ponderado: Edificio -> (Destino -> Metros)
        private Dictionary<string, Dictionary<string, int>> adyacencias;

        public GrafoRutas()
        {
            adyacencias = new Dictionary<string, Dictionary<string, int>>();
        }

        // Agregar Vertice (Edificio)
        public void AgregarEdificio(string nombre)
        {
            if (!adyacencias.ContainsKey(nombre))
            {
                adyacencias[nombre] = new Dictionary<string, int>();
            }
        }

        // Agregar Arista (Ruta entre dos edificios)
        public void AgregarRuta(string origen, string destino, int distancia)
        {
            if (adyacencias.ContainsKey(origen) && adyacencias.ContainsKey(destino))
            {
                // Conexión bidireccional (No dirigido)
                adyacencias[origen][destino] = distancia;
                adyacencias[destino][origen] = distancia;
            }
        }

        // Algoritmo BFS por "saltos"
        public string RutaMasCortaBFS(string inicio, string fin)
        {
            if (!adyacencias.ContainsKey(inicio) || !adyacencias.ContainsKey(fin))
                return "Error: Edificios no registrados.";

            var cola = new Queue<string>();
            var visitados = new HashSet<string>();
            var padre = new Dictionary<string, string>(); // Para reconstruir el camino

            cola.Enqueue(inicio);
            visitados.Add(inicio);
            padre[inicio] = null;

            bool encontrado = false;

            while (cola.Count > 0)
            {
                string actual = cola.Dequeue();
                if (actual == fin)
                {
                    encontrado = true;
                    break;
                }

                foreach (var vecino in adyacencias[actual])
                {
                    if (!visitados.Contains(vecino.Key))
                    {
                        visitados.Add(vecino.Key);
                        cola.Enqueue(vecino.Key);
                        padre[vecino.Key] = actual;
                    }
                }
            }

            if (encontrado) return ReconstruirCamino(padre, inicio, fin);
            else return "No existe una ruta entre estos edificios.";
        }

        private string ReconstruirCamino(Dictionary<string, string> padre, string inicio, string fin)
        {
            List<string> camino = new List<string>();
            string actual = fin;
            int distanciaTotal = 0;

            while (actual != null)
            {
                camino.Add(actual);
                string anterior = padre[actual];

                // Sumamos la distancia
                if (anterior != null)
                {
                    distanciaTotal += adyacencias[anterior][actual];
                }
                actual = anterior;
            }

            camino.Reverse();
            return $"Ruta Óptima (BFS): {string.Join(" -> ", camino)}\nDistancia Total: {distanciaTotal} metros.";
        }
    }
}