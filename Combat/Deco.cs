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

