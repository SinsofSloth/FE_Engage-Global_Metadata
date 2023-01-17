// Namespace: MoonSharp.Interpreter.Interop
public class CustomConvertersCollection // TypeDefIndex: 6062
{
	// Fields
	private Dictionary<Type, Func<DynValue, object>>[] m_Script2Clr; // 0x10
	private Dictionary<Type, Func<Script, object, DynValue>> m_Clr2Script; // 0x18

	// Methods

	// RVA: 0x30FB610 Offset: 0x30FB711 VA: 0x30FB610
	internal void .ctor() { }

	// RVA: 0x30FB7B0 Offset: 0x30FB8B1 VA: 0x30FB7B0
	public void SetScriptToClrCustomConversion(DataType scriptDataType, Type clrDataType, Func<DynValue, object> converter) { }

	// RVA: 0x30FB910 Offset: 0x30FBA11 VA: 0x30FB910
	public Func<DynValue, object> GetScriptToClrCustomConversion(DataType scriptDataType, Type clrDataType) { }

	// RVA: 0x30FB9B0 Offset: 0x30FBAB1 VA: 0x30FB9B0
	public void SetClrToScriptCustomConversion(Type clrDataType, Func<Script, object, DynValue> converter) { }

	// RVA: -1 Offset: -1
	public void SetClrToScriptCustomConversion<T>(Func<Script, T, DynValue> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229DEA0 Offset: 0x229DFA1 VA: 0x229DEA0
	|-CustomConvertersCollection.SetClrToScriptCustomConversion<object>
	*/

	// RVA: 0x30F8700 Offset: 0x30F8801 VA: 0x30F8700
	public Func<Script, object, DynValue> GetClrToScriptCustomConversion(Type clrDataType) { }

	[ObsoleteAttribute] // RVA: 0x10370 Offset: 0x10471 VA: 0x10370
	// RVA: 0x30FBA80 Offset: 0x30FBB81 VA: 0x30FBA80
	public void SetClrToScriptCustomConversion(Type clrDataType, Func<object, DynValue> converter) { }

	[ObsoleteAttribute] // RVA: 0x103B0 Offset: 0x104B1 VA: 0x103B0
	// RVA: -1 Offset: -1
	public void SetClrToScriptCustomConversion<T>(Func<T, DynValue> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229DD70 Offset: 0x229DE71 VA: 0x229DD70
	|-CustomConvertersCollection.SetClrToScriptCustomConversion<object>
	*/

	// RVA: 0x30FBB70 Offset: 0x30FBC71 VA: 0x30FBB70
	public void Clear() { }
}

