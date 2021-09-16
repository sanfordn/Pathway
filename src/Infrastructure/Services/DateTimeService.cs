using Pathway.Application.Common.Interfaces;
using System;

namespace Pathway.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
