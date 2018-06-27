﻿using System.ComponentModel.DataAnnotations;

namespace ForumIT.Models
{
    public class PodKomentarz
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int IdPodKomentarza { get; set; }

        [Required]
        [Display(Name = "Treść komentarza:")]
        [DataType(DataType.MultilineText)]
        public string Tresc { get; set; }

        [Display(Name = "Data dodania:")]
        [DataType(DataType.Date, ErrorMessage = "Niepoprawny format daty")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public System.DateTime DataDodania { get; set; }

        [Display(Name = "Autor komentarza:")]
        public string Id { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }

        [Display(Name = "Komentowany tekst:")]
        public int IdKomentarza { get; set; }
        public virtual Komentarz Komentarz { get; set; }
    }
}