// Namespace: UnityEngine.Experimental.Rendering.Universal
[Serializable]
internal class PixelPerfectCameraInternal : ISerializationCallbackReceiver // TypeDefIndex: 5487
{
	// Fields
	private IPixelPerfectCamera m_Component; // 0x10
	private PixelPerfectCamera m_SerializableComponent; // 0x18
	internal float originalOrthoSize; // 0x20
	internal bool hasPostProcessLayer; // 0x24
	internal bool cropFrameXAndY; // 0x25
	internal bool cropFrameXOrY; // 0x26
	internal bool useStretchFill; // 0x27
	internal int zoom; // 0x28
	internal bool useOffscreenRT; // 0x2C
	internal int offscreenRTWidth; // 0x30
	internal int offscreenRTHeight; // 0x34
	internal Rect pixelRect; // 0x38
	internal float orthoSize; // 0x48
	internal float unitsPerPixel; // 0x4C
	internal int cinemachineVCamZoom; // 0x50

	// Methods

	// RVA: 0x3362DB0 Offset: 0x3362EB1 VA: 0x3362DB0
	internal void .ctor(IPixelPerfectCamera component) { }

	// RVA: 0x3363D90 Offset: 0x3363E91 VA: 0x3363D90 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x3363E20 Offset: 0x3363F21 VA: 0x3363E20 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x3362FD0 Offset: 0x33630D1 VA: 0x3362FD0
	internal void CalculateCameraProperties(int screenWidth, int screenHeight) { }

	// RVA: 0x33636B0 Offset: 0x33637B1 VA: 0x33636B0
	internal Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight) { }

	// RVA: 0x33627C0 Offset: 0x33628C1 VA: 0x33627C0
	internal float CorrectCinemachineOrthoSize(float targetOrthoSize) { }
}

