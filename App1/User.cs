using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace App1
{

    public class User : IValidatableObject
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(Name))
                errors.Add(new ValidationResult("Не указано имя"));

            if (Name.Length < 2 || Name.Length > 20)
                errors.Add(new ValidationResult("Некорректная длина имени"));

            if (this.Age < 1 || this.Age > 100)
                errors.Add(new ValidationResult("Недопустимый возраст"));

            return errors;
        }
    }

}
