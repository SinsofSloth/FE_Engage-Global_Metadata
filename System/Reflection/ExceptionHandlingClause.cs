// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x4724C0 Offset: 0x4725C1 VA: 0x4724C0
public class ExceptionHandlingClause // TypeDefIndex: 565
{
	// Fields
	internal Type catch_type; // 0x10
	internal int filter_offset; // 0x18
	internal ExceptionHandlingClauseOptions flags; // 0x1C
	internal int try_offset; // 0x20
	internal int try_length; // 0x24
	internal int handler_offset; // 0x28
	internal int handler_length; // 0x2C

	// Methods

	// RVA: 0x3B63200 Offset: 0x3B63301 VA: 0x3B63200
	protected void .ctor() { }

	// RVA: 0x3B63210 Offset: 0x3B63311 VA: 0x3B63210 Slot: 3
	public override string ToString() { }
}

