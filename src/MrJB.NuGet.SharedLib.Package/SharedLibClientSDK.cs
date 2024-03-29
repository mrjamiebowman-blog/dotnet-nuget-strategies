namespace MrJB.NuGet.SharedLib.Package;

public class SharedLibClientSDK : ISharedLibClientSDK
{
    public async Task DoWork()
    {
        await Task.Delay(200);
    }
}
