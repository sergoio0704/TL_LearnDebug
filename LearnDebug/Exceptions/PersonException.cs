namespace LearnDebug.Exceptions
{
    public abstract class PersonException : Exception
    {
        protected PersonException( string message ) : base( $"[LearnDebug] {message}" )
        {
            
        }

        protected PersonException( string message, Exception innerException )
            : base( $"[LearnDebug] {message}", innerException )
        {
            
        }
    }
}
