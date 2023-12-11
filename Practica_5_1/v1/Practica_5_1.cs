/* 
 * Programa que gestiona un array de habitaciones de hotel. Permite añadir
 * habitaciones, buscarlas, filtrar por precio, etc. Y ahora en el nuevo parche
 * se añadira la funcion de ordenar habitaciones y busqueda avanzada.
 */
 
using System;

class Practica4
{
    enum opciones  { SALIR, NUEVA, LISTADO, BUSCAR, FILTRAR, ORDENAR, AVANZADO }

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

    static void Main()
    {
        habitacion[] habitaciones = new habitacion[100];
        int cantidad = 0, numHabitacion;
        opciones opcionUsuario;
        string texto;
        float filtroPrecio;

        do
        {
            opcionUsuario = MostrarMenu();
            
            switch (opcionUsuario)
            {
                case opciones.NUEVA:
                    int retorno = NuevaHabitacion(habitaciones, ref cantidad);
                    if(retorno == 0)
                    {
                        Console.WriteLine("Habitación añadida correctamente.");
                    }
                    else if(retorno == 1)
                    {
                        Console.WriteLine("Habitación ya existente.");
                    }
                    else
                    {
                        Console.WriteLine("No caben más habitaciones.");
                    }
                    break;

                case opciones.LISTADO:
                    ListarHabitaciones(habitaciones, cantidad);
                    break;
                    
                case opciones.BUSCAR:
                    Console.WriteLine("Número de la habitación a buscar:");
                    numHabitacion = Convert.ToInt32(Console.ReadLine());
                    BuscarHabitacion(habitaciones,cantidad,numHabitacion);
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
                    texto=Console.ReadLine().ToUpper();
                    BusquedaAvanzada(habitaciones, cantidad, texto);
                    break;
            }
            
            if (opcionUsuario != opciones.SALIR)
            {
                Console.WriteLine("Pulsa Intro para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        while (opcionUsuario != opciones.SALIR);
    }
    
    static opciones MostrarMenu()
    {
        Console.WriteLine("1. Añadir habitación");
        Console.WriteLine("2. Ver listado de habitaciones");
        Console.WriteLine("3. Buscar habitaciones");
        Console.WriteLine("4. Filtrar habitaciones");
        Console.WriteLine("5. Ordenar habitaciones");
        Console.WriteLine("6. Busqueda avanzada");
        Console.WriteLine("0. Salir del programa");
        Console.WriteLine("Elige una opción:");
        
        return (opciones)Convert.ToInt32(Console.ReadLine());
    }
    
    static int NuevaHabitacion(habitacion[]habitaciones, ref int cantidad)
    {
        int retorno;
        if (cantidad < habitaciones.Length)
        {
            int numHabitacion;
            int posicion;
            Console.WriteLine("Número de habitación:");
            numHabitacion = Convert.ToInt32(Console.ReadLine());
            posicion = BuscarRepetida(habitaciones, cantidad, numHabitacion);
            if (posicion < 0)
            {
                AsignarValorHabitacion(habitaciones, cantidad, numHabitacion);
                cantidad++;
                retorno = 0;
            }
            else
            {
                retorno = 1;
            }
        }
        else
        {
            retorno = 2;
        }
        return retorno;
    }
    
    static int BuscarRepetida(habitacion[]habitaciones, int cantidad,
        int numHabitacion)
    {
        int repetida = -1;
        for (int i = 0; i < cantidad; i++)
        {
            if (habitaciones[i].numero == numHabitacion)
            {
                repetida = i;
            }
        }
        return repetida;
    }
    
    static void AsignarValorHabitacion(habitacion[]habitaciones, int cantidad,
        int numHabitacion)
    {
        string preguntaWiFi;
        habitaciones[cantidad].numero = numHabitacion;
        Console.WriteLine("Precio por noche:");
        habitaciones[cantidad].precio = Convert.ToSingle(Console.ReadLine());
        ComprobarHuespedes(habitaciones, cantidad);
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
    }
    
    static void ComprobarHuespedes(habitacion[]habitaciones, int cantidad)
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
    
    static void ListarHabitaciones(habitacion[]habitaciones, int cantidad)
    {
        if (cantidad > 0)
        {
            for (int i = 0; i < cantidad; i++)
            {
                MostrarDatosParciales(habitaciones, i);
            }
        }
        else
        {
            Console.WriteLine("No hay habitaciones almacenadas");
        }
    }
    
    static void BuscarHabitacion(habitacion[]habitaciones, int cantidad,
        int numHabitacion)
    {
        if (cantidad > 0)
        {
            int posicion;
            posicion = BuscarRepetida(habitaciones, cantidad, numHabitacion);
            if (posicion >= 0)
            {
                MostrarDatosCompletos(habitaciones, posicion);
            }
            else
            {
                Console.WriteLine("Habitación no encontrada");
            }
        }
        else
        {
            Console.WriteLine("No hay habitaciones almacenadas");                        
        }
    }
    
    static void MostrarDatosParciales(habitacion[]habitaciones, int i)
    {
        Console.WriteLine("Numero: " + habitaciones[i].numero);
        Console.WriteLine("\tPrecio: " + habitaciones[i].precio);
        Console.WriteLine("\tDescripción: " + habitaciones[i].descripcion);
    }
    
    static void MostrarDatosCompletos(habitacion[]habitaciones, int posicion)
    {
        Console.WriteLine("Numero: " + habitaciones[posicion].numero);
        Console.WriteLine("Precio: " + habitaciones[posicion].precio);
        Console.WriteLine("Descripción: " + habitaciones[posicion].descripcion);
        Console.WriteLine("Max. huespedes: " +
            habitaciones[posicion].servicios.huespedes);
        if (habitaciones[posicion].servicios.wifi)
            Console.WriteLine("Wifi: si");
        else
            Console.WriteLine("Wifi: no");
    }
    
    static void FiltrarHabitaciones(habitacion[]habitaciones, int cantidad, 
        float filtroPrecio)
    {
        bool encontrado = false;
        if(cantidad > 0)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (filtroPrecio >= habitaciones[i].precio)
                {
                    MostrarDatosParciales(habitaciones, i);
                    encontrado = true;
                }
            }
            if(!encontrado)
            {
                Console.WriteLine("No tenemos habitaciones con ese precio");
            }
        }
        else
        {
            Console.WriteLine("No hay habitaciones almacenadas");                                                
        }
    }
    
    static void OrdenarHabitaciones(habitacion[]habitaciones, int cantidad)
    {
        if(cantidad > 0)
        {
            for (int i = 0; i < cantidad-1; i++)
            {
                for (int j = i+1; j < cantidad; j++)
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
                MostrarDatosParciales(habitaciones, i);
            }
        }
        else
        {
            Console.WriteLine("No hay habitaciones almacenadas");                                                
        }
    }
    
    static void BusquedaAvanzada(habitacion[]habitaciones, int cantidad,
        string texto)
    {
        if(cantidad > 0)
        {
            bool encontrado = false;
            for (int i = 0; i < cantidad; i++)
            {    
                int indice=habitaciones[i].descripcion.ToUpper().IndexOf(texto);
                
                if(indice>=0)
                {
                    RecortarDescripcion(habitaciones, texto, indice, i);
                    encontrado = true;
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
    
    static void RecortarDescripcion(habitacion[]habitaciones, string texto,
        int indice, int i)
    {
        int principio=indice-10;
        int fin=indice+texto.Length+10;
        string descripcionRecortada;
        
        if(principio<0)
        {
            principio=0;
        }
        
        if(fin>habitaciones[i].descripcion.Length)
        {
            fin=habitaciones[i].descripcion.Length;
        }
        
        descripcionRecortada=habitaciones[i].descripcion
            .Substring(principio,fin-principio);
        Console.WriteLine("Numero: " + habitaciones[i].numero);
        Console.WriteLine("\tPrecio: " + habitaciones[i].precio);
        Console.WriteLine("\t..." + descripcionRecortada + "...");
    }
}
