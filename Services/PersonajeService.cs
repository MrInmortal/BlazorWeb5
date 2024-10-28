// Services/PersonajeService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarea5.Modelos;

namespace Tarea5.Services
{
    public class PersonajeService
    {
        private List<Personaje> personajes = new List<Personaje>();

        public Task AddAsync(Personaje personaje)
        {
            personaje.Id = personajes.Count + 1; // Asignar un Id único
            personajes.Add(personaje);
            return Task.CompletedTask;
        }

        public Task<List<Personaje>> GetAllAsync()
        {
            return Task.FromResult(personajes);
        }
    }
}
