// Namespace: UniRx.Async.Internal
public class MinimumQueue<T> // TypeDefIndex: 5214
{
	// Fields
	private const int MinimumGrow = 4;
	private const int GrowFactor = 200;
	private T[] array; // 0x0
	private int head; // 0x0
	private int tail; // 0x0
	private int size; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293C740 Offset: 0x293C841 VA: 0x293C740
	|-MinimumQueue<ValueTuple<int, bool>>..ctor
	|
	|-RVA: 0x293CB60 Offset: 0x293CC61 VA: 0x293CB60
	|-MinimumQueue<ValueTuple<int, Bounds>>..ctor
	|
	|-RVA: 0x293D010 Offset: 0x293D111 VA: 0x293D010
	|-MinimumQueue<ValueTuple<int, byte>>..ctor
	|
	|-RVA: 0x293D430 Offset: 0x293D531 VA: 0x293D430
	|-MinimumQueue<ValueTuple<int, Color>>..ctor
	|
	|-RVA: 0x293D8C0 Offset: 0x293D9C1 VA: 0x293D8C0
	|-MinimumQueue<ValueTuple<int, double>>..ctor
	|
	|-RVA: 0x293DCF0 Offset: 0x293DDF1 VA: 0x293DCF0
	|-MinimumQueue<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x293E110 Offset: 0x293E211 VA: 0x293E110
	|-MinimumQueue<ValueTuple<int, long>>..ctor
	|
	|-RVA: 0x293E540 Offset: 0x293E641 VA: 0x293E540
	|-MinimumQueue<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x293E9A0 Offset: 0x293EAA1 VA: 0x293E9A0
	|-MinimumQueue<ValueTuple<int, Quaternion>>..ctor
	|
	|-RVA: 0x293EE30 Offset: 0x293EF31 VA: 0x293EE30
	|-MinimumQueue<ValueTuple<int, Rect>>..ctor
	|
	|-RVA: 0x293F2C0 Offset: 0x293F3C1 VA: 0x293F2C0
	|-MinimumQueue<ValueTuple<int, float>>..ctor
	|
	|-RVA: 0x293F6E0 Offset: 0x293F7E1 VA: 0x293F6E0
	|-MinimumQueue<ValueTuple<int, Unit>>..ctor
	|
	|-RVA: 0x293FB00 Offset: 0x293FC01 VA: 0x293FB00
	|-MinimumQueue<ValueTuple<int, Vector2>>..ctor
	|
	|-RVA: 0x293FF40 Offset: 0x2940041 VA: 0x293FF40
	|-MinimumQueue<ValueTuple<int, Vector3>>..ctor
	|
	|-RVA: 0x2940370 Offset: 0x2940471 VA: 0x2940370
	|-MinimumQueue<ValueTuple<int, Vector4>>..ctor
	|
	|-RVA: 0x2940800 Offset: 0x2940901 VA: 0x2940800
	|-MinimumQueue<Action>..ctor
	|-MinimumQueue<CancellationTokenSource>..ctor
	|-MinimumQueue<IPlayerLoopItem>..ctor
	|-MinimumQueue<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293C800 Offset: 0x293C901 VA: 0x293C800
	|-MinimumQueue<ValueTuple<int, bool>>.get_Count
	|
	|-RVA: 0x293CC20 Offset: 0x293CD21 VA: 0x293CC20
	|-MinimumQueue<ValueTuple<int, Bounds>>.get_Count
	|
	|-RVA: 0x293D0D0 Offset: 0x293D1D1 VA: 0x293D0D0
	|-MinimumQueue<ValueTuple<int, byte>>.get_Count
	|
	|-RVA: 0x293D4F0 Offset: 0x293D5F1 VA: 0x293D4F0
	|-MinimumQueue<ValueTuple<int, Color>>.get_Count
	|
	|-RVA: 0x293D980 Offset: 0x293DA81 VA: 0x293D980
	|-MinimumQueue<ValueTuple<int, double>>.get_Count
	|
	|-RVA: 0x293DDB0 Offset: 0x293DEB1 VA: 0x293DDB0
	|-MinimumQueue<ValueTuple<int, int>>.get_Count
	|
	|-RVA: 0x293E1D0 Offset: 0x293E2D1 VA: 0x293E1D0
	|-MinimumQueue<ValueTuple<int, long>>.get_Count
	|
	|-RVA: 0x293E600 Offset: 0x293E701 VA: 0x293E600
	|-MinimumQueue<ValueTuple<int, object>>.get_Count
	|
	|-RVA: 0x293EA60 Offset: 0x293EB61 VA: 0x293EA60
	|-MinimumQueue<ValueTuple<int, Quaternion>>.get_Count
	|
	|-RVA: 0x293EEF0 Offset: 0x293EFF1 VA: 0x293EEF0
	|-MinimumQueue<ValueTuple<int, Rect>>.get_Count
	|
	|-RVA: 0x293F380 Offset: 0x293F481 VA: 0x293F380
	|-MinimumQueue<ValueTuple<int, float>>.get_Count
	|
	|-RVA: 0x293F7A0 Offset: 0x293F8A1 VA: 0x293F7A0
	|-MinimumQueue<ValueTuple<int, Unit>>.get_Count
	|
	|-RVA: 0x293FBC0 Offset: 0x293FCC1 VA: 0x293FBC0
	|-MinimumQueue<ValueTuple<int, Vector2>>.get_Count
	|
	|-RVA: 0x2940000 Offset: 0x2940101 VA: 0x2940000
	|-MinimumQueue<ValueTuple<int, Vector3>>.get_Count
	|
	|-RVA: 0x2940430 Offset: 0x2940531 VA: 0x2940430
	|-MinimumQueue<ValueTuple<int, Vector4>>.get_Count
	|
	|-RVA: 0x29408C0 Offset: 0x29409C1 VA: 0x29408C0
	|-MinimumQueue<Action>.get_Count
	|-MinimumQueue<CancellationTokenSource>.get_Count
	|-MinimumQueue<IPlayerLoopItem>.get_Count
	|-MinimumQueue<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293C810 Offset: 0x293C911 VA: 0x293C810
	|-MinimumQueue<ValueTuple<int, bool>>.Peek
	|
	|-RVA: 0x293CC30 Offset: 0x293CD31 VA: 0x293CC30
	|-MinimumQueue<ValueTuple<int, Bounds>>.Peek
	|
	|-RVA: 0x293D0E0 Offset: 0x293D1E1 VA: 0x293D0E0
	|-MinimumQueue<ValueTuple<int, byte>>.Peek
	|
	|-RVA: 0x293D500 Offset: 0x293D601 VA: 0x293D500
	|-MinimumQueue<ValueTuple<int, Color>>.Peek
	|
	|-RVA: 0x293D990 Offset: 0x293DA91 VA: 0x293D990
	|-MinimumQueue<ValueTuple<int, double>>.Peek
	|
	|-RVA: 0x293DDC0 Offset: 0x293DEC1 VA: 0x293DDC0
	|-MinimumQueue<ValueTuple<int, int>>.Peek
	|
	|-RVA: 0x293E1E0 Offset: 0x293E2E1 VA: 0x293E1E0
	|-MinimumQueue<ValueTuple<int, long>>.Peek
	|
	|-RVA: 0x293E610 Offset: 0x293E711 VA: 0x293E610
	|-MinimumQueue<ValueTuple<int, object>>.Peek
	|
	|-RVA: 0x293EA70 Offset: 0x293EB71 VA: 0x293EA70
	|-MinimumQueue<ValueTuple<int, Quaternion>>.Peek
	|
	|-RVA: 0x293EF00 Offset: 0x293F001 VA: 0x293EF00
	|-MinimumQueue<ValueTuple<int, Rect>>.Peek
	|
	|-RVA: 0x293F390 Offset: 0x293F491 VA: 0x293F390
	|-MinimumQueue<ValueTuple<int, float>>.Peek
	|
	|-RVA: 0x293F7B0 Offset: 0x293F8B1 VA: 0x293F7B0
	|-MinimumQueue<ValueTuple<int, Unit>>.Peek
	|
	|-RVA: 0x293FBD0 Offset: 0x293FCD1 VA: 0x293FBD0
	|-MinimumQueue<ValueTuple<int, Vector2>>.Peek
	|
	|-RVA: 0x2940010 Offset: 0x2940111 VA: 0x2940010
	|-MinimumQueue<ValueTuple<int, Vector3>>.Peek
	|
	|-RVA: 0x2940440 Offset: 0x2940541 VA: 0x2940440
	|-MinimumQueue<ValueTuple<int, Vector4>>.Peek
	|
	|-RVA: 0x29408D0 Offset: 0x29409D1 VA: 0x29408D0
	|-MinimumQueue<object>.Peek
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293C880 Offset: 0x293C981 VA: 0x293C880
	|-MinimumQueue<ValueTuple<int, bool>>.Enqueue
	|
	|-RVA: 0x293CCB0 Offset: 0x293CDB1 VA: 0x293CCB0
	|-MinimumQueue<ValueTuple<int, Bounds>>.Enqueue
	|
	|-RVA: 0x293D150 Offset: 0x293D251 VA: 0x293D150
	|-MinimumQueue<ValueTuple<int, byte>>.Enqueue
	|
	|-RVA: 0x293D580 Offset: 0x293D681 VA: 0x293D580
	|-MinimumQueue<ValueTuple<int, Color>>.Enqueue
	|
	|-RVA: 0x293DA00 Offset: 0x293DB01 VA: 0x293DA00
	|-MinimumQueue<ValueTuple<int, double>>.Enqueue
	|
	|-RVA: 0x293DE30 Offset: 0x293DF31 VA: 0x293DE30
	|-MinimumQueue<ValueTuple<int, int>>.Enqueue
	|
	|-RVA: 0x293E250 Offset: 0x293E351 VA: 0x293E250
	|-MinimumQueue<ValueTuple<int, long>>.Enqueue
	|
	|-RVA: 0x293E680 Offset: 0x293E781 VA: 0x293E680
	|-MinimumQueue<ValueTuple<int, object>>.Enqueue
	|
	|-RVA: 0x293EAF0 Offset: 0x293EBF1 VA: 0x293EAF0
	|-MinimumQueue<ValueTuple<int, Quaternion>>.Enqueue
	|
	|-RVA: 0x293EF80 Offset: 0x293F081 VA: 0x293EF80
	|-MinimumQueue<ValueTuple<int, Rect>>.Enqueue
	|
	|-RVA: 0x293F400 Offset: 0x293F501 VA: 0x293F400
	|-MinimumQueue<ValueTuple<int, float>>.Enqueue
	|
	|-RVA: 0x293F820 Offset: 0x293F921 VA: 0x293F820
	|-MinimumQueue<ValueTuple<int, Unit>>.Enqueue
	|
	|-RVA: 0x293FC40 Offset: 0x293FD41 VA: 0x293FC40
	|-MinimumQueue<ValueTuple<int, Vector2>>.Enqueue
	|
	|-RVA: 0x2940080 Offset: 0x2940181 VA: 0x2940080
	|-MinimumQueue<ValueTuple<int, Vector3>>.Enqueue
	|
	|-RVA: 0x29404C0 Offset: 0x29405C1 VA: 0x29404C0
	|-MinimumQueue<ValueTuple<int, Vector4>>.Enqueue
	|
	|-RVA: 0x2940940 Offset: 0x2940A41 VA: 0x2940940
	|-MinimumQueue<Action>.Enqueue
	|-MinimumQueue<CancellationTokenSource>.Enqueue
	|-MinimumQueue<IPlayerLoopItem>.Enqueue
	|-MinimumQueue<object>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293C930 Offset: 0x293CA31 VA: 0x293C930
	|-MinimumQueue<ValueTuple<int, bool>>.Dequeue
	|
	|-RVA: 0x293CD90 Offset: 0x293CE91 VA: 0x293CD90
	|-MinimumQueue<ValueTuple<int, Bounds>>.Dequeue
	|
	|-RVA: 0x293D200 Offset: 0x293D301 VA: 0x293D200
	|-MinimumQueue<ValueTuple<int, byte>>.Dequeue
	|
	|-RVA: 0x293D650 Offset: 0x293D751 VA: 0x293D650
	|-MinimumQueue<ValueTuple<int, Color>>.Dequeue
	|
	|-RVA: 0x293DAB0 Offset: 0x293DBB1 VA: 0x293DAB0
	|-MinimumQueue<ValueTuple<int, double>>.Dequeue
	|
	|-RVA: 0x293DEE0 Offset: 0x293DFE1 VA: 0x293DEE0
	|-MinimumQueue<ValueTuple<int, int>>.Dequeue
	|
	|-RVA: 0x293E300 Offset: 0x293E401 VA: 0x293E300
	|-MinimumQueue<ValueTuple<int, long>>.Dequeue
	|
	|-RVA: 0x293E750 Offset: 0x293E851 VA: 0x293E750
	|-MinimumQueue<ValueTuple<int, object>>.Dequeue
	|
	|-RVA: 0x293EBC0 Offset: 0x293ECC1 VA: 0x293EBC0
	|-MinimumQueue<ValueTuple<int, Quaternion>>.Dequeue
	|
	|-RVA: 0x293F050 Offset: 0x293F151 VA: 0x293F050
	|-MinimumQueue<ValueTuple<int, Rect>>.Dequeue
	|
	|-RVA: 0x293F4B0 Offset: 0x293F5B1 VA: 0x293F4B0
	|-MinimumQueue<ValueTuple<int, float>>.Dequeue
	|
	|-RVA: 0x293F8D0 Offset: 0x293F9D1 VA: 0x293F8D0
	|-MinimumQueue<ValueTuple<int, Unit>>.Dequeue
	|
	|-RVA: 0x293FD00 Offset: 0x293FE01 VA: 0x293FD00
	|-MinimumQueue<ValueTuple<int, Vector2>>.Dequeue
	|
	|-RVA: 0x2940130 Offset: 0x2940231 VA: 0x2940130
	|-MinimumQueue<ValueTuple<int, Vector3>>.Dequeue
	|
	|-RVA: 0x2940590 Offset: 0x2940691 VA: 0x2940590
	|-MinimumQueue<ValueTuple<int, Vector4>>.Dequeue
	|
	|-RVA: 0x2940A00 Offset: 0x2940B01 VA: 0x2940A00
	|-MinimumQueue<Action>.Dequeue
	|-MinimumQueue<CancellationTokenSource>.Dequeue
	|-MinimumQueue<IPlayerLoopItem>.Dequeue
	|-MinimumQueue<object>.Dequeue
	*/

