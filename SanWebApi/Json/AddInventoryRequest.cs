namespace SanWebApi.Json
{
    public class AddInventoryItemRequest
    {
        public string licensor_pid { get; set; }
        public string compat_version { get; set; }
        public string licensor_label { get; set; }
        public string licensee_label { get; set; }
        public int origin { get; set; }
        public int state { get; set; }
        public InventoryResponse.Revision[] revisions { get; set; }
    }
}
