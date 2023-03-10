// Namespace: 
[FlagsAttribute] // RVA: 0x275CE0 Offset: 0x275DE1 VA: 0x275CE0
private enum BattleCalculator.Flags // TypeDefIndex: 9468
{
	// Fields
	public int value__; // 0x0
	public const BattleCalculator.Flags InterruptOffense = 1;
	public const BattleCalculator.Flags InterruptDefense = 2;
	public const BattleCalculator.Flags Interrupting = 4;
	public const BattleCalculator.Flags ContinueBattle = 8;
	public const BattleCalculator.Flags SwapOrder = 16;
	public const BattleCalculator.Flags Dead = 32;
	public const BattleCalculator.Flags ChainAttacked = 64;
	public const BattleCalculator.Flags Commited = 128;
	public const BattleCalculator.Flags MaskInterrupt = 7;
}

// Namespace: 
public enum BattleCalculator.Mode // TypeDefIndex: 9469
{
	// Fields
	public int value__; // 0x0
	public const BattleCalculator.Mode Battle = 0;
	public const BattleCalculator.Mode JobIntro = 1;
	public const BattleCalculator.Mode ClassChange = 2;
}

// Namespace: 
private enum BattleCalculator.TrainingResult // TypeDefIndex: 9470
{
	// Fields
	public int value__; // 0x0
	public const BattleCalculator.TrainingResult Win = 0;
	public const BattleCalculator.TrainingResult Lose = 1;
}

// Namespace: 
public enum BattleCalculator.Attributes // TypeDefIndex: 9471
{
	// Fields
	public int value__; // 0x0
	public const BattleCalculator.Attributes None = 0;
	public const BattleCalculator.Attributes Physical = 1;
	public const BattleCalculator.Attributes Magic = 2;
}

// Namespace: 
private class BattleCalculator.FlagField : BitFieldTemplate32<BattleCalculator.Flags> // TypeDefIndex: 9472
{
	// Methods

	// RVA: 0x1F72F70 Offset: 0x1F73071 VA: 0x1F72F70 Slot: 5
	protected override int ToInt(BattleCalculator.Flags value) { }

	// RVA: 0x1F72F80 Offset: 0x1F73081 VA: 0x1F72F80
	public void .ctor() { }
}

// Namespace: 
private class BattleCalculator.Order : Pool.Node // TypeDefIndex: 9473
{
	// Fields
	public BattleSide.Type Side; // 0x10

	// Methods

	// RVA: 0x1F73FF0 Offset: 0x1F740F1 VA: 0x1F73FF0 Slot: 4
	public override void OnEnter() { }

	// RVA: 0x1F74000 Offset: 0x1F74101 VA: 0x1F74000 Slot: 5
	public override void OnExit() { }

	// RVA: 0x1F74010 Offset: 0x1F74111 VA: 0x1F74010
	public void .ctor() { }
}

// Namespace: 
private class BattleCalculator.OrderList : Pool.List<BattleCalculator.Order> // TypeDefIndex: 9474
{
	// Fields
	private const int MaxOrder = 32;

	// Methods

	// RVA: 0x1F74020 Offset: 0x1F74121 VA: 0x1F74020
	public void .ctor() { }

	// RVA: 0x1F74080 Offset: 0x1F74181 VA: 0x1F74080
	public void TryAdd(BattleInfo info, BattleSide.Type side) { }

	// RVA: 0x1F740B0 Offset: 0x1F741B1 VA: 0x1F740B0
	public bool CanSwap(BattleSide.Type side, int index) { }
}

// Namespace: 
private class BattleCalculator.HitSkill : Pool.Node // TypeDefIndex: 9475
{
	// Fields
	public BattleInfoSide Side; // 0x10
	public SkillData.Actions Action; // 0x18
	public SkillData Skill; // 0x20

	// Properties
	public override int SortKey { get; }

	// Methods

	// RVA: 0x1F737C0 Offset: 0x1F738C1 VA: 0x1F737C0 Slot: 4
	public override void OnEnter() { }

	// RVA: 0x1F737D0 Offset: 0x1F738D1 VA: 0x1F737D0 Slot: 5
	public override void OnExit() { }

	// RVA: 0x1F73810 Offset: 0x1F73911 VA: 0x1F73810
	private void Clear() { }

