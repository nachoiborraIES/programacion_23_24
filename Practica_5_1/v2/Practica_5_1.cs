/* 
 * Programa que, tomando como solución la práctica 4.2, modulariza el código 
 * empleando funciones. 
 * 
 * Siempre que una función sea mayor de 50 lineas se creará una nueva función 
 * que segmente una parte del código para así, reducir el contenido de las 
 * funciones a 50 lineas.
 * 
 * Si se observan partes del código que hace la misma operación en distintos 
 * lugares, se generará una funcion que ejecute esa operación y será llamada 
 * desde las partes del código que la necesiten.
 * 
 */
 
using System;
class Practica_5_1
{
    enum opciones  {SALIR, NUEVA, LISTADO, BUSCAR, FILTRAR, ORDENAR, AVANZADO}

    struct serviciosHabitacion
    {
        public bool wifi;
        public int huespedes;
    }
    
    struct habitacion
    {
        public int numero;
        public float precio;
        public string descripcion;
        public serviciosHabitacion servicios;
    }
    static opciones MostrarMenu()
    {
        opciones opcionUsuario;
        Console.WriteLine("1. Añadir habitación");
        Console.WriteLine("2. Ver listado de habitaciones");
        Console.WriteLine("3. Buscar habitaciones");
        Console.WriteLine("4. Filtrar habitaciones");
        Console.WriteLine("5. Ordenar habitaciones");
        Console.WriteLine("6. Busqueda avanzada");
        Console.WriteLine("0. Salir del programa");
        Console.WriteLine("Elige una opción:");

        opcionUsuario = (opciones)Convert.ToInt32(Console.ReadLine()); 
        return opcionUsuario;
    }
    
    static int NuevaHabitacion(habitacion [] habitaciones, ref int cantidad)
    {
        int resultado, numHabitacion;
        string preguntaWiFi;
        
        if (cantidad < habitaciones.Length)
        {
            Console.WriteLine("Número de habitación:");
            numHabitacion = Convert.ToInt32(Console.ReadLine());
                
            if (!InsertarNumero(cantidad, habitaciones, numHabitacion))
            {
                habitaciones[cantidad].numero = numHabitacion;

                Console.WriteLine("Precio por noche:");
                habitaciones[cantidad].precio = 
                    Convert.ToSingle(Console.ReadLine());
                    
                InsertarHuespedes(cantidad, habitaciones);

                Console.WriteLine("Descripción de la habitación:");
                habitaciones[cantidad].descripcion = Console.ReadLine();

                Console.WriteLine("WiFi (S/N):");
                preguntaWiFi = Console.ReadLine();
                
                if (preguntaWiFi == "S" || preguntaWiFi == "s")
                {
                    habitaciones[cantidad].servicios.wifi = true;
                }
                else
                {
                    habitaciones[cantidad].servicios.wifi = false;
                }
                resultado = 0;
                cantidad++;
            }
            else
            {
                resultado = 1;
            }
        }
        else
        {
            resultado = 2;
        }
        return resultado;
    }
    
    static bool InsertarNumero(int cantidad, habitacion[] habitaciones, 
        int numHabitacion)
    {
        bool encontrado = false;

        for (int i = 0; i < cantidad; i++)
        {
            if (habitaciones[i].numero == numHabitacion)
            {
                encontrado = true;
            }
        }
        return encontrado;
    }
    
    static void InsertarHuespedes(int cantidad, habitacion [] habitaciones)
    {
        do
        {
            try
            {
                Console.WriteLine("Max. huéspedes:");
                habitaciones[cantidad].servicios.huespedes
                    = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Cantidad no válida");
            }
        }
        while(habitaciones[cantidad].servicios.huespedes > 5 
            || habitaciones[cantidad].servicios.huespedes < 1);
    }
    
    static void ListarHabitaciones(habitacion [] habitaciones, int cantidad)
    {
        if (cantidad > 0)
        {
            for (int i = 0; i < cantidad; i++)
            {
                MostrarDatos(habitaciones,i);
            }
        }
        else
        {
            Console.WriteLine("No hay habitaciones almacenadas");
        }
    }
    
