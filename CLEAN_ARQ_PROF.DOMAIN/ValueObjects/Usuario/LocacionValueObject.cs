using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEAN_ARQ_PROF.DOMAIN.ValueObjects.Usuario
{
    public record LocacionValueObject
    {
        public string? Departamento { get; init; }
        public string? Provincia { get; init; }
        public string? Distrito { get; init; }
        public string? Direccion { get; init; }
    }
}
