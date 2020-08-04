using System;
using OpenTK.Input;

namespace Engine3D.Managers.Render
{
	public interface IRenderer : IDisposable
	{
		void Render(object sender, KeyboardKeyEventArgs arg);
	}
}