// Namespace: MoonSharp.Interpreter.Interop
public class ArrayMemberDescriptor : ObjectCallbackMemberDescriptor, IWireableDescriptor // TypeDefIndex: 6083
{
	// Fields
	private bool m_IsSetter; // 0x50

	// Methods

	// RVA: 0x30E60B0 Offset: 0x30E61B1 VA: 0x30E60B0
	public void .ctor(string name, bool isSetter, ParameterDescriptor[] indexerParams) { }

	// RVA: 0x30E61A0 Offset: 0x30E62A1 VA: 0x30E61A0
	public void .ctor(string name, bool isSetter) { }

	// RVA: 0x30E6280 Offset: 0x30E6381 VA: 0x30E6280 Slot: 19
	public void PrepareForWiring(Table t) { }

	// RVA: 0x30E6830 Offset: 0x30E6931 VA: 0x30E6830
	private static int[] BuildArrayIndices(CallbackArguments args, int count) { }

	// RVA: 0x30E69A0 Offset: 0x30E6AA1 VA: 0x30E69A0
	private static object ArrayIndexerSet(object arrayObj, ScriptExecutionContext ctx, CallbackArguments args) { }

	// RVA: 0x30E6C30 Offset: 0x30E6D31 VA: 0x30E6C30
	private static object ArrayIndexerGet(object arrayObj, ScriptExecutionContext ctx, CallbackArguments args) { }
}

