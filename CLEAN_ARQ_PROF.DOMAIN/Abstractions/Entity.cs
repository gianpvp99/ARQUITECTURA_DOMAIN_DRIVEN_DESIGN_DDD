using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEAN_ARQ_PROF.DOMAIN.Abstractions
{
    public abstract class Entity
    {
        protected Entity(Guid idUsuario) 
        {
            IdUsuario = idUsuario;
        }
        public Guid IdUsuario { get; init; } // No podra actualizarse ya que Guid siempre debe ser único.
    }
}
