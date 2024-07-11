using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "exemple",
            Type = Communication.Enums.PetType.Cat,
            Birthday = new DateTime(year: 2022, month: 02, day: 31),
        }; 
    }
}