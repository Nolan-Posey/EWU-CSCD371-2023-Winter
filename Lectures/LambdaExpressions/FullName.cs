using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Reflection.Metadata.Ecma335;

namespace LambdaExpressions;
public record FullName(string FirstName, string LastName)
{
    public FullName(string fullName) : this(null!, null!)
    {

        if (fullName.Split(" ") is [string {Length: > 0 } firstName, string { Length: > 0 } lastName]) 
        {
            FirstName = firstName; 
            LastName = lastName;
        }
    }

    public string Initials 
    {
        get 
        {
            string initials;
            //return $"{FirstName[0]}{LastName[0]}";
            //return initials;
            if ((FirstName.First(), LastName.First()) is (char firstInitial, char lastInitial))
            {
                initials = new string(new char[] { firstInitial, lastInitial });
            }
            return initials;
        }
    }

}
