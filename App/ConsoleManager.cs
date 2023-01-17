// Namespace: App
public class ConsoleManager : SingletonProcInst<ConsoleManager> // TypeDefIndex: 8911
{
	// Fields
	private GameObject m_GameObject; // 0x78
	private static float s_ScaleX; // 0x0
	private static float s_ScaleY; // 0x4
	private static float s_Orient; // 0x8
	private static object s_LockObject; // 0x10
	private static List<string> s_Logs; // 0x18
	private static GameParam.Holder s_ShowLog; // 0x20

	// Properties
	public static float ScaleX { get; }
	public static float ScaleY { get; }
	public static float Orient { get; }
	public static List<string> Logs { get; }

	// Methods

	// RVA: 0x23B72D0 Offset: 0x23B73D1 VA: 0x23B72D0
	public static float get_ScaleX() { }

	// RVA: 0x23B7340 Offset: 0x23B7441 VA: 0x23B7340
	public static float get_ScaleY() { }

	// RVA: 0x23B73B0 Offset: 0x23B74B1 VA: 0x23B73B0
	public static float get_Orient() { }

	// RVA: 0x23B7420 Offset: 0x23B7521 VA: 0x23B7420
	public static List<string> get_Logs() { }

	// RVA: 0x23B7490 Offset: 0x23B7591 VA: 0x23B7490 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x23B7530 Offset: 0x23B7631 VA: 0x23B7530 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x23B75A0 Offset: 0x23B76A1 VA: 0x23B75A0
	protected void Tick() { }

	[ConditionalAttribute] // RVA: 0x2ADAA0 Offset: 0x2ADBA1 VA: 0x2ADAA0
	// RVA: 0x23B81F0 Offset: 0x23B82F1 VA: 0x23B81F0
	private static void Print(string str) { }

	[ConditionalAttribute] // RVA: 0x2ADAE0 Offset: 0x2ADBE1 VA: 0x2ADAE0
	// RVA: 0x23B8200 Offset: 0x23B8301 VA: 0x23B8200
	public static void Clear() { }

	[ConditionalAttribute] // RVA: 0x2ADB20 Offset: 0x2ADC21 VA: 0x2ADB20
	// RVA: 0x23B8350 Offset: 0x23B8451 VA: 0x23B8350
	public static void Open() { }

	[ConditionalAttribute] // RVA: 0x2ADB60 Offset: 0x2ADC61 VA: 0x2ADB60
	// RVA: 0x23B8680 Offset: 0x23B8781 VA: 0x23B8680
	public static void Close() { }

	// RVA: 0x23B7E80 Offset: 0x23B7F81 VA: 0x23B7E80
	public static bool IsButton() { }

	// RVA: 0x23B7D00 Offset: 0x23B7E01 VA: 0x23B7D00
	public static bool IsTrigger() { }

	// RVA: 0x23B8700 Offset: 0x23B8801 VA: 0x23B8700
	private static void OnLogMessage(string logText, string stackTrace, LogType type) { }

	[ConditionalAttribute] // RVA: 0x2ADBA0 Offset: 0x2ADCA1 VA: 0x2ADBA0
	// RVA: 0x23B8710 Offset: 0x23B8811 VA: 0x23B8710
	public static void Initialize() { }

	// RVA: 0x23B8600 Offset: 0x23B8701 VA: 0x23B8600
	public void .ctor() { }

	// RVA: 0x23B8720 Offset: 0x23B8821 VA: 0x23B8720
	private static void .cctor() { }
}

