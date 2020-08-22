using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_trining.Models
{
    public class tbl_news
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="الخبر")]
        public string news_name { get; set; }
        [Required]
        [Display(Name = "عنوان الخبر")]
        public string title_news { get; set; }
        [Required]
        [Display(Name = "تفاصيل الخبر")]
        public string news_desc { get; set; }
     
        [Display(Name = "1صور الخبر")]
        public string news_img1 { get; set; }
       
        [Display(Name = "2صور الخبر")]
        public string news_img2 { get; set; }
      
        [Display(Name = "3صور الخبر")]
        public string news_img3 { get; set; }
        
        [Display(Name = "4صور الخبر")]
        public string news_img4 { get; set; }
        [Required]
        [Display(Name = " القسم المعني بالخبر")]
        public int news_category { get; set; }
        [Display(Name = "تاريخ الخبر")]
        public string date_news { get; set; }
    }
}