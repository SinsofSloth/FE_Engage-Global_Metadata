// Namespace: App.Water
[RequireComponent] // RVA: 0x2795D0 Offset: 0x2796D1 VA: 0x2795D0
[DisallowMultipleComponent] // RVA: 0x2795D0 Offset: 0x2796D1 VA: 0x2795D0
public class ReflectionCamera : MonoBehaviour // TypeDefIndex: 14100
{
	// Fields
	public short m_id; // 0x18
	public Camera m_camera; // 0x20
	private Camera m_cameraOriginal; // 0x28
	public Vector2 renderTextureSize; // 0x30
	public float farClip; // 0x38
	public float clipPlaneOffset; // 0x3C

	// Methods

	// RVA: 0x2525730 Offset: 0x2525831 VA: 0x2525730
	public void CameraSetting(Camera cam) { }

	// RVA: 0x2525AD0 Offset: 0x2525BD1 VA: 0x2525AD0
	public void SetRenderTextureSize(float width, float height) { }

	// RVA: 0x2525AE0 Offset: 0x2525BE1 VA: 0x2525AE0
	public void CreateTexture() { }

	// RVA: 0x2525BF0 Offset: 0x2525CF1 VA: 0x2525BF0
	public void RenderReflection(Transform transformMesh) { }

	// RVA: 0x2525CC0 Offset: 0x2525DC1 VA: 0x2525CC0
	private void SetCameraTransform(Transform transformMesh) { }

	// RVA: 0x2526400 Offset: 0x2526501 VA: 0x2526400
	private Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane) { }

	// RVA: 0x2526000 Offset: 0x2526101 VA: 0x2526000
	private Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane) { }

	// RVA: 0x2526600 Offset: 0x2526701 VA: 0x2526600
	private float Sgn(float a) { }

	// RVA: 0x25262D0 Offset: 0x25263D1 VA: 0x25262D0
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) { }

	// RVA: 0x2526620 Offset: 0x2526721 VA: 0x2526620
	public void .ctor() { }
}

