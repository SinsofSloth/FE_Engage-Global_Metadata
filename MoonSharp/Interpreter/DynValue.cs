// Namespace: MoonSharp.Interpreter
public sealed class DynValue // TypeDefIndex: 5939
{
	// Fields
	private static int s_RefIDCounter; // 0x0
	private int m_RefID; // 0x10
	private int m_HashCode; // 0x14
	private bool m_ReadOnly; // 0x18
	private double m_Number; // 0x20
	private object m_Object; // 0x28
	private DataType m_Type; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xE240 Offset: 0xE341 VA: 0xE240
	private static DynValue <Void>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0xE250 Offset: 0xE351 VA: 0xE250
	private static DynValue <Nil>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE260 Offset: 0xE361 VA: 0xE260
	private static DynValue <True>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE270 Offset: 0xE371 VA: 0xE270
	private static DynValue <False>k__BackingField; // 0x20

	// Properties
	public int ReferenceID { get; }
	public DataType Type { get; }
	public Closure Function { get; }
	public double Number { get; }
	public DynValue[] Tuple { get; }
	public Coroutine Coroutine { get; }
	public Table Table { get; }
	public bool Boolean { get; }
	public string String { get; }
	public CallbackFunction Callback { get; }
	public TailCallData TailCallData { get; }
	public YieldRequest YieldRequest { get; }
	public UserData UserData { get; }
	public bool ReadOnly { get; }
	public static DynValue Void { get; set; }
	public static DynValue Nil { get; set; }
	public static DynValue True { get; set; }
	public static DynValue False { get; set; }

	// Methods

	// RVA: 0x3103290 Offset: 0x3103391 VA: 0x3103290
	public int get_ReferenceID() { }

	// RVA: 0x31032A0 Offset: 0x31033A1 VA: 0x31032A0
	public DataType get_Type() { }

	// RVA: 0x30FC980 Offset: 0x30FCA81 VA: 0x30FC980
	public Closure get_Function() { }

	// RVA: 0x31032B0 Offset: 0x31033B1 VA: 0x31032B0
	public double get_Number() { }

	// RVA: 0x30EB1F0 Offset: 0x30EB2F1 VA: 0x30EB1F0
	public DynValue[] get_Tuple() { }

	// RVA: 0x30FA7F0 Offset: 0x30FA8F1 VA: 0x30FA7F0
	public Coroutine get_Coroutine() { }

	// RVA: 0x30E67A0 Offset: 0x30E68A1 VA: 0x30E67A0
	public Table get_Table() { }

	// RVA: 0x31032C0 Offset: 0x31033C1 VA: 0x31032C0
	public bool get_Boolean() { }

	// RVA: 0x30EA960 Offset: 0x30EAA61 VA: 0x30EA960
	public string get_String() { }

	// RVA: 0x30FA680 Offset: 0x30FA781 VA: 0x30FA680
	public CallbackFunction get_Callback() { }

	// RVA: 0x30EACD0 Offset: 0x30EADD1 VA: 0x30EACD0
	public TailCallData get_TailCallData() { }

	// RVA: 0x31032D0 Offset: 0x31033D1 VA: 0x31032D0
	public YieldRequest get_YieldRequest() { }

	// RVA: 0x30FC080 Offset: 0x30FC181 VA: 0x30FC080
	public UserData get_UserData() { }

	// RVA: 0x3103360 Offset: 0x3103461 VA: 0x3103360
	public bool get_ReadOnly() { }

	// RVA: 0x3103370 Offset: 0x3103471 VA: 0x3103370
	public static DynValue NewNil() { }

	// RVA: 0x30E6630 Offset: 0x30E6731 VA: 0x30E6630
	public static DynValue NewBoolean(bool v) { }

	// RVA: 0x30EB250 Offset: 0x30EB351 VA: 0x30EB250
	public static DynValue NewNumber(double num) { }

	// RVA: 0x30E6550 Offset: 0x30E6651 VA: 0x30E6550
	public static DynValue NewString(string str) { }

	// RVA: 0x30FD750 Offset: 0x30FD851 VA: 0x30FD750
	public static DynValue NewString(StringBuilder sb) { }

	// RVA: 0x31034C0 Offset: 0x31035C1 VA: 0x31034C0
	public static DynValue NewString(string format, object[] args) { }

