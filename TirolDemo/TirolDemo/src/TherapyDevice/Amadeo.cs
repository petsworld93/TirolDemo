namespace TherapyDemo
{
    public class Amadeo : TherapyDevice
    {
        public Amadeo(string serialNumber, string deviceName, string model, string firmwareVersion) : base(serialNumber, deviceName, model, firmwareVersion) { }
        
        public override void StartTherapie()
        {
            // Implementierung der Therapie für Amadeo
            Console.WriteLine("Amadeo Therapie gestartet.");
        }

        public override void StopTherapie()
        {
            // Implementierung der Therapie für Amadeo
            Console.WriteLine("Amadeo Therapie gestoppt.");
        }
    }
}




