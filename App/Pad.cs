// Namespace: App
public class Pad : SingletonClass<Pad> // TypeDefIndex: 9152
{
	// Fields
	public static readonly NpadButton A; // 0x0
	public static readonly NpadButton B; // 0x8
	public static readonly NpadButton X; // 0x10
	public static readonly NpadButton Y; // 0x18
	public static readonly NpadButton StickL; // 0x20
	public static readonly NpadButton StickR; // 0x28
	public static readonly NpadButton L; // 0x30
	public static readonly NpadButton R; // 0x38
	public static readonly NpadButton ZL; // 0x40
	public static readonly NpadButton ZR; // 0x48
	public static readonly NpadButton Plus; // 0x50
	public static readonly NpadButton Minus; // 0x58
	public static readonly NpadButton Left; // 0x60
	public static readonly NpadButton Up; // 0x68
	public static readonly NpadButton Right; // 0x70
	public static readonly NpadButton Down; // 0x78
	public static readonly NpadButton StickLLeft; // 0x80
	public static readonly NpadButton StickLUp; // 0x88
	public static readonly NpadButton StickLRight; // 0x90
	public static readonly NpadButton StickLDown; // 0x98
	public static readonly NpadButton StickRLeft; // 0xA0
	public static readonly NpadButton StickRUp; // 0xA8
	public static readonly NpadButton StickRRight; // 0xB0
	public static readonly NpadButton StickRDown; // 0xB8
	public static readonly NpadButton LeftSL; // 0xC0
	public static readonly NpadButton LeftSR; // 0xC8
	public static readonly NpadButton RightSL; // 0xD0
	public static readonly NpadButton RightSR; // 0xD8
	public static readonly NpadButton AnyButton; // 0xE0
	public static readonly NpadButton AnyCross; // 0xE8
	public static readonly NpadButton AnyLeft; // 0xF0
	public static readonly NpadButton AnyUp; // 0xF8
	public static readonly NpadButton AnyRight; // 0x100
	public static readonly NpadButton AnyDown; // 0x108
	public static readonly NpadButton SpeedUp; // 0x110
	private NpadId m_NpadId; // 0x1C
	private NpadStyle m_NpadStyle; // 0x20
	private NpadState m_NpadState; // 0x28
	private NpadButton m_OldButtons; // 0x58
	public const int REPAT_FIRST = 10;
	public const int REPAT_CONTINUE = 4;
	private NpadButton m_RepeatButtons; // 0x60
	private int m_RepeatCount; // 0x68
	private int m_HoldCount; // 0x6C
	private Pad.Mode m_Mode; // 0x70
	private VibrationManager m_Vibration; // 0x78
	private ControllerSupportApplet m_ControllerSupportApplet; // 0x80
	private GyroMnager m_GyroMnager; // 0x88

	// Methods

	// RVA: 0x2363AB0 Offset: 0x2363BB1 VA: 0x2363AB0
	public void .ctor() { }

	// RVA: 0x2363C60 Offset: 0x2363D61 VA: 0x2363C60
	public Pad.Mode GetMode() { }

	// RVA: 0x2363C70 Offset: 0x2363D71 VA: 0x2363C70
	private Pad.Mode GetInputMode() { }

	// RVA: 0x2363C80 Offset: 0x2363D81 VA: 0x2363C80
	private int GetStickValue(string key) { }

	// RVA: 0x2363CD0 Offset: 0x2363DD1 VA: 0x2363CD0
	private void CommitStickButton(ref NpadState state, float margin = 0.75) { }

	// RVA: 0x2363DE0 Offset: 0x2363EE1 VA: 0x2363DE0 Slot: 8
	protected override void OnUpdate() { }

	// RVA: 0x2364090 Offset: 0x2364191 VA: 0x2364090
	private void UpdateDebugPad() { }

	// RVA: 0x23640A0 Offset: 0x23641A1 VA: 0x23640A0
	private void UpdateExclusive(NpadButton button) { }

