using ProductDAL.Repost;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBLL.Services
{
    public class SizeScaleServices
    {
        ISizeScaleRepost _ISizeScaleRepost;

        public SizeScaleServices(ISizeScaleRepost ISizeScaleRepost)
        {
            _ISizeScaleRepost = ISizeScaleRepost;
        }
        public void AddSizeScale(SizeScale SizeScale)
        {
            _ISizeScaleRepost.AddSizeScale(SizeScale);
        }
        public void UpdateSizeScale(SizeScale SizeScale)
        {
            _ISizeScaleRepost.UpdateSizeScale(SizeScale);
        }
        public void DeleteSizeScale(int Id)
        {
            _ISizeScaleRepost.RemoveSizeScale(Id);
        }
        public SizeScale GeSizeScaleById(int id)
        {
            return _ISizeScaleRepost.GetSizeScale(id);
        }
        public IEnumerable<SizeScale> GetAll()
        {
            return _ISizeScaleRepost.GetSizeScaleList();
        }
    }
}
