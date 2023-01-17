// Namespace: 
public class BoxCaster.CastResult // TypeDefIndex: 8803
{
	// Fields
	private Vector3 startPos; // 0x10
	private Vector3 endPos; // 0x1C
	private Vector3 dir; // 0x28
	private float sizeXZ; // 0x34
	private float sizeY; // 0x38
	private Quaternion forward; // 0x3C
	public int NumHits; // 0x4C
	public RaycastHit[] Hits; // 0x50

	// Properties
	private Vector3 centerPos { get; }

	// Methods

	// RVA: 0x1F798C0 Offset: 0x1F799C1 VA: 0x1F798C0
	private Vector3 get_centerPos() { }

	// RVA: 0x1F798F0 Offset: 0x1F799F1 VA: 0x1F798F0
	public void .ctor(float settingXZ, float settingY) { }

	// RVA: 0x1F79980 Offset: 0x1F79A81 VA: 0x1F79980
	public void Cast(Vector3 startPos, Vector3 endPos, Vector3 halfBoxSize, int mask) { }

	// RVA: 0x1F79B90 Offset: 0x1F79C91 VA: 0x1F79B90
	public bool IsIntersect(FXZ pos, float radius) { }

	// RVA: 0x1F79D10 Offset: 0x1F79E11 VA: 0x1F79D10
	public bool IsDividedBy(int mask) { }

	// RVA: 0x1F79DB0 Offset: 0x1F79EB1 VA: 0x1F79DB0
	public void DrawGizmos() { }

	// RVA: 0x1F7A1D0 Offset: 0x1F7A2D1 VA: 0x1F7A1D0 Slot: 3
	public override string ToString() { }
}

