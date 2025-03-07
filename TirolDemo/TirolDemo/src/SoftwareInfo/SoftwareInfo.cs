namespace TherapyDemo
{
    // 
    /// <summary>
    /// This class holds all basic information about the TirolSoftware
    /// </summary>
    public class SoftwareInfo
    {
        // Properties
        public string _Name { get; private set; }
        public string _Version { get; private set; }
        public DateTime _ReleaseDate { get; private set; }
        public string _Description { get; private set; }
        public string _License { get; private set; }

        // Constructor
        public SoftwareInfo(string name, string version, DateTime releaseDate, string description, string license)
        {
            _Name        = name;
            _Version     = version;
            _ReleaseDate = releaseDate;
            _Description = description;
            _License     = license;
        }

        // Method that gives all information about the Tirol Software
        public string GetFullInfo()
        {
            return $"Name: {_Name}\nVersion: {_Version}\nRelease Date: {_ReleaseDate.ToShortDateString()}\nDescription: {_Description}\nLicense: {_License}";
        }
    }
}



