// Namespace: Combat
[DefaultMemberAttribute] // RVA: 0x274BC0 Offset: 0x274CC1 VA: 0x274BC0
internal sealed class FlattenedVec3Curve // TypeDefIndex: 8863
{
	// Fields
	private const float U = 0.0020833334;
	[CompilerGeneratedAttribute] // RVA: 0x284A60 Offset: 0x284B61 VA: 0x284A60
	private float <timeLength>k__BackingField; // 0x10
	private List<Vector3> tip; // 0x18
	private List<Vector3> roo; // 0x20
	private List<Vector3> dir; // 0x28

	// Properties
	public float timeLength { get; set; }
	public int length { get; }
	public Vector3 Item { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AD7D0 Offset: 0x2AD8D1 VA: 0x2AD7D0
	// RVA: 0x29F77D0 Offset: 0x29F78D1 VA: 0x29F77D0
	public float get_timeLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD7E0 Offset: 0x2AD8E1 VA: 0x2AD7E0
	// RVA: 0x29F77E0 Offset: 0x29F78E1 VA: 0x29F77E0
	private void set_timeLength(float value) { }

	// RVA: 0x29F77F0 Offset: 0x29F78F1 VA: 0x29F77F0
	public int get_length() { }

	// RVA: 0x29F7840 Offset: 0x29F7941 VA: 0x29F7840
	public Vector3 get_Item(int i) { }

	// RVA: 0x29F78C0 Offset: 0x29F79C1 VA: 0x29F78C0
	public void .ctor(AnimationCurve rx, AnimationCurve ry, AnimationCurve rz, AnimationCurve tx, AnimationCurve ty, AnimationCurve tz) { }

	// RVA: 0x29F7C10 Offset: 0x29F7D11 VA: 0x29F7C10
	public void CopyFrom(FlattenedVec3Curve rhs, int lp, int rp) { }

	// RVA: 0x29F7D50 Offset: 0x29F7E51 VA: 0x29F7D50
	public void Export(out AnimationCurve rx, out AnimationCurve ry, out AnimationCurve rz, out AnimationCurve tx, out AnimationCurve ty, out AnimationCurve tz) { }
}

