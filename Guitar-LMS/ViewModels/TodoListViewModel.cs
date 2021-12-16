using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Guitar_LMS.Models;

namespace Guitar_LMS.ViewModels {
    public class TodoListViewModel {
        public TodoListViewModel() {
            //using (var db = DbHelper.GetConnection()) {
            //    this.EditableItem = new TodoListItem();
            //    this.TodoItems = db.Query<TodoListItem>("SELECT * FROM TodoListItems ORDER BY AddDate DESC").ToList();
            //}

            this.EditableItem = new TodoListItem();
            this.TodoItems = new List<TodoListItem>();
        }

        public string DateStr { get; set; }

        public string Summary { get; set; }

        public ICollection<TodoListItem> TodoItems { get; set; }

        public TodoListItem EditableItem { get; set; }
    }
}