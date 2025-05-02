using TodoApp.Models;

namespace TodoApp.Services
{
    public interface ITodoService
    {
        List<Todo> GetAllTodos();
        Todo? GetTodoById(int id);
        void AddTodo(Todo todo);
        void UpdateTodo(Todo todo);
        void DeleteTodo(int id);
    }
}