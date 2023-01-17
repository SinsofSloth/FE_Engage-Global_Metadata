// Namespace: App
public class HubAccessoryRoomCamera : MonoBehaviour // TypeDefIndex: 10659
{
	// Fields
	[HeaderAttribute] // RVA: 0x293360 Offset: 0x293461 VA: 0x293360
	[HeaderAttribute] // RVA: 0x293360 Offset: 0x293461 VA: 0x293360
	[HeaderAttribute] // RVA: 0x293360 Offset: 0x293461 VA: 0x293360
	[HeaderAttribute] // RVA: 0x293360 Offset: 0x293461 VA: 0x293360
	public float RotateSpeed; // 0x18
	[HeaderAttribute] // RVA: 0x293410 Offset: 0x293511 VA: 0x293410
	public float RotateAccel; // 0x1C
	[HeaderAttribute] // RVA: 0x293450 Offset: 0x293551 VA: 0x293450
	public float RotateBrake; // 0x20
	[HeaderAttribute] // RVA: 0x293490 Offset: 0x293591 VA: 0x293490
	[HeaderAttribute] // RVA: 0x293490 Offset: 0x293591 VA: 0x293490
	[HeaderAttribute] // RVA: 0x293490 Offset: 0x293591 VA: 0x293490
	[HeaderAttribute] // RVA: 0x293490 Offset: 0x293591 VA: 0x293490
	public float CamSpeedBody; // 0x24
	[HeaderAttribute] // RVA: 0x293540 Offset: 0x293641 VA: 0x293540
	public float CamSpeedAccs; // 0x28
	[HeaderAttribute] // RVA: 0x293580 Offset: 0x293681 VA: 0x293580
	[HeaderAttribute] // RVA: 0x293580 Offset: 0x293681 VA: 0x293580
	[HeaderAttribute] // RVA: 0x293580 Offset: 0x293681 VA: 0x293580
	[HeaderAttribute] // RVA: 0x293580 Offset: 0x293681 VA: 0x293580
	public float MinDistBody; // 0x2C
	[HeaderAttribute] // RVA: 0x293630 Offset: 0x293731 VA: 0x293630
	public float MaxDistBody; // 0x30
	[HeaderAttribute] // RVA: 0x293670 Offset: 0x293771 VA: 0x293670
	public float MinDistAccs; // 0x34
	[HeaderAttribute] // RVA: 0x2936B0 Offset: 0x2937B1 VA: 0x2936B0
	public float MaxDistAccs; // 0x38
	[HeaderAttribute] // RVA: 0x2936F0 Offset: 0x2937F1 VA: 0x2936F0
	[HeaderAttribute] // RVA: 0x2936F0 Offset: 0x2937F1 VA: 0x2936F0
	[HeaderAttribute] // RVA: 0x2936F0 Offset: 0x2937F1 VA: 0x2936F0
	[HeaderAttribute] // RVA: 0x2936F0 Offset: 0x2937F1 VA: 0x2936F0
	public float MinFoVBody; // 0x3C
	[HeaderAttribute] // RVA: 0x2937A0 Offset: 0x2938A1 VA: 0x2937A0
	public float MaxFoVBody; // 0x40
	[HeaderAttribute] // RVA: 0x2937E0 Offset: 0x2938E1 VA: 0x2937E0
	public float MinFoVAccs; // 0x44
	[HeaderAttribute] // RVA: 0x293820 Offset: 0x293921 VA: 0x293820
	public float MaxFoVAccs; // 0x48
	[HeaderAttribute] // RVA: 0x293860 Offset: 0x293961 VA: 0x293860
	[HeaderAttribute] // RVA: 0x293860 Offset: 0x293961 VA: 0x293860
	[HeaderAttribute] // RVA: 0x293860 Offset: 0x293961 VA: 0x293860
	[HeaderAttribute] // RVA: 0x293860 Offset: 0x293961 VA: 0x293860
	public float HeightFixerBody; // 0x4C
	[HeaderAttribute] // RVA: 0x293910 Offset: 0x293A11 VA: 0x293910
	public float FarthestBodyHeight; // 0x50
	[HeaderAttribute] // RVA: 0x293950 Offset: 0x293A51 VA: 0x293950
	public float HeightFixerBack; // 0x54
	private const float HeightFixerHead = 0.25;
	private const float HeightFixerFace = 0.1;
	[HeaderAttribute] // RVA: 0x293990 Offset: 0x293A91 VA: 0x293990
	[HeaderAttribute] // RVA: 0x293990 Offset: 0x293A91 VA: 0x293990
	[HeaderAttribute] // RVA: 0x293990 Offset: 0x293A91 VA: 0x293990
	[HeaderAttribute] // RVA: 0x293990 Offset: 0x293A91 VA: 0x293990
	public float TiltHigh; // 0x58
	[HeaderAttribute] // RVA: 0x293A40 Offset: 0x293B41 VA: 0x293A40
	public float TiltLow; // 0x5C
	[HeaderAttribute] // RVA: 0x293A80 Offset: 0x293B81 VA: 0x293A80
	public float TiltHighMax; // 0x60
	[HeaderAttribute] // RVA: 0x293AC0 Offset: 0x293BC1 VA: 0x293AC0
	public float TiltLowMax; // 0x64
	[HeaderAttribute] // RVA: 0x293B00 Offset: 0x293C01 VA: 0x293B00
	public float TiltSpeed; // 0x68
	[HeaderAttribute] // RVA: 0x293B40 Offset: 0x293C41 VA: 0x293B40
	public float TiltBackSpeedHand; // 0x6C
	[HeaderAttribute] // RVA: 0x293B80 Offset: 0x293C81 VA: 0x293B80
	public float TiltBackSpeedAuto; // 0x70
	[HeaderAttribute] // RVA: 0x293BC0 Offset: 0x293CC1 VA: 0x293BC0
	[HeaderAttribute] // RVA: 0x293BC0 Offset: 0x293CC1 VA: 0x293BC0
	[HeaderAttribute] // RVA: 0x293BC0 Offset: 0x293CC1 VA: 0x293BC0
	[HeaderAttribute] // RVA: 0x293BC0 Offset: 0x293CC1 VA: 0x293BC0
	public float CameraChangeSpeed; // 0x74
	[HeaderAttribute] // RVA: 0x293C70 Offset: 0x293D71 VA: 0x293C70
	public float CameraChangeCurve; // 0x78
	[HeaderAttribute] // RVA: 0x293CB0 Offset: 0x293DB1 VA: 0x293CB0
	[HeaderAttribute] // RVA: 0x293CB0 Offset: 0x293DB1 VA: 0x293CB0
	[HeaderAttribute] // RVA: 0x293CB0 Offset: 0x293DB1 VA: 0x293CB0
	[HeaderAttribute] // RVA: 0x293CB0 Offset: 0x293DB1 VA: 0x293CB0
	public float SlipSlideSizeTop; // 0x7C
	[HeaderAttribute] // RVA: 0x293D60 Offset: 0x293E61 VA: 0x293D60
	public float SlipSlideSizeSelect; // 0x80
	[HeaderAttribute] // RVA: 0x293DA0 Offset: 0x293EA1 VA: 0x293DA0
	public float SlipSlideSizePreview; // 0x84
	[HeaderAttribute] // RVA: 0x293DE0 Offset: 0x293EE1 VA: 0x293DE0
	public float SlipSlideSpeed; // 0x88
	[HeaderAttribute] // RVA: 0x293E20 Offset: 0x293F21 VA: 0x293E20
	[HeaderAttribute] // RVA: 0x293E20 Offset: 0x293F21 VA: 0x293E20
	[HeaderAttribute] // RVA: 0x293E20 Offset: 0x293F21 VA: 0x293E20
	public float CameraBoost; // 0x8C
	[HeaderAttribute] // RVA: 0x293EB0 Offset: 0x293FB1 VA: 0x293EB0
	[HeaderAttribute] // RVA: 0x293EB0 Offset: 0x293FB1 VA: 0x293EB0
	[HeaderAttribute] // RVA: 0x293EB0 Offset: 0x293FB1 VA: 0x293EB0
	[HeaderAttribute] // RVA: 0x293EB0 Offset: 0x293FB1 VA: 0x293EB0
	public float EyesIKWeight; // 0x90
	[HeaderAttribute] // RVA: 0x293F60 Offset: 0x294061 VA: 0x293F60
	public float HeadIKWeight; // 0x94
	[HeaderAttribute] // RVA: 0x293FA0 Offset: 0x2940A1 VA: 0x293FA0
	public float BodyIKWeight; // 0x98
	[HeaderAttribute] // RVA: 0x293FE0 Offset: 0x2940E1 VA: 0x293FE0
	public float LookChangeSpeed; // 0x9C
	[HeaderAttribute] // RVA: 0x294020 Offset: 0x294121 VA: 0x294020
	public float LookChangeDegree; // 0xA0
	private int m_SelectingBackId; // 0xA4
	private bool m_IsBackUpdating; // 0xA8
	private ResourceHandle m_BGHandle; // 0xB0
	private GameObject m_LookTarget; // 0xB8
	private LookAtIK m_LookAtIKEyes; // 0xC0
	private LookAtIK m_LookAtIKBody; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x294060 Offset: 0x294161 VA: 0x294060
	private Character <Character>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x294070 Offset: 0x294171 VA: 0x294070
	private string <PID>k__BackingField; // 0xD8
	private Nullable<AccessoryData.Kinds> m_Target; // 0xE0
	private HubAccessoryRoom.ViewMode m_ViewMode; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x294080 Offset: 0x294181 VA: 0x294080
	private bool <IsAccs>k__BackingField; // 0xEC
	[CompilerGeneratedAttribute] // RVA: 0x294090 Offset: 0x294191 VA: 0x294090
	private bool <IsCharacterChanged>k__BackingField; // 0xED
	[CompilerGeneratedAttribute] // RVA: 0x2940A0 Offset: 0x2941A1 VA: 0x2940A0
	private bool <IsTargetChanged>k__BackingField; // 0xEE
	[CompilerGeneratedAttribute] // RVA: 0x2940B0 Offset: 0x2941B1 VA: 0x2940B0
	private bool <IsPreviewChanged>k__BackingField; // 0xEF
	[CompilerGeneratedAttribute] // RVA: 0x2940C0 Offset: 0x2941C1 VA: 0x2940C0
	private float <CameraTilt>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x2940D0 Offset: 0x2941D1 VA: 0x2940D0
	private float <SlipSlide>k__BackingField; // 0xF4
	private HubAccessoryRoomCamera.CameraPositionParam m_CameraPos; // 0xF8
	private HubAccessoryRoomCamera.CameraPositionParam m_CameraDiff; // 0x110
	private float m_CameraDiffRate; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x2940E0 Offset: 0x2941E1 VA: 0x2940E0
	private bool <IsLookCam>k__BackingField; // 0x12C
	private float m_LookCamRate; // 0x130
	private Vector3 m_LastTargetPosNearest; // 0x134
	private Vector3 m_LastTargetPosFarthest; // 0x140
	[HeaderAttribute] // RVA: 0x2940F0 Offset: 0x2941F1 VA: 0x2940F0
	[HeaderAttribute] // RVA: 0x2940F0 Offset: 0x2941F1 VA: 0x2940F0
	[HeaderAttribute] // RVA: 0x2940F0 Offset: 0x2941F1 VA: 0x2940F0
	public HubAccessoryRoomCamera.BackgroundSettings[] Backgrounds; // 0x150
	public Light MainLight; // 0x158
	private float m_LastRotSpeed; // 0x160

