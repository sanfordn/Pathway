using Pathway.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Pathway.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
