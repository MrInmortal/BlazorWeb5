// Services/PlataformaService.cs
using Tarea5.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tarea5.Services
{
    public class PlataformaService
    {
        private List<Plataforma> plataformas = new List<Plataforma>();

        public Task<List<Plataforma>> GetAllAsync() => Task.FromResult(plataformas);

        public Task AddAsync(Plataforma plataforma)
        {
            plataforma.Id = plataformas.Count + 1;
            plataformas.Add(plataforma);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Plataforma plataforma)
        {
            var existingPlataforma = plataformas.Find(p => p.Id == plataforma.Id);
            if (existingPlataforma != null)
            {
                existingPlataforma.Nombre = plataforma.Nombre;
                existingPlataforma.Estado = plataforma.Estado;
            }
            return Task.CompletedTask;
        }

        public Task ChangeStateAsync(int id)
        {
            var plataforma = plataformas.Find(p => p.Id == id);
            if (plataforma != null)
            {
                plataforma.Estado = !plataforma.Estado;
            }
            return Task.CompletedTask;
        }
    }
}
