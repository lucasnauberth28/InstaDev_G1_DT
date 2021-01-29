using System.Collections.Generic;
using InstaDev_G1_DT.Models;

namespace InstaDev_G1_DT.Interfaces
{
    public interface IPageRegister
    {
        // CRUD
        void Create(PageRegister newRegister);
        List<PageRegister> ReadAllItems();
        void Update();
        void Delete();
    }
}