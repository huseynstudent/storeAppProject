namespace StoreAppProject.Exceptions;

public class InvalidInputFormatException : Exception
{
    public InvalidInputFormatException() : base("The price cannot be negative") { }

}
