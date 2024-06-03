using CLEAN_ARQ_PROF.DOMAIN.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEAN_ARQ_PROF.DOMAIN.Usuarios
{
    public sealed class Usuarios: Entity
    {
        //public Guid IdUsuario { get; init; } // comentar porque ya existe y lo está heredando en Entity
        public Usuarios(Guid idUsuario) : base(idUsuario) { }
        public string? Usuario { get; private set; }
        public string? NroDocumento { get; private set; }
        public string? Nombres { get; private set; }
        public string? ApellidoPaterno { get; private set; }
        public string? ApellidoMaterno { get; private set; }
        public string? Genero { get; private set; }
        public Locacion Direccion { get; private set; }
        public string? Correo { get; private set; }
        public string? Telefono { get; private set; }
        public bool Activo { get; private set; }
        public bool Eliminado { get; private set; }
        public DateTime FechaCreacion { get; private set; }
        public DateTime FechaModificacion { get; private set; }
        public int IdUsuarioModificacion { get; private set; }
        public DateTime UltimoLogin { get; private set; }

    }

}
