using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_BTN.Model
{
    public class Information_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string linkTitle { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Authur { get; set; } = string.Empty;
        public DateTime Create_At { get; set; }
        public string Image {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string urlVideo { get; set; } = string.Empty;
        public int Category_Id { get; set; }
        [ForeignKey(nameof(Category_Id))]
        public Category Category ;
    }
}
