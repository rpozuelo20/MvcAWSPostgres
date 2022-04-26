using MvcAWSPostgres.Data;
using MvcAWSPostgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAWSPostgres.Repositories
{
    public class RepositoryDepartamentos
    {
        private DepartamentosContext context;
        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.context = context;
        }
        public List<Departamento> GetDepartamentos()
        {
            return this.context.Departamentos.ToList();
        }
        public Departamento FindDepartamento(int id)
        {
            return this.context.Departamentos.SingleOrDefault(x => x.IdDepartamento == id);
        }
        public void InsertDepartamento(int id, string nombre, string localidad)
        {
            Departamento dept = new Departamento
            {
                IdDepartamento = id,
                Nombre = nombre,
                Localidad = localidad
            };
            this.context.Departamentos.Add(dept);
            this.context.SaveChanges();
        }
    }
}