    static void BuscarHabitacion(habitacion [] habitaciones, int cantidad, 
        int numHabitacion)
    {
        bool encontrado = false;
        if (cantidad > 0)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (habitaciones[i].numero == numHabitacion)
                {
                    MostrarDatos(habitaciones, i);
                    Console.WriteLine("Max. huespedes: " + habitaciones[i].
                        servicios.huespedes);
                        
                    if (habitaciones[i].servicios.wifi)
                    {
                        Console.WriteLine("Wifi: si");
                    }
                    else
                    {
                        Console.WriteLine("Wifi: no");
                    }
                    encontrado = true;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("Habitación no encontrada");
            }       
        }
        else
        {
            Console.WriteLine("No hay habitaciones almacenadas");                        
        }
    }
    
    static void FiltrarHabitaciones(habitacion [] habitaciones, int cantidad, 
        float filtroPrecio)
    {
        if(cantidad > 0)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (filtroPrecio >= habitaciones[i].precio)
                {
                    MostrarDatos(habitaciones, i);
                }
            }
        }
        else
        {
            Console.WriteLine("No hay habitaciones almacenadas");                                                
        }
    }
    
    static void OrdenarHabitaciones(habitacion [] habitaciones, int cantidad)
    {
        if(cantidad > 0)
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (habitaciones[i].precio > habitaciones[j].precio)
                    {
                        habitacion auxiliar = habitaciones[i];
                        habitaciones[i] = habitaciones[j];
                        habitaciones[j] = auxiliar;
                    }
                }
            }
            
            for (int i = 0; i < Math.Min(cantidad,3); i++)
            {
                MostrarDatos(habitaciones,i);
            }
        }
        else
        {
            Console.WriteLine("No hay habitaciones almacenadas");                                                
        }
    }
    
    static void BusquedaAvanzada (habitacion [] habitaciones, int cantidad, 
        string texto)
    {
        bool encontrado;
        int indice, principio, fin;
        string descripcionRecortada;
        
        if(cantidad > 0)
        {
            encontrado = false;
            for (int i = 0; i < cantidad; i++)
            {                                
                indice = habitaciones[i].descripcion.ToUpper().IndexOf(texto);
                
                if(indice>=0)
                {
                    encontrado = true;
                    principio = indice - 10;
                    fin = indice + texto.Length + 10;
                    
                    if(principio <  0)
                    {
                        principio = 0;
                    }
                    
                    if(fin > habitaciones[i].descripcion.Length)
                    {
                        fin = habitaciones[i].descripcion.Length;
                    }
                    
                    descripcionRecortada = habitaciones[i].descripcion.
                        Substring(principio, fin - principio);
                    
                    Console.WriteLine("Numero: " + 
                    habitaciones[i].numero);
                    Console.WriteLine("\tPrecio: " + 
                    habitaciones[i].precio);
                    Console.WriteLine("\t..." + descripcionRecortada
                        + "...");
                }
            }
            
            if(!encontrado)
            {
                Console.WriteLine("No hay coincidencias");
            }
        }
        else
        {
            Console.WriteLine("No hay habitaciones almacenadas");                                                
        }
    }
    
    static void MostrarDatos(habitacion [] habitaciones,int i)
    {
        Console.WriteLine("Numero: " + habitaciones[i].numero);
        Console.WriteLine("\tPrecio: " + habitaciones[i].precio);
        Console.WriteLine("\tDescripción: " + habitaciones[i].descripcion);
    }
    
    static void ResultadoInsertarHabitacion(int NuevaHabitacion)
    {
        if(NuevaHabitacion == 0)
        {
            Console.WriteLine("Habitación insertada correctamente!");
        }
        else if(NuevaHabitacion == 1)
        {
            Console.WriteLine("No se ha podido insertar la " +
                "habitación porque ya existe!");
        }
        else
        {
            Console.WriteLine("No se ha podidio insertar la " +
                "habitación porque caben más habitaciones");
        }
    }

    static void Main()
    {
        habitacion[] habitaciones = new habitacion[100];
        int cantidad = 0, numHabitacion;
        opciones opcionUsuario;
        float filtroPrecio;
        string texto;

        do
        {
            opcionUsuario = MostrarMenu();
            switch ((opciones)opcionUsuario)
            {
                case opciones.NUEVA:
                    ResultadoInsertarHabitacion(NuevaHabitacion(habitaciones, 
                        ref cantidad));
                    break;

                case opciones.LISTADO:
                    ListarHabitaciones(habitaciones, cantidad);
                    break;
                    
                case opciones.BUSCAR:
                    if (cantidad > 0)
                    {
                        Console.WriteLine("Número de la habitación a buscar:");
                        numHabitacion = Convert.ToInt32(Console.ReadLine());
                        BuscarHabitacion(habitaciones, cantidad, numHabitacion);
                    }
                    else
                    {
                        Console.WriteLine("No hay habitaciones almacenadas");                        
                    }
                    break;
                    
                case opciones.FILTRAR:
                    Console.WriteLine("Dime un precio máximo:");
                    filtroPrecio = Convert.ToSingle(Console.ReadLine());
                    FiltrarHabitaciones(habitaciones, cantidad, filtroPrecio);
                    break;
                    
                case opciones.ORDENAR:
                    OrdenarHabitaciones(habitaciones, cantidad);
                    break;
                    
                case opciones.AVANZADO:
                    Console.WriteLine("Escribe un texto para buscar");
                    texto = Console.ReadLine().ToUpper();
                    BusquedaAvanzada(habitaciones, cantidad, texto);
                    break;
            }
            
            if ((opciones)opcionUsuario != opciones.SALIR)
            {
                Console.WriteLine("Pulsa Intro para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        while ((opciones)opcionUsuario != opciones.SALIR);
        Console.WriteLine("Hasta la próxima!");
    }   
}

