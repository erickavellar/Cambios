namespace Cambios.Servicos
{
    using Modelos;
    using System.Net;

    public class NetworkService
    {
        public Response CheckConnection()
        {
            var client = new WebClient();

            try
            {
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return new Response
                    {
                        isSuccess = true,
                    };
                }
            }
            catch
            {

                return new Response
                {
                    isSuccess = false,
                    Message = "Configure a sua ligação à Internet",
                };
            }
        }
    }
}
