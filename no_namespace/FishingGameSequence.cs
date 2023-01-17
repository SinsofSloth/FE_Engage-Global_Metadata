// Namespace: 
public enum FishingGameSequence.Label // TypeDefIndex: 10589
{
	// Fields
	public int value__; // 0x0
	public const FishingGameSequence.Label None = 0;
	public const FishingGameSequence.Label Init = 1;
	public const FishingGameSequence.Label SelectRod = 2;
	public const FishingGameSequence.Label ConfirmAssist = 3;
	public const FishingGameSequence.Label MoveCircle = 4;
	public const FishingGameSequence.Label ThrowIn = 5;
	public const FishingGameSequence.Label WaitCatch = 6;
	public const FishingGameSequence.Label WaitCancel = 7;
	public const FishingGameSequence.Label AnnounceFailed = 8;
	public const FishingGameSequence.Label HitPopup = 9;
	public const FishingGameSequence.Label AssistAtack = 10;
	public const FishingGameSequence.Label Battle = 11;
	public const FishingGameSequence.Label BattleLethal = 12;
	public const FishingGameSequence.Label BattleFailed = 13;
	public const FishingGameSequence.Label DefeatMovie = 14;
	public const FishingGameSequence.Label Result = 15;
	public const FishingGameSequence.Label MascotBond = 16;
	public const FishingGameSequence.Label GetPrize = 17;
	public const FishingGameSequence.Label CheckContinue = 18;
	public const FishingGameSequence.Label InitContinue = 19;
	public const FishingGameSequence.Label Exit = 20;
}

// Namespace: 
private struct FishingGameSequence.LureRoot // TypeDefIndex: 10590
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float frame; // 0x8

	// Methods

	// RVA: 0x22DC670 Offset: 0x22DC771 VA: 0x22DC670
	public void .ctor(float setX, float setY, float setFrame) { }
}

// Namespace: 
private class FishingGameSequence.Ripple // TypeDefIndex: 10591
{
	// Fields
	private GameObject m_obj; // 0x10
	private Vector3 m_BasePos; // 0x18
	private List<int> m_SizeList; // 0x28
	private float m_BaseHeight; // 0x30
	private float m_PopIntervalBaseTime; // 0x34
	private float m_PopRandomMax; // 0x38
	private float m_Timer; // 0x3C
	private Transform m_parentNode; // 0x40

	// Methods

	// RVA: 0x22DC680 Offset: 0x22DC781 VA: 0x22DC680
	public void .ctor() { }

	// RVA: 0x22DC770 Offset: 0x22DC871 VA: 0x22DC770
	public void Init(Vector3 pos, List<int> size, float baseHeight, float baseInterval, float addRange) { }

	// RVA: 0x22DC880 Offset: 0x22DC981 VA: 0x22DC880
	public void Update() { }

	// RVA: 0x22DCB50 Offset: 0x22DCC51 VA: 0x22DCB50
	public void DestroyObjSoon() { }
}

// Namespace: 
private enum FishingGameSequence.FishingAngleState // TypeDefIndex: 10592
{
	// Fields
	public int value__; // 0x0
	public const FishingGameSequence.FishingAngleState Center = 0;
	public const FishingGameSequence.FishingAngleState Right = 1;
	public const FishingGameSequence.FishingAngleState Left = 2;
	public const FishingGameSequence.FishingAngleState Lethal = 3;
	public const FishingGameSequence.FishingAngleState AngleStateCount = 4;
}

// Namespace: 
private enum FishingGameSequence.AnnounceType // TypeDefIndex: 10593
{
	// Fields
	public int value__; // 0x0
	public const FishingGameSequence.AnnounceType None = 0;
	public const FishingGameSequence.AnnounceType Fast = 1;
	public const FishingGameSequence.AnnounceType Slow = 2;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276FC0 Offset: 0x2770C1 VA: 0x276FC0
[Serializable]
private sealed class FishingGameSequence.<>c // TypeDefIndex: 10594
{
	// Fields
	public static readonly FishingGameSequence.<>c <>9; // 0x0
	public static FishingRodSelectMenu.DecideEventHandler <>9__188_0; // 0x8
	public static FishingContinueDialog.DecideEventHandler <>9__215_0; // 0x10
	public static ProcBoolMethod <>9__248_0; // 0x18
	public static ProcBoolMethod <>9__248_1; // 0x20

	// Methods

	// RVA: 0x22DC420 Offset: 0x22DC521 VA: 0x22DC420
	private static void .cctor() { }

	// RVA: 0x22DC490 Offset: 0x22DC591 VA: 0x22DC490
	public void .ctor() { }

	// RVA: 0x22DC4A0 Offset: 0x22DC5A1 VA: 0x22DC4A0
	internal void <CreateRodSelectMenu>b__188_0(StickType r) { }

	// RVA: 0x22DC510 Offset: 0x22DC611 VA: 0x22DC510
	internal void <CreateContinueDialog>b__215_0(bool r) { }

	// RVA: 0x22DC590 Offset: 0x22DC691 VA: 0x22DC590
	internal bool <CreateBind>b__248_0() { }

	// RVA: 0x22DC600 Offset: 0x22DC701 VA: 0x22DC600
	internal bool <CreateBind>b__248_1() { }
}