	// RVA: 0x30FB220 Offset: 0x30FB321 VA: 0x30FB220
	public static DynValue NewCoroutine(Coroutine coroutine) { }

	// RVA: 0x30F8760 Offset: 0x30F8861 VA: 0x30F8760
	public static DynValue NewClosure(Closure function) { }

	// RVA: 0x30F8920 Offset: 0x30F8A21 VA: 0x30F8920
	public static DynValue NewCallback(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, string name) { }

	// RVA: 0x30F8840 Offset: 0x30F8941 VA: 0x30F8840
	public static DynValue NewCallback(CallbackFunction function) { }

	// RVA: 0x30F7F80 Offset: 0x30F8081 VA: 0x30F7F80
	public static DynValue NewTable(Table table) { }

	// RVA: 0x30E6710 Offset: 0x30E6811 VA: 0x30E6710
	public static DynValue NewPrimeTable() { }

	// RVA: 0x31035B0 Offset: 0x31036B1 VA: 0x31035B0
	public static DynValue NewTable(Script script) { }

	// RVA: 0x3103650 Offset: 0x3103751 VA: 0x3103650
	public static DynValue NewTable(Script script, DynValue[] arrayValues) { }

	// RVA: 0x3103700 Offset: 0x3103801 VA: 0x3103700
	public static DynValue NewTailCallReq(DynValue tailFn, DynValue[] args) { }

	// RVA: 0x3103830 Offset: 0x3103931 VA: 0x3103830
	public static DynValue NewTailCallReq(TailCallData tailCallData) { }

	// RVA: 0x30FAF90 Offset: 0x30FB091 VA: 0x30FAF90
	public static DynValue NewYieldReq(DynValue[] args) { }

	// RVA: 0x3103910 Offset: 0x3103A11 VA: 0x3103910
	internal static DynValue NewForcedYieldReq() { }

	// RVA: 0x30FADE0 Offset: 0x30FAEE1 VA: 0x30FADE0
	public static DynValue NewTuple(DynValue[] values) { }

	// RVA: 0x30EA270 Offset: 0x30EA371 VA: 0x30EA270
	public static DynValue NewTupleNested(DynValue[] values) { }

	// RVA: 0x3103A10 Offset: 0x3103B11 VA: 0x3103A10
	public static DynValue NewUserData(UserData userData) { }

	// RVA: 0x3103AF0 Offset: 0x3103BF1 VA: 0x3103AF0
	public DynValue AsReadOnly() { }

	// RVA: 0x3103C10 Offset: 0x3103D11 VA: 0x3103C10
	public DynValue Clone() { }

	// RVA: 0x3103B10 Offset: 0x3103C11 VA: 0x3103B10
	public DynValue Clone(bool readOnly) { }

	// RVA: 0x3103C20 Offset: 0x3103D21 VA: 0x3103C20
	public DynValue CloneAsWritable() { }

	[CompilerGeneratedAttribute] // RVA: 0xF8B0 Offset: 0xF9B1 VA: 0xF8B0
	// RVA: 0x3103C30 Offset: 0x3103D31 VA: 0x3103C30
	public static DynValue get_Void() { }

