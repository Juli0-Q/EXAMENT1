using T1;

ListaEnlasadaS l1 = new ListaEnlasadaS();
ListaEnlasadaS l2 = new ListaEnlasadaS();
int op = 0;

do
{
    Console.Clear();
    Console.WriteLine("================= Menu ==================");
    Console.WriteLine("1. Agregar carro a la primera lista");
    Console.WriteLine("2. Agregar carro a la segunda lista");
    Console.WriteLine("3. Mostrar primera lista");
    Console.WriteLine("4. Mostrar segunda lista");
    Console.WriteLine("5. Eliminar en primera lista");
    Console.WriteLine("6. Eliminar en segunda lsita");
    Console.WriteLine("7. Por cantidad de puertas en primera lista");
    Console.WriteLine("8. Por cantidad de puertas en segunda lista");
    Console.WriteLine("9. Mezclar listas");
    Console.WriteLine("10. salir");
    Console.WriteLine("Ingrese numero de opcion");
    op = int.Parse(Console.ReadLine());

    if (op <= 0 && op >= 10) Console.WriteLine("Opcion invalida");
    switch (op)
    {
        case 1:
            l1.AgregarCarro(); break;
        case 2: 
            l2.AgregarCarro(); break;
        case 3:
            l1.mostrar();
            break;
        case 4:
            l2.mostrar();
            break;
        case 5:
            Console.WriteLine("Ingrese elemento a eliminar");
            string marca = Console.ReadLine();
            l1.Elminar(marca); break;
        case 6:
            Console.WriteLine("Ingrese elemento a eliminar");
            string marca2 = Console.ReadLine();
            l2.Elminar(marca2); break;
        case 7:
            Console.WriteLine("ingrese que cantidad de puertas desea");
            int puertas = int.Parse(Console.ReadLine());
            l1.CantidadPuertas(puertas); break;
        case 8:
            Console.WriteLine("ingrese que cantidad de puertas desea");
            int puertas2 = int.Parse(Console.ReadLine());
            l1.CantidadPuertas(puertas2); break;
        case 9:
            l1.MezclarL(l2); break;
            case 10:
            Console.WriteLine("Saliendo.."); break;
        default:
            Console.WriteLine("Ingrese otra opcion"); return;

    }

} while (op != 10);
Console.ReadKey();