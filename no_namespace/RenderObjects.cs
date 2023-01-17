// Namespace: 
[Serializable]
public class RenderObjects.RenderObjectsSettings // TypeDefIndex: 5501
{
	// Fields
	public string passTag; // 0x10
	public RenderPassEvent Event; // 0x18
	public RenderObjects.FilterSettings filterSettings; // 0x20
	public Material overrideMaterial; // 0x28
	public int overrideMaterialPassIndex; // 0x30
	public bool overrideDepthState; // 0x34
	public CompareFunction depthCompareFunction; // 0x38
	public bool enableWrite; // 0x3C
	public StencilStateData stencilSettings; // 0x40
	public RenderObjects.CustomCameraSettings cameraSettings; // 0x48

	// Methods

	// RVA: 0x2FA4C70 Offset: 0x2FA4D71 VA: 0x2FA4C70
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class RenderObjects.FilterSettings // TypeDefIndex: 5502
{
	// Fields
	public RenderQueueType RenderQueueType; // 0x10
	public LayerMask LayerMask; // 0x14
	public string[] PassNames; // 0x18

	// Methods

	// RVA: 0x2FA4C30 Offset: 0x2FA4D31 VA: 0x2FA4C30
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class RenderObjects.CustomCameraSettings // TypeDefIndex: 5503
{
	// Fields
	public bool overrideCamera; // 0x10
	public bool restoreCamera; // 0x11
	public Vector4 offset; // 0x14
	public float cameraFieldOfView; // 0x24

	// Methods

	// RVA: 0x2FA4C10 Offset: 0x2FA4D11 VA: 0x2FA4C10
	public void .ctor() { }
}

