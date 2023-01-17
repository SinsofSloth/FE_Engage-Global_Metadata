// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LocalVariable // TypeDefIndex: 3118
{
	// Fields
	public readonly int Index; // 0x10
	private int _flags; // 0x14

	// Properties
	public bool IsBoxed { get; set; }
	public bool InClosure { get; }

	// Methods

	// RVA: 0x3325300 Offset: 0x3325401 VA: 0x3325300
	public bool get_IsBoxed() { }

	// RVA: 0x3325310 Offset: 0x3325411 VA: 0x3325310
	public void set_IsBoxed(bool value) { }

	// RVA: 0x3325330 Offset: 0x3325431 VA: 0x3325330
	public bool get_InClosure() { }

	// RVA: 0x3325340 Offset: 0x3325441 VA: 0x3325340
	internal void .ctor(int index, bool closure) { }

	// RVA: 0x3325390 Offset: 0x3325491 VA: 0x3325390 Slot: 3
	public override string ToString() { }
}

