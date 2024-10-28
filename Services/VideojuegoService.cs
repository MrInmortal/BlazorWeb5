// Services/VideojuegoService.cs
using Tarea5.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tarea5.Services
{
    public class VideojuegoService
    {
        private List<Videojuego> videojuegos = new List<Videojuego>();

        public Task<List<Videojuego>> GetAllAsync() => Task.FromResult(videojuegos);

        public Task AddAsync(Videojuego videojuego)
        {
            videojuego.Id = videojuegos.Count + 1;
            videojuegos.Add(videojuego);
            return Task.CompletedTask;
        }
    }
}
