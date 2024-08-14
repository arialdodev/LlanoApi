using LlanoApp.Api.Dto;
using MediatR;
using System.Text.RegularExpressions;

namespace LlanoApp.Api.Commands
{
    public class CreateResourceCommand : IRequest<bool>
    {
        public ResourceCreateDto CreateResourceDto { get; private set; }

        public CreateResourceCommand(ResourceCreateDto createResourceDto)
        {
            CreateResourceDto = createResourceDto;

            #region Validaciones Name
            if (string.IsNullOrWhiteSpace(createResourceDto.Name))
                throw new ArgumentException("el nombre es requerido", nameof(createResourceDto.Name));

            CreateResourceDto.SetName(CreateResourceDto.Name.Trim());

            if (createResourceDto.Name.Length < 7)
                throw new ArgumentException("Name deberia tener mas de 7 caracteres", nameof(createResourceDto.Name));

            if (createResourceDto.ResourceTypesId == 1 && string.IsNullOrWhiteSpace(createResourceDto.Image))
                throw new ArgumentException("imagen es requerida", nameof(createResourceDto.Image));

            CreateResourceDto.SetImage(CreateResourceDto.Image.Trim());

            if (!Regex.IsMatch(createResourceDto.Name, @"^\D+$"))
                throw new ArgumentException("los numeros no son permitidos en el nombre", nameof(createResourceDto.Name));
            #endregion

            #region Validaciones Description
            if (string.IsNullOrWhiteSpace(createResourceDto.Description))
                throw new ArgumentException("La Descripcion es requerida", nameof(createResourceDto.Description));

            CreateResourceDto.SetDescription(CreateResourceDto.Description.Trim());

            if (createResourceDto.ResourceTypesId == 1 && createResourceDto.Description.Length < 600)
                throw new ArgumentException("La descripcion debe tener mas de 600 caracteres", nameof(createResourceDto.Description));

            if (!Regex.IsMatch(createResourceDto.Description, @"^\D+$")) 
                throw new ArgumentException("no se pueden poner numeros en la descripcion", nameof(createResourceDto.Description));
            #endregion

            if (!Regex.IsMatch(string.Join(",",createResourceDto.ResourceTypesId), @"^([1-4](,[1-4])*)?$"))
                throw new ArgumentException("Tiene que ser menor a 4", nameof(createResourceDto.ResourceTypesId));
     
        }
    }
}
