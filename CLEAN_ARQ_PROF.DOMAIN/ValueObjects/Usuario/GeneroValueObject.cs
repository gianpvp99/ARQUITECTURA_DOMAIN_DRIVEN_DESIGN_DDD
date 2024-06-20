using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEAN_ARQ_PROF.DOMAIN.ValueObjects.Usuario
{
    public record GeneroValueObject
    {
        public string? Genero { get; init; }

        public static readonly GeneroValueObject Masculino = new("M");
        public static readonly GeneroValueObject Femenino = new("F");
        private GeneroValueObject(string genero)
        {
            Genero = genero;
        }

        public static readonly IReadOnlyCollection<GeneroValueObject> All = new[]
        {
            Masculino,
            Femenino
        };
        
        public static GeneroValueObject FromGenero(string genero)
        {
            //Logica para retornar si el genero es nullo usando ?? 
            return All.FirstOrDefault(g => g.Genero == genero)?? throw new ApplicationException("El genero ingresado es inválido");
        }
    }
}
