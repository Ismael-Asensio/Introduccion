namespace PagoEmpleados
{
    public partial class FrmPagoEmpleados : Form
    {
        public FrmPagoEmpleados()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Recuperando la inforción registrada
            string empleado = textBox1.Text;
            int hora = int.Parse(textBox2.Text);
            double costo = double.Parse(textBox3.Text);
            
            //Realizando los calculos 

            double sueldoBasico = hora * costo;
            double bonificacion = 20.0 / 100 * sueldoBasico;
            double sueldoBruto = sueldoBasico + bonificacion;
            double descuento = sueldoBruto * 12.0 / 100;
            double sueldoNeto = sueldoBruto - descuento;

            //imprimiendo Resultados
            lblMontoBruto.Text = sueldoBruto.ToString("C");
            lblMontoDescuento.Text = descuento.ToString("C");
            lblMontoNeto.Text = sueldoNeto.ToString("C");
        }

        private void FrmPagoEmpleados_Load(object sender, EventArgs e)
        {
            lblMontoBruto.Text = "";
            lblMontoDescuento.Text = "";
            lblMontoNeto.Text = String .Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            lblMontoBruto.Text = "";
            lblMontoDescuento.Text = "";
            lblMontoNeto.Text = String.Empty;
            textBox1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de salir?", 
                "Control de Pago" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);

               if (r == DialogResult.Yes)
                  this.Close();
        }
    }
}