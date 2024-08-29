using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LovchaFantasy.Models.Fantasy
{
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        [Required]
        public string FileName { get; private set; }
        [Required]
        public string ContentType { get; private set; }
        [Required]
        public string FilePath { get; private set; }

        public Image() { }
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
    }
}
