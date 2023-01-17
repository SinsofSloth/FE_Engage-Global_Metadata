// Namespace: 
internal struct ShadowUtility.Edge : IComparable<ShadowUtility.Edge> // TypeDefIndex: 5496
{
	// Fields
	public int vertexIndex0; // 0x0
	public int vertexIndex1; // 0x4
	public Vector4 tangent; // 0x8
	private bool compareReversed; // 0x18

	// Methods

	// RVA: 0x2FA6B90 Offset: 0x2FA6C91 VA: 0x2FA6B90
	public void AssignVertexIndices(int vi0, int vi1) { }

	// RVA: 0x2FA6BB0 Offset: 0x2FA6CB1 VA: 0x2FA6BB0
	public int Compare(ShadowUtility.Edge a, ShadowUtility.Edge b) { }

	// RVA: 0x2FA6BF0 Offset: 0x2FA6CF1 VA: 0x2FA6BF0 Slot: 4
	public int CompareTo(ShadowUtility.Edge edgeToCompare) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x480490 Offset: 0x480591 VA: 0x480490
[Serializable]
private sealed class ShadowUtility.<>c // TypeDefIndex: 5497
{
	// Fields
	public static readonly ShadowUtility.<>c <>9; // 0x0
	public static Func<int, int> <>9__8_0; // 0x8
	public static Func<ContourVertex, Vector3> <>9__8_1; // 0x10
	public static Func<ContourVertex, Color> <>9__8_2; // 0x18

	// Methods

	// RVA: 0x2FA69B0 Offset: 0x2FA6AB1 VA: 0x2FA69B0
	private static void .cctor() { }

	// RVA: 0x2FA6A20 Offset: 0x2FA6B21 VA: 0x2FA6A20
	public void .ctor() { }

	// RVA: 0x2FA6A30 Offset: 0x2FA6B31 VA: 0x2FA6A30
	internal int <GenerateShadowMesh>b__8_0(int i) { }

	// RVA: 0x2FA6A40 Offset: 0x2FA6B41 VA: 0x2FA6A40
	internal Vector3 <GenerateShadowMesh>b__8_1(ContourVertex v) { }

	// RVA: 0x2FA6A50 Offset: 0x2FA6B51 VA: 0x2FA6A50
	internal Color <GenerateShadowMesh>b__8_2(ContourVertex v) { }
}

