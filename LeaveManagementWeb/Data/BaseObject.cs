namespace LeaveManagementWeb.Data
{
    //abstract so that it cannot be instantiated
    public abstract class BaseObject
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
