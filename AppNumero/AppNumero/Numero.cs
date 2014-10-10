using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumero
{
    class Numero
    {
        //Atributos
        int numeromayor;
        int numeromenor;


        //Constructor con Parametros
        public Numero(int numeromenor, int numeromayor)
        {
            this.numeromenor = numeromenor;
            this.numeromayor = numeromayor;
        }

        //Metodos get y set
        public int Numeromenor
        {
            get { return numeromenor; }
            set { numeromenor = value; }
        }

        public int Numeromayor
        {
            get { return numeromayor; }
            set { numeromayor = value; }
        }

        //Metodo Transacional = Operaciones
        public List<int> MostrarRango()
        {
            List<int> rango = new List<int>();
            for (int contador = numeromenor; contador <= numeromayor; contador++)
            {
                rango.Add(contador);
            }
            return rango;
        }
    }
}