using System.Collections.Generic;

namespace UserManagement.Infrastructure.ViewModel
{
    public class GridDataModel<T> where T : class 
    {
        public int RecordsTotal { get; set; }

        public int RecordsFiltered { get; set; }

        public IList<T> Data { get; set; }

        public int Draw { get; set; }
    }
}
