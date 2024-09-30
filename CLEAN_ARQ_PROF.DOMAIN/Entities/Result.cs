using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEAN_ARQ_PROF.DOMAIN.Entities
{
    public sealed class Result<T>
    {
        public List<T> Data { get; set; }
        public string? Message { get; set; }
        public bool Status { get; set; }
        public bool Error { get; set; }

        private Result(List<T> data, string message, bool status, bool error)
        {
            this.Data = data;
            this.Message = message;
            this.Status = status;
            this.Error = error;
        }

        public static Result<T> ListResult(List<T> data, string message, bool status, bool error)
        {
            var result = new Result<T>(data, message, status, error);
            return result;
        }
    }
}
