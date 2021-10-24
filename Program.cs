using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET1
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaSimple LEmpleados = new ListaSimple();
            LEmpleados.Mostrar();  //la lista aun no contiene registros
            
            LEmpleados.AddEmp("Carlos", "Ramirez", 20);
            LEmpleados.AddEmp("Hugo", "Huatuco", 30);
            LEmpleados.AddEmp("Davy", "Hipólito", 25);
            LEmpleados.AddEmp("Ana", "Saavedra", 27);
            LEmpleados.AddEmp("Rafael", "Vargas", 28);
            Console.WriteLine();

            LEmpleados.Mostrar();

            LEmpleados.AddEmp("Luis", "Becerra", 27);
            LEmpleados.AddEmp("Peter", "Montalvo", 30);
            Console.WriteLine();

            LEmpleados.Mostrar();

            LEmpleados.Eliminar("Carlos", "Ramirez");

            LEmpleados.Mostrar();

            LEmpleados.Eliminar("Peter", "Montalvo");

            LEmpleados.Mostrar();

            LEmpleados.Eliminar("Hugo", "Huatuco");

            LEmpleados.Mostrar();

            Console.Read();
        }
    }
}
