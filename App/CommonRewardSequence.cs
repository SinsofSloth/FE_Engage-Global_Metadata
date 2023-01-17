// Namespace: App
public class CommonRewardSequence : ProcInst // TypeDefIndex: 12597
{
	// Fields
	private MenuBg m_Bg; // 0x70
	private Dictionary<Unit, int> m_RewardExpList; // 0x78
	private List<ItemData> m_RewardItemList; // 0x80
	private int m_RewardMoney; // 0x88
	private bool m_IsDiscard; // 0x8C
	private bool m_IsCreateBg; // 0x8D
	private bool m_IsClear; // 0x8E
	private string TitleMID; // 0x90
	private Dictionary<Unit, int> m_LevelUpUnitList; // 0x98

	// Methods

	// RVA: 0x23AEEE0 Offset: 0x23AEFE1 VA: 0x23AEEE0
	public static void CreateBind(ProcInst super, Dictionary<Unit, int> rewardExpList, List<ItemData> rewardList, int rewardMoney = 0, bool isCreateBg = False) { }

	// RVA: 0x23AF860 Offset: 0x23AF961 VA: 0x23AF860
	public static void CreateBindClear(ProcInst super, List<ItemData> rewardList) { }

	// RVA: 0x23AF8F0 Offset: 0x23AF9F1 VA: 0x23AF8F0
	public static void CreateBindForWell(ProcInst super, List<ItemData> rewardList, string title) { }

	// RVA: 0x23AEF90 Offset: 0x23AF091 VA: 0x23AEF90
	private void .ctor(Dictionary<Unit, int> rewardExpList, List<ItemData> rewardItemList, int rewardMoney, bool isCreateBg, bool isClear) { }

	// RVA: 0x23AF110 Offset: 0x23AF211 VA: 0x23AF110
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x23AF9A0 Offset: 0x23AFAA1 VA: 0x23AF9A0
	private ProcDesc[] CreateDescForWell() { }

	// RVA: 0x23AFE10 Offset: 0x23AFF11 VA: 0x23AFE10
	private void LoadRes() { }

	// RVA: 0x23AFE40 Offset: 0x23AFF41 VA: 0x23AFE40
	private bool IsLoadingRes() { }

	// RVA: 0x23AFE80 Offset: 0x23AFF81 VA: 0x23AFE80
	private void OpenRewardExp() { }

	// RVA: 0x23AFFA0 Offset: 0x23B00A1 VA: 0x23AFFA0
	private void CheckLevelUp() { }

	// RVA: 0x23B0190 Offset: 0x23B0291 VA: 0x23B0190
	public static ProcInst TryCreateBindDiscardMessage(ProcInst super, bool discard) { }

	// RVA: 0x23B01A0 Offset: 0x23B02A1 VA: 0x23B01A0
	public static Dictionary<ItemData, int> CalcRewardItemList(List<ItemData> itemList, ref int money, ref bool discard) { }

	// RVA: 0x23B0580 Offset: 0x23B0681 VA: 0x23B0580
	private Dictionary<ItemData, int> CalcRewardItemList() { }

	// RVA: 0x23B05A0 Offset: 0x23B06A1 VA: 0x23B05A0
	private void OpenRewardItem() { }

	// RVA: 0x23B0730 Offset: 0x23B0831 VA: 0x23B0730
	private void OpenRewardItemForWell() { }

	// RVA: 0x23B0FE0 Offset: 0x23B10E1 VA: 0x23B0FE0
	private void Close() { }

	// RVA: 0x23B1090 Offset: 0x23B1191 VA: 0x23B1090
	private void CheckItemOverflow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9B30 Offset: 0x2C9C31 VA: 0x2C9B30
	// RVA: 0x23B10A0 Offset: 0x23B11A1 VA: 0x23B10A0
	private bool <CreateDesc>b__14_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9B40 Offset: 0x2C9C41 VA: 0x2C9B40
	// RVA: 0x23B10B0 Offset: 0x23B11B1 VA: 0x23B10B0
	private bool <CreateDesc>b__14_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9B50 Offset: 0x2C9C51 VA: 0x2C9B50
	// RVA: 0x23B10C0 Offset: 0x23B11C1 VA: 0x23B10C0
	private void <OpenRewardExp>b__18_0(Unit unit, int levelOld) { }
}

