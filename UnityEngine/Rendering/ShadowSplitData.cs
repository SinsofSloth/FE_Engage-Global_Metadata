// Namespace: UnityEngine.Rendering
[UsedByNativeCodeAttribute] // RVA: 0x441010 Offset: 0x441111 VA: 0x441010
public struct ShadowSplitData : IEquatable<ShadowSplitData> // TypeDefIndex: 3961
{
	// Fields
	public static readonly int maximumCullingPlaneCount; // 0x0
	private int m_CullingPlaneCount; // 0x0
	[FixedBufferAttribute] // RVA: 0x444F40 Offset: 0x445041 VA: 0x444F40
	internal ShadowSplitData.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x4
	private Vector4 m_CullingSphere; // 0xA4
	private float m_ShadowCascadeBlendCullingFactor; // 0xB4
	private float m_CullingNearPlane; // 0xB8

	// Properties
	public int cullingPlaneCount { get; }
	public Vector4 cullingSphere { get; set; }
	public float shadowCascadeBlendCullingFactor { set; }

	// Methods

	// RVA: 0x31EB920 Offset: 0x31EBA21 VA: 0x31EB920
	public int get_cullingPlaneCount() { }

	// RVA: 0x31EB930 Offset: 0x31EBA31 VA: 0x31EB930
	public Vector4 get_cullingSphere() { }

	// RVA: 0x31EB940 Offset: 0x31EBA41 VA: 0x31EB940
	public void set_cullingSphere(Vector4 value) { }

	// RVA: 0x31EB480 Offset: 0x31EB581 VA: 0x31EB480
	public void set_shadowCascadeBlendCullingFactor(float value) { }

	// RVA: 0x31EB960 Offset: 0x31EBA61 VA: 0x31EB960
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x31EB630 Offset: 0x31EB731 VA: 0x31EB630 Slot: 4
	public bool Equals(ShadowSplitData other) { }

	// RVA: 0x31EBA70 Offset: 0x31EBB71 VA: 0x31EBA70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31EB8F0 Offset: 0x31EB9F1 VA: 0x31EB8F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31EBB10 Offset: 0x31EBC11 VA: 0x31EBB10
	private static void .cctor() { }
}

