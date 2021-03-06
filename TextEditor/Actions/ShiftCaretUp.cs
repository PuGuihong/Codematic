using System;
using System.Drawing;
namespace LTP.TextEditor.Actions
{
	public class ShiftCaretUp : CaretUp
	{
		public override void Execute(TextArea textArea)
		{
			Point position = textArea.Caret.Position;
			base.Execute(textArea);
			textArea.AutoClearSelection = false;
			textArea.SelectionManager.ExtendSelection(position, textArea.Caret.Position);
		}
	}
}
