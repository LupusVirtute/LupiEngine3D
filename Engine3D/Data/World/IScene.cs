using System;
using Engine3D.Data.Objects3D;
using Engine3D.Data.Shaders;

namespace Engine3D.Data.World
{
    public interface IScene : IDisposable
    {
	    bool AddEntityToScene(IEntity entity);
	    bool RemoveEntityByReference(IEntity entity);
	    void Render(IShader shader);
	    void Render();
    }
}
