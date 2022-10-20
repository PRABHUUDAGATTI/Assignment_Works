using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAL.Repost
{
    public interface ISizeScaleRepost
    {
        void AddSizeScale(SizeScale sizeScale);
        SizeScale GetSizeScale(int sizescaleid);
        void RemoveSizeScale(int sizescaleid);
        void UpdateSizeScale(SizeScale sizeScale);
        IEnumerable<SizeScale> GetSizeScaleList();

    }
}
