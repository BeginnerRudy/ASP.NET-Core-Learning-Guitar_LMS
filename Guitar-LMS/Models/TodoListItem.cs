using System;
using System.ComponentModel.DataAnnotations;

namespace Guitar_LMS.Models {
    public class TodoListItem {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Title must contain at least two characters!")]
        [MaxLength(200, ErrorMessage = "Title must contain a maximum of 200 characters!")]
        public string Title { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int DurationInMinute { get; set; }

        public bool IsDone { get; set; }
    }
}   