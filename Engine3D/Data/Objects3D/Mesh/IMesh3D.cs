using System;
using Engine3D.Data.Shaders;

namespace Engine3D.Data.Objects3D.Mesh
{
	public interface IMesh3D : IDisposable
	{
		void Draw(IShader shader);
		void Draw();
	}
}