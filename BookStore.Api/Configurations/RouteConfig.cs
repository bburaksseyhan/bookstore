namespace BookStore.Api.Configurations
{
    public static class RouteConfig
    {
        private const string Root = "api";

        private const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public const string Ping = Base + "/ping";

        public static class Book
        {
            public const string Controller = "/book/";

            public const string GetAll = Controller + "books";

            public const string Create = Controller + "create";

            public const string Detail = Controller + "detail";

            public const string Delete = Controller + "delete";
        }

        public static class Category
        {
            public const string Controller = "/category/";

            public const string GetAll = Controller + "categories";

            public const string Create = Controller + "create";

            public const string Detail = Controller + "detail";

            public const string Delete = Controller + "delete";
        }

        public static class Company
        {
            public const string Controller = "/company/";

            public const string GetAll = Controller + "companies";

            public const string Create = Controller + "create";

            public const string Detail = Controller + "detail";

            public const string Delete = Controller + "delete";
        }
    }
}
