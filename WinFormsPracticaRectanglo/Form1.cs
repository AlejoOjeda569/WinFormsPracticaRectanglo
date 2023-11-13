using System.Drawing;
using WinForms.Datos;
using WinFormsPractica.Entidades;

namespace WinFormsPracticaRectanglo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        RepositorioDatos repositorio = new RepositorioDatos();
        List<Rectangulo> rectanguloslista;
        private void Form1_Load(object sender, EventArgs e)
        {
            rectanguloslista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var rectangulo in rectanguloslista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, rectangulo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Rectangulo rectangulo)
        {
            r.Cells[colBase.Index].Value = rectangulo.Base;
            r.Cells[colAltura.Index].Value = rectangulo.Altura;
            r.Cells[colBorde.Index].Value = rectangulo.Borde;
            r.Cells[colRelleno.Index].Value = rectangulo.Relleno;
            r.Cells[colSuperficie.Index].Value = rectangulo.GetArea();
            r.Cells[colPerimetro.Index].Value = rectangulo.GetPerimetro();

            r.Tag = rectangulo;
        }


        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2() { Text = "Nuevo formulario" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Rectangulo rectangulo = frm.GetRectangulo();
            repositorio.Agregar(rectangulo);
            var r = ConstruirFila();
            SetearFila(r, rectangulo);
            AgregarFila(r);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea dar de baja el cuadrado?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Rectangulo rectangulo = filaSeleccionada.Tag as Rectangulo;
            repositorio.Borrar(rectangulo);

            

            QuitarFila(filaSeleccionada);
            MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK,
    MessageBoxIcon.Information);

        }

        private void QuitarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Remove(r);
        }
    }
}