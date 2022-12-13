namespace crud_libros
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Biblioteca ventanaBiblioteca = new Biblioteca();
            Inicio ventanaInicio = new Inicio();
            ventanaBiblioteca.ShowDialog();
        }
    }
}