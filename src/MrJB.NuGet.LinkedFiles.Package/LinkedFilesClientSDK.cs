
using MrJB.NuGet.LinkedFiles.Domain.Models;

namespace MrJB.NuGet.LinkedFiles.Package;

public class LinkedFilesClientSDK : ILinkedFilesClientSDK
{
    public async Task DoWork(Customer customer)
    {
        await Task.Delay(500);
    }
}
