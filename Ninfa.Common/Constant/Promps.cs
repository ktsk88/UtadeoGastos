namespace Ninfa.Common
{
    public class Promps
    {
        public const string FindIntention = "Puedes detectar la intencion del usuario que envia el siguiente mensaje \"{0}\" "; //mensaje
        public const string UserDude = "Un usuario llamado {0} con cedula terminada en {1} pregunta \"{2}\""; //Nombre- cedula - pregunta
        public const string UserEasyDude = "Un usuario llamado {0} pregunta \"{1}\""; //Nombre -pregunta
        public const string EasyDude = "Un usuario pregunta \"{0}\""; //Pregunta
        public const string UserDataDude = "De acuerdo a la siguiente informacion, responder a la pregunta que realiza {0}, \n \"{1}\"  \n {2}"; //Nombre- pregunta - datos
        public const string RgxGreet = @"(Saludar)";
        public const string RgxKnowMore = @"(Saber mas)";
        public const string RgxHowToWork = @"(Como funciona)";
        public const string RgxConsult = @"(Consulta)";
        public const string RgxAvailableBalance = @"(Validacion saldo disponible)";
        public const string RgxInfoCredits = @"(Consulta cuotas credito)";
        public const string RgxSettings = @"(Configuracion)";
        public const string RgxInfoYear = @"(Informe año )(\-|\+)(\d{1,2})";
        public const string RgxInfoMonth = @"(Informe mes )(\-|\+)(\d{1,2})";
    }
}
