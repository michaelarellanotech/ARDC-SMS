using ARDC.Admin.API.DTOs;
using ARDC.Admin.API.Extensions;
using ARDC.Admin.Common.Extension;
using ARDC.Admin.Common.Pagination;
using ARDC.Admin.Data.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace ARDC.Admin.API.Services
{
    public class OfficialsService: IOfficialsService
    {
        private readonly IOfficialsRepository _officialsRepository;

        public OfficialsService(IOfficialsRepository officialsRepository) 
        {
            _officialsRepository = officialsRepository;
        }

        public async Task<PageResult<OfficialsListItem>> GetAll(PagingRequest pagingReq, FilterRequest filterReq)
        {
            pagingReq.TotalRecords = await _officialsRepository.Count(filterReq);
            var items = await _officialsRepository.GetAll(pagingReq, filterReq);

            return pagingReq.ToPageResult(items.Select(item => item.ToDto()));
        }

    }

    public interface IOfficialsService
    {
        Task<PageResult<OfficialsListItem>> GetAll(PagingRequest pagingReq, FilterRequest filterReq);
    }
}
