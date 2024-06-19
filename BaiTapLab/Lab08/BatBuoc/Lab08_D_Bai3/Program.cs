using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Profile
            Profile myProfile = new Profile("John Doe", "johndoe@example.com", "0123456789", 30, 50000000, "john_doe_2021", "Password123!!");

            // Validators
            NotEmptyValidator notEmptyValidator = new NotEmptyValidator();
            RangeValidator ageValidator = new RangeValidator(15, 55);
            RangeValidator salaryValidator = new RangeValidator(1000000, 100000000);
            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator = new PasswordValidator(3, 3, 2);
            LengthValidator usernameValidator = new LengthValidator(10, int.MaxValue);
            LengthValidator fullNameValidator = new LengthValidator(15, 30);

            // Validation
            Console.WriteLine("FullName Valid: " + (notEmptyValidator.Validate(myProfile.FullName) && fullNameValidator.Validate(myProfile.FullName)));
            Console.WriteLine("Email Valid: " + emailValidator.Validate(myProfile.Email));
            Console.WriteLine("Phone Valid: " + notEmptyValidator.Validate(myProfile.Phone));
            Console.WriteLine("Age Valid: " + ageValidator.Validate(myProfile.Age));
            Console.WriteLine("Salary Valid: " + salaryValidator.Validate(myProfile.Salary));
            Console.WriteLine("UserName Valid: " + (notEmptyValidator.Validate(myProfile.UserName) && usernameValidator.Validate(myProfile.UserName)));
            Console.WriteLine("Password Valid: " + passwordValidator.Validate(myProfile.Password));

            Console.ReadKey();
        }
    }
}
