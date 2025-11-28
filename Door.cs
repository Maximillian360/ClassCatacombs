namespace ClassCatacombs;

public class Door (DoorState state = DoorState.Open, string passCode = "1111")
{
    public DoorState State {get; private set;} = state;
    public string PassCode {get; private set;} = passCode;
    
    public void Open()
    {
        if (State == DoorState.Open)
        {
            Console.WriteLine("Door is open");
        }
        else if (State == DoorState.Locked)
        {
            Console.WriteLine("Door is locked");
        }
        else
        {
            State = DoorState.Open;
            Console.WriteLine("Door is successfully opened");
        }
        
    }

    public void Close()
    {
        if (State == DoorState.Closed || State == DoorState.Locked)
        {
            Console.WriteLine("Door is already closed");
        }
        else
        {
            State = DoorState.Closed;
            Console.WriteLine("Door is successfully closed");
        }
        
    }

    public void Lock()
    {
        if (State == DoorState.Locked)
        {
            Console.WriteLine("Door is already locked");
        }

        else if (State == DoorState.Open)
        {
            Console.WriteLine("Door is opened");
        }
        else
        {
            State = DoorState.Locked;
            Console.WriteLine("Door is successfully locked");
        }
        
    }

    public void Unlock(string passCode)
    {
        if (State != DoorState.Locked || State == DoorState.Open)
        {
            Console.WriteLine("Door is open");
        }
        else if (PassCode != passCode)
        {
            Console.WriteLine("Invalid passcode!");
        }
        else
        {
            State = DoorState.Closed;
            Console.WriteLine("Door is successfully unlocked");
        }
    }

    public void NewPass(string oldPassInput, string newPassCode)
    {
        if (oldPassInput == PassCode)
        {
            PassCode = newPassCode;
            Console.WriteLine("Passcode changed");
        }
        else
        {
            Console.WriteLine("Old passcode does not match old passcode");
        }
    }
    
}

public enum DoorState
{
    Open,
    Closed,
    Locked
}