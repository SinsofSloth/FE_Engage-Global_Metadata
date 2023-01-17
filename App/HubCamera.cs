// Namespace: App
public class HubCamera : MonoBehaviour // TypeDefIndex: 10666
{
	// Fields
	[HeaderAttribute] // RVA: 0x294260 Offset: 0x294361 VA: 0x294260
	public AnimationCurve m_CameraTargetHeight; // 0x18
	public AnimationCurve m_OffsetCurveX; // 0x20
	public AnimationCurve m_DistanceCurve; // 0x28
	public AnimationCurve m_FovCurve; // 0x30
	public AnimationCurve m_TalkCurve; // 0x38
	public float m_NearClip; // 0x40
	public float m_RotateSpeed; // 0x44
	public float m_PitchSpeed; // 0x48
	public float m_RotateFollowSpeed; // 0x4C
	public float m_FollowRate; // 0x50
	public float m_PredictionLimitAngle; // 0x54
	public float m_SideOffsetIndex; // 0x58
	public static float m_DefaultAngleX; // 0x0
	private Camera m_Camera; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x2942A0 Offset: 0x2943A1 VA: 0x2942A0
	private bool <IsStop>k__BackingField; // 0x68
	public HubPlayerController PlayerController; // 0x70
	public float SideLength; // 0x78
	private InterpolatorFloat m_AngleX; // 0x80
	private InterpolatorVector3 m_TargetPosition; // 0x88
	private InterpolatorVector3 m_Position; // 0x90
	private InterpolatorRotation m_AngleY; // 0x98
	private InterpolatorFloat m_Distance; // 0xA0
	private InterpolatorFloat m_Fov; // 0xA8
	private InterpolatorFloat m_DistanceRatio; // 0xB0
	private InterpolatorFloat m_HeightRatio; // 0xB8
	private InterpolatorFloat m_TalkTail; // 0xC0
	private InterpolatorFloat m_SideOffset; // 0xC8
	private InterpolatorFloat m_PredictionPitch; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x2942B0 Offset: 0x2943B1 VA: 0x2942B0
	private readonly string <CameraRoateteParamName>k__BackingField; // 0xD8
	private int ObjectCollisionLayerMask; // 0xE0
	private int HeightLayerMask; // 0xE4
	private RaycastHit[] hresults; // 0xE8
	private RaycastHit[] rayhits; // 0xF0
	private Vector3 m_position; // 0xF8
	private float m_angleX; // 0x104
	private float m_angleY; // 0x108
	private float m_distance; // 0x10C
	private float m_zoom; // 0x110
	private float m_fov; // 0x114
	private float TalkCameraMoveTime; // 0x118
	private float TalkCameraReturnTime; // 0x11C
	private float NormalTalkDistanceRatio; // 0x120
	private float NormalTalkAngleX; // 0x124
	private float NormalTalkAngleY; // 0x128
	private float NormalTalkZoom; // 0x12C
	private float NormalTalkSeparateDistance; // 0x130
	private float NormalTalkOffsetY; // 0x134
	private float ShopTalkDistanceRatio; // 0x138
	private float ShopTalkAngleX; // 0x13C
	private float ShopTalkAngleY; // 0x140
	private float ShopTalkZoom; // 0x144
	private float ShopTalkSeparateDistance; // 0x148
	private float ShopTalkOffsetY; // 0x14C

