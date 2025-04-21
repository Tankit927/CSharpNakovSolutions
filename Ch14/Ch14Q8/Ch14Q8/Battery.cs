public class Battery
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    private BatteryType _model = BatteryType.LiIon;
    private uint _idleTime = 0;
    private uint _talkingTime = 0;

    public BatteryType Model {get => _model; set => _model = value;}
    public uint IdleTime {get => _idleTime; set => _idleTime = value;}
    public uint TalkingTime {get => _talkingTime; set => _talkingTime = value;}

    public Battery(BatteryType model, uint idleTime, uint talkingTime)
    {
        Model = model;
        IdleTime = idleTime;
        TalkingTime = talkingTime;
    }

    public Battery(BatteryType model, uint idleTime) : this(model, idleTime, 0)
    {
    }

    public Battery(BatteryType model) : this(model, 0, 0)
    {
    }

    public Battery() : this(BatteryType.LiIon, 0, 0)
    {
    }
}