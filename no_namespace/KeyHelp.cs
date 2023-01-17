// Namespace: 
public enum KeyHelp.Type // TypeDefIndex: 11826
{
	// Fields
	public int value__; // 0x0
	public const KeyHelp.Type A = 0;
	public const KeyHelp.Type B = 1;
	public const KeyHelp.Type X = 2;
	public const KeyHelp.Type Y = 3;
	public const KeyHelp.Type L = 4;
	public const KeyHelp.Type R = 5;
	public const KeyHelp.Type LR = 6;
	public const KeyHelp.Type ZL = 7;
	public const KeyHelp.Type ZR = 8;
	public const KeyHelp.Type Plus = 9;
	public const KeyHelp.Type Minus = 10;
	public const KeyHelp.Type Num = 11;
}

// Namespace: 
private class KeyHelp.UI // TypeDefIndex: 11828
{
	// Fields
	private const string PrefabPath = "UI/Common/KeyHelp/Prefabs/KeyHelp";
	private static readonly string[] ElementNames; // 0x0
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x10
	private GameObject m_GameObject; // 0x18
	private Dictionary<KeyHelp.Type, KeyHelp.UI.Element> m_Elements; // 0x20
	private int m_Index; // 0x28

	// Methods

	// RVA: 0x222CC80 Offset: 0x222CD81 VA: 0x222CC80
	public void .ctor() { }

	// RVA: 0x222CD20 Offset: 0x222CE21 VA: 0x222CD20
	public void CreateAsync() { }

	// RVA: 0x222CE60 Offset: 0x222CF61 VA: 0x222CE60
	public bool IsCreating() { }

	// RVA: 0x222CE90 Offset: 0x222CF91 VA: 0x222CE90
	public void Destroy() { }

	// RVA: 0x222CF80 Offset: 0x222D081 VA: 0x222CF80
	public void SetVisible(bool isVisible) { }

	// RVA: 0x222D030 Offset: 0x222D131 VA: 0x222D030
	public void Add(KeyHelp.Type type, string text) { }

	// RVA: 0x222D130 Offset: 0x222D231 VA: 0x222D130
	public void Add(string keyHelpID) { }

	// RVA: 0x222D200 Offset: 0x222D301 VA: 0x222D200
	public void Clear() { }

	// RVA: 0x222D3E0 Offset: 0x222D4E1 VA: 0x222D3E0
	private void CreateImpl() { }

	// RVA: 0x222D6A0 Offset: 0x222D7A1 VA: 0x222D6A0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6B10 Offset: 0x2C6C11 VA: 0x2C6B10
	// RVA: 0x222DB20 Offset: 0x222DC21 VA: 0x222DB20
	private void <CreateAsync>b__8_0(GameObject _) { }
}

