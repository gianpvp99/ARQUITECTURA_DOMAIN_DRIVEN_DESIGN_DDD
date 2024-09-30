namespace CQRS.Application.DTOs.Responses
{
    public class UserResponse
    {
        public int? IdUsuario { get; set; }
        public string? Usuario { get; set; }
        public string? Clave { get; set; }

        public string? NroDocumento { get; set; }
        public string? Nombres { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Genero { get; set; }
        //public string Distrito { get; set; }
        //public string Provincia { get; set; }
        //public string Departamento { get; set; }
        //public string Direccion { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public bool? Activo { get; set; }
        public bool? Eliminado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaUltimoLogin { get; set; }
        public int? IdUsuarioModificacion { get; set; }
    }
}
