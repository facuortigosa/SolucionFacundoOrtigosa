using Cuadrilateros.BL;
using Cuadrilateros.DL;
using System.Windows.Forms;

namespace Cuadrilateros.Windows
{
    public partial class frmCuadrilateroAE : Form
    {
        public frmCuadrilateroAE()
        {
            InitializeComponent();
        }

        private Cuadrilatero cuadrilatero;

        RepositorioDeCuadrilateros repositorio = new RepositorioDeCuadrilateros();

        internal Cuadrilatero GetCuadrilatero()
        {
            return cuadrilatero;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(Lado1TextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(Lado1TextBox, "Debe ingresar un numero.");
            }
            if (string.IsNullOrEmpty(Lado2TextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(Lado2TextBox, "Debe ingresar un numero.");
            }

            return valido;
        }       

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cuadrilatero==null)
                {
                    cuadrilatero = new Cuadrilatero();
                }
                cuadrilatero.Lado1 = int.Parse(Lado1TextBox.Text);
                cuadrilatero.Lado2 = int.Parse(Lado2TextBox.Text);
                repositorio.Agregar(cuadrilatero);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }


    }
}
