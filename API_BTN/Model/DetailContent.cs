using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_BTN.Model
{
    public class DetailContent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Detail_Id { get; set; }
        [ForeignKey(nameof(Detail_Id))]
        public Information_Details  Information_Details;
        public string Detail_Content { get; set; } = string.Empty;
    }
}
