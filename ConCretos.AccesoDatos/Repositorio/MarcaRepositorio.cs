﻿using ConCretos.AccesoDatos.Data;
using ConCretos.AccesoDatos.Repositorio.IRepositorio;
using ConCretos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCretos.AccesoDatos.Repositorio
{
    public class MarcaRepositorio : Repositorio<Marca>, IMarcaRepositorio
    {
        private readonly ApplicationDbContext _db;
        public MarcaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Actualizar(Marca marca)
        {
            var marcaBD = _db.Marcas.FirstOrDefault(b => b.Id == marca.Id);
            if (marcaBD != null)
            {
                marcaBD.Nombre = marca.Nombre;
                marcaBD.Descripcion = marca.Descripcion;
                marcaBD.Estado = marca.Estado;
                _db.SaveChanges();
            }
        }
    }

}
