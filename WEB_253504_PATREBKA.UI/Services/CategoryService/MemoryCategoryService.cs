using WEB_253504_PATREBKA.Domain.Models;
using WEB_253504_PATREBKA.Domain.Entities;

namespace WEB_253504_PATREBKA.UI.Services.CategoryService
{

  public class MemoryCategoryService : IComponentCategoryService
  {
    public Task<ResponseData<List<ComponentCategory>>> GetCategoryListAsync()
    {
      var categories = new List<ComponentCategory>
      {
        new ComponentCategory {Id=1, Name="Resistors",
        NormalizedName="resistors"},
        new ComponentCategory {Id=2, Name="Transistors",
        NormalizedName="transistors"},
        new ComponentCategory {Id=3, Name="Capasitors", NormalizedName="capasitors"},
        new ComponentCategory {Id=4, Name="Transformers",
        NormalizedName="tranformers"},
        new ComponentCategory {Id=5, Name="Diodes",
        NormalizedName="diodes"},
        new ComponentCategory {Id=6, Name="Switches",
        NormalizedName="switches"}
      };
      var result = ResponseData<List<ComponentCategory>>.Success(categories);
      return Task.FromResult(result);
    }
  }
}
