﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Icon { get; set; } = "";
        [Column(TypeName = "nvarchar(20)")]
        public string Type { get; set; } = "Expense";
        [NotMapped]
        public string? TitleWithIcon
        {
            get
            {
                return $"{Icon} {Title}";
            }
        }
    }
}
