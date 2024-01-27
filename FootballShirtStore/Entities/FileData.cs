using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballShirtStore.Entities
{
    public class FileData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public byte[] Data { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public FileDataType Type { get; set; }
        
    }
    public enum FileDataType
    {
        Image,
        Doc
    }
}
