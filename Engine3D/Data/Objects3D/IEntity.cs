using System;
using Engine3D.Data.Shaders;

namespace Engine3D.Data.Objects3D
{
    public interface IEntity : IDisposable
    {
        /// <summary>
        /// Draws with given shader
        /// </summary>
        /// <param name="shader">Draws Entity with given Shader</param>
	    void Draw(IShader shader);
        /// <summary>
        /// Draws with default shader
        /// </summary>
	    void Draw();
    }
}
