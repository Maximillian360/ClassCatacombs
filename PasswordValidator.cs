namespace ClassCatacombs;

public class PasswordValidator (string password)
{
    public string Password {get; private set;} = password;
    public bool HasUpperCase {get; private set;} = false;
    public bool HasLowerCase {get; private set;} = false;
    public bool HasDigits {get; private set;} = false;

    public void PasswordValidation()
    {
        foreach (char c in Password)
        {
            if (char.IsUpper(c))
            {
                HasUpperCase = true;
            }
            else if (char.IsLower(c))
            {
                HasLowerCase = true;
            }
            else if (char.IsDigit(c))
            {
                HasDigits = true;
            }
        }
        if (HasUpperCase &&  HasLowerCase && HasDigits) Console.WriteLine("Password is valid");
        else Console.WriteLine("Password is invalid");
    }
}