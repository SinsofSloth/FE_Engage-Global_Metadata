// Namespace: UTJ
public class WindVolume : ForceProvider // TypeDefIndex: 6356
{
	// Fields
	[RangeAttribute] // RVA: 0x5B660 Offset: 0x5B761 VA: 0x5B660
	public float weight; // 0x18
	public float strength; // 0x1C
	public float amplitude; // 0x20
	public float period; // 0x24
	public float spinPeriod; // 0x28
	public float peakDistance; // 0x2C
	private const float PI2 = 6.2831855;
	private float positionalMultiplier; // 0x30
	private float currentTime; // 0x34
	private float timeFactor; // 0x38
	private float spinTime; // 0x3C
	private Vector3 offsetVector; // 0x40

	// Properties
	public Vector3 OffsetVector { get; }

	// Methods

	// RVA: 0x3A79250 Offset: 0x3A79351 VA: 0x3A79250 Slot: 4
	public override Vector3 GetForceOnBone(SpringBone springBone) { }

	// RVA: 0x3A793F0 Offset: 0x3A794F1 VA: 0x3A793F0
	public Vector3 get_OffsetVector() { }

	// RVA: 0x3A793A0 Offset: 0x3A794A1 VA: 0x3A793A0
	private float GetPositionalFactor(float x, float y) { }

	// RVA: 0x3A79400 Offset: 0x3A79501 VA: 0x3A79400
	private float AddPeriodically(float currentValue, float deltaValue, float period) { }

	// RVA: 0x3A79420 Offset: 0x3A79521 VA: 0x3A79420
	private void Update() { }

	// RVA: 0x3A795E0 Offset: 0x3A796E1 VA: 0x3A795E0 Slot: 5
	public override SpringForceComponent GetActiveForce() { }

	// RVA: 0x3A796D0 Offset: 0x3A797D1 VA: 0x3A796D0
	public void .ctor() { }
}

