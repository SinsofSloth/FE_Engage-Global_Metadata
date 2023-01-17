// Namespace: Combat
[Serializable]
public sealed class MagicBulletSettings // TypeDefIndex: 8778
{
	// Fields
	[HideInInspector] // RVA: 0x284440 Offset: 0x284541 VA: 0x284440
	public string HomeNodeName; // 0x10
	[HideInInspector] // RVA: 0x284450 Offset: 0x284551 VA: 0x284450
	public string TargetNodeName; // 0x18
	[HideInInspector] // RVA: 0x284460 Offset: 0x284561 VA: 0x284460
	public float DecayFrame; // 0x20
	[HideInInspector] // RVA: 0x284470 Offset: 0x284571 VA: 0x284470
	public MagicArrivalType ArrivalType; // 0x24
	[HideInInspector] // RVA: 0x284480 Offset: 0x284581 VA: 0x284480
	public float MoveSpeed; // 0x28
	[HideInInspector] // RVA: 0x284490 Offset: 0x284591 VA: 0x284490
	public Curve.Type EaseType; // 0x2C
	[HideInInspector] // RVA: 0x2844A0 Offset: 0x2845A1 VA: 0x2844A0
	public int EasePower; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0x2844B0 Offset: 0x2845B1 VA: 0x2844B0
	[HideInInspector] // RVA: 0x2844B0 Offset: 0x2845B1 VA: 0x2844B0
	public float ConstantArrivalFrame; // 0x34

	// Properties
	public float DecayTime { get; }

	// Methods

	// RVA: 0x1F946F0 Offset: 0x1F947F1 VA: 0x1F946F0
	public float get_DecayTime() { }

	// RVA: 0x1F935F0 Offset: 0x1F936F1 VA: 0x1F935F0
	public float CalcFlyingTime(Vector3 startPos, Vector3 endPos) { }

	// RVA: 0x1F944D0 Offset: 0x1F945D1 VA: 0x1F944D0
	public void .ctor() { }
}

