// Namespace: MoonSharp.Interpreter
[Serializable]
public class ScriptRuntimeException : InterpreterException // TypeDefIndex: 5959
{
	// Methods

	// RVA: 0x301B480 Offset: 0x301B581 VA: 0x301B480
	public void .ctor(Exception ex) { }

	// RVA: 0x301B490 Offset: 0x301B591 VA: 0x301B490
	public void .ctor(ScriptRuntimeException ex) { }

	// RVA: 0x301A430 Offset: 0x301A531 VA: 0x301A430
	public void .ctor(string message) { }

	// RVA: 0x300EE60 Offset: 0x300EF61 VA: 0x300EE60
	public void .ctor(string format, object[] args) { }

	// RVA: 0x301B4E0 Offset: 0x301B5E1 VA: 0x301B4E0
	public static ScriptRuntimeException ArithmeticOnNonNumber(DynValue l, DynValue r) { }

	// RVA: 0x301B720 Offset: 0x301B821 VA: 0x301B720
	public static ScriptRuntimeException ConcatOnNonString(DynValue l, DynValue r) { }

	// RVA: 0x301B8C0 Offset: 0x301B9C1 VA: 0x301B8C0
	public static ScriptRuntimeException LenOnInvalidType(DynValue r) { }

	// RVA: 0x301B9C0 Offset: 0x301BAC1 VA: 0x301B9C0
	public static ScriptRuntimeException CompareInvalidType(DynValue l, DynValue r) { }

	// RVA: 0x301BBA0 Offset: 0x301BCA1 VA: 0x301BBA0
	public static ScriptRuntimeException BadArgument(int argNum, string funcName, string message) { }

	// RVA: 0x301BD40 Offset: 0x301BE41 VA: 0x301BD40
	public static ScriptRuntimeException BadArgumentUserData(int argNum, string funcName, Type expected, object got, bool allowNil) { }

	// RVA: 0x301C020 Offset: 0x301C121 VA: 0x301C020
	public static ScriptRuntimeException BadArgument(int argNum, string funcName, DataType expected, DataType got, bool allowNil) { }

	// RVA: 0x301C090 Offset: 0x301C191 VA: 0x301C090
	public static ScriptRuntimeException BadArgument(int argNum, string funcName, string expected, string got, bool allowNil) { }

	// RVA: 0x301C2E0 Offset: 0x301C3E1 VA: 0x301C2E0
	public static ScriptRuntimeException BadArgumentNoValue(int argNum, string funcName, DataType expected) { }

	// RVA: 0x301C490 Offset: 0x301C591 VA: 0x301C490
	public static ScriptRuntimeException BadArgumentIndexOutOfRange(string funcName, int argNum) { }

	// RVA: 0x301C5F0 Offset: 0x301C6F1 VA: 0x301C5F0
	public static ScriptRuntimeException BadArgumentNoNegativeNumbers(int argNum, string funcName) { }

	// RVA: 0x301C750 Offset: 0x301C851 VA: 0x301C750
	public static ScriptRuntimeException BadArgumentValueExpected(int argNum, string funcName) { }

	// RVA: 0x301C8B0 Offset: 0x301C9B1 VA: 0x301C8B0
	public static ScriptRuntimeException IndexType(DynValue obj) { }

	// RVA: 0x301C9B0 Offset: 0x301CAB1 VA: 0x301C9B0
	public static ScriptRuntimeException LoopInIndex() { }

	// RVA: 0x301CA30 Offset: 0x301CB31 VA: 0x301CA30
	public static ScriptRuntimeException LoopInNewIndex() { }

	// RVA: 0x301A5D0 Offset: 0x301A6D1 VA: 0x301A5D0
	public static ScriptRuntimeException LoopInCall() { }

	// RVA: 0x301CAB0 Offset: 0x301CBB1 VA: 0x301CAB0
	public static ScriptRuntimeException TableIndexIsNil() { }

	// RVA: 0x301CB30 Offset: 0x301CC31 VA: 0x301CB30
	public static ScriptRuntimeException TableIndexIsNaN() { }

	// RVA: 0x301CBB0 Offset: 0x301CCB1 VA: 0x301CBB0
	public static ScriptRuntimeException ConvertToNumberFailed(int stage) { }

	// RVA: 0x301CC70 Offset: 0x301CD71 VA: 0x301CC70
	public static ScriptRuntimeException ConvertObjectFailed(object obj) { }

	// RVA: 0x301CD70 Offset: 0x301CE71 VA: 0x301CD70
	public static ScriptRuntimeException ConvertObjectFailed(DataType t) { }

	// RVA: 0x301CEC0 Offset: 0x301CFC1 VA: 0x301CEC0
	public static ScriptRuntimeException ConvertObjectFailed(DataType t, Type t2) { }

	// RVA: 0x300FCC0 Offset: 0x300FDC1 VA: 0x300FCC0
	public static ScriptRuntimeException UserDataArgumentTypeMismatch(DataType t, Type clrType) { }

	// RVA: 0x301D060 Offset: 0x301D161 VA: 0x301D060
	public static ScriptRuntimeException UserDataMissingField(string typename, string fieldname) { }

	// RVA: 0x301D190 Offset: 0x301D291 VA: 0x301D190
	public static ScriptRuntimeException CannotResumeNotSuspended(CoroutineState state) { }

	// RVA: 0x301A3B0 Offset: 0x301A4B1 VA: 0x301A3B0
	public static ScriptRuntimeException CannotYield() { }

	// RVA: 0x301D230 Offset: 0x301D331 VA: 0x301D230
	public static ScriptRuntimeException CannotYieldMain() { }

	// RVA: 0x301A440 Offset: 0x301A541 VA: 0x301A440
	public static ScriptRuntimeException AttemptToCallNonFunc(DataType type, string debugText) { }

	// RVA: 0x301D2B0 Offset: 0x301D3B1 VA: 0x301D2B0
	public static ScriptRuntimeException AccessInstanceMemberOnStatics(IMemberDescriptor desc) { }

	// RVA: 0x301D410 Offset: 0x301D511 VA: 0x301D410
	public static ScriptRuntimeException AccessInstanceMemberOnStatics(IUserDataDescriptor typeDescr, IMemberDescriptor desc) { }

	// RVA: 0x301D620 Offset: 0x301D721 VA: 0x301D620 Slot: 18
	public override void Rethrow() { }
}

