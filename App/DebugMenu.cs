// Namespace: App
public class DebugMenu : ProcInst // TypeDefIndex: 8926
{
	// Fields
	public static readonly Color COLOR_WINDOW; // 0x0
	public static readonly Color COLOR_ZERO; // 0x10
	private Rect m_Rect; // 0x70
	private int m_Select; // 0x80
	private float m_Orient; // 0x84
	private Color m_Color; // 0x88
	private int m_Depth; // 0x98
	private GX.Anchor m_Anchor; // 0x9C
	private GameObject m_Prefab; // 0xA0
	private DebugWindow m_Window; // 0xA8
	private DebugMenu.BindMode m_BindMode; // 0xB0
	private List<MenuItem> m_Items; // 0xB8
	private bool m_IsFirst; // 0xC0
	private bool m_IsRelay; // 0xC1
	private bool m_IsCalcW; // 0xC2
	private bool m_IsCalcH; // 0xC3
	private bool m_IsMovePage; // 0xC4
	private bool m_IsMapCursor; // 0xC5
	private string m_RecordKey; // 0xC8
	private int m_SelectTick; // 0xD0
	private float m_SelectTime; // 0xD4
	private float m_TimeScale; // 0xD8

	// Methods

	// RVA: 0x2E9E950 Offset: 0x2E9EA51 VA: 0x2E9E950 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2E9EAA0 Offset: 0x2E9EBA1 VA: 0x2E9EAA0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2E9EE70 Offset: 0x2E9EF71 VA: 0x2E9EE70 Slot: 18
	protected virtual void OnOpen() { }

	// RVA: 0x2E9EE80 Offset: 0x2E9EF81 VA: 0x2E9EE80 Slot: 19
	protected virtual void OnClose() { }

	// RVA: 0x2E9EE90 Offset: 0x2E9EF91 VA: 0x2E9EE90 Slot: 20
	protected virtual void OnRebuild() { }

	// RVA: 0x2E9EEA0 Offset: 0x2E9EFA1 VA: 0x2E9EEA0 Slot: 21
	protected virtual void OnSelect() { }

	// RVA: 0x2E9EEB0 Offset: 0x2E9EFB1 VA: 0x2E9EEB0
	protected MenuItem.Result TickItem(MenuItem item) { }

	// RVA: 0x2EA0860 Offset: 0x2EA0961 VA: 0x2EA0860
	private bool IsSelectable(int index) { }

	// RVA: 0x2EA0920 Offset: 0x2EA0A21 VA: 0x2EA0920
	private bool IsSelectable(MenuItem item) { }

	// RVA: 0x2EA0990 Offset: 0x2EA0A91 VA: 0x2EA0990
	private bool IsVisible(MenuItem item) { }

	// RVA: 0x2EA09E0 Offset: 0x2EA0AE1 VA: 0x2EA09E0
	private bool IsRelay() { }

	// RVA: 0x2EA09F0 Offset: 0x2EA0AF1 VA: 0x2EA09F0
	private void MoveToPrev(int step, bool isTrigger) { }

	// RVA: 0x2EA0B10 Offset: 0x2EA0C11 VA: 0x2EA0B10
	private void MoveToNext(int step, bool isTrigger) { }

	// RVA: 0x2EA0C50 Offset: 0x2EA0D51 VA: 0x2EA0C50
	private float GetWidth() { }

	// RVA: 0x2EA0CF0 Offset: 0x2EA0DF1 VA: 0x2EA0CF0
	private float GetHeight() { }

	// RVA: 0x2EA0D20 Offset: 0x2EA0E21 VA: 0x2EA0D20
	private int GetPage() { }

	// RVA: 0x2EA0E40 Offset: 0x2EA0F41 VA: 0x2EA0E40
	private void MoveTick() { }

	// RVA: 0x2EA2030 Offset: 0x2EA2131 VA: 0x2EA2030
	private void Init() { }

	// RVA: 0x2EA2730 Offset: 0x2EA2831 VA: 0x2EA2730 Slot: 22
	protected virtual MenuItem.Result BCall() { }

