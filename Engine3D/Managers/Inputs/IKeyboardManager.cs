using Engine3D.Managers.Inputs.KeyInputs;
using OpenTK.Input;

namespace Engine3D.Managers.Inputs
{
    public interface IKeyboardManager
    {
        /// <summary>
        /// Handles the response to the key that was triggered
        /// </summary>
        /// <param name="triggeredKey">Key that was triggered</param>
        /// <returns>If operation was successful</returns>
	    bool Handle(Key triggeredKey);
        /// <summary>
        /// Adds Key Input Handler to handler totals
        /// </summary>
        /// <param name="keyInput"></param>
        /// <returns></returns>
        bool AddKeyInputHandler(IKeyInput keyInput);
    }
}
