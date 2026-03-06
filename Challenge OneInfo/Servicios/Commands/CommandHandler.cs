namespace Challenge_OneInfo.Servicios.Commands
{
    public class CommandHandler
    {
        
        public CommandHandler() { }

        public CommandResponse Handler(CommandRequest request)
        {
            var response = new CommandResponse();
            try
            {
                // reviso que no esten en null los datos
                if (request == null) {
                    //caso null envio msj error
                    response.Mensaje = "Error procesando datos";
                    return response;
                }

                // msj con el nombre
                response.Mensaje = $"Se recibió el nombre \"{request.Nombre}\"";

            }
            catch(Exception ex)
            {
                response.Mensaje = "Error interno: " + ex.Message;
            }

            return response;
        }
    }
}
