// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273E90 Offset: 0x273F91 VA: 0x273E90
public sealed class CharacterLod // TypeDefIndex: 8616
{
	// Fields
	private static float[] LOD_VALUES; // 0x0
	private static int MAX_LOD; // 0x8

	// Methods

	// RVA: 0x2B81240 Offset: 0x2B81341 VA: 0x2B81240
	private static void Activate(Transform[] objects) { }

	// RVA: 0x2B81390 Offset: 0x2B81491 VA: 0x2B81390
	private static bool HasLod(Renderer[] renderers) { }

	// RVA: 0x2B81450 Offset: 0x2B81551 VA: 0x2B81450
	private static bool IsShadowMesh(Renderer r) { }

	// RVA: 0x2B815B0 Offset: 0x2B816B1 VA: 0x2B815B0
	private static string GetBaseName(string name) { }

	// RVA: 0x2B816C0 Offset: 0x2B817C1 VA: 0x2B816C0
	private static Renderer[] GetRenderersByLod(string key, Renderer[] renderers) { }

	// RVA: 0x2B81A30 Offset: 0x2B81B31 VA: 0x2B81A30
	private static LOD[] CreateLods(Renderer[] renderers) { }

	// RVA: 0x2B82220 Offset: 0x2B82321 VA: 0x2B82220
	public static bool Setup(CharacterAsset asset) { }

	// RVA: 0x2B82450 Offset: 0x2B82551 VA: 0x2B82450
	public void .ctor() { }

	// RVA: 0x2B82460 Offset: 0x2B82561 VA: 0x2B82460
	private static void .cctor() { }
}

