namespace NetworkInfoApi.Models
{
    public class NetworkInterfaceInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public List<string> Addresses { get; set; } = new List<string>();
    }
}