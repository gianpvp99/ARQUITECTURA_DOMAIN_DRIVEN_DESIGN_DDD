using CLEAN_ARQ_PROF.DOMAIN.SeedWork;
using CLEAN_ARQ_PROF.DOMAIN.ValueObjects.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEAN_ARQ_PROF.DOMAIN.Entities
{
    public sealed class Usuarios : EntidadBase // se usa sealed para no ser heredada por otra clase.
    {
        public string? Usuario { get; private set; }
        public string? NroDocumento { get; private set; }
        public string? Nombres { get; private set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; private set; }
        public GeneroValueObject Genero { get; private set; }
        public LocacionValueObject Direccion { get; private set; }
        public string? Correo { get; private set; }
        public string? Telefono { get; private set; }
        public bool Activo { get; private set; }
        public bool Eliminado { get; private set; }
        public DateTime? FechaCreacion { get; private set; }
        public DateTime? FechaModificacion { get; private set; }
        public int IdUsuarioModificacion { get; private set; }
        public DateTime? UltimoLogin { get; private set; }

        //public Guid IdUsuario { get; init; } // comentar porque ya existe y lo está heredando en Entity
        //Declarar constructor privado por seguridad, para modificar o actualizar estas propiedades utilizar métodos
        private Usuarios(
            Guid idUsuario,
            string usuario,
            string nroDocumento,
            string nombres,
            string apellidoPaterno,
            string apellidoMaterno,
            GeneroValueObject genero,
            LocacionValueObject direccion,
            string correo,
            string telefono,
            bool activo,
            bool eliminado,
            DateTime fechaCreacion,
            DateTime fechaModificacion,
            int idUsuarioModificacion,
            DateTime ultimoLogin) : base(idUsuario)
        {

            this.Usuario = usuario;
            this.NroDocumento = nroDocumento;
            this.Nombres = nombres;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.Genero = genero;
            this.Direccion = direccion;
            this.Correo = correo;
            this.Telefono = telefono;
            this.Activo = activo;
            this.Eliminado = eliminado;
            this.FechaCreacion = fechaCreacion;
            this.FechaModificacion = fechaModificacion;
            this.IdUsuarioModificacion = idUsuarioModificacion;
            this.UltimoLogin = ultimoLogin;
        }

        // Metodos
        public static Usuarios create(
            string usuario,
            string nroDocumento,
            string nombres,
            string apellidoPaterno,
            string apellidoMaterno,
            GeneroValueObject genero,
            LocacionValueObject direccion,
            string correo,
            string telefono,
            bool activo,
            bool eliminado,
            DateTime fechaCreacion,
            DateTime fechaModificacion,
            int idUsuarioModificacion,
            DateTime ultimoLogin)
        {
            var objUsuario = new Usuarios(
                Guid.NewGuid(),
                usuario,
                nroDocumento,
                nombres,
                apellidoPaterno,
                apellidoMaterno,
                genero,
                direccion,
                correo,
                telefono,
                activo,
                eliminado,
                fechaCreacion,
                fechaModificacion,
                idUsuarioModificacion,
                ultimoLogin);

            return objUsuario;
        }

    }

}