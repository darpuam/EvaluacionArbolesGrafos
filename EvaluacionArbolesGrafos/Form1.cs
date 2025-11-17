using evaluacionArbolesGrafos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionArbolesGrafos
{
    public partial class Form1 : Form
    {
        ArbolEmpresa arbol = new ArbolEmpresa();
        GrafoRutas grafo = new GrafoRutas();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ---------------- SECCIÓN ÁRBOL ----------------
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string jefe = tbJefeSuperior.Text.Trim();
            string nombre = tbNuevoEmpleado.Text.Trim();
            string cargo = tbCargo.Text.Trim();

            if (string.IsNullOrEmpty(nombre)) { MessageBox.Show("Escriba un nombre."); return; }

            // Si el árbol está vacío, ignoramos al jefe y creamos la Raíz
            if (arbol.Raiz == null)
            {
                arbol.Insertar("", nombre, cargo);
                MessageBox.Show($"CEO {nombre} registrado como raíz.");
            }
            else
            {
                if (string.IsNullOrEmpty(jefe)) { MessageBox.Show("Debe indicar quién es el jefe."); return; }
                arbol.Insertar(jefe, nombre, cargo);
            }

            ActualizarVisualizacionArbol();
            label1.Text = "Total Personal: " + arbol.ContarPersonal(arbol.Raiz);
            LimpiarCajasArbol();
        }

        private void ActualizarVisualizacionArbol()
        {
            treeView1.Nodes.Clear();
            if (arbol.Raiz != null)
            {
                // Iniciar recursividad para pintar el árbol
                PintarNodo(arbol.Raiz, treeView1.Nodes);
                treeView1.ExpandAll();
            }
        }

        private void PintarNodo(NodoJerarquia nodo, TreeNodeCollection coleccionVista)
        {
            // Formato visual: Nombre - Cargo
            TreeNode nuevoNodoVista = coleccionVista.Add($"{nodo.Nombre} - {nodo.Cargo}");
            foreach (var hijo in nodo.Subordinados)
            {
                PintarNodo(hijo, nuevoNodoVista.Nodes);
            }
        }

        private void LimpiarCajasArbol()
        {
            tbNuevoEmpleado.Clear();
            tbCargo.Clear();
        }

        // ---------------- SECCIÓN GRAFO ----------------
        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            string edificio = tbEdificio1.Text.Trim();
            if (!string.IsNullOrEmpty(edificio))
            {
                grafo.AgregarEdificio(edificio);
                MessageBox.Show($"Edificio '{edificio}' registrado.");
            }
        }

        private void btnCrearRuta_Click(object sender, EventArgs e)
        {
            string origen = tbEdificio1.Text.Trim();
            string destino = tbEdificio2.Text.Trim();

            if (int.TryParse(tbDistancia.Text, out int distancia))
            {
                grafo.AgregarRuta(origen, destino, distancia);
                lstRutas.Items.Add($"{origen} <--> {destino} ({distancia} m)");
            }
            else
            {
                MessageBox.Show("La distancia debe ser un número entero.");
            }
        }

        private void btnCalcularRuta_Click(object sender, EventArgs e)
        {
            string inicio = tbEdificio1.Text.Trim();
            string fin = tbEdificio2.Text.Trim();

            // Llamamos a la función BFS que creamos
            string resultado = grafo.RutaMasCortaBFS(inicio, fin);

            lblResultadoRuta.Text = resultado;
            MessageBox.Show(resultado, "Ruta Calculada");
        }
    }
}

