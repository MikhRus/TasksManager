using System;
using System.Collections.Generic;
using System.Text;

namespace TasksManager.ViewModels.Response
{
    public class ListResponse<Titem> where Titem : class 
    {
        public ICollection<Titem> Items { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Sorting { get; set; }
        public int TotalItemsCount { get; set; }

        public int TotalPagesCount
        {
            get
            {
                int pagesCount = TotalItemsCount / PageSize;
                if (TotalItemsCount % PageSize != 0)
                {
                    pagesCount++;
                }
                return pagesCount;
            }
        }
    }
}
