// Namespace: App.RingCleaning
public class EffectController // TypeDefIndex: 14179
{
	// Fields
	private const string GlitterEffectPrefab = "Effects/Field/Hub/Hub_GodRoom/Prefabs/Eff_RingGlitter_00";
	private const string GlitterStrongEffectPrefab = "Effects/Field/Hub/Hub_GodRoom/Prefabs/Eff_RingGlitter_01";
	private const string GlitterWeakNotHit = "Effects/Field/Hub/Hub_GodRoom/Prefabs/Eff_RingGlitter_Small";
	private const string GlitterWeakNear = "Effects/Field/Hub/Hub_GodRoom/Prefabs/Eff_RingGlitter_Normal";
	private const string GlitterStrongA = "Effects/Field/Hub/Hub_GodRoom/Prefabs/Eff_RingGlitter_Strong_A";
	private const string GlitterStrongB = "Effects/Field/Hub/Hub_GodRoom/Prefabs/Eff_RingGlitter_Strong_B";
	private const string NoteEffectA = "Effects/Field/Hub/Hub_GodRoom/Prefabs/Eff_RingNote_Strong_A";
	private const string NoteEffectB = "Effects/Field/Hub/Hub_GodRoom/Prefabs/Eff_RingNote_Strong_B";
	private const string HitEffect2D = "Effects/Field/Hub/Hub_GodRoom/Prefabs/Eff_RingScreen_Lucky";
	private const string RubEffect = "Effects/Field/Hub/Hub_GodRoom/Prefabs/Eff_RingGlitter_Paper";
	private static GameObject s_EffectRoot; // 0x0
	private static GameObject s_Rub; // 0x8

	// Properties
	public static string NoteEffect { get; }
	public static string NoteEffectBig { get; }

	// Methods

	// RVA: 0x25F1D10 Offset: 0x25F1E11 VA: 0x25F1D10
	public static void LoadPrefabAsync() { }

	// RVA: 0x25F1F00 Offset: 0x25F2001 VA: 0x25F1F00
	public static bool IsLoadingPrefab() { }

	// RVA: 0x25F21B0 Offset: 0x25F22B1 VA: 0x25F21B0
	public static void UnloadPrefab() { }

	// RVA: 0x25F2370 Offset: 0x25F2471 VA: 0x25F2370
	public static void Initialize() { }

	// RVA: 0x25F23F0 Offset: 0x25F24F1 VA: 0x25F23F0
	public static GameObject CreateGlitterEffect(RingCleaningSequence.Strength strength, RingCleaningSequence.HitResult hitResult) { }

	// RVA: 0x25F2570 Offset: 0x25F2671 VA: 0x25F2570
	public static void PlayHitScreen() { }

	// RVA: 0x25F2640 Offset: 0x25F2741 VA: 0x25F2640
	public static GameObject PlayRubEffect() { }

	// RVA: 0x25F2750 Offset: 0x25F2851 VA: 0x25F2750
	public static string get_NoteEffect() { }

	// RVA: 0x25F27A0 Offset: 0x25F28A1 VA: 0x25F27A0
	public static string get_NoteEffectBig() { }

	// RVA: 0x25F27F0 Offset: 0x25F28F1 VA: 0x25F27F0
	public void .ctor() { }
}

