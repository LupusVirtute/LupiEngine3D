using System;
using System.Collections.Generic;
using Engine3D.Data.Objects3D.Mesh;
using Engine3D.Data.Shaders;
using Engine3D.Data.Textures;

namespace Engine3D.Data.Objects3D
{
    public class Entity : IEntity
    {
		private Mesh3D mesh;
		private List<Texture> textures;

		public Entity(Mesh3D mesh, Texture[] textures)
		{
			this.mesh = mesh;
			this.textures = new List<Texture>(textures);
		}
		public void Dispose()
		{

		}
		public void Draw(IShader shader)
		{
			shader.Use();
			Draw();
		}

		public void Draw()
		{
			throw new NotImplementedException();
		}
    }
}
