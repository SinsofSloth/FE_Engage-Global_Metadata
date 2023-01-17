// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TryCatchFinallyHandler // TypeDefIndex: 3078
{
	// Fields
	internal readonly int TryStartIndex; // 0x10
	internal readonly int TryEndIndex; // 0x14
	internal readonly int FinallyStartIndex; // 0x18
	internal readonly int FinallyEndIndex; // 0x1C
	internal readonly int GotoEndTargetIndex; // 0x20
	private readonly ExceptionHandler[] _handlers; // 0x28

	// Properties
	internal bool IsFinallyBlockExist { get; }
	internal bool IsCatchBlockExist { get; }

	// Methods

	// RVA: 0x3333C70 Offset: 0x3333D71 VA: 0x3333C70
	internal bool get_IsFinallyBlockExist() { }

	// RVA: 0x3333C90 Offset: 0x3333D91 VA: 0x3333C90
	internal bool get_IsCatchBlockExist() { }

	// RVA: 0x3333CA0 Offset: 0x3333DA1 VA: 0x3333CA0
	internal void .ctor(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) { }

	// RVA: 0x3333D00 Offset: 0x3333E01 VA: 0x3333D00
	internal void .ctor(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) { }

	// RVA: 0x3333D70 Offset: 0x3333E71 VA: 0x3333D70
	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) { }

	// RVA: 0x3333EE0 Offset: 0x3333FE1 VA: 0x3333EE0
	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) { }
}

