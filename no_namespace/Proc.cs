// Namespace: 
public enum Proc.RootType // TypeDefIndex: 13859
{
	// Fields
	public int value__; // 0x0
	public const Proc.RootType Hi = 0;
	public const Proc.RootType Def = 1;
	public const Proc.RootType Low = 2;
	public const Proc.RootType Num = 3;
}

// Namespace: 
public sealed class Proc.ProcCallback<T> : MulticastDelegate // TypeDefIndex: 13860
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A84FC0 Offset: 0x2A850C1 VA: 0x2A84FC0
	|-Proc.ProcCallback<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T inst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A84FE0 Offset: 0x2A850E1 VA: 0x2A84FE0
	|-Proc.ProcCallback<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T inst, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85340 Offset: 0x2A85441 VA: 0x2A85340
	|-Proc.ProcCallback<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85370 Offset: 0x2A85471 VA: 0x2A85370
	|-Proc.ProcCallback<object>.EndInvoke
	*/
}

