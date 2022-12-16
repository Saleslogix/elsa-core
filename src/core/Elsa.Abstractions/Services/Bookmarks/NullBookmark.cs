namespace Elsa.Services
{
    public class NullBookmark : IBookmark
    {
        public static readonly IBookmark Instance = new NullBookmark();

        public bool? Compare(IBookmark bookmark)
        {
            return null;
        }
    }
}