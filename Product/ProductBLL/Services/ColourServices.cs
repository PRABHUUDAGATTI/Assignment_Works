using ProductDAL.Repost;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBLL.Services
{
    public class ColourServices
    {
        IColourRepost _IColourRepost;

        public ColourServices(IColourRepost IColourRepost)
        {
            _IColourRepost = IColourRepost;
        }
        public void AddColour(Colour Colour)
        {
            _IColourRepost.AddColour(Colour);
        }
        public void UpdateColour(Colour Colour)
        {
            _IColourRepost.UpdateColour(Colour);
        }
        public void DeleteColour(int Id)
        {
            _IColourRepost.RemoveColour(Id);
        }
        public Colour GeColourById(int id)
        {
            return _IColourRepost.GetColour(id);
        }
        public IEnumerable<Colour> GetAll()
        {
            return _IColourRepost.GetColourList();
        }
    }
}
