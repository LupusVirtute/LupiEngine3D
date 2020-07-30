using System;

namespace Engine3D.Managers.Render
{
	public interface IRenderer : IDisposable
	{
		void Render();
	}
}