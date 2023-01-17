// Namespace: UnityEngine.Rendering.Universal.Custom
public sealed class CustomEnvSetManager // TypeDefIndex: 5426
{
	// Fields
	private static readonly Lazy<CustomEnvSetManager> s_Instance; // 0x0
	private List<CustomEnvSet> m_EnvSets; // 0x10

	// Properties
	public static CustomEnvSetManager instance { get; }

	// Methods

	// RVA: 0x2D32650 Offset: 0x2D32751 VA: 0x2D32650
	public static CustomEnvSetManager get_instance() { }

	// RVA: 0x2D326D0 Offset: 0x2D327D1 VA: 0x2D326D0
	public void Register(CustomEnvSet set) { }

	// RVA: 0x2D32840 Offset: 0x2D32941 VA: 0x2D32840
	public void Unregister(CustomEnvSet set) { }

	// RVA: 0x2D328B0 Offset: 0x2D329B1 VA: 0x2D328B0
	public bool TryGetReflectionProbe(int index, out ReflectionProbe probe) { }

	// RVA: 0x2D32AA0 Offset: 0x2D32BA1 VA: 0x2D32AA0
	public void .ctor() { }

	// RVA: 0x2D32B30 Offset: 0x2D32C31 VA: 0x2D32B30
	private static void .cctor() { }
}

