// Namespace: UnityEngine.Rendering
public struct DepthState : IEquatable<DepthState> // TypeDefIndex: 3940
{
	// Fields
	private byte m_WriteEnabled; // 0x0
	private sbyte m_CompareFunction; // 0x1

	// Properties
	public static DepthState defaultValue { get; }
	public bool writeEnabled { set; }
	public CompareFunction compareFunction { set; }

	// Methods

	// RVA: 0x2F20530 Offset: 0x2F20631 VA: 0x2F20530
	public static DepthState get_defaultValue() { }

	// RVA: 0x2F205A0 Offset: 0x2F206A1 VA: 0x2F205A0
	public void .ctor(bool writeEnabled = True, CompareFunction compareFunction = 2) { }

	// RVA: 0x2F20630 Offset: 0x2F20731 VA: 0x2F20630
	public void set_writeEnabled(bool value) { }

	// RVA: 0x2F206B0 Offset: 0x2F207B1 VA: 0x2F206B0
	public void set_compareFunction(CompareFunction value) { }

	// RVA: 0x2F206C0 Offset: 0x2F207C1 VA: 0x2F206C0 Slot: 4
	public bool Equals(DepthState other) { }

	// RVA: 0x2F206F0 Offset: 0x2F207F1 VA: 0x2F206F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F20790 Offset: 0x2F20891 VA: 0x2F20790 Slot: 2
	public override int GetHashCode() { }
}

