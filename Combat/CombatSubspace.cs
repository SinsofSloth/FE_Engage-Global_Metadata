// Namespace: Combat
internal abstract class CombatSubspace : ProcInst // TypeDefIndex: 8703
{
	// Fields
	protected static ResourceHandle s_SpaceHandle; // 0x0
	public const Fade.Layer FadeLayer = 3;
	public const float FadeTime = 0.125;
	public Subject<Unit> OnTripFinished; // 0x70

	// Methods

	// RVA: 0x25743A0 Offset: 0x25744A1 VA: 0x25743A0
	public static void RelocateToGround() { }

	// RVA: 0x25703C0 Offset: 0x25704C1 VA: 0x25703C0
	public static bool IsSubspace() { }

	// RVA: 0x2574440 Offset: 0x2574541 VA: 0x2574440
	protected void .ctor() { }

	// RVA: 0x25744D0 Offset: 0x25745D1 VA: 0x25744D0
	private static void .cctor() { }
}

