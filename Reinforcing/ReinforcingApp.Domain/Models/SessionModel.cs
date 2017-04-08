using System;
using System.ComponentModel.DataAnnotations;

namespace ReinforcingApp.Domain.Models
{
    public class SessionModel: ModelBase
    {
        [Key]
        public int SessionsControl_Id { get; set; }
        public string LastValidToken { get; set; }
        public DateTime DateTimeToControlRequestLimist { get; set; }
        public long RequestCountByMinute { get; set; }
        public bool RequestLimitExceded { get; set; }
        public string Application_Id { get; set; }
        public virtual ApplicationModel Application { get; set; }
    }
}
