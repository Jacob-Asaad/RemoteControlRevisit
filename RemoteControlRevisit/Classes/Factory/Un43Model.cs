

using System;
public class Un43Model : IScreenFactory
{
    public string ModelName { get; set; }
    public string ModelNumber { get; set; }
    public bool Settings { get; set; }
    public int Volume { get; set; }
    public int Channel { get; set; }
    public int PreviousChannel { get; set; }
    public bool PowerOn { get; set; }
    public bool SmartMenu { get; set; }
    public bool Mute { get; set; }
    public string Source { get; set; }
    public long UpcNum { get; set; }
    public string OrderCode { get; set; }
    public Un43Model()
    {
        ModelName = "UN43";
        UpcNum = 887276400037;
        OrderCode = "UN43TU7000FXZA";
        ModelNumber = "UN43TU7000";
        Settings = false;
        Volume = 1;
        Channel = 1;
        PreviousChannel = Channel;
        PowerOn = false;
        SmartMenu = false;
        Mute = false;
        Source = "";


    }

    /*
         orderCode = "UN43TU7000FXZA ";
        upcNum = 887276400037;
        modelNumber = "UN43TU7000";
    */



    public void Build(string modelNumber)
    {
        throw new NotImplementedException();
    }

    public override void SettingsCommand()
    {
        Console.Clear();
        Console.WriteLine("=====Current Information====");
        Console.WriteLine("Model #: " + this.modelNumber);
        Console.WriteLine("UPC #: " + this.upcNum);
        Console.WriteLine("Order Code: " + this.orderCode);
        Console.WriteLine("Current Volume: " + this.volume);
        Console.WriteLine("Current Channel: " + this.channel);
        Console.WriteLine("Power State: " + this.powerOn);
        Console.WriteLine("Mute State: " + this.mute);
        Console.WriteLine("Smart Menu State: " + this.smartMenu);
        Console.WriteLine("Current Source: " + this.source);
        Console.WriteLine("============================\n");

    }

}