using System.ComponentModel.DataAnnotations;

namespace Tarea5.Modelos
{
    public class Personaje
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Nombre { get; set; }

        public string Alias { get; set; }

        [Required(ErrorMessage = "El rol en el juego es requerido.")]
        public string RolEnElJuego { get; set; }

        public string HabilidadEspecial { get; set; }

        public string ArmaFavorita { get; set; }

        [Range(1, 100, ErrorMessage = "El nivel de poder debe estar entre 1 y 100.")]
        public int NivelDePoder { get; set; }

        [Url(ErrorMessage = "La imagen del personaje debe ser una URL válida.")]
        public string ImagenDelPersonaje { get; set; }
    }
}
