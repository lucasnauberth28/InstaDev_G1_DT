using System.Collections.Generic;
using InstaDev_G1_DT.Models;

namespace InstaDev_G1_DT.Interfaces
{
    public interface IPublication
    {
        // CRUD
        void Create(Publication newPub);
        List<Publication> ReadAllItens();
        void Update();
        void Delete(int id);
    }
}