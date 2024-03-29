using MrJB.NuGet.LinkedFiles.Domain.Models;

namespace MrJB.NuGet.LinkedFiles.Package;

public interface ILinkedFilesClientSDK
{
    Task DoWork(Customer customer);
}
