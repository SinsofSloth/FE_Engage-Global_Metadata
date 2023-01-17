// Namespace: Combat
internal abstract class Deco_Rod : Decorator // TypeDefIndex: 8453
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x2EACBC0 Offset: 0x2EACCC1 VA: 0x2EACBC0 Slot: 4
	public override string get_Name() { }

	// RVA: 0x2EACC10 Offset: 0x2EACD11 VA: 0x2EACC10 Slot: 5
	public override void OnEnter() { }

	// RVA: 0x2EACC20 Offset: 0x2EACD21 VA: 0x2EACC20
	protected void .ctor() { }
}

// Namespace: Combat
internal sealed class Deco_RodHeal : Deco_Rod // TypeDefIndex: 8454
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x2EAD390 Offset: 0x2EAD491 VA: 0x2EAD390 Slot: 4
	public override string get_Name() { }

	// RVA: 0x2EAD3E0 Offset: 0x2EAD4E1 VA: 0x2EAD3E0
	public static bool IsAvailable(DecoratorArgs that) { }

	// RVA: 0x2EAD530 Offset: 0x2EAD631 VA: 0x2EAD530 Slot: 14
	public override void OnEnemyDamage_(AnimationEvent ev) { }

	// RVA: 0x2EAD620 Offset: 0x2EAD721 VA: 0x2EAD620
	public void .ctor() { }
}

// Namespace: Combat
internal sealed class Deco_RodCollapse : Deco_Rod // TypeDefIndex: 8456
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x2EAD0D0 Offset: 0x2EAD1D1 VA: 0x2EAD0D0 Slot: 4
	public override string get_Name() { }

	// RVA: 0x2EAD120 Offset: 0x2EAD221 VA: 0x2EAD120
	public static bool IsAvailable(DecoratorArgs that) { }

	// RVA: 0x2EAD220 Offset: 0x2EAD321 VA: 0x2EAD220 Slot: 14
	public override void OnEnemyDamage_(AnimationEvent ev) { }

	// RVA: 0x2EAD380 Offset: 0x2EAD481 VA: 0x2EAD380
	public void .ctor() { }
}

// Namespace: Combat
internal sealed class Deco_RodWarp : Deco_Rod // TypeDefIndex: 8457
{
	// Fields
	private ItemData.UseTypes m_Use; // 0x28
	private Character m_Target; // 0x30
	private float m_FinalAlpha; // 0x38

	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x2EAD630 Offset: 0x2EAD731 VA: 0x2EAD630 Slot: 4
	public override string get_Name() { }

	// RVA: 0x2EAD680 Offset: 0x2EAD781 VA: 0x2EAD680
	public static bool IsAvailable(DecoratorArgs that) { }

	// RVA: 0x2EAD700 Offset: 0x2EAD801 VA: 0x2EAD700 Slot: 5
	public override void OnEnter() { }

	// RVA: 0x2EAD8C0 Offset: 0x2EAD9C1 VA: 0x2EAD8C0 Slot: 13
	public override void OnHitPassed(AnimationEvent ev) { }

	// RVA: 0x2EAD9B0 Offset: 0x2EADAB1 VA: 0x2EAD9B0
	private void UpdateAlpha() { }

	// RVA: 0x2EADA90 Offset: 0x2EADB91 VA: 0x2EADA90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A88C0 Offset: 0x2A89C1 VA: 0x2A88C0
	// RVA: 0x2EADAA0 Offset: 0x2EADBA1 VA: 0x2EADAA0
	private void <OnEnter>b__6_0(Unit _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A88D0 Offset: 0x2A89D1 VA: 0x2A88D0
	// RVA: 0x2EADAD0 Offset: 0x2EADBD1 VA: 0x2EADAD0
	private void <OnHitPassed>b__7_0() { }
}

// Namespace: Combat
internal sealed class Deco_RodWeak : Deco_Rod // TypeDefIndex: 8458
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x2EADB20 Offset: 0x2EADC21 VA: 0x2EADB20 Slot: 4
	public override string get_Name() { }

