using Domain.Activo_fijo;
using Domain.Enums;
using Infraestructure.Activo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1erParcial.Forms
{
    public partial class FrmActivoFijo : Form
    {
        public ActivoModel aModel { get; set; }
        public FrmActivoFijo()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void FrmActivoFijo_Load(object sender, EventArgs e)
        {
            cmbTipoActivo.Items.AddRange(Enum.GetValues(typeof(TipoActivoFijo))
                                  .Cast<object>()
                                  .ToArray());
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ActivoFijo p = new ActivoFijo()
            {
                Id = aModel.GetLastProductoId() + 1,
                NombreActivo = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                ValorActivo = (int)nudValor.Value,
                FechaAdquisicion = dtpFechaAdquisicion.Value,
                TipoActivoFijo = (TipoActivoFijo)cmbTipoActivo.SelectedIndex
            };

            aModel.Add(p);

            Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
