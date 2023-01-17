// Namespace: UnityEngine.Rendering
[UsedByNativeCodeAttribute] // RVA: 0x440D80 Offset: 0x440E81 VA: 0x440D80
public struct ScriptableCullingParameters : IEquatable<ScriptableCullingParameters> // TypeDefIndex: 3937
{
	// Fields
	private int m_IsOrthographic; // 0x0
	private LODParameters m_LODParameters; // 0x4
	public static readonly int maximumCullingPlaneCount; // 0x0
	[FixedBufferAttribute] // RVA: 0x444C70 Offset: 0x444D71 VA: 0x444C70
	internal ScriptableCullingParameters.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x20
	private int m_CullingPlaneCount; // 0xC0
	private uint m_CullingMask; // 0xC4
	private ulong m_SceneMask; // 0xC8
	public static readonly int layerCount; // 0x4
	[FixedBufferAttribute] // RVA: 0x444CE0 Offset: 0x444DE1 VA: 0x444CE0
	internal ScriptableCullingParameters.<m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances; // 0xD0
	private int m_LayerCull; // 0x150
	private Matrix4x4 m_CullingMatrix; // 0x154
	private Vector3 m_Origin; // 0x194
	private float m_ShadowDistance; // 0x1A0
	private CullingOptions m_CullingOptions; // 0x1A4
	private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria; // 0x1A8
	private CameraProperties m_CameraProperties; // 0x1AC
	private float m_AccurateOcclusionThreshold; // 0x58C
	private int m_MaximumPortalCullingJobs; // 0x590
	private Matrix4x4 m_StereoViewMatrix; // 0x594
	private Matrix4x4 m_StereoProjectionMatrix; // 0x5D4
	private float m_StereoSeparationDistance; // 0x614
	private int m_maximumVisibleLights; // 0x618

	// Properties
	public int maximumVisibleLights { set; }
	public int cullingPlaneCount { get; }
	public bool isOrthographic { set; }
	public float shadowDistance { set; }
	public CullingOptions cullingOptions { get; set; }
	public Matrix4x4 stereoViewMatrix { set; }
	public Matrix4x4 stereoProjectionMatrix { get; set; }

	// Methods

	// RVA: 0x31E3C60 Offset: 0x31E3D61 VA: 0x31E3C60
	public void set_maximumVisibleLights(int value) { }

	// RVA: 0x31E3C70 Offset: 0x31E3D71 VA: 0x31E3C70
	public int get_cullingPlaneCount() { }

	// RVA: 0x31E3C80 Offset: 0x31E3D81 VA: 0x31E3C80
	public void set_isOrthographic(bool value) { }

	// RVA: 0x31E3D00 Offset: 0x31E3E01 VA: 0x31E3D00
	public void set_shadowDistance(float value) { }

	// RVA: 0x31E3D10 Offset: 0x31E3E11 VA: 0x31E3D10
	public CullingOptions get_cullingOptions() { }

	// RVA: 0x31E3D20 Offset: 0x31E3E21 VA: 0x31E3D20
	public void set_cullingOptions(CullingOptions value) { }

	// RVA: 0x31E3D30 Offset: 0x31E3E31 VA: 0x31E3D30
	public void set_stereoViewMatrix(Matrix4x4 value) { }

	// RVA: 0x31E3D50 Offset: 0x31E3E51 VA: 0x31E3D50
	public Matrix4x4 get_stereoProjectionMatrix() { }

	// RVA: 0x31E3D80 Offset: 0x31E3E81 VA: 0x31E3D80
	public void set_stereoProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x31E3DA0 Offset: 0x31E3EA1 VA: 0x31E3DA0
	public float GetLayerCullingDistance(int layerIndex) { }

	// RVA: 0x31E3E80 Offset: 0x31E3F81 VA: 0x31E3E80
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x31E3F70 Offset: 0x31E4071 VA: 0x31E3F70 Slot: 4
	public bool Equals(ScriptableCullingParameters other) { }

	// RVA: 0x31E4320 Offset: 0x31E4421 VA: 0x31E4320 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31E43C0 Offset: 0x31E44C1 VA: 0x31E43C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31E4510 Offset: 0x31E4611 VA: 0x31E4510
	private static void .cctor() { }
}

