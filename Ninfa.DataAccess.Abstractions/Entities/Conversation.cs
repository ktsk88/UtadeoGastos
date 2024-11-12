using System.ComponentModel.DataAnnotations;

namespace Ninfa.Entities
{
    public class Conversation
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        [MaxLength(200)]
        public string Intention { get; set; } = string.Empty;
        [MaxLength(800)]
        public string UserMessage { get; set; } = string.Empty;
        [MaxLength(800)]
        public string PromptSended { get; set; } = string.Empty;
        [MaxLength(800)]
        public string BotResponse { get; set; } = string.Empty;

        #region Relations
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = new();
        #endregion
    }
}
