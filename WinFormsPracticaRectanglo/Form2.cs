using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPractica.Entidades;

namespace WinFormsPracticaRectanglo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Rectangulo rectangulo;
        List<Borde> listaBordes = Enum.GetValues(typeof(Borde))
                .Cast<Borde>().ToList();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarComboColores();
            Crearbordes();
        }

        private void Crearbordes()
        {
            int X = 6;
            int Y = 31;
            bool check = true;
            var listaBorde = Enum.GetValues(typeof(Borde))
            .Cast<Borde>().ToList();
            foreach (var itemborde in listaBorde)
            {
                RadioButton rb = new RadioButton
                {
                    Name = $"rbt{itemborde.ToString()}",
                    Text = itemborde.ToString(),
                    Location = new Point(X, Y),
                    Checked = check
                };
                gbxBordes.Controls.Add(rb);
                Y += 32;
                check = false;
            }
        }

        private void CargarComboColores()
        {
            var listaRelleno = Enum.GetValues(typeof(Relleno))
            .Cast<Relleno>().ToList();
            comboBox1.DataSource = listaRelleno;
            comboBox1.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                rectangulo = new Rectangulo();
                rectangulo.Base = int.Parse(txtBase.Text);
                rectangulo.Altura = int.Parse(txtAltura.Text);
                rectangulo.Relleno = (Relleno)comboBox1.SelectedItem;
                rectangulo.Borde = ObtenerBorde();

                DialogResult = DialogResult.OK;
            }
        }

        private Borde ObtenerBorde()
        {
            Borde tipo = 0;
            foreach (var itemBorde in listaBordes)
            {
                var key = $"rbt{itemBorde.ToString()}";
                var rb = (RadioButton)gbxBordes.Controls.Find(key, true)[0];
                if (rb.Checked)
                {
                    tipo = itemBorde;
                    break;
                }
            }
            return tipo;
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtBase.Text, out int baseRect))
            {
                valido = false;
                errorProvider1.SetError(txtBase, "Base no numérica!!!");
            }
            else if (baseRect <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtBase, "Base no válida!!!");
            }
            if (!int.TryParse(txtAltura.Text, out int alturaRect))
            {
                valido = false;
                errorProvider1.SetError(txtBase, "Altura no numérica!!!");
            }
            else if (alturaRect <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtAltura, "Altura no válida!!!");
            }
            if (alturaRect == baseRect)
            {
                valido = false;
                errorProvider1.SetError(txtAltura, "Base y altura son iguales!!!!");
            }
            return valido;
        }

        public Rectangulo GetRectangulo()
        {
            return rectangulo;
        }
    }
}
