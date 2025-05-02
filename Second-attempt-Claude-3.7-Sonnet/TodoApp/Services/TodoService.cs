using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private List<Todo> _todos;
        private int _nextId = 1;

        public TodoService()
        {
            _todos = new List<Todo>
            {
                new Todo { Id = _nextId++, Title = "Learn Blazor", IsComplete = false },
                new Todo { Id = _nextId++, Title = "Build a Todo App", IsComplete = false },
                new Todo { Id = _nextId++, Title = "Deploy the application", IsComplete = false }
            };
        }

        public List<Todo> GetAllTodos()
        {
            return _todos;
        }

        public Todo? GetTodoById(int id)
        {
            return _todos.FirstOrDefault(t => t.Id == id);
        }

        public void AddTodo(Todo todo)
        {
            todo.Id = _nextId++;
            todo.CreatedDate = DateTime.Now;
            _todos.Add(todo);
        }

        public void UpdateTodo(Todo todo)
        {
            var existingTodo = _todos.FirstOrDefault(t => t.Id == todo.Id);
            if (existingTodo != null)
            {
                existingTodo.Title = todo.Title;
                existingTodo.IsComplete = todo.IsComplete;
            }
        }

        public void DeleteTodo(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                _todos.Remove(todo);
            }
        }
    }
}