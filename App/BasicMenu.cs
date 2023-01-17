// Namespace: App
public class BasicMenu : ProcInst // TypeDefIndex: 12515
{
	// Fields
	protected BasicMenuContent m_menuContent; // 0x70
	protected List<BasicMenuItem> m_menuItemList; // 0x78
	protected List<BasicMenuItem> m_fullMenuItemList; // 0x80
	protected BasicMenu.StatusField m_status; // 0x88
	protected BasicMenu.Result m_result; // 0x90
	private bool m_scrollPrecedeInputA; // 0x94
	protected int m_rowNum; // 0x98
	protected int m_showRowNum; // 0x9C
	protected int m_selectIndex; // 0xA0
	protected int m_selectIndexOld; // 0xA4
	protected int m_scrollIndex; // 0xA8
	protected int m_scrollIndexOld; // 0xAC
	protected int m_reservedSelectIndex; // 0xB0
	protected int m_reservedScrollIndex; // 0xB4
	protected int m_reservedShowRowNum; // 0xB8
	protected int m_memoryDisplayIndex; // 0xBC
	protected int m_suspend; // 0xC0

	// Properties
	protected virtual BasicMenu.BindTypes BindType { get; }

	// Methods

	// RVA: 0x28F0560 Offset: 0x28F0661 VA: 0x28F0560
	protected void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x28F86A0 Offset: 0x28F87A1 VA: 0x28F86A0 Slot: 18
	public virtual ProcDesc[] CreateDefaultDesc() { }

	// RVA: 0x28F8B90 Offset: 0x28F8C91 VA: 0x28F8B90 Slot: 19
	protected virtual BasicMenu.BindTypes get_BindType() { }

	// RVA: 0x28F8BA0 Offset: 0x28F8CA1 VA: 0x28F8BA0 Slot: 11
	protected override void OnBind() { }

	// RVA: 0x28F8BB0 Offset: 0x28F8CB1 VA: 0x28F8BB0 Slot: 12
	protected override void OnUnbind() { }

	// RVA: 0x28F1480 Offset: 0x28F1581 VA: 0x28F1480
	public void BindParentMenu() { }

	// RVA: 0x28F8C90 Offset: 0x28F8D91 VA: 0x28F8C90
	protected void Build() { }

	// RVA: 0x28F9540 Offset: 0x28F9641 VA: 0x28F9540
	public void SetActive(bool active) { }

	// RVA: 0x28F95F0 Offset: 0x28F96F1 VA: 0x28F95F0
	public void SetActiveAll(bool active) { }

	// RVA: 0x28F9760 Offset: 0x28F9861 VA: 0x28F9760 Slot: 20
	public virtual void OpenAnime() { }

	// RVA: 0x28F9780 Offset: 0x28F9881 VA: 0x28F9780 Slot: 21
	public virtual void OpenAnimeAll() { }

	// RVA: 0x28F9820 Offset: 0x28F9921 VA: 0x28F9820 Slot: 22
	public virtual void CloseAnime() { }

	// RVA: 0x28F9840 Offset: 0x28F9941 VA: 0x28F9840 Slot: 23
	public virtual void CloseAnimeAll() { }

	// RVA: 0x28F98E0 Offset: 0x28F99E1 VA: 0x28F98E0 Slot: 24
	protected virtual void OnBuild(bool isFirstBuild) { }

	// RVA: 0x28F0DA0 Offset: 0x28F0EA1 VA: 0x28F0DA0 Slot: 25
	protected virtual void AfterBuild() { }

	// RVA: 0x28F0EF0 Offset: 0x28F0FF1 VA: 0x28F0EF0 Slot: 26
	public virtual void OnClose() { }

	// RVA: 0x28F9900 Offset: 0x28F9A01 VA: 0x28F9900 Slot: 27
	public virtual void OnCursorMoveEnd() { }

	// RVA: 0x28F9980 Offset: 0x28F9A81 VA: 0x28F9980 Slot: 28
	protected virtual void OnResume() { }

	// RVA: 0x28F9990 Offset: 0x28F9A91 VA: 0x28F9990 Slot: 29
	protected virtual void OnSuspend() { }

	// RVA: 0x28F99A0 Offset: 0x28F9AA1 VA: 0x28F99A0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x28F9A20 Offset: 0x28F9B21 VA: 0x28F9A20 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x28F9D10 Offset: 0x28F9E11 VA: 0x28F9D10 Slot: 30
	public virtual string GetName() { }

