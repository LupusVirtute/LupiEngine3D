using System;
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
	    void Handle(object sender,KeyboardKeyEventArgs ev);
        /// <summary>
        /// Adds Key Input Handler to handler totals
        /// </summary>
        /// <param name="keyInput"></param>
        /// <returns></returns>
        bool AddKeyInputHandler(IKeyInput keyInput);
        /// <summary>
        /// Way with using delegate not recommended only should accept KeyboardManager.RunKey delegate
        /// </summary>
        /// <param name="forKey"></param>
        /// <param name="dDelegate"></param>
        /// <returns></returns>
        bool AddKeyInputHandler(Key forKey,Delegate dDelegate);
    }
}
