// Namespace: App
public class BasicMenuContent : MonoBehaviour // TypeDefIndex: 12519
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	[SerializeField] // RVA: 0x29A830 Offset: 0x29A931 VA: 0x29A830
	public Material m_srcMaterial; // 0x18
	protected Material m_material; // 0x20
	protected BasicMenu m_menu; // 0x28
	protected Animator m_winAnimator; // 0x30
	protected GameObject m_objMenu; // 0x38
	protected GameObject m_objFrontCursor; // 0x40
	protected GameObject m_objBackCursor; // 0x48
	protected GameObject m_objViewport; // 0x50
	protected GameObject m_objVerticalScrollBar; // 0x58
	protected GameObject m_objScrollBarHandle; // 0x60
	protected GameObject m_objContent; // 0x68
	protected GameObject m_objSubMenuBase; // 0x70
	protected GameObject m_backContent; // 0x78
	protected BasicMenuContent.Cursor m_cursor; // 0x80
	protected BasicMenuContent.Scroll m_scroll; // 0x88
	protected Vector2 m_pos; // 0x90
	protected Vector2 m_posOld; // 0x98
	protected BasicMenu.AnchorType m_anchorType; // 0xA0
	protected Vector2 m_anchoredPosOriginal; // 0xA4
	protected Vector2 m_anchorMinOriginal; // 0xAC
	protected Vector2 m_anchorMaxOriginal; // 0xB4
	protected Vector3 m_objContentBaseLocalPos; // 0xBC
	protected Vector3 m_backContentBaseLocalPos; // 0xC8
	protected Color m_color; // 0xD4
	protected bool m_requestAdjust; // 0xE4

	// Methods

	// RVA: 0x28F2FD0 Offset: 0x28F30D1 VA: 0x28F2FD0
	protected void .ctor() { }

	// RVA: 0x28FFAB0 Offset: 0x28FFBB1 VA: 0x28FFAB0 Slot: 4
	public virtual int GetMenuItemContentMax() { }

	// RVA: 0x28FFB50 Offset: 0x28FFC51 VA: 0x28FFB50 Slot: 5
	public virtual RectTransform GetRectTransform() { }

	// RVA: 0x28FFC60 Offset: 0x28FFD61 VA: 0x28FFC60
	public BasicMenu GetMenu() { }

	// RVA: 0x28FFC70 Offset: 0x28FFD71 VA: 0x28FFC70
	public void SetMenu(BasicMenu menu) { }

	// RVA: 0x28FFC80 Offset: 0x28FFD81 VA: 0x28FFC80 Slot: 6
	public virtual bool IsOpening() { }

	// RVA: 0x28FFD30 Offset: 0x28FFE31 VA: 0x28FFD30 Slot: 7
	public virtual bool IsClosing() { }

	// RVA: 0x28FFDE0 Offset: 0x28FFEE1 VA: 0x28FFDE0 Slot: 8
	public virtual bool IsClosed() { }

	// RVA: 0x28FFE90 Offset: 0x28FFF91 VA: 0x28FFE90
	public void SetAnimator(Animator anim) { }

	// RVA: 0x28FFEA0 Offset: 0x28FFFA1 VA: 0x28FFEA0 Slot: 9
	protected virtual float CalcCursorMovedPosX(int menuItemIndex) { }

	// RVA: 0x2900020 Offset: 0x2900121 VA: 0x2900020 Slot: 10
	protected virtual float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x29003B0 Offset: 0x29004B1 VA: 0x29003B0 Slot: 11
	protected virtual float CalcCursorWidth(int menuItemIndex) { }

	// RVA: 0x2900540 Offset: 0x2900641 VA: 0x2900540 Slot: 12
	protected virtual float CalcCursorHeight(int menuItemIndex) { }

	// RVA: 0x29003C0 Offset: 0x29004C1 VA: 0x29003C0
	protected float NowCursorWidth() { }

	// RVA: 0x2900550 Offset: 0x2900651 VA: 0x2900550
	protected float NowCursorHeight() { }

	// RVA: 0x28F1CF0 Offset: 0x28F1DF1 VA: 0x28F1CF0
	protected float GetScreenScale() { }

	// RVA: 0x28F1FD0 Offset: 0x28F20D1 VA: 0x28F1FD0 Slot: 13
	protected virtual void InitObjReference() { }

	// RVA: 0x28F9CA0 Offset: 0x28F9DA1 VA: 0x28F9CA0
	public void Delete() { }

	// RVA: 0x28FA7A0 Offset: 0x28FA8A1 VA: 0x28FA7A0
	public void SetCursorMoveFrame(float frame) { }

	// RVA: 0x28FA7B0 Offset: 0x28FA8B1 VA: 0x28FA7B0
	public void CursorMoveInstant() { }

	// RVA: 0x28FA7D0 Offset: 0x28FA8D1 VA: 0x28FA7D0
	public void SetScrollFrame(float frame) { }

	// RVA: 0x29006D0 Offset: 0x29007D1 VA: 0x29006D0
	public void SetScrollBarHandleSize(float size) { }

	// RVA: 0x28FDFD0 Offset: 0x28FE0D1 VA: 0x28FDFD0
	public bool IsScrollBusy() { }

	// RVA: 0x28FA7E0 Offset: 0x28FA8E1 VA: 0x28FA7E0
	public void ScrollInstant() { }

	// RVA: 0x28F9490 Offset: 0x28F9591 VA: 0x28F9490
	public void ResetScroll() { }

	// RVA: 0x2900AE0 Offset: 0x2900BE1 VA: 0x2900AE0 Slot: 14
	public virtual void SetCursorColor(Color c) { }

	// RVA: 0x28FAAB0 Offset: 0x28FABB1 VA: 0x28FAAB0
	public void PutCursorInFront() { }

	// RVA: 0x28FABC0 Offset: 0x28FACC1 VA: 0x28FABC0
	public void PutCursorInBack() { }

	// RVA: 0x28FA850 Offset: 0x28FA951 VA: 0x28FA850
	public void SetCursorToKeepAnimatorState(bool keep) { }

	// RVA: 0x28FA870 Offset: 0x28FA971 VA: 0x28FA870
	public void MoveFrontCursorFrom(float fromX, float fromY, float frame) { }

	// RVA: 0x28FA890 Offset: 0x28FA991 VA: 0x28FA890
	public void MoveFrontCursorFrom(BasicMenuItem fromMenuItem, float frame) { }

	// RVA: 0x2900E20 Offset: 0x2900F21 VA: 0x2900E20
	public void SetFrontCursorVisibility(bool visibility) { }

	// RVA: 0x28FACC0 Offset: 0x28FADC1 VA: 0x28FACC0
	public void RestartCursorAnim() { }

	// RVA: 0x28FAD70 Offset: 0x28FAE71 VA: 0x28FAD70
	public RectTransform GetSubMenuBaseTransform() { }

	// RVA: 0x2900E30 Offset: 0x2900F31 VA: 0x2900E30 Slot: 15
	public virtual void Suspend() { }

	// RVA: 0x2900E70 Offset: 0x2900F71 VA: 0x2900E70 Slot: 16
	public virtual void UnSuspend() { }

	// RVA: 0x2900EB0 Offset: 0x2900FB1 VA: 0x2900EB0 Slot: 17
	public virtual void SetColor(Color color) { }

	// RVA: 0x28F2770 Offset: 0x28F2871 VA: 0x28F2770 Slot: 18
	public virtual void BuildMenuItemContent() { }

	// RVA: 0x29010D0 Offset: 0x29011D1 VA: 0x29010D0 Slot: 19
	public virtual void BuildMaterial() { }

	// RVA: 0x28F17F0 Offset: 0x28F18F1 VA: 0x28F17F0 Slot: 20
	public virtual void BuildWH() { }

	// RVA: 0x29010E0 Offset: 0x29011E1 VA: 0x29010E0
	protected void BuildContentPos() { }

	// RVA: 0x2901360 Offset: 0x2901461 VA: 0x2901360 Slot: 21
	public virtual float CalcW() { }

	// RVA: 0x2901600 Offset: 0x2901701 VA: 0x2901600 Slot: 22
	public virtual float CalcH() { }

	// RVA: 0x29016A0 Offset: 0x29017A1 VA: 0x29016A0 Slot: 23
	protected virtual float GetCursorOffsetX() { }

	// RVA: 0x29016B0 Offset: 0x29017B1 VA: 0x29016B0 Slot: 24
	protected virtual float GetCursorOffsetY() { }

	// RVA: 0x29016C0 Offset: 0x29017C1 VA: 0x29016C0 Slot: 25
	public virtual void OpenAnime() { }

	// RVA: 0x2901730 Offset: 0x2901831 VA: 0x2901730 Slot: 26
	public virtual void CloseAnime() { }

	// RVA: 0x2901810 Offset: 0x2901911 VA: 0x2901810 Slot: 27
	public virtual void AfterBuild() { }

	// RVA: 0x28FAF50 Offset: 0x28FB051 VA: 0x28FAF50
	public void SetPivot(float x, float y) { }

	// RVA: 0x2901820 Offset: 0x2901921 VA: 0x2901820
	public BasicMenu.AnchorType GetAnchorType() { }

	// RVA: 0x28FAFA0 Offset: 0x28FB0A1 VA: 0x28FAFA0
	public void SetAnchorType(BasicMenu.AnchorType anchorType, float x, float y) { }

	// RVA: 0x28FB1B0 Offset: 0x28FB2B1 VA: 0x28FB1B0
	public void SetAnchorTypeFromScreenCoord(BasicMenu.AnchorType anchorType, float x, float y) { }

	// RVA: 0x28FB390 Offset: 0x28FB491 VA: 0x28FB390
	public static BasicMenu.AnchorType AnchorPositionToAnchorType(float x, float y) { }

	// RVA: 0x2901830 Offset: 0x2901931 VA: 0x2901830
	public Vector2 ScreenPointToLocalPoint(float x, float y) { }

	// RVA: 0x28FB420 Offset: 0x28FB521 VA: 0x28FB420
	public float GetX() { }

	// RVA: 0x28F1AA0 Offset: 0x28F1BA1 VA: 0x28F1AA0
	public float GetY() { }

	// RVA: 0x29018E0 Offset: 0x29019E1 VA: 0x29018E0
	public Vector2 GetPos() { }

	// RVA: 0x28FB450 Offset: 0x28FB551 VA: 0x28FB450
	public void SetX(float x) { }

	// RVA: 0x28FB470 Offset: 0x28FB571 VA: 0x28FB470
	public void SetY(float y) { }

	// RVA: 0x28FB490 Offset: 0x28FB591 VA: 0x28FB490
	public void SetPos(float x, float y) { }

	// RVA: 0x28FB4B0 Offset: 0x28FB5B1 VA: 0x28FB4B0
	public void SetTransformAsSubMenu(BasicMenu parentMenu, BasicMenuItem parentMenuItem) { }

	// RVA: 0x28F92A0 Offset: 0x28F93A1 VA: 0x28F92A0
	public void UpdateX() { }

	// RVA: 0x28F93A0 Offset: 0x28F94A1 VA: 0x28F93A0
	public void UpdateY() { }

	// RVA: 0x29018F0 Offset: 0x29019F1 VA: 0x29018F0
	public void UpdatePos() { }

	// RVA: 0x28F1980 Offset: 0x28F1A81 VA: 0x28F1980
	public float GetW() { }

	// RVA: 0x28FB7D0 Offset: 0x28FB8D1 VA: 0x28FB7D0
	public float GetH() { }

	// RVA: 0x29006E0 Offset: 0x29007E1 VA: 0x29006E0
	protected void UpdateAfterScroll(bool isForceUpdate = False) { }

	// RVA: 0x28F94D0 Offset: 0x28F95D1 VA: 0x28F94D0
	public void ForceRebuildLayout() { }

	// RVA: 0x2901920 Offset: 0x2901A21 VA: 0x2901920 Slot: 28
	protected virtual void CycleMenuItemContent(bool isForward, int cycleCount) { }

	// RVA: 0x29021B0 Offset: 0x29022B1 VA: 0x29021B0 Slot: 29
	protected virtual float GetLineHeightForScroll() { }

	// RVA: 0x29023B0 Offset: 0x29024B1 VA: 0x29023B0 Slot: 30
	protected virtual void Awake() { }

	// RVA: 0x2902520 Offset: 0x2902621 VA: 0x2902520
	private static string CalcName(string menuName, string assetName) { }

	// RVA: 0x2902600 Offset: 0x2902701 VA: 0x2902600 Slot: 31
	protected virtual void Start() { }

	// RVA: 0x2902830 Offset: 0x2902931 VA: 0x2902830 Slot: 32
	protected virtual void Update() { }

	// RVA: 0x2902BB0 Offset: 0x2902CB1 VA: 0x2902BB0 Slot: 33
	protected virtual void OnDestroy() { }

	// RVA: 0x2902C30 Offset: 0x2902D31 VA: 0x2902C30
	public static void LoadPrefabAsync() { }

	// RVA: 0x28FF460 Offset: 0x28FF561 VA: 0x28FF460
	public static BasicMenuContent Create() { }

	// RVA: 0x28F2E40 Offset: 0x28F2F41 VA: 0x28F2E40
	public static void LoadPrefabAsync(string path) { }

	// RVA: 0x2902D00 Offset: 0x2902E01 VA: 0x2902D00
	public static void UnloadPrefab(string path) { }

	// RVA: 0x2902D70 Offset: 0x2902E71 VA: 0x2902D70
	public static bool IsLoadingPrefab(string path) { }

	// RVA: -1 Offset: -1
	public static T Create<T>(string path, GameObject parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2299D40 Offset: 0x2299E41 VA: 0x2299D40
	|-BasicMenuContent.Create<BasicDialogContent>
	|-BasicMenuContent.Create<BasicItemMenuContent>
	|-BasicMenuContent.Create<BasicMenuContent>
	|-BasicMenuContent.Create<ExchangeDialogContent>
	|-BasicMenuContent.Create<GameMessageContent>
	|-BasicMenuContent.Create<GridMenuContent>
	|-BasicMenuContent.Create<ItemListDialogContent>
	|-BasicMenuContent.Create<MapUnitCommandMenuContent>
	|-BasicMenuContent.Create<NameCheckDialogContent>
	|-BasicMenuContent.Create<object>
	|-BasicMenuContent.Create<SortieSubMenuContent>
	|-BasicMenuContent.Create<SortieTopMenuContent>
	|-BasicMenuContent.Create<TradeMenuContent>
	*/

	// RVA: -1 Offset: -1
	public static T Create<T>(GameObject srcObjMenu, GameObject parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2299E90 Offset: 0x2299F91 VA: 0x2299E90
	|-BasicMenuContent.Create<object>
	|-BasicMenuContent.Create<RingListSkillMenu.MenuContent>
	*/

	// RVA: 0x2902DE0 Offset: 0x2902EE1 VA: 0x2902DE0
	public static GameObject GetCanvas() { }

	// RVA: 0x2902E30 Offset: 0x2902F31 VA: 0x2902E30
	private static void .cctor() { }
}

