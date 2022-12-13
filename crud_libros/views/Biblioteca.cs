using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crud_libros.models;

namespace crud_libros
{
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.Nombre = txtNombre.Text;
            libro.Autor = txtAutor.Text;
            libro.Paginas = txtPaginas.Text;
            listLibros.Items.Add(libro);
            txtNombre.Text = null;
            txtAutor.Text = null;
            txtPaginas.Text = null;
        }

        private void listLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int index = listLibros.SelectedIndex;
            listLibros.Items.RemoveAt(index);
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = listLibros.SelectedIndex;

        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

         
        }
    }
}
