using System.Collections.Generic;
using InstaDev_G1_DT.Models;

namespace InstaDev_G1_DT.Interfaces
{
    public interface IComments
    {
        // CRUD
        void Create(Comments newComment);
        List<Comments> ReadAllItems();
        void Update();
        void Delete(int id);
    }
}