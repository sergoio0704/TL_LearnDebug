// F5 - Переход к следующей указанной точке останова
// F10 - Шаг с обходом
// F11 - Шаг с заходом внутрь
// SHIFT + F11 - Выход из метода

#region Debug

class Program
{
    public static void Main( string[] args )
    {
        string value = "Hello world";
        string reverseValue = Reverse( value );

        Console.WriteLine( reverseValue );
    }

    public static string Reverse( string value )
    {
        string reverseValue = String.Empty;
        for ( int i = value.Length - 1; i >= 0; i-- )
        {
            reverseValue += value[i];
        }

        return reverseValue;
    }
}

#endregion

#region Debug object
//using LearnDebug;

//class Program
//{
//    public static void Main( string[] args )
//    {
//        List<Person> persons = new List<Person>
//        {
//            new Person( 1, "Jason", 20),
//            new Person( 2, "Oleg", 30),
//            new Person( 3, "Gleb", 40),
//            new Person( 4, "Alexander", 22),
//            new Person( 5, "Alex", 13)
//        };

//        Person person = FindPersonWithMaxAge( persons );
//        Console.WriteLine( "Person with max age: " + person.GetInfo() );

//        Person person1 = FindPersonByName( persons, "Oleg" );
//        Console.WriteLine( "Person: " + person1.GetInfo() );
//    }

//    public static Person FindPersonWithMaxAge( List<Person> persons )
//    {
//        Person personWithMaxAge = persons.First();
//        foreach ( Person person in persons )
//        {
//            if ( person.Age > personWithMaxAge.Age )
//            {
//                personWithMaxAge = person;
//            }
//        }

//        return personWithMaxAge;
//    }

//    public static Person FindPersonByName( List<Person> persons, string name )
//    {
//        foreach ( Person person in persons )
//        {
//            if ( person.Name == name )
//            {
//                return person;
//            }
//        }

//        return null;
//    }
//}
#endregion

#region Exceptions
//using LearnDebug;
//using LearnDebug.Exceptions;

//class Program
//{
//    public static void Main( string[] args )
//    {
//        List<Person> persons = new List<Person>
//        {
//            new Person( 1, "Jason", 20),
//            new Person( 2, "Oleg", 30),
//            new Person( 3, "Gleb", 40),
//            new Person( 4, "Alexander", 22),
//            new Person( 5, "Alex", 13)
//        };

//        try
//        {
//            Person person2 = FindPersonByName( persons, "Vasya" );
//        }
//        catch ( NotFoundPersonException ex )
//        {
//            Console.WriteLine( ex.Message );
//        }
//        catch ( PersonException ex )
//        {
//            Console.WriteLine( ex.Message );
//        }
//        catch ( Exception ex )
//        {
//            Console.WriteLine( ex.Message );
//        }
//    }

//    public static Person FindPersonWithMaxAge( List<Person> persons )
//    {
//        Person personWithMaxAge = persons.First();
//        foreach ( Person person in persons )
//        {
//            if ( person.Age > personWithMaxAge.Age )
//            {
//                personWithMaxAge = person;
//            }
//        }

//        return personWithMaxAge;
//    }

//    public static Person FindPersonByName( List<Person> persons, string name )
//    {
//        if ( persons == null )
//        {
//            throw new ArgumentNullException( "Persons is null" );
//        }

//        foreach ( Person person in persons )
//        {
//            if ( person.Name == name )
//            {
//                return person;
//            }
//        }

//        throw new NotFoundPersonException( $"Person with name {name} not found" );
//        //throw new NotFoundPersonException( typeof( Person ), name );
//    }
//}
#endregion
