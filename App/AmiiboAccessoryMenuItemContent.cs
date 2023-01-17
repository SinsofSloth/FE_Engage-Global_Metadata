// Namespace: App
public class AmiiboAccessoryMenuItemContent : BasicMenuItemContent // TypeDefIndex: 10389
{
	// Fields
	[SerializeField] // RVA: 0x28DF70 Offset: 0x28E071 VA: 0x28DF70
	private Image m_Icon; // 0x48
	[SerializeField] // RVA: 0x28DF80 Offset: 0x28E081 VA: 0x28DF80
	private GameObject m_TicketObj; // 0x50
	[SerializeField] // RVA: 0x28DF90 Offset: 0x28E091 VA: 0x28DF90
	private Image m_TicketIcon; // 0x58
	[SerializeField] // RVA: 0x28DFA0 Offset: 0x28E0A1 VA: 0x28DFA0
	private TextMeshProUGUI m_TicketValue; // 0x60
	[SerializeField] // RVA: 0x28DFB0 Offset: 0x28E0B1 VA: 0x28DFB0
	private GameObject m_NewObj; // 0x68
	private const int c_Cost = 1;
	private bool m_IsCanBy; // 0x70

	// Methods

	// RVA: 0x20E5F10 Offset: 0x20E6011 VA: 0x20E5F10 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x20E62A0 Offset: 0x20E63A1 VA: 0x20E62A0 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x20E6390 Offset: 0x20E6491 VA: 0x20E6390
	public void .ctor() { }
}

