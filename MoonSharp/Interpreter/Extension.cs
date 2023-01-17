// Namespace: MoonSharp.Interpreter
[ExtensionAttribute] // RVA: 0xD300 Offset: 0xD401 VA: 0xD300
internal static class Extension_Methods // TypeDefIndex: 5924
{
	// Methods

	[ExtensionAttribute] // RVA: 0xF3B0 Offset: 0xF4B1 VA: 0xF3B0
	// RVA: -1 Offset: -1
	public static TValue GetOrDefault<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B49E0 Offset: 0x22B4AE1 VA: 0x22B49E0
	|-Extension_Methods.GetOrDefault<object, Delegate>
	|-Extension_Methods.GetOrDefault<object, object>
	|-Extension_Methods.GetOrDefault<string, IMemberDescriptor>
	|-Extension_Methods.GetOrDefault<string, SymbolRef>
	|-Extension_Methods.GetOrDefault<Type, Func<DynValue, object>>
	|-Extension_Methods.GetOrDefault<Type, Func<Script, object, DynValue>>
	*/

	[ExtensionAttribute] // RVA: 0xF3C0 Offset: 0xF4C1 VA: 0xF3C0
	// RVA: -1 Offset: -1
	public static TValue GetOrCreate<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> creator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4950 Offset: 0x22B4A51 VA: 0x22B4950
	|-Extension_Methods.GetOrCreate<object, Delegate>
	|-Extension_Methods.GetOrCreate<object, object>
	*/
}