	// Properties
	private float MinDist { get; }
	private float MaxDist { get; }
	private float MinFoV { get; }
	private float MaxFoV { get; }
	private Character Character { get; set; }
	private string PID { get; set; }
	public Nullable<AccessoryData.Kinds> Target { get; set; }
	public HubAccessoryRoom.ViewMode ViewMode { get; set; }
	public bool IsAccs { get; set; }
	public bool IsCharacterChanged { get; set; }
	public bool IsTargetChanged { get; set; }
	public bool IsPreviewChanged { get; set; }
	public float CameraTilt { get; set; }
	public float SlipSlide { get; set; }
	private bool IsLookCam { get; set; }
	private Vector3 TargetPosNearest { get; }
	private Vector3 TargetPosFarthest { get; }
	[TupleElementNamesAttribute] // RVA: 0x2D4EB0 Offset: 0x2D4FB1 VA: 0x2D4EB0
	private ValueTuple<float, float> StickInput { get; }

	// Methods

	// RVA: 0x3044DB0 Offset: 0x3044EB1 VA: 0x3044DB0
	private float get_MinDist() { }

	// RVA: 0x3044DD0 Offset: 0x3044ED1 VA: 0x3044DD0
	private float get_MaxDist() { }

	// RVA: 0x3044DF0 Offset: 0x3044EF1 VA: 0x3044DF0
	private float get_MinFoV() { }