	// RVA: 0x23640C0 Offset: 0x23641C1 VA: 0x23640C0
	private void UpdateExclusive() { }

	// RVA: 0x2363F90 Offset: 0x2364091 VA: 0x2363F90
	private bool CheckPadState() { }

	// RVA: 0x2364240 Offset: 0x2364341 VA: 0x2364240
	public static bool IsButton(NpadButton buttons) { }

	// RVA: 0x23642F0 Offset: 0x23643F1 VA: 0x23642F0
	public static bool IsTrigger(NpadButton buttons) { }

	// RVA: 0x23643E0 Offset: 0x23644E1 VA: 0x23643E0
	public static bool IsRepeat(NpadButton buttons) { }

	// RVA: 0x2364590 Offset: 0x2364691 VA: 0x2364590
	public static bool IsRelease(NpadButton buttons) { }

	// RVA: 0x2364680 Offset: 0x2364781 VA: 0x2364680
	public static float GetStickLX() { }

	// RVA: 0x2364750 Offset: 0x2364851 VA: 0x2364750
	public static float GetStickLY() { }

	// RVA: 0x2364820 Offset: 0x2364921 VA: 0x2364820
	public static float GetStickRX() { }

	// RVA: 0x23648F0 Offset: 0x23649F1 VA: 0x23648F0
	public static float GetStickRY() { }

	// RVA: 0x23649C0 Offset: 0x2364AC1 VA: 0x23649C0
	public static float GetStickLX(float allowance) { }

	// RVA: 0x2364B30 Offset: 0x2364C31 VA: 0x2364B30
	public static float GetStickLY(float allowance) { }

	// RVA: 0x2364CA0 Offset: 0x2364DA1 VA: 0x2364CA0
	public static float GetStickRX(float allowance) { }

	// RVA: 0x2364E10 Offset: 0x2364F11 VA: 0x2364E10
	public static float GetStickRY(float allowance) { }

	// RVA: 0x2364F80 Offset: 0x2365081 VA: 0x2364F80
	private static float GetAllowance(float value, float allowance) { }

	// RVA: 0x2364FC0 Offset: 0x23650C1 VA: 0x2364FC0
	public static VibrationManager Vibration() { }

	// RVA: 0x2365060 Offset: 0x2365161 VA: 0x2365060
	public static GyroMnager Gyro() { }

	// RVA: 0x2365100 Offset: 0x2365201 VA: 0x2365100
	public static int GetStepCount() { }

	// RVA: 0x2365170 Offset: 0x2365271 VA: 0x2365170
	public static int GetHoldCount() { }

	// RVA: 0x2365210 Offset: 0x2365311 VA: 0x2365210
	public static void SetEnableControllerSupport(bool isEnable) { }

	// RVA: 0x2365320 Offset: 0x2365421 VA: 0x2365320
	public static bool IsDebugTrigger() { }

	// RVA: 0x2365330 Offset: 0x2365431 VA: 0x2365330
	public static bool IsDebugSkip() { }

	// RVA: 0x2365340 Offset: 0x2365441 VA: 0x2365340
	public static void DebugRecordStart() { }

	// RVA: 0x2365350 Offset: 0x2365451 VA: 0x2365350
	public static void DebugRecordStop() { }

	// RVA: 0x2365360 Offset: 0x2365461 VA: 0x2365360
	public static void DebugRecordPlay() { }

	// RVA: 0x2365370 Offset: 0x2365471 VA: 0x2365370
	public static bool IsDebugRecording() { }

	// RVA: 0x2365380 Offset: 0x2365481 VA: 0x2365380
	public static void DebugHookButton(int buttons) { }

	// RVA: 0x2365390 Offset: 0x2365491 VA: 0x2365390
	public static void DebugHookStickL(float x, float y) { }

	// RVA: 0x23653A0 Offset: 0x23654A1 VA: 0x23653A0
	public static void DebugHookStickR(float x, float y) { }

	// RVA: 0x23653B0 Offset: 0x23654B1 VA: 0x23653B0
	private static void .cctor() { }
}

