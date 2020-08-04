using System;
using System.Collections.Generic;
using Engine3D.Managers.Inputs.KeyInputs;
using OpenTK.Input;

namespace Engine3D.Managers.Inputs
{
    public class KeyboardManager : IKeyboardManager
    {
	    private delegate void RunKey();
	    private Dictionary<Key, RunKey> keys = new Dictionary<Key, RunKey>();

	    public KeyboardManager()
	    {

	    }
	    public KeyboardManager(IKeyInput[] keys)
	    {
		    if (keys == null)
		    {
			    return;
		    }
		    foreach (var keyInput in keys)
		    {
			    if (keyInput == null)
			    {
				    continue;
			    }

			    RunKey runKey = new RunKey(keyInput.run);
			    this.keys.Add(keyInput.key,runKey);
		    }
	    }
	    public void Handle(object sender,KeyboardKeyEventArgs ev)
	    {
		    Key k = ev.Key;
		    try
		    {
			    keys[k].Invoke();
		    }
		    catch (Exception e)
		    {
		    }
	    }

	    public bool AddKeyInputHandler(IKeyInput keyInput)
	    {
		    RunKey keyRunner = new RunKey(keyInput.run);
			try
			{
				keys[keyInput.key] += keyRunner;
			}
			catch (KeyNotFoundException e)
			{
				keys.Add(keyInput.key, keyRunner);
			}

			return true;
	    }

	    public bool AddKeyInputHandler(Key forKey,Delegate runKey)
	    {
		    if (runKey is RunKey keyRunner)
		    {
			    try
				{
					keys[forKey] += keyRunner;
				}
				catch (KeyNotFoundException e)
				{
					keys.Add(forKey,keyRunner);
				}
				return true;
		    }

		    return false;
	    }
    }
}
