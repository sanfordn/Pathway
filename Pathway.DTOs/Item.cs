

namespace Pathway.DTOs
{
    public class Item
    {
        public Item(string _serialNumber, string _name)
        {
            SerialNumber = _serialNumber;
            Name = _name;
        }

        public string SerialNumber { get; }
        public string Name { get; }
        public string Description { get; set; }
    }
}
