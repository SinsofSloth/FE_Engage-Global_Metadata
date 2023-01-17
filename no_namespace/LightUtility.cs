// Namespace: 
private struct LightUtility.ParametricLightMeshVertex // TypeDefIndex: 5477
{
	// Fields
	public float3 position; // 0x0
	public Color color; // 0xC
	public static readonly VertexAttributeDescriptor[] VertexLayout; // 0x0

	// Methods

	// RVA: 0x2FA35F0 Offset: 0x2FA36F1 VA: 0x2FA35F0
	private static void .cctor() { }
}

// Namespace: 
private struct LightUtility.SpriteLightMeshVertex // TypeDefIndex: 5478
{
	// Fields
	public Vector3 position; // 0x0
	public Color color; // 0xC
	public Vector2 uv; // 0x1C
	public static readonly VertexAttributeDescriptor[] VertexLayout; // 0x0

	// Methods

	// RVA: 0x2FA36E0 Offset: 0x2FA37E1 VA: 0x2FA36E0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x480240 Offset: 0x480341 VA: 0x480240
[Serializable]
private sealed class LightUtility.<>c // TypeDefIndex: 5479
{
	// Fields
	public static readonly LightUtility.<>c <>9; // 0x0
	public static Func<int, int> <>9__8_0; // 0x8
	public static Func<ContourVertex, float3> <>9__8_1; // 0x10

	// Methods

	// RVA: 0x2FA3550 Offset: 0x2FA3651 VA: 0x2FA3550
	private static void .cctor() { }

	// RVA: 0x2FA35C0 Offset: 0x2FA36C1 VA: 0x2FA35C0
	public void .ctor() { }

	// RVA: 0x2FA35D0 Offset: 0x2FA36D1 VA: 0x2FA35D0
	internal int <GenerateShapeMesh>b__8_0(int i) { }

	// RVA: 0x2FA35E0 Offset: 0x2FA36E1 VA: 0x2FA35E0
	internal float3 <GenerateShapeMesh>b__8_1(ContourVertex v) { }
}