	// RVA: 0x2EA2740 Offset: 0x2EA2841 VA: 0x2EA2740 Slot: 23
	protected virtual MenuItem.Result XCall() { }

	// RVA: 0x2EA2750 Offset: 0x2EA2851 VA: 0x2EA2750 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x2EA2E10 Offset: 0x2EA2F11 VA: 0x2EA2E10
	private float GetItemBlank(int index, int dir) { }

	// RVA: 0x2EA2CA0 Offset: 0x2EA2DA1 VA: 0x2EA2CA0
	private float GetOrientTarget() { }

	// RVA: 0x2EA24D0 Offset: 0x2EA25D1 VA: 0x2EA24D0
	private void UpdateSelect() { }

	// RVA: 0x2E9B400 Offset: 0x2E9B501 VA: 0x2E9B400
	public DebugMenu AddItem(MenuItem item) { }

	// RVA: 0x2EA2F60 Offset: 0x2EA3061 VA: 0x2EA2F60
	public DebugMenu AddItem(List<MenuItem> items) { }

	// RVA: 0x2EA30C0 Offset: 0x2EA31C1 VA: 0x2EA30C0
	public DebugMenu AddString(string name) { }

	// RVA: 0x2EA3180 Offset: 0x2EA3281 VA: 0x2EA3180
	public DebugMenu AddString(string name, string english) { }

	// RVA: 0x2EA3250 Offset: 0x2EA3351 VA: 0x2EA3250
	public DebugMenu AddStringFormat(string format, object[] args) { }

	// RVA: 0x2EA3330 Offset: 0x2EA3431 VA: 0x2EA3330
	public DebugMenu AddDisable(string name) { }

	// RVA: 0x2EA33F0 Offset: 0x2EA34F1 VA: 0x2EA33F0
	public DebugMenu AddFunc(string name, FuncItem.Func func) { }

	// RVA: 0x2EA34C0 Offset: 0x2EA35C1 VA: 0x2EA34C0
	public DebugMenu AddProperty(object obj, FieldInfo info) { }

	// RVA: 0x2EA3590 Offset: 0x2EA3691 VA: 0x2EA3590
	public DebugMenu AddProperty(object obj, PropertyInfo info) { }

	// RVA: 0x2EA3660 Offset: 0x2EA3761 VA: 0x2EA3660
	public DebugMenu AddProperty(object obj, string name, BindingFlags flags) { }

	// RVA: 0x2EA3730 Offset: 0x2EA3831 VA: 0x2EA3730
	public DebugMenu AddProperty(object obj, BindingFlags flags) { }

	// RVA: 0x2E9B340 Offset: 0x2E9B441 VA: 0x2E9B340
	public DebugMenu AddLabel(string name) { }

	// RVA: 0x2EA3840 Offset: 0x2EA3941 VA: 0x2EA3840
	public DebugMenu AddLabel(string name, string english) { }

	// RVA: 0x2EA3910 Offset: 0x2EA3A11 VA: 0x2EA3910
	public DebugMenu AddLabelFormat(string format, object[] args) { }

	// RVA: 0x2E9B480 Offset: 0x2E9B581 VA: 0x2E9B480
	public DebugMenu AddSeparator() { }

	// RVA: 0x2EA39F0 Offset: 0x2EA3AF1 VA: 0x2EA39F0
	public DebugMenu AddGroupBegin(string name, MenuItem.State state = 1) { }

	// RVA: 0x2EA3AC0 Offset: 0x2EA3BC1 VA: 0x2EA3AC0
	public DebugMenu AddGroupEnd() { }

	// RVA: 0x2EA3B70 Offset: 0x2EA3C71 VA: 0x2EA3B70
	public DebugMenu ClearItem() { }

	// RVA: 0x2EA3BD0 Offset: 0x2EA3CD1 VA: 0x2EA3BD0
	public DebugMenu SetPos(float x, float y) { }

	// RVA: 0x2EA3C20 Offset: 0x2EA3D21 VA: 0x2EA3C20
	public DebugMenu SetPos(Vector2 pos) { }

	// RVA: 0x2EA3C70 Offset: 0x2EA3D71 VA: 0x2EA3C70
	public DebugMenu SetSize(float w, float h) { }

