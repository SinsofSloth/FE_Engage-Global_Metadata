// Namespace: RootMotion.FinalIK
public class LookAtController : MonoBehaviour // TypeDefIndex: 14466
{
	// Fields
	public LookAtIK ik; // 0x18
	[TooltipAttribute] // RVA: 0x2A50A0 Offset: 0x2A51A1 VA: 0x2A50A0
	[HeaderAttribute] // RVA: 0x2A50A0 Offset: 0x2A51A1 VA: 0x2A50A0
	public Transform target; // 0x20
	[RangeAttribute] // RVA: 0x2A5100 Offset: 0x2A5201 VA: 0x2A5100
	public float weight; // 0x28
	public Vector3 offset; // 0x2C
	[TooltipAttribute] // RVA: 0x2A5120 Offset: 0x2A5221 VA: 0x2A5120
	public float targetSwitchSmoothTime; // 0x38
	[TooltipAttribute] // RVA: 0x2A5160 Offset: 0x2A5261 VA: 0x2A5160
	public float weightSmoothTime; // 0x3C
	[HeaderAttribute] // RVA: 0x2A51A0 Offset: 0x2A52A1 VA: 0x2A51A0
	[TooltipAttribute] // RVA: 0x2A51A0 Offset: 0x2A52A1 VA: 0x2A51A0
	public bool smoothTurnTowardsTarget; // 0x40
	[TooltipAttribute] // RVA: 0x2A5200 Offset: 0x2A5301 VA: 0x2A5200
	public float maxRadiansDelta; // 0x44
	[TooltipAttribute] // RVA: 0x2A5240 Offset: 0x2A5341 VA: 0x2A5240
	public float maxMagnitudeDelta; // 0x48
	[TooltipAttribute] // RVA: 0x2A5280 Offset: 0x2A5381 VA: 0x2A5280
	public float slerpSpeed; // 0x4C
	[TooltipAttribute] // RVA: 0x2A52C0 Offset: 0x2A53C1 VA: 0x2A52C0
	public Vector3 pivotOffsetFromRoot; // 0x50
	[TooltipAttribute] // RVA: 0x2A5300 Offset: 0x2A5401 VA: 0x2A5300
	public float minDistance; // 0x5C
	[RangeAttribute] // RVA: 0x2A5340 Offset: 0x2A5441 VA: 0x2A5340
	[HeaderAttribute] // RVA: 0x2A5340 Offset: 0x2A5441 VA: 0x2A5340
	[TooltipAttribute] // RVA: 0x2A5340 Offset: 0x2A5441 VA: 0x2A5340
	public float maxRootAngle; // 0x60
	private Transform lastTarget; // 0x68
	private float switchWeight; // 0x70
	private float switchWeightV; // 0x74
	private float weightV; // 0x78
	private Vector3 lastPosition; // 0x7C
	private Vector3 dir; // 0x88
	private bool lastSmoothTowardsTarget; // 0x94

	// Properties
	private Vector3 pivot { get; }

	// Methods

	// RVA: 0x1F91430 Offset: 0x1F91531 VA: 0x1F91430
	private void Start() { }

	// RVA: 0x1F91570 Offset: 0x1F91671 VA: 0x1F91570
	private void LateUpdate() { }

	// RVA: 0x1F914F0 Offset: 0x1F915F1 VA: 0x1F914F0
	private Vector3 get_pivot() { }

	// RVA: 0x1F91BB0 Offset: 0x1F91CB1 VA: 0x1F91BB0
	private void ApplyMinDistance() { }

	// RVA: 0x1F91CC0 Offset: 0x1F91DC1 VA: 0x1F91CC0
	private void RootRotation() { }

	// RVA: 0x1F91ED0 Offset: 0x1F91FD1 VA: 0x1F91ED0
	public void .ctor() { }
}

