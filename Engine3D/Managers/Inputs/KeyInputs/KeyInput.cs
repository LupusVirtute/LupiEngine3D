using OpenTK.Input;

namespace Engine3D.Managers.Inputs.KeyInputs
{
    public abstract class KeyInput : IKeyInput
    {
	    private readonly Key _key;

	    protected KeyInput(Key key)
	    {
		    _key = key;
	    }
	    public Key key
	    {
		    get => _key;
	    }

	    public abstract void run();

	    public bool IsMatch(Key key)
	    {
		    return key == _key;
	    }
    }
}
