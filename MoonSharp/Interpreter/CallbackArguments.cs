// Namespace: MoonSharp.Interpreter
[DefaultMemberAttribute] // RVA: 0xD310 Offset: 0xD411 VA: 0xD310
public class CallbackArguments // TypeDefIndex: 5925
{
	// Fields
	private IList<DynValue> m_Args; // 0x10
	private int m_Count; // 0x18
	private bool m_LastIsTuple; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0xE1B0 Offset: 0xE2B1 VA: 0xE1B0
	private bool <IsMethodCall>k__BackingField; // 0x1D

	// Properties
	public int Count { get; }
	public bool IsMethodCall { get; set; }
	public DynValue Item { get; }

	// Methods

	// RVA: 0x30F4880 Offset: 0x30F4981 VA: 0x30F4880
	public void .ctor(IList<DynValue> args, bool isMethodCall) { }

	// RVA: 0x30F4B80 Offset: 0x30F4C81 VA: 0x30F4B80
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0xF3D0 Offset: 0xF4D1 VA: 0xF3D0
	// RVA: 0x30F4B90 Offset: 0x30F4C91 VA: 0x30F4B90
	public bool get_IsMethodCall() { }

	[CompilerGeneratedAttribute] // RVA: 0xF3E0 Offset: 0xF4E1 VA: 0xF3E0
	// RVA: 0x30F4BA0 Offset: 0x30F4CA1 VA: 0x30F4BA0
	private void set_IsMethodCall(bool value) { }

	// RVA: 0x30E6B30 Offset: 0x30E6C31 VA: 0x30E6B30
	public DynValue get_Item(int index) { }

	// RVA: 0x30F4BB0 Offset: 0x30F4CB1 VA: 0x30F4BB0
	public DynValue RawGet(int index, bool translateVoids) { }

	// RVA: 0x30EA150 Offset: 0x30EA251 VA: 0x30EA150
	public DynValue[] GetArray(int skip = 0) { }

	// RVA: 0x30EA910 Offset: 0x30EAA11 VA: 0x30EA910
	public DynValue AsType(int argNum, string funcName, DataType type, bool allowNil = False) { }

	// RVA: -1 Offset: -1
	public T AsUserData<T>(int argNum, string funcName, bool allowNil = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229A320 Offset: 0x229A421 VA: 0x229A320
	|-CallbackArguments.AsUserData<FileUserDataBase>
	|-CallbackArguments.AsUserData<object>
	*/

	// RVA: 0x30E6940 Offset: 0x30E6A41 VA: 0x30E6940
	public int AsInt(int argNum, string funcName) { }

	// RVA: 0x30F52A0 Offset: 0x30F53A1 VA: 0x30F52A0
	public long AsLong(int argNum, string funcName) { }

	// RVA: 0x30EBA60 Offset: 0x30EBB61 VA: 0x30EBA60
	public string AsStringUsingMeta(ScriptExecutionContext executionContext, int argNum, string funcName) { }

	// RVA: 0x30F5300 Offset: 0x30F5401 VA: 0x30F5300
	public CallbackArguments SkipMethodCall() { }
}

