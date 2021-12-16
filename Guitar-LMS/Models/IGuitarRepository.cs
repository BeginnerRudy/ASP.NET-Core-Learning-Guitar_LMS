using System;
using System.Collections.Generic;

namespace Guitar_LMS.Models {
    public interface IGuitarRepository {
        GuitarPracticeCard GetGuitarPracticeCard(string dateStr);
        GuitarPracticeCard AddGuitarPracticeCard(GuitarPracticeCard guitarPracticeCard);
        GuitarPracticeCard UpdateGuitarPracticeCard(GuitarPracticeCard guitarPracticeCardChanges);
        TodoListItem GetTodoListItem(int id);
        TodoListItem UpdateTodoListItem(TodoListItem todoListItem);
        TodoListItem AddTodoListItem(TodoListItem todoListItem);
        TodoListItem DeleteTodoListItem(int id);
    }
}
