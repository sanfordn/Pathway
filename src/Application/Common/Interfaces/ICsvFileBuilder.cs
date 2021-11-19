using Pathway.Application.TodoLists.Queries.ExportTodos;

namespace Pathway.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
