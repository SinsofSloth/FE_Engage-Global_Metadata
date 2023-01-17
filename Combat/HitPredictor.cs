// Namespace: Combat
internal static class HitPredictor // TypeDefIndex: 8497
{
	// Methods

	// RVA: 0x2666B70 Offset: 0x2666C71 VA: 0x2666B70
	public static float CalcLocalHitTimeFromAttackStart(Character chr, SkillStack skills, float animTime) { }

	// RVA: 0x2666CA0 Offset: 0x2666DA1 VA: 0x2666CA0
	private static float PredictHit(Character chr, float startTime) { }

	// RVA: 0x2666D50 Offset: 0x2666E51 VA: 0x2666D50
	private static float PredictShoot(Character chr, float startTime) { }

	// RVA: 0x2666E20 Offset: 0x2666F21 VA: 0x2666E20
	private static float PredictMagic(Character chr, float startTime) { }

	// RVA: 0x2666F50 Offset: 0x2667051 VA: 0x2666F50
	public static ValueTuple<AnimationEvent, MagicSignal> FindMagicSignalPair(PrefetchedSignal store, Magic magic) { }
}

