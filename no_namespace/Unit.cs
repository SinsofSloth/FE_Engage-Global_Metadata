// Namespace: 
[FlagsAttribute] // RVA: 0x278E30 Offset: 0x278F31 VA: 0x278E30
public enum Unit.Status // TypeDefIndex: 13484
{
	// Fields
	public long value__; // 0x0
	public const Unit.Status Fixed = 1;
	public const Unit.Status MoveNotAllow = 2;
	public const Unit.Status MustSortie = 4;
	public const Unit.Status NeverSortie = 8;
	public const Unit.Status DontPosChange = 16;
	public const Unit.Status DangerShowing = 32;
	public const Unit.Status ChainGuard = 64;
	public const Unit.Status DualGuard = 128;
	public const Unit.Status Sortie = 256;
	public const Unit.Status Dead = 512;
	public const Unit.Status EscapeHere = 1024;
	public const Unit.Status DiedHere = 2048;
	public const Unit.Status JoinHere = 4096;
	public const Unit.Status PureHide = 8192;
	public const Unit.Status DisposHide = 16384;
	public const Unit.Status ViewOut = 32768;
	public const Unit.Status UnderRoof = 65536;
	public const Unit.Status LockedUpdate = 131072;
	public const Unit.Status Removing = 262144;
	public const Unit.Status Remagicing = 524288;
	public const Unit.Status Rerewarping = 1048576;
	public const Unit.Status Guest = 2097152;
	public const Unit.Status DisposGuset = 4194304;
	public const Unit.Status Engaging = 8388608;
	public const Unit.Status EngageAttack = 16777216;
	public const Unit.Status EngageLinked = 33554432;
	public const Unit.Status EngageAttacked = 67108864;
	public const Unit.Status Vision = 134217728;
	public const Unit.Status ExistDead = 268435456;
	public const Unit.Status Continued = 536870912;
	public const Unit.Status Defect = 1073741824;
	public const Unit.Status BowCannon = 4294967296;
	public const Unit.Status MagicCannon = 8589934592;
	public const Unit.Status FireCannon = 17179869184;
	public const Unit.Status IgnoreWholeSkill = 68719476736;
	public const Unit.Status IgnoreEquipSkill = 137438953472;
	public const Unit.Status IgnoreEquipEnhance = 274877906944;
	public const Unit.Status RelayLeave = 549755813888;
	public const Unit.Status IgnoreImmortal = 1099511627776;
	public const Unit.Status IgnoreGodUnit = 2199023255552;
	public const Unit.Status IgonreMapEnhance = 4398046511104;
	public const Unit.Status BeforeSortied = 8796093022208;
	public const Unit.Status IgnoreSupportedSkill = 17592186044416;
	public const Unit.Status Summon = 35184372088832;
	public const Unit.Status Lockon = 70368744177664;
	public const Unit.Status Reacted = 140737488355328;
	public const Unit.Status HoldHp = 281474976710656;
	public const Unit.Status IgnoreMapHistory = 562949953421312;
	public const Unit.Status ChangeEngaged = 1125899906842624;
	public const Unit.Status LockedSupport = 2251799813685248;
	public const Unit.Status HideImage = 8192;
	public const Unit.Status HideRender = 122880;
	public const Unit.Status NotTarget = 65536;
	public const Unit.Status InitMapBegin = 1130298490224924;
	public const Unit.Status InitPhaseBegin = 1125899906842816;
	public const Unit.Status InitPhaseEnd = 1548112424075265;
	public const Unit.Status InitMapEnd = 3874680177943037;
	public const Unit.Status DeadMask = 268438016;
	public const Unit.Status GuardMask = 192;
	public const Unit.Status EngageMask = 125829248;
	public const Unit.Status FixedMask = 70368744177857;
	public const Unit.Status CannonMask = 30064771072;
	public const Unit.Status ReactionMask = 1835008;
	public const Unit.Status SaveMask = -1;
}

// Namespace: 
private struct Unit.ChangeValue // TypeDefIndex: 13486
{
	// Fields
	private byte m_Value; // 0x0
	private byte m_Display; // 0x1

	// Properties
	public byte Value { get; set; }
	public byte Display { get; }

	// Methods

	// RVA: 0x23AB170 Offset: 0x23AB271 VA: 0x23AB170
	public byte get_Value() { }

	// RVA: 0x23AB180 Offset: 0x23AB281 VA: 0x23AB180
	public void set_Value(byte value) { }

	// RVA: 0x23AB190 Offset: 0x23AB291 VA: 0x23AB190
	public byte get_Display() { }

	// RVA: 0x23AB1A0 Offset: 0x23AB2A1 VA: 0x23AB1A0
	public void Change(int value) { }

	// RVA: 0x23AB250 Offset: 0x23AB351 VA: 0x23AB250
	public void Tick() { }

	// RVA: 0x23AB3A0 Offset: 0x23AB4A1 VA: 0x23AB3A0
	public bool IsChanging() { }

	// RVA: 0x23AB240 Offset: 0x23AB341 VA: 0x23AB240
	public void Instant() { }

	// RVA: 0x23AB3C0 Offset: 0x23AB4C1 VA: 0x23AB3C0
	public static byte op_Implicit(Unit.ChangeValue v) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278E40 Offset: 0x278F41 VA: 0x278E40
[Serializable]
private sealed class Unit.ItemsForSelectedWeapon.<>c // TypeDefIndex: 13488
{
	// Fields
	public static readonly Unit.ItemsForSelectedWeapon.<>c <>9; // 0x0
	public static Comparison<ItemData> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x2D68EF0 Offset: 0x2D68FF1 VA: 0x2D68EF0
	private static void .cctor() { }

	// RVA: 0x2D68F60 Offset: 0x2D69061 VA: 0x2D68F60
	public void .ctor() { }

	// RVA: 0x2D68F70 Offset: 0x2D69071 VA: 0x2D68F70
	internal int <Sort>b__1_0(ItemData itemA, ItemData itemB) { }
}

// Namespace: 
private class Unit.ChartItemsForSelectedWeapon : Unit.ItemsForSelectedWeapon // TypeDefIndex: 13490
{
	// Fields
	private ChartData.Item[] m_ChartItems; // 0x18

	// Methods

	// RVA: 0x23AB3D0 Offset: 0x23AB4D1 VA: 0x23AB3D0
	public void .ctor(ChartData.Item[] chartItems) { }

	// RVA: 0x23AB420 Offset: 0x23AB521 VA: 0x23AB420 Slot: 4
	protected override void Prepare() { }
}

// Namespace: 
public sealed class Unit.FuncUnitItem : MulticastDelegate // TypeDefIndex: 13492
{
	// Methods

	// RVA: 0x23AB7F0 Offset: 0x23AB8F1 VA: 0x23AB7F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x23AA0E0 Offset: 0x23AA1E1 VA: 0x23AA0E0 Slot: 13
	public virtual void Invoke(UnitItem unitItem) { }

	// RVA: 0x23AB810 Offset: 0x23AB911 VA: 0x23AB810 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnitItem unitItem, AsyncCallback callback, object object) { }

	// RVA: 0x23AB840 Offset: 0x23AB941 VA: 0x23AB840 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278E50 Offset: 0x278F51 VA: 0x278E50
private struct Unit.<>c__DisplayClass416_0 // TypeDefIndex: 13494
{
	// Fields
	public bool isBullet; // 0x0
	public Unit <>4__this; // 0x8
}

