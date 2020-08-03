using OpenTK.Input;

namespace Engine3D.Managers.Inputs.KeyInputs
{
    public interface IKeyInput
    {
	    Key key
	    {
		    get;
	    }
	    void run();
	    bool IsMatch(Key key);
    }
}
