// Namespace: App
public class ShopSellAccountWindow : MonoBehaviour // TypeDefIndex: 11185
{
	// Fields
	public TextMeshProUGUI m_CountTitleText; // 0x18
	public TextMeshProUGUI m_CountValueText; // 0x20
	public TextMeshProUGUI m_TotalTitleText; // 0x28
	public TextMeshProUGUI m_TotalValueText; // 0x30
	public TextMeshProUGUI m_TotalValueGText; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x296ED0 Offset: 0x296FD1 VA: 0x296ED0
	private int <m_Count>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x296EE0 Offset: 0x296FE1 VA: 0x296EE0
	private int <m_Total>k__BackingField; // 0x44
	private Animator m_Animator; // 0x48

	// Properties
	public int m_Count { get; set; }
	public int m_Total { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3C90 Offset: 0x2C3D91 VA: 0x2C3C90
	// RVA: 0x2335B30 Offset: 0x2335C31 VA: 0x2335B30
	public int get_m_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3CA0 Offset: 0x2C3DA1 VA: 0x2C3CA0
	// RVA: 0x2335B40 Offset: 0x2335C41 VA: 0x2335B40
	private void set_m_Count(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3CB0 Offset: 0x2C3DB1 VA: 0x2C3CB0
	// RVA: 0x2335B50 Offset: 0x2335C51 VA: 0x2335B50
	public int get_m_Total() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3CC0 Offset: 0x2C3DC1 VA: 0x2C3CC0
	// RVA: 0x2335B60 Offset: 0x2335C61 VA: 0x2335B60
	private void set_m_Total(int value) { }

	// RVA: 0x2335B70 Offset: 0x2335C71 VA: 0x2335B70
	private void Start() { }

	// RVA: 0x2335D00 Offset: 0x2335E01 VA: 0x2335D00
	public void UpdateInfo(int itemCount, int totalValue) { }

	// RVA: 0x2335DE0 Offset: 0x2335EE1 VA: 0x2335DE0
	public void ClearInfo() { }

	// RVA: 0x2335E70 Offset: 0x2335F71 VA: 0x2335E70
	public void Close() { }

	// RVA: 0x2335F20 Offset: 0x2336021 VA: 0x2335F20
	public void .ctor() { }
}

