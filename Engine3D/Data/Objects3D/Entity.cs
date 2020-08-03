using System;
using System.Collections.Generic;
using Engine3D.Data.Objects3D.Mesh;
using Engine3D.Data.Shaders;
using Engine3D.Data.Textures;
using ProtoBuf;

namespace Engine3D.Data.Objects3D
{
	[ProtoContract(Name = "entity")]
	public class Entity : IEntity
    {
		[ProtoMember(1)]
		private Mesh3D mesh;
		[ProtoMember(2)]
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
