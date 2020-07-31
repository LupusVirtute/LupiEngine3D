using System;
using System.Collections.Generic;
using Engine3D.Data.Objects3D.Mesh;
using Engine3D.Data.Shaders;
using Engine3D.Data.Textures;
using OpenTK;

namespace Engine3D.Data.Objects3D
{
    public class Entity : IEntity
    {
	    private bool disposed;

		private Mesh3D mesh;
		private List<Texture> textures;
		private Vector3 entityPos;

		public Entity(Mesh3D mesh, Texture[] textures,Vector3 entityPos)
		{
			this.mesh = mesh;
			this.textures = new List<Texture>(textures);
			this.entityPos = entityPos;
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public void Dispose(bool disposing)
		{
			if (!disposing) return;
			if (!disposed)
			{
				mesh.Dispose();
				for (int i = 0; i < textures.Count; i++)
				{
					textures[i].Dispose();
				}
				disposed = true;
			}
		}
		public void Draw(IShader shader)
		{
			shader.Use();
			Draw();
		}

		public void Draw()
		{
			// TODO apply textures
			mesh.Draw();
		}
    }
}
