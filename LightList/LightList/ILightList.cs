using System;
using System.Collections.Generic;
using System.Text;

namespace LightList
{
    public interface ILightList <TObject>
        where TObject: class
    {
        int Index { get; set; }
        void Add(TObject item);
        int Count();
        void Remove(TObject item);
    }
}
