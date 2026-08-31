class Program
{
    static List<Cliente> clientes = new List<Cliente>();
    static List<Repartidor> repartidores = new List<Repartidor>();
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
            switch (opcion)
            {
                case 1:
                    RegistrarCliente();
                    break;
                case 2:
                    ConsultarClientes();
                    break;
                case 3:
                    BuscarClientes();
                    break;
                case 4:
                    ActualizarCliente();
                    break;
            }

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
            switch (opcion)
            {
                case 1:
                    RegistrarRepartidor();
                    break;
                case 2:
                    ConsultarRepartidores();
                    break;
                case 3:
                    BuscarRepartidor();
                    break;
                case 4:
                    VerificarDisponibilidad();
                    break;
                case 6:
                    ActualizarEstado();
                    break;

            }
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
    static void RegistrarCliente()
    {
        Console.Clear();
        Console.WriteLine("======================");
        Console.WriteLine("   REGISTRAR CLIENTE   ");
        Console.WriteLine("=======================");

        Console.Write("Ingrese código: ");
        string codigo = Console.ReadLine();
        foreach (Cliente clientes in clientes)
        {
            if (clientes.Codigo == codigo)
            {
                Console.WriteLine("El código ya existe.");
                Console.ReadKey();
                return;
            }
        }
        while (codigo == "")
        {
            Console.WriteLine("El campo no puede quedar vacio o el codigo ya existe");
            Console.Write("Ingrese código: ");
            codigo = Console.ReadLine();
        }

        Console.Write("Ingrese nombre: ");
        string nombre = Console.ReadLine();
        while (nombre == "")
        {
            Console.WriteLine("El campo no puede quedar vacio");
            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();
        }

        Console.Write("Ingrese numero de telefono: ");
        string numeroTelefono = Console.ReadLine();
        while (numeroTelefono == "")
        {
            Console.WriteLine("El campo no puede quedar vacio");
            Console.Write("Ingrese número de telefono: ");
            numeroTelefono = Console.ReadLine();
        }

        int edad;
        do
        {
            Console.Write("Ingrese edad: ");
            if (!int.TryParse(Console.ReadLine(), out edad))
            {
                Console.WriteLine("Debe ingresar un número: ");
                continue;
            }
            if (edad < 18 || edad > 90)
            {
                Console.WriteLine("La edad debe ser entre 18 y 90");
                continue;
            }
            break;
        } while (true);

        Console.Write("Ingrese correo: ");
        string correo = Console.ReadLine();
        while (correo == "" || !correo.Contains("@"))
        {
            Console.WriteLine("Invalido");
            Console.Write("Ingrese correo: ");
            correo = Console.ReadLine();
        }

        Console.Write("Ingrese dirección: ");
        string direccion = Console.ReadLine();
        while (direccion == "")
        {
            Console.WriteLine("Este campo no puede quedar vacio");
            Console.Write("Ingrese dirección: ");
            direccion = Console.ReadLine();
        }
        int cantidadSolicitudes;
        do
        {
            Console.Write("Ingrese cantidad de solicitudes realizadas: ");
            if (!int.TryParse(Console.ReadLine(), out cantidadSolicitudes))
            {
                Console.WriteLine("Debe ingresar un número");
                continue;
            }
            if (cantidadSolicitudes <= 0)
            {
                Console.WriteLine("La cantidad de solicitudes debe ser mayor a 0");
                continue;
            }
            break;
        } while (true);

        Cliente cliente = new Cliente(codigo, nombre, numeroTelefono, edad, correo, direccion, cantidadSolicitudes);

        clientes.Add(cliente);

        Console.WriteLine("Cliente registrado correctamente.");
        Console.ReadKey();
    }
    static void ConsultarClientes()
    {
        Console.Clear();

        foreach (Cliente cliente in clientes)
        {
            cliente.MostrarInformacion();
            Console.WriteLine();
        }

        Console.ReadKey();
    }
    static void BuscarClientes()
    {
        Console.Clear();
        Console.WriteLine("==========================");
        Console.WriteLine("      BUSCAR CLIENTE   ");
        Console.WriteLine("==========================");
        Console.Write("Ingrese código del cliente: ");
        string codigo = Console.ReadLine();
        while (codigo == "")
        {
            Console.WriteLine("Este campo no puede quedar vacio");
            Console.Write("Ingrese código del cliente: ");
            codigo = Console.ReadLine();

        }
        bool encontrado = false;
        foreach (Cliente clientes in clientes)
        {
            if (clientes.Codigo == codigo)
            {
                clientes.MostrarInformacion();
                encontrado = true;
                break;
            }
        }
        if (encontrado == false)
        {
            Console.WriteLine("No existe cliente con ese código");
        }
        Console.ReadKey();
    }

    static void ActualizarCliente()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("      ACTUALIZAR CLIENTE     ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del cliente: ");
        string codigo = Console.ReadLine();

        foreach (Cliente cliente in clientes)
        {
            if (cliente.Codigo == codigo)
            {
                Console.Write("Ingrese nuevo nombre: ");
                cliente.Nombre = Console.ReadLine();

                Console.Write("Ingrese nuevo número de teléfono: ");
                cliente.NumeroTelefono = Console.ReadLine();

                Console.Write("Ingrese nueva edad: ");
                int edad;

                while (!int.TryParse(Console.ReadLine(), out edad) || edad <= 0)
                {
                    Console.WriteLine("La edad debe ser mayor a 0.");
                    Console.Write("Ingrese nueva edad: ");
                }

                cliente.Edad = edad;

                Console.Write("Ingrese nueva dirección: ");
                cliente.Direccion = Console.ReadLine();

                Console.WriteLine("Cliente actualizado correctamente.");

                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No se encontró un cliente con ese código.");

        Console.ReadKey();
    }
    static void RegistrarRepartidor()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("     REGISTRAR REPARTIDOR    ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código: ");
        string codigo = Console.ReadLine();

        while (codigo == "")
        {
            Console.WriteLine("El código no puede estar vacío");
            Console.Write("Ingrese código: ");
            codigo = Console.ReadLine();
        }

        foreach (Repartidor repartidores in repartidores)
        {
            if (repartidores.Codigo == codigo)
            {
                Console.WriteLine("Ya existe un repartidor con ese código");
                Console.ReadKey();
                return;
            }
        }

        Console.Write("Ingrese nombre: ");
        string nombre = Console.ReadLine();

        while (nombre == "")
        {
            Console.WriteLine("El nombre no puede estar vacío");
            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();
        }

        Console.Write("Ingrese número de teléfono: ");
        string numeroTelefono = Console.ReadLine();

        while (numeroTelefono == "")
        {
            Console.WriteLine("El número de teléfono no puede estar vacío");
            Console.Write("Ingrese número de teléfono: ");
            numeroTelefono = Console.ReadLine();
        }

        int edad;

        do
        {
            Console.Write("Ingrese edad: ");

            if (!int.TryParse(Console.ReadLine(), out edad))
            {
                Console.WriteLine("Debe ingresar un número");
                continue;
            }

            if (edad < 18 || edad > 90)
            {
                Console.WriteLine("La edad debe ser entre 18 y 90");
                continue;
            }

            break;

        } while (true);

        Console.Write("Ingrese número de licencia: ");
        string numeroLicencia = Console.ReadLine();

        while (numeroLicencia == "")
        {
            Console.WriteLine("El número de licencia no puede estar vacío");
            Console.Write("Ingrese número de licencia: ");
            numeroLicencia = Console.ReadLine();
        }

        Console.Write("Ingrese tipo de licencia: ");
        string tipoLicencia = Console.ReadLine();

        while (tipoLicencia == "")
        {
            Console.WriteLine("El tipo de licencia no puede estar vacío");
            Console.Write("Ingrese tipo de licencia: ");
            tipoLicencia = Console.ReadLine();
        }

        string estadoDisponibilidad;

        do
        {
            Console.Write("Ingrese estado de disponibilidad (Disponible/Asignado/Fuera de servicio): ");
            estadoDisponibilidad = Console.ReadLine();

            if (estadoDisponibilidad != "Disponible" && estadoDisponibilidad != "Asignado" && estadoDisponibilidad != "Fuera de servicio")
            {
                Console.WriteLine("Estado no válido");
            }
            else
            {
                break;
            }

        } while (true);

        int cantidadEntregasRealizadas;

        do
        {
            Console.Write("Ingrese cantidad de entregas realizadas: ");

            if (!int.TryParse(Console.ReadLine(), out cantidadEntregasRealizadas))
            {
                Console.WriteLine("Debe ingresar un número");
                continue;
            }

            if (cantidadEntregasRealizadas < 0)
            {
                Console.WriteLine("La cantidad no puede ser negativa");
                continue;
            }

            break;

        } while (true);

        double calificacionPromedio;

        do
        {
            Console.Write("Ingrese calificación promedio: ");

            if (!double.TryParse(Console.ReadLine(), out calificacionPromedio))
            {
                Console.WriteLine("Debe ingresar un número");
                continue;
            }

            if (calificacionPromedio < 0 || calificacionPromedio > 5)
            {
                Console.WriteLine("La calificación debe estar entre 0 y 5");
                continue;
            }

            break;

        } while (true);

        Repartidor repartidor = new Repartidor(codigo, nombre, numeroTelefono, edad, numeroLicencia, tipoLicencia, estadoDisponibilidad, cantidadEntregasRealizadas, calificacionPromedio);

        repartidores.Add(repartidor);

        Console.WriteLine();
        Console.WriteLine("Repartidor registrado correctamente");

        Console.ReadKey();
    }
    static void ConsultarRepartidores()
    {
        Console.Clear();
        if (repartidores.Count == 0)
        {
            Console.WriteLine("No hay repartidores registrados");
        }
        else
        {
            foreach (Repartidor repartidor in repartidores)
            {
                repartidor.MostrarInformacion();
                Console.WriteLine();
            }
        }

        Console.ReadKey();
    }
    static void BuscarRepartidor()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("      BUSCAR REPARTIDOR      ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del repartidor: ");
        string codigo = Console.ReadLine();

        while (codigo == "")
        {
            Console.WriteLine("Este campo no puede quedar vacío");
            Console.Write("Ingrese código del repartidor: ");
            codigo = Console.ReadLine();
        }

        bool encontrado = false;

        foreach (Repartidor repartidores in repartidores)
        {
            if (repartidores.Codigo == codigo)
            {
                repartidores.MostrarInformacion();
                encontrado = true;
                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine("No existe repartidor con ese código");
        }

        Console.ReadKey();
    }
    static void VerificarDisponibilidad()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("   VERIFICAR DISPONIBILIDAD  ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del repartidor: ");
        string codigo = Console.ReadLine();

        foreach (Repartidor repartidores in repartidores)
        {
            if (repartidores.Codigo == codigo)
            {
                Console.WriteLine("Repartidor: " + repartidores.Nombre);
                Console.WriteLine("Estado: " + repartidores.EstadoDisponibilidad);

                if (repartidores.EstadoDisponibilidad == "Disponible")
                {
                    Console.WriteLine("El repartidor está disponible");
                }
                else
                {
                    Console.WriteLine("El repartidor no está disponible");
                }

                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No existe repartidor con ese código");

        Console.ReadKey();
    }
    static void ActualizarEstado()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("      ACTUALIZAR ESTADO      ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del repartidor: ");
        string codigo = Console.ReadLine();

        foreach (Repartidor repartidor in repartidores)
        {
            if (repartidor.Codigo == codigo)
            {
                string estado;

                do
                {
                    Console.Write("Ingrese nuevo estado (Disponible/Asignado/Fuera de servicio): ");
                    estado = Console.ReadLine();

                    if (estado != "Disponible" && estado != "Asignado" && estado != "Fuera de servicio")
                    {
                        Console.WriteLine("Estado no válido");
                    }
                    else
                    {
                        break;
                    }

                } while (true);

                repartidor.EstadoDisponibilidad = estado;

                Console.WriteLine("Estado actualizado correctamente");

                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No existe repartidor con ese código");

        Console.ReadKey();
    }
}
