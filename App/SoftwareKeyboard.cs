// Namespace: App
public class SoftwareKeyboard : ProcInst // TypeDefIndex: 12671
{
	// Fields
	public const int DataCodeMaxLength = 14;
	private static StringBuilder s_result; // 0x0
	private ShowKeyboardArg m_arg; // 0x70
	private int m_maxLength; // 0x128
	private string m_headerText; // 0x130
	private string m_subText; // 0x138
	private string m_initialText; // 0x140
	private SoftwareKeyboard.Preset m_preset; // 0x148
	private Action<string> m_callback; // 0x150

	// Properties
	public static string ResultText { get; }

	// Methods

	// RVA: 0x27E6050 Offset: 0x27E6151 VA: 0x27E6050
	public static string get_ResultText() { }

	// RVA: 0x27E60C0 Offset: 0x27E61C1 VA: 0x27E60C0
	private void .ctor(int maxLength, string initialText, string headerText, string subText, SoftwareKeyboard.Preset preset, Action<string> callback) { }

	// RVA: 0x27E6160 Offset: 0x27E6261 VA: 0x27E6160
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x27E6520 Offset: 0x27E6621 VA: 0x27E6520
	private void Create() { }

	// RVA: 0x27E6530 Offset: 0x27E6631 VA: 0x27E6530
	private void Destroy() { }

	// RVA: 0x27E6540 Offset: 0x27E6641 VA: 0x27E6540
	private void Callback() { }

	// RVA: 0x27E6640 Offset: 0x27E6741 VA: 0x27E6640
	private KeyboardMode GetKeyboradMode() { }

	// RVA: 0x27E6760 Offset: 0x27E6861 VA: 0x27E6760
	private void ShowKeyboard() { }

	// RVA: 0x27E6A40 Offset: 0x27E6B41 VA: 0x27E6A40
	private void NetKeepAliveOn() { }

	// RVA: 0x27E6A50 Offset: 0x27E6B51 VA: 0x27E6A50
	private void NetKeepAliveOff() { }

	// RVA: 0x27E6A60 Offset: 0x27E6B61 VA: 0x27E6A60
	public static void CreateBind(ProcInst super, int maxLength = 8, string initialText = "", string headerText = "", string subText = "", SoftwareKeyboard.Preset preset = 0, Action<string> callback) { }

	// RVA: 0x27E6B60 Offset: 0x27E6C61 VA: 0x27E6B60
	public static void CreateBindByPlayerNameInput(ProcInst super, string name, Action<string> callback) { }

	// RVA: 0x27E6C60 Offset: 0x27E6D61 VA: 0x27E6C60
	public static string GetResult() { }

	// RVA: 0x27E6A20 Offset: 0x27E6B21 VA: 0x27E6A20
	private Preset GetNnPreset() { }

	// RVA: 0x27E6D20 Offset: 0x27E6E21 VA: 0x27E6D20
	private static void .cctor() { }
}

