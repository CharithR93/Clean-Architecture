using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces
{
    public interface IAddRange<T>
    {
        Task AddRangeAsync(List<T> entities);
    }
}