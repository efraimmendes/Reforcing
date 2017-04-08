using System.ComponentModel.DataAnnotations;

namespace ReinforcingApp.Domain.Models
{
    public class LogModel:ModelBase
    {
        [Key]
        public int Log_Id { get; set; }
        public string Logger { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string Application_Id { get; set; }
        public virtual ApplicationModel Application { get; set; }
    }
}