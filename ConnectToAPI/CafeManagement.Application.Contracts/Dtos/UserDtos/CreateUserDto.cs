﻿using System.ComponentModel.DataAnnotations;

namespace CafeManagement.Application.Contracts.Dtos.UserDtos
{
    public class CreateUserDto : IValidatableObject
    {
        public Guid Id { get; set; }
        public Guid UserTypeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public void ValidateUser()
        {

            if (!string.IsNullOrEmpty(Email))
            {
                if (CheckEmailConvert(Email) == false)
                {
                    throw new Exception("Email is deficiency @gmail.com");
                }
            }



            if (string.IsNullOrEmpty(PhoneNumber))
            {
                throw new Exception("Phone number is empty");
            }

            if (CheckPhoneNumberConvert(PhoneNumber) == null)
            {
                throw new Exception("Check phone again,something wrong");
            }

            else
            {
                PhoneNumber = CheckPhoneNumberConvert(PhoneNumber);

                if (PhoneNumber.Length != 10)
                {
                    throw new Exception("Check phone again,something wrong");
                }
            }

            if (string.IsNullOrEmpty(UserName))
            {
                throw new Exception("User name is empty");
            }

            if (string.IsNullOrEmpty(Password))
            {
                throw new Exception("Password is empty");
            }
        }

        private string CheckPhoneNumberConvert(string input)
        {
            var checkInput = input.StartsWith("0") || input.StartsWith("84");
            if (checkInput)
            {
                if (input.StartsWith("84"))
                {
                    input = "0" + input.Substring(2);
                }
                var filter = decimal.TryParse(input, out var number);
                if (filter && input.Length == 10)
                {
                    return input;
                }
            }
            return null;
        }

        private bool CheckEmailConvert(string input)
        {
            string[] subs = input.Split("@");
            if (subs.Length > 2)
            {
                throw new Exception("Check email again");
            }
            var filter = subs[1].Equals("gmail.com");
            return filter;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(FullName))
            {
                yield return new ValidationResult("Full name is empty", new[] { nameof(FullName) });
            }
        }
    }
}
