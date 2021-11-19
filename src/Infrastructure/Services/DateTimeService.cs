using Pathway.Application.Common.Interfaces;

namespace Pathway.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
