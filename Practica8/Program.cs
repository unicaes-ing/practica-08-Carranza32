using System;

namespace Practica8
{
    class Program
    { 
        static void Main(string[] args)
        {
            int opc = 0;
            bool isNumber;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Escoja una opcion");
                    Console.WriteLine("1 - Ejercicio 1");
                    Console.WriteLine("2 - Ejercicio 2");
                    Console.WriteLine("3 - Ejercicio 3");
                    Console.WriteLine("4 - Ejercicio 4");
                    Console.WriteLine("0 - Salir");
                    isNumber = int.TryParse(Console.ReadLine(), out opc);
                } while (isNumber == false || opc < 0);
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio3();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opc != 0);
        }

        private static void Ejercicio3()
        {
            double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
            int cAlumnos = 0;
            Console.WriteLine("Cuantos alumnos seran?");
            cAlumnos = Convert.ToInt32(Console.ReadLine());
            Alumno[] alumnos = new Alumno[cAlumnos];
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Nombre alumno " + (i + 1));
                alumnos[i].nombre = Console.ReadLine();
                Console.WriteLine("Nombre Carnet " + (i + 1));
                alumnos[i].carnet = Console.ReadLine();
                Console.WriteLine("Carrera alumno " + (i + 1));
                alumnos[i].carrera = Console.ReadLine();
                Console.WriteLine("nota materia 1 del alumno " + (i + 1));
                nota1 = Convert.ToInt32(Console.ReadLine());
                alumnos[i].materia1.setNota(nota1);
                Console.WriteLine("nota materia 2 del alumno " + (i + 1));
                nota2 = Convert.ToInt32(Console.ReadLine());
                alumnos[i].materia2.setNota(nota2);
                Console.WriteLine("nota materia 3 del alumno " + (i + 1));
                nota3 = Convert.ToInt32(Console.ReadLine());
                alumnos[i].materia3.setNota(nota3);
                Console.WriteLine("nota materia 4 del alumno " + (i + 1));
                nota4 = Convert.ToInt32(Console.ReadLine());
                alumnos[i].materia4.setNota(nota4);
            }
            foreach (var alumno in alumnos)
            {
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("Nombre: " + alumno.nombre);
                Console.WriteLine("Carnet: " + alumno.carnet);
                Console.WriteLine("carrera: " + alumno.carrera);
                if (alumno.materia1.getNota() > 6)
                {
                    Console.WriteLine("Materia 1: " + alumno.materia1.getNota() + " " + alumno.materia1.resultado());
                }
                else
                {
                    Console.WriteLine("Materia 1: " + alumno.materia1.getNota() + " Reprobada");
                }
                if (alumno.materia2.getNota() > 6)
                {
                    Console.WriteLine("Materia 2: " + alumno.materia2.getNota() + " " + alumno.materia2.resultado());
                }
                else
                {
                    Console.WriteLine("Materia 2: " + alumno.materia2.getNota() + " Reprobada");
                }
                if (alumno.materia3.getNota() > 6)
                {
                    Console.WriteLine("Materia 3: " + alumno.materia3.getNota() + " " + alumno.materia3.resultado());
                }
                else
                {
                    Console.WriteLine("Materia 3: " + alumno.materia3.getNota() + " Reprobada");
                }
                if (alumno.materia4.getNota() > 6)
                {
                    Console.WriteLine("Materia 4: " + alumno.materia4.getNota() + " " + alumno.materia4.resultado());
                }
                else
                {
                    Console.WriteLine("Materia 4: " + alumno.materia4.getNota() + " Reprobada");
                }


            }
        }

        private static void Ejercicio2()
        {
            Producto producto = new Producto();
            Console.WriteLine("Nombre: ");
            producto.nombre = Console.ReadLine();
            int cantidad = 0;
            do
            {
                Console.WriteLine("Ingrese la cantida: ");
                cantidad = Convert.ToInt32(Console.ReadLine());

            } while (cantidad < 0);
            producto.setCantidad(cantidad);
            double precio = 0;
            do
            {
                Console.WriteLine("Ingrese el precio: ");
                precio = Double.Parse(Console.ReadLine());
            } while (precio < 0);
            producto.setPrecio(precio);
            Console.WriteLine("Nombre producto: " + producto.nombre);
            Console.WriteLine("Cantidad: " + producto.getCantidad());
            Console.WriteLine("Precio + el iva: " + producto.getPrecio());
        }

        private static void Ejercicio1()
        {
            Estudiante estudiante = new Estudiante();
            Console.WriteLine("Carnet: ");
            estudiante.carnet = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            estudiante.nombre = Console.ReadLine();
            Console.WriteLine("Carrera: ");
            estudiante.carrera = Console.ReadLine();

            double cum = 0;

            do
            {
                Console.WriteLine("Cum: ");
                cum = Convert.ToDouble(Console.ReadLine());

            } while (cum < 0 || cum > 10);

            estudiante.setCum(cum);
            Console.WriteLine("Carnet: {0}\n Nombre: {1}\n Carrera: {2}\n Cum: {3}", estudiante.carnet, estudiante.nombre, estudiante.carrera, estudiante.getCum());
        }
    }
}
