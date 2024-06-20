using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEAN_ARQ_PROF.DOMAIN.SeedWork
{
    public abstract class EntidadBase
    {
        protected EntidadBase(Guid idUsuario)
        {
            IdUsuario = idUsuario;
        }
        public Guid IdUsuario { get; init; } // No podra actualizarse ya que Guid siempre debe ser único.
}
}
