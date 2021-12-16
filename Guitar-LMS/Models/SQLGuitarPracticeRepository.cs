using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Guitar_LMS.Models {
    public class SQLGuitarPracticeRepository : IGuitarRepository{
        private AppDbContext context;
        public SQLGuitarPracticeRepository(AppDbContext appDbContext) {
            context = appDbContext;
        }

        public GuitarPracticeCard AddGuitarPracticeCard(GuitarPracticeCard guitarPracticeCard) {
            context.GuitarPracticeCards.Add(guitarPracticeCard);
            context.SaveChanges();
            return guitarPracticeCard;
        }

        public GuitarPracticeCard GetGuitarPracticeCard(string dateStr) {
            try {
                GuitarPracticeCard guitarPracticeCard = context.GuitarPracticeCards.Include(_ => _.TodoList).AsNoTracking().First(_ => _.DateStr == dateStr);
                return guitarPracticeCard;
            } catch (Exception e) {
                e.GetBaseException();
            }
            return null;
        }

        public GuitarPracticeCard UpdateGuitarPracticeCard(GuitarPracticeCard guitarPracticeCardChanges) {
            var guitarPracticeCard = context.GuitarPracticeCards.Attach(guitarPracticeCardChanges);
            guitarPracticeCard.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return guitarPracticeCardChanges;
        }

        public TodoListItem AddTodoListItem(TodoListItem todoListItem) {
            context.TodoListItems.Add(todoListItem);
            context.SaveChanges();
            return todoListItem;
        }

        public TodoListItem DeleteTodoListItem(int id) {
            TodoListItem todoListItem = context.TodoListItems.Find(id);
            if (todoListItem != null) {
                context.TodoListItems.Remove(todoListItem);
                context.SaveChanges();
            }
            return todoListItem;
        }


        public TodoListItem GetTodoListItem(int id) {
            TodoListItem todoListItem = context.TodoListItems.Find(id);
            return todoListItem;
        }

        public TodoListItem UpdateTodoListItem(TodoListItem todoListItemChanges) {
            var todoListItem = context.TodoListItems.Attach(todoListItemChanges);
            todoListItem.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return todoListItemChanges;
        }
    }
}