	// RVA: 0x28F1C50 Offset: 0x28F1D51 VA: 0x28F1C50
	public BasicMenuItem GetMenuItem(int itemIndex) { }

	// RVA: 0x28F2CE0 Offset: 0x28F2DE1 VA: 0x28F2CE0
	public int GetMenuItemNum() { }

	// RVA: 0x28F9D60 Offset: 0x28F9E61 VA: 0x28F9D60 Slot: 31
	public virtual int ClampMenuItemIndex(int itemIndex) { }

	// RVA: 0x28F9DE0 Offset: 0x28F9EE1 VA: 0x28F9DE0
	public int GetMenuItemIndex(BasicMenuItem menuItem) { }

	// RVA: 0x28F9EB0 Offset: 0x28F9FB1 VA: 0x28F9EB0
	public int GetRowNum() { }

	// RVA: 0x28F9EC0 Offset: 0x28F9FC1 VA: 0x28F9EC0
	public int GetShowRowNum() { }

	// RVA: 0x28F9ED0 Offset: 0x28F9FD1 VA: 0x28F9ED0
	public void SetShowRowNum(int rowNum) { }

	// RVA: 0x28F9F10 Offset: 0x28FA011 VA: 0x28F9F10
	public void SetShowRowAuto() { }

	// RVA: 0x28F9F80 Offset: 0x28FA081 VA: 0x28F9F80 Slot: 32
	public virtual int GetShowRowMax() { }

	// RVA: 0x28F9F90 Offset: 0x28FA091 VA: 0x28F9F90 Slot: 33
	protected virtual int GetBuildRowNum() { }

	// RVA: 0x28F9FE0 Offset: 0x28FA0E1 VA: 0x28F9FE0
	public int GetSelectIndex() { }

	// RVA: 0x28F9FF0 Offset: 0x28FA0F1 VA: 0x28F9FF0
	public int GetSelectIndexOld() { }

	// RVA: 0x28FA000 Offset: 0x28FA101 VA: 0x28FA000 Slot: 34
	public virtual void SetSelectIndex(int selectIndex) { }

	// RVA: 0x28FA090 Offset: 0x28FA191 VA: 0x28FA090
	public void UpdateSelectIndexOld() { }

	// RVA: 0x28FA110 Offset: 0x28FA211 VA: 0x28FA110
	public void AdjustSelectIndex() { }

	// RVA: 0x28FA130 Offset: 0x28FA231 VA: 0x28FA130
	public int GetScrollIndex() { }

	// RVA: 0x28FA140 Offset: 0x28FA241 VA: 0x28FA140
	public int GetScrollIndexOld() { }

	// RVA: 0x28F9260 Offset: 0x28F9361 VA: 0x28F9260
	public void SetScrollIndex(int scrollIndex) { }

	// RVA: 0x28FA150 Offset: 0x28FA251 VA: 0x28FA150
	public void UpdateScrollIndexOld() { }

	// RVA: 0x28FA180 Offset: 0x28FA281 VA: 0x28FA180 Slot: 35
	public virtual void AdjustScrollIndex() { }

	// RVA: 0x28FA1E0 Offset: 0x28FA2E1 VA: 0x28FA1E0
	public void SaveSelect(BasicMenuSelect sel) { }

	// RVA: 0x28FA210 Offset: 0x28FA311 VA: 0x28FA210
	public void RestoreSelect(BasicMenuSelect sel) { }

	// RVA: 0x28FA290 Offset: 0x28FA391 VA: 0x28FA290
	public bool IsOpening() { }

	// RVA: 0x28FA2A0 Offset: 0x28FA3A1 VA: 0x28FA2A0
	public bool IsClosing() { }

	// RVA: 0x28FA2B0 Offset: 0x28FA3B1 VA: 0x28FA2B0
	public bool IsClosed() { }

	// RVA: 0x28FA2C0 Offset: 0x28FA3C1 VA: 0x28FA2C0
	public bool IsCursorHide() { }

	// RVA: 0x28FA320 Offset: 0x28FA421 VA: 0x28FA320
	public void SetCursorHide(bool onoff) { }

	// RVA: 0x28FA3A0 Offset: 0x28FA4A1 VA: 0x28FA3A0
	public bool IsInputDisable() { }

