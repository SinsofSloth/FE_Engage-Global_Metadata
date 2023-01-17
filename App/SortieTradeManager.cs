// Namespace: App
public class SortieTradeManager : SingletonClass<SortieTradeManager> // TypeDefIndex: 13185
{
	// Fields
	private SortieTradeManager.Side m_From; // 0x20
	private SortieTradeManager.Side m_To; // 0x28
	private SortieTradeManager.SideId m_SelectSide; // 0x30
	private bool m_IsFirstSelected; // 0x34

	// Properties
	public SortieTradeManager.Side From { get; }
	public SortieTradeManager.Side To { get; }
	public SortieTradeManager.SideId SelectSide { get; set; }
	public bool IsFirstSelected { get; set; }

	// Methods

	// RVA: 0x2173BA0 Offset: 0x2173CA1 VA: 0x2173BA0
	public void .ctor() { }

	// RVA: 0x215C4B0 Offset: 0x215C5B1 VA: 0x215C4B0
	public void Reset() { }

	// RVA: 0x2173CB0 Offset: 0x2173DB1 VA: 0x2173CB0
	public SortieTradeManager.Side get_From() { }

	// RVA: 0x2173CC0 Offset: 0x2173DC1 VA: 0x2173CC0
	public SortieTradeManager.Side get_To() { }

	// RVA: 0x2173CD0 Offset: 0x2173DD1 VA: 0x2173CD0
	public SortieTradeManager.SideId get_SelectSide() { }

	// RVA: 0x2173CE0 Offset: 0x2173DE1 VA: 0x2173CE0
	public void set_SelectSide(SortieTradeManager.SideId value) { }

	// RVA: 0x2173CF0 Offset: 0x2173DF1 VA: 0x2173CF0
	public bool get_IsFirstSelected() { }

	// RVA: 0x2173D00 Offset: 0x2173E01 VA: 0x2173D00
	public void set_IsFirstSelected(bool value) { }
}

