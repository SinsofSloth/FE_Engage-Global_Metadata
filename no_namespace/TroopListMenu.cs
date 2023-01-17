// Namespace: 
public class TroopListMenu.TroopListMenuItem : BasicMenuItem // TypeDefIndex: 13294
{
	// Fields
	private int m_index; // 0x64
	private SortieSequenceTroopList.Mode m_mode; // 0x68

	// Methods

	// RVA: 0x23A7620 Offset: 0x23A7721 VA: 0x23A7620
	public void .ctor(int index, SortieSequenceTroopList.Mode mode) { }

	// RVA: 0x23A7660 Offset: 0x23A7761 VA: 0x23A7660
	public Unit GetUnit() { }

	// RVA: 0x23A7700 Offset: 0x23A7801 VA: 0x23A7700
	public Unit GetTmpUnit() { }

	// RVA: 0x23A77A0 Offset: 0x23A78A1 VA: 0x23A77A0
	public SortieSequenceTroopList.Mode GetMode() { }

	// RVA: 0x23A77B0 Offset: 0x23A78B1 VA: 0x23A77B0
	public RectTransform GetRectTransform() { }

	// RVA: 0x23A77C0 Offset: 0x23A78C1 VA: 0x23A77C0 Slot: 4
	public override string GetName() { }

	// RVA: 0x23A7910 Offset: 0x23A7A11 VA: 0x23A7910 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x23A7E10 Offset: 0x23A7F11 VA: 0x23A7E10 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x23A8690 Offset: 0x23A8791 VA: 0x23A8690 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x23A88A0 Offset: 0x23A89A1 VA: 0x23A88A0 Slot: 23
	public override BasicMenu.Result RCall() { }

	// RVA: 0x23A8A50 Offset: 0x23A8B51 VA: 0x23A8A50 Slot: 24
	public override BasicMenu.Result PlusCall() { }

	// RVA: 0x23A8BC0 Offset: 0x23A8CC1 VA: 0x23A8BC0
	public void SetPage(int page) { }
}

// Namespace: 
private class TroopListMenu.ConfirmBattleSequence : ProcInst // TypeDefIndex: 13295
{
	// Fields
	private BasicMenu m_ParentMenu; // 0x70

	// Methods

	// RVA: 0x23A72F0 Offset: 0x23A73F1 VA: 0x23A72F0
	public static void CreateBind(BasicMenu parentMenu) { }

	// RVA: 0x23A7550 Offset: 0x23A7651 VA: 0x23A7550
	private void .ctor(BasicMenu parentMenu) { }

	// RVA: 0x23A7590 Offset: 0x23A7691 VA: 0x23A7590 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x23A75A0 Offset: 0x23A76A1 VA: 0x23A75A0
	private void CreateDialog() { }
}

