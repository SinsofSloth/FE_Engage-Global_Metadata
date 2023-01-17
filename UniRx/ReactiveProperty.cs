// Namespace: UniRx
[Serializable]
public class ReactiveProperty<T> : IReactiveProperty<T>, IReadOnlyReactiveProperty<T>, IObservable<T>, IDisposable, IOptimizedObservable<T>, IObserverLinkedList<T> // TypeDefIndex: 6768
{
	// Fields
	private static readonly IEqualityComparer<T> defaultEqualityComparer; // 0x0
	[SerializeField] // RVA: 0x13DA0 Offset: 0x13EA1 VA: 0x13DA0
	private T value; // 0x0
	private ObserverNode<T> root; // 0x0
	private ObserverNode<T> last; // 0x0
	private bool isDisposed; // 0x0
	private static readonly Action<object> Callback; // 0x0
	private ReactivePropertyReusablePromise<T> commonPromise; // 0x0
	private Dictionary<CancellationToken, ReactivePropertyReusablePromise<T>> removablePromises; // 0x0

	// Properties
	protected virtual IEqualityComparer<T> EqualityComparer { get; }
	public T Value { get; set; }
	public bool HasValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual IEqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345D8D0 Offset: 0x345D9D1 VA: 0x345D8D0
	|-ReactiveProperty<AnimationCurve>.get_EqualityComparer
	|-ReactiveProperty<object>.get_EqualityComparer
	|-ReactiveProperty<string>.get_EqualityComparer
	|
	|-RVA: 0x34552F0 Offset: 0x34553F1 VA: 0x34552F0
	|-ReactiveProperty<bool>.get_EqualityComparer
	|
	|-RVA: 0x34565C0 Offset: 0x34566C1 VA: 0x34565C0
	|-ReactiveProperty<Bounds>.get_EqualityComparer
	|
	|-RVA: 0x3457A10 Offset: 0x3457B11 VA: 0x3457A10
	|-ReactiveProperty<byte>.get_EqualityComparer
	|
	|-RVA: 0x3458CD0 Offset: 0x3458DD1 VA: 0x3458CD0
	|-ReactiveProperty<Color>.get_EqualityComparer
	|
	|-RVA: 0x345A080 Offset: 0x345A181 VA: 0x345A080
	|-ReactiveProperty<double>.get_EqualityComparer
	|
	|-RVA: 0x345B350 Offset: 0x345B451 VA: 0x345B350
	|-ReactiveProperty<int>.get_EqualityComparer
	|
	|-RVA: 0x345C610 Offset: 0x345C711 VA: 0x345C610
	|-ReactiveProperty<long>.get_EqualityComparer
	|
	|-RVA: 0x345EBB0 Offset: 0x345ECB1 VA: 0x345EBB0
	|-ReactiveProperty<Quaternion>.get_EqualityComparer
	|
	|-RVA: 0x345FF60 Offset: 0x3460061 VA: 0x345FF60
	|-ReactiveProperty<Rect>.get_EqualityComparer
	|
	|-RVA: 0x3461310 Offset: 0x3461411 VA: 0x3461310
	|-ReactiveProperty<float>.get_EqualityComparer
	|
	|-RVA: 0x34625E0 Offset: 0x34626E1 VA: 0x34625E0
	|-ReactiveProperty<Vector2>.get_EqualityComparer
	|
	|-RVA: 0x34638C0 Offset: 0x34639C1 VA: 0x34638C0
	|-ReactiveProperty<Vector3>.get_EqualityComparer
	|
	|-RVA: 0x3464C20 Offset: 0x3464D21 VA: 0x3464C20
	|-ReactiveProperty<Vector4>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345D980 Offset: 0x345DA81 VA: 0x345D980
	|-ReactiveProperty<AnimationCurve>.get_Value
	|-ReactiveProperty<object>.get_Value
	|-ReactiveProperty<string>.get_Value
	|
	|-RVA: 0x34553A0 Offset: 0x34554A1 VA: 0x34553A0
	|-ReactiveProperty<bool>.get_Value
	|
	|-RVA: 0x3456670 Offset: 0x3456771 VA: 0x3456670
	|-ReactiveProperty<Bounds>.get_Value
	|
	|-RVA: 0x3457AC0 Offset: 0x3457BC1 VA: 0x3457AC0
	|-ReactiveProperty<byte>.get_Value
	|
	|-RVA: 0x3458D80 Offset: 0x3458E81 VA: 0x3458D80
	|-ReactiveProperty<Color>.get_Value
	|
	|-RVA: 0x345A130 Offset: 0x345A231 VA: 0x345A130
	|-ReactiveProperty<double>.get_Value
	|
	|-RVA: 0x345B400 Offset: 0x345B501 VA: 0x345B400
	|-ReactiveProperty<int>.get_Value
	|
	|-RVA: 0x345C6C0 Offset: 0x345C7C1 VA: 0x345C6C0
	|-ReactiveProperty<long>.get_Value
	|
	|-RVA: 0x345EC60 Offset: 0x345ED61 VA: 0x345EC60
	|-ReactiveProperty<Quaternion>.get_Value
	|
	|-RVA: 0x3460010 Offset: 0x3460111 VA: 0x3460010
	|-ReactiveProperty<Rect>.get_Value
	|
	|-RVA: 0x34613C0 Offset: 0x34614C1 VA: 0x34613C0
	|-ReactiveProperty<float>.get_Value
	|
	|-RVA: 0x3462690 Offset: 0x3462791 VA: 0x3462690
	|-ReactiveProperty<Vector2>.get_Value
	|
	|-RVA: 0x3463970 Offset: 0x3463A71 VA: 0x3463970
	|-ReactiveProperty<Vector3>.get_Value
	|
	|-RVA: 0x3464CD0 Offset: 0x3464DD1 VA: 0x3464CD0
	|-ReactiveProperty<Vector4>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345D990 Offset: 0x345DA91 VA: 0x345D990
	|-ReactiveProperty<AnimationCurve>.set_Value
	|-ReactiveProperty<object>.set_Value
	|-ReactiveProperty<string>.set_Value
	|
	|-RVA: 0x34553B0 Offset: 0x34554B1 VA: 0x34553B0
	|-ReactiveProperty<bool>.set_Value
	|
	|-RVA: 0x3456690 Offset: 0x3456791 VA: 0x3456690
	|-ReactiveProperty<Bounds>.set_Value
	|
	|-RVA: 0x3457AD0 Offset: 0x3457BD1 VA: 0x3457AD0
	|-ReactiveProperty<byte>.set_Value
	|
	|-RVA: 0x3458D90 Offset: 0x3458E91 VA: 0x3458D90
	|-ReactiveProperty<Color>.set_Value
	|
	|-RVA: 0x345A140 Offset: 0x345A241 VA: 0x345A140
	|-ReactiveProperty<double>.set_Value
	|
	|-RVA: 0x345B410 Offset: 0x345B511 VA: 0x345B410
	|-ReactiveProperty<int>.set_Value
	|
	|-RVA: 0x345C6D0 Offset: 0x345C7D1 VA: 0x345C6D0
	|-ReactiveProperty<long>.set_Value
	|
	|-RVA: 0x345EC70 Offset: 0x345ED71 VA: 0x345EC70
	|-ReactiveProperty<Quaternion>.set_Value
	|
	|-RVA: 0x3460020 Offset: 0x3460121 VA: 0x3460020
	|-ReactiveProperty<Rect>.set_Value
	|
	|-RVA: 0x34613D0 Offset: 0x34614D1 VA: 0x34613D0
	|-ReactiveProperty<float>.set_Value
	|
	|-RVA: 0x34626A0 Offset: 0x34627A1 VA: 0x34626A0
	|-ReactiveProperty<Vector2>.set_Value
	|
	|-RVA: 0x3463980 Offset: 0x3463A81 VA: 0x3463980
	|-ReactiveProperty<Vector3>.set_Value
	|
	|-RVA: 0x3464CE0 Offset: 0x3464DE1 VA: 0x3464CE0
	|-ReactiveProperty<Vector4>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345DAB0 Offset: 0x345DBB1 VA: 0x345DAB0
	|-ReactiveProperty<AnimationCurve>.get_HasValue
	|-ReactiveProperty<object>.get_HasValue
	|-ReactiveProperty<string>.get_HasValue
	|
	|-RVA: 0x34554D0 Offset: 0x34555D1 VA: 0x34554D0
	|-ReactiveProperty<bool>.get_HasValue
	|
	|-RVA: 0x3456820 Offset: 0x3456921 VA: 0x3456820
	|-ReactiveProperty<Bounds>.get_HasValue
	|
	|-RVA: 0x3457BF0 Offset: 0x3457CF1 VA: 0x3457BF0
	|-ReactiveProperty<byte>.get_HasValue
	|
	|-RVA: 0x3458F00 Offset: 0x3459001 VA: 0x3458F00
	|-ReactiveProperty<Color>.get_HasValue
	|
	|-RVA: 0x345A260 Offset: 0x345A361 VA: 0x345A260
	|-ReactiveProperty<double>.get_HasValue
	|
	|-RVA: 0x345B530 Offset: 0x345B631 VA: 0x345B530
	|-ReactiveProperty<int>.get_HasValue
	|
	|-RVA: 0x345C7F0 Offset: 0x345C8F1 VA: 0x345C7F0
	|-ReactiveProperty<long>.get_HasValue
	|
	|-RVA: 0x345EDE0 Offset: 0x345EEE1 VA: 0x345EDE0
	|-ReactiveProperty<Quaternion>.get_HasValue
	|
	|-RVA: 0x3460190 Offset: 0x3460291 VA: 0x3460190
	|-ReactiveProperty<Rect>.get_HasValue
	|
	|-RVA: 0x34614F0 Offset: 0x34615F1 VA: 0x34614F0
	|-ReactiveProperty<float>.get_HasValue
	|
	|-RVA: 0x34627D0 Offset: 0x34628D1 VA: 0x34627D0
	|-ReactiveProperty<Vector2>.get_HasValue
	|
	|-RVA: 0x3463AD0 Offset: 0x3463BD1 VA: 0x3463AD0
	|-ReactiveProperty<Vector3>.get_HasValue
	|
	|-RVA: 0x3464E50 Offset: 0x3464F51 VA: 0x3464E50
	|-ReactiveProperty<Vector4>.get_HasValue
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345DAC0 Offset: 0x345DBC1 VA: 0x345DAC0
	|-ReactiveProperty<AnimationCurve>..ctor
	|-ReactiveProperty<object>..ctor
	|-ReactiveProperty<string>..ctor
	|
	|-RVA: 0x34554E0 Offset: 0x34555E1 VA: 0x34554E0
	|-ReactiveProperty<bool>..ctor
	|
	|-RVA: 0x3456830 Offset: 0x3456931 VA: 0x3456830
	|-ReactiveProperty<Bounds>..ctor
	|
	|-RVA: 0x3457C00 Offset: 0x3457D01 VA: 0x3457C00
	|-ReactiveProperty<byte>..ctor
	|
	|-RVA: 0x3458F10 Offset: 0x3459011 VA: 0x3458F10
	|-ReactiveProperty<Color>..ctor
	|
	|-RVA: 0x345A270 Offset: 0x345A371 VA: 0x345A270
	|-ReactiveProperty<double>..ctor
	|
	|-RVA: 0x345B540 Offset: 0x345B641 VA: 0x345B540
	|-ReactiveProperty<int>..ctor
	|
	|-RVA: 0x345C800 Offset: 0x345C901 VA: 0x345C800
	|-ReactiveProperty<long>..ctor
	|
	|-RVA: 0x345EDF0 Offset: 0x345EEF1 VA: 0x345EDF0
	|-ReactiveProperty<Quaternion>..ctor
	|
	|-RVA: 0x34601A0 Offset: 0x34602A1 VA: 0x34601A0
	|-ReactiveProperty<Rect>..ctor
	|
	|-RVA: 0x3461500 Offset: 0x3461601 VA: 0x3461500
	|-ReactiveProperty<float>..ctor
	|
	|-RVA: 0x34627E0 Offset: 0x34628E1 VA: 0x34627E0
	|-ReactiveProperty<Vector2>..ctor
	|
	|-RVA: 0x3463AE0 Offset: 0x3463BE1 VA: 0x3463AE0
	|-ReactiveProperty<Vector3>..ctor
	|
	|-RVA: 0x3464E60 Offset: 0x3464F61 VA: 0x3464E60
	|-ReactiveProperty<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T initialValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345DAE0 Offset: 0x345DBE1 VA: 0x345DAE0
	|-ReactiveProperty<AnimationCurve>..ctor
	|-ReactiveProperty<object>..ctor
	|-ReactiveProperty<string>..ctor
	|
	|-RVA: 0x3455500 Offset: 0x3455601 VA: 0x3455500
	|-ReactiveProperty<bool>..ctor
	|
	|-RVA: 0x3456870 Offset: 0x3456971 VA: 0x3456870
	|-ReactiveProperty<Bounds>..ctor
	|
	|-RVA: 0x3457C20 Offset: 0x3457D21 VA: 0x3457C20
	|-ReactiveProperty<byte>..ctor
	|
	|-RVA: 0x3458F40 Offset: 0x3459041 VA: 0x3458F40
	|-ReactiveProperty<Color>..ctor
	|
	|-RVA: 0x345A290 Offset: 0x345A391 VA: 0x345A290
	|-ReactiveProperty<double>..ctor
	|
	|-RVA: 0x345B560 Offset: 0x345B661 VA: 0x345B560
	|-ReactiveProperty<int>..ctor
	|
	|-RVA: 0x345C820 Offset: 0x345C921 VA: 0x345C820
	|-ReactiveProperty<long>..ctor
	|
	|-RVA: 0x345EE20 Offset: 0x345EF21 VA: 0x345EE20
	|-ReactiveProperty<Quaternion>..ctor
	|
	|-RVA: 0x34601D0 Offset: 0x34602D1 VA: 0x34601D0
	|-ReactiveProperty<Rect>..ctor
	|
	|-RVA: 0x3461520 Offset: 0x3461621 VA: 0x3461520
	|-ReactiveProperty<float>..ctor
	|
	|-RVA: 0x3462800 Offset: 0x3462901 VA: 0x3462800
	|-ReactiveProperty<Vector2>..ctor
	|
	|-RVA: 0x3463B00 Offset: 0x3463C01 VA: 0x3463B00
	|-ReactiveProperty<Vector3>..ctor
	|
	|-RVA: 0x3464E90 Offset: 0x3464F91 VA: 0x3464E90
	|-ReactiveProperty<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	private void RaiseOnNext(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3455540 Offset: 0x3455641 VA: 0x3455540
	|-ReactiveProperty<bool>.RaiseOnNext
	|
	|-RVA: 0x34568E0 Offset: 0x34569E1 VA: 0x34568E0
	|-ReactiveProperty<Bounds>.RaiseOnNext
	|
	|-RVA: 0x3457C60 Offset: 0x3457D61 VA: 0x3457C60
	|-ReactiveProperty<byte>.RaiseOnNext
	|
	|-RVA: 0x3458FB0 Offset: 0x34590B1 VA: 0x3458FB0
	|-ReactiveProperty<Color>.RaiseOnNext
	|
	|-RVA: 0x345A2E0 Offset: 0x345A3E1 VA: 0x345A2E0
	|-ReactiveProperty<double>.RaiseOnNext
	|
	|-RVA: 0x345B5A0 Offset: 0x345B6A1 VA: 0x345B5A0
	|-ReactiveProperty<int>.RaiseOnNext
	|
	|-RVA: 0x345C860 Offset: 0x345C961 VA: 0x345C860
	|-ReactiveProperty<long>.RaiseOnNext
	|
	|-RVA: 0x345DB20 Offset: 0x345DC21 VA: 0x345DB20
	|-ReactiveProperty<object>.RaiseOnNext
	|
	|-RVA: 0x345EE90 Offset: 0x345EF91 VA: 0x345EE90
	|-ReactiveProperty<Quaternion>.RaiseOnNext
	|
	|-RVA: 0x3460240 Offset: 0x3460341 VA: 0x3460240
	|-ReactiveProperty<Rect>.RaiseOnNext
	|
	|-RVA: 0x3461570 Offset: 0x3461671 VA: 0x3461570
	|-ReactiveProperty<float>.RaiseOnNext
	|
	|-RVA: 0x3462850 Offset: 0x3462951 VA: 0x3462850
	|-ReactiveProperty<Vector2>.RaiseOnNext
	|
	|-RVA: 0x3463B60 Offset: 0x3463C61 VA: 0x3463B60
	|-ReactiveProperty<Vector3>.RaiseOnNext
	|
	|-RVA: 0x3464F00 Offset: 0x3465001 VA: 0x3464F00
	|-ReactiveProperty<Vector4>.RaiseOnNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual void SetValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345DBF0 Offset: 0x345DCF1 VA: 0x345DBF0
	|-ReactiveProperty<AnimationCurve>.SetValue
	|-ReactiveProperty<object>.SetValue
	|-ReactiveProperty<string>.SetValue
	|
	|-RVA: 0x3455610 Offset: 0x3455711 VA: 0x3455610
	|-ReactiveProperty<bool>.SetValue
	|
	|-RVA: 0x34569F0 Offset: 0x3456AF1 VA: 0x34569F0
	|-ReactiveProperty<Bounds>.SetValue
	|
	|-RVA: 0x3457D30 Offset: 0x3457E31 VA: 0x3457D30
	|-ReactiveProperty<byte>.SetValue
	|
	|-RVA: 0x3459090 Offset: 0x3459191 VA: 0x3459090
	|-ReactiveProperty<Color>.SetValue
	|
	|-RVA: 0x345A3B0 Offset: 0x345A4B1 VA: 0x345A3B0
	|-ReactiveProperty<double>.SetValue
	|
	|-RVA: 0x345B670 Offset: 0x345B771 VA: 0x345B670
	|-ReactiveProperty<int>.SetValue
	|
	|-RVA: 0x345C930 Offset: 0x345CA31 VA: 0x345C930
	|-ReactiveProperty<long>.SetValue
	|
	|-RVA: 0x345EF70 Offset: 0x345F071 VA: 0x345EF70
	|-ReactiveProperty<Quaternion>.SetValue
	|
	|-RVA: 0x3460320 Offset: 0x3460421 VA: 0x3460320
	|-ReactiveProperty<Rect>.SetValue
	|
	|-RVA: 0x3461640 Offset: 0x3461741 VA: 0x3461640
	|-ReactiveProperty<float>.SetValue
	|
	|-RVA: 0x3462920 Offset: 0x3462A21 VA: 0x3462920
	|-ReactiveProperty<Vector2>.SetValue
	|
	|-RVA: 0x3463C40 Offset: 0x3463D41 VA: 0x3463C40
	|-ReactiveProperty<Vector3>.SetValue
	|
	|-RVA: 0x3464FE0 Offset: 0x34650E1 VA: 0x3464FE0
	|-ReactiveProperty<Vector4>.SetValue
	*/

	// RVA: -1 Offset: -1
	public void SetValueAndForceNotify(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3455620 Offset: 0x3455721 VA: 0x3455620
	|-ReactiveProperty<bool>.SetValueAndForceNotify
	|
	|-RVA: 0x3456A10 Offset: 0x3456B11 VA: 0x3456A10
	|-ReactiveProperty<Bounds>.SetValueAndForceNotify
	|
	|-RVA: 0x3457D40 Offset: 0x3457E41 VA: 0x3457D40
	|-ReactiveProperty<byte>.SetValueAndForceNotify
	|
	|-RVA: 0x34590B0 Offset: 0x34591B1 VA: 0x34590B0
	|-ReactiveProperty<Color>.SetValueAndForceNotify
	|
	|-RVA: 0x345A3C0 Offset: 0x345A4C1 VA: 0x345A3C0
	|-ReactiveProperty<double>.SetValueAndForceNotify
	|
	|-RVA: 0x345B680 Offset: 0x345B781 VA: 0x345B680
	|-ReactiveProperty<int>.SetValueAndForceNotify
	|
	|-RVA: 0x345C940 Offset: 0x345CA41 VA: 0x345C940
	|-ReactiveProperty<long>.SetValueAndForceNotify
	|
	|-RVA: 0x345DC00 Offset: 0x345DD01 VA: 0x345DC00
	|-ReactiveProperty<object>.SetValueAndForceNotify
	|
	|-RVA: 0x345EF90 Offset: 0x345F091 VA: 0x345EF90
	|-ReactiveProperty<Quaternion>.SetValueAndForceNotify
	|
	|-RVA: 0x3460340 Offset: 0x3460441 VA: 0x3460340
	|-ReactiveProperty<Rect>.SetValueAndForceNotify
	|
	|-RVA: 0x3461650 Offset: 0x3461751 VA: 0x3461650
	|-ReactiveProperty<float>.SetValueAndForceNotify
	|
	|-RVA: 0x3462930 Offset: 0x3462A31 VA: 0x3462930
	|-ReactiveProperty<Vector2>.SetValueAndForceNotify
	|
	|-RVA: 0x3463C50 Offset: 0x3463D51 VA: 0x3463C50
	|-ReactiveProperty<Vector3>.SetValueAndForceNotify
	|
	|-RVA: 0x3465000 Offset: 0x3465101 VA: 0x3465000
	|-ReactiveProperty<Vector4>.SetValueAndForceNotify
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345DC70 Offset: 0x345DD71 VA: 0x345DC70
	|-ReactiveProperty<AnimationCurve>.Subscribe
	|-ReactiveProperty<object>.Subscribe
	|-ReactiveProperty<string>.Subscribe
	|
	|-RVA: 0x34556A0 Offset: 0x34557A1 VA: 0x34556A0
	|-ReactiveProperty<bool>.Subscribe
	|
	|-RVA: 0x3456AA0 Offset: 0x3456BA1 VA: 0x3456AA0
	|-ReactiveProperty<Bounds>.Subscribe
	|
	|-RVA: 0x3457DB0 Offset: 0x3457EB1 VA: 0x3457DB0
	|-ReactiveProperty<byte>.Subscribe
	|
	|-RVA: 0x3459130 Offset: 0x3459231 VA: 0x3459130
	|-ReactiveProperty<Color>.Subscribe
	|
	|-RVA: 0x345A430 Offset: 0x345A531 VA: 0x345A430
	|-ReactiveProperty<double>.Subscribe
	|
	|-RVA: 0x345B6F0 Offset: 0x345B7F1 VA: 0x345B6F0
	|-ReactiveProperty<int>.Subscribe
	|
	|-RVA: 0x345C9B0 Offset: 0x345CAB1 VA: 0x345C9B0
	|-ReactiveProperty<long>.Subscribe
	|
	|-RVA: 0x345F010 Offset: 0x345F111 VA: 0x345F010
	|-ReactiveProperty<Quaternion>.Subscribe
	|
	|-RVA: 0x34603C0 Offset: 0x34604C1 VA: 0x34603C0
	|-ReactiveProperty<Rect>.Subscribe
	|
	|-RVA: 0x34616C0 Offset: 0x34617C1 VA: 0x34616C0
	|-ReactiveProperty<float>.Subscribe
	|
	|-RVA: 0x34629A0 Offset: 0x3462AA1 VA: 0x34629A0
	|-ReactiveProperty<Vector2>.Subscribe
	|
	|-RVA: 0x3463CD0 Offset: 0x3463DD1 VA: 0x3463CD0
	|-ReactiveProperty<Vector3>.Subscribe
	|
	|-RVA: 0x3465080 Offset: 0x3465181 VA: 0x3465080
	|-ReactiveProperty<Vector4>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void UniRx.IObserverLinkedList<T>.UnsubscribeNode(ObserverNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345DEB0 Offset: 0x345DFB1 VA: 0x345DEB0
	|-ReactiveProperty<AnimationCurve>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|-ReactiveProperty<object>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|-ReactiveProperty<string>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x34558E0 Offset: 0x34559E1 VA: 0x34558E0
	|-ReactiveProperty<bool>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x3456D10 Offset: 0x3456E11 VA: 0x3456D10
	|-ReactiveProperty<Bounds>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x3457FF0 Offset: 0x34580F1 VA: 0x3457FF0
	|-ReactiveProperty<byte>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x3459380 Offset: 0x3459481 VA: 0x3459380
	|-ReactiveProperty<Color>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x345A670 Offset: 0x345A771 VA: 0x345A670
	|-ReactiveProperty<double>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x345B930 Offset: 0x345BA31 VA: 0x345B930
	|-ReactiveProperty<int>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x345CBF0 Offset: 0x345CCF1 VA: 0x345CBF0
	|-ReactiveProperty<long>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x345F260 Offset: 0x345F361 VA: 0x345F260
	|-ReactiveProperty<Quaternion>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x3460610 Offset: 0x3460711 VA: 0x3460610
	|-ReactiveProperty<Rect>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x3461900 Offset: 0x3461A01 VA: 0x3461900
	|-ReactiveProperty<float>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x3462BE0 Offset: 0x3462CE1 VA: 0x3462BE0
	|-ReactiveProperty<Vector2>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x3463F20 Offset: 0x3464021 VA: 0x3463F20
	|-ReactiveProperty<Vector3>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x34652D0 Offset: 0x34653D1 VA: 0x34652D0
	|-ReactiveProperty<Vector4>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345E040 Offset: 0x345E141 VA: 0x345E040
	|-ReactiveProperty<AnimationCurve>.Dispose
	|-ReactiveProperty<object>.Dispose
	|-ReactiveProperty<string>.Dispose
	|
	|-RVA: 0x3455A70 Offset: 0x3455B71 VA: 0x3455A70
	|-ReactiveProperty<bool>.Dispose
	|
	|-RVA: 0x3456EA0 Offset: 0x3456FA1 VA: 0x3456EA0
	|-ReactiveProperty<Bounds>.Dispose
	|
	|-RVA: 0x3458180 Offset: 0x3458281 VA: 0x3458180
	|-ReactiveProperty<byte>.Dispose
	|
	|-RVA: 0x3459510 Offset: 0x3459611 VA: 0x3459510
	|-ReactiveProperty<Color>.Dispose
	|
	|-RVA: 0x345A800 Offset: 0x345A901 VA: 0x345A800
	|-ReactiveProperty<double>.Dispose
	|
	|-RVA: 0x345BAC0 Offset: 0x345BBC1 VA: 0x345BAC0
	|-ReactiveProperty<int>.Dispose
	|
	|-RVA: 0x345CD80 Offset: 0x345CE81 VA: 0x345CD80
	|-ReactiveProperty<long>.Dispose
	|
	|-RVA: 0x345F3F0 Offset: 0x345F4F1 VA: 0x345F3F0
	|-ReactiveProperty<Quaternion>.Dispose
	|
	|-RVA: 0x34607A0 Offset: 0x34608A1 VA: 0x34607A0
	|-ReactiveProperty<Rect>.Dispose
	|
	|-RVA: 0x3461A90 Offset: 0x3461B91 VA: 0x3461A90
	|-ReactiveProperty<float>.Dispose
	|
	|-RVA: 0x3462D70 Offset: 0x3462E71 VA: 0x3462D70
	|-ReactiveProperty<Vector2>.Dispose
	|
	|-RVA: 0x34640B0 Offset: 0x34641B1 VA: 0x34640B0
	|-ReactiveProperty<Vector3>.Dispose
	|
	|-RVA: 0x3465460 Offset: 0x3465561 VA: 0x3465460
	|-ReactiveProperty<Vector4>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345E0D0 Offset: 0x345E1D1 VA: 0x345E0D0
	|-ReactiveProperty<AnimationCurve>.Dispose
	|-ReactiveProperty<object>.Dispose
	|-ReactiveProperty<string>.Dispose
	|
	|-RVA: 0x3455B00 Offset: 0x3455C01 VA: 0x3455B00
	|-ReactiveProperty<bool>.Dispose
	|
	|-RVA: 0x3456F30 Offset: 0x3457031 VA: 0x3456F30
	|-ReactiveProperty<Bounds>.Dispose
	|
	|-RVA: 0x3458210 Offset: 0x3458311 VA: 0x3458210
	|-ReactiveProperty<byte>.Dispose
	|
	|-RVA: 0x34595A0 Offset: 0x34596A1 VA: 0x34595A0
	|-ReactiveProperty<Color>.Dispose
	|
	|-RVA: 0x345A890 Offset: 0x345A991 VA: 0x345A890
	|-ReactiveProperty<double>.Dispose
	|
	|-RVA: 0x345BB50 Offset: 0x345BC51 VA: 0x345BB50
	|-ReactiveProperty<int>.Dispose
	|
	|-RVA: 0x345CE10 Offset: 0x345CF11 VA: 0x345CE10
	|-ReactiveProperty<long>.Dispose
	|
	|-RVA: 0x345F480 Offset: 0x345F581 VA: 0x345F480
	|-ReactiveProperty<Quaternion>.Dispose
	|
	|-RVA: 0x3460830 Offset: 0x3460931 VA: 0x3460830
	|-ReactiveProperty<Rect>.Dispose
	|
	|-RVA: 0x3461B20 Offset: 0x3461C21 VA: 0x3461B20
	|-ReactiveProperty<float>.Dispose
	|
	|-RVA: 0x3462E00 Offset: 0x3462F01 VA: 0x3462E00
	|-ReactiveProperty<Vector2>.Dispose
	|
	|-RVA: 0x3464140 Offset: 0x3464241 VA: 0x3464140
	|-ReactiveProperty<Vector3>.Dispose
	|
	|-RVA: 0x34654F0 Offset: 0x34655F1 VA: 0x34654F0
	|-ReactiveProperty<Vector4>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345E380 Offset: 0x345E481 VA: 0x345E380
	|-ReactiveProperty<AnimationCurve>.ToString
	|-ReactiveProperty<object>.ToString
	|-ReactiveProperty<string>.ToString
	|
	|-RVA: 0x3455DB0 Offset: 0x3455EB1 VA: 0x3455DB0
	|-ReactiveProperty<bool>.ToString
	|
	|-RVA: 0x34571E0 Offset: 0x34572E1 VA: 0x34571E0
	|-ReactiveProperty<Bounds>.ToString
	|
	|-RVA: 0x34584C0 Offset: 0x34585C1 VA: 0x34584C0
	|-ReactiveProperty<byte>.ToString
	|
	|-RVA: 0x3459850 Offset: 0x3459951 VA: 0x3459850
	|-ReactiveProperty<Color>.ToString
	|
	|-RVA: 0x345AB40 Offset: 0x345AC41 VA: 0x345AB40
	|-ReactiveProperty<double>.ToString
	|
	|-RVA: 0x345BE00 Offset: 0x345BF01 VA: 0x345BE00
	|-ReactiveProperty<int>.ToString
	|
	|-RVA: 0x345D0C0 Offset: 0x345D1C1 VA: 0x345D0C0
	|-ReactiveProperty<long>.ToString
	|
	|-RVA: 0x345F730 Offset: 0x345F831 VA: 0x345F730
	|-ReactiveProperty<Quaternion>.ToString
	|
	|-RVA: 0x3460AE0 Offset: 0x3460BE1 VA: 0x3460AE0
	|-ReactiveProperty<Rect>.ToString
	|
	|-RVA: 0x3461DD0 Offset: 0x3461ED1 VA: 0x3461DD0
	|-ReactiveProperty<float>.ToString
	|
	|-RVA: 0x34630B0 Offset: 0x34631B1 VA: 0x34630B0
	|-ReactiveProperty<Vector2>.ToString
	|
	|-RVA: 0x34643F0 Offset: 0x34644F1 VA: 0x34643F0
	|-ReactiveProperty<Vector3>.ToString
	|
	|-RVA: 0x34657A0 Offset: 0x34658A1 VA: 0x34657A0
	|-ReactiveProperty<Vector4>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool IsRequiredSubscribeOnCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345E3F0 Offset: 0x345E4F1 VA: 0x345E3F0
	|-ReactiveProperty<AnimationCurve>.IsRequiredSubscribeOnCurrentThread
	|-ReactiveProperty<object>.IsRequiredSubscribeOnCurrentThread
	|-ReactiveProperty<string>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3455E00 Offset: 0x3455F01 VA: 0x3455E00
	|-ReactiveProperty<bool>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3457230 Offset: 0x3457331 VA: 0x3457230
	|-ReactiveProperty<Bounds>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3458510 Offset: 0x3458611 VA: 0x3458510
	|-ReactiveProperty<byte>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x34598A0 Offset: 0x34599A1 VA: 0x34598A0
	|-ReactiveProperty<Color>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x345AB90 Offset: 0x345AC91 VA: 0x345AB90
	|-ReactiveProperty<double>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x345BE50 Offset: 0x345BF51 VA: 0x345BE50
	|-ReactiveProperty<int>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x345D110 Offset: 0x345D211 VA: 0x345D110
	|-ReactiveProperty<long>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x345F780 Offset: 0x345F881 VA: 0x345F780
	|-ReactiveProperty<Quaternion>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3460B30 Offset: 0x3460C31 VA: 0x3460B30
	|-ReactiveProperty<Rect>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3461E20 Offset: 0x3461F21 VA: 0x3461E20
	|-ReactiveProperty<float>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3463100 Offset: 0x3463201 VA: 0x3463100
	|-ReactiveProperty<Vector2>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3464440 Offset: 0x3464541 VA: 0x3464440
	|-ReactiveProperty<Vector3>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x34657F0 Offset: 0x34658F1 VA: 0x34657F0
	|-ReactiveProperty<Vector4>.IsRequiredSubscribeOnCurrentThread
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public UniTask<T> WaitUntilValueChangedAsync(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345E400 Offset: 0x345E501 VA: 0x345E400
	|-ReactiveProperty<AnimationCurve>.WaitUntilValueChangedAsync
	|-ReactiveProperty<object>.WaitUntilValueChangedAsync
	|-ReactiveProperty<string>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x3455E10 Offset: 0x3455F11 VA: 0x3455E10
	|-ReactiveProperty<bool>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x3457240 Offset: 0x3457341 VA: 0x3457240
	|-ReactiveProperty<Bounds>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x3458520 Offset: 0x3458621 VA: 0x3458520
	|-ReactiveProperty<byte>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x34598B0 Offset: 0x34599B1 VA: 0x34598B0
	|-ReactiveProperty<Color>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x345ABA0 Offset: 0x345ACA1 VA: 0x345ABA0
	|-ReactiveProperty<double>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x345BE60 Offset: 0x345BF61 VA: 0x345BE60
	|-ReactiveProperty<int>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x345D120 Offset: 0x345D221 VA: 0x345D120
	|-ReactiveProperty<long>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x345F790 Offset: 0x345F891 VA: 0x345F790
	|-ReactiveProperty<Quaternion>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x3460B40 Offset: 0x3460C41 VA: 0x3460B40
	|-ReactiveProperty<Rect>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x3461E30 Offset: 0x3461F31 VA: 0x3461E30
	|-ReactiveProperty<float>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x3463110 Offset: 0x3463211 VA: 0x3463110
	|-ReactiveProperty<Vector2>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x3464450 Offset: 0x3464551 VA: 0x3464450
	|-ReactiveProperty<Vector3>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x3465800 Offset: 0x3465901 VA: 0x3465800
	|-ReactiveProperty<Vector4>.WaitUntilValueChangedAsync
	*/

	// RVA: -1 Offset: -1
	private static void CancelCallback(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3456190 Offset: 0x3456291 VA: 0x3456190
	|-ReactiveProperty<bool>.CancelCallback
	|
	|-RVA: 0x34575E0 Offset: 0x34576E1 VA: 0x34575E0
	|-ReactiveProperty<Bounds>.CancelCallback
	|
	|-RVA: 0x34588A0 Offset: 0x34589A1 VA: 0x34588A0
	|-ReactiveProperty<byte>.CancelCallback
	|
	|-RVA: 0x3459C50 Offset: 0x3459D51 VA: 0x3459C50
	|-ReactiveProperty<Color>.CancelCallback
	|
	|-RVA: 0x345AF20 Offset: 0x345B021 VA: 0x345AF20
	|-ReactiveProperty<double>.CancelCallback
	|
	|-RVA: 0x345C1E0 Offset: 0x345C2E1 VA: 0x345C1E0
	|-ReactiveProperty<int>.CancelCallback
	|
	|-RVA: 0x345D4A0 Offset: 0x345D5A1 VA: 0x345D4A0
	|-ReactiveProperty<long>.CancelCallback
	|
	|-RVA: 0x345E780 Offset: 0x345E881 VA: 0x345E780
	|-ReactiveProperty<object>.CancelCallback
	|
	|-RVA: 0x345FB30 Offset: 0x345FC31 VA: 0x345FB30
	|-ReactiveProperty<Quaternion>.CancelCallback
	|
	|-RVA: 0x3460EE0 Offset: 0x3460FE1 VA: 0x3460EE0
	|-ReactiveProperty<Rect>.CancelCallback
	|
	|-RVA: 0x34621B0 Offset: 0x34622B1 VA: 0x34621B0
	|-ReactiveProperty<float>.CancelCallback
	|
	|-RVA: 0x3463490 Offset: 0x3463591 VA: 0x3463490
	|-ReactiveProperty<Vector2>.CancelCallback
	|
	|-RVA: 0x34647F0 Offset: 0x34648F1 VA: 0x34647F0
	|-ReactiveProperty<Vector3>.CancelCallback
	|
	|-RVA: 0x3465BA0 Offset: 0x3465CA1 VA: 0x3465BA0
	|-ReactiveProperty<Vector4>.CancelCallback
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3456420 Offset: 0x3456521 VA: 0x3456420
	|-ReactiveProperty<bool>..cctor
	|
	|-RVA: 0x3457870 Offset: 0x3457971 VA: 0x3457870
	|-ReactiveProperty<Bounds>..cctor
	|
	|-RVA: 0x3458B30 Offset: 0x3458C31 VA: 0x3458B30
	|-ReactiveProperty<byte>..cctor
	|
	|-RVA: 0x3459EE0 Offset: 0x3459FE1 VA: 0x3459EE0
	|-ReactiveProperty<Color>..cctor
	|
	|-RVA: 0x345B1B0 Offset: 0x345B2B1 VA: 0x345B1B0
	|-ReactiveProperty<double>..cctor
	|
	|-RVA: 0x345C470 Offset: 0x345C571 VA: 0x345C470
	|-ReactiveProperty<int>..cctor
	|
	|-RVA: 0x345D730 Offset: 0x345D831 VA: 0x345D730
	|-ReactiveProperty<long>..cctor
	|
	|-RVA: 0x345EA10 Offset: 0x345EB11 VA: 0x345EA10
	|-ReactiveProperty<object>..cctor
	|
	|-RVA: 0x345FDC0 Offset: 0x345FEC1 VA: 0x345FDC0
	|-ReactiveProperty<Quaternion>..cctor
	|
	|-RVA: 0x3461170 Offset: 0x3461271 VA: 0x3461170
	|-ReactiveProperty<Rect>..cctor
	|
	|-RVA: 0x3462440 Offset: 0x3462541 VA: 0x3462440
	|-ReactiveProperty<float>..cctor
	|
	|-RVA: 0x3463720 Offset: 0x3463821 VA: 0x3463720
	|-ReactiveProperty<Vector2>..cctor
	|
	|-RVA: 0x3464A80 Offset: 0x3464B81 VA: 0x3464A80
	|-ReactiveProperty<Vector3>..cctor
	|
	|-RVA: 0x3465E30 Offset: 0x3465F31 VA: 0x3465E30
	|-ReactiveProperty<Vector4>..cctor
	*/
}

