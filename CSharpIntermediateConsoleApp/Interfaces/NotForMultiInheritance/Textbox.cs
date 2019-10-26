using System;

namespace CSharpIntermediateConsoleApp.Interfaces.NotForMultiInheritance
{
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