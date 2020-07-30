using System;

namespace Engine3D.Data.Shaders
{
	public interface IShader : IDisposable
	{
		int ID { get; }
		void Use();
#if DEBUG
		void ReCompileShaders(String verShaderPath, String fragShaderPath);
#endif
	}
}