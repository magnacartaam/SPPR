using WEB_253504_PATREBKA.Domain.Entities;
using WEB_253504_PATREBKA.Domain.Models;

namespace WEB_253504_PATREBKA.UI.Services.ComponentService;

// public class MemoryProductService : IComponentService
//   {
//     public Task<ResponseData<List<ElectricComponent>>> GetProductListAsync()
//     {
//       var products = new List<ElectricComponent>
//       {
//         new ElectricComponent {Id=1, Name="Resistors",
//         Description="resistors"},
//         new ElectricComponent {Id=2, Name="Transistors",
//         Description="transistors"},
//         new ElectricComponent {Id=3, Name="Capasitors", Description="capasitors"},
//         new ElectricComponent {Id=4, Name="Transformers",
//         Description="tranformers"},
//         new ElectricComponent {Id=5, Name="Diodes",
//         Description="diodes"},
//         new ElectricComponent {Id=6, Name="Switches",
//         Description="switches"}
//       };
//       var result = ResponseData<List<ComponentCategory>>.Success(categories);
//       return Task.FromResult(result);
//     }
//   }