// Namespace: UnityEngine.Rendering
public sealed class ListChangedEventHandler<T> : MulticastDelegate // TypeDefIndex: 4542
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B00CE0 Offset: 0x3B00DE1 VA: 0x3B00CE0
	|-ListChangedEventHandler<object>..ctor
	|-ListChangedEventHandler<DebugUI.Widget>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ObservableList<T> sender, ListChangedEventArgs<T> e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B00D00 Offset: 0x3B00E01 VA: 0x3B00D00
	|-ListChangedEventHandler<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ObservableList<T> sender, ListChangedEventArgs<T> e, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B01070 Offset: 0x3B01171 VA: 0x3B01070
	|-ListChangedEventHandler<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B010A0 Offset: 0x3B011A1 VA: 0x3B010A0
	|-ListChangedEventHandler<object>.EndInvoke
	*/
}

