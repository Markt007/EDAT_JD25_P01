namespace UI.NumerosAleatorios
{
    public partial class Form1 : Form
    {
        new List<Trabajador> trabajadores = new List<Trabajador>();
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerarTrabajador()
        {
            Random random = new Random();
            string[] nombresMasculinos = { "Juan", "Pedro", "Luis", "Carlos", "Jorge" };
            string[] nombresFemeninos = { "Ana", "Maria", "Luisa", "Carmen", "Sofia" };
            int numero = random.Next(1, 1000);
            DateTime fechaNacimiento = DateTime.Now.AddYears(-random.Next(18, 65)).AddDays(random.Next(0, 365));
            string sexo = random.Next(0, 2) == 0 ? "Masculino" : "Femenino";
            string nombre = sexo == "Masculino" ? nombresMasculinos[random.Next(nombresMasculinos.Length)] : nombresFemeninos[random.Next(nombresFemeninos.Length)];
            char grupo = (char)('A' + random.Next(0, 3));
            double sueldo = Math.Round(random.NextDouble() * 50000 + 20000, 2);
            bool seguroMedico = random.Next(0, 2) == 0;
            Trabajador nuevoTrabajador = new Trabajador(numero, nombre, fechaNacimiento, sexo, grupo, sueldo, seguroMedico);
            trabajadores.Add(nuevoTrabajador);
            //lstTrabajadores.Items.Add(nuevoTrabajador.ToString());
        }
        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            GenerarTrabajador();
            BoxNumero.Text = trabajadores.Last().GetNumero().ToString();
            BoxNombre.Text = trabajadores.Last().GetNombre();
            dateTime.Value = trabajadores.Last().GetFechaNacimiento();
            Masculino.Checked = trabajadores.Last().GetSexo() == "Masculino" ? true : false;
            Femenino.Checked = trabajadores.Last().GetSexo() == "Femenino" ? true : false;
            BoxGrupo.Text = trabajadores.Last().GetGrupo().ToString();
            BoxSueldo.Text = trabajadores.Last().GetSueldo().ToString();
            checkBoxSeguro.Checked = trabajadores.Last().GetSeguroMedico() == true ? true : false;
        }

        


    }
}
