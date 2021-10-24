using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET1
{
    class ListaSimple
    {
        public Nodo cabeza { get; set; }

        public void Mostrar()
        {
            Nodo actual = cabeza;
            if (actual == null)
            {
                Console.WriteLine("No hay empleados registrados\n");
            }
            else
            {
                Console.WriteLine("Empleados Registrados:\nNombre\tApellido   \tEdad\n------  ----------     ------");
                while (actual != null)
                {
                    Console.WriteLine(actual.nombre + " \t" + actual.apellido + "  \t" + actual.edad);
                    actual = actual.siguiente;
                }
                Console.WriteLine();
            }
            
        }
        public void AddEmp(string nombr, string apelli, int edad)
        {
            Console.WriteLine("Agregando nuevo empleado...");
            if (cabeza==null)
            {
                cabeza = new Nodo();
                cabeza.nombre = nombr;
                cabeza.apellido = apelli;
                cabeza.edad = edad;
                cabeza.siguiente = null;
            }
            else
            {
                Nodo actual = cabeza;
                Nodo nuevo = new Nodo();
                nuevo.nombre = nombr;
                nuevo.apellido = apelli;
                nuevo.edad = edad;
                while (actual.siguiente!=null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevo;
            }
        }
        public void Eliminar(string nomb,string ape)
        {
            Console.WriteLine("Eliminando a "+nomb+" "+ape+"\n");
            Nodo temp = new Nodo();
            Nodo aux = cabeza;
            bool elim = false;
            if (aux.nombre == nomb && aux.apellido == ape)
            {
                cabeza = cabeza.siguiente;
                aux = null;
                elim = true;
            }
            else
            {


                while (aux.nombre != nomb || aux.apellido != ape)
                {
                   temp = aux;
                   aux = aux.siguiente;
                    if (aux==null) 
                        break;  
                }
                if (aux==null)
                {
                    temp = null;
                }
                else
                {
                    temp.siguiente = aux.siguiente;
                    aux = null;
                    elim = true;
                }

            }

            if (elim == true)
            {
                Console.WriteLine("Se eliminó a "+nomb+" "+ape+" de la lista\n");
            }
            else
            {
                Console.WriteLine(nomb+" "+ape+" no se encuentra en la lista\n");
            }
        }
    }
}
