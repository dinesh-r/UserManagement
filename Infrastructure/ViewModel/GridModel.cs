namespace UserManagement.Infrastructure.ViewModel
{
    public class GridModel
    {
        public int Draw { get; set; }

        public int Skip { get; set; }

        public int Take { get; set; }

        public string SortColumn { get; set; }

        public bool SortAscending { get; set; }

        public GridModel()
        {
            Draw = 1;
            Skip = 0;
            Take = 10;
            SortColumn = string.Empty;
            SortAscending = true;
        }
    }
}
