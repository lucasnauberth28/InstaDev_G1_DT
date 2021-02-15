using System.Collections.Generic;
using InstaDev_G1_DT.Models;

namespace InstaDev_G1_DT.Interfaces
{
    public interface IUser
    {
        // CRUD
        void Create(User newUser);
        List<User> ReadAllItems();
        void Update();
        void Delete();
    }
}