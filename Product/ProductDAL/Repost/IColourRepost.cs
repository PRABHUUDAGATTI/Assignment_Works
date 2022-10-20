using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAL.Repost
{
    public interface IColourRepost
    {
        void AddColour(Colour Colour);
        Colour GetColour(int Colourid);
        void RemoveColour(int Colourid);
        void UpdateColour(Colour Colour);
        IEnumerable<Colour> GetColourList();

    }
}
