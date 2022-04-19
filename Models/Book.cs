using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace MVCBooks.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Display (Name ="Tên")]
        public string Title { get; set; }
        [Display(Name = "Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Ngôn Ngữ Lập Trình")]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Giá Tiền")]
        [DataType (DataType.Currency)]
        public decimal Price { get; set; }
    }
}
