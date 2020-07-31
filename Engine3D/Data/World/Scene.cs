using System;
using System.Collections.Generic;
using Engine3D.Data.Objects3D;
using Engine3D.Data.Shaders;

namespace Engine3D.Data.World
{
    public class Scene : IScene
    {
	    private bool disposed;

	    private List<IEntity> _entities;
	    private string _sceneName;

	    public Scene(IEntity[] entities,string sceneName)
	    {
		    _sceneName = sceneName;
			_entities = new List<IEntity>();
		    for (var i = 0; i < entities.Length; i++)
		    {
				if (entities[i] != null)
					_entities.Add(entities[i]);
#if DEBUG
				else
					Console.WriteLine("Entity nr "+i+" from scene " + sceneName + " failed to load properly");
#endif
		    }
	    }
	    public void Dispose()
	    {
			Dispose(true);
			GC.SuppressFinalize(this);
	    }
		/// <summary>
		/// Adds entity to rendering
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
	    public bool AddEntityToScene(IEntity entity)
	    {
		    if (entity == null)
			    return false;
			_entities.Add(entity);
			return true;
	    }

		public bool RemoveEntityByReference(IEntity entity)
		{
			if (entity == null)
				return false;
			_entities.Remove(entity);
			return true;
		}

	    public void Dispose(bool disposing)
	    {
		    if (!disposed)
		    {
			    if (disposing)
			    {
				    for (int i = 0; i < _entities.Count; i++)
				    {
					    _entities[i].Dispose();
				    }
				    disposed = true;
			    }
		    }
	    }
		public void Render(IShader shader)
	    {
			shader.Use();
			Render();
	    }

	    public void Render()
	    {
		    for (int i = 0; i < _entities.Count; i++)
		    {
			    _entities[i].Draw();
		    }
	    }
    }
}
