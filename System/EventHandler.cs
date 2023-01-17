// Namespace: System
[Serializable]
public sealed class EventHandler<TEventArgs> : MulticastDelegate // TypeDefIndex: 216
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CC770 Offset: 0x33CC871 VA: 0x33CC770
	|-EventHandler<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(object sender, TEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CC790 Offset: 0x33CC891 VA: 0x33CC790
	|-EventHandler<object>.Invoke
	|-EventHandler<SafeSerializationEventArgs>.Invoke
	|-EventHandler<SocketAsyncEventArgs>.Invoke
	|-EventHandler<UnobservedTaskExceptionEventArgs>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, TEventArgs e, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCB00 Offset: 0x33CCC01 VA: 0x33CCB00
	|-EventHandler<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCB30 Offset: 0x33CCC31 VA: 0x33CCB30
	|-EventHandler<object>.EndInvoke
	*/
}

