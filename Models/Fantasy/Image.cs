using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LovchaFantasy.Models.Fantasy
{
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(1, int.MaxValue, ErrorMessage = "ID не может быть 0.")]
        public int Id { get; private set; }
        [Required]
        public string FileName { get; private set; } = null!;
        [Required]
        public string ContentType { get; private set; } = null!;
        [Required]
        public string FilePath { get; private set; } = null!;

        public Image() {
            Games = new HashSet<Game>();
        }
        public Image(string fileName, string contentType, string filePath)
        {
            FileName = fileName;
            ContentType = contentType;
            FilePath = filePath;
        }

        public void UpdateFilePath(string newFilePath)
        {
            FilePath = newFilePath;
        }

        public void UpdateFileName(string newFileName)
        {
            FileName = newFileName;
        }
        public ICollection<Game>? Games { get; set; }
    }
}
