using CSharpFunctionalExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using WitchesHat.Domain.Core;

namespace WitchesHat.Data.Repository
{
    public interface IRepositoryBase<T> : IAggregateBase
    {
        Task<List<T>> Get();
        Task<Result<T>> Create(T newItem);
    }
}
