// Namespace: App
public class HelpManager : SingletonMonoBehaviour<HelpManager> // TypeDefIndex: 11817
{
	// Fields
	public HelpParamSetter m_HelpParamSetter; // 0x20
	private List<HelpItemList> m_HelpList; // 0x28
	private List<HelpManager.Item> m_ItemList; // 0x30
	private int m_CurrentIndex; // 0x38
	private HelpManager.SituationType m_SituationType; // 0x3C
	private HelpManager.Item.Dir m_PreviousDir; // 0x40
	private Vector2 m_AxisPos; // 0x44

	// Methods

	// RVA: 0x2DBCD50 Offset: 0x2DBCE51 VA: 0x2DBCD50
	public static void Add(HelpItemList list) { }

	// RVA: 0x2DBCE20 Offset: 0x2DBCF21 VA: 0x2DBCE20
	public static void Remove(HelpItemList list) { }

	// RVA: 0x2DBE860 Offset: 0x2DBE961 VA: 0x2DBE860
	public bool Setup(bool isTempGod, GodUnit tempGod, bool isTempRing, UnitRing tempRing, bool isTempUnit, Unit tempUnit) { }

	// RVA: 0x2DC22A0 Offset: 0x2DC23A1 VA: 0x2DC22A0
	public void SetContents(bool immediate) { }

	// RVA: 0x2DC2350 Offset: 0x2DC2451 VA: 0x2DC2350
	public bool Up(bool isTrigger) { }

	// RVA: 0x2DC2630 Offset: 0x2DC2731 VA: 0x2DC2630
	public bool Down(bool isTrigger) { }

	// RVA: 0x2DC2640 Offset: 0x2DC2741 VA: 0x2DC2640
	public bool Left(bool isTrigger) { }

	// RVA: 0x2DC2650 Offset: 0x2DC2751 VA: 0x2DC2650
	public bool Right(bool isTrigger) { }

	// RVA: 0x2DC2660 Offset: 0x2DC2761 VA: 0x2DC2660
	private float Dot(Vector2 ab, Vector2 p) { }

	// RVA: 0x2DC2680 Offset: 0x2DC2781 VA: 0x2DC2680
	private bool SearchDestItem(int dirIdx, int pairDirIdx, Vector2 curPos, Vector2 curA, Vector2 curB, Vector2 curAB, bool isMoveToNoTouchItem, bool isLoop = False, Vector2 loopLimit) { }

	// RVA: 0x2DC2360 Offset: 0x2DC2461 VA: 0x2DC2360
	private bool MoveImpl(HelpManager.Item.Dir dir, bool isTrigger) { }

	// RVA: 0x2DC20A0 Offset: 0x2DC21A1 VA: 0x2DC20A0
	private bool IsHelpValid(HelpItemBase hib) { }

	// RVA: 0x2DC2140 Offset: 0x2DC2241 VA: 0x2DC2140
	private int StartItemPriority(HelpItemBase hib) { }

	// RVA: 0x2DC21F0 Offset: 0x2DC22F1 VA: 0x2DC21F0
	private int StartItemConstPriority(HelpItemBase hib) { }

	// RVA: 0x2DC2AB0 Offset: 0x2DC2BB1 VA: 0x2DC2AB0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6A90 Offset: 0x2C6B91 VA: 0x2C6A90
	// RVA: 0x2DC2BE0 Offset: 0x2DC2CE1 VA: 0x2DC2BE0
	internal static int <Setup>g__SortCompareX|12_7(HelpManager.Item a, HelpManager.Item b) { }
}

