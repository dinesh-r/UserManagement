using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using UserManagement.Infrastructure.ViewModel;

namespace UserManagement.Infrastructure.Extensions
{
    public static class CollectionExtensions
    {
        public static async Task<GridDataModel<T>> ToGridDataAsync<T>
            (this IQueryable<T> query, GridModel gridModel) where T : class
        {
            var sortExpression = "";
            if (gridModel.SortColumn != null && gridModel.SortColumn.Length > 0)
            {
                var sortDirection = gridModel.SortAscending ? "asc" : "desc";
                sortExpression = $"{gridModel.SortColumn} {sortDirection}";
                query = query.OrderBy(sortExpression);
            }

            var pagedResult = new GridDataModel<T> { RecordsTotal = query.Count() };
            query = query.Skip(gridModel.Skip).Take(gridModel.Take);
            pagedResult.Data = await query.ToListAsync();
           // pagedResult.Draw = gridModel.Draw;
            return pagedResult;
        }
    }
}
