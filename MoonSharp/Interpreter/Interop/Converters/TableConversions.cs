// Namespace: MoonSharp.Interpreter.Interop.Converters
internal static class TableConversions // TypeDefIndex: 6158
{
	// Methods

	// RVA: 0x3344510 Offset: 0x3344611 VA: 0x3344510
	internal static Table ConvertIListToTable(Script script, IList list) { }

	// RVA: 0x33446E0 Offset: 0x33447E1 VA: 0x33446E0
	internal static Table ConvertIDictionaryToTable(Script script, IDictionary dict) { }

	// RVA: 0x3344A30 Offset: 0x3344B31 VA: 0x3344A30
	internal static bool CanConvertTableToType(Table table, Type t) { }

	// RVA: 0x33451A0 Offset: 0x33452A1 VA: 0x33451A0
	internal static object ConvertTableToType(Table table, Type t) { }

	// RVA: 0x33463D0 Offset: 0x33464D1 VA: 0x33463D0
	internal static object ConvertTableToDictionaryOfGenericType(Type dictionaryType, Type keyType, Type valueType, Table table) { }

	// RVA: 0x33468E0 Offset: 0x33469E1 VA: 0x33468E0
	internal static object ConvertTableToArrayOfGenericType(Type arrayType, Type itemType, Table table) { }

	// RVA: 0x3346140 Offset: 0x3346241 VA: 0x3346140
	internal static object ConvertTableToListOfGenericType(Type listType, Type itemType, Table table) { }

	// RVA: -1 Offset: -1
	internal static List<T> TableToList<T>(Table table, Func<DynValue, T> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20248E0 Offset: 0x20249E1 VA: 0x20248E0
	|-TableConversions.TableToList<DynValue>
	|-TableConversions.TableToList<object>
	*/

	// RVA: -1 Offset: -1
	internal static Dictionary<TK, TV> TableToDictionary<TK, TV>(Table table, Func<DynValue, TK> keyconverter, Func<DynValue, TV> valconverter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20245A0 Offset: 0x20246A1 VA: 0x20245A0
	|-TableConversions.TableToDictionary<DynValue, DynValue>
	|-TableConversions.TableToDictionary<object, object>
	*/
}

