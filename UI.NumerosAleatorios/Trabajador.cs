using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.NumerosAleatorios
{
    internal class Trabajador
    {
        private int Numero { get; set; }
        private string Nombre { get; set; }
        private DateTime FechaNacimiento { get; set; }
        private string sexo { get; set; }
        private char Grupo { get; set; }
        private double Sueldo { get; set; }
        private bool SeguroMedico { get; set; }
        
        public Trabajador(int numero, string nombre, DateTime fechaNacimiento, string sexo, char grupo, double sueldo, bool seguroMedico)
        {
            Numero = numero;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            this.sexo = sexo;
            Grupo = grupo;
            Sueldo = sueldo;
            SeguroMedico = seguroMedico;
        }
        public int GetNumero()
        {
            return Numero;
        }

        public string GetNombre()
        {
            return Nombre;
        }
        public DateTime GetFechaNacimiento()
        {
            return FechaNacimiento;
        }
        public string GetSexo()
        {
            return sexo;
        }

        public char GetGrupo()
        {
            return Grupo;
        }
        public double GetSueldo()
        {
            return Sueldo;
        }
        public bool GetSeguroMedico()
        {
            return SeguroMedico;
        }

        public override string ToString()
        {
            return $"Número: {Numero}, Nombre: {Nombre}, Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}, Sexo: {sexo}, Grupo: {Grupo}, Sueldo: {Sueldo:C}, Seguro Médico: {(SeguroMedico ? "Sí" : "No")}";
        }
    }
}
