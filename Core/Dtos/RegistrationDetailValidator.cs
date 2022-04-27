using Core.Dtos;
using FluentValidation;

namespace Core.Dtos
{
    public class RegistrationDetailValidator : AbstractValidator<RegistrationDetailDto>
    {
        public RegistrationDetailValidator()
        {
            RuleFor(v => v.FirstName)
                .MinimumLength(3)
                .MaximumLength(50)
                .NotEmpty();

            RuleFor(v => v.Surname)
                .MinimumLength(3)
                .MaximumLength(50)
                .NotEmpty();

            RuleFor(v => v.Email)
                .NotEmpty()
                .Unless(v => v.DOB != null);

            RuleFor(v => v.DOB)
                .NotEmpty()
                .Must(IsOldEnough)
                .Unless(v => !string.IsNullOrEmpty(v.Email));

            RuleFor(v => v.PolicyReferenceNumber)
                .Matches("[A-Z]{2}-\\d{6}$");
        }

        private bool IsOldEnough(DateTime? dateOfBirth)
        {
            if (dateOfBirth.HasValue)
            {
                var minAge = 18;
                var currentDate = DateTime.Now;

                return dateOfBirth.Value.AddYears(minAge) <= currentDate;
            }
            else
            {
                // dob should not be null due to previous null check validation rule
                // handle dob null here
                return false;
            }
        }
    }
}
