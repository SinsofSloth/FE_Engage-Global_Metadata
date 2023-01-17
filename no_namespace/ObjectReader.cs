// Namespace: 
internal class ObjectReader.TypeNAssembly // TypeDefIndex: 1074
{
	// Fields
	public Type type; // 0x10
	public string assemblyName; // 0x18

	// Methods

	// RVA: 0x35F0360 Offset: 0x35F0461 VA: 0x35F0360
	public void .ctor() { }
}

// Namespace: 
internal sealed class ObjectReader.TopLevelAssemblyTypeResolver // TypeDefIndex: 1075
{
	// Fields
	private Assembly m_topLevelAssembly; // 0x10

	// Methods

	// RVA: 0x35F02B0 Offset: 0x35F03B1 VA: 0x35F02B0
	public void .ctor(Assembly topLevelAssembly) { }

	// RVA: 0x35F02F0 Offset: 0x35F03F1 VA: 0x35F02F0
	public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }
}

