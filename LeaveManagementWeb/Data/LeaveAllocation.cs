namespace LeaveManagementWeb.Data
{
    public class LeaveAllocation : BaseObject
    {
        
        public LeaveType LeaveType  { get; set; }
        public int LeaveTypeId  { get; set; }
        public string EmployeeId { get; set; }
        public int NumberOfDays { get; set; }

    }
}
