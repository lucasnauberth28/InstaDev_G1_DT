using System.Collections.Generic;
using InstaDev_G1_DT.Models;

namespace InstaDev_G1_DT.Interfaces
{
    public interface IComments
    {
        //CRUD
        void Create(Comments c);
        List<Comments> ReadAllItens();
        void Update(Comments c);
        void Delete(int id);
    }
}