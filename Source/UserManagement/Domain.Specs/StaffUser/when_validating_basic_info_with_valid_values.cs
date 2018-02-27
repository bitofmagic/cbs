using Machine.Specifications;
using Domain.StaffUser;
using System;
using FluentValidation.Results;
using System.Collections.Generic;

namespace Domain.Specs.StaffUser
{
    [Subject(typeof(BasicInfoValidator))]
    public class when_validating_basic_info_with_valid_values
    {
        static BasicInfoValidator validator;
        static ValidationResult validation_results;
        static BasicInfo sut;

        Establish context = () =>
        {
            validator = new BasicInfoValidator();
            sut = new BasicInfo
            {
                StaffUserId = Guid.NewGuid(),
                Email = "user@redcross.no",
                FullName = "Our New User"
            };
        };

        Because of = () => { validation_results = validator.Validate(sut); };

        It should_be_valid = () => validation_results.ShouldBeValid();    
    }
}