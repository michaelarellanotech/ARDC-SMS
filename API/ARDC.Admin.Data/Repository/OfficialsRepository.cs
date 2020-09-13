using ARDC.Admin.Common.Pagination;
using ARDC.Admin.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace ARDC.Admin.Data.Repository
{
    public class OfficialsRepository: IOfficialsRepository
    {
        private readonly ARDCDataContext _dbContext;

        public OfficialsRepository(ARDCDataContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<int> Count(FilterRequest filterReq)
        {
            var query = GetFilteringQuery(filterReq);
            return await query.CountAsync();
        }

        public async Task<List<vwOfficialsEventDay>> GetAll(PagingRequest pagingReq, FilterRequest filterReq)
        {
            var query = GetFilteringQuery(filterReq);

            if (!string.IsNullOrWhiteSpace(pagingReq.SortBy))
            {
                query = query.OrderBy($"{pagingReq.SortBy} {pagingReq.SortOrder}");
            }

            return await query.Skip((pagingReq.Page - 1) * pagingReq.PageSize)
                                .Take(pagingReq.PageSize)
                                .AsNoTracking()
                                .ToListAsync();
        }

        public IQueryable<vwOfficialsEventDay> GetFilteringQuery(FilterRequest filterReq)
        {
            var query = _dbContext.vwOfficialsEventDay.AsQueryable();

            // name or description
            if (!string.IsNullOrWhiteSpace(filterReq.Search))
            {
                query = query.Where(x => (x.Firstname.Contains(filterReq.Search)
                                            || x.Surname.Contains(filterReq.Search)
                                            || x.EventType.Contains(filterReq.Search)));
            }

            if (filterReq.Filters != null)
            {
                foreach (var filter in filterReq.Filters)
                {
                    switch (filter.FilterBy)
                    {
                        //case "groupId":
                        //    query = query.Where(x => (x.GroupId.Equals(filter.Value[0], StringComparison.OrdinalIgnoreCase)));
                        //    break;

                        //case "name":
                        //    query = query.Where(x => (x.Name.Contains(filter.Value[0])));
                        //    break;

                        //case "description":
                        //    query = query.Where(x => (x.Description.Contains(filter.Value[0])));
                        //    break;

                        //case "modifiedby":
                        //    query = query.Where(x => (x.ModifiedBy.Contains(filter.Value[0])));
                        //    break;

                        //case "comment":
                        //    query = query.Where(x => (x.Comment.Contains(filter.Value[0])));
                        //    break;

                        //case "status":
                        //    var options = filter.Value.ToList();
                        //    query = query.Where(x => options.Contains(x.Status));
                        //    break;

                        default:
                            break;
                    }
                }
            }

            return query;
        }
    }


    public interface IOfficialsRepository
    {
        Task<int> Count(FilterRequest filterReq);
        Task<List<vwOfficialsEventDay>> GetAll(PagingRequest pagingReq, FilterRequest filterReq);
        IQueryable<vwOfficialsEventDay> GetFilteringQuery(FilterRequest filterReq);
    }
}
