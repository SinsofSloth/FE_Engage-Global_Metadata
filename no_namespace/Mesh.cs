// Namespace: 
[NativeContainerSupportsMinMaxWriteRestrictionAttribute] // RVA: 0x43D2B0 Offset: 0x43D3B1 VA: 0x43D2B0
[StaticAccessorAttribute] // RVA: 0x43D2B0 Offset: 0x43D3B1 VA: 0x43D2B0
[NativeContainerAttribute] // RVA: 0x43D2B0 Offset: 0x43D3B1 VA: 0x43D2B0
[DefaultMemberAttribute] // RVA: 0x43D2B0 Offset: 0x43D3B1 VA: 0x43D2B0
public struct Mesh.MeshDataArray : IDisposable // TypeDefIndex: 3510
{
	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x442EE0 Offset: 0x442FE1 VA: 0x442EE0
	private IntPtr* m_Ptrs; // 0x0
	internal int m_Length; // 0x8

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x3854100 Offset: 0x3854201 VA: 0x3854100
	private static void AcquireReadOnlyMeshData(Mesh mesh, IntPtr* datas) { }

	// RVA: 0x3854150 Offset: 0x3854251 VA: 0x3854150
	private static void AcquireReadOnlyMeshDatas(Mesh[] meshes, IntPtr* datas, int count) { }

	// RVA: 0x38541B0 Offset: 0x38542B1 VA: 0x38541B0
	private static void ReleaseMeshDatas(IntPtr* datas, int count) { }

	// RVA: 0x3854200 Offset: 0x3854301 VA: 0x3854200
	private static void CreateNewMeshDatas(IntPtr* datas, int count) { }

	[NativeThrowsAttribute] // RVA: 0x44C260 Offset: 0x44C361 VA: 0x44C260
	// RVA: 0x3854250 Offset: 0x3854351 VA: 0x3854250
	private static void ApplyToMeshesImpl(Mesh[] meshes, IntPtr* datas, int count, MeshUpdateFlags flags) { }

	[NativeThrowsAttribute] // RVA: 0x44C270 Offset: 0x44C371 VA: 0x44C270
	// RVA: 0x38542C0 Offset: 0x38543C1 VA: 0x38542C0
	private static void ApplyToMeshImpl(Mesh mesh, IntPtr data, MeshUpdateFlags flags) { }

	// RVA: 0x3854320 Offset: 0x3854421 VA: 0x3854320
	public int get_Length() { }

	// RVA: 0x3854330 Offset: 0x3854431 VA: 0x3854330 Slot: 4
	public void Dispose() { }

	// RVA: 0x38543D0 Offset: 0x38544D1 VA: 0x38543D0
	internal void ApplyToMeshAndDispose(Mesh mesh, MeshUpdateFlags flags) { }

	// RVA: 0x3854540 Offset: 0x3854641 VA: 0x3854540
	internal void ApplyToMeshesAndDispose(Mesh[] meshes, MeshUpdateFlags flags) { }

	// RVA: 0x38547C0 Offset: 0x38548C1 VA: 0x38547C0
	internal void .ctor(Mesh mesh, bool checkReadWrite = True) { }

	// RVA: 0x38549E0 Offset: 0x3854AE1 VA: 0x38549E0
	internal void .ctor(Mesh[] meshes, int meshesCount, bool checkReadWrite = True) { }

	// RVA: 0x3854D40 Offset: 0x3854E41 VA: 0x3854D40
	internal void .ctor(int meshesCount) { }
}

