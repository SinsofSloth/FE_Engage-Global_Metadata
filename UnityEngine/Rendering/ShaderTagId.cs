// Namespace: UnityEngine.Rendering
public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 3958
{
	// Fields
	public static readonly ShaderTagId none; // 0x0
	private int m_Id; // 0x0

	// Properties
	internal int id { get; set; }

	// Methods

	// RVA: 0x31E62B0 Offset: 0x31E63B1 VA: 0x31E62B0
	public void .ctor(string name) { }

	// RVA: 0x31E7100 Offset: 0x31E7201 VA: 0x31E7100
	internal int get_id() { }

	// RVA: 0x31E7170 Offset: 0x31E7271 VA: 0x31E7170
	internal void set_id(int value) { }

	// RVA: 0x31EAD00 Offset: 0x31EAE01 VA: 0x31EAD00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31EAD90 Offset: 0x31EAE91 VA: 0x31EAD90 Slot: 4
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x31EADA0 Offset: 0x31EAEA1 VA: 0x31EADA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31EADD0 Offset: 0x31EAED1 VA: 0x31EADD0
	public static bool op_Equality(ShaderTagId tag1, ShaderTagId tag2) { }

	// RVA: 0x31EADE0 Offset: 0x31EAEE1 VA: 0x31EADE0
	public static bool op_Inequality(ShaderTagId tag1, ShaderTagId tag2) { }

	// RVA: 0x31EAE50 Offset: 0x31EAF51 VA: 0x31EAE50
	private static void .cctor() { }
}