	// RVA: 0x2EA3D50 Offset: 0x2EA3E51 VA: 0x2EA3D50
	public DebugMenu SetSize(Vector2 size) { }

	// RVA: 0x2EA3CD0 Offset: 0x2EA3DD1 VA: 0x2EA3CD0
	public DebugMenu SetWidth(float w) { }

	// RVA: 0x2EA3D10 Offset: 0x2EA3E11 VA: 0x2EA3D10
	public DebugMenu SetHeight(float h) { }

	// RVA: 0x2EA3DB0 Offset: 0x2EA3EB1 VA: 0x2EA3DB0
	public DebugMenu SetRect(float x, float y, float w, float h) { }

	// RVA: 0x2EA3E40 Offset: 0x2EA3F41 VA: 0x2EA3E40
	public DebugMenu SetColot(Color color) { }

	// RVA: 0x2EA3E60 Offset: 0x2EA3F61 VA: 0x2EA3E60
	public DebugMenu Move(float x, float y) { }

	// RVA: 0x2EA3ED0 Offset: 0x2EA3FD1 VA: 0x2EA3ED0
	public DebugMenu SetMovePage(bool enable) { }

	// RVA: 0x2EA3EE0 Offset: 0x2EA3FE1 VA: 0x2EA3EE0
	public DebugMenu SetMapCursor(bool enable) { }

	// RVA: 0x2EA2C00 Offset: 0x2EA2D01 VA: 0x2EA2C00
	protected void ResetSize() { }

	// RVA: 0x2EA3EF0 Offset: 0x2EA3FF1 VA: 0x2EA3EF0
	public DebugMenu CalcWidth() { }

	// RVA: 0x2EA40C0 Offset: 0x2EA41C1 VA: 0x2EA40C0
	public DebugMenu CalcHeight() { }

	// RVA: 0x2EA2240 Offset: 0x2EA2341 VA: 0x2EA2240
	public DebugMenu CalcRow(int row = 20) { }

	// RVA: 0x2EA4220 Offset: 0x2EA4321 VA: 0x2EA4220
	public DebugMenu SetSelect(int index) { }

	// RVA: 0x2EA4230 Offset: 0x2EA4331 VA: 0x2EA4230
	public DebugMenu SetDepth(int depth) { }

	// RVA: 0x2EA4240 Offset: 0x2EA4341 VA: 0x2EA4240
	public DebugMenu SetAncher(GX.Anchor anchor) { }

	// RVA: 0x2EA4250 Offset: 0x2EA4351 VA: 0x2EA4250
	public DebugMenu SetAncherPos(GX.Anchor anchor, float offset) { }

	// RVA: 0x2EA4300 Offset: 0x2EA4401 VA: 0x2EA4300
	public DebugMenu SetRelay(bool enable) { }

	// RVA: 0x2EA4310 Offset: 0x2EA4411 VA: 0x2EA4310
	public void SetDebugTime(float timeScale) { }

	// RVA: 0x2EA43C0 Offset: 0x2EA44C1 VA: 0x2EA43C0
	public Rect GetRect() { }

	// RVA: 0x2EA43D0 Offset: 0x2EA44D1 VA: 0x2EA43D0
	public float GetOrient() { }

	// RVA: 0x2EA43E0 Offset: 0x2EA44E1 VA: 0x2EA43E0
	public Color GetColor() { }

	// RVA: 0x2EA43F0 Offset: 0x2EA44F1 VA: 0x2EA43F0
	public int GetDepth() { }

	// RVA: 0x2EA4400 Offset: 0x2EA4501 VA: 0x2EA4400
	public int GetSelect() { }

	// RVA: 0x2EA4410 Offset: 0x2EA4511 VA: 0x2EA4410
	public Vector2 GetPos() { }

	// RVA: 0x2EA0CA0 Offset: 0x2EA0DA1 VA: 0x2EA0CA0
	public Vector2 GetSize() { }

	// RVA: 0x2EA4460 Offset: 0x2EA4561 VA: 0x2EA4460
	public GX.Anchor GetAnchor() { }

