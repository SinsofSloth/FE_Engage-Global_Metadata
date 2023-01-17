// Namespace: MoonSharp.Interpreter
[ExtensionAttribute] // RVA: 0xD570 Offset: 0xD671 VA: 0xD570
public static class LinqHelpers // TypeDefIndex: 5975
{
	// Methods

	[ExtensionAttribute] // RVA: 0xFC30 Offset: 0xFD31 VA: 0xFC30
	// RVA: -1 Offset: -1
	public static IEnumerable<T> Convert<T>(IEnumerable<DynValue> enumerable, DataType type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295C140 Offset: 0x295C241 VA: 0x295C140
	|-LinqHelpers.Convert<object>
	*/

	[ExtensionAttribute] // RVA: 0xFC40 Offset: 0xFD41 VA: 0xFC40
	// RVA: 0x2BACB80 Offset: 0x2BACC81 VA: 0x2BACB80
	public static IEnumerable<DynValue> OfDataType(IEnumerable<DynValue> enumerable, DataType type) { }

	[ExtensionAttribute] // RVA: 0xFC50 Offset: 0xFD51 VA: 0xFC50
	// RVA: 0x2BACC70 Offset: 0x2BACD71 VA: 0x2BACC70
	public static IEnumerable<object> AsObjects(IEnumerable<DynValue> enumerable) { }

	[ExtensionAttribute] // RVA: 0xFC60 Offset: 0xFD61 VA: 0xFC60
	// RVA: -1 Offset: -1
	public static IEnumerable<T> AsObjects<T>(IEnumerable<DynValue> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295BF80 Offset: 0x295C081 VA: 0x295BF80
	|-LinqHelpers.AsObjects<object>
	*/
}

