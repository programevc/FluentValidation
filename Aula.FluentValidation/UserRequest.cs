using System;

namespace Aula.FluentValidation
{
    public class UserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
