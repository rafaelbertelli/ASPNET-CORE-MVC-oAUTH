using System;

namespace Tarefas.Models
{
    public class TarefaItem
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public bool EstaCompleta { get; set; }

        public DateTimeOffset? DataConclasao { get; set; }
        
    }
}