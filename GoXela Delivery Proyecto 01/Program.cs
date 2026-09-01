class Program
{
    static List<Cliente> clientes = new List<Cliente>();
    static List<Repartidor> repartidores = new List<Repartidor>();
    static List<Vehiculo> vehiculos = new List<Vehiculo>();
    static List<Paquete> paquetes = new List<Paquete>();
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
            switch (opcion)
            {
                case 1:
                    RegistrarVehiculo();
                    break;

                case 2:
                    ConsultarVehiculos();
                    break;

                case 3:
                    BuscarVehiculo();
                    break;

                case 4:
                    VerificarDisponibilidadVehiculo();
                    break;

                case 5:
                    VerificarCapacidad();
                    break;

                case 6:
                    VerificarCompatibilidad();
                    break;

                case 7:
                    AsignarVehiculo();
                    break;

                case 8:
                    ActualizarEstadoVehiculo();
                    break;
            }
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
            switch (opcion)
            {
                case 1:
                    RegistrarPaquete();
                    break;
                case 2:
                    ConsultarPaquetes();
                    break;

                case 3:
                    BuscarPaquete();
                    break;

                case 4:
                    VerTipoPaquete();
                    break;

                case 5:
                    VerCondicionesPaquete();
                    break;

                case 6:
                    VerificarCompatibilidadPaquete();
                    break;

                case 7:
                    ActualizarEstadoPaquete();
                    break;
            }
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
            Console.WriteLine("El campo no puede quedar vacio");
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
        while (correo == "" || !correo.Contains("@") || !correo.Contains(".com"))
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
    static void RegistrarVehiculo()
    {
        int tipo;

        do
        {
            Console.Clear();

            Console.WriteLine("=============================");
            Console.WriteLine("     REGISTRAR VEHÍCULO      ");
            Console.WriteLine("=============================");
            Console.WriteLine("1. Bicicleta");
            Console.WriteLine("2. Motocicleta");
            Console.WriteLine("3. Automóvil");
            Console.WriteLine("4. Regresar");

            do
            {
                Console.Write("Seleccione el tipo de vehículo: ");

                if (!int.TryParse(Console.ReadLine(), out tipo))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }

                if (tipo < 1 || tipo > 4)
                {
                    Console.WriteLine("Opción inválida");
                    continue;
                }

                break;

            } while (true);

            switch (tipo)
            {
                case 1:
                    RegistrarBicicleta();
                    break;

                case 2:
                    RegistrarMotocicleta();
                    break;

                case 3:
                    RegistrarAutomovil();
                    break;
            }

        } while (tipo != 4);
    }

    static void RegistrarBicicleta()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("      REGISTRAR BICICLETA    ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código: ");
        string codigo = Console.ReadLine();

        while (codigo == "")
        {
            Console.WriteLine("El código no puede estar vacío");
            Console.Write("Ingrese código: ");
            codigo = Console.ReadLine();
        }

        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (vehiculo.Codigo == codigo)
            {
                Console.WriteLine("El código ya existe");
                Console.ReadKey();
                return;
            }
        }

        Console.Write("Ingrese marca: ");
        string marca = Console.ReadLine();

        while (marca == "")
        {
            Console.WriteLine("La marca no puede estar vacía");
            Console.Write("Ingrese marca: ");
            marca = Console.ReadLine();
        }

        Console.Write("Ingrese modelo: ");
        string modelo = Console.ReadLine();

        while (modelo == "")
        {
            Console.WriteLine("El modelo no puede estar vacío");
            Console.Write("Ingrese modelo: ");
            modelo = Console.ReadLine();
        }

        double capacidad;

        do
        {
            Console.Write("Ingrese capacidad máxima de carga(kg): ");

            if (!double.TryParse(Console.ReadLine(), out capacidad))
            {
                Console.WriteLine("Debe ingresar un número");
                continue;
            }

            if (capacidad <= 0)
            {
                Console.WriteLine("La capacidad debe ser mayor a 0");
                continue;
            }

            break;

        } while (true);

        Console.Write("Ingrese estado: ");
        string estado = Console.ReadLine();

        while (estado == "")
        {
            Console.WriteLine("El estado no puede estar vacío");
            Console.Write("Ingrese estado: ");
            estado = Console.ReadLine();
        }

        Console.Write("Ingrese material de la bicicleta: ");
        string material = Console.ReadLine();

        while (material == "")
        {
            Console.WriteLine("El material no puede estar vacío");
            Console.Write("Ingrese material: ");
            material = Console.ReadLine();
        }

        Bicicleta bicicleta = new Bicicleta(codigo, "Bicicleta", marca, modelo, capacidad, estado, material);

        vehiculos.Add(bicicleta);

        Console.WriteLine("Bicicleta registrada correctamente");

        Console.ReadKey();
    }
    static void RegistrarMotocicleta()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("    REGISTRAR MOTOCICLETA    ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código: ");
        string codigo = Console.ReadLine();

        while (codigo == "")
        {
            Console.WriteLine("El código no puede estar vacío");
            Console.Write("Ingrese código: ");
            codigo = Console.ReadLine();
        }

        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (vehiculo.Codigo == codigo)
            {
                Console.WriteLine("El código ya existe");
                Console.ReadKey();
                return;
            }
        }

        Console.Write("Ingrese marca: ");
        string marca = Console.ReadLine();

        while (marca == "")
        {
            Console.WriteLine("La marca no puede estar vacía");
            Console.Write("Ingrese marca: ");
            marca = Console.ReadLine();
        }

        Console.Write("Ingrese modelo: ");
        string modelo = Console.ReadLine();

        while (modelo == "")
        {
            Console.WriteLine("El modelo no puede estar vacío");
            Console.Write("Ingrese modelo: ");
            modelo = Console.ReadLine();
        }

        double capacidad;

        do
        {
            Console.Write("Ingrese capacidad máxima de carga: ");

            if (!double.TryParse(Console.ReadLine(), out capacidad))
            {
                Console.WriteLine("Debe ingresar un número");
                continue;
            }

            if (capacidad <= 0)
            {
                Console.WriteLine("La capacidad debe ser mayor a 0");
                continue;
            }

            break;

        } while (true);
        string estado = "disponible";
        Console.Write("Ingrese placa: ");
        string placa = Console.ReadLine();

        while (placa == "")
        {
            Console.WriteLine("La placa no puede estar vacía");
            Console.Write("Ingrese placa: ");
            placa = Console.ReadLine();
        }

        Motocicleta motocicleta = new Motocicleta(codigo, "Motocicleta", marca, modelo, capacidad, estado, placa);

        vehiculos.Add(motocicleta);

        Console.WriteLine("Motocicleta registrada correctamente");

        Console.ReadKey();
    }
    static void RegistrarAutomovil()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("      REGISTRAR AUTOMÓVIL    ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código: ");
        string codigo = Console.ReadLine();

        while (codigo == "")
        {
            Console.WriteLine("El código no puede estar vacío");
            Console.Write("Ingrese código: ");
            codigo = Console.ReadLine();
        }

        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (vehiculo.Codigo == codigo)
            {
                Console.WriteLine("El código ya existe");
                Console.ReadKey();
                return;
            }
        }

        Console.Write("Ingrese marca: ");
        string marca = Console.ReadLine();

        while (marca == "")
        {
            Console.WriteLine("La marca no puede estar vacía");
            Console.Write("Ingrese marca: ");
            marca = Console.ReadLine();
        }

        Console.Write("Ingrese modelo: ");
        string modelo = Console.ReadLine();

        while (modelo == "")
        {
            Console.WriteLine("El modelo no puede estar vacío");
            Console.Write("Ingrese modelo: ");
            modelo = Console.ReadLine();
        }

        double capacidad;

        do
        {
            Console.Write("Ingrese capacidad máxima de carga: ");

            if (!double.TryParse(Console.ReadLine(), out capacidad))
            {
                Console.WriteLine("Debe ingresar un número");
                continue;
            }

            if (capacidad <= 0)
            {
                Console.WriteLine("La capacidad debe ser mayor a 0");
                continue;
            }

            break;

        } while (true);

        Console.Write("Ingrese estado: ");
        string estado = Console.ReadLine();

        while (estado == "")
        {
            Console.WriteLine("El estado no puede estar vacío");
            Console.Write("Ingrese estado: ");
            estado = Console.ReadLine();
        }

        Console.Write("Ingrese placa: ");
        string placa = Console.ReadLine();

        while (placa == "")
        {
            Console.WriteLine("La placa no puede estar vacía");
            Console.Write("Ingrese placa: ");
            placa = Console.ReadLine();
        }

        Console.Write("Ingrese transmisión (Manual/Automático): ");
        string transmision = Console.ReadLine();

        while (transmision != "Manual" && transmision != "Automático")
        {
            Console.WriteLine("Debe ingresar Manual o Automático");
            Console.Write("Ingrese transmisión: ");
            transmision = Console.ReadLine();
        }

        Automovil automovil = new Automovil(codigo, "Automóvil", marca, modelo, capacidad, estado, placa, transmision);

        vehiculos.Add(automovil);

        Console.WriteLine("Automóvil registrado correctamente");

        Console.ReadKey();
    }
    static void ConsultarVehiculos()
    {
        Console.Clear();

        if (vehiculos.Count == 0)
        {
            Console.WriteLine("No hay vehículos registrados");
        }
        else
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.MostrarInformacion();
                Console.WriteLine();
            }
        }

        Console.ReadKey();
    }
    static void BuscarVehiculo()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("       BUSCAR VEHÍCULO       ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código: ");
        string codigo = Console.ReadLine();

        while (codigo == "")
        {
            Console.WriteLine("El código no puede estar vacío");
            Console.Write("Ingrese código: ");
            codigo = Console.ReadLine();
        }

        bool encontrado = false;

        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (vehiculo.Codigo == codigo)
            {
                vehiculo.MostrarInformacion();
                encontrado = true;
                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine("No existe un vehículo con ese código");
        }

        Console.ReadKey();
    }
    static void VerificarDisponibilidadVehiculo()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("   VERIFICAR DISPONIBILIDAD  ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del vehículo: ");
        string codigo = Console.ReadLine();

        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (vehiculo.Codigo == codigo)
            {
                Console.WriteLine("Vehículo: " + vehiculo.Marca + " " + vehiculo.Modelo);
                Console.WriteLine("Estado: " + vehiculo.Estado);

                if (vehiculo.Estado == "Disponible")
                {
                    Console.WriteLine("El vehículo está disponible.");
                }
                else
                {
                    Console.WriteLine("El vehículo no está disponible.");
                }

                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No existe un vehículo con ese código.");
        Console.ReadKey();
    }
    static void VerificarCapacidad()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("      VERIFICAR CAPACIDAD    ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del vehículo: ");
        string codigo = Console.ReadLine();

        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (vehiculo.Codigo == codigo)
            {
                double peso;

                do
                {
                    Console.Write("Ingrese el peso del paquete (kg): ");

                    if (!double.TryParse(Console.ReadLine(), out peso))
                    {
                        Console.WriteLine("Debe ingresar un número.");
                        continue;
                    }

                    if (peso <= 0)
                    {
                        Console.WriteLine("El peso debe ser mayor a 0.");
                        continue;
                    }

                    break;

                } while (true);

                if (peso <= vehiculo.Capacidad)
                {
                    Console.WriteLine("El vehículo puede transportar el paquete.");
                }
                else
                {
                    Console.WriteLine("El vehículo NO puede transportar el paquete.");
                }

                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No existe un vehículo con ese código.");
        Console.ReadKey();
    }
    static void VerificarCompatibilidad()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("    VERIFICAR COMPATIBILIDAD ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del vehículo: ");
        string codigo = Console.ReadLine();

        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (vehiculo.Codigo == codigo)
            {
                Console.Write("Ingrese tipo de paquete: ");
                string tipoPaquete = Console.ReadLine();

                if (vehiculo.Tipo == "Bicicleta" && tipoPaquete == "Producto refrigerado")
                {
                    Console.WriteLine("El vehículo no es compatible con este paquete.");
                }
                else
                {
                    Console.WriteLine("El vehículo es compatible con el paquete.");
                }

                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No existe un vehículo con ese código.");
        Console.ReadKey();
    }
    static void AsignarVehiculo()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("       ASIGNAR VEHÍCULO      ");
        Console.WriteLine("=============================");

        Console.ReadKey();
    }
    static void ActualizarEstadoVehiculo()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("      ACTUALIZAR ESTADO      ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del vehículo: ");
        string codigo = Console.ReadLine();

        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (vehiculo.Codigo == codigo)
            {
                int opcionEstado;

                do
                {
                    Console.Clear();

                    Console.WriteLine("=============================");
                    Console.WriteLine("      ACTUALIZAR ESTADO      ");
                    Console.WriteLine("=============================");
                    Console.WriteLine("1. Disponible");
                    Console.WriteLine("2. No disponible");

                    Console.Write("Seleccione el nuevo estado: ");

                    if (!int.TryParse(Console.ReadLine(), out opcionEstado))
                    {
                        Console.WriteLine("Debe ingresar un número.");
                        Console.ReadKey();
                        continue;
                    }

                    if (opcionEstado < 1 || opcionEstado > 2)
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        continue;
                    }

                    break;

                } while (true);

                switch (opcionEstado)
                {
                    case 1:
                        vehiculo.Estado = "Disponible";
                        break;

                    case 2:
                        vehiculo.Estado = "No disponible";
                        break;
                }

                Console.WriteLine("Estado actualizado correctamente.");
                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No existe un vehículo con ese código.");
        Console.ReadKey();
    }
    static void RegistrarPaquete()
    {
        int tipo;

        do
        {
            Console.Clear();

            Console.WriteLine("=============================");
            Console.WriteLine("      REGISTRAR PAQUETE      ");
            Console.WriteLine("=============================");
            Console.WriteLine("1. Documento");
            Console.WriteLine("2. Paquete estándar");
            Console.WriteLine("3. Paquete frágil");
            Console.WriteLine("4. Producto refrigerado");
            Console.WriteLine("5. Regresar");

            do
            {
                Console.Write("Seleccione el tipo de paquete: ");

                if (!int.TryParse(Console.ReadLine(), out tipo))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }

                if (tipo < 1 || tipo > 5)
                {
                    Console.WriteLine("Opción inválida");
                    continue;
                }

                break;

            } while (true);

            switch (tipo)
            {
                case 1:
                    RegistrarDatosPaquete(1);
                    break;

                case 2:
                    RegistrarDatosPaquete(2);
                    break;

                case 3:
                    RegistrarDatosPaquete(3);
                    break;

                case 4:
                    RegistrarDatosPaquete(4);
                    break;
            }

        } while (tipo != 5);
    }
    static void RegistrarDatosPaquete(int tipo)
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("      DATOS DEL PAQUETE      ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código: ");
        string codigo = Console.ReadLine();

        while (codigo == "")
        {
            Console.WriteLine("El código no puede estar vacío");
            Console.Write("Ingrese código: ");
            codigo = Console.ReadLine();
        }

        foreach (Paquete paquetes in paquetes)
        {
            if (paquetes.Codigo == codigo)
            {
                Console.WriteLine("Ya existe un paquete con ese código");
                Console.ReadKey();
                return;
            }
        }

        Console.Write("Ingrese descripción: ");
        string descripcion = Console.ReadLine();

        while (descripcion == "")
        {
            Console.WriteLine("La descripción no puede estar vacía");
            Console.Write("Ingrese descripción: ");
            descripcion = Console.ReadLine();
        }

        double peso;

        do
        {
            Console.Write("Ingrese peso(kg): ");

            if (!double.TryParse(Console.ReadLine(), out peso))
            {
                Console.WriteLine("Debe ingresar un número");
                continue;
            }

            if (peso <= 0)
            {
                Console.WriteLine("El peso debe ser mayor a 0");
                continue;
            }

            break;

        } while (true);

        Console.Write("Ingrese valor declarado: ");
        string valorDeclarado = Console.ReadLine();

        while (valorDeclarado == "")
        {
            Console.WriteLine("El valor declarado no puede estar vacío");
            Console.Write("Ingrese valor declarado: ");
            valorDeclarado = Console.ReadLine();
        }

        Console.Write("Ingrese dirección de origen: ");
        string direccionOrigen = Console.ReadLine();

        while (direccionOrigen == "")
        {
            Console.WriteLine("La dirección de origen no puede estar vacía");
            Console.Write("Ingrese dirección de origen: ");
            direccionOrigen = Console.ReadLine();
        }

        Console.Write("Ingrese dirección de destino: ");
        string direccionDestino = Console.ReadLine();

        while (direccionDestino == "")
        {
            Console.WriteLine("La dirección de destino no puede estar vacía");
            Console.Write("Ingrese dirección de destino: ");
            direccionDestino = Console.ReadLine();
        }

        string estado = "Registrado";

        Paquete paquete;

        switch (tipo)
        {
            case 1:

                paquete = new Documento(codigo, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino, estado);

                break;

            case 2:

                paquete = new PaqueteEstandar(codigo, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino, estado);

                break;

            case 3:

                paquete = new PaqueteFragil(codigo, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino, estado);

                break;

            default:

                paquete = new ProductoRefrigerado(codigo, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino, estado);

                break;
        }

        paquetes.Add(paquete);

        Console.WriteLine();
        Console.WriteLine("Paquete registrado correctamente.");

        Console.ReadKey();
    }
    static void ConsultarPaquetes()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("       LISTA DE PAQUETES     ");
        Console.WriteLine("=============================");

        if (paquetes.Count == 0)
        {
            Console.WriteLine("No hay paquetes registrados.");
        }
        else
        {
            foreach (Paquete paquete in paquetes)
            {
                paquete.MostrarInformacion();
                Console.WriteLine();
            }
        }

        Console.ReadKey();
    }
    static void BuscarPaquete()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("        BUSCAR PAQUETE       ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código: ");
        string codigo = Console.ReadLine();

        bool encontrado = false;

        foreach (Paquete paquete in paquetes)
        {
            if (paquete.Codigo == codigo)
            {
                paquete.MostrarInformacion();
                encontrado = true;
                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine("No existe un paquete con ese código.");
        }

        Console.ReadKey();
    }
    static void VerTipoPaquete()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("       TIPO DE PAQUETE       ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del paquete: ");
        string codigo = Console.ReadLine();

        foreach (Paquete paquete in paquetes)
        {
            if (paquete.Codigo == codigo)
            {
                Console.WriteLine("Tipo de paquete: " + paquete.TipoPaquete);
                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No existe un paquete con ese código.");

        Console.ReadKey();
    }
    static void VerCondicionesPaquete()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("   CONDICIONES DE TRANSPORTE ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del paquete: ");
        string codigo = Console.ReadLine();

        foreach (Paquete paquete in paquetes)
        {
            if (paquete.Codigo == codigo)
            {
                paquete.PuedeSerTransportado();

                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No existe un paquete con ese código.");

        Console.ReadKey();
    }
    static void VerificarCompatibilidadPaquete()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("    VERIFICAR COMPATIBILIDAD ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del paquete: ");
        string codigoPaquete = Console.ReadLine();

        foreach (Paquete paquete in paquetes)
        {
            if (paquete.Codigo == codigoPaquete)
            {
                Console.WriteLine("Paquete encontrado.");
                Console.WriteLine("Tipo: " + paquete.TipoPaquete);
                Console.WriteLine("Peso: " + paquete.Peso + " kg");

                Console.WriteLine();
                Console.WriteLine("La compatibilidad se verificará");
                Console.WriteLine("al asignar un vehículo a la entrega.");

                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No existe un paquete con ese código.");

        Console.ReadKey();
    }
    static void ActualizarEstadoPaquete()
    {
        Console.Clear();

        Console.WriteLine("=============================");
        Console.WriteLine("      ACTUALIZAR ESTADO      ");
        Console.WriteLine("=============================");

        Console.Write("Ingrese código del paquete: ");
        string codigo = Console.ReadLine();

        foreach (Paquete paquete in paquetes)
        {
            if (paquete.Codigo == codigo)
            {
                int opcionEstado;

                do
                {
                    Console.Clear();

                    Console.WriteLine("=============================");
                    Console.WriteLine("         NUEVO ESTADO        ");
                    Console.WriteLine("=============================");
                    Console.WriteLine("1. Registrado");
                    Console.WriteLine("2. En tránsito");
                    Console.WriteLine("3. Entregado");
                    Console.WriteLine("4. Cancelado");

                    Console.Write("Seleccione el nuevo estado: ");

                    if (!int.TryParse(Console.ReadLine(), out opcionEstado))
                    {
                        Console.WriteLine("Debe ingresar un número.");
                        Console.ReadKey();
                        continue;
                    }

                    if (opcionEstado < 1 || opcionEstado > 4)
                    {
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        continue;
                    }

                    break;

                } while (true);

                switch (opcionEstado)
                {
                    case 1:
                        paquete.Estado = "Registrado";
                        break;

                    case 2:
                        paquete.Estado = "En tránsito";
                        break;

                    case 3:
                        paquete.Estado = "Entregado";
                        break;

                    case 4:
                        paquete.Estado = "Cancelado";
                        break;
                }

                Console.WriteLine("Estado actualizado correctamente.");

                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("No existe un paquete con ese código.");

        Console.ReadKey();
    }
}
