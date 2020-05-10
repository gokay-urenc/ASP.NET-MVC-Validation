using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_29_Validation.Models
{
    public class Kategori
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Adı alanı boş bırakılamaz."), MinLength(3, ErrorMessage = "Lütfen en az 3 karakter giriniz.")]
        public string adi { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş bırakılamaz.")]
        public string aciklamasi { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz."), MinLength(4, ErrorMessage = "En az 4 karakter giriniz.")]
        public string sifre { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı alanı boş bırakılamaz."), MinLength(4, ErrorMessage = "En az 4 karakter giriniz.")]
        [Compare("sifre", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string sifre_tekrari { get; set; }
    }
}