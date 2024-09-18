using FluentValidation;
using LlanoApp.Api.Dto;

namespace LlanoApp.Api.Validations.Resource
{
    public class ResourceCreateDtoValidator : AbstractValidator<ResourceCreateDto>
    {
        public ResourceCreateDtoValidator()
        {
            #region Validaciones de name
            RuleFor(ResourceCreateDto => ResourceCreateDto.Name)
                .NotEmpty().WithMessage("El nombre es requerido.");

            RuleFor(ResourceCreateDto => ResourceCreateDto.Name)
                .MinimumLength(8).WithMessage("Nombre deberia tener mas de 7 caracteres.");

            RuleFor(ResourceCreateDto => ResourceCreateDto.Name)
                .Matches(@"^\D+$").WithMessage("los numeros no son permitidos en el nombre");
            #endregion

            RuleFor(ResourceCreateDto => ResourceCreateDto.Image)
                .NotEmpty()
                .When(ResourceCreateDto => ResourceCreateDto.ResourceTypesId == 1)
                .WithMessage("la imagen es requerida cuando el recurso es una leyenda");

            #region
            RuleFor(ResourceCreateDto => ResourceCreateDto.Description)
                .NotEmpty().WithMessage("La Descripcion es requerida");

            RuleFor(resource => resource.Description)
            .MinimumLength(601)
            .When(resource => resource.ResourceTypesId == 1)
            .WithMessage("La descripción debe tener más de 600 caracteres cuando el recurso es una leyenda.");

            RuleFor(ResourceCreateDto => ResourceCreateDto.Description)
                .Matches(@"^\D*$")
                .WithMessage("no se pueden poner numeros en la descripcion");
            #endregion

            RuleFor(ResourceCreateDto => ResourceCreateDto.ResourceTypesId.ToString())
                .Matches(@"^([1-4](,[1-4])*)?$").WithMessage("Tiene que ser menor a 4");
        }
    }
}