	// RVA: -1 Offset: -1
	private void Grow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293C9D0 Offset: 0x293CAD1 VA: 0x293C9D0
	|-MinimumQueue<ValueTuple<int, bool>>.Grow
	|
	|-RVA: 0x293CE80 Offset: 0x293CF81 VA: 0x293CE80
	|-MinimumQueue<ValueTuple<int, Bounds>>.Grow
	|
	|-RVA: 0x293D2A0 Offset: 0x293D3A1 VA: 0x293D2A0
	|-MinimumQueue<ValueTuple<int, byte>>.Grow
	|
	|-RVA: 0x293D730 Offset: 0x293D831 VA: 0x293D730
	|-MinimumQueue<ValueTuple<int, Color>>.Grow
	|
	|-RVA: 0x293DB60 Offset: 0x293DC61 VA: 0x293DB60
	|-MinimumQueue<ValueTuple<int, double>>.Grow
	|
	|-RVA: 0x293DF80 Offset: 0x293E081 VA: 0x293DF80
	|-MinimumQueue<ValueTuple<int, int>>.Grow
	|
	|-RVA: 0x293E3B0 Offset: 0x293E4B1 VA: 0x293E3B0
	|-MinimumQueue<ValueTuple<int, long>>.Grow
	|
	|-RVA: 0x293E810 Offset: 0x293E911 VA: 0x293E810
	|-MinimumQueue<ValueTuple<int, object>>.Grow
	|
	|-RVA: 0x293ECA0 Offset: 0x293EDA1 VA: 0x293ECA0
	|-MinimumQueue<ValueTuple<int, Quaternion>>.Grow
	|
	|-RVA: 0x293F130 Offset: 0x293F231 VA: 0x293F130
	|-MinimumQueue<ValueTuple<int, Rect>>.Grow
	|
	|-RVA: 0x293F550 Offset: 0x293F651 VA: 0x293F550
	|-MinimumQueue<ValueTuple<int, float>>.Grow
	|
	|-RVA: 0x293F970 Offset: 0x293FA71 VA: 0x293F970
	|-MinimumQueue<ValueTuple<int, Unit>>.Grow
	|
	|-RVA: 0x293FDB0 Offset: 0x293FEB1 VA: 0x293FDB0
	|-MinimumQueue<ValueTuple<int, Vector2>>.Grow
	|
	|-RVA: 0x29401E0 Offset: 0x29402E1 VA: 0x29401E0
	|-MinimumQueue<ValueTuple<int, Vector3>>.Grow
	|
	|-RVA: 0x2940670 Offset: 0x2940771 VA: 0x2940670
	|-MinimumQueue<ValueTuple<int, Vector4>>.Grow
	|
	|-RVA: 0x2940AB0 Offset: 0x2940BB1 VA: 0x2940AB0
	|-MinimumQueue<object>.Grow
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293CA00 Offset: 0x293CB01 VA: 0x293CA00
	|-MinimumQueue<ValueTuple<int, bool>>.SetCapacity
	|
	|-RVA: 0x293CEB0 Offset: 0x293CFB1 VA: 0x293CEB0
	|-MinimumQueue<ValueTuple<int, Bounds>>.SetCapacity
	|
	|-RVA: 0x293D2D0 Offset: 0x293D3D1 VA: 0x293D2D0
	|-MinimumQueue<ValueTuple<int, byte>>.SetCapacity
	|
	|-RVA: 0x293D760 Offset: 0x293D861 VA: 0x293D760
	|-MinimumQueue<ValueTuple<int, Color>>.SetCapacity
	|
	|-RVA: 0x293DB90 Offset: 0x293DC91 VA: 0x293DB90
	|-MinimumQueue<ValueTuple<int, double>>.SetCapacity
	|
	|-RVA: 0x293DFB0 Offset: 0x293E0B1 VA: 0x293DFB0
	|-MinimumQueue<ValueTuple<int, int>>.SetCapacity
	|
	|-RVA: 0x293E3E0 Offset: 0x293E4E1 VA: 0x293E3E0
	|-MinimumQueue<ValueTuple<int, long>>.SetCapacity
	|
	|-RVA: 0x293E840 Offset: 0x293E941 VA: 0x293E840
	|-MinimumQueue<ValueTuple<int, object>>.SetCapacity
	|
	|-RVA: 0x293ECD0 Offset: 0x293EDD1 VA: 0x293ECD0
	|-MinimumQueue<ValueTuple<int, Quaternion>>.SetCapacity
	|
	|-RVA: 0x293F160 Offset: 0x293F261 VA: 0x293F160
	|-MinimumQueue<ValueTuple<int, Rect>>.SetCapacity
	|
	|-RVA: 0x293F580 Offset: 0x293F681 VA: 0x293F580
	|-MinimumQueue<ValueTuple<int, float>>.SetCapacity
	|
	|-RVA: 0x293F9A0 Offset: 0x293FAA1 VA: 0x293F9A0
	|-MinimumQueue<ValueTuple<int, Unit>>.SetCapacity
	|
	|-RVA: 0x293FDE0 Offset: 0x293FEE1 VA: 0x293FDE0
	|-MinimumQueue<ValueTuple<int, Vector2>>.SetCapacity
	|
	|-RVA: 0x2940210 Offset: 0x2940311 VA: 0x2940210
	|-MinimumQueue<ValueTuple<int, Vector3>>.SetCapacity
	|
	|-RVA: 0x29406A0 Offset: 0x29407A1 VA: 0x29406A0
	|-MinimumQueue<ValueTuple<int, Vector4>>.SetCapacity
	|
	|-RVA: 0x2940AE0 Offset: 0x2940BE1 VA: 0x2940AE0
	|-MinimumQueue<object>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private void MoveNext(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293CAE0 Offset: 0x293CBE1 VA: 0x293CAE0
	|-MinimumQueue<ValueTuple<int, bool>>.MoveNext
	|
	|-RVA: 0x293CF90 Offset: 0x293D091 VA: 0x293CF90
	|-MinimumQueue<ValueTuple<int, Bounds>>.MoveNext
	|
	|-RVA: 0x293D3B0 Offset: 0x293D4B1 VA: 0x293D3B0
	|-MinimumQueue<ValueTuple<int, byte>>.MoveNext
	|
	|-RVA: 0x293D840 Offset: 0x293D941 VA: 0x293D840
	|-MinimumQueue<ValueTuple<int, Color>>.MoveNext
	|
	|-RVA: 0x293DC70 Offset: 0x293DD71 VA: 0x293DC70
	|-MinimumQueue<ValueTuple<int, double>>.MoveNext
	|
	|-RVA: 0x293E090 Offset: 0x293E191 VA: 0x293E090
	|-MinimumQueue<ValueTuple<int, int>>.MoveNext
	|
	|-RVA: 0x293E4C0 Offset: 0x293E5C1 VA: 0x293E4C0
	|-MinimumQueue<ValueTuple<int, long>>.MoveNext
	|
	|-RVA: 0x293E920 Offset: 0x293EA21 VA: 0x293E920
	|-MinimumQueue<ValueTuple<int, object>>.MoveNext
	|
	|-RVA: 0x293EDB0 Offset: 0x293EEB1 VA: 0x293EDB0
	|-MinimumQueue<ValueTuple<int, Quaternion>>.MoveNext
	|
	|-RVA: 0x293F240 Offset: 0x293F341 VA: 0x293F240
	|-MinimumQueue<ValueTuple<int, Rect>>.MoveNext
	|
	|-RVA: 0x293F660 Offset: 0x293F761 VA: 0x293F660
	|-MinimumQueue<ValueTuple<int, float>>.MoveNext
	|
	|-RVA: 0x293FA80 Offset: 0x293FB81 VA: 0x293FA80
	|-MinimumQueue<ValueTuple<int, Unit>>.MoveNext
	|
	|-RVA: 0x293FEC0 Offset: 0x293FFC1 VA: 0x293FEC0
	|-MinimumQueue<ValueTuple<int, Vector2>>.MoveNext
	|
	|-RVA: 0x29402F0 Offset: 0x29403F1 VA: 0x29402F0
	|-MinimumQueue<ValueTuple<int, Vector3>>.MoveNext
	|
	|-RVA: 0x2940780 Offset: 0x2940881 VA: 0x2940780
	|-MinimumQueue<ValueTuple<int, Vector4>>.MoveNext
	|
	|-RVA: 0x2940BC0 Offset: 0x2940CC1 VA: 0x2940BC0
	|-MinimumQueue<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293CB00 Offset: 0x293CC01 VA: 0x293CB00
	|-MinimumQueue<ValueTuple<int, bool>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293CFB0 Offset: 0x293D0B1 VA: 0x293CFB0
	|-MinimumQueue<ValueTuple<int, Bounds>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293D3D0 Offset: 0x293D4D1 VA: 0x293D3D0
	|-MinimumQueue<ValueTuple<int, byte>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293D860 Offset: 0x293D961 VA: 0x293D860
	|-MinimumQueue<ValueTuple<int, Color>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293DC90 Offset: 0x293DD91 VA: 0x293DC90
	|-MinimumQueue<ValueTuple<int, double>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293E0B0 Offset: 0x293E1B1 VA: 0x293E0B0
	|-MinimumQueue<ValueTuple<int, int>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293E4E0 Offset: 0x293E5E1 VA: 0x293E4E0
	|-MinimumQueue<ValueTuple<int, long>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293E940 Offset: 0x293EA41 VA: 0x293E940
	|-MinimumQueue<ValueTuple<int, object>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293EDD0 Offset: 0x293EED1 VA: 0x293EDD0
	|-MinimumQueue<ValueTuple<int, Quaternion>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293F260 Offset: 0x293F361 VA: 0x293F260
	|-MinimumQueue<ValueTuple<int, Rect>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293F680 Offset: 0x293F781 VA: 0x293F680
	|-MinimumQueue<ValueTuple<int, float>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293FAA0 Offset: 0x293FBA1 VA: 0x293FAA0
	|-MinimumQueue<ValueTuple<int, Unit>>.ThrowForEmptyQueue
	|
	|-RVA: 0x293FEE0 Offset: 0x293FFE1 VA: 0x293FEE0
	|-MinimumQueue<ValueTuple<int, Vector2>>.ThrowForEmptyQueue
	|
	|-RVA: 0x2940310 Offset: 0x2940411 VA: 0x2940310
	|-MinimumQueue<ValueTuple<int, Vector3>>.ThrowForEmptyQueue
	|
	|-RVA: 0x29407A0 Offset: 0x29408A1 VA: 0x29407A0
	|-MinimumQueue<ValueTuple<int, Vector4>>.ThrowForEmptyQueue
	|
	|-RVA: 0x2940BE0 Offset: 0x2940CE1 VA: 0x2940BE0
	|-MinimumQueue<object>.ThrowForEmptyQueue
	*/
}

