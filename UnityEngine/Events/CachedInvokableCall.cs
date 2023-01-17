// Namespace: UnityEngine.Events
internal class CachedInvokableCall<T> : InvokableCall<T> // TypeDefIndex: 3689
{
	// Fields
	private readonly T m_Arg1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Object target, MethodInfo theFunction, T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C7D40 Offset: 0x30C7E41 VA: 0x30C7D40
	|-CachedInvokableCall<bool>..ctor
	|
	|-RVA: 0x30C7DC0 Offset: 0x30C7EC1 VA: 0x30C7DC0
	|-CachedInvokableCall<int>..ctor
	|
	|-RVA: 0x30C7E40 Offset: 0x30C7F41 VA: 0x30C7E40
	|-CachedInvokableCall<object>..ctor
	|-CachedInvokableCall<string>..ctor
	|
	|-RVA: 0x30C7EC0 Offset: 0x30C7FC1 VA: 0x30C7EC0
	|-CachedInvokableCall<float>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C7D80 Offset: 0x30C7E81 VA: 0x30C7D80
	|-CachedInvokableCall<bool>.Invoke
	|
	|-RVA: 0x30C7E00 Offset: 0x30C7F01 VA: 0x30C7E00
	|-CachedInvokableCall<int>.Invoke
	|
	|-RVA: 0x30C7E80 Offset: 0x30C7F81 VA: 0x30C7E80
	|-CachedInvokableCall<object>.Invoke
	|
	|-RVA: 0x30C7F00 Offset: 0x30C8001 VA: 0x30C7F00
	|-CachedInvokableCall<float>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void Invoke(T arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C7DA0 Offset: 0x30C7EA1 VA: 0x30C7DA0
	|-CachedInvokableCall<bool>.Invoke
	|
	|-RVA: 0x30C7E20 Offset: 0x30C7F21 VA: 0x30C7E20
	|-CachedInvokableCall<int>.Invoke
	|
	|-RVA: 0x30C7EA0 Offset: 0x30C7FA1 VA: 0x30C7EA0
	|-CachedInvokableCall<object>.Invoke
	|
	|-RVA: 0x30C7F20 Offset: 0x30C8021 VA: 0x30C7F20
	|-CachedInvokableCall<float>.Invoke
	*/
}

