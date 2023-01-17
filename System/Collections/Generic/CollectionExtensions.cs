// Namespace: System.Collections.Generic
[ExtensionAttribute] // RVA: 0x4774B0 Offset: 0x4775B1 VA: 0x4774B0
public static class CollectionExtensions // TypeDefIndex: 1394
{
	// Methods

	[ExtensionAttribute] // RVA: 0x47D9C0 Offset: 0x47DAC1 VA: 0x47D9C0
	// RVA: -1 Offset: -1
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229ACD0 Offset: 0x229ADD1 VA: 0x229ACD0
	|-CollectionExtensions.GetValueOrDefault<object, object>
	|-CollectionExtensions.GetValueOrDefault<string, LocalDataStoreSlot>
	*/

	[ExtensionAttribute] // RVA: 0x47D9D0 Offset: 0x47DAD1 VA: 0x47D9D0
	// RVA: -1 Offset: -1
	public static TValue GetValueOrDefault<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229ACF0 Offset: 0x229ADF1 VA: 0x229ACF0
	|-CollectionExtensions.GetValueOrDefault<object, object>
	*/
}

