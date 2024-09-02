using StaffAPI.Models;

namespace StaffAPI.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        List<Staff> _staffs=new List<Staff>();
        public void AddStaff(Staff staff)
        {
           _staffs.Add(staff);
        }

        public void DeleteStaff(string staffId)
        {
            Staff staff=_staffs.SingleOrDefault(s=>s.SfaffId==staffId);
            _staffs.Remove(staff);
        }

        public List<Staff> GetAll()
        {
            return _staffs;
        }

        public Staff GetStaff(string staffId)
        {
            return _staffs.SingleOrDefault(s => s.SfaffId == staffId);
        }

        public List<Staff> GetStaffByStd(string std)
        {
            // List<Staff> staffswithStd = new List<Staff>();
            //foreach(var staff in _staffs)
            // {
            //     foreach(var s in staff.stds)
            //     {
            //         if(s==std)
            //         {
            //             staffswithStd.Add(staff);
            //         }
            //     }
            // }
            // return staffswithStd;
            List<Staff> staffswithStd = (from s in _staffs
                                         where s.stds.Contains(std)
                                         select s).ToList();
            return staffswithStd;
        }

        public List<Staff> GetStaffBySubject(string subject)
        {
            List<Staff> staffswithSubject = new List<Staff>();
            foreach (var staff in _staffs)
            {
                foreach (var s in staff.Subjects)
                {
                    if (s == subject)
                    {
                        staffswithSubject.Add(staff);
                    }
                }
            }
            return staffswithSubject;
        }

        public void UpdateStaff(Staff staff)
        {
            foreach(var s in _staffs)
            {
                if(s.SfaffId==staff.SfaffId)
                {
                    s.Name = staff.Name;
                    s.Subjects = staff.Subjects;
                }
            }
        }
    }
}
