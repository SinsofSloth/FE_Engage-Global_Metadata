// Namespace: System
[Serializable]
public struct ConsoleKeyInfo // TypeDefIndex: 189
{
	// Fields
	private char _keyChar; // 0x0
	private ConsoleKey _key; // 0x4
	private ConsoleModifiers _mods; // 0x8

	// Properties
	public char KeyChar { get; }
	public ConsoleKey Key { get; }

	// Methods

	// RVA: 0x33B0290 Offset: 0x33B0391 VA: 0x33B0290
	public void .ctor(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	// RVA: 0x33B0340 Offset: 0x33B0441 VA: 0x33B0340
	public char get_KeyChar() { }

	// RVA: 0x33B0350 Offset: 0x33B0451 VA: 0x33B0350
	public ConsoleKey get_Key() { }

	// RVA: 0x33B0360 Offset: 0x33B0461 VA: 0x33B0360 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x33B0410 Offset: 0x33B0511 VA: 0x33B0410
	public bool Equals(ConsoleKeyInfo obj) { }

	// RVA: 0x33B0450 Offset: 0x33B0551 VA: 0x33B0450 Slot: 2
	public override int GetHashCode() { }
}

