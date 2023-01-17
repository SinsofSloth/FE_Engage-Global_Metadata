// Namespace: App
public class BitHash : IDisposable // TypeDefIndex: 9179
{
	// Fields
	private int m_Shift; // 0x10
	private int m_Mask; // 0x14
	private List<int> m_List; // 0x18
	private List<string> m_Names; // 0x20
	private Dictionary<int, int> m_Dictionary; // 0x28
	private byte[] m_Bits; // 0x30

	// Properties
	public List<string> Names { get; }

	// Methods

	// RVA: 0x2C77590 Offset: 0x2C77691 VA: 0x2C77590
	public void .ctor(int shift = 20) { }

	// RVA: 0x2C77780 Offset: 0x2C77881 VA: 0x2C77780 Slot: 4
	public void Dispose() { }

	// RVA: 0x2C777E0 Offset: 0x2C778E1 VA: 0x2C777E0
	public void Add(string name) { }

	// RVA: 0x2C779E0 Offset: 0x2C77AE1 VA: 0x2C779E0
	public void Add(string[] conditions) { }

	// RVA: 0x2C77AE0 Offset: 0x2C77BE1 VA: 0x2C77AE0
	public void Clear() { }

	// RVA: 0x2C77C00 Offset: 0x2C77D01 VA: 0x2C77C00
	public bool Test(int key) { }

	// RVA: 0x2C77C50 Offset: 0x2C77D51 VA: 0x2C77C50
	public bool Test(int key1, int key2) { }

	// RVA: 0x2C77CC0 Offset: 0x2C77DC1 VA: 0x2C77CC0
	public bool Test(int key1, int key2, int key3) { }

	// RVA: 0x2C77D60 Offset: 0x2C77E61 VA: 0x2C77D60
	public bool Test(int key1, int key2, int key3, int key4) { }

	// RVA: 0x2C77E20 Offset: 0x2C77F21 VA: 0x2C77E20
	public bool Test(int[] keys) { }

	// RVA: 0x2C77EA0 Offset: 0x2C77FA1 VA: 0x2C77EA0
	public bool Test(List<int> keys) { }

	// RVA: 0x2C77F80 Offset: 0x2C78081 VA: 0x2C77F80
	public bool Not(int key) { }

	// RVA: 0x2C77FD0 Offset: 0x2C780D1 VA: 0x2C77FD0
	public bool Not(int[] keys) { }

	// RVA: 0x2C78050 Offset: 0x2C78151 VA: 0x2C78050
	public bool Not(List<int> keys) { }

	// RVA: 0x2C78130 Offset: 0x2C78231 VA: 0x2C78130
	public static int CalcKey(string name, int shift) { }

	// RVA: 0x2C78170 Offset: 0x2C78271 VA: 0x2C78170
	public bool Test(string key) { }

	// RVA: 0x2C781F0 Offset: 0x2C782F1 VA: 0x2C781F0
	public List<string> get_Names() { }
}

