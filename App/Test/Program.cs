using System;
using System.Collections.Generic;
using Model.entities;
using Controller.AppRepositories;

namespace Test
{
    class Program
    {
        //static option = 0; // Global varible
        static IRMunicipio _repoMunicipio = new RMunicipio(new MyAppContext()); //This is how to use the interface
        static void Main(string[] args)
        {
            menu();
        }
        private static void menu()
        {
            Console.WriteLine();
            Console.WriteLine("\n------MENU DE OPCIONES------");
            Console.WriteLine("1. Crear Municipio");
            Console.WriteLine("2. Buscar Municipio");
            Console.WriteLine("3. Eliminar Municipio");
            Console.WriteLine("4. Actualizar Municipio");
            Console.WriteLine("5. Listar Municipios\n");
            Console.WriteLine(" Seleccione una de las opciones (1-5) ");
            var option = int.Parse(Console.ReadLine());

            switch (option)

            {
                case 1:
                {
                    crearMunicipio(); //this function is the responsible for calling the function in the repository
                    break;
                }
                case 2:
                {
                    buscarMunicipio();
                    break;
                }
                case 3:
                {
                    eliminarMunicipio();
                    break;
                }
                case 4:
                {
                    actualizarMunicipio();
                    break;
                }
                case 5:
                {
                    listarMunicipios();
                    break;
                }
                
                default:
                {
                    Console.WriteLine("Digite una opcion valida ( 1-5 )");
                    recargar();
                    break;
                }
            }
        }
        private static void crearMunicipio()
        {
            Municipio municipio = new Municipio();
            Console.WriteLine("Ingrese el nombre del nuevo municipio");
            municipio.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la secretaria del nuevo municipio");
            municipio.secretaria = Console.ReadLine();
            string outmsg = _repoMunicipio.createMunicipio(municipio);
            Console.WriteLine(outmsg);
            recargar();
            /*bool funciono = _repoMunicipio.createMunicipio(municipio);
            if (funciono)
            {
                Console.WriteLine("Municipio creado con exito!");
                recargar();
            }
            else
            {
                Console.WriteLine("Fallo la creacion del municipio!");
                recargar();
            }*/
        }
        private static void buscarMunicipio()
        {
            Municipio municipio = null;
            int id = 0;
            Console.WriteLine("Ingrese el ID del municipio que desea buscar\n");
            id = int.Parse(Console.ReadLine());
            municipio = _repoMunicipio.searchMunicipio(id);
            if (municipio != null)
            {
                Console.Clear();
                Console.WriteLine(municipio.id);
                Console.WriteLine(municipio.nombre);
                Console.WriteLine(municipio.secretaria);
                recargar();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No se encontro el municipio con ID " + id + " .\n");
                recargar();
            }
        }
        private static void eliminarMunicipio()
        {
            int id = 0;
            Console.WriteLine("Ingrese el ID del municipio que desea eliminar\n");
            id = int.Parse(Console.ReadLine());
            bool delete = _repoMunicipio.deleteMunicipio(id);
            if (delete)
            {
                Console.WriteLine("Se elimino el municipio con ID " + id + " \n");
                recargar();    
            }
            else
            {
                Console.WriteLine("No se puede eliminar, no existe el municipio con ID " + id + " \n");
                recargar();  
            }
        }
        private static void actualizarMunicipio()
        {
            Municipio municipio = new Municipio();
            Console.WriteLine("Ingrese el ID del municipio que desea actualizar: ");
            municipio.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo nombre del municipio que desea actualizar: ");
            municipio.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva secretaria del municipio que desea actualizar: ");
            municipio.secretaria = Console.ReadLine();
            bool update = _repoMunicipio.updateMunicipio(municipio);
            if (update)
            {
                Console.WriteLine("Se actulizo con exito el municipio! ");
                recargar();
            }
            else
            {
                Console.WriteLine("No se pudo actulizar el municipio");
                recargar();
            }
        }
        private static void listarMunicipios()
        {
            Console.Clear();
            //special object type that should be instantiated
            List<Municipio> lstmunicipios = _repoMunicipio.listMunicipios1();
            foreach (var municipio in lstmunicipios)
            {
                Console.WriteLine(municipio.id + " - " + municipio.nombre + " - " + municipio.secretaria);
            }
            recargar();
        }
        private static void recargar()
        {
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();
            Console.Clear();
            menu();
        } 
    }
}
