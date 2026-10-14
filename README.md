# MediCitas
## Objetivo del Sistema
Desarrollar una plataforma digital centralizada (MediCitas) para la gestión eficiente de citas médicas, optimizando la asignación de horarios entre pacientes y profesionales de la salud, reduciendo tiempos de espera y agilizando el flujo de atención en centros clínicos.

## Problema que Resuelve
Soluciona la congestión en la recepción de clínicas y la pérdida o cruce de turnos médicos mediante un sistema automatizado de reservas en línea. Permite a los pacientes agendar, reprogramar o cancelar citas de forma digital y otorga a los administradores control total sobre la disponibilidad de los médicos.

## Funcionalidades Principales
1. Módulo de Autenticación y Roles: Registro e inicio de sesión diferenciado para Pacientes, Médicos y Administradores.
2. Gestión de Citas: Búsqueda de especialistas, selección de horarios disponibles y reserva en tiempo real.
3. Historial Médico: Visualización de citas pasadas y próximas para los pacientes.
4. Panel de Administración: Gestión de usuarios, especialidades médicas y control de la agenda de los doctores.
5. Notificaciones y Alertas: Avisos de confirmación de citas.

## Arquitectura Seleccionada y Organización Frontend / Backend
El sistema está estructurado bajo una arquitectura de capas / cliente-servidor modular para garantizar escalabilidad, mantenimiento y separación de responsabilidades:

- Frontend (Interfaz de Usuario / Capa de Presentación):
  - Responsabilidad: Manejar toda la interacción visual con el usuario (pantallas de login, formularios de registro, calendarios de selección de citas y paneles de control).
  - Comunicación: Se comunica con el backend mediante peticiones HTTP (API REST) para enviar datos de formularios y recibir respuestas en formato JSON.

- Backend (Lógica de Negocio / Servidor):
  - Responsabilidad: Procesar las reglas de negocio, validar la autenticación de usuarios, gestionar la lógica de disponibilidad de horarios médicos y realizar las operaciones de consultas sobre la base de datos.
  - Comunicación: Recibe las peticiones del frontend, procesa la información y devuelve los resultados correspondientes o ejecuta consultas hacia la base de datos relacional.

## Herramientas y Tecnologías Utilizadas
- Modelado y Diseño: Visual Paradigm Online (Diagramas UML: Casos de Uso, Clases, Secuencia).
- Gestión de Proyecto y Tareas: GitHub Projects (Tablero Kanban).
- Control de Versiones: Git y GitHub.
- Entorno de Desarrollo: Visual Studio / C# / PostgreSQL / SQL Server.

## Estado Actual del Proyecto
El proyecto se encuentra en su versión inicial controlada (v1.0.0). Se han completado satisfactoriamente los diagramas de arquitectura conceptual y de diseño en UML, la estructuración inicial del repositorio en GitHub, el tablero de seguimiento y las configuraciones base de la documentación técnica.
