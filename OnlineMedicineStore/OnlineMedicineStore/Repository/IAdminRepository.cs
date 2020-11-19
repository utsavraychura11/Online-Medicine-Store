using OnlineMedicineStore.Models;
using System.Collections.Generic;
using OnlineMedicineStore.Data;

namespace OnlineMedicineStore.Repository
{
    public interface IAdminRepository
    {
        IEnumerable<ApplicationUser> GetAllUsers();
      //  ApplicationUser DeleteUser(string id);
        //ApplicationUser GetUser(string id);

       // Medicine GetMedicine(int id);
    }
}