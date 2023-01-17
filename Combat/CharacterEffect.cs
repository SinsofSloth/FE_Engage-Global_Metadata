// Namespace: Combat
public sealed class CharacterEffect // TypeDefIndex: 8598
{
	// Fields
	private Character CP; // 0x10

	// Methods

	// RVA: 0x2B71320 Offset: 0x2B71421 VA: 0x2B71320
	private static Transform GetTransform(Character chr, AnimationEvent ev) { }

	// RVA: 0x2B71690 Offset: 0x2B71791 VA: 0x2B71690
	private static ParticleSystem GetParticle(Character chr, AnimationEvent ev) { }

	// RVA: 0x2B71830 Offset: 0x2B71931 VA: 0x2B71830
	public void .ctor(Character chr) { }

	// RVA: 0x2B71BD0 Offset: 0x2B71CD1 VA: 0x2B71BD0
	public static void SignalEffect(Character chr, AnimationEvent ev) { }

	// RVA: 0x2B6ACD0 Offset: 0x2B6ADD1 VA: 0x2B6ACD0
	public GameObject Create(GameObject prefab, Transform parent) { }

	// RVA: 0x2B72480 Offset: 0x2B72581 VA: 0x2B72480
	public void CreateHit(in TR tr, SlashType slashType, int effectLevel) { }

	// RVA: 0x2B726D0 Offset: 0x2B727D1 VA: 0x2B726D0
	public void CreatePairingHit(GameObject prefab, in TR tr) { }

	// RVA: 0x2B725A0 Offset: 0x2B726A1 VA: 0x2B725A0
	private string GetHitEffectName(SlashType slashType, int level) { }

	// RVA: 0x2B727A0 Offset: 0x2B728A1 VA: 0x2B727A0
	public void CreateGuard() { }

	// RVA: 0x2B728A0 Offset: 0x2B729A1 VA: 0x2B728A0
	public void CreateParry() { }

	// RVA: 0x2B72990 Offset: 0x2B72A91 VA: 0x2B72990
	public void CreateEfficacyHit() { }

	// RVA: 0x2B72A40 Offset: 0x2B72B41 VA: 0x2B72A40
	public void CreateBreak() { }

	// RVA: 0x2B72AE0 Offset: 0x2B72BE1 VA: 0x2B72AE0
	public void CreateSmash() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA8E0 Offset: 0x2AA9E1 VA: 0x2AA8E0
	// RVA: 0x2B72B50 Offset: 0x2B72C51 VA: 0x2B72B50
	private void <CreateGuard>b__9_0(long _) { }
}

