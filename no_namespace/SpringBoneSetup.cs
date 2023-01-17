// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B2D0 Offset: 0x5B3D1 VA: 0x5B2D0
private sealed class SpringBoneSetup.<>c__DisplayClass8_0 // TypeDefIndex: 6379
{
	// Fields
	public IEnumerable<Transform> skinBones; // 0x10

	// Methods

	// RVA: 0x3A7D200 Offset: 0x3A7D301 VA: 0x3A7D200
	public void .ctor() { }

	// RVA: 0x3A7D210 Offset: 0x3A7D311 VA: 0x3A7D210
	internal bool <GetPivotToSpringBoneMap>b__0(SpringBone bone) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B2E0 Offset: 0x5B3E1 VA: 0x5B2E0
private sealed class SpringBoneSetup.<>c__DisplayClass12_0 // TypeDefIndex: 6380
{
	// Fields
	public IEnumerable<Transform> skinBones; // 0x10

	// Methods

	// RVA: 0x3A7D1D0 Offset: 0x3A7D2D1 VA: 0x3A7D1D0
	public void .ctor() { }

	// RVA: 0x3A7D1E0 Offset: 0x3A7D2E1 VA: 0x3A7D1E0
	internal bool <DestroyPivotObjects>b__2(Transform pivot) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x5B2F0 Offset: 0x5B3F1 VA: 0x5B2F0
[Serializable]
private sealed class SpringBoneSetup.<>c // TypeDefIndex: 6381
{
	// Fields
	public static readonly SpringBoneSetup.<>c <>9; // 0x0
	public static Func<SpringBone, bool> <>9__12_0; // 0x8
	public static Func<SpringBone, Transform> <>9__12_1; // 0x10
	public static Func<Transform, GameObject> <>9__12_3; // 0x18
	public static Func<SkinnedMeshRenderer, Mesh> <>9__14_0; // 0x20
	public static Func<Mesh, bool> <>9__14_1; // 0x28
	public static Func<SpringBone, <>f__AnonymousType0<SpringBone, int>> <>9__17_0; // 0x30
	public static Comparison<<>f__AnonymousType0<SpringBone, int>> <>9__17_1; // 0x38
	public static Func<<>f__AnonymousType0<SpringBone, int>, SpringBone> <>9__17_2; // 0x40

	// Methods

	// RVA: 0x3A7CEC0 Offset: 0x3A7CFC1 VA: 0x3A7CEC0
	private static void .cctor() { }

	// RVA: 0x3A7CF30 Offset: 0x3A7D031 VA: 0x3A7CF30
	public void .ctor() { }

	// RVA: 0x3A7CF40 Offset: 0x3A7D041 VA: 0x3A7CF40
	internal bool <DestroyPivotObjects>b__12_0(SpringBone springBone) { }

	// RVA: 0x3A7CFC0 Offset: 0x3A7D0C1 VA: 0x3A7CFC0
	internal Transform <DestroyPivotObjects>b__12_1(SpringBone springBone) { }

	// RVA: 0x3A7CFD0 Offset: 0x3A7D0D1 VA: 0x3A7CFD0
	internal GameObject <DestroyPivotObjects>b__12_3(Transform pivot) { }

	// RVA: 0x3A7CFE0 Offset: 0x3A7D0E1 VA: 0x3A7CFE0
	internal Mesh <FindClosestMeshNormalToPoint>b__14_0(SkinnedMeshRenderer renderer) { }

	// RVA: 0x3A7CFF0 Offset: 0x3A7D0F1 VA: 0x3A7CFF0
	internal bool <FindClosestMeshNormalToPoint>b__14_1(Mesh mesh) { }

	// RVA: 0x3A7D090 Offset: 0x3A7D191 VA: 0x3A7D090
	internal <>f__AnonymousType0<SpringBone, int> <GetSpringBonesSortedByDepth>b__17_0(SpringBone bone) { }

	// RVA: 0x3A7D130 Offset: 0x3A7D231 VA: 0x3A7D130
	internal int <GetSpringBonesSortedByDepth>b__17_1(<>f__AnonymousType0<SpringBone, int> a, <>f__AnonymousType0<SpringBone, int> b) { }

	// RVA: 0x3A7D190 Offset: 0x3A7D291 VA: 0x3A7D190
	internal SpringBone <GetSpringBonesSortedByDepth>b__17_2(<>f__AnonymousType0<SpringBone, int> item) { }
}

