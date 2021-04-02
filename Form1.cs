using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinEstructura
{
    public struct Libro
    {
        public string titulo;
        public string autor;
        public string precio;

        public Libro( string sTitulo, string sAutor, string sPrecio)
        {
            titulo = sTitulo;
            autor = sAutor;
            precio = sPrecio;
        }
    }
    public partial class Form1 : Form
    {
        Libro libro = new Libro();
        private struct Libro2
        {
            public string titulo;
            public string autor;
            public string precio;
            public Libro2(string sTitulo, string sAutor, string sPrecio)
            {
                titulo = sTitulo;
                autor = sAutor;
                precio = sPrecio;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Libro2 libro2 = new Libro2();

            string sMensaje = string.Empty;
            libro.titulo = txtTitulo.Text;
            libro.autor = txtAutor.Text;
            libro.precio = txtPrecio.Text;
            sMensaje = string.Format("Titulo: {0} \r\nAutor: {1} \r\nPrecio: {2}", libro.titulo, libro.autor, libro.precio);
            MessageBox.Show(sMensaje, "Datos del Libro Publico");

            libro2.titulo= txtTitulo.Text;
            libro2.autor = txtAutor.Text;
            libro2.precio = txtPrecio.Text;
            sMensaje = string.Format("Titulo: {0} \r\nAutor: {1} \r\nPrecio: {2}", libro2.titulo, libro2.autor, libro2.precio);
            MessageBox.Show(sMensaje, "Datos del Libro Privado");
        }
    }
}