	// Properties
	private bool IsStop { get; set; }
	public float AngleY { get; }
	public bool IsAdjustPosition { get; }
	public bool IsAdjustPositionSub { get; }
	public bool IsAdjustHeight { get; }
	public bool IsPredictionHeight { get; }
	public float PredictionHeightTime { get; }
	public bool IsMaximumZoom { get; }
	public float ZoomSpeed { get; }
	public float ZoomInterpolateTime { get; }
	public float ZoomDistanceTime { get; }
	public float CameraSpeed { get; }
	public float CameraRadius { get; }
	public float CameraPositionTime { get; }
	public float PitchParam { get; }
	public float PitchBlankParam { get; }
	public float PitchHeightParam { get; }
	private float ZoomParam { get; set; }
	private string CameraRoateteParamName { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0720 Offset: 0x2C0821 VA: 0x2C0720
	// RVA: 0x304C610 Offset: 0x304C711 VA: 0x304C610
	private bool get_IsStop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0730 Offset: 0x2C0831 VA: 0x2C0730
	// RVA: 0x304C620 Offset: 0x304C721 VA: 0x304C620
	private void set_IsStop(bool value) { }

	// RVA: 0x304C630 Offset: 0x304C731 VA: 0x304C630
	public float get_AngleY() { }

	// RVA: 0x304C690 Offset: 0x304C791 VA: 0x304C690
	public bool get_IsAdjustPosition() { }

	// RVA: 0x304C6E0 Offset: 0x304C7E1 VA: 0x304C6E0
	public bool get_IsAdjustPositionSub() { }

	// RVA: 0x304C730 Offset: 0x304C831 VA: 0x304C730
	public bool get_IsAdjustHeight() { }

	// RVA: 0x304C780 Offset: 0x304C881 VA: 0x304C780
	public bool get_IsPredictionHeight() { }

	// RVA: 0x304C7D0 Offset: 0x304C8D1 VA: 0x304C7D0
	public float get_PredictionHeightTime() { }

	// RVA: 0x304C820 Offset: 0x304C921 VA: 0x304C820
	public bool get_IsMaximumZoom() { }

	// RVA: 0x304C930 Offset: 0x304CA31 VA: 0x304C930
	public float get_ZoomSpeed() { }

	// RVA: 0x304C940 Offset: 0x304CA41 VA: 0x304C940
	public float get_ZoomInterpolateTime() { }

	// RVA: 0x304C990 Offset: 0x304CA91 VA: 0x304C990
	public float get_ZoomDistanceTime() { }

	// RVA: 0x304C9E0 Offset: 0x304CAE1 VA: 0x304C9E0
	public float get_CameraSpeed() { }

	// RVA: 0x304CA80 Offset: 0x304CB81 VA: 0x304CA80
	public float get_CameraRadius() { }

	// RVA: 0x304CAD0 Offset: 0x304CBD1 VA: 0x304CAD0
	public float get_CameraPositionTime() { }

	// RVA: 0x304CB20 Offset: 0x304CC21 VA: 0x304CB20
	public float get_PitchParam() { }

	// RVA: 0x304CB70 Offset: 0x304CC71 VA: 0x304CB70
	public float get_PitchBlankParam() { }

	// RVA: 0x304CBC0 Offset: 0x304CCC1 VA: 0x304CBC0
	public float get_PitchHeightParam() { }

	// RVA: 0x304C8B0 Offset: 0x304C9B1 VA: 0x304C8B0
	private float get_ZoomParam() { }

	// RVA: 0x304CC10 Offset: 0x304CD11 VA: 0x304CC10
	private void set_ZoomParam(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0740 Offset: 0x2C0841 VA: 0x2C0740
	// RVA: 0x304CCA0 Offset: 0x304CDA1 VA: 0x304CCA0
	private string get_CameraRoateteParamName() { }

	// RVA: 0x304CCB0 Offset: 0x304CDB1 VA: 0x304CCB0
	public void Reset(int zoomStep = 2) { }

	// RVA: 0x304D030 Offset: 0x304D131 VA: 0x304D030
	public void Start() { }

	// RVA: 0x304D610 Offset: 0x304D711 VA: 0x304D610
	private void Update() { }

	// RVA: 0x304E100 Offset: 0x304E201 VA: 0x304E100
	private void UpdateKey() { }

	// RVA: 0x3050DE0 Offset: 0x3050EE1 VA: 0x3050DE0
	private static int CompareNear(RaycastHit a, RaycastHit b) { }

	// RVA: 0x3050E20 Offset: 0x3050F21 VA: 0x3050E20
	private static Vector3 GetHitOffsetPos(Vector3 pos, Vector3 target, Vector3 dir, Vector3 offset, Vector3 hit) { }

	// RVA: 0x304FAC0 Offset: 0x304FBC1 VA: 0x304FAC0
	private void Commit() { }

	// RVA: 0x3050F30 Offset: 0x3051031 VA: 0x3050F30
	public void Reset(float y) { }

	// RVA: 0x3051010 Offset: 0x3051111 VA: 0x3051010
	public void SetAngleY(float y) { }

	// RVA: 0x3051030 Offset: 0x3051131 VA: 0x3051030
	public void SetAngleX(float x) { }

	// RVA: 0x304D5A0 Offset: 0x304D6A1 VA: 0x304D5A0
	public void Instant() { }

	// RVA: 0x3050D00 Offset: 0x3050E01 VA: 0x3050D00
	private static float GetParamTime(string name) { }

	// RVA: 0x3050D40 Offset: 0x3050E41 VA: 0x3050D40
	public float GetZoomRatio() { }

	// RVA: 0x304D4E0 Offset: 0x304D5E1 VA: 0x304D4E0
	public void SetZoom(float zoom) { }

	// RVA: 0x3051050 Offset: 0x3051151 VA: 0x3051050
	public bool CheckScroll() { }

	// RVA: 0x3051100 Offset: 0x3051201 VA: 0x3051100
	public bool CheckScrollStrictly() { }

	// RVA: 0x3051120 Offset: 0x3051221 VA: 0x3051120
	public void StartManualCamera_NormalTalk(Vector3 player, Vector3 target) { }

	// RVA: 0x3051340 Offset: 0x3051441 VA: 0x3051340
	public void StartManualCamera_FaceMainTalk(Vector3 player, Vector3 target, Vector3 forward) { }

	// RVA: 0x3051460 Offset: 0x3051561 VA: 0x3051460
	public void StartManualCamera_ShopTalk(Vector3 player, Vector3 target) { }

	// RVA: 0x3051170 Offset: 0x3051271 VA: 0x3051170
	public void StartManualCamera(Vector3 source, Vector3 target, float ratio, float angleX, float angleY, float zoom, float separateDistance, float offsetY, float moveTime) { }

	// RVA: 0x30514B0 Offset: 0x30515B1 VA: 0x30514B0
	public bool Intersect(Vector3 source, Vector3 target, float ratio, float angleX, float angleY, float zoom, float separateDistance, float offsetY) { }

	// RVA: 0x30516D0 Offset: 0x30517D1 VA: 0x30516D0
	public void ReturnManualCamera() { }

	// RVA: 0x3051730 Offset: 0x3051831 VA: 0x3051730
	public void ReturnManualCamera(float returnTime) { }

	// RVA: 0x3051790 Offset: 0x3051891 VA: 0x3051790
	public void .ctor() { }

	// RVA: 0x3051C20 Offset: 0x3051D21 VA: 0x3051C20
	private static void .cctor() { }
}

