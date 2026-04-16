namespace Platform.BuildingBlocks.Abstractions;

public interface ICurrentUserProvider
{
    string? CurrentUserId { get; }
}
