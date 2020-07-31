using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL4;

namespace Engine3D.Data.Objects3D
{
    public enum ObjectDrawingInfo
    {
        Static = BufferUsageHint.StaticDraw,
        Dynamic = BufferUsageHint.DynamicDraw,
        Stream = BufferUsageHint.StreamDraw,
    }
}
