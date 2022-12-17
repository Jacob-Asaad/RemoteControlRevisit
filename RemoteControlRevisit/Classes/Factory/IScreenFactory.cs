public interface IScreenFactory
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
    public void Build(string modelNumber);
}

