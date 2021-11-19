using Pathway.Application.Common.Mappings;
using Pathway.Domain.Entities;

namespace Pathway.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
