// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ExceptionHandler // TypeDefIndex: 3077
{
	// Fields
	private readonly Type _exceptionType; // 0x10
	public readonly int LabelIndex; // 0x18
	public readonly int HandlerStartIndex; // 0x1C
	public readonly int HandlerEndIndex; // 0x20
	public readonly ExceptionFilter Filter; // 0x28

	// Methods

	// RVA: 0x2E5E030 Offset: 0x2E5E131 VA: 0x2E5E030
	internal void .ctor(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter) { }

	// RVA: 0x2E5E0A0 Offset: 0x2E5E1A1 VA: 0x2E5E0A0
	public bool Matches(Type exceptionType) { }

	// RVA: 0x2E5E0C0 Offset: 0x2E5E1C1 VA: 0x2E5E0C0 Slot: 3
	public override string ToString() { }
}

