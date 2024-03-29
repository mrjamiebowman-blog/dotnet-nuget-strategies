using MrJB.NuGet.SharedLib.Domain.Models;

namespace MrJB.NuGet.SharedLib.Package;

public class SharedLibClientSDK : ISharedLibClientSDK
{
    public async Task DoWork(Order order)
    {
        await Task.Delay(200);
    }
}
