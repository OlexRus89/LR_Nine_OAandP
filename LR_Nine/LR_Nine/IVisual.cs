using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Nine
{
    public interface IVisual
    {
        string Name { get; set; }
        string Model { get; set; }
        void DrawObject();
    }
}