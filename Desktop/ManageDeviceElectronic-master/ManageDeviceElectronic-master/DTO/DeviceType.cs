
namespace DTO
{
    public class DeviceType
    {
        public int TypeID { get; set; }
        public string Name { get; set; }
        public string DefaultImage { get; set; }
        public DeviceType(int typeID, string name, string defaultImage)
        {
            TypeID = typeID;
            Name = name;
            DefaultImage = defaultImage;
        }
        public DeviceType(string name, string defaultImage)
        {
            Name = name;
            DefaultImage = defaultImage;
        }
        public DeviceType(string defaultImage)
        {
            DefaultImage = defaultImage;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
