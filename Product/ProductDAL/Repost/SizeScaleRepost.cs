using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductDAL.Repost
{
    public class SizeScaleRepost:ISizeScaleRepost
    {
        ProductDB _db;
        public SizeScaleRepost(ProductDB db)
        {
            _db = db;
        }
        public void AddSizeScale(SizeScale sizeScale)
        {
            _db.sizeScales.Add(sizeScale);
            _db.SaveChanges();
        }
        public void RemoveSizeScale(int SizeScaleId)
        {
            var theater = _db.sizeScales.Find(SizeScaleId);
            _db.sizeScales.Remove(theater);
            _db.SaveChanges();
        }
        public SizeScale GetSizeScale(int SizeScaleId)
        {
            return _db.sizeScales.Find(SizeScaleId);
        }
        public IEnumerable<SizeScale> GetSizeScaleList()
        {
            return _db.sizeScales.ToList();
        }
        public void UpdateSizeScale(SizeScale sizeScale)
        {
            _db.Entry(sizeScale).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
