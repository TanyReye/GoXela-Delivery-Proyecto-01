class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("          GOXELA DELIVERY        ");
            Console.WriteLine("  SISTEMA DE GESTIÓN DE ENTREGAS   ");
            Console.WriteLine("=================================");
            Console.WriteLine("1.Gestión de clientes");
            Console.WriteLine("2.Gestión de repartidores");
            Console.WriteLine("3.Gestión de vehículos");
            Console.WriteLine("4.Gestión de paquetes");
            Console.WriteLine("5.Gestión de entregas");
            Console.WriteLine("6.Cálculo y consulta de tarifas");
            Console.WriteLine("7.Gestión de incidencias");
            Console.WriteLine("8.Cancelar entrega");
            Console.WriteLine("9.Reprogramar entrega");
            Console.WriteLine("10.Reportes y estadísticas");
            Console.WriteLine("11.Salir");

            do
            {
                Console.Write("Ingrese una opcion: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                if (opcion < 1 || opcion > 11)
                {
                    Console.WriteLine("Opción invalida");
                    continue;
                }
                break;
            } while (true);
            switch (opcion)
            {

                case 1:
                    MenuClientes();
                    break;
                case 2:
                    MenuRepartidores();
                    break;
                case 3:
                    MenuVehiculos();
                    break;
                case 4:
                    MenuPaquetes();
                    break;
                case 5:
                    MenuEntregas();
                    break;
                case 6:
                    Tarifas();
                    break;
                case 7:
                    MenuIncidencias();
                    break;
                case 8:
                    CancelarEntrega();
                    break;
                case 9:
                    RemoprogramarEntrega();
                    break;
                case 10:
                    Reportes();
                    break;
                case 11:
                    Console.WriteLine("Saliendo del sistema....");
                    break;
            }

        } while (opcion != 11);
    }

    static void MenuClientes()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("     GESTIÓN DE CLIENTES     ");
            Console.WriteLine("=============================");
            Console.WriteLine("1. Registrar cliente");
            Console.WriteLine("2. Consultar cliente");
            Console.WriteLine("3. Buscar cliente");
            Console.WriteLine("4. Actualizar cliente");
            Console.WriteLine("5. Ver solicitudes realizadas");
            Console.WriteLine("6. Regresar");
            do
            {
                Console.Write("Ingrese una opcion: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                if (opcion < 1 || opcion > 6)
                {
                    Console.WriteLine("Opción invalida");
                    continue;
                }
                break;
            } while (true);
        } while (opcion != 6);
    }
    static void MenuRepartidores()
    {
        Console.Clear();
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("    GESTIÓN DE REPARTIDORES   ");
            Console.WriteLine("=============================");
            Console.WriteLine("1. Registrar repartidor");
            Console.WriteLine("2. Consultar repartidor");
            Console.WriteLine("3. Buscar repartidor");
            Console.WriteLine("4. Verificar disponibilidad");
            Console.WriteLine("5. Asignar entrega");
            Console.WriteLine("6. Actualizar estado");
            Console.WriteLine("7. Ver entregas realizadas");
            Console.WriteLine("8. Regresar");
            do
            {
                Console.Write("Ingrese una opcion: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                if (opcion < 1 || opcion > 8)
                {
                    Console.WriteLine("Opción invalida");
                    continue;
                }
                break;
            } while (true);
        } while (opcion != 8);
    }

    static void MenuVehiculos()
    {
        Console.Clear();
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("    GESTIÓN DE VEHICULOS   ");
            Console.WriteLine("=============================");
            Console.WriteLine("1. Registrar vehículo");
            Console.WriteLine("2. Consultar vehículo");
            Console.WriteLine("3. Buscar vehículo");
            Console.WriteLine("4. Verificar disponibilidad");
            Console.WriteLine("5. Verificar capacidad");
            Console.WriteLine("6. Verificar compatibilidad");
            Console.WriteLine("7. Asignar vehículo");
            Console.WriteLine("8. Actualizar estado");
            Console.WriteLine("9. Regresar");
            do
            {
                Console.Write("Ingrese una opcion: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                if (opcion < 1 || opcion > 9)
                {
                    Console.WriteLine("Opción invalida");
                    continue;
                }
                break;
            } while (true);
        } while (opcion != 9);
    }

    static void MenuPaquetes()
    {
        Console.Clear();
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("    GESTIÓN DE PAQUETES   ");
            Console.WriteLine("=============================");
            Console.WriteLine("1. Registrar paquete");
            Console.WriteLine("2. Consultar paquete");
            Console.WriteLine("3. Buscar paquete");
            Console.WriteLine("4. Ver tipo de paquete");
            Console.WriteLine("5. Ver condiciones de transporte");
            Console.WriteLine("6. Verificar compatibilidad");
            Console.WriteLine("7. Actualizar estado");
            Console.WriteLine("8. Regresar");
            do
            {
                Console.Write("Ingrese una opcion: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                if (opcion < 1 || opcion > 8)
                {
                    Console.WriteLine("Opción invalida");
                    continue;
                }
                break;
            } while (true);
        } while (opcion != 8);
    }

    static void MenuEntregas()
    {
        Console.Clear();
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("    GESTIÓN DE ENTREGAS   ");
            Console.WriteLine("=============================");
            Console.WriteLine("1. Crear solicitud");
            Console.WriteLine("2. Consultar entrega");
            Console.WriteLine("3. Buscar entrega");
            Console.WriteLine("4. Asignar repartidor");
            Console.WriteLine("5. Asignar vehículo");
            Console.WriteLine("6. Calcular tarifa");
            Console.WriteLine("7. Actualizar estado");
            Console.WriteLine("8. Registrar incidencia");
            Console.WriteLine("9. Confirmar entrega");
            Console.WriteLine("10. Cancelar enntrega");
            Console.WriteLine("11. Reprogramar entrega");
            Console.WriteLine("12. Consultar entregas activas");
            Console.WriteLine("13. Consultar entregas finalizas");
            Console.WriteLine("14. Regresar");
            do
            {
                Console.Write("Ingrese una opcion: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                if (opcion < 1 || opcion > 14)
                {
                    Console.WriteLine("Opción invalida");
                    continue;
                }
                break;
            } while (true);
        } while (opcion != 14);
    }
    static void Tarifas()
    {
        Console.Clear();
        Console.WriteLine("============================");
        Console.WriteLine("CÁLCULO Y CONSULTA DE TARIFAS");
        Console.WriteLine("=============================");
        Console.ReadKey();
    }
    static void MenuIncidencias()
    {
        Console.Clear();
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine(" GESTIÓN DE INCIDENCIAS ");
            Console.WriteLine("=========================");
            Console.WriteLine("1. Registrar incidencia");
            Console.WriteLine("2. Consultar incidencia");
            Console.WriteLine("3. Buscar incidencia");
            Console.WriteLine("4. Ver incidencias de una entrega");
            Console.WriteLine("5. Actualizar estado");
            Console.WriteLine("6. Registrar acción tomada");
            Console.WriteLine("7. Resolver incidencia");
            Console.WriteLine("8. Regresar");
            do
            {
                Console.Write("Ingrese una opcion: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                if (opcion < 1 || opcion > 8)
                {
                    Console.WriteLine("Opción invalida");
                    continue;
                }
                break;
            } while (true);

        } while (opcion != 8);
    }
    static void CancelarEntrega()
    {
        Console.Clear();
        Console.WriteLine("====================");
        Console.WriteLine("  CANCELAR ENTREGA ");
        Console.WriteLine("====================");
        Console.ReadKey();
    }
    static void RemoprogramarEntrega()
    {
        Console.Clear();
        Console.WriteLine("====================");
        Console.WriteLine("REPROGRAMAR ENTREGA ");
        Console.WriteLine("====================");
        Console.ReadKey();
    }
    static void Reportes()
    {
        Console.Clear();
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("   REPORTES Y ESTADÍSTICAS    ");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Entregas activas");
            Console.WriteLine("2. Entregas finalizadas");
            Console.WriteLine("3. Entregas canceladas");
            Console.WriteLine("4. Entregas con incidencias");
            Console.WriteLine("5. Repartidores disponibles");
            Console.WriteLine("6. Repartidor con más entregas");
            Console.WriteLine("7. Vehículo más utilizado");
            Console.WriteLine("8. Paquetes por tipo");
            Console.WriteLine("9. Total de ingresos");
            Console.WriteLine("10. Entrega con mayor costo");
            Console.WriteLine("11. Entregas por repartidor");
            Console.WriteLine("12. Entregas por vehículo");
            Console.WriteLine("13. Paquetes pendientes");
            Console.WriteLine("14. Entregas por destino");
            Console.WriteLine("15. Ingresos por período");
            Console.WriteLine("16. Promedio del costo");
            Console.WriteLine("17. Entregas con retraso");
            Console.WriteLine("18. Tipos de incidencias");
            Console.WriteLine("19. Vehículos disponibles/ocupados");
            Console.WriteLine("20. Porcentaje de entregas exitosas");
            Console.WriteLine("21. Regresar");
            do
            {
                Console.Write("Ingrese una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                if (opcion < 1 || opcion > 21)
                {
                    Console.WriteLine("Opción invalida");
                    continue;
                }
                break;
            } while (true);

        } while (opcion != 21);
    }
}