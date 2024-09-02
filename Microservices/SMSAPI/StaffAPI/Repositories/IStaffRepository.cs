using StaffAPI.Models;

namespace StaffAPI.Repositories
{
    public interface IStaffRepository
    {
        void AddStaff(Staff staff);
        void UpdateStaff(Staff staff);
        void DeleteStaff(string staffId);
        List<Staff> GetAll();
        List<Staff> GetStaffByStd(string std);
        List<Staff> GetStaffBySubject(string subject);
        Staff GetStaff(string staffId);
    }
}
