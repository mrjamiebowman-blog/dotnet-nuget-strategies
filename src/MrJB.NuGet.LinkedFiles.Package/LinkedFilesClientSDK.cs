
namespace MrJB.NuGet.LinkedFiles.Package;

public class LinkedFilesClientSDK : ILinkedFilesClientSDK
{
    public async Task DoWork()
    {
        await Task.Delay(500);
    }
}