	// RVA: 0x28FA400 Offset: 0x28FA501 VA: 0x28FA400
	public void SetInputDisable(bool onoff) { }

	// RVA: 0x28FA480 Offset: 0x28FA581 VA: 0x28FA480
	public bool IsInputDisableNowFrame() { }

	// RVA: 0x28FA4E0 Offset: 0x28FA5E1 VA: 0x28FA4E0
	public void SetInputDisableNowFrame(bool onoff) { }

	// RVA: 0x28FA560 Offset: 0x28FA661 VA: 0x28FA560
	public bool IsCursorMoved() { }

	// RVA: 0x28FA5C0 Offset: 0x28FA6C1 VA: 0x28FA5C0
	public void SetCursorMoved(bool onoff) { }

	// RVA: 0x28FA640 Offset: 0x28FA741 VA: 0x28FA640
	public bool IsCloseCalled() { }

	// RVA: 0x28FA6A0 Offset: 0x28FA7A1 VA: 0x28FA6A0
	public void SetCloseCalled(bool onoff) { }

	// RVA: 0x28FA720 Offset: 0x28FA821 VA: 0x28FA720
	public bool IsRebuild() { }

	// RVA: 0x28FA780 Offset: 0x28FA881 VA: 0x28FA780 Slot: 36
	protected virtual bool IsSystemCall() { }

	// RVA: 0x28FA790 Offset: 0x28FA891 VA: 0x28FA790
	public void SetCursorMoveFrame(float frame) { }

	// RVA: 0x28F98F0 Offset: 0x28F99F1 VA: 0x28F98F0
	public void CursorMoveInstant() { }

	// RVA: 0x28FA7C0 Offset: 0x28FA8C1 VA: 0x28FA7C0
	public void SetScrollFrame(float frame) { }

	// RVA: 0x28F94A0 Offset: 0x28F95A1 VA: 0x28F94A0
	public void ScrollInstant() { }

	// RVA: 0x28FA810 Offset: 0x28FA911 VA: 0x28FA810
	public void SetBackCursorColor(Color c) { }

	// RVA: 0x28FA830 Offset: 0x28FA931 VA: 0x28FA830
	public void SetCursorToKeepAnimatorState(bool keep) { }

	// RVA: 0x28FA860 Offset: 0x28FA961 VA: 0x28FA860
	public void MoveFrontCursorFrom(float fromX, float fromY, float frame) { }

	// RVA: 0x28FA880 Offset: 0x28FA981 VA: 0x28FA880
	public void MoveFrontCursorFrom(BasicMenuItem fromMenuItem, float frame = 4) { }

	// RVA: 0x28FA9F0 Offset: 0x28FAAF1 VA: 0x28FA9F0
	public void PutCursorInFront() { }

	// RVA: 0x28FAB00 Offset: 0x28FAC01 VA: 0x28FAB00
	public void PutCursorInBack() { }

	// RVA: 0x28FAC10 Offset: 0x28FAD11 VA: 0x28FAC10
	public void SetCursorFrontBack(bool isFront) { }

	// RVA: 0x28FAC20 Offset: 0x28FAD21 VA: 0x28FAC20
	public void RestartCursorAnimation() { }

	// RVA: 0x28FACD0 Offset: 0x28FADD1 VA: 0x28FACD0
	public RectTransform GetSubMenuBaseTransform() { }

	// RVA: 0x28F3B90 Offset: 0x28F3C91 VA: 0x28F3B90
	public bool IsSuspend() { }

	// RVA: 0x28F8BC0 Offset: 0x28F8CC1 VA: 0x28F8BC0
	public void IncSuspend() { }

	// RVA: 0x28F9BD0 Offset: 0x28F9CD1 VA: 0x28F9BD0
	public void DecSuspend() { }

	// RVA: 0x28FAF10 Offset: 0x28FB011 VA: 0x28FAF10
	public void SetPivot(float x, float y) { }

	// RVA: 0x28F9290 Offset: 0x28F9391 VA: 0x28F9290
	public BasicMenu.AnchorType GetAnchorType() { }

	// RVA: 0x28FAF90 Offset: 0x28FB091 VA: 0x28FAF90
	public void SetAnchorType(BasicMenu.AnchorType anchorType, float x, float y) { }

