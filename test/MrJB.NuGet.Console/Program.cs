using MrJB.NuGet.LinkedFiles.Domain.Models;
using MrJB.NuGet.LinkedFiles.Package;
using MrJB.NuGet.SharedLib.Domain.Models;
using MrJB.NuGet.SharedLib.Package;


var client1 = new LinkedFilesClientSDK();

var customer = new Customer();
customer.CustomerId = Guid.NewGuid();
customer.FirstName = "Jamie";
customer.LastName = "Bowman";
customer.Email = "notreal@email.com";

await client1.DoWork(customer);

var client2 = new SharedLibClientSDK();

var order = new Order();
order.OrderId = 1234;
order.CustomerId = customer.CustomerId;
order.Total = 120M;

await client2.DoWork(order);



Console.WriteLine("@mrjamiebowman");
