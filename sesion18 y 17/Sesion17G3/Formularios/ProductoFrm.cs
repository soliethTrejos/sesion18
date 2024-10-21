using Sesion17G3.Modelos;
using Sesion17G3.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion17G3.Formularios
{
    public partial class ProductoFrm : Form
    {
        ProductoServicio productos;
        Producto productoSe1 = new Producto();


        public ProductoFrm()
        {
            InitializeComponent();
            productos = new ProductoServicio();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            { 
            Producto prod = new Producto();
            prod.ID = int.Parse(TbID.Text);
            prod.Nombre = TbNombre.Text;
            prod.Descripcion = TbDescripcion.Text;
            prod.Precio = double.Parse(TbPrecio.Text);
            productos.AgregarProducto(prod);
                MostrarRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AsignarProductos(DataGridViewRow row )
        {
            productoSe1.ID = int.Parse(row.Cells
                [0].Value.ToString());
            productoSe1.Nombre = row.Cells
                [1].Value.ToString();
            productoSe1.Descripcion = row.Cells
                [2].Value.ToString();
            productoSe1.Precio = double.Parse(row.Cells
                [3].Value.ToString());

        }

        private void MostrarRegistros()
        {
            DgvRegistros.DataSource = null;
            DgvRegistros.DataSource = productos.Productos();
        }

        private void DgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgvRegistros_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow index = DgvRegistros.CurrentRow;
            if (index != null)
            {
                TbID.Text = index.Cells[0].Value.ToString();
                TbNombre.Text = index.Cells[1].Value.ToString();
                TbDescripcion.Text = index.Cells[2].Value.ToString();
                TbPrecio.Text = index.Cells[3].Value.ToString();
            }
        }
    }
}
