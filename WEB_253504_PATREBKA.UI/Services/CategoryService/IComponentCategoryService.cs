using WEB_253504_PATREBKA.Domain.Entities;
using WEB_253504_PATREBKA.Domain.Models;

namespace WEB_253504_PATREBKA.UI.Services.CategoryService
{

  public interface IComponentCategoryService
  {
    ///<summary>
    /// Получение списка всех категорий
    /// </summary>
    /// <returns></returns>
    public Task<ResponseData<List<ComponentCategory>>> GetCategoryListAsync();
  }
}
