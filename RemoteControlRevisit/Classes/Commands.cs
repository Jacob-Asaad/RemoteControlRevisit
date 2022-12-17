public interface ITvCommand
{
    public void Execute(ISystem system);
}
public interface ISystem
{

    public int State
    {
        get;
        set;
    }
}
/*-----------------------------------------------------------------------------------------------*/
public class ChannelSystem : ISystem

{
    int channel = 1;
    ITvCommand channelUP = new ChannelUp();
    ITvCommand channelDown = new ChannelDown();

    public int State { get { return channel; } set { channel = value; } }

}
public class ChannelUp : ITvCommand
{

    public void Execute(ISystem system)
    {
        {
            system.State++;
        }
    }
}
public class ChannelDown : ITvCommand
{

    public void Execute(ISystem system)
    {
        {
            system.State--;
        }
    }
}
/*-----------------------------------------------------------------------------------------------*/
public class VolumeSystem : ISystem
{

    int volume = 1;

    ITvCommand volumeUp = new VolumeUp();
    ITvCommand volumelDown = new VolumeDown();
    public int State { get { return volume; } set { volume = value; } }

}
public class VolumeDown : ITvCommand
{
    public void Execute(ISystem system)
    {
        {
            system.State--;
        }
    }
}
public class VolumeUp : ITvCommand
{
    public void Execute(ISystem system)
    {
        {
            system.State++;
        }
    }
}
/*-----------------------------------------------------------------------------------------------*/
public class PowerSystem : ISystem
{
    int powerOn = 0;
    ITvCommand powerStatus = new PowerCommand();
    public int State { get { return powerOn; } set { powerOn = value; } }
}
public class PowerCommand : ITvCommand
{
    public void Execute(ISystem system)
    {
        if (system.State = 1)
        {

            //--system.State();
            // system.DisplayScreen("Power: Off");
            Console.Clear();
            // system.DisplayScreen("");
        }
        else
        {
            //system.DisplayScreen("Power: On");
            Console.Clear();
            //system.DisplayScreen("");
        }
    }
}






