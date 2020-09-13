using FluentValidation;

namespace ARDC.Admin.Common.Pagination
{ 
    public class PagingRequestValidator<T> : AbstractValidator<PagingRequest<T>>
    {
        private const string InvalidSortByFieldMessage = "Invalid value for 'sortBy' field.";

        public PagingRequestValidator()
        {
            RuleFor(model => model.Page).GreaterThanOrEqualTo(1);
            RuleFor(model => model.PageSize).GreaterThanOrEqualTo((int)PageSizeDefinitions.Small).LessThanOrEqualTo((int)PageSizeDefinitions.Large);

            RuleFor(model => model.SortBy)
                .Must((model, b) => string.IsNullOrWhiteSpace(model.SortBy) || Validator.Validator.ValidPropertieNames<T>(new[] { model.SortBy }))
                .WithMessage(InvalidSortByFieldMessage);
        }
    }
}
