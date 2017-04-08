using System.ComponentModel.DataAnnotations;

namespace ReinforcingApp.Domain.Models
{
    public class ConfigurationModel : ModelBase
    {
        [Key]
        public long Configuration_Id { get; set; }
        public long NumberOfMinutesToWaitExceedLimite { get; set; }
        public long NumberOfRequestToExceedLimite { get; set; }
        public long NumberOfMinutesToCheckRequests { get; set; }
        public long TimeToExpireTheToken { get; set; }
    }
}