	[CompilerGeneratedAttribute] // RVA: 0xF8C0 Offset: 0xF9C1 VA: 0xF8C0
	// RVA: 0x3103CA0 Offset: 0x3103DA1 VA: 0x3103CA0
	private static void set_Void(DynValue value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF8D0 Offset: 0xF9D1 VA: 0xF8D0
	// RVA: 0x3103D20 Offset: 0x3103E21 VA: 0x3103D20
	public static DynValue get_Nil() { }

	[CompilerGeneratedAttribute] // RVA: 0xF8E0 Offset: 0xF9E1 VA: 0xF8E0
	// RVA: 0x3103D90 Offset: 0x3103E91 VA: 0x3103D90
	private static void set_Nil(DynValue value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF8F0 Offset: 0xF9F1 VA: 0xF8F0
	// RVA: 0x3103E10 Offset: 0x3103F11 VA: 0x3103E10
	public static DynValue get_True() { }

	[CompilerGeneratedAttribute] // RVA: 0xF900 Offset: 0xFA01 VA: 0xF900
	// RVA: 0x3103E80 Offset: 0x3103F81 VA: 0x3103E80
	private static void set_True(DynValue value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF910 Offset: 0xFA11 VA: 0xF910
	// RVA: 0x3103F00 Offset: 0x3104001 VA: 0x3103F00
	public static DynValue get_False() { }

	[CompilerGeneratedAttribute] // RVA: 0xF920 Offset: 0xFA21 VA: 0xF920
	// RVA: 0x3103F70 Offset: 0x3104071 VA: 0x3103F70
	private static void set_False(DynValue value) { }

	// RVA: 0x3103FF0 Offset: 0x31040F1 VA: 0x3103FF0
	private static void .cctor() { }

	// RVA: 0x30E9D80 Offset: 0x30E9E81 VA: 0x30E9D80
	public string ToPrintString() { }

	// RVA: 0x3104350 Offset: 0x3104451 VA: 0x3104350
	public string ToDebugPrintString() { }

	// RVA: 0x31046C0 Offset: 0x31047C1 VA: 0x31046C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3104D00 Offset: 0x3104E01 VA: 0x3104D00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3104EF0 Offset: 0x3104FF1 VA: 0x3104EF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x30EA7D0 Offset: 0x30EA8D1 VA: 0x30EA7D0
	public string CastToString() { }

	// RVA: 0x30EE050 Offset: 0x30EE151 VA: 0x30EE050
	public Nullable<double> CastToNumber() { }

	// RVA: 0x30E9D30 Offset: 0x30E9E31 VA: 0x30E9D30
	public bool CastToBool() { }

	// RVA: 0x3105380 Offset: 0x3105481 VA: 0x3105380
	public IScriptPrivateResource GetAsPrivateResource() { }

	// RVA: 0x30E5F40 Offset: 0x30E6041 VA: 0x30E5F40
	public DynValue ToScalar() { }

	// RVA: 0x30FCEE0 Offset: 0x30FCFE1 VA: 0x30FCEE0
	public void Assign(DynValue value) { }

	// RVA: 0x31053E0 Offset: 0x31054E1 VA: 0x31053E0
	public DynValue GetLength() { }

	// RVA: 0x30E9D70 Offset: 0x30E9E71 VA: 0x30E9D70
	public bool IsNil() { }

	// RVA: 0x30FD740 Offset: 0x30FD841 VA: 0x30FD740
	public bool IsNotNil() { }

	// RVA: 0x30EBA50 Offset: 0x30EBB51 VA: 0x30EBA50
	public bool IsVoid() { }

	// RVA: 0x31055D0 Offset: 0x31056D1 VA: 0x31055D0
	public bool IsNotVoid() { }

	// RVA: 0x30EE8F0 Offset: 0x30EE9F1 VA: 0x30EE8F0
	public bool IsNilOrNan() { }

	// RVA: 0x31055E0 Offset: 0x31056E1 VA: 0x31055E0
	internal void AssignNumber(double num) { }

	// RVA: 0x30FA160 Offset: 0x30FA261 VA: 0x30FA160
	public static DynValue FromObject(Script script, object obj) { }

	// RVA: 0x30F7BD0 Offset: 0x30F7CD1 VA: 0x30F7BD0
	public object ToObject() { }

	// RVA: 0x3105730 Offset: 0x3105831 VA: 0x3105730
	public object ToObject(Type desiredType) { }

	// RVA: -1 Offset: -1
	public T ToObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A1A40 Offset: 0x22A1B41 VA: 0x22A1A40
	|-DynValue.ToObject<bool>
	|
	|-RVA: 0x22A1B20 Offset: 0x22A1C21 VA: 0x22A1B20
	|-DynValue.ToObject<int>
	|
	|-RVA: 0x22A1C00 Offset: 0x22A1D01 VA: 0x22A1C00
	|-DynValue.ToObject<object>
	|-DynValue.ToObject<string>
	*/

	// RVA: 0x30F5020 Offset: 0x30F5121 VA: 0x30F5020
	public DynValue CheckType(string funcName, DataType desiredType, int argNum = -1, TypeValidationFlags flags = 2) { }

	// RVA: -1 Offset: -1
	public T CheckUserDataType<T>(string funcName, int argNum = -1, TypeValidationFlags flags = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A18E0 Offset: 0x22A19E1 VA: 0x22A18E0
	|-DynValue.CheckUserDataType<FileUserDataBase>
	|-DynValue.CheckUserDataType<object>
	*/

	// RVA: 0x3103430 Offset: 0x3103531 VA: 0x3103430
	public void .ctor() { }
}

