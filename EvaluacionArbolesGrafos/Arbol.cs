using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacionArbolesGrafos

{
    // Clase Nodo para el Árbol General con cualquier número de hijos
    public class NodoJerarquia
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public List<NodoJerarquia> Subordinados { get; set; } // Lista de hijos

        public NodoJerarquia(string nombre, string cargo)
        {
            Nombre = nombre;
            Cargo = cargo;
            Subordinados = new List<NodoJerarquia>();
        }
    }

    public class ArbolEmpresa
    {
        public NodoJerarquia Raiz { get; set; }

        public ArbolEmpresa()
        {
            Raiz = null;
        }

        // Método para insertar un empleado bajo un jefe
        public void Insertar(string jefeNombre, string nuevoNombre, string nuevoCargo)
        {
            if (Raiz == null)
            {
                Raiz = new NodoJerarquia(nuevoNombre, nuevoCargo);
                return;
            }

            NodoJerarquia nodoJefe = Buscar(Raiz, jefeNombre);
            if (nodoJefe != null)
            {
                nodoJefe.Subordinados.Add(new NodoJerarquia(nuevoNombre, nuevoCargo));
            }
            else
            {
                MessageBox.Show($"El jefe '{jefeNombre}' no existe en la jerarquia.");
            }
        }

        // Búsqueda Recursiva
        private NodoJerarquia Buscar(NodoJerarquia nodo, string nombre)
        {
            if (nodo.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)) return nodo;

            foreach (var hijo in nodo.Subordinados)
            {
                var encontrado = Buscar(hijo, nombre);

                if (encontrado != null) 
                    return encontrado;
            }
            return null;
        }

        // Conteo Recursivo de personal 
        public int ContarPersonal(NodoJerarquia nodo)
        {
            if (nodo == null)
                return 0;
            int cont = 1; // Contamos al nodo actual
            foreach (var hijo in nodo.Subordinados)
            {
                cont += ContarPersonal(hijo);
            }
            return cont;
        }
    }
}