	// RVA: 0x2EA4060 Offset: 0x2EA4161 VA: 0x2EA4060
	public float GetIndentOffset(int indent) { }

	// RVA: 0x2EA4070 Offset: 0x2EA4171 VA: 0x2EA4070
	public int CalcIndent(int indent, MenuItem item) { }

	// RVA: 0x2EA23C0 Offset: 0x2EA24C1 VA: 0x2EA23C0
	private void ReadRecord() { }

	// RVA: 0x2E9EC80 Offset: 0x2E9ED81 VA: 0x2E9EC80
	private void WriteRecord() { }

	// RVA: 0x2EA4470 Offset: 0x2EA4571 VA: 0x2EA4470
	public DebugMenu SetRecord(string key) { }

	// RVA: 0x2EA20B0 Offset: 0x2EA21B1 VA: 0x2EA20B0
	public DebugMenu BuildHierarchy() { }

	// RVA: 0x2EA45C0 Offset: 0x2EA46C1 VA: 0x2EA45C0
	public float GetTextWidth(string text) { }

	// RVA: 0x2EA47C0 Offset: 0x2EA48C1 VA: 0x2EA47C0
	public float GetTextHeight(string text) { }

	// RVA: 0x2EA49D0 Offset: 0x2EA4AD1 VA: 0x2EA49D0
	public DebugMenu SetBindMode(DebugMenu.BindMode mode) { }

	// RVA: 0x2EA49E0 Offset: 0x2EA4AE1 VA: 0x2EA49E0
	public DebugMenu.BindMode GetBindMode() { }

	// RVA: 0x2EA49F0 Offset: 0x2EA4AF1 VA: 0x2EA49F0
	private DebugMenu.BindMode GetCurrentBindMode() { }

	// RVA: 0x2EA4A30 Offset: 0x2EA4B31 VA: 0x2EA4A30
	public Color GetBaseColor() { }

	// RVA: 0x2EA4AC0 Offset: 0x2EA4BC1 VA: 0x2EA4AC0
	public MenuItem GetItem(int i) { }

	// RVA: 0x2EA4B30 Offset: 0x2EA4C31 VA: 0x2EA4B30
	public List<MenuItem> GetItems() { }

	// RVA: 0x2EA4B40 Offset: 0x2EA4C41 VA: 0x2EA4B40
	public int GetItemCount() { }

	// RVA: 0x2EA4B90 Offset: 0x2EA4C91 VA: 0x2EA4B90
	public int GetSelectTick() { }

	// RVA: 0x2EA4BA0 Offset: 0x2EA4CA1 VA: 0x2EA4BA0
	public float GetSelectTime() { }

	// RVA: 0x2E9B2C0 Offset: 0x2E9B3C1 VA: 0x2E9B2C0
	public static DebugMenu CreateBind(ProcInst super) { }

	// RVA: 0x2EA2B10 Offset: 0x2EA2C11 VA: 0x2EA2B10
	private static DebugMenu GetTopMenu(DebugMenu menu, bool isRelay) { }

	// RVA: 0x2EA2C10 Offset: 0x2EA2D11 VA: 0x2EA2C10
	private static DebugMenu GetParentMenu(ProcInst super) { }

	// RVA: -1 Offset: -1
	public static T CreateBind<T>(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229E750 Offset: 0x229E851 VA: 0x229E750
	|-DebugMenu.CreateBind<DebugMenu>
	|-DebugMenu.CreateBind<object>
	|-DebugMenu.CreateBind<DebugRingMenu.RingMenu>
	|-DebugMenu.CreateBind<DebugUnitItemMenu.UnitDebugMenu>
	|-DebugMenu.CreateBind<DebugUnitRingMenu.UnitRingMenu>
	|-DebugMenu.CreateBind<ScriptMenu.EventMenu>
	*/

	// RVA: 0x2EA4BB0 Offset: 0x2EA4CB1 VA: 0x2EA4BB0
	public void .ctor() { }

	// RVA: 0x2EA4CF0 Offset: 0x2EA4DF1 VA: 0x2EA4CF0
	private static void .cctor() { }
}

