namespace Banco2
{
    public partial class Form1 : Form
    {
        List<CuentaUsuario> ListaUsuarios = new List<CuentaUsuario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearcuenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            { return; }
            if (inputInteres.Value > 0)
            {
                decimal.TryParse(inputInteres.Text, out decimal tasaInteres);
                CuentaAhorros usuario = new CuentaAhorros(textBoxNombre.Text,tasaInteres);
                usuario.Depositar(inputdinero.Value);
                inputInteres.Text = "0";
                inputdinero.Text = "0";
                ListaUsuarios.Add(usuario);
            }
            else
            {
                CuentaUsuario usuario = new CuentaUsuario(textBoxNombre.Text);
                usuario.Depositar(inputdinero.Value);
                inputdinero.Text = "0";
                ListaUsuarios.Add(usuario);
                
            }
            
            ActualizarCuadro();
            textBoxNombre.Text = "";

            MessageBox.Show("Usuario Agregado");
        }

        private void ActualizarCuadro()
        {
            cuadrousuario.DataSource = null;
            cuadrousuario.DataSource = ListaUsuarios;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (cuadrousuario.SelectedRows.Count == 1)
            {
                CuentaUsuario cuentaseleccionada = cuadrousuario.SelectedRows[0]
                    .DataBoundItem as CuentaUsuario;
                string mensaje = cuentaseleccionada.
                    Depositar(inputdinero.Value);
                ActualizarCuadro();
                inputdinero.Value = 0;
                MessageBox.Show(mensaje);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (cuadrousuario.SelectedRows.Count == 1)
            {
                CuentaUsuario cuentaseleccionada = cuadrousuario.SelectedRows[0].DataBoundItem as CuentaUsuario;
                string mensaje = cuentaseleccionada.Retirar(inputdinero.Value);
                ActualizarCuadro();
                inputdinero.Value = 0;
                MessageBox.Show(mensaje);
            }
        }


    }
}
