using LlanoApp.Api.Dto;
using MediatR;
using System.Text.RegularExpressions;

namespace LlanoApp.Api.Commands
{
    public class ResourceCreateCommand : IRequest<bool>
    {
        public ResourceCreateDto ResourceCreateDto { get; private set; }

        public ResourceCreateCommand(ResourceCreateDto resourceCreateDto)
        {
            ResourceCreateDto = resourceCreateDto;

            #region Validaciones Name
            if (string.IsNullOrWhiteSpace(resourceCreateDto.Name))
                throw new ArgumentException("el nombre es requerido", nameof(resourceCreateDto.Name));

            ResourceCreateDto.SetName(ResourceCreateDto.Name.Trim());

            if (resourceCreateDto.Name.Length < 7)
                throw new ArgumentException("Name deberia tener mas de 7 caracteres", nameof(resourceCreateDto.Name));

            if (resourceCreateDto.ResourceTypesId == 1 && string.IsNullOrWhiteSpace(resourceCreateDto.Image))
                throw new ArgumentException("imagen es requerida", nameof(resourceCreateDto.Image));

            ResourceCreateDto.SetImage(ResourceCreateDto.Image.Trim());

            if (!Regex.IsMatch(resourceCreateDto.Name, @"^\D+$"))
                throw new ArgumentException("los numeros no son permitidos en el nombre", nameof(resourceCreateDto.Name));
            #endregion

            #region Validaciones Description
            if (string.IsNullOrWhiteSpace(resourceCreateDto.Description))
                throw new ArgumentException("La Descripcion es requerida", nameof(resourceCreateDto.Description));

            ResourceCreateDto.SetDescription(ResourceCreateDto.Description.Trim());

            if (resourceCreateDto.ResourceTypesId == 1 && resourceCreateDto.Description.Length < 600)
                throw new ArgumentException("La descripcion debe tener mas de 600 caracteres", nameof(resourceCreateDto.Description));

            if (!Regex.IsMatch(resourceCreateDto.Description, @"^\D+$")) 
                throw new ArgumentException("no se pueden poner numeros en la descripcion", nameof(resourceCreateDto.Description));
            #endregion

            if (!Regex.IsMatch(string.Join(",",resourceCreateDto.ResourceTypesId), @"^([1-4](,[1-4])*)?$"))
                throw new ArgumentException("Tiene que ser menor a 4", nameof(resourceCreateDto.ResourceTypesId));
     
        }
    }
}
