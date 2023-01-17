// Namespace: UniRx
internal sealed class ObserverNode<T> : IObserver<T>, IDisposable // TypeDefIndex: 6767
{
	// Fields
	private readonly IObserver<T> observer; // 0x0
	private IObserverLinkedList<T> list; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13D80 Offset: 0x13E81 VA: 0x13D80
	private ObserverNode<T> <Previous>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13D90 Offset: 0x13E91 VA: 0x13D90
	private ObserverNode<T> <Next>k__BackingField; // 0x0

	// Properties
	public ObserverNode<T> Previous { get; set; }
	public ObserverNode<T> Next { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x17580 Offset: 0x17681 VA: 0x17580
	// RVA: -1 Offset: -1
	public ObserverNode<T> get_Previous() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37119A0 Offset: 0x3711AA1 VA: 0x37119A0
	|-ObserverNode<bool>.get_Previous
	|
	|-RVA: 0x3711CC0 Offset: 0x3711DC1 VA: 0x3711CC0
	|-ObserverNode<Bounds>.get_Previous
	|
	|-RVA: 0x3712010 Offset: 0x3712111 VA: 0x3712010
	|-ObserverNode<byte>.get_Previous
	|
	|-RVA: 0x3712330 Offset: 0x3712431 VA: 0x3712330
	|-ObserverNode<Color>.get_Previous
	|
	|-RVA: 0x3712670 Offset: 0x3712771 VA: 0x3712670
	|-ObserverNode<double>.get_Previous
	|
	|-RVA: 0x3712990 Offset: 0x3712A91 VA: 0x3712990
	|-ObserverNode<int>.get_Previous
	|
	|-RVA: 0x3712CB0 Offset: 0x3712DB1 VA: 0x3712CB0
	|-ObserverNode<long>.get_Previous
	|
	|-RVA: 0x3712FD0 Offset: 0x37130D1 VA: 0x3712FD0
	|-ObserverNode<object>.get_Previous
	|
	|-RVA: 0x37132F0 Offset: 0x37133F1 VA: 0x37132F0
	|-ObserverNode<Quaternion>.get_Previous
	|
	|-RVA: 0x3713630 Offset: 0x3713731 VA: 0x3713630
	|-ObserverNode<Rect>.get_Previous
	|
	|-RVA: 0x3713970 Offset: 0x3713A71 VA: 0x3713970
	|-ObserverNode<float>.get_Previous
	|
	|-RVA: 0x3713C90 Offset: 0x3713D91 VA: 0x3713C90
	|-ObserverNode<Vector2>.get_Previous
	|
	|-RVA: 0x3713FC0 Offset: 0x37140C1 VA: 0x3713FC0
	|-ObserverNode<Vector3>.get_Previous
	|
	|-RVA: 0x3714300 Offset: 0x3714401 VA: 0x3714300
	|-ObserverNode<Vector4>.get_Previous
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17590 Offset: 0x17691 VA: 0x17590
	// RVA: -1 Offset: -1
	internal void set_Previous(ObserverNode<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37119B0 Offset: 0x3711AB1 VA: 0x37119B0
	|-ObserverNode<bool>.set_Previous
	|
	|-RVA: 0x3711CD0 Offset: 0x3711DD1 VA: 0x3711CD0
	|-ObserverNode<Bounds>.set_Previous
	|
	|-RVA: 0x3712020 Offset: 0x3712121 VA: 0x3712020
	|-ObserverNode<byte>.set_Previous
	|
	|-RVA: 0x3712340 Offset: 0x3712441 VA: 0x3712340
	|-ObserverNode<Color>.set_Previous
	|
	|-RVA: 0x3712680 Offset: 0x3712781 VA: 0x3712680
	|-ObserverNode<double>.set_Previous
	|
	|-RVA: 0x37129A0 Offset: 0x3712AA1 VA: 0x37129A0
	|-ObserverNode<int>.set_Previous
	|
	|-RVA: 0x3712CC0 Offset: 0x3712DC1 VA: 0x3712CC0
	|-ObserverNode<long>.set_Previous
	|
	|-RVA: 0x3712FE0 Offset: 0x37130E1 VA: 0x3712FE0
	|-ObserverNode<object>.set_Previous
	|
	|-RVA: 0x3713300 Offset: 0x3713401 VA: 0x3713300
	|-ObserverNode<Quaternion>.set_Previous
	|
	|-RVA: 0x3713640 Offset: 0x3713741 VA: 0x3713640
	|-ObserverNode<Rect>.set_Previous
	|
	|-RVA: 0x3713980 Offset: 0x3713A81 VA: 0x3713980
	|-ObserverNode<float>.set_Previous
	|
	|-RVA: 0x3713CA0 Offset: 0x3713DA1 VA: 0x3713CA0
	|-ObserverNode<Vector2>.set_Previous
	|
	|-RVA: 0x3713FD0 Offset: 0x37140D1 VA: 0x3713FD0
	|-ObserverNode<Vector3>.set_Previous
	|
	|-RVA: 0x3714310 Offset: 0x3714411 VA: 0x3714310
	|-ObserverNode<Vector4>.set_Previous
	*/

	[CompilerGeneratedAttribute] // RVA: 0x175A0 Offset: 0x176A1 VA: 0x175A0
	// RVA: -1 Offset: -1
	public ObserverNode<T> get_Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37119C0 Offset: 0x3711AC1 VA: 0x37119C0
	|-ObserverNode<bool>.get_Next
	|
	|-RVA: 0x3711CE0 Offset: 0x3711DE1 VA: 0x3711CE0
	|-ObserverNode<Bounds>.get_Next
	|
	|-RVA: 0x3712030 Offset: 0x3712131 VA: 0x3712030
	|-ObserverNode<byte>.get_Next
	|
	|-RVA: 0x3712350 Offset: 0x3712451 VA: 0x3712350
	|-ObserverNode<Color>.get_Next
	|
	|-RVA: 0x3712690 Offset: 0x3712791 VA: 0x3712690
	|-ObserverNode<double>.get_Next
	|
	|-RVA: 0x37129B0 Offset: 0x3712AB1 VA: 0x37129B0
	|-ObserverNode<int>.get_Next
	|
	|-RVA: 0x3712CD0 Offset: 0x3712DD1 VA: 0x3712CD0
	|-ObserverNode<long>.get_Next
	|
	|-RVA: 0x3712FF0 Offset: 0x37130F1 VA: 0x3712FF0
	|-ObserverNode<object>.get_Next
	|
	|-RVA: 0x3713310 Offset: 0x3713411 VA: 0x3713310
	|-ObserverNode<Quaternion>.get_Next
	|
	|-RVA: 0x3713650 Offset: 0x3713751 VA: 0x3713650
	|-ObserverNode<Rect>.get_Next
	|
	|-RVA: 0x3713990 Offset: 0x3713A91 VA: 0x3713990
	|-ObserverNode<float>.get_Next
	|
	|-RVA: 0x3713CB0 Offset: 0x3713DB1 VA: 0x3713CB0
	|-ObserverNode<Vector2>.get_Next
	|
	|-RVA: 0x3713FE0 Offset: 0x37140E1 VA: 0x3713FE0
	|-ObserverNode<Vector3>.get_Next
	|
	|-RVA: 0x3714320 Offset: 0x3714421 VA: 0x3714320
	|-ObserverNode<Vector4>.get_Next
	*/

	[CompilerGeneratedAttribute] // RVA: 0x175B0 Offset: 0x176B1 VA: 0x175B0
	// RVA: -1 Offset: -1
	internal void set_Next(ObserverNode<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37119D0 Offset: 0x3711AD1 VA: 0x37119D0
	|-ObserverNode<bool>.set_Next
	|
	|-RVA: 0x3711CF0 Offset: 0x3711DF1 VA: 0x3711CF0
	|-ObserverNode<Bounds>.set_Next
	|
	|-RVA: 0x3712040 Offset: 0x3712141 VA: 0x3712040
	|-ObserverNode<byte>.set_Next
	|
	|-RVA: 0x3712360 Offset: 0x3712461 VA: 0x3712360
	|-ObserverNode<Color>.set_Next
	|
	|-RVA: 0x37126A0 Offset: 0x37127A1 VA: 0x37126A0
	|-ObserverNode<double>.set_Next
	|
	|-RVA: 0x37129C0 Offset: 0x3712AC1 VA: 0x37129C0
	|-ObserverNode<int>.set_Next
	|
	|-RVA: 0x3712CE0 Offset: 0x3712DE1 VA: 0x3712CE0
	|-ObserverNode<long>.set_Next
	|
	|-RVA: 0x3713000 Offset: 0x3713101 VA: 0x3713000
	|-ObserverNode<object>.set_Next
	|
	|-RVA: 0x3713320 Offset: 0x3713421 VA: 0x3713320
	|-ObserverNode<Quaternion>.set_Next
	|
	|-RVA: 0x3713660 Offset: 0x3713761 VA: 0x3713660
	|-ObserverNode<Rect>.set_Next
	|
	|-RVA: 0x37139A0 Offset: 0x3713AA1 VA: 0x37139A0
	|-ObserverNode<float>.set_Next
	|
	|-RVA: 0x3713CC0 Offset: 0x3713DC1 VA: 0x3713CC0
	|-ObserverNode<Vector2>.set_Next
	|
	|-RVA: 0x3713FF0 Offset: 0x37140F1 VA: 0x3713FF0
	|-ObserverNode<Vector3>.set_Next
	|
	|-RVA: 0x3714330 Offset: 0x3714431 VA: 0x3714330
	|-ObserverNode<Vector4>.set_Next
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObserverLinkedList<T> list, IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37119E0 Offset: 0x3711AE1 VA: 0x37119E0
	|-ObserverNode<bool>..ctor
	|
	|-RVA: 0x3711D00 Offset: 0x3711E01 VA: 0x3711D00
	|-ObserverNode<Bounds>..ctor
	|
	|-RVA: 0x3712050 Offset: 0x3712151 VA: 0x3712050
	|-ObserverNode<byte>..ctor
	|
	|-RVA: 0x3712370 Offset: 0x3712471 VA: 0x3712370
	|-ObserverNode<Color>..ctor
	|
	|-RVA: 0x37126B0 Offset: 0x37127B1 VA: 0x37126B0
	|-ObserverNode<double>..ctor
	|
	|-RVA: 0x37129D0 Offset: 0x3712AD1 VA: 0x37129D0
	|-ObserverNode<int>..ctor
	|
	|-RVA: 0x3712CF0 Offset: 0x3712DF1 VA: 0x3712CF0
	|-ObserverNode<long>..ctor
	|
	|-RVA: 0x3713010 Offset: 0x3713111 VA: 0x3713010
	|-ObserverNode<object>..ctor
	|
	|-RVA: 0x3713330 Offset: 0x3713431 VA: 0x3713330
	|-ObserverNode<Quaternion>..ctor
	|
	|-RVA: 0x3713670 Offset: 0x3713771 VA: 0x3713670
	|-ObserverNode<Rect>..ctor
	|
	|-RVA: 0x37139B0 Offset: 0x3713AB1 VA: 0x37139B0
	|-ObserverNode<float>..ctor
	|
	|-RVA: 0x3713CD0 Offset: 0x3713DD1 VA: 0x3713CD0
	|-ObserverNode<Vector2>..ctor
	|
	|-RVA: 0x3714000 Offset: 0x3714101 VA: 0x3714000
	|-ObserverNode<Vector3>..ctor
	|
	|-RVA: 0x3714340 Offset: 0x3714441 VA: 0x3714340
	|-ObserverNode<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3711A30 Offset: 0x3711B31 VA: 0x3711A30
	|-ObserverNode<bool>.OnNext
	|
	|-RVA: 0x3711D50 Offset: 0x3711E51 VA: 0x3711D50
	|-ObserverNode<Bounds>.OnNext
	|
	|-RVA: 0x37120A0 Offset: 0x37121A1 VA: 0x37120A0
	|-ObserverNode<byte>.OnNext
	|
	|-RVA: 0x37123C0 Offset: 0x37124C1 VA: 0x37123C0
	|-ObserverNode<Color>.OnNext
	|
	|-RVA: 0x3712700 Offset: 0x3712801 VA: 0x3712700
	|-ObserverNode<double>.OnNext
	|
	|-RVA: 0x3712A20 Offset: 0x3712B21 VA: 0x3712A20
	|-ObserverNode<int>.OnNext
	|
	|-RVA: 0x3712D40 Offset: 0x3712E41 VA: 0x3712D40
	|-ObserverNode<long>.OnNext
	|
	|-RVA: 0x3713060 Offset: 0x3713161 VA: 0x3713060
	|-ObserverNode<object>.OnNext
	|
	|-RVA: 0x3713380 Offset: 0x3713481 VA: 0x3713380
	|-ObserverNode<Quaternion>.OnNext
	|
	|-RVA: 0x37136C0 Offset: 0x37137C1 VA: 0x37136C0
	|-ObserverNode<Rect>.OnNext
	|
	|-RVA: 0x3713A00 Offset: 0x3713B01 VA: 0x3713A00
	|-ObserverNode<float>.OnNext
	|
	|-RVA: 0x3713D20 Offset: 0x3713E21 VA: 0x3713D20
	|-ObserverNode<Vector2>.OnNext
	|
	|-RVA: 0x3714050 Offset: 0x3714151 VA: 0x3714050
	|-ObserverNode<Vector3>.OnNext
	|
	|-RVA: 0x3714390 Offset: 0x3714491 VA: 0x3714390
	|-ObserverNode<Vector4>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3711AD0 Offset: 0x3711BD1 VA: 0x3711AD0
	|-ObserverNode<bool>.OnError
	|
	|-RVA: 0x3711E20 Offset: 0x3711F21 VA: 0x3711E20
	|-ObserverNode<Bounds>.OnError
	|
	|-RVA: 0x3712140 Offset: 0x3712241 VA: 0x3712140
	|-ObserverNode<byte>.OnError
	|
	|-RVA: 0x3712480 Offset: 0x3712581 VA: 0x3712480
	|-ObserverNode<Color>.OnError
	|
	|-RVA: 0x37127A0 Offset: 0x37128A1 VA: 0x37127A0
	|-ObserverNode<double>.OnError
	|
	|-RVA: 0x3712AC0 Offset: 0x3712BC1 VA: 0x3712AC0
	|-ObserverNode<int>.OnError
	|
	|-RVA: 0x3712DE0 Offset: 0x3712EE1 VA: 0x3712DE0
	|-ObserverNode<long>.OnError
	|
	|-RVA: 0x3713100 Offset: 0x3713201 VA: 0x3713100
	|-ObserverNode<object>.OnError
	|
	|-RVA: 0x3713440 Offset: 0x3713541 VA: 0x3713440
	|-ObserverNode<Quaternion>.OnError
	|
	|-RVA: 0x3713780 Offset: 0x3713881 VA: 0x3713780
	|-ObserverNode<Rect>.OnError
	|
	|-RVA: 0x3713AA0 Offset: 0x3713BA1 VA: 0x3713AA0
	|-ObserverNode<float>.OnError
	|
	|-RVA: 0x3713DD0 Offset: 0x3713ED1 VA: 0x3713DD0
	|-ObserverNode<Vector2>.OnError
	|
	|-RVA: 0x3714110 Offset: 0x3714211 VA: 0x3714110
	|-ObserverNode<Vector3>.OnError
	|
	|-RVA: 0x3714450 Offset: 0x3714551 VA: 0x3714450
	|-ObserverNode<Vector4>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3711B70 Offset: 0x3711C71 VA: 0x3711B70
	|-ObserverNode<bool>.OnCompleted
	|
	|-RVA: 0x3711EC0 Offset: 0x3711FC1 VA: 0x3711EC0
	|-ObserverNode<Bounds>.OnCompleted
	|
	|-RVA: 0x37121E0 Offset: 0x37122E1 VA: 0x37121E0
	|-ObserverNode<byte>.OnCompleted
	|
	|-RVA: 0x3712520 Offset: 0x3712621 VA: 0x3712520
	|-ObserverNode<Color>.OnCompleted
	|
	|-RVA: 0x3712840 Offset: 0x3712941 VA: 0x3712840
	|-ObserverNode<double>.OnCompleted
	|
	|-RVA: 0x3712B60 Offset: 0x3712C61 VA: 0x3712B60
	|-ObserverNode<int>.OnCompleted
	|
	|-RVA: 0x3712E80 Offset: 0x3712F81 VA: 0x3712E80
	|-ObserverNode<long>.OnCompleted
	|
	|-RVA: 0x37131A0 Offset: 0x37132A1 VA: 0x37131A0
	|-ObserverNode<object>.OnCompleted
	|
	|-RVA: 0x37134E0 Offset: 0x37135E1 VA: 0x37134E0
	|-ObserverNode<Quaternion>.OnCompleted
	|
	|-RVA: 0x3713820 Offset: 0x3713921 VA: 0x3713820
	|-ObserverNode<Rect>.OnCompleted
	|
	|-RVA: 0x3713B40 Offset: 0x3713C41 VA: 0x3713B40
	|-ObserverNode<float>.OnCompleted
	|
	|-RVA: 0x3713E70 Offset: 0x3713F71 VA: 0x3713E70
	|-ObserverNode<Vector2>.OnCompleted
	|
	|-RVA: 0x37141B0 Offset: 0x37142B1 VA: 0x37141B0
	|-ObserverNode<Vector3>.OnCompleted
	|
	|-RVA: 0x37144F0 Offset: 0x37145F1 VA: 0x37144F0
	|-ObserverNode<Vector4>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3711C00 Offset: 0x3711D01 VA: 0x3711C00
	|-ObserverNode<bool>.Dispose
	|
	|-RVA: 0x3711F50 Offset: 0x3712051 VA: 0x3711F50
	|-ObserverNode<Bounds>.Dispose
	|
	|-RVA: 0x3712270 Offset: 0x3712371 VA: 0x3712270
	|-ObserverNode<byte>.Dispose
	|
	|-RVA: 0x37125B0 Offset: 0x37126B1 VA: 0x37125B0
	|-ObserverNode<Color>.Dispose
	|
	|-RVA: 0x37128D0 Offset: 0x37129D1 VA: 0x37128D0
	|-ObserverNode<double>.Dispose
	|
	|-RVA: 0x3712BF0 Offset: 0x3712CF1 VA: 0x3712BF0
	|-ObserverNode<int>.Dispose
	|
	|-RVA: 0x3712F10 Offset: 0x3713011 VA: 0x3712F10
	|-ObserverNode<long>.Dispose
	|
	|-RVA: 0x3713230 Offset: 0x3713331 VA: 0x3713230
	|-ObserverNode<object>.Dispose
	|
	|-RVA: 0x3713570 Offset: 0x3713671 VA: 0x3713570
	|-ObserverNode<Quaternion>.Dispose
	|
	|-RVA: 0x37138B0 Offset: 0x37139B1 VA: 0x37138B0
	|-ObserverNode<Rect>.Dispose
	|
	|-RVA: 0x3713BD0 Offset: 0x3713CD1 VA: 0x3713BD0
	|-ObserverNode<float>.Dispose
	|
	|-RVA: 0x3713F00 Offset: 0x3714001 VA: 0x3713F00
	|-ObserverNode<Vector2>.Dispose
	|
	|-RVA: 0x3714240 Offset: 0x3714341 VA: 0x3714240
	|-ObserverNode<Vector3>.Dispose
	|
	|-RVA: 0x3714580 Offset: 0x3714681 VA: 0x3714580
	|-ObserverNode<Vector4>.Dispose
	*/
}

