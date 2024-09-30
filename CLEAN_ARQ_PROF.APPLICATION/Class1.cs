namespace CLEAN_ARQ_PROF.APPLICATION
{
    public class Class1:DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Lógica antes de pasar la solicitud al siguiente handler
            Console.WriteLine("Processing request...");

            // Pasar la solicitud al siguiente handler o al servidor
            var response = await base.SendAsync(request, cancellationToken);

            // Lógica para manipular la respuesta antes de devolverla
            Console.WriteLine("Processing response...");

            return response;
        }
    }
}
