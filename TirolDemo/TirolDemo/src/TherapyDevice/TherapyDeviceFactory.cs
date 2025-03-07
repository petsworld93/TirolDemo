namespace TherapyDemo
{

    // Creates and returns a therapy device which is given by the parameter deviceName 
    public static class TherapyDeviceFactory
    {
        public static TherapyDevice CreateTherapyDevice(string serialNumber, string deviceName, string model, string firmwareVersion)
        {
            switch(deviceName)
            {
                case "Amadeo":
                    return new Amadeo(serialNumber, deviceName, model, firmwareVersion);
                case "Diego":
                    return new Diego(serialNumber, deviceName, model, firmwareVersion);
                case "Lexo":
                    return new Lexo(serialNumber, deviceName, model, firmwareVersion);
                default:
                    // Error handling
                    return null;
            }
        }

    }
}