	// RVA: 0x1F73850 Offset: 0x1F73951 VA: 0x1F73850 Slot: 6
	public override int get_SortKey() { }

	// RVA: 0x1F73870 Offset: 0x1F73971 VA: 0x1F73870
	public void .ctor() { }
}

// Namespace: 
private class BattleCalculator.HitSkillPool : Pool.List<BattleCalculator.HitSkill> // TypeDefIndex: 9476
{
	// Methods

	// RVA: 0x1F73880 Offset: 0x1F73981 VA: 0x1F73880
	public void .ctor() { }

	// RVA: 0x1F738E0 Offset: 0x1F739E1 VA: 0x1F738E0
	public void Add(BattleInfoSide side, SkillData.Timings timing, SkillData.Actions action) { }
}

// Namespace: 
private struct BattleCalculator.TargetScope : IDisposable // TypeDefIndex: 9477
{
	// Fields
	private BattleInfoSide m_Current; // 0x0
	private BattleInfoSide m_Reverse; // 0x8
	private bool m_IsDump; // 0x10

	// Methods

	// RVA: 0x1F74790 Offset: 0x1F74891 VA: 0x1F74790
	public void .ctor(BattleInfoSide current, BattleInfoSide reverse, bool isDump = False) { }

	// RVA: 0x1F748D0 Offset: 0x1F749D1 VA: 0x1F748D0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
private struct BattleCalculator.SeparatorScope : IDisposable // TypeDefIndex: 9478
{
	// Fields
	private BattleCalculator m_Calc; // 0x0
	private BattleScene.Kind m_Push; // 0x8
	private BattleScene.Kind m_Pop; // 0xC
	private BattleSide.Type m_Side; // 0x10
	private SkillData m_EquipSkill; // 0x18
	private bool m_IsDump; // 0x20

	// Methods

	// RVA: 0x1F741D0 Offset: 0x1F742D1 VA: 0x1F741D0
	public void .ctor(BattleCalculator calc, BattleSide.Type side = -1, BattleScene.Kind push = 0, BattleScene.Kind pop = 0, bool isDump = False) { }

	// RVA: 0x1F745C0 Offset: 0x1F746C1 VA: 0x1F745C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1F74760 Offset: 0x1F74861 VA: 0x1F74760
	private BattleInfoSide GetSide() { }

	// RVA: 0x1F74780 Offset: 0x1F74881 VA: 0x1F74780
	private BattleInfoSide GetSide(BattleSide.Type side) { }
}

// Namespace: 
private struct BattleCalculator.DetailScope : IDisposable // TypeDefIndex: 9479
{
	// Fields
	private BattleInfo m_Info; // 0x0

	// Methods

	// RVA: 0x1F72EF0 Offset: 0x1F72FF1 VA: 0x1F72EF0
	public void .ctor(BattleInfo info) { }

	// RVA: 0x1F72F30 Offset: 0x1F73031 VA: 0x1F72F30 Slot: 4
	public void Dispose() { }
}

// Namespace: 
private sealed class BattleCalculator.FuncExp1 : MulticastDelegate // TypeDefIndex: 9480
{
	// Methods

	// RVA: 0x1F72FE0 Offset: 0x1F730E1 VA: 0x1F72FE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F73000 Offset: 0x1F73101 VA: 0x1F73000 Slot: 13
	public virtual int Invoke(BattleInfoSide current) { }

	// RVA: 0x1F73360 Offset: 0x1F73461 VA: 0x1F73360 Slot: 14
	public virtual IAsyncResult BeginInvoke(BattleInfoSide current, AsyncCallback callback, object object) { }

	// RVA: 0x1F73390 Offset: 0x1F73491 VA: 0x1F73390 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class BattleCalculator.FuncExp2 : MulticastDelegate // TypeDefIndex: 9481
{
	// Methods

	// RVA: 0x1F733C0 Offset: 0x1F734C1 VA: 0x1F733C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F733E0 Offset: 0x1F734E1 VA: 0x1F733E0 Slot: 13
	public virtual int Invoke(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x1F73760 Offset: 0x1F73861 VA: 0x1F73760 Slot: 14
	public virtual IAsyncResult BeginInvoke(BattleInfoSide current, BattleInfoSide reverse, AsyncCallback callback, object object) { }

	// RVA: 0x1F73790 Offset: 0x1F73891 VA: 0x1F73790 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

