using ShareTV.Domain.Entities;
using ShareTV.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ShareTV.Application.Contratos
{
    public interface ILiveStreamService
    {
        Task<LiveStream> CreateLiveAsync(CreateLiveDto dto);
        Task<IEnumerable<LiveStream>> GetAllAsync();

    }
}