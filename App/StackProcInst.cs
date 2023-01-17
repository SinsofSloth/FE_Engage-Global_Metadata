// Namespace: App
public class StackProcInst<T> : ProcInst // TypeDefIndex: 9220
{
	// Fields
	private static Stack<T> s_Instances; // 0x0
	private static T s_Instance; // 0x0

	// Properties
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BAF80 Offset: 0x36BB081 VA: 0x36BAF80
	|-StackProcInst<EventSequence>.get_Instance
	|-StackProcInst<object>.get_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected sealed override void OnSingletonCreate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB0B0 Offset: 0x36BB1B1 VA: 0x36BB0B0
	|-StackProcInst<EventSequence>.OnSingletonCreate
	|-StackProcInst<object>.OnSingletonCreate
	|-StackProcInst<MyRoomMovieMenuItem.MyRoomMovieCallSequence>.OnSingletonCreate
	|-StackProcInst<MyRoomRelianceSubSelect.MyRoomRelianceCallSequence>.OnSingletonCreate
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected sealed override void OnSingletonDispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB240 Offset: 0x36BB341 VA: 0x36BB240
	|-StackProcInst<EventSequence>.OnSingletonDispose
	|-StackProcInst<object>.OnSingletonDispose
	|-StackProcInst<MyRoomMovieMenuItem.MyRoomMovieCallSequence>.OnSingletonDispose
	|-StackProcInst<MyRoomRelianceSubSelect.MyRoomRelianceCallSequence>.OnSingletonDispose
	*/

	// RVA: -1 Offset: -1
	public static bool op_Implicit(StackProcInst<T> exists) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB330 Offset: 0x36BB431 VA: 0x36BB330
	|-StackProcInst<EventSequence>.op_Implicit
	|-StackProcInst<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB340 Offset: 0x36BB441 VA: 0x36BB340
	|-StackProcInst<EventSequence>..ctor
	|-StackProcInst<object>..ctor
	|-StackProcInst<MyRoomMovieMenuItem.MyRoomMovieCallSequence>..ctor
	|-StackProcInst<MyRoomRelianceSubSelect.MyRoomRelianceCallSequence>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB350 Offset: 0x36BB451 VA: 0x36BB350
	|-StackProcInst<object>..cctor
	*/
}

