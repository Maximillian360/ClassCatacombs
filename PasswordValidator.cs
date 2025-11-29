namespace ClassCatacombs;

public class PasswordValidator
{
    public string Password {get; private set;}
    public bool HasUpperCase {get; private set;}
    public bool HasLowerCase {get; private set;}
    public bool HasDigits {get; private set;}
    private bool _validLength;

    public bool ValidLength
    {
        get => _validLength; 
        set
        {
            if (Password.Length >= 6 && Password.Length <= 13)
            {
                _validLength = true;
            }
            else
            {
                _validLength = false;
            }
        }
    }

    public PasswordValidator(string password)
    {
        Password = password;
        HasUpperCase = false;
        HasLowerCase = false;
        HasDigits = false;
        ValidLength = false;
    }

    public void PasswordValidation()
    {
        Console.WriteLine($"Length: {Password.Length},  ValidLength: {ValidLength}");
        HasUpperCase = HasLowerCase = HasDigits = false;
        if (ValidLength)
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
        }
        else
        {
            Console.WriteLine("Password needs to be at least 6 characters, and not more than 13 characters long.");
        }
        
        if (HasUpperCase &&  HasLowerCase && HasDigits) Console.WriteLine("Password is valid");
        else Console.WriteLine("Password is invalid");
    }
}