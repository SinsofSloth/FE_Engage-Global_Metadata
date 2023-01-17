// Namespace: MoonSharp.Interpreter.Interop
public class ObjectCallbackMemberDescriptor : FunctionMemberDescriptorBase // TypeDefIndex: 6089
{
	// Fields
	private Func<object, ScriptExecutionContext, CallbackArguments, object> m_CallbackFunc; // 0x48

	// Methods

	// RVA: 0x2BC1790 Offset: 0x2BC1891 VA: 0x2BC1790
	public void .ctor(string funcName) { }

	// RVA: 0x2BC1960 Offset: 0x2BC1A61 VA: 0x2BC1960
	public void .ctor(string funcName, Func<object, ScriptExecutionContext, CallbackArguments, object> callBack) { }

	// RVA: 0x2BC1900 Offset: 0x2BC1A01 VA: 0x2BC1900
	public void .ctor(string funcName, Func<object, ScriptExecutionContext, CallbackArguments, object> callBack, ParameterDescriptor[] parameters) { }

	// RVA: 0x2BC1A00 Offset: 0x2BC1B01 VA: 0x2BC1A00 Slot: 16
	public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args) { }
}

