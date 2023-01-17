// Namespace: System.Linq.Expressions.Interpreter
internal class LightLambda // TypeDefIndex: 3095
{
	// Fields
	private readonly IStrongBox[] _closure; // 0x10
	private readonly Interpreter _interpreter; // 0x18
	private static readonly CacheDict<Type, Func<LightLambda, Delegate>> _runCache; // 0x0
	private readonly LightDelegateCreator _delegateCreator; // 0x20

	// Methods

	// RVA: 0x3322930 Offset: 0x3322A31 VA: 0x3322930
	internal void RunVoid0() { }

	// RVA: 0x3322830 Offset: 0x3322931 VA: 0x3322830
	internal void .ctor(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	// RVA: 0x3322A80 Offset: 0x3322B81 VA: 0x3322A80
	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	// RVA: 0x3322C20 Offset: 0x3322D21 VA: 0x3322C20
	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	// RVA: 0x3323690 Offset: 0x3323791 VA: 0x3323690
	private Delegate CreateCustomDelegate(Type delegateType) { }

	// RVA: 0x3322890 Offset: 0x3322991 VA: 0x3322890
	internal Delegate MakeDelegate(Type delegateType) { }

	// RVA: 0x3322A10 Offset: 0x3322B11 VA: 0x3322A10
	private InterpretedFrame MakeFrame() { }

	// RVA: -1 Offset: -1
	internal void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295BCD0 Offset: 0x295BDD1 VA: 0x295BCD0
	|-LightLambda.RunVoidRef2<object, object>
	*/

	// RVA: 0x3324050 Offset: 0x3324151 VA: 0x3324050
	public object Run(object[] arguments) { }

	// RVA: 0x3324290 Offset: 0x3324391 VA: 0x3324290
	public object RunVoid(object[] arguments) { }

	// RVA: 0x33244D0 Offset: 0x33245D1 VA: 0x33244D0
	private static void .cctor() { }
}

