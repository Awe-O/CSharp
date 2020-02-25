using System;
using System.Collections.Generic;
using System.Text;

namespace LightListProject
{
    public interface ILightList<TObject> : IEnumerable<TObject>
        where TObject: class
    {
        int Index { get; set; }
        void Add(TObject item);
        int Count();
        void Remove(TObject item);
    }
}
