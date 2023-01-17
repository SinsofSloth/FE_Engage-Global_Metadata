// Namespace: MoonSharp.Interpreter
public sealed class ScriptFunctionDelegate<T> : MulticastDelegate // TypeDefIndex: 5944
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000DB0 Offset: 0x3000EB1 VA: 0x3000DB0
	|-ScriptFunctionDelegate<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual T Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000DD0 Offset: 0x3000ED1 VA: 0x3000DD0
	|-ScriptFunctionDelegate<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(object[] args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3001130 Offset: 0x3001231 VA: 0x3001130
	|-ScriptFunctionDelegate<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual T EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3001160 Offset: 0x3001261 VA: 0x3001160
	|-ScriptFunctionDelegate<object>.EndInvoke
	*/
}

