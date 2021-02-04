using System.Collections.Generic;
using InstaDev_G1_DT.Models;

namespace InstaDev_G1_DT.Interfaces
{
    public interface IPublication
    {
        void Create(Publication p);
        List<Publication> ReadAllItens();
        void Update(Publication p);
        void Delete(int Id);
        void curtir( int Likes, int contador);
    }
}