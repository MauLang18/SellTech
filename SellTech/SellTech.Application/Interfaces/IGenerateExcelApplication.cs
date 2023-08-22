using SellTech.Infrastructure.Commons.Bases.Response;

namespace SellTech.Application.Interfaces
{
    public interface IGenerateExcelApplication
    {
        byte[] GenerateToExcel<T>(BaseEntityResponse<T> data, List<(string ColumnName, string PropertyName)> columns);
    }
}
