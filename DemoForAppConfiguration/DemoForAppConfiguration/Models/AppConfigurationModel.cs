using System.ComponentModel.DataAnnotations;

namespace DemoForAppConfiguration.Models
{
    public class AppConfigurationModel
    {
        [Required]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
