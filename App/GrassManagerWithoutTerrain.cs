// Namespace: App
[ExecuteAlways] // RVA: 0x274E00 Offset: 0x274F01 VA: 0x274E00
public abstract class GrassManagerWithoutTerrain : GrassManager // TypeDefIndex: 8995
{
	// Properties
	public override bool HasTerrain { get; }

	// Methods

	// RVA: 0x27C1070 Offset: 0x27C1171 VA: 0x27C1070 Slot: 4
	public override bool get_HasTerrain() { }

	// RVA: 0x27C1080 Offset: 0x27C1181 VA: 0x27C1080 Slot: 5
	protected override Transform FindGrassMeshParentTransform(Transform parent, int meshIndex) { }

	// RVA: 0x27C10D0 Offset: 0x27C11D1 VA: 0x27C10D0
	public static ValueTuple<Transform, int> FindGroundTransform(Transform parentTransform, int index) { }

	// RVA: 0x27C1420 Offset: 0x27C1521 VA: 0x27C1420 Slot: 6
	protected override int CalcReferenceTransformNum() { }

	// RVA: 0x27C1630 Offset: 0x27C1731 VA: 0x27C1630 Slot: 7
	public override ValueTuple<Transform, int> FindGroundTransform(int meshIndex) { }

	// RVA: 0x27C1660 Offset: 0x27C1761 VA: 0x27C1660 Slot: 8
	public override bool GetFieldSizeOffset(out Vector3 size, out Vector3 offset) { }

	// RVA: 0x27C1870 Offset: 0x27C1971 VA: 0x27C1870 Slot: 10
	protected override Texture2D FindGroundTexture(int meshIndex) { }

	// RVA: 0x27C1A70 Offset: 0x27C1B71 VA: 0x27C1A70
	protected void .ctor() { }
}

