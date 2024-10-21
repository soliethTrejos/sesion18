using Sesion17G3.Formularios;

namespace Sesion17G3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MostrarHora();
            MostarFecha();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoFrm frm = new ProductoFrm();
            frm.MdiParent = this;
            frm.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void MostarFecha()
        {
            LabelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void MostrarHora()
        {
            LabelHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            MostrarHora();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarHora();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
