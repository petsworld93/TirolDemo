namespace TherapyDemo
{
    public class Lexo : TherapyDevice
    {
        public Lexo(string serialNumber, string deviceName, string model, string firmwareVersion) : base(serialNumber, deviceName, model, firmwareVersion) { }
        
        public override void StartTherapie()
        {
            // Implementierung der Therapie für Lexo
            Console.WriteLine("Lexo Therapie gestartet.");
        }

        public override void StopTherapie()
        {
            // Implementierung der Therapie für Lexo
            Console.WriteLine("Lexo Therapie gestoppt.");
        }
    }
}




