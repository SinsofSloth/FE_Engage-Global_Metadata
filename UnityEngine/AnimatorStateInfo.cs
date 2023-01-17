// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x348B0 Offset: 0x349B1 VA: 0x348B0
[RequiredByNativeCodeAttribute] // RVA: 0x348B0 Offset: 0x349B1 VA: 0x348B0
public struct AnimatorStateInfo // TypeDefIndex: 4095
{
	// Fields
	private int m_Name; // 0x0
	private int m_Path; // 0x4
	private int m_FullPath; // 0x8
	private float m_NormalizedTime; // 0xC
	private float m_Length; // 0x10
	private float m_Speed; // 0x14
	private float m_SpeedMultiplier; // 0x18
	private int m_Tag; // 0x1C
	private int m_Loop; // 0x20

	// Properties
	public int fullPathHash { get; }
	public int shortNameHash { get; }
	public float normalizedTime { get; }
	public float length { get; }
	public float speed { get; }
	public float speedMultiplier { get; }
	public bool loop { get; }

	// Methods

	// RVA: 0x3EDD010 Offset: 0x3EDD111 VA: 0x3EDD010
	public bool IsName(string name) { }

	// RVA: 0x3EDD0A0 Offset: 0x3EDD1A1 VA: 0x3EDD0A0
	public int get_fullPathHash() { }

	// RVA: 0x3EDD0B0 Offset: 0x3EDD1B1 VA: 0x3EDD0B0
	public int get_shortNameHash() { }

	// RVA: 0x3EDD0C0 Offset: 0x3EDD1C1 VA: 0x3EDD0C0
	public float get_normalizedTime() { }

	// RVA: 0x3EDD0D0 Offset: 0x3EDD1D1 VA: 0x3EDD0D0
	public float get_length() { }

	// RVA: 0x3EDD0E0 Offset: 0x3EDD1E1 VA: 0x3EDD0E0
	public float get_speed() { }

	// RVA: 0x3EDD0F0 Offset: 0x3EDD1F1 VA: 0x3EDD0F0
	public float get_speedMultiplier() { }

	// RVA: 0x3EDD100 Offset: 0x3EDD201 VA: 0x3EDD100
	public bool get_loop() { }
}

