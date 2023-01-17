// Namespace: UnityEngine.Rendering
[UsedByNativeCodeAttribute] // RVA: 0x440CA0 Offset: 0x440DA1 VA: 0x440CA0
public struct CameraProperties : IEquatable<CameraProperties> // TypeDefIndex: 3933
{
	// Fields
	private Rect screenRect; // 0x0
	private Vector3 viewDir; // 0x10
	private float projectionNear; // 0x1C
	private float projectionFar; // 0x20
	private float cameraNear; // 0x24
	private float cameraFar; // 0x28
	private float cameraAspect; // 0x2C
	private Matrix4x4 cameraToWorld; // 0x30
	private Matrix4x4 actualWorldToClip; // 0x70
	private Matrix4x4 cameraClipToWorld; // 0xB0
	private Matrix4x4 cameraWorldToClip; // 0xF0
	private Matrix4x4 implicitProjection; // 0x130
	private Matrix4x4 stereoWorldToClipLeft; // 0x170
	private Matrix4x4 stereoWorldToClipRight; // 0x1B0
	private Matrix4x4 worldToCamera; // 0x1F0
	private Vector3 up; // 0x230
	private Vector3 right; // 0x23C
	private Vector3 transformDirection; // 0x248
	private Vector3 cameraEuler; // 0x254
	private Vector3 velocity; // 0x260
	private float farPlaneWorldSpaceLength; // 0x26C
	private uint rendererCount; // 0x270
	[FixedBufferAttribute] // RVA: 0x444B20 Offset: 0x444C21 VA: 0x444B20
	internal CameraProperties.<m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes; // 0x274
	[FixedBufferAttribute] // RVA: 0x444B90 Offset: 0x444C91 VA: 0x444B90
	internal CameraProperties.<m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes; // 0x2D4
	private float baseFarDistance; // 0x334
	private Vector3 shadowCullCenter; // 0x338
	[FixedBufferAttribute] // RVA: 0x444C00 Offset: 0x444D01 VA: 0x444C00
	internal CameraProperties.<layerCullDistances>e__FixedBuffer layerCullDistances; // 0x344
	private int layerCullSpherical; // 0x3C4
	private CoreCameraValues coreCameraValues; // 0x3C8
	private uint cameraType; // 0x3D4
	private int projectionIsOblique; // 0x3D8
	private int isImplicitProjectionMatrix; // 0x3DC

	// Methods

	// RVA: 0x2F136E0 Offset: 0x2F137E1 VA: 0x2F136E0
	public Plane GetShadowCullingPlane(int index) { }

	// RVA: 0x2F137D0 Offset: 0x2F138D1 VA: 0x2F137D0
	public Plane GetCameraCullingPlane(int index) { }

	// RVA: 0x2F138C0 Offset: 0x2F139C1 VA: 0x2F138C0 Slot: 4
	public bool Equals(CameraProperties other) { }

	// RVA: 0x2F14600 Offset: 0x2F14701 VA: 0x2F14600 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F146A0 Offset: 0x2F147A1 VA: 0x2F146A0 Slot: 2
	public override int GetHashCode() { }
}