	// RVA: 0x2EADB70 Offset: 0x2EADC71 VA: 0x2EADB70
	public static bool IsAvailable(DecoratorArgs that) { }

	// RVA: 0x2EADCF0 Offset: 0x2EADDF1 VA: 0x2EADCF0 Slot: 14
	public override void OnEnemyDamage_(AnimationEvent ev) { }

	// RVA: 0x2EADD30 Offset: 0x2EADE31 VA: 0x2EADD30
	public void .ctor() { }
}

// Namespace: Combat
internal sealed class Deco_RodBlock : Deco_Rod // TypeDefIndex: 8459
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x2EACC30 Offset: 0x2EACD31 VA: 0x2EACC30 Slot: 4
	public override string get_Name() { }

	// RVA: 0x2EACC80 Offset: 0x2EACD81 VA: 0x2EACC80
	public static bool IsAvailable(DecoratorArgs that) { }

	// RVA: 0x2EACCB0 Offset: 0x2EACDB1 VA: 0x2EACCB0 Slot: 5
	public override void OnEnter() { }

	// RVA: 0x2EACDB0 Offset: 0x2EACEB1 VA: 0x2EACDB0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A88E0 Offset: 0x2A89E1 VA: 0x2A88E0
	// RVA: 0x2EACDC0 Offset: 0x2EACEC1 VA: 0x2EACDC0
	private void <OnEnter>b__3_0(Unit _) { }
}

// Namespace: Combat
internal sealed class Deco_自爆 : Decorator // TypeDefIndex: 8460
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x236F400 Offset: 0x236F501 VA: 0x236F400 Slot: 4
	public override string get_Name() { }

	// RVA: 0x236F450 Offset: 0x236F551 VA: 0x236F450
	public static bool IsAvailable(DecoratorArgs that) { }

	// RVA: 0x236F4F0 Offset: 0x236F5F1 VA: 0x236F4F0
	public void .ctor() { }
}

// Namespace: Combat
internal class Deco_Skill : Decorator // TypeDefIndex: 8463
{
	// Fields
	protected SkillStack.Packet m_Pair; // 0x28
	private bool m_bNameShown; // 0x30

	// Properties
	public override string Name { get; }
	public SkillStack.Packet Pair { set; }

	// Methods

	// RVA: 0x2EADD40 Offset: 0x2EADE41 VA: 0x2EADD40 Slot: 4
	public override string get_Name() { }

	// RVA: 0x2EADD90 Offset: 0x2EADE91 VA: 0x2EADD90
	public void set_Pair(SkillStack.Packet value) { }

	// RVA: 0x2EADDA0 Offset: 0x2EADEA1 VA: 0x2EADDA0
	public static bool IsAvailable(DecoratorArgs that, SkillStack.Packet pair) { }

	// RVA: 0x2EADDF0 Offset: 0x2EADEF1 VA: 0x2EADDF0 Slot: 5
	public override void OnEnter() { }

	// RVA: 0x2EADE20 Offset: 0x2EADF21 VA: 0x2EADE20 Slot: 6
	public override void OnEnterAttack() { }

	// RVA: 0x2EAE390 Offset: 0x2EAE491 VA: 0x2EAE390 Slot: 14
	public override void OnEnemyDamage_(AnimationEvent ev) { }

	// RVA: 0x2EAE180 Offset: 0x2EAE281 VA: 0x2EAE180
	public static void DrawSkillDamages(Phase phase, SkillStack skills) { }

	// RVA: 0x2EAE610 Offset: 0x2EAE711 VA: 0x2EAE610
	public static IDisposable DrawSkillTimeStop(Character chr) { }

	// RVA: 0x2EAE150 Offset: 0x2EAE251 VA: 0x2EAE150
	private static bool IsSubspace(Character c) { }

	// RVA: 0x2EAE810 Offset: 0x2EAE911 VA: 0x2EAE810
	public void .ctor() { }
}

