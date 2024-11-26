using WEB_253504_PATREBKA.Domain.Entities;
using WEB_253504_PATREBKA.Domain.Models;

namespace WEB_253504_PATREBKA.UI.Services.ComponentService;

public interface IComponentService
{
/// <summary>
/// Получение списка всех объектов
/// </summary>
/// <param name="categoryNormalizedName">нормализованное имя категории дляфильтрации</param>
/// <param name="pageNo">номер страницы списка</param>
/// <returns></returns>
public Task<ResponseData<ListModel<ElectricComponent>>> GetProductListAsync(string? categoryNormalizedName, int pageNo=1);

/// <summary>
/// Поиск объекта по Id
/// </summary>
/// <param name="id">Идентификатор объекта</param>
/// <returns>Найденный объект или null, если объект не найден</returns>
public Task<ResponseData<ElectricComponent>> GetProductByIdAsync(int id);

/// <summary>
/// Обновление объекта
/// </summary>
/// <param name="id">Id изменяемомго объекта</param>
/// <param name="product">объект с новыми параметрами</param>
/// <param name="formFile">Файл изображения</param>
/// <returns></returns>
public Task UpdateProductAsync(int id, ElectricComponent product, IFormFile? formFile);

/// <summary>
/// Удаление объекта
/// </summary>
/// <param name="id">Id удаляемомго объекта</param>
/// <returns></returns>
public Task DeleteProductAsync(int id);

/// <summary>
/// Создание объекта
/// </summary>
/// <param name="product">Новый объект</param>
/// <param name="formFile">Файл изображения</param>
/// <returns>Созданный объект</returns>
public Task<ResponseData<ElectricComponent>> CreateProductAsync(ElectricComponent product, IFormFile? formFile);
}