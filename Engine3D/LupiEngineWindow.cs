using System;
using Engine3D.Loading;
using Engine3D.Managers.Inputs;
using Engine3D.Managers.Render;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Input;

namespace Engine3D
{
	public class LupiEngineWindow : OpenTK.GameWindow
	{
		private IRenderer renderManager;
		private IKeyboardManager keyboardManager;
		private ILoader loader;
		public LupiEngineWindow(IRenderer renderManager,IKeyboardManager keyboardManager,ILoader loader,string title, OpenTK.GameWindowFlags GameWindowFlags) : base(1366, 768, new GraphicsMode(), title, GameWindowFlags,DisplayDevice.Default,4,5,GraphicsContextFlags.Default)
		{
			this.renderManager = renderManager;
			this.keyboardManager = keyboardManager;
			this.loader = loader;
			this.KeyDown += KeyboardFunction;
		}
		private void KeyboardFunction(object sender,KeyboardKeyEventArgs arg)
		{
			
		}
		protected override void Dispose(bool manual)
		{
			if (manual)
			{
				renderManager.Dispose();
			}
			base.Dispose(manual);
		}

		protected override void OnLoad(EventArgs ev)
		{
		}

		protected override void OnRenderFrame(FrameEventArgs e)
		{
			GL.Clear(ClearBufferMask.ColorBufferBit);
			
			renderManager.Render(e);

			Context.SwapBuffers();
		}

	}
}