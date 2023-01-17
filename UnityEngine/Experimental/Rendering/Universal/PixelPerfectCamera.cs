// Namespace: UnityEngine.Experimental.Rendering.Universal
[DisallowMultipleComponent] // RVA: 0x480260 Offset: 0x480361 VA: 0x480260
[AddComponentMenu] // RVA: 0x480260 Offset: 0x480361 VA: 0x480260
[RequireComponent] // RVA: 0x480260 Offset: 0x480361 VA: 0x480260
[MovedFromAttribute] // RVA: 0x480260 Offset: 0x480361 VA: 0x480260
[HelpURLAttribute] // RVA: 0x480260 Offset: 0x480361 VA: 0x480260
public class PixelPerfectCamera : MonoBehaviour, IPixelPerfectCamera // TypeDefIndex: 5485
{
	// Fields
	[SerializeField] // RVA: 0x483F40 Offset: 0x484041 VA: 0x483F40
	private int m_AssetsPPU; // 0x18
	[SerializeField] // RVA: 0x483F50 Offset: 0x484051 VA: 0x483F50
	private int m_RefResolutionX; // 0x1C
	[SerializeField] // RVA: 0x483F60 Offset: 0x484061 VA: 0x483F60
	private int m_RefResolutionY; // 0x20
	[SerializeField] // RVA: 0x483F70 Offset: 0x484071 VA: 0x483F70
	private bool m_UpscaleRT; // 0x24
	[SerializeField] // RVA: 0x483F80 Offset: 0x484081 VA: 0x483F80
	private bool m_PixelSnapping; // 0x25
	[SerializeField] // RVA: 0x483F90 Offset: 0x484091 VA: 0x483F90
	private bool m_CropFrameX; // 0x26
	[SerializeField] // RVA: 0x483FA0 Offset: 0x4840A1 VA: 0x483FA0
	private bool m_CropFrameY; // 0x27
	[SerializeField] // RVA: 0x483FB0 Offset: 0x4840B1 VA: 0x483FB0
	private bool m_StretchFill; // 0x28
	private Camera m_Camera; // 0x30
	private PixelPerfectCameraInternal m_Internal; // 0x38
	private bool m_CinemachineCompatibilityMode; // 0x40

	// Properties
	public int assetsPPU { get; set; }
	public int refResolutionX { get; set; }
	public int refResolutionY { get; set; }
	public bool upscaleRT { get; set; }
	public bool pixelSnapping { get; set; }
	public bool cropFrameX { get; set; }
	public bool cropFrameY { get; set; }
	public bool stretchFill { get; set; }
	public int pixelRatio { get; }
	internal bool isRunning { get; }
	internal FilterMode finalBlitFilterMode { get; }
	internal Vector2Int offscreenRTSize { get; }

	// Methods

	// RVA: 0x33624A0 Offset: 0x33625A1 VA: 0x33624A0 Slot: 4
	public int get_assetsPPU() { }

	// RVA: 0x33624B0 Offset: 0x33625B1 VA: 0x33624B0 Slot: 5
	public void set_assetsPPU(int value) { }

	// RVA: 0x33624C0 Offset: 0x33625C1 VA: 0x33624C0 Slot: 6
	public int get_refResolutionX() { }

	// RVA: 0x33624D0 Offset: 0x33625D1 VA: 0x33624D0 Slot: 7
	public void set_refResolutionX(int value) { }

	// RVA: 0x33624E0 Offset: 0x33625E1 VA: 0x33624E0 Slot: 8
	public int get_refResolutionY() { }

	// RVA: 0x33624F0 Offset: 0x33625F1 VA: 0x33624F0 Slot: 9
	public void set_refResolutionY(int value) { }

	// RVA: 0x3362500 Offset: 0x3362601 VA: 0x3362500 Slot: 10
	public bool get_upscaleRT() { }

	// RVA: 0x3362510 Offset: 0x3362611 VA: 0x3362510 Slot: 11
	public void set_upscaleRT(bool value) { }

	// RVA: 0x3362520 Offset: 0x3362621 VA: 0x3362520 Slot: 12
	public bool get_pixelSnapping() { }

	// RVA: 0x3362530 Offset: 0x3362631 VA: 0x3362530 Slot: 13
	public void set_pixelSnapping(bool value) { }

	// RVA: 0x3362540 Offset: 0x3362641 VA: 0x3362540 Slot: 14
	public bool get_cropFrameX() { }

	// RVA: 0x3362550 Offset: 0x3362651 VA: 0x3362550 Slot: 15
	public void set_cropFrameX(bool value) { }

	// RVA: 0x3362560 Offset: 0x3362661 VA: 0x3362560 Slot: 16
	public bool get_cropFrameY() { }

	// RVA: 0x3362570 Offset: 0x3362671 VA: 0x3362570 Slot: 17
	public void set_cropFrameY(bool value) { }

	// RVA: 0x3362580 Offset: 0x3362681 VA: 0x3362580 Slot: 18
	public bool get_stretchFill() { }

	// RVA: 0x3362590 Offset: 0x3362691 VA: 0x3362590 Slot: 19
	public void set_stretchFill(bool value) { }

	// RVA: 0x33625A0 Offset: 0x33626A1 VA: 0x33625A0
	public int get_pixelRatio() { }

	// RVA: 0x33625E0 Offset: 0x33626E1 VA: 0x33625E0
	public Vector3 RoundToPixel(Vector3 position) { }

	// RVA: 0x33627A0 Offset: 0x33628A1 VA: 0x33627A0
	public float CorrectCinemachineOrthoSize(float targetOrthoSize) { }

	// RVA: 0x3362A90 Offset: 0x3362B91 VA: 0x3362A90
	internal bool get_isRunning() { }

	// RVA: 0x3362AA0 Offset: 0x3362BA1 VA: 0x3362AA0
	internal FilterMode get_finalBlitFilterMode() { }

	// RVA: 0x3362AE0 Offset: 0x3362BE1 VA: 0x3362AE0
	internal Vector2Int get_offscreenRTSize() { }

	// RVA: 0x3362B30 Offset: 0x3362C31 VA: 0x3362B30
	private void PixelSnap() { }

	// RVA: 0x3362CC0 Offset: 0x3362DC1 VA: 0x3362CC0
	private void Awake() { }

	// RVA: 0x3362E20 Offset: 0x3362F21 VA: 0x3362E20
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x3363A40 Offset: 0x3363B41 VA: 0x3363A40
	private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x3363AE0 Offset: 0x3363BE1 VA: 0x3363AE0
	private void OnEnable() { }

	// RVA: 0x3363C00 Offset: 0x3363D01 VA: 0x3363C00
	internal void OnDisable() { }

	// RVA: 0x3363D70 Offset: 0x3363E71 VA: 0x3363D70
	public void .ctor() { }
}

