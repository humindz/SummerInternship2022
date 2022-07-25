namespace HumindZ.SummerInternship2022.Business
{
    using System;

    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
    }
}