	// RVA: 0x3044E10 Offset: 0x3044F11 VA: 0x3044E10
	private float get_MaxFoV() { }

	// RVA: 0x3044E30 Offset: 0x3044F31 VA: 0x3044E30
	private void Awake() { }

	// RVA: 0x30453C0 Offset: 0x30454C1 VA: 0x30453C0
	private void LateUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C03D0 Offset: 0x2C04D1 VA: 0x2C03D0
	// RVA: 0x3046810 Offset: 0x3046911 VA: 0x3046810
	private Character get_Character() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C03E0 Offset: 0x2C04E1 VA: 0x2C03E0
	// RVA: 0x3046820 Offset: 0x3046921 VA: 0x3046820
	private void set_Character(Character value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C03F0 Offset: 0x2C04F1 VA: 0x2C03F0
	// RVA: 0x3046830 Offset: 0x3046931 VA: 0x3046830
	private string get_PID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0400 Offset: 0x2C0501 VA: 0x2C0400
	// RVA: 0x3046840 Offset: 0x3046941 VA: 0x3046840
	private void set_PID(string value) { }

	// RVA: 0x3046850 Offset: 0x3046951 VA: 0x3046850
	public void SetCharacter(Character chr, string pid) { }

	// RVA: 0x3046F90 Offset: 0x3047091 VA: 0x3046F90
	public Nullable<AccessoryData.Kinds> get_Target() { }

	// RVA: 0x3045060 Offset: 0x3045161 VA: 0x3045060
	public void set_Target(Nullable<AccessoryData.Kinds> value) { }

	// RVA: 0x3046FA0 Offset: 0x30470A1 VA: 0x3046FA0
	public HubAccessoryRoom.ViewMode get_ViewMode() { }

	// RVA: 0x3045030 Offset: 0x3045131 VA: 0x3045030
	public void set_ViewMode(HubAccessoryRoom.ViewMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0410 Offset: 0x2C0511 VA: 0x2C0410
	// RVA: 0x3046FB0 Offset: 0x30470B1 VA: 0x3046FB0
	public bool get_IsAccs() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0420 Offset: 0x2C0521 VA: 0x2C0420
	// RVA: 0x3046FC0 Offset: 0x30470C1 VA: 0x3046FC0
	public void set_IsAccs(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0430 Offset: 0x2C0531 VA: 0x2C0430
	// RVA: 0x3046FD0 Offset: 0x30470D1 VA: 0x3046FD0
	public bool get_IsCharacterChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0440 Offset: 0x2C0541 VA: 0x2C0440
	// RVA: 0x3046FE0 Offset: 0x30470E1 VA: 0x3046FE0
	public void set_IsCharacterChanged(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0450 Offset: 0x2C0551 VA: 0x2C0450
	// RVA: 0x3046FF0 Offset: 0x30470F1 VA: 0x3046FF0
	public bool get_IsTargetChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0460 Offset: 0x2C0561 VA: 0x2C0460
	// RVA: 0x3047000 Offset: 0x3047101 VA: 0x3047000
	public void set_IsTargetChanged(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0470 Offset: 0x2C0571 VA: 0x2C0470
	// RVA: 0x3047010 Offset: 0x3047111 VA: 0x3047010
	public bool get_IsPreviewChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0480 Offset: 0x2C0581 VA: 0x2C0480
	// RVA: 0x3047020 Offset: 0x3047121 VA: 0x3047020
	public void set_IsPreviewChanged(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0490 Offset: 0x2C0591 VA: 0x2C0490
	// RVA: 0x3047030 Offset: 0x3047131 VA: 0x3047030
	public float get_CameraTilt() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C04A0 Offset: 0x2C05A1 VA: 0x2C04A0
	// RVA: 0x3047040 Offset: 0x3047141 VA: 0x3047040
	public void set_CameraTilt(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C04B0 Offset: 0x2C05B1 VA: 0x2C04B0
	// RVA: 0x3047050 Offset: 0x3047151 VA: 0x3047050
	public float get_SlipSlide() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C04C0 Offset: 0x2C05C1 VA: 0x2C04C0
	// RVA: 0x3047060 Offset: 0x3047161 VA: 0x3047060
	public void set_SlipSlide(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C04D0 Offset: 0x2C05D1 VA: 0x2C04D0
	// RVA: 0x3047070 Offset: 0x3047171 VA: 0x3047070
	private bool get_IsLookCam() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C04E0 Offset: 0x2C05E1 VA: 0x2C04E0
	// RVA: 0x3047080 Offset: 0x3047181 VA: 0x3047080
	private void set_IsLookCam(bool value) { }

	// RVA: 0x3047090 Offset: 0x3047191 VA: 0x3047090
	private Vector3 get_TargetPosNearest() { }

	// RVA: 0x30472D0 Offset: 0x30473D1 VA: 0x30472D0
	private Vector3 get_TargetPosFarthest() { }

	// RVA: 0x30450F0 Offset: 0x30451F1 VA: 0x30450F0
	private void InitPos(bool force = False) { }

	// RVA: 0x3045440 Offset: 0x3045541 VA: 0x3045440
	private void UpdateBack() { }

	// RVA: 0x30457D0 Offset: 0x30458D1 VA: 0x30457D0
	private void LoadInput() { }

	// RVA: 0x30474F0 Offset: 0x30475F1 VA: 0x30474F0
	private ValueTuple<float, float> get_StickInput() { }

	// RVA: 0x30461F0 Offset: 0x30462F1 VA: 0x30461F0
	private void UpdateCameraPos() { }

	// RVA: 0x3046230 Offset: 0x3046331 VA: 0x3046230
	private void SetCameraPos() { }

	// RVA: 0x3047A20 Offset: 0x3047B21 VA: 0x3047A20
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C04F0 Offset: 0x2C05F1 VA: 0x2C04F0
	// RVA: 0x3047150 Offset: 0x3047251 VA: 0x3047150
	private Vector3 <get_TargetPosNearest>g__TryGet|106_0(Character chara, int jointId, float fixer) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0500 Offset: 0x2C0601 VA: 0x2C0500
	// RVA: 0x3047400 Offset: 0x3047501 VA: 0x3047400
	private Vector3 <get_TargetPosFarthest>g__TryGet|109_0(Transform t, float fixer) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0510 Offset: 0x2C0611 VA: 0x2C0510
	// RVA: 0x3047A70 Offset: 0x3047B71 VA: 0x3047A70
	private void <UpdateBack>b__113_0(Material material) { }
}

