using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Guitar_LMS.Models {
    public class GuitarPracticeCard {
        public GuitarPracticeCard() {
        }
        [Key]
        public string DateStr { get; set; }

        public string Summary { get; set; }

        public ICollection<TodoListItem> TodoList { get; set; }
    }
}
