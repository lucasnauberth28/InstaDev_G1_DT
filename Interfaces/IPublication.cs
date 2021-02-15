using System.Collections.Generic;
using System.ComponentModel;
using InstaDev_G1_DT.Models;

namespace InstaDev_G1_DT.Interfaces
{
    public interface IPublication
    {
        void Create(Publication p);
        List<Publication> ReadAllItens();
        
     void Delete(int Id);
       
    }
}