	// RVA: 0x28FB0E0 Offset: 0x28FB1E1 VA: 0x28FB0E0
	public void SetAnchorTypeFromScreenCoord(BasicMenu.AnchorType anchorType, float x, float y) { }

	// RVA: 0x28FB280 Offset: 0x28FB381 VA: 0x28FB280
	public static BasicMenu.AnchorType AnchorPositionToAnchorType(float x, float y) { }

	// RVA: 0x28FB410 Offset: 0x28FB511 VA: 0x28FB410
	public float GetX() { }

	// RVA: 0x28FB430 Offset: 0x28FB531 VA: 0x28FB430
	public float GetY() { }

	// RVA: 0x28FB440 Offset: 0x28FB541 VA: 0x28FB440
	public void SetX(float x) { }

	// RVA: 0x28FB460 Offset: 0x28FB561 VA: 0x28FB460
	public void SetY(float y) { }

	// RVA: 0x28FB480 Offset: 0x28FB581 VA: 0x28FB480
	public Vector2 GetPos() { }

	// RVA: 0x28F1140 Offset: 0x28F1241 VA: 0x28F1140
	public void SetPos(float x, float y) { }

	// RVA: 0x28FB4A0 Offset: 0x28FB5A1 VA: 0x28FB4A0
	public void SetTransformAsSubMenu(BasicMenu parentMenu, BasicMenuItem parentMenuItem) { }

	// RVA: 0x28FB790 Offset: 0x28FB891 VA: 0x28FB790
	public void SetColor(Color color) { }

	// RVA: 0x28FB7B0 Offset: 0x28FB8B1 VA: 0x28FB7B0
	public float GetW() { }

	// RVA: 0x28FB7C0 Offset: 0x28FB8C1 VA: 0x28FB7C0
	public float GetH() { }

	// RVA: 0x28FB8F0 Offset: 0x28FB9F1 VA: 0x28FB8F0
	public void SetAsFirstSibling() { }

	// RVA: 0x28FB920 Offset: 0x28FBA21 VA: 0x28FB920
	public void SetAsLastSibling() { }

	// RVA: 0x28FB950 Offset: 0x28FBA51 VA: 0x28FB950
	public void Rebuild() { }

	// RVA: 0x28FB9B0 Offset: 0x28FBAB1 VA: 0x28FB9B0
	public void RebuildInstant(bool isKeepItemIndex = False) { }

	// RVA: 0x28FBAA0 Offset: 0x28FBBA1 VA: 0x28FBAA0
	public void RebuildInstant(BasicMenuSelect menuSelect) { }

	// RVA: 0x28FBAC0 Offset: 0x28FBBC1 VA: 0x28FBAC0 Slot: 37
	public virtual void RebuildInstant(BasicMenuSelect menuSelect, int displayIndex) { }

	// RVA: 0x28FBAF0 Offset: 0x28FBBF1 VA: 0x28FBAF0
	public void Close() { }

	// RVA: 0x28FBB50 Offset: 0x28FBC51 VA: 0x28FBB50
	public void CloseParentMenu() { }

	// RVA: 0x28FBC20 Offset: 0x28FBD21 VA: 0x28FBC20
	public void DeleteParentMenu() { }

	// RVA: 0x28FBCB0 Offset: 0x28FBDB1 VA: 0x28FBCB0 Slot: 38
	protected virtual void Tick() { }

	// RVA: 0x28FBEF0 Offset: 0x28FBFF1 VA: 0x28FBEF0 Slot: 39
	protected virtual bool TickInput() { }

	// RVA: 0x28FE050 Offset: 0x28FE151 VA: 0x28FE050 Slot: 40
	protected virtual void KeyUp(bool isTrigger) { }

	// RVA: 0x28FE070 Offset: 0x28FE171 VA: 0x28FE070 Slot: 41
	protected virtual void KeyDown(bool isTrigger) { }

	// RVA: 0x28FE090 Offset: 0x28FE191 VA: 0x28FE090 Slot: 42
	protected virtual void KeyLeft(bool isTrigger) { }

	// RVA: 0x28FE120 Offset: 0x28FE221 VA: 0x28FE120 Slot: 43
	protected virtual void KeyRight(bool isTrigger) { }

	// RVA: 0x28FE1B0 Offset: 0x28FE2B1 VA: 0x28FE1B0 Slot: 44
	protected virtual void MoveUp(bool isTrigger) { }

