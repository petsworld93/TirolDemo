namespace TherapyDemo
{
    public class Diego : TherapyDevice
    {
        public Diego(string serialNumber, string deviceName, string model, string firmwareVersion) : base(serialNumber, deviceName, model, firmwareVersion) { }
        
        public override void StartTherapie()
        {
            // Implementierung der Therapie für Diego
            Console.WriteLine("Diego Therapie gestartet.");
        }

        public override void StopTherapie()
        {
            // Implementierung der Therapie für Diego
            Console.WriteLine("Diego Therapie gestoppt.");
        }
    }
}




