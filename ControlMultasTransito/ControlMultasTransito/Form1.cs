namespace ControlMultasTransito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //CAPTURANDO LOS DATOS 
            string placa = txtPlaca.Text;
            double velocidad = double.Parse(txtVelocidad.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime hora = DateTime.Parse(lblHora.Text);

            //PROCESANDO
            double multa = 0;

            if (velocidad <= 70)
                multa = 0;
            else if (velocidad > 70 && velocidad <= 90)
                multa = 120;
            else if (velocidad > 90 && velocidad <= 100)
                multa = 240;
            else if (velocidad > 100)
                multa = 350;
            //IMPRIMIENDO RESULTADOS

            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(lblFecha.Text);
            fila.SubItems.Add(lblHora.Text);
            fila.SubItems.Add(velocidad.ToString("0.00"));
            fila.SubItems.Add(multa.ToString("C"));
            lvMulta.Items.Add(fila);
        }

        private void lvMulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        ListViewItem item;
        private void lvMulta_MouseClick(object sender, MouseEventArgs e)
        {
            item = lvMulta.GetItemAt(e.X, e.Y);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(item != null)
            {
                lvMulta.Items.Remove(item);
                MessageBox.Show("La multa ha sido eleminada");
            }
            else
            {
                MessageBox.Show("Debe de seleccionar una multa de la lista");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de salir?",
            "Control de Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}