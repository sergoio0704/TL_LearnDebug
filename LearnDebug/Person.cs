namespace LearnDebug
{
    public class Person
    {
        public Person( int id, string name, int age )
        {
            Validate( id, name, age );

            Id = id;
            Name = name;
            Age = age;
        }

        public int Id { get; init; }
        public string Name { get; init; }
        public int Age { get; init; }

        public string GetInfo()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }

        private void Validate( int id, string name, int age )
        {
            if ( id <= 0 )
            {
                throw new ArgumentException( $"'{nameof(id)}' must be greater than 0, current value: {id}" );
            }

            if ( String.IsNullOrEmpty( name ) )
            {
                throw new ArgumentException( $"'{nameof(name)}' must not be empty or null" );
            }

            if ( age < 0 || age > 130 )
            {
                throw new ArgumentException( $"'{nameof( age )}' must be between 0 and 150, current value: {age}" );
            }
        }
    }
}
