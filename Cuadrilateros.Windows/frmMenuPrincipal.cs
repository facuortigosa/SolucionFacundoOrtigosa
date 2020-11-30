using Cuadrilateros.BL;
using Cuadrilateros.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrilateros.Windows
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private List<Cuadrilatero> lista;
        RepositorioDeCuadrilateros repositorio = new RepositorioDeCuadrilateros();

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();

            if (repositorio.GetCantidad() > 0)
            {
                MostrarDatosEnGrilla();
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();

            foreach (var c in lista)
            {
                var r = ConstruirFila(c);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila(Cuadrilatero c)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            SetearFila(r, c);
            return r;
        }

        private void SetearFila(DataGridViewRow r, Cuadrilatero c)
        {
            r.Cells[cmnLado1.Index].Value = c.Lado1;
            r.Cells[cmnLado2.Index].Value = c.Lado2;
            r.Cells[cmnPerimetro.Index].Value = c.GetPerimetro();
            r.Cells[cmnArea.Index].Value = c.GetArea();

            r.Tag = c;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmCuadrilateroAE frm = new frmCuadrilateroAE();
            frm.Text = "Nuevo Objeto";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                Cuadrilatero c = frm.GetCuadrilatero();
                repositorio.Agregar(c);
                DataGridViewRow r = ConstruirFila(c);
                AgregarFila(r);
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            if (repositorio.IsModified)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar los datos?", "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    repositorio.GuardarDatosEnArchivo();
                }

            }
            Close();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDatos.SelectedRows[0];
                Cuadrilatero cuadrilatero = (Cuadrilatero)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea borrar de la lista ?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr== DialogResult.Yes)
                {
                    repositorio.Borrar(cuadrilatero);
                    dgvDatos.Rows.Remove(r);
                }
               if (dr == DialogResult.No)
                {
                    return;
                }

            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void tsbOrdenar_Click(object sender, EventArgs e)
        {

        }
        private void Lado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaPorLadoDescendente();
            MostrarDatosEnGrilla();
        }

        private void PerimetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaPerimetroAscendente();
            MostrarDatosEnGrilla();
        }


    }
}
