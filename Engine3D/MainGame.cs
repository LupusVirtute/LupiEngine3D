using OpenTK.Graphics;

namespace Engine3D
{
	public class MainGame : OpenTK.GameWindow
	{
		public MainGame(string title, OpenTK.GameWindowFlags GameWindowFlags) : base(1366, 768, new GraphicsMode(), title, GameWindowFlags)
		{
		}
	}
}