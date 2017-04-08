using System.ComponentModel.DataAnnotations;

namespace ReinforcingApp.Domain.Models
{
    public class ApplicationModel:ModelBase
    {
        [Key]
        public string Application_Id { get; set; }
        public string Display_Name { get; set; }
        public string SecretKey { get; set; }
   }
}