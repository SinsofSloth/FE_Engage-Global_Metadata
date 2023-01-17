// Namespace: App
public class MapCursor : SingletonClass<MapCursor> // TypeDefIndex: 11921
{
	// Fields
	private const float MapCursorMoveOffset = 0.975;
	private const int MOVE_WAIT_FRAME = 8;
	private const int MOVE_CENTER_FRAME = 12;
	private Vector3 m_Pos; // 0x1C
	private Vector3 m_OldPos; // 0x28
	private Vector3 m_OrigPos; // 0x34
	private Vector3 m_Rotate; // 0x40
	private Vector3 m_Move; // 0x4C
	private Vector3 m_EnterPos; // 0x58
	private int m_MoveCount; // 0x64
	private bool m_IsRotateXSoundPlaying; // 0x68
	private static MapCursor.CursorTopType m_CursorTop; // 0x0
	private static MapCursor.AnimType m_CursorTopAnim; // 0x4
	private static MapCursor.AnimType m_CursorBottomAnim; // 0x8
	private Transform m_CursorIconBill; // 0x70
	private int m_DistanceDir; // 0x78
	private int m_AnalogCount; // 0x7C
	private int m_CenterCount; // 0x80
	private float m_DistanceScale; // 0x84
	private GameConfig.MapCursorMoveTyep m_MapCursorMoveType; // 0x88
	private bool m_IsLockMoveType; // 0x8C
	private GameObject m_CursorTopObj; // 0x90
	private GameObject m_CursorBottomObj; // 0x98
	private MapPointerAnimManager m_CursorTopMgr; // 0xA0
	private MapCursorAnimManager m_CursorBottomMgr; // 0xA8
	private static MapPointerLocatorRoot m_MapPointerLocatorRoot; // 0x10
	private static MapCursorLocatorRoot m_MapCursorLocatorRoot; // 0x18
	private InterpolatorVector3 m_PositionTop; // 0xB0
	private InterpolatorVector3 m_PositionBottom; // 0xB8
	private MapMind.Type m_CursorMind; // 0xC0
	private Color m_Color; // 0xC4
	private MapCursor.FlagField m_Flags; // 0xD8

