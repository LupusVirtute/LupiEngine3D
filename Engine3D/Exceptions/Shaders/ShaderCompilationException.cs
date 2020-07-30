using System;

namespace Engine3D.Exceptions.Shaders
{
	public class ShaderCompilationException : Exception
	{
		public ShaderCompilationException(String errorMessage) : base(errorMessage)
		{
		}
	}
}