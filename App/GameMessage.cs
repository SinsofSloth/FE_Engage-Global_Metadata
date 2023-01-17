// Namespace: App
public class GameMessage : ProcInst // TypeDefIndex: 12555
{
	// Fields
	protected GameMessageContent m_content; // 0x70
	protected GameMessage.Status m_status; // 0x78
	protected string m_mess; // 0x80
	protected string m_expandedMess; // 0x88
	protected int m_tickCount; // 0x90
	protected int m_endFrame; // 0x94

	// Methods

	// RVA: 0x26A72E0 Offset: 0x26A73E1 VA: 0x26A72E0
	public void .ctor(string mess, GameMessageContent content, int status) { }

	// RVA: 0x26A73D0 Offset: 0x26A74D1 VA: 0x26A73D0
	public ProcDesc[] CreateDefaultDesc() { }

	// RVA: 0x26A77E0 Offset: 0x26A78E1 VA: 0x26A77E0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x26A79C0 Offset: 0x26A7AC1 VA: 0x26A79C0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x26A7BC0 Offset: 0x26A7CC1 VA: 0x26A7BC0
	public GameMessage.Status GetStatus() { }

	// RVA: 0x26A7BD0 Offset: 0x26A7CD1 VA: 0x26A7BD0
	public string GetMess() { }

	// RVA: 0x26A7BE0 Offset: 0x26A7CE1 VA: 0x26A7BE0
	public string GetExpandedMess() { }

	// RVA: 0x26A7BF0 Offset: 0x26A7CF1 VA: 0x26A7BF0 Slot: 18
	protected virtual void Build() { }

	// RVA: 0x26A7F50 Offset: 0x26A8051 VA: 0x26A7F50 Slot: 19
	protected virtual void OpenWindow() { }

	// RVA: 0x26A8070 Offset: 0x26A8171 VA: 0x26A8070 Slot: 20
	protected virtual void WaitOpenWindow() { }

	// RVA: 0x26A8160 Offset: 0x26A8261 VA: 0x26A8160 Slot: 21
	protected virtual void CloseWindow() { }

	// RVA: 0x26A8280 Offset: 0x26A8381 VA: 0x26A8280 Slot: 22
	protected virtual void WaitCloseWindow() { }

	// RVA: 0x26A8360 Offset: 0x26A8461 VA: 0x26A8360 Slot: 23
	protected virtual void Tick() { }

	// RVA: 0x26A8620 Offset: 0x26A8721 VA: 0x26A8620
	private static GameMessage CreateCommon(ProcInst super, string mess, bool isBind, int status) { }

	// RVA: 0x26A87F0 Offset: 0x26A88F1 VA: 0x26A87F0
	public static GameMessage CreateNoBind(ProcInst super, string mess, int status = 0) { }

	// RVA: 0x26A8800 Offset: 0x26A8901 VA: 0x26A8800
	public static GameMessage CreateBind(ProcInst super, string mess, int status = 0) { }

	// RVA: 0x269A970 Offset: 0x269AA71 VA: 0x269A970
	public static GameMessage CreateKeyWait(ProcInst super, string mess) { }

	// RVA: 0x26A8810 Offset: 0x26A8911 VA: 0x26A8810
	public static GameMessage CreateSystem(ProcInst super, string mess) { }

	// RVA: 0x26A8820 Offset: 0x26A8921 VA: 0x26A8820
	public static GameMessage CreateWarning(ProcInst super, string mess) { }

	// RVA: 0x26A8850 Offset: 0x26A8951 VA: 0x26A8850
	private static GameMessage CreateItemGetImpl(ProcInst super, ItemData item, string name, string label, int count = 1) { }

	// RVA: 0x26A8B70 Offset: 0x26A8C71 VA: 0x26A8B70
	public static GameMessage CreateItemGet(ProcInst super, ItemData itemData, string label, int count = 1) { }

	// RVA: 0x26A8BC0 Offset: 0x26A8CC1 VA: 0x26A8BC0
	public static GameMessage CreateUnitItemGet(ProcInst super, UnitItem unitItem, string label, int count = 1) { }

	// RVA: 0x26A8F10 Offset: 0x26A9011 VA: 0x26A8F10
	public static GameMessage CreateGoldGain(ProcInst super, int gold, string label) { }

	// RVA: 0x26A9180 Offset: 0x26A9281 VA: 0x26A9180
	public static GameMessage CreateGrowUpItemUse(ProcInst super, ItemData item) { }

	// RVA: 0x26A9410 Offset: 0x26A9511 VA: 0x26A9410
	public static GameMessage CreateEnhanceItemUse(ProcInst super, ItemData item) { }

	// RVA: 0x26A96A0 Offset: 0x26A97A1 VA: 0x26A96A0
	public GameMessage SetShadowOff() { }

	// RVA: 0x26A9800 Offset: 0x26A9901 VA: 0x26A9800
	public GameMessage SetPosition(float x, float y) { }
}

