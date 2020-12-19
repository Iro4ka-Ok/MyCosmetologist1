using System.Linq;
using MyCosmetologist.Data.Repositories.Interfaces;
using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Services.Mappers;
using MyCosmetologist.Services.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task Add(ClientDto dto)
        {
            var entity = dto.MapToEntity();
            await _clientRepository.Add(entity);
        }

        public async Task Delete(int id)
        {
            await _clientRepository.Delete(id);
        }

        public async Task Edit(ClientDto dto)
        {
            var entity = await _clientRepository.GetById(dto.Id);
            if (entity == null)
            {
                return;
            }

            entity.Name = dto.Name;
            entity.SurName = dto.SurName;
            entity.Email = dto.Email;
            entity.Phone = dto.Phone;
            entity.BirthDate = dto.BirthDate;
            entity.Gender = dto.Gender;

            await _clientRepository.Update(entity);
        }

        public async Task<ClientDto> Get(int id)
        {
            return (await _clientRepository.GetById(id)).MapToDto();
        }

        public IList<ClientDto> GetItems(string search)
        {
            var query = _clientRepository.GetAllQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(g => g.Name.ToUpper().Contains(search.ToUpper()));
            }

            return query.ToList()
                .Select(s => s.MapToDto())
                .ToList();
        }
    }
}
