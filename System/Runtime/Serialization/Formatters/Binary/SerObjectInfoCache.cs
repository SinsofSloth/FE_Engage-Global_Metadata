// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerObjectInfoCache // TypeDefIndex: 1072
{
	// Fields
	internal string fullTypeName; // 0x10
	internal string assemblyString; // 0x18
	internal bool hasTypeForwardedFrom; // 0x20
	internal MemberInfo[] memberInfos; // 0x28
	internal string[] memberNames; // 0x30
	internal Type[] memberTypes; // 0x38

	// Methods

	// RVA: 0x3617B50 Offset: 0x3617C51 VA: 0x3617B50
	internal void .ctor(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	// RVA: 0x3617BB0 Offset: 0x3617CB1 VA: 0x3617BB0
	internal void .ctor(Type type) { }
}

