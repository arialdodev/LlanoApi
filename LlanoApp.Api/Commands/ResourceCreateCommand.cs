using LlanoApp.Api.Dto;
using LlanoApp.Domain.Common;
using MediatR;
using System.Text.RegularExpressions;

namespace LlanoApp.Api.Commands
{
    public class ResourceCreateCommand : IRequest<Result<bool>>
    {
        public ResourceCreateDto ResourceCreateDto { get; private set; }

        public ResourceCreateCommand(ResourceCreateDto resourceCreateDto)
        {
            ResourceCreateDto = resourceCreateDto;
        }

        public Result<bool> Validate()
        {
            #region Validaciones Name
            if (string.IsNullOrWhiteSpace(ResourceCreateDto.Name))
            {
               return Result<bool>.Failure(
                    error: "el nombre es requerido" + nameof(ResourceCreateDto.Name),
                    errorType: ErrorType.Validation
                );
            }

            if (ResourceCreateDto.Name.Length < 7)
            {
                return Result<bool>.Failure(
                    error: "Name deberia tener mas de 7 caracteres" + nameof(ResourceCreateDto.Name),
                    errorType: ErrorType.Validation
                    );
            }

            if (ResourceCreateDto.ResourceTypesId == 1 && string.IsNullOrWhiteSpace(ResourceCreateDto.Image))
            {
                return Result<bool>.Failure(
                    error: "imagen es requerida" + nameof(ResourceCreateDto.Image),
                    errorType: ErrorType.Validation);

            }

            if (!Regex.IsMatch(ResourceCreateDto.Name, @"^\D+$"))
            {
                return Result<bool>.Failure(error: "los numeros no son permitidos en el nombre" + nameof(ResourceCreateDto.Name),
                    errorType: ErrorType.Validation);
            }
            #endregion

            #region Validaciones Description
            if (string.IsNullOrWhiteSpace(ResourceCreateDto.Description))
            {
                return Result<bool>.Failure(error: "La Descripcion es requerida" + nameof(ResourceCreateDto.Description),
                    errorType: ErrorType.Validation);
            }

            if (ResourceCreateDto.ResourceTypesId == 1 && ResourceCreateDto.Description.Length < 600)
            {
                return Result<bool>.Failure(error: "La descripcion debe tener mas de 600 caracteres" + nameof(ResourceCreateDto.Description),
                    errorType: ErrorType.Validation);
            }

            if (!Regex.IsMatch(ResourceCreateDto.Description, @"^\D+$"))
            {
                return Result<bool>.Failure(error: "no se pueden poner numeros en la descripcion" + nameof(ResourceCreateDto.Description),
                    errorType: ErrorType.Validation);
            }
            #endregion

            if (!Regex.IsMatch(string.Join(",",ResourceCreateDto.ResourceTypesId), @"^([1-4](,[1-4])*)?$"))
            {
                return Result<bool>.Failure(error: "Tiene que ser menor a 4" + nameof(ResourceCreateDto.ResourceTypesId),
                    errorType: ErrorType.Validation);
            }

            return Result<bool>.Success(true);
        }
    }
}
