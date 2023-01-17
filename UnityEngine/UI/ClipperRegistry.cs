// Namespace: UnityEngine.UI
public class ClipperRegistry // TypeDefIndex: 4249
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x1A42AB0 Offset: 0x1A42BB1 VA: 0x1A42AB0
	protected void .ctor() { }

	// RVA: 0x1A41D60 Offset: 0x1A41E61 VA: 0x1A41D60
	public static ClipperRegistry get_instance() { }

	// RVA: 0x1A41E60 Offset: 0x1A41F61 VA: 0x1A41E60
	public void Cull() { }

	// RVA: 0x1A42B40 Offset: 0x1A42C41 VA: 0x1A42B40
	public static void Register(IClipper c) { }

	// RVA: 0x1A42BB0 Offset: 0x1A42CB1 VA: 0x1A42BB0
	public static void Unregister(IClipper c) { }
}

