using MrJB.NuGet.SharedLib.Domain.Models;

namespace MrJB.NuGet.SharedLib.Package;

public interface ISharedLibClientSDK
{
    Task DoWork(Order order);
}
