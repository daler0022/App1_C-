using System;
using System.ComponentModel.DataAnnotations;

namespace App1
{
    [PersonName("Daler", "Olimov", 19)]
    class Person
    {
    [Required(ErrorMessage = "Не указано имя пользователя")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Значение этого поля не должно быть больше {1} символо и быть меньше {2} символов")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Не указано фамилия пользователя")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Значение этого поля не должно быть больше {1} символо и быть меньше {2} символов")]
    public string Surname { get; set; }

    [Required(ErrorMessage = "Не указано возраст пользователя")]
    [Range(1, 100, ErrorMessage = "Возраст не может быть меньше {1} или больше {2}")]
    public int Age { get; set; }

    public Person (string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    public string Print()
        {
            return ($"Имя: {Name}, Фамилия: {Surname}, Возраст: {Age}");
        }
    }

    public class PersonNameAttribute : ValidationAttribute
    {
        string invalidName { get; set; }
        string invalidSurname { get; set; }
        int invalidAge { get; set; }
        public PersonNameAttribute(string name, string surname, int age)
        {
            invalidName = name;
            invalidSurname = surname;
            invalidAge = age;
        }
        public override bool IsValid(object? value)
        {
            if(value is Person person)
            {
                if (person.Name == invalidName && person.Surname == invalidSurname && person.Age == invalidAge)
                {
                    Console.WriteLine("Доступ есть");
                    return true;
                }
                else
                    ErrorMessage = "Некорректные данные";
            }
            return false;
        }
    }
}