	// RVA: 0x28FE3E0 Offset: 0x28FE4E1 VA: 0x28FE3E0 Slot: 45
	protected virtual void MoveDown(bool isTrigger) { }

	// RVA: 0x28FE600 Offset: 0x28FE701 VA: 0x28FE600 Slot: 46
	protected virtual void PageUp(bool isTrigger) { }

	// RVA: 0x28FE7A0 Offset: 0x28FE8A1 VA: 0x28FE7A0 Slot: 47
	protected virtual void PageDown(bool isTrigger) { }

	// RVA: 0x28FE940 Offset: 0x28FEA41 VA: 0x28FE940 Slot: 48
	protected virtual BasicMenu.Result SystemCall() { }

	// RVA: 0x28FE9E0 Offset: 0x28FEAE1 VA: 0x28FE9E0 Slot: 49
	protected virtual BasicMenu.Result KeyCall() { }

	// RVA: 0x28FEA80 Offset: 0x28FEB81 VA: 0x28FEA80 Slot: 50
	protected virtual BasicMenu.Result ACall() { }

	// RVA: 0x28FEB20 Offset: 0x28FEC21 VA: 0x28FEB20 Slot: 51
	protected virtual BasicMenu.Result BCall() { }

	// RVA: 0x28FEBC0 Offset: 0x28FECC1 VA: 0x28FEBC0 Slot: 52
	protected virtual BasicMenu.Result XCall() { }

	// RVA: 0x28FEC60 Offset: 0x28FED61 VA: 0x28FEC60 Slot: 53
	protected virtual BasicMenu.Result YCall() { }

	// RVA: 0x28FED00 Offset: 0x28FEE01 VA: 0x28FED00 Slot: 54
	protected virtual BasicMenu.Result LCall() { }

	// RVA: 0x28FEDA0 Offset: 0x28FEEA1 VA: 0x28FEDA0 Slot: 55
	protected virtual BasicMenu.Result RCall() { }

	// RVA: 0x28FEE40 Offset: 0x28FEF41 VA: 0x28FEE40 Slot: 56
	protected virtual BasicMenu.Result PlusCall() { }

	// RVA: 0x28FEEE0 Offset: 0x28FEFE1 VA: 0x28FEEE0 Slot: 57
	protected virtual BasicMenu.Result MinusCall() { }

	// RVA: 0x28FEF80 Offset: 0x28FF081 VA: 0x28FEF80 Slot: 58
	protected virtual BasicMenu.Result CustomCall() { }

	// RVA: 0x28FF020 Offset: 0x28FF121 VA: 0x28FF020 Slot: 59
	protected virtual void PlayCursorSE() { }

	// RVA: 0x28FF0A0 Offset: 0x28FF1A1 VA: 0x28FF0A0 Slot: 60
	protected virtual void PlayDecideSE() { }

	// RVA: 0x28FF120 Offset: 0x28FF221 VA: 0x28FF120 Slot: 61
	protected virtual void PlayDecideBigSE() { }

	// RVA: 0x28FF1A0 Offset: 0x28FF2A1 VA: 0x28FF1A0 Slot: 62
	protected virtual void PlayCancelSE() { }

	// RVA: 0x28FF220 Offset: 0x28FF321 VA: 0x28FF220 Slot: 63
	protected virtual string GetTutorial() { }

	// RVA: 0x28FF230 Offset: 0x28FF331 VA: 0x28FF230
	protected void TryTutorial() { }

	// RVA: 0x28FF2F0 Offset: 0x28FF3F1 VA: 0x28FF2F0
	private static BasicMenu CreateBasicMenuCommon(List<BasicMenuItem> menuItemList, ProcInst super, bool isBind) { }

	// RVA: 0x28FF4E0 Offset: 0x28FF5E1 VA: 0x28FF4E0
	public static void CreateDummy() { }

	// RVA: 0x28FF890 Offset: 0x28FF991 VA: 0x28FF890
	public static BasicMenu CreateBasicMenuNoBind(List<BasicMenuItem> menuItemList, ProcInst super) { }

	// RVA: 0x28FF8A0 Offset: 0x28FF9A1 VA: 0x28FF8A0
	public static BasicMenu CreateBasicMenuBind(List<BasicMenuItem> menuItemList, ProcInst super) { }
}

