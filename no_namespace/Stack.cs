// Namespace: 
[Serializable]
private class Stack.StackEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1382
{
	// Fields
	private Stack _stack; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x1C04990 Offset: 0x1C04A91 VA: 0x1C04990
	internal void .ctor(Stack stack) { }

	// RVA: 0x1C049F0 Offset: 0x1C04AF1 VA: 0x1C049F0 Slot: 7
	public object Clone() { }

	// RVA: 0x1C04A00 Offset: 0x1C04B01 VA: 0x1C04A00 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x1C04B00 Offset: 0x1C04C01 VA: 0x1C04B00 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x1C04B90 Offset: 0x1C04C91 VA: 0x1C04B90 Slot: 10
	public virtual void Reset() { }
}

// Namespace: 
internal class Stack.StackDebugView // TypeDefIndex: 1383
{}

// Namespace: 
[Serializable]
public struct Stack.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 2443
{
	// Fields
	private readonly Stack<T> _stack; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Stack<T> stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB3810 Offset: 0x2EB3911 VA: 0x2EB3810
	|-Stack.Enumerator<Color>..ctor
	|
	|-RVA: 0x2EB68C0 Offset: 0x2EB69C1 VA: 0x2EB68C0
	|-Stack.Enumerator<int>..ctor
	|
	|-RVA: 0x2EB7280 Offset: 0x2EB7381 VA: 0x2EB7280
	|-Stack.Enumerator<Int32Enum>..ctor
	|
	|-RVA: 0x2EBAA10 Offset: 0x2EBAB11 VA: 0x2EBAA10
	|-Stack.Enumerator<object>..ctor
	|
	|-RVA: 0x2EBBA90 Offset: 0x2EBBB91 VA: 0x2EBBA90
	|-Stack.Enumerator<RandomSeed>..ctor
	|
	|-RVA: 0x2EBDBD0 Offset: 0x2EBDCD1 VA: 0x2EBDBD0
	|-Stack.Enumerator<float>..ctor
	|
	|-RVA: 0x2E04050 Offset: 0x2E04151 VA: 0x2E04050
	|-Stack.Enumerator<uint>..ctor
	|
	|-RVA: 0x2E091B0 Offset: 0x2E092B1 VA: 0x2E091B0
	|-Stack.Enumerator<DynamicMesh.State>..ctor
	|
	|-RVA: 0x2E0AD70 Offset: 0x2E0AE71 VA: 0x2E0AD70
	|-Stack.Enumerator<MapMind.Record>..ctor
	|
	|-RVA: 0x2E0C350 Offset: 0x2E0C451 VA: 0x2E0C350
	|-Stack.Enumerator<QualitySettingsStack.Settings>..ctor
	|
	|-RVA: 0x2E0D1F0 Offset: 0x2E0D2F1 VA: 0x2E0D1F0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x2E0E1A0 Offset: 0x2E0E2A1 VA: 0x2E0E1A0
	|-Stack.Enumerator<Stream.Info>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB3850 Offset: 0x2EB3951 VA: 0x2EB3850
	|-Stack.Enumerator<Color>.Dispose
	|
	|-RVA: 0x2EBAA50 Offset: 0x2EBAB51 VA: 0x2EBAA50
	|-Stack.Enumerator<GameObject>.Dispose
	|-Stack.Enumerator<MapInspector>.Dispose
	|-Stack.Enumerator<object>.Dispose
	|
	|-RVA: 0x2EB6900 Offset: 0x2EB6A01 VA: 0x2EB6900
	|-Stack.Enumerator<int>.Dispose
	|
	|-RVA: 0x2EB72C0 Offset: 0x2EB73C1 VA: 0x2EB72C0
	|-Stack.Enumerator<Int32Enum>.Dispose
	|-Stack.Enumerator<UnitInfo.Mode>.Dispose
	|
	|-RVA: 0x2EBBAD0 Offset: 0x2EBBBD1 VA: 0x2EBBAD0
	|-Stack.Enumerator<RandomSeed>.Dispose
	|
	|-RVA: 0x2EBDC10 Offset: 0x2EBDD11 VA: 0x2EBDC10
	|-Stack.Enumerator<float>.Dispose
	|
	|-RVA: 0x2E04090 Offset: 0x2E04191 VA: 0x2E04090
	|-Stack.Enumerator<uint>.Dispose
	|
	|-RVA: 0x2E091F0 Offset: 0x2E092F1 VA: 0x2E091F0
	|-Stack.Enumerator<DynamicMesh.State>.Dispose
	|
	|-RVA: 0x2E0ADC0 Offset: 0x2E0AEC1 VA: 0x2E0ADC0
	|-Stack.Enumerator<MapMind.Record>.Dispose
	|
	|-RVA: 0x2E0C390 Offset: 0x2E0C491 VA: 0x2E0C390
	|-Stack.Enumerator<QualitySettingsStack.Settings>.Dispose
	|
	|-RVA: 0x2E0D230 Offset: 0x2E0D331 VA: 0x2E0D230
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.Dispose
	|
	|-RVA: 0x2E0E1E0 Offset: 0x2E0E2E1 VA: 0x2E0E1E0
	|-Stack.Enumerator<Stream.Info>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB3860 Offset: 0x2EB3961 VA: 0x2EB3860
	|-Stack.Enumerator<Color>.MoveNext
	|
	|-RVA: 0x2EBAA60 Offset: 0x2EBAB61 VA: 0x2EBAA60
	|-Stack.Enumerator<GameObject>.MoveNext
	|-Stack.Enumerator<MapInspector>.MoveNext
	|-Stack.Enumerator<object>.MoveNext
	|
	|-RVA: 0x2EB6910 Offset: 0x2EB6A11 VA: 0x2EB6910
	|-Stack.Enumerator<int>.MoveNext
	|
	|-RVA: 0x2EB72D0 Offset: 0x2EB73D1 VA: 0x2EB72D0
	|-Stack.Enumerator<Int32Enum>.MoveNext
	|-Stack.Enumerator<UnitInfo.Mode>.MoveNext
	|
	|-RVA: 0x2EBBAE0 Offset: 0x2EBBBE1 VA: 0x2EBBAE0
	|-Stack.Enumerator<RandomSeed>.MoveNext
	|
	|-RVA: 0x2EBDC20 Offset: 0x2EBDD21 VA: 0x2EBDC20
	|-Stack.Enumerator<float>.MoveNext
	|
	|-RVA: 0x2E040A0 Offset: 0x2E041A1 VA: 0x2E040A0
	|-Stack.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x2E09200 Offset: 0x2E09301 VA: 0x2E09200
	|-Stack.Enumerator<DynamicMesh.State>.MoveNext
	|
	|-RVA: 0x2E0ADD0 Offset: 0x2E0AED1 VA: 0x2E0ADD0
	|-Stack.Enumerator<MapMind.Record>.MoveNext
	|
	|-RVA: 0x2E0C3A0 Offset: 0x2E0C4A1 VA: 0x2E0C3A0
	|-Stack.Enumerator<QualitySettingsStack.Settings>.MoveNext
	|
	|-RVA: 0x2E0D240 Offset: 0x2E0D341 VA: 0x2E0D240
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.MoveNext
	|
	|-RVA: 0x2E0E1F0 Offset: 0x2E0E2F1 VA: 0x2E0E1F0
	|-Stack.Enumerator<Stream.Info>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB3970 Offset: 0x2EB3A71 VA: 0x2EB3970
	|-Stack.Enumerator<Color>.get_Current
	|
	|-RVA: 0x2EBAB70 Offset: 0x2EBAC71 VA: 0x2EBAB70
	|-Stack.Enumerator<GameObject>.get_Current
	|-Stack.Enumerator<MapInspector>.get_Current
	|-Stack.Enumerator<object>.get_Current
	|
	|-RVA: 0x2EB6A10 Offset: 0x2EB6B11 VA: 0x2EB6A10
	|-Stack.Enumerator<int>.get_Current
	|
	|-RVA: 0x2EB73D0 Offset: 0x2EB74D1 VA: 0x2EB73D0
	|-Stack.Enumerator<Int32Enum>.get_Current
	|-Stack.Enumerator<UnitInfo.Mode>.get_Current
	|
	|-RVA: 0x2EBBBF0 Offset: 0x2EBBCF1 VA: 0x2EBBBF0
	|-Stack.Enumerator<RandomSeed>.get_Current
	|
	|-RVA: 0x2EBDD20 Offset: 0x2EBDE21 VA: 0x2EBDD20
	|-Stack.Enumerator<float>.get_Current
	|
	|-RVA: 0x2E041A0 Offset: 0x2E042A1 VA: 0x2E041A0
	|-Stack.Enumerator<uint>.get_Current
	|
	|-RVA: 0x2E09300 Offset: 0x2E09401 VA: 0x2E09300
	|-Stack.Enumerator<DynamicMesh.State>.get_Current
	|
	|-RVA: 0x2E0AEF0 Offset: 0x2E0AFF1 VA: 0x2E0AEF0
	|-Stack.Enumerator<MapMind.Record>.get_Current
	|
	|-RVA: 0x2E0C4C0 Offset: 0x2E0C5C1 VA: 0x2E0C4C0
	|-Stack.Enumerator<QualitySettingsStack.Settings>.get_Current
	|
	|-RVA: 0x2E0D360 Offset: 0x2E0D461 VA: 0x2E0D360
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.get_Current
	|
	|-RVA: 0x2E0E310 Offset: 0x2E0E411 VA: 0x2E0E310
	|-Stack.Enumerator<Stream.Info>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB39B0 Offset: 0x2EB3AB1 VA: 0x2EB39B0
	|-Stack.Enumerator<Color>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2EB6A50 Offset: 0x2EB6B51 VA: 0x2EB6A50
	|-Stack.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2EB7410 Offset: 0x2EB7511 VA: 0x2EB7410
	|-Stack.Enumerator<Int32Enum>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2EBABB0 Offset: 0x2EBACB1 VA: 0x2EBABB0
	|-Stack.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2EBBC30 Offset: 0x2EBBD31 VA: 0x2EBBC30
	|-Stack.Enumerator<RandomSeed>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2EBDD60 Offset: 0x2EBDE61 VA: 0x2EBDD60
	|-Stack.Enumerator<float>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2E041E0 Offset: 0x2E042E1 VA: 0x2E041E0
	|-Stack.Enumerator<uint>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2E09340 Offset: 0x2E09441 VA: 0x2E09340
	|-Stack.Enumerator<DynamicMesh.State>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2E0AF50 Offset: 0x2E0B051 VA: 0x2E0AF50
	|-Stack.Enumerator<MapMind.Record>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2E0C510 Offset: 0x2E0C611 VA: 0x2E0C510
	|-Stack.Enumerator<QualitySettingsStack.Settings>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2E0D3B0 Offset: 0x2E0D4B1 VA: 0x2E0D3B0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2E0E360 Offset: 0x2E0E461 VA: 0x2E0E360
	|-Stack.Enumerator<Stream.Info>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB3A20 Offset: 0x2EB3B21 VA: 0x2EB3A20
	|-Stack.Enumerator<Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB6AC0 Offset: 0x2EB6BC1 VA: 0x2EB6AC0
	|-Stack.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB7480 Offset: 0x2EB7581 VA: 0x2EB7480
	|-Stack.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBAC20 Offset: 0x2EBAD21 VA: 0x2EBAC20
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBBCA0 Offset: 0x2EBBDA1 VA: 0x2EBBCA0
	|-Stack.Enumerator<RandomSeed>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBDDD0 Offset: 0x2EBDED1 VA: 0x2EBDDD0
	|-Stack.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E04250 Offset: 0x2E04351 VA: 0x2E04250
	|-Stack.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E093B0 Offset: 0x2E094B1 VA: 0x2E093B0
	|-Stack.Enumerator<DynamicMesh.State>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0AFC0 Offset: 0x2E0B0C1 VA: 0x2E0AFC0
	|-Stack.Enumerator<MapMind.Record>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0C580 Offset: 0x2E0C681 VA: 0x2E0C580
	|-Stack.Enumerator<QualitySettingsStack.Settings>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0D420 Offset: 0x2E0D521 VA: 0x2E0D420
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0E3D0 Offset: 0x2E0E4D1 VA: 0x2E0E3D0
	|-Stack.Enumerator<Stream.Info>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB3AD0 Offset: 0x2EB3BD1 VA: 0x2EB3AD0
	|-Stack.Enumerator<Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB6B60 Offset: 0x2EB6C61 VA: 0x2EB6B60
	|-Stack.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB7520 Offset: 0x2EB7621 VA: 0x2EB7520
	|-Stack.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBAC80 Offset: 0x2EBAD81 VA: 0x2EBAC80
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBBD50 Offset: 0x2EBBE51 VA: 0x2EBBD50
	|-Stack.Enumerator<RandomSeed>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBDE70 Offset: 0x2EBDF71 VA: 0x2EBDE70
	|-Stack.Enumerator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E042F0 Offset: 0x2E043F1 VA: 0x2E042F0
	|-Stack.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E09450 Offset: 0x2E09551 VA: 0x2E09450
	|-Stack.Enumerator<DynamicMesh.State>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0B090 Offset: 0x2E0B191 VA: 0x2E0B090
	|-Stack.Enumerator<MapMind.Record>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0C640 Offset: 0x2E0C741 VA: 0x2E0C640
	|-Stack.Enumerator<QualitySettingsStack.Settings>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0D4E0 Offset: 0x2E0D5E1 VA: 0x2E0D4E0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0E480 Offset: 0x2E0E581 VA: 0x2E0E480
	|-Stack.Enumerator<Stream.Info>.System.Collections.IEnumerator.Reset
	*/
}

