namespace LearnDebug.Exceptions
{
    public class NotFoundPersonException : PersonException
    {
        public NotFoundPersonException( string message ) : base( $"Not found: {message}" )
        {
        }

        public NotFoundPersonException( Type type, object entityKey )
            : base( $"Not found: {type.Name}#{entityKey}" )
        { 
        }
    }
}
