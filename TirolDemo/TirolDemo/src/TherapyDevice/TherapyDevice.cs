namespace TherapyDemo
{
    /// <summary>
    /// This class provides basic functionalities every Tirol therapy device provides
    /// </summary>
    public abstract class TherapyDevice
    {
        // Properties
        protected string _SerialNumber { get; private set; }
        protected string _DeviceName { get; private set; }
        protected string _Model { get; private set; }
        protected string _FirmwareVersion { get; private set; }
        protected string _Status { get; private set; }
        protected TirolSoftware _TirolSoftware{ get; set; }
        protected CommunicationModule _Communication{ get; set; }     

        // Constructor
        public TherapyDevice(string serialNumber, string deviceName, string model, string firmwareVersion)
        {
            _TirolSoftware      = TirolSoftware.GetInstance(); 
            _SerialNumber       = serialNumber;
            _DeviceName         = deviceName;
            _Model              = model;
            _FirmwareVersion    = firmwareVersion;
            _Status             = "Idle";
        }

        // Abstract methods
        public abstract void StartTherapie();
        public abstract void StopTherapie();
    }
}