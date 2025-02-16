﻿using Mapping.Domain.Common;

namespace Mapping.Domain.Entities
{
    public class User : BaseItem
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public string Image { get; set; }
    }
}
