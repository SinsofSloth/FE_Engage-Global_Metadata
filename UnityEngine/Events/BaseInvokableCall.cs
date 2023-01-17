// Namespace: UnityEngine.Events
internal abstract class BaseInvokableCall // TypeDefIndex: 3683
{
	// Methods

	// RVA: 0x2F0B610 Offset: 0x2F0B711 VA: 0x2F0B610
	protected void .ctor() { }

	// RVA: 0x2F0B620 Offset: 0x2F0B721 VA: 0x2F0B620
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(object[] args);

	// RVA: -1 Offset: -1
	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2299250 Offset: 0x2299351 VA: 0x2299250
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|
	|-RVA: 0x22993E0 Offset: 0x22994E1 VA: 0x22993E0
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|
	|-RVA: 0x2299570 Offset: 0x2299671 VA: 0x2299570
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|
	|-RVA: 0x2299700 Offset: 0x2299801 VA: 0x2299700
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|
	|-RVA: 0x2299890 Offset: 0x2299991 VA: 0x2299890
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|
	|-RVA: 0x2299A20 Offset: 0x2299B21 VA: 0x2299A20
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|
	|-RVA: 0x2299BB0 Offset: 0x2299CB1 VA: 0x2299BB0
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	*/

	// RVA: 0x2F0B700 Offset: 0x2F0B801 VA: 0x2F0B700
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Find(object targetObj, MethodInfo method);
}

