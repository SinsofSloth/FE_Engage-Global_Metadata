// Namespace: App.Water
[RequireComponent] // RVA: 0x279540 Offset: 0x279641 VA: 0x279540
[DisallowMultipleComponent] // RVA: 0x279540 Offset: 0x279641 VA: 0x279540
[ExecuteInEditMode] // RVA: 0x279540 Offset: 0x279641 VA: 0x279540
public abstract class PlanarReflectionV2 : MonoBehaviour // TypeDefIndex: 14099
{
	// Fields
	public ReflectionManager m_ReflectionManager; // 0x18
	public Material m_SharedMaterial; // 0x20
	public short reflectionCameraNumber; // 0x28
	private const string reflectionSampler = "_ReflectionTex";

	// Methods

	// RVA: 0x29D18F0 Offset: 0x29D19F1 VA: 0x29D18F0
	private void Start() { }

	// RVA: 0x29D1C20 Offset: 0x29D1D21 VA: 0x29D1C20
	public void WaterTileBeingRendered(Transform tr, Camera currentCam) { }

	// RVA: 0x29D1E40 Offset: 0x29D1F41 VA: 0x29D1E40
	private RenderTexture GetReflectionTexture() { }

	// RVA: 0x29D1D90 Offset: 0x29D1E91 VA: 0x29D1D90
	private bool RenderReflection(Transform tr, Camera currentCam) { }

	// RVA: 0x29D1A10 Offset: 0x29D1B11 VA: 0x29D1A10
	private ReflectionManager GetReflectionManager() { }

	// RVA: 0x29D1E60 Offset: 0x29D1F61 VA: 0x29D1E60
	protected void .ctor() { }
}

