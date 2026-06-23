# Abnb - Repositorio del Proyecto (Replica)

Este repositorio contiene la implementacion de la plataforma tipo Airbnb realizada como base academica. 
Se ha seguido una arquitectura basada en Domain-Driven Design (DDD) y orquestada con .NET Aspire.

## 1. Estructura del proyecto
El proyecto esta dividido en las siguientes capas siguiendo Clean Architecture:

- src/Dominio: Nucleo del negocio, entidades, objetos de valor y reglas invariantes.
- src/Aplicacion: Casos de uso, queries y logica de orquestacion.
- src/Infraestructura: Persistencia con EF Core, repositorios concretos y configuraciones de BD.
- src/Api: Endpoints de la API web.
- src/AppHost: Proyecto de orquestacion con .NET Aspire para levantar los contenedores (PostgreSQL).

## 2. Requisitos previos
- .NET 10 SDK o superior.
- Docker Desktop instalado y en ejecucion (requerido para los contenedores).
- .NET Aspire Workload instalado:
    dotnet workload install aspire

## 3. Como ejecutar el proyecto
Para levantar toda la plataforma (API + Base de datos PostgreSQL), ejecuta el siguiente comando desde la raiz del repositorio:

    dotnet run --project src/AppHost/AppHost.csproj

Una vez iniciado, la terminal te proporcionara una URL para acceder al Dashboard de Aspire. 
Alli podras ver el estado de los servicios y acceder a la API.

## 4. Comandos de mantenimiento
- Restaurar paquetes: dotnet restore
- Compilar: dotnet build Abnb-main.slnx
- Limpiar binarios: dotnet clean

---
Proyecto desarrollado como parte de la materia de Aplicaciones para Servidor Web.