	// Properties
	public Color Color { get; }
	public static bool IsLockMoveType { get; set; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x2C98EE0 Offset: 0x2C98FE1 VA: 0x2C98EE0
	public static MapMind.Type GetCursorMind() { }

	// RVA: 0x2C98F80 Offset: 0x2C99081 VA: 0x2C98F80
	public static void SetCursorMind(MapMind.Type mind) { }

	// RVA: 0x2C99160 Offset: 0x2C99261 VA: 0x2C99160
	public static float GetCameraTilt(MapCursor.DistanceMode mode) { }

	// RVA: 0x2C99240 Offset: 0x2C99341 VA: 0x2C99240
	private static float GetCameraTiltClamp(MapCursor.DistanceMode mode) { }

	// RVA: 0x2C994A0 Offset: 0x2C995A1 VA: 0x2C994A0
	private static float GetCameraTilt(float ratio) { }

	// RVA: 0x2C99640 Offset: 0x2C99741 VA: 0x2C99640
	private static float GetCameraTiltMin() { }

	// RVA: 0x2C996E0 Offset: 0x2C997E1 VA: 0x2C996E0
	private static float GetCameraTiltMax() { }

	// RVA: 0x2C8CF80 Offset: 0x2C8D081 VA: 0x2C8CF80
	public static float GetCameraDistance(MapCursor.DistanceMode mode) { }

	// RVA: 0x2C992B0 Offset: 0x2C993B1 VA: 0x2C992B0
	private static float GetCameraTiltClamp(float value, bool isMargin = True) { }

	// RVA: 0x2C99780 Offset: 0x2C99881 VA: 0x2C99780
	private static float GetCameraTiltRate(float tilt) { }

	// RVA: 0x2C99920 Offset: 0x2C99A21 VA: 0x2C99920
	private static MapCursor.DistanceMode GetCameraDistanceMode(float tilt) { }

	// RVA: 0x2C99A10 Offset: 0x2C99B11 VA: 0x2C99A10
	private float GetCameraDistance() { }

	// RVA: 0x2C99B30 Offset: 0x2C99C31 VA: 0x2C99B30
	private Vector3 GetCameraRotate() { }

	// RVA: 0x2C99BC0 Offset: 0x2C99CC1 VA: 0x2C99BC0
	private MapCursor.DistanceMode GetBackMode(MapCursor.DistanceMode mode) { }

	// RVA: 0x2C99C70 Offset: 0x2C99D71 VA: 0x2C99C70
	private MapCursor.DistanceMode GetZoomMode(MapCursor.DistanceMode mode) { }

	// RVA: 0x2C99D20 Offset: 0x2C99E21 VA: 0x2C99D20
	private MapCursor.DistanceMode GetNextMode(MapCursor.DistanceMode mode, int dir) { }

	// RVA: 0x2C99E40 Offset: 0x2C99F41 VA: 0x2C99E40
	public void .ctor() { }

	// RVA: 0x2C9AAA0 Offset: 0x2C9ABA1 VA: 0x2C9AAA0 Slot: 7
	protected override void OnTick() { }

	// RVA: 0x2C9AAB0 Offset: 0x2C9ABB1 VA: 0x2C9AAB0 Slot: 8
	protected override void OnUpdate() { }

	// RVA: 0x2C9FC30 Offset: 0x2C9FD31 VA: 0x2C9FC30
	private void ToggleCursorMoveSize() { }

	// RVA: 0x2C9B0F0 Offset: 0x2C9B1F1 VA: 0x2C9B0F0
	private Vector3 CalcCursorTopPos() { }

	// RVA: 0x2C9CAC0 Offset: 0x2C9CBC1 VA: 0x2C9CAC0
	private Vector3 CalcCursorBottomPos() { }

	// RVA: 0x2CA1550 Offset: 0x2CA1651 VA: 0x2CA1550
	public static bool IsChangeCursorTop() { }

	// RVA: 0x2CA16B0 Offset: 0x2CA17B1 VA: 0x2CA16B0
	public static bool IsChangeCursorBottom() { }

	// RVA: 0x2C9F160 Offset: 0x2C9F261 VA: 0x2C9F160
	private float GetCursorTime(Vector3 prev, Vector3 next) { }

	// RVA: 0x2C9F210 Offset: 0x2C9F311 VA: 0x2C9F210
	private float GetCursorSpeed() { }

	// RVA: 0x2CA17F0 Offset: 0x2CA18F1 VA: 0x2CA17F0
	private float GetMovePos(float prev, float next, float speed) { }

	// RVA: 0x2C9F370 Offset: 0x2C9F471 VA: 0x2C9F370
	private Vector3 GetMovePos(Vector3 prev, Vector3 next, float speed) { }

	// RVA: 0x2CA1840 Offset: 0x2CA1941 VA: 0x2CA1840
	private float GetDigitalMove(NpadButton button) { }

	// RVA: 0x2CA1C60 Offset: 0x2CA1D61 VA: 0x2CA1C60
	public static void SetCursorTop(MapMind.Type mind) { }

	// RVA: 0x2CA1EA0 Offset: 0x2CA1FA1 VA: 0x2CA1EA0
	public static void ApplyCursorTop(MapCursor.CursorTopType newCursorTop) { }

	// RVA: 0x2CA20C0 Offset: 0x2CA21C1 VA: 0x2CA20C0
	private static Transform GetMapPointerTransform(MapCursor.CursorTopType type) { }

	// RVA: 0x2CA2230 Offset: 0x2CA2331 VA: 0x2CA2230
	private static void SetActive(GameObject gameObject, bool value) { }

	// RVA: 0x2C990F0 Offset: 0x2C991F1 VA: 0x2C990F0
	public static void PlayCursorAnim() { }

	// RVA: 0x2CA2280 Offset: 0x2CA2381 VA: 0x2CA2280
	public static void PlayCursorTopAnim() { }

	// RVA: 0x2CA2450 Offset: 0x2CA2551 VA: 0x2CA2450
	public static void PlayCursorBottomAnim() { }

	// RVA: 0x2CA27E0 Offset: 0x2CA28E1 VA: 0x2CA27E0
	private void TryBorderSound(Vector3 old, Vector3 pos) { }

	// RVA: 0x2CA2C00 Offset: 0x2CA2D01 VA: 0x2CA2C00
	private void CalcDigitalMove() { }

	// RVA: 0x2CA3040 Offset: 0x2CA3141 VA: 0x2CA3040
	private void CalcAnalogMove() { }

	// RVA: 0x2CA5390 Offset: 0x2CA5491 VA: 0x2CA5390
	private void UpdateEnterPos() { }

	// RVA: 0x2CA5750 Offset: 0x2CA5851 VA: 0x2CA5750
	public void ResetEnterPos() { }

	// RVA: 0x2CA5940 Offset: 0x2CA5A41 VA: 0x2CA5940
	private void AdjustPosition() { }

	// RVA: 0x2CA8130 Offset: 0x2CA8231 VA: 0x2CA8130
	private void TickInputReset() { }

	// RVA: 0x2CA8140 Offset: 0x2CA8241 VA: 0x2CA8140
	private void TickInputMove(bool isTrigger) { }

	// RVA: 0x2CA8640 Offset: 0x2CA8741 VA: 0x2CA8640
	private void TryPlayCameraMoveSe() { }

	// RVA: 0x2CA87B0 Offset: 0x2CA88B1 VA: 0x2CA87B0
	private void TryStopCameraMoveSe() { }

	// RVA: 0x2CA88E0 Offset: 0x2CA89E1 VA: 0x2CA88E0
	private void TickInputRotate() { }

	// RVA: 0x2CA9AA0 Offset: 0x2CA9BA1 VA: 0x2CA9AA0
	private void TickInputDanger() { }

	// RVA: 0x2CA9FC0 Offset: 0x2CAA0C1 VA: 0x2CA9FC0
	public void CommitCamera() { }

	// RVA: 0x2CA8460 Offset: 0x2CA8561 VA: 0x2CA8460
	private void CommitCameraPosition(float speed = 0) { }

	// RVA: 0x2CA9A00 Offset: 0x2CA9B01 VA: 0x2CA9A00
	private void CommitCameraRotate() { }

	// RVA: 0x2CA8300 Offset: 0x2CA8401 VA: 0x2CA8300
	public void UpdatePosition() { }

	// RVA: 0x2CA9FF0 Offset: 0x2CAA0F1 VA: 0x2CA9FF0
	private void ClampPosition(ref Vector3 pos) { }

	// RVA: 0x2CAAE10 Offset: 0x2CAAF11 VA: 0x2CAAE10
	public static void Setup() { }

	// RVA: 0x2CA0D80 Offset: 0x2CA0E81 VA: 0x2CA0D80
	private static Unit GetCursorUnit() { }

	// RVA: 0x2CAB330 Offset: 0x2CAB431 VA: 0x2CAB330
	public static int GetX() { }

	// RVA: 0x2CAB470 Offset: 0x2CAB571 VA: 0x2CAB470
	public static int GetZ() { }

	// RVA: 0x2CAB5B0 Offset: 0x2CAB6B1 VA: 0x2CAB5B0
	public static int GetNoClampX() { }

	// RVA: 0x2CAB6D0 Offset: 0x2CAB7D1 VA: 0x2CAB6D0
	public static int GetNoClampZ() { }

	// RVA: 0x2CAB7F0 Offset: 0x2CAB8F1 VA: 0x2CAB7F0
	public static void Set(int x, int z, float speed = 0, bool isUpdateEnterPos = True) { }

	// RVA: 0x2CAC5F0 Offset: 0x2CAC6F1 VA: 0x2CAC5F0
	public static void Set(Unit unit, float speed = 0, bool isUpdateEnterPos = True) { }

	// RVA: 0x2CAC510 Offset: 0x2CAC611 VA: 0x2CAC510
	public static void Set(Vector3 pos, float speed = 0, bool isUpdateEnterPos = True) { }

	// RVA: 0x2CAE100 Offset: 0x2CAE201 VA: 0x2CAE100
	public static bool TrySet(Vector3 pos, float speed = 0, bool isUpdateEnterPos = True) { }

	// RVA: 0x2CAE330 Offset: 0x2CAE431 VA: 0x2CAE330
	public static void Instant() { }

	// RVA: 0x2CAE470 Offset: 0x2CAE571 VA: 0x2CAE470
	public void SetColor(Color color) { }

	// RVA: 0x2CAE640 Offset: 0x2CAE741 VA: 0x2CAE640
	public void SetColor() { }

	// RVA: 0x2CAEEE0 Offset: 0x2CAEFE1 VA: 0x2CAEEE0
	public Color get_Color() { }

	// RVA: 0x2CAEEF0 Offset: 0x2CAEFF1 VA: 0x2CAEEF0
	public static void Show() { }

	// RVA: 0x2CAF1C0 Offset: 0x2CAF2C1 VA: 0x2CAF1C0
	public static void Hide() { }

	// RVA: 0x2CAF250 Offset: 0x2CAF351 VA: 0x2CAF250
	public static bool IsVisible() { }

	// RVA: 0x2CAF0B0 Offset: 0x2CAF1B1 VA: 0x2CAF0B0
	public static void SetVisible(bool enable) { }

	// RVA: 0x2CAE410 Offset: 0x2CAE511 VA: 0x2CAE410
	private void InstantImpl() { }

	// RVA: 0x2CADE00 Offset: 0x2CADF01 VA: 0x2CADE00
	private void SetImpl(Vector3 pos, float speed, bool isUpdateEnterPos) { }

	// RVA: 0x2CAB1D0 Offset: 0x2CAB2D1 VA: 0x2CAB1D0
	private void UpdateVisible() { }

	// RVA: 0x2CA8730 Offset: 0x2CA8831 VA: 0x2CA8730
	private static void PlayCameraMoveSe() { }

	// RVA: 0x2CA8820 Offset: 0x2CA8921 VA: 0x2CA8820
	private static void StopCameraMoveSe() { }

	// RVA: 0x2CAF320 Offset: 0x2CAF421 VA: 0x2CAF320
	public static MapCursor.DistanceMode GetDistanceMode() { }

	// RVA: 0x2CAF420 Offset: 0x2CAF521 VA: 0x2CAF420
	public static void SetDistanceMode(MapCursor.DistanceMode mode) { }

	// RVA: 0x2CAF580 Offset: 0x2CAF681 VA: 0x2CAF580
	public static void SetDistanceScale(float scale) { }

	// RVA: 0x2CAF650 Offset: 0x2CAF751 VA: 0x2CAF650
	public static float GetDistanceRateForSound() { }

	// RVA: 0x2CA1490 Offset: 0x2CA1591 VA: 0x2CA1490
	public static GameConfig.MapCursorMoveTyep GetMapCursorMoveType() { }

	// RVA: 0x2CAF870 Offset: 0x2CAF971 VA: 0x2CAF870
	public static void SetMapCursorMoveType(GameConfig.MapCursorMoveTyep type) { }

	// RVA: 0x2CA13E0 Offset: 0x2CA14E1 VA: 0x2CA13E0
	public static bool get_IsLockMoveType() { }

	// RVA: 0x2CAF920 Offset: 0x2CAFA21 VA: 0x2CAF920
	public static void set_IsLockMoveType(bool value) { }

	// RVA: 0x2CAF9D0 Offset: 0x2CAFAD1 VA: 0x2CAF9D0
	public static Vector3 GetRotate() { }

	// RVA: 0x2CAE270 Offset: 0x2CAE371 VA: 0x2CAE270
	public static Vector3 GetPos() { }

	// RVA: 0x2CAFA90 Offset: 0x2CAFB91 VA: 0x2CAFA90
	public static Vector3 GetEnterPos() { }

	// RVA: 0x2CAFB50 Offset: 0x2CAFC51 VA: 0x2CAFB50
	public static void SetEnterPos(Vector3 pos) { }

	// RVA: 0x2CAFC10 Offset: 0x2CAFD11 VA: 0x2CAFC10
	public static void Tick() { }

	// RVA: 0x2CAFC20 Offset: 0x2CAFD21 VA: 0x2CAFC20
	public static void TickMove(bool isTrigger = False) { }

	// RVA: 0x2CAFCF0 Offset: 0x2CAFDF1 VA: 0x2CAFCF0
	public static void TickRotate() { }

	// RVA: 0x2CAFF50 Offset: 0x2CB0051 VA: 0x2CAFF50 Slot: 9
	protected override void OnBind() { }

	// RVA: 0x2CAFF60 Offset: 0x2CB0061 VA: 0x2CAFF60 Slot: 10
	protected override void OnUnbind() { }

	// RVA: 0x2CAFF70 Offset: 0x2CB0071 VA: 0x2CAFF70 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x2CAFF80 Offset: 0x2CB0081 VA: 0x2CAFF80 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x2CB0020 Offset: 0x2CB0121 VA: 0x2CB0020 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x2CB0310 Offset: 0x2CB0411 VA: 0x2CB0310
	private static void .cctor() { }
}

