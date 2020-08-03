using System;
using System.Collections.Generic;
using Engine3D.Managers.Inputs.KeyInputs;
using OpenTK.Input;

namespace Engine3D.Managers.Inputs
{
    public class KeyboardManager : IKeyboardManager
    {
	    private Dictionary<Key, IKeyInput> keys = new Dictionary<Key, IKeyInput>();

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
			    this.keys.Add(keyInput.key,keyInput);
		    }
	    }
	    public bool Handle(Key triggeredKey)
	    {
		    try
		    {
			    keys[triggeredKey].run();
		    }
		    catch (KeyNotFoundException e)
		    {
				Console.WriteLine("This key handler doesnt exist");
			    return false;
		    }

		    return true;
	    }
    }
}
