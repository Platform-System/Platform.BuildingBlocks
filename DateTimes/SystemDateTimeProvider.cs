using Platform.BuildingBlocks.Abstractions;

namespace Platform.BuildingBlocks.DateTimes
{
    public class SystemDateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
