using System;
namespace BlazorApp.Data
{
    [Serializable]
    public class Profile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

    }
}

