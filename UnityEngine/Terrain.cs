// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x48E090 Offset: 0x48E191 VA: 0x48E090
[NativeHeaderAttribute] // RVA: 0x48E090 Offset: 0x48E191 VA: 0x48E090
[StaticAccessorAttribute] // RVA: 0x48E090 Offset: 0x48E191 VA: 0x48E090
[NativeHeaderAttribute] // RVA: 0x48E090 Offset: 0x48E191 VA: 0x48E090
[NativeHeaderAttribute] // RVA: 0x48E090 Offset: 0x48E191 VA: 0x48E090
public sealed class Terrain : Behaviour // TypeDefIndex: 7547
{
	// Properties
	public TerrainData terrainData { get; }
	[NativePropertyAttribute] // RVA: 0x48E650 Offset: 0x48E751 VA: 0x48E650
	public int lightmapIndex { get; }
	[NativePropertyAttribute] // RVA: 0x48E690 Offset: 0x48E791 VA: 0x48E690
	public Vector4 lightmapScaleOffset { get; }
	public bool allowAutoConnect { get; }
	public int groupingID { get; }
	[NativePropertyAttribute] // RVA: 0x48E6D0 Offset: 0x48E7D1 VA: 0x48E6D0
	public static Terrain[] activeTerrains { get; }

	// Methods

	// RVA: 0x3F047C0 Offset: 0x3F048C1 VA: 0x3F047C0
	public TerrainData get_terrainData() { }

	// RVA: 0x3F04810 Offset: 0x3F04911 VA: 0x3F04810
	public int get_lightmapIndex() { }

	// RVA: 0x3F04860 Offset: 0x3F04961 VA: 0x3F04860
	public Vector4 get_lightmapScaleOffset() { }

	// RVA: 0x3F04910 Offset: 0x3F04A11 VA: 0x3F04910
	public bool get_allowAutoConnect() { }

	// RVA: 0x3F04960 Offset: 0x3F04A61 VA: 0x3F04960
	public int get_groupingID() { }

	// RVA: 0x3F049B0 Offset: 0x3F04AB1 VA: 0x3F049B0
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x3F04A20 Offset: 0x3F04B21 VA: 0x3F04A20
	public static Terrain[] get_activeTerrains() { }

	// RVA: 0x3F04A60 Offset: 0x3F04B61 VA: 0x3F04A60
	public void .ctor() { }

	// RVA: 0x3F048C0 Offset: 0x3F049C1 VA: 0x3F048C0
	private void get_lightmapScaleOffset_Injected(out Vector4 ret) { }
}

