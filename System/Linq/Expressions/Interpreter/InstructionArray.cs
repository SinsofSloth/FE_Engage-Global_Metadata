// Namespace: System.Linq.Expressions.Interpreter
[DebuggerTypeProxyAttribute] // RVA: 0x40470 Offset: 0x40571 VA: 0x40470
internal struct InstructionArray // TypeDefIndex: 3033
{
	// Fields
	internal readonly int MaxStackDepth; // 0x0
	internal readonly int MaxContinuationDepth; // 0x4
	internal readonly Instruction[] Instructions; // 0x8
	internal readonly object[] Objects; // 0x10
	internal readonly RuntimeLabel[] Labels; // 0x18
	internal readonly List<KeyValuePair<int, object>> DebugCookies; // 0x20

	// Methods

	// RVA: 0x31B7300 Offset: 0x31B7401 VA: 0x31B7300
	internal void .ctor(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, object[] objects, RuntimeLabel[] labels, List<KeyValuePair<int, object>> debugCookies) { }
}

