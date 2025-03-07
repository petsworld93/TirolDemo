namespace TherapyDemo
{
    /// <summary>
    /// This class handles the therapy devices which are controlled by the Software and is 
    /// implemented as a singleton.
    /// </summary>
    /// <remarks>
    /// Defined as 'sealed' class to prevent inheritance.
    /// </remarks>
    public sealed class TirolSoftware
    {
        // Properties
        private static TirolSoftware? _Instance;     // contains the instance of the TirolSoftware which is a singleton, allow nullable
        private SoftwareInfo _SoftwareInfo;         // contains relevant info about the software running on the device
        private List<TherapyDevice> _TherapyDevices { get; set; }   // contains all devices which are controlled by the software

        // Constructor
        public TirolSoftware() 
        { 
            _TherapyDevices = new List<TherapyDevice>();                            // empty list

            _SoftwareInfo = new SoftwareInfo("TirolSoftware",                       // name
            "0.1",                                                                  // version
            new DateTime(2025, 3, 7, 13, 00, 0),                                    // March 7, 2025, 1:00 PM, 
            "Handles the therapy devices which are controlled by the Software",     // description
            "Test");                                                                // license
        }
        
        // Method that controls the access to the singleton TirolSoftware instance. 
        // Creates an instance at the first call and stores it in _Instance.
        public static TirolSoftware GetInstance()
        {
            if (_Instance == null)
            {
                // Store the TirolSoftware instance in static field. 
                _Instance = new TirolSoftware();
            }
            return _Instance;
        }

        // Creates device which is given by the parameter deviceName and adds it to list _TherapyDevices
        public void AddDevice(string serialNumber, string deviceName, string model, string firmwareVersion)
        {
            _TherapyDevices.Add(TherapyDeviceFactory.CreateTherapyDevice(serialNumber, deviceName, model, firmwareVersion));
        }
    }
}
