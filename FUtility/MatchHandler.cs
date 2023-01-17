// Namespace: FUtility
public sealed class MatchHandler<T> : MulticastDelegate // TypeDefIndex: 6340
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939500 Offset: 0x2939601 VA: 0x2939500
	|-MatchHandler<NativeBlock>..ctor
	|
	|-RVA: 0x2939840 Offset: 0x2939941 VA: 0x2939840
	|-MatchHandler<object>..ctor
	|-MatchHandler<SpringJobManager>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual int Invoke(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939520 Offset: 0x2939621 VA: 0x2939520
	|-MatchHandler<NativeBlock>.Invoke
	|
	|-RVA: 0x2939860 Offset: 0x2939961 VA: 0x2939860
	|-MatchHandler<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T obj, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939780 Offset: 0x2939881 VA: 0x2939780
	|-MatchHandler<NativeBlock>.BeginInvoke
	|
	|-RVA: 0x2939BC0 Offset: 0x2939CC1 VA: 0x2939BC0
	|-MatchHandler<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939810 Offset: 0x2939911 VA: 0x2939810
	|-MatchHandler<NativeBlock>.EndInvoke
	|
	|-RVA: 0x2939BF0 Offset: 0x2939CF1 VA: 0x2939BF0
	|-MatchHandler<object>.EndInvoke
	*/
}

