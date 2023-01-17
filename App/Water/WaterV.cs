// Namespace: App.Water
public abstract class WaterV2 : MonoBehaviour // TypeDefIndex: 14107
{
	// Fields
	public WaterV2.WaterMode waterMode; // 0x18
	public bool disablePixelLights; // 0x1C
	public int textureSize; // 0x20
	public float clipPlaneOffset; // 0x24
	public LayerMask reflectLayers; // 0x28
	public LayerMask refractLayers; // 0x2C
	private Dictionary<Camera, Camera> m_ReflectionCameras; // 0x30
	private Dictionary<Camera, Camera> m_RefractionCameras; // 0x38
	private RenderTexture m_ReflectionTexture; // 0x40
	private RenderTexture m_RefractionTexture; // 0x48
	private WaterV2.WaterMode m_HardwareWaterSupport; // 0x50
	private int m_OldReflectionTextureSize; // 0x54
	private int m_OldRefractionTextureSize; // 0x58
	private static bool s_InsideWater; // 0x0

	// Methods

	// RVA: 0x26C7A80 Offset: 0x26C7B81 VA: 0x26C7A80
	public void OnWillRenderObject() { }

	// RVA: 0x26C95C0 Offset: 0x26C96C1 VA: 0x26C95C0
	private void OnDisable() { }

	// RVA: 0x26C9940 Offset: 0x26C9A41 VA: 0x26C9940
	private void Update() { }

	// RVA: 0x26C8F80 Offset: 0x26C9081 VA: 0x26C8F80
	private void UpdateCameraModes(Camera src, Camera dest) { }

	// RVA: 0x26C8640 Offset: 0x26C8741 VA: 0x26C8640
	private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera) { }

	// RVA: 0x26C8620 Offset: 0x26C8721 VA: 0x26C8620
	private WaterV2.WaterMode GetWaterMode() { }

	// RVA: 0x26C8480 Offset: 0x26C8581 VA: 0x26C8480
	private WaterV2.WaterMode FindHardwareWaterSupport() { }

	// RVA: 0x26C9490 Offset: 0x26C9591 VA: 0x26C9490
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) { }

	// RVA: 0x26C91E0 Offset: 0x26C92E1 VA: 0x26C91E0
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane) { }

	// RVA: 0x26C9C20 Offset: 0x26C9D21 VA: 0x26C9C20
	protected void .ctor() { }
}

