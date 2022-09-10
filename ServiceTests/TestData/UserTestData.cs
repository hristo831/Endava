namespace ServiceTests.TestData
{
    public static class UserTestData
    {
        //page data
        public const int Page = 1;
        public const int PerPage = 6;
        public const int Total = 12;
        public const int TotalPages = 2;

        // First user data
        public const int FirstUserId = 1;
        public const string FirstUserEmail = "george.bluth@reqres.in";
        public const string FirstUserFirstName = "George";
        public const string FirstUserLastName = "Bluth";
        public const string FirstUserLastAvatar = "https://reqres.in/img/faces/1-image.jpg";

        //support data
        public const string SupportUrl = "https://reqres.in/#support-heading";
        public const string SupportText = "To keep ReqRes free, contributions towards server costs are appreciated!";

        public const int NonExistingUserId = 1000;

        //New User
        public const string Name = "Hristo";
        public const string Job = "QA";
    }
}
