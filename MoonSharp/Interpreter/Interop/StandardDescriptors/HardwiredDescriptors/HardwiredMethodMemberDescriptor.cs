// Namespace: MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
public abstract class HardwiredMethodMemberDescriptor : FunctionMemberDescriptorBase // TypeDefIndex: 6140
{
	// Methods

	// RVA: 0x33164B0 Offset: 0x33165B1 VA: 0x33164B0 Slot: 16
	public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args) { }

	// RVA: 0x3316640 Offset: 0x3316741 VA: 0x3316640
	private int CalcArgsCount(object[] pars) { }

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract object Invoke(Script script, object obj, object[] pars, int argscount);

	// RVA: 0x3316710 Offset: 0x3316811 VA: 0x3316710
	protected void .ctor() { }
}

