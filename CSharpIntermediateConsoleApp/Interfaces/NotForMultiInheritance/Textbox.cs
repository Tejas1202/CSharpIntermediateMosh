using System;

namespace CSharpIntermediateConsoleApp.Interfaces.NotForMultiInheritance
{
    // So here, just the syntax looks same but they're fundamentally different
    // Textbox class inherits the code from UiControl class and hence we can use it's class members for code re-use
    // while IDraggable and IDroppable are simple contracts that this class has to implement i.e. Drag and Drop method, hence there is no code-reuse here
    class Textbox : UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
}