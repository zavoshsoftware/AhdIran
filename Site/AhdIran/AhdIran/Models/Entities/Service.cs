using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Service:BaseEntity
    {
        [Display(Name = "عنوان")]
        public string Title { get; set; }

      

        [Display(Name = "تصویر")]
        public string ImageUrl { get; set; }

        [Display(Name = "پارامتر url")]
        public string UrlParam { get; set; }
         

        [Display(Name = "تعداد بازدید")]
        public int Visit { get; set; }

        [Display(Name = "خلاصه")]
        [DataType(DataType.Html)]
        [AllowHtml]
        [Column(TypeName = "ntext")]
        [UIHint("RichText")]
        public string Summery { get; set; }

        [Display(Name = "متن")]
        [DataType(DataType.Html)]
        [AllowHtml]
        [Column(TypeName = "ntext")]
        [UIHint("RichText")]
        [Required(ErrorMessage = "فیلد {0} اجباری می باشد.")]
        public string Body { get; set; }

    }
}