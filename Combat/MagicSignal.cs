// Namespace: Combat
[DebuggerDisplayAttribute] // RVA: 0x2746E0 Offset: 0x2747E1 VA: 0x2746E0
[Serializable]
public sealed class MagicSignal // TypeDefIndex: 8783
{
	// Fields
	public MagicLevels level; // 0x10
	public float frame; // 0x14
	public MagicCommand command; // 0x18
	public GameObject prefab; // 0x20
	public string parentName; // 0x28
	public ParticleConnect connect; // 0x30
	public int intParameter; // 0x34
	public float floatParameter; // 0x38
	public string stringParameter; // 0x40

	// Properties
	public float Time { get; }

	// Methods

	// RVA: 0x1F949F0 Offset: 0x1F94AF1 VA: 0x1F949F0
	public static bool op_Implicit(MagicSignal a) { }

	// RVA: 0x1F94A00 Offset: 0x1F94B01 VA: 0x1F94A00
	public float get_Time() { }

	// RVA: 0x1F94A20 Offset: 0x1F94B21 VA: 0x1F94A20
	public bool IsFiredBetween(float prevTime, float currTime) { }

	// RVA: 0x1F94A50 Offset: 0x1F94B51 VA: 0x1F94A50
	public void .ctor() { }
}

