// Namespace: App
public abstract class GmapCamera : SingletonMonoBehaviour<GmapCamera> // TypeDefIndex: 10260
{
	// Fields
	public GameObject m_SphereCenter; // 0x20
	public float m_DefaultAngleX; // 0x28
	public float m_DefaultDistance; // 0x2C
	public AnimationCurve m_AngleCurve; // 0x30
	public AnimationCurve m_DistanceCurve; // 0x38
	public float m_ZoomSpeed; // 0x40
	private Camera m_Camera; // 0x48
	private float[] m_ZoomParam; // 0x50
	private float m_ZoomDir; // 0x58
	private InterpolatorVector3 m_Position; // 0x60
	private InterpolatorFloat m_AngleX; // 0x68
	private InterpolatorFloat m_Distance; // 0x70
	private bool m_IsRStickZoom; // 0x78
	private float m_PrevZoom; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x28DC80 Offset: 0x28DD81 VA: 0x28DC80
	private bool <IsCameraTracking>k__BackingField; // 0x80

	// Properties
	private float ZoomDistance { get; set; }
	public Vector3 Position { get; }
	public Vector3 CameraPosition { get; }
	public bool IsCameraTracking { get; set; }

	// Methods

	// RVA: 0x28E4DA0 Offset: 0x28E4EA1 VA: 0x28E4DA0
	private float get_ZoomDistance() { }

	// RVA: 0x28E4E20 Offset: 0x28E4F21 VA: 0x28E4E20
	private void set_ZoomDistance(float value) { }

	// RVA: 0x28E4EB0 Offset: 0x28E4FB1 VA: 0x28E4EB0
	public Vector3 get_Position() { }

	// RVA: 0x28E4F10 Offset: 0x28E5011 VA: 0x28E4F10
	public Vector3 get_CameraPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD830 Offset: 0x2BD931 VA: 0x2BD830
	// RVA: 0x28E4F30 Offset: 0x28E5031 VA: 0x28E4F30
	public void set_IsCameraTracking(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD840 Offset: 0x2BD941 VA: 0x2BD840
	// RVA: 0x28E4F40 Offset: 0x28E5041 VA: 0x28E4F40
	public bool get_IsCameraTracking() { }

	// RVA: 0x28E4F50 Offset: 0x28E5051 VA: 0x28E4F50
	private void Start() { }

	// RVA: 0x28E52C0 Offset: 0x28E53C1 VA: 0x28E52C0
	private void Update() { }

	// RVA: 0x28E5900 Offset: 0x28E5A01 VA: 0x28E5900
	public void Tick() { }

	// RVA: 0x28E5BA0 Offset: 0x28E5CA1 VA: 0x28E5BA0
	public void UpdateKey() { }

	// RVA: 0x28E5700 Offset: 0x28E5801 VA: 0x28E5700
	private void Commit() { }

	// RVA: 0x28E5270 Offset: 0x28E5371 VA: 0x28E5270
	public void Instant() { }

	// RVA: 0x28E6C70 Offset: 0x28E6D71 VA: 0x28E6C70
	public void ActiveCamera() { }

	// RVA: 0x28E63E0 Offset: 0x28E64E1 VA: 0x28E63E0
	private GmapCamera.DistanceMode GetCameraDistanceMode() { }

	// RVA: 0x28E6620 Offset: 0x28E6721 VA: 0x28E6620
	private GmapCamera.DistanceMode GetBackMode(GmapCamera.DistanceMode mode) { }

	// RVA: 0x28E66D0 Offset: 0x28E67D1 VA: 0x28E66D0
	private GmapCamera.DistanceMode GetZoomMode(GmapCamera.DistanceMode mode) { }

	// RVA: 0x28E6500 Offset: 0x28E6601 VA: 0x28E6500
	private GmapCamera.DistanceMode GetNextMode(GmapCamera.DistanceMode mode, float dir) { }

	// RVA: 0x28E6C80 Offset: 0x28E6D81 VA: 0x28E6C80
	private static float GetParamTime(string name) { }

	// RVA: 0x28E6CC0 Offset: 0x28E6DC1 VA: 0x28E6CC0
	private static Rect GetMoveableRect() { }

	// RVA: 0x28E6D10 Offset: 0x28E6E11 VA: 0x28E6D10
	public static bool IsMovableArea(Vector3 position, out GmapSequence.GmapFreeCameraSequence.DirFlagField outAreaFlag, GmapSequence.GmapFreeCameraSequence.DirFlagField ignoreFlag) { }

	// RVA: 0x28E6D60 Offset: 0x28E6E61 VA: 0x28E6D60
	public static GmapSequence.GmapFreeCameraSequence.DirFlagField GetDisableDir(Vector3 position, GmapSequence.GmapFreeCameraSequence.DirFlagField ignoreFlag) { }

	// RVA: 0x28E59A0 Offset: 0x28E5AA1 VA: 0x28E59A0
	public Vector3 SetPosition(Vector3 position, bool isFreeCamera = False) { }

	// RVA: 0x28E69E0 Offset: 0x28E6AE1 VA: 0x28E69E0
	public void Zoom(float value) { }

	// RVA: 0x28E6780 Offset: 0x28E6881 VA: 0x28E6780
	private void SetZoomParam(int index) { }

	// RVA: 0x28E5050 Offset: 0x28E5151 VA: 0x28E5050
	private void SetZoomDistance(float distance) { }

	// RVA: 0x28E6FC0 Offset: 0x28E70C1 VA: 0x28E6FC0
	public void SetLookOver(Vector3 lookOverCameraPosition) { }

	// RVA: 0x28E7160 Offset: 0x28E7261 VA: 0x28E7160
	public void CancelLookOver(Vector3 returnPosition) { }

	// RVA: 0x28E7350 Offset: 0x28E7451 VA: 0x28E7350
	public bool CheckScroll() { }

	// RVA: 0x28E7400 Offset: 0x28E7501 VA: 0x28E7400
	public bool CheckScrollStrictly() { }

	// RVA: 0x28E74A0 Offset: 0x28E75A1 VA: 0x28E74A0
	protected void .ctor() { }
}

