using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductDAL.Repost
{
    public class ColourRepost:IColourRepost
    {
        ProductDB _db;
        public ColourRepost(ProductDB db)
        {
            _db = db;
        }
        public void AddColour(Colour Colour)
        {
            _db.colours.Add(Colour);
            _db.SaveChanges();
        }
        public void RemoveColour(int ColourId)
        {
            var theater = _db.colours.Find(ColourId);
            _db.colours.Remove(theater);
            _db.SaveChanges();
        }
        public Colour GetColour(int ColourId)
        {
            return _db.colours.Find(ColourId);
        }
        public IEnumerable<Colour> GetColourList()
        {
            return _db.colours.ToList();
        }
        public void UpdateColour(Colour Colour)
        {
            _db.Entry(Colour).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
