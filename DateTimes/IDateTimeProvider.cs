using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.BuildingBlocks.DateTimes
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
    }
}
