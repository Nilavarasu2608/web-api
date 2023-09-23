using web_api.Data_Transfer_Objects_DTO;
using web_api.models;

namespace web_api.Services.CharacterServices
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto character);
    }
}