using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WatchVideo.Models
{
    [Table("Video", Schema = "dbo")]
    public partial class Video
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VideoId { get; set; }
        public string? VideoName { get; set; }
        public string? VideoPoster { get; set; }
        public string? VideoUrl { get; set; }
        public string? VideoDiscrption { get; set; }
        public string? userId { get; set; } = string.Empty;
        public bool? DelFlage { get; set; } = false;

    }
}
