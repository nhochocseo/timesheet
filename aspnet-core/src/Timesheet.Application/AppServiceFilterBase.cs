using Abp.Dependency;
using Abp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.Models;
using Sieve.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.CommonDto;
using Timesheet.Entities;
using Timesheet.Filter;
using Timesheet.Paging;

namespace Timesheet
{
    public class AppServiceFilterBase<TEntity, TEntityDto> : AppServiceBase where TEntity : BaseEntity where TEntityDto : BaseEntityDto
    {
        [HttpGet]
        public List<TEntityDto> Filter(FilterParam filterParam)
        {
            ISieveProcessor _sieveProcessor = IocManager.Instance.Resolve<ISieveProcessor>();
            var result = WorkScope.GetRepo<TEntity, long>().GetAll();
            result = IncludeRelationship(filterParam, result);
            result = _sieveProcessor.Apply(filterParam, result);

            return ObjectMapper.Map<List<TEntityDto>>(result.ToList());
        }

        [HttpGet]
        public PagingResult<TEntityDto> FilterAndPaging(FilterParam filterParam)
        {
            ISieveProcessor _sieveProcessor = IocManager.Instance.Resolve<ISieveProcessor>();
            var result = WorkScope.GetRepo<TEntity, long>().GetAll();
            var total = WorkScope.GetRepo<TEntity, long>().GetAll();
            var totalPages = _sieveProcessor.Apply(filterParam, result, null, true, false, false).Count();
            result = IncludeRelationship(filterParam, result);
            result = _sieveProcessor.Apply(filterParam, result);
            return new PagingResult<TEntityDto>
            {
                TotalPages = totalPages,
                Items = ObjectMapper.Map<List<TEntityDto>>(result.ToList())
            };
        }

        public virtual async Task<TEntityDto> Get(long id, string includes)
        {
            var result = WorkScope.GetRepo<TEntity, long>().GetAll();
            FilterParam filterParam = new FilterParam();
            filterParam.Includes = includes;
            result = IncludeRelationship(filterParam, result);
            var rs = await result.Where(r => r.Id == id).FirstOrDefaultAsync();

            return ObjectMapper.Map<TEntityDto>(rs);
        }

        private IQueryable<TEntity> IncludeRelationship(FilterParam filterParam, IQueryable<TEntity> result)
        {
            if (filterParam.Includes != null)
            {
                String[] relationship = filterParam.Includes.Split(",");
                foreach (var r in relationship)
                {
                    result = result.Include(r);
                }
            }
            return result;
        }

        public virtual async Task<TEntityDto> Save(TEntityDto dto)
        {
            return ObjectMapper.Map<TEntityDto>(await SaveReturnEntity(dto));
        }

        public virtual async void Delete(long id)
        {
            var ent = await WorkScope.GetAsync<TEntity>(id);
            await WorkScope.DeleteAsync(ent);
        }

        protected async Task<TEntity> SaveReturnEntity(TEntityDto dto)
        {
            TEntity result = null;
            if (dto.Id.HasValue)
            {
                result = await WorkScope.UpdateAsync(ObjectMapper.Map<TEntity>(dto));
            }
            else
            {
                result = await WorkScope.InsertAsync(ObjectMapper.Map<TEntity>(dto));
            }

            return result;
        }
    }
}
