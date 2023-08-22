using SellTech.Infrastructure.Commons.Bases.Response;
using SellTech.Utilities.Static;

namespace SellTech.Infrastructure.FileExcel
{
    public interface IGenerateExcel
    {
        MemoryStream GenerateToExcel<T>(BaseEntityResponse<T> data, List<TableColumns> columns);
    }
}
