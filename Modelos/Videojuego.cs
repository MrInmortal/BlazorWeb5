namespace Tarea5.Modelos
{
    public class Videojuego
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Desarrollador { get; set; }
        public int PlataformaId { get; set; }
        public string Genero { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string ImagenPortadaUrl { get; set; }
        public string? Descripcion { get; set; }
    }
}
