// Namespace: 
public sealed class ExecuteEvents.EventFunction<T1> : MulticastDelegate // TypeDefIndex: 4414
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CC3A0 Offset: 0x33CC4A1 VA: 0x33CC3A0
	|-ExecuteEvents.EventFunction<IBeginDragHandler>..ctor
	|-ExecuteEvents.EventFunction<ICancelHandler>..ctor
	|-ExecuteEvents.EventFunction<IDeselectHandler>..ctor
	|-ExecuteEvents.EventFunction<IDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IDropHandler>..ctor
	|-ExecuteEvents.EventFunction<IEndDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IInitializePotentialDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IMoveHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerClickHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerDownHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerEnterHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerExitHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerUpHandler>..ctor
	|-ExecuteEvents.EventFunction<IScrollHandler>..ctor
	|-ExecuteEvents.EventFunction<ISelectHandler>..ctor
	|-ExecuteEvents.EventFunction<ISubmitHandler>..ctor
	|-ExecuteEvents.EventFunction<IUpdateSelectedHandler>..ctor
	|-ExecuteEvents.EventFunction<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CC3C0 Offset: 0x33CC4C1 VA: 0x33CC3C0
	|-ExecuteEvents.EventFunction<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CC730 Offset: 0x33CC831 VA: 0x33CC730
	|-ExecuteEvents.EventFunction<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CC760 Offset: 0x33CC861 VA: 0x33CC760
	|-ExecuteEvents.EventFunction<object>.EndInvoke
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x43830 Offset: 0x43931 VA: 0x43830
[Serializable]
private sealed class ExecuteEvents.<>c // TypeDefIndex: 4415
{
	// Fields
	public static readonly ExecuteEvents.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1BFD090 Offset: 0x1BFD191 VA: 0x1BFD090
	private static void .cctor() { }

	// RVA: 0x1BFD100 Offset: 0x1BFD201 VA: 0x1BFD100
	public void .ctor() { }

	// RVA: 0x1BFD110 Offset: 0x1BFD211 VA: 0x1BFD110
	internal void <.cctor>b__79_0(List<IEventSystemHandler> l) { }
}

