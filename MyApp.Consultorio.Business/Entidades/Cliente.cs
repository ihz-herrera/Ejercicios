﻿using MyApp.Consultorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Consultorio.Entidades
{
    public class Cliente : Persona, IEntity
    {
        public readonly string Path="";
        public readonly IRepository<Cliente> repository;
       
        public DateTime FechaNacimiento { get; set; }
        public string? Direccion { get; set; }



        public Cliente(IRepository<Cliente> repo)
        {
            repository = repo;
        }

        public Cliente()
        {

        }


        public override string ToString()
        {
            return $"{Id}, {Nombre}, {Apellido},{FechaNacimiento},{Direccion}";
        }



        public void AgregarCliente(Cliente cliente)
        {

            //Todo: Validar datos de entrada
            if (String.IsNullOrEmpty(cliente.Nombre) || String.IsNullOrEmpty(cliente.Apellido) )
            {
                throw new ArgumentException("Las propiedades deben tener un valor. " +
                    "La propiedadad Nombre, Apellidos o Direccion estan vacias");
            }

            //Buscar si existe el cliente en la base de datos
            var result = repository.Consultar().Where(x=> 
                            x.Nombre.ToUpper().Equals(cliente.Nombre.ToUpper()) &&
                            x.Apellido.ToUpper().Equals(cliente.Apellido.ToUpper())
                         ).ToList();

            if(result.Count != 0)
            {
                throw new ArgumentException("El cliente ya existe");
            }


            repository.Agregar(cliente);


        }
       

        public List<Cliente> CargarDatos()
        {
            return repository.Consultar();
        }

        public void Guardar(List<Cliente> clientes)
        {
            repository.Guardar(clientes);
        }

    }
}