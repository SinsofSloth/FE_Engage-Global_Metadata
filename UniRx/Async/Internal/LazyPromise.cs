// Namespace: UniRx.Async.Internal
internal sealed class LazyPromise<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5213
{
	// Fields
	private Func<UniTask<T>> factory; // 0x0
	private UniTask<T> value; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<UniTask<T>> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289F8B0 Offset: 0x289F9B1 VA: 0x289F8B0
	|-LazyPromise<UniTask<object>>..ctor
	|
	|-RVA: 0x289FB30 Offset: 0x289FC31 VA: 0x289FB30
	|-LazyPromise<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x289FDE0 Offset: 0x289FEE1 VA: 0x289FDE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x28A00A0 Offset: 0x28A01A1 VA: 0x28A00A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x28A0380 Offset: 0x28A0481 VA: 0x28A0380
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x28A0670 Offset: 0x28A0771 VA: 0x28A0670
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x28A08C0 Offset: 0x28A09C1 VA: 0x28A08C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x28A0B10 Offset: 0x28A0C11 VA: 0x28A0B10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x28A0E00 Offset: 0x28A0F01 VA: 0x28A0E00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x28A1050 Offset: 0x28A1151 VA: 0x28A1050
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x28A1330 Offset: 0x28A1431 VA: 0x28A1330
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x28A1620 Offset: 0x28A1721 VA: 0x28A1620
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x28A18D0 Offset: 0x28A19D1 VA: 0x28A18D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x28A1BC0 Offset: 0x28A1CC1 VA: 0x28A1BC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x28A1EB0 Offset: 0x28A1FB1 VA: 0x28A1EB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x28A2190 Offset: 0x28A2291 VA: 0x28A2190
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x28A2470 Offset: 0x28A2571 VA: 0x28A2470
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x28A2720 Offset: 0x28A2821 VA: 0x28A2720
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x28A2A10 Offset: 0x28A2B11 VA: 0x28A2A10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x28A2C60 Offset: 0x28A2D61 VA: 0x28A2C60
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x28A2F30 Offset: 0x28A3031 VA: 0x28A2F30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x28A31F0 Offset: 0x28A32F1 VA: 0x28A31F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x28A34D0 Offset: 0x28A35D1 VA: 0x28A34D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x28A37C0 Offset: 0x28A38C1 VA: 0x28A37C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x28A3AB0 Offset: 0x28A3BB1 VA: 0x28A3AB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x28A3DB0 Offset: 0x28A3EB1 VA: 0x28A3DB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x28A40D0 Offset: 0x28A41D1 VA: 0x28A40D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x28A4410 Offset: 0x28A4511 VA: 0x28A4410
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x28A4750 Offset: 0x28A4851 VA: 0x28A4750
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x28A4AA0 Offset: 0x28A4BA1 VA: 0x28A4AA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x28A4CF0 Offset: 0x28A4DF1 VA: 0x28A4CF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x28A4F40 Offset: 0x28A5041 VA: 0x28A4F40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x28A5220 Offset: 0x28A5321 VA: 0x28A5220
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x28A5470 Offset: 0x28A5571 VA: 0x28A5470
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x28A5730 Offset: 0x28A5831 VA: 0x28A5730
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x28A5A10 Offset: 0x28A5B11 VA: 0x28A5A10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x28A5CC0 Offset: 0x28A5DC1 VA: 0x28A5CC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x28A5FA0 Offset: 0x28A60A1 VA: 0x28A5FA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x28A6280 Offset: 0x28A6381 VA: 0x28A6280
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x28A6540 Offset: 0x28A6641 VA: 0x28A6540
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x28A6800 Offset: 0x28A6901 VA: 0x28A6800
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x28A6AB0 Offset: 0x28A6BB1 VA: 0x28A6AB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x28A6D90 Offset: 0x28A6E91 VA: 0x28A6D90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x28A6FE0 Offset: 0x28A70E1 VA: 0x28A6FE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x28A7290 Offset: 0x28A7391 VA: 0x28A7290
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x28A7560 Offset: 0x28A7661 VA: 0x28A7560
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x28A7820 Offset: 0x28A7921 VA: 0x28A7820
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x28A7B00 Offset: 0x28A7C01 VA: 0x28A7B00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x28A7DE0 Offset: 0x28A7EE1 VA: 0x28A7DE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x28A8110 Offset: 0x28A8211 VA: 0x28A8110
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x28A8400 Offset: 0x28A8501 VA: 0x28A8400
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x28A8750 Offset: 0x28A8851 VA: 0x28A8750
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x28A8A50 Offset: 0x28A8B51 VA: 0x28A8A50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x28A8DC0 Offset: 0x28A8EC1 VA: 0x28A8DC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x28A90F0 Offset: 0x28A91F1 VA: 0x28A90F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x28A9490 Offset: 0x28A9591 VA: 0x28A9490
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x28A97C0 Offset: 0x28A98C1 VA: 0x28A97C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x28A9AD0 Offset: 0x28A9BD1 VA: 0x28A9AD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x28A9E20 Offset: 0x28A9F21 VA: 0x28A9E20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x28AA070 Offset: 0x28AA171 VA: 0x28AA070
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x28AA2C0 Offset: 0x28AA3C1 VA: 0x28AA2C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x28AA5A0 Offset: 0x28AA6A1 VA: 0x28AA5A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x28AA7F0 Offset: 0x28AA8F1 VA: 0x28AA7F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x28AAAC0 Offset: 0x28AABC1 VA: 0x28AAAC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x28AAD80 Offset: 0x28AAE81 VA: 0x28AAD80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x28AB000 Offset: 0x28AB101 VA: 0x28AB000
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x28AB2C0 Offset: 0x28AB3C1 VA: 0x28AB2C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2AC1DD0 Offset: 0x2AC1ED1 VA: 0x2AC1DD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x2AC20A0 Offset: 0x2AC21A1 VA: 0x2AC20A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x2AC2370 Offset: 0x2AC2471 VA: 0x2AC2370
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x2AC25F0 Offset: 0x2AC26F1 VA: 0x2AC25F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x2AC28C0 Offset: 0x2AC29C1 VA: 0x2AC28C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x2AC2B10 Offset: 0x2AC2C11 VA: 0x2AC2B10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x2AC2DC0 Offset: 0x2AC2EC1 VA: 0x2AC2DC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x2AC3070 Offset: 0x2AC3171 VA: 0x2AC3070
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x2AC3340 Offset: 0x2AC3441 VA: 0x2AC3340
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x2AC3610 Offset: 0x2AC3711 VA: 0x2AC3610
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x2AC38D0 Offset: 0x2AC39D1 VA: 0x2AC38D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AC3BD0 Offset: 0x2AC3CD1 VA: 0x2AC3BD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x2AC3EB0 Offset: 0x2AC3FB1 VA: 0x2AC3EB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AC41F0 Offset: 0x2AC42F1 VA: 0x2AC41F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2AC44E0 Offset: 0x2AC45E1 VA: 0x2AC44E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AC4830 Offset: 0x2AC4931 VA: 0x2AC4830
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2AC4B30 Offset: 0x2AC4C31 VA: 0x2AC4B30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AC4EB0 Offset: 0x2AC4FB1 VA: 0x2AC4EB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2AC51D0 Offset: 0x2AC52D1 VA: 0x2AC51D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AC5570 Offset: 0x2AC5671 VA: 0x2AC5570
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2AC58A0 Offset: 0x2AC59A1 VA: 0x2AC58A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AC5B80 Offset: 0x2AC5C81 VA: 0x2AC5B80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AC5E60 Offset: 0x2AC5F61 VA: 0x2AC5E60
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x2AC60B0 Offset: 0x2AC61B1 VA: 0x2AC60B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x2AC6300 Offset: 0x2AC6401 VA: 0x2AC6300
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x2AC65C0 Offset: 0x2AC66C1 VA: 0x2AC65C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x2AC6810 Offset: 0x2AC6911 VA: 0x2AC6810
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x2AC6AC0 Offset: 0x2AC6BC1 VA: 0x2AC6AC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x2AC6D70 Offset: 0x2AC6E71 VA: 0x2AC6D70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x2AC6FF0 Offset: 0x2AC70F1 VA: 0x2AC6FF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x2AC72A0 Offset: 0x2AC73A1 VA: 0x2AC72A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2AC7550 Offset: 0x2AC7651 VA: 0x2AC7550
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x2AC7800 Offset: 0x2AC7901 VA: 0x2AC7800
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x2AC7AB0 Offset: 0x2AC7BB1 VA: 0x2AC7AB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x2AC7D30 Offset: 0x2AC7E31 VA: 0x2AC7D30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x2AC7FE0 Offset: 0x2AC80E1 VA: 0x2AC7FE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x2AC8230 Offset: 0x2AC8331 VA: 0x2AC8230
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x2AC84B0 Offset: 0x2AC85B1 VA: 0x2AC84B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x2AC8760 Offset: 0x2AC8861 VA: 0x2AC8760
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x2AC8A10 Offset: 0x2AC8B11 VA: 0x2AC8A10
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x2AC8CC0 Offset: 0x2AC8DC1 VA: 0x2AC8CC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x2AC8F70 Offset: 0x2AC9071 VA: 0x2AC8F70
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2AC9260 Offset: 0x2AC9361 VA: 0x2AC9260
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x2AC9530 Offset: 0x2AC9631 VA: 0x2AC9530
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2AC9860 Offset: 0x2AC9961 VA: 0x2AC9860
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x2AC9B40 Offset: 0x2AC9C41 VA: 0x2AC9B40
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2AC9E90 Offset: 0x2AC9F91 VA: 0x2AC9E90
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2ACA180 Offset: 0x2ACA281 VA: 0x2ACA180
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2ACA4F0 Offset: 0x2ACA5F1 VA: 0x2ACA4F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2ACA7F0 Offset: 0x2ACA8F1 VA: 0x2ACA7F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2ACAB90 Offset: 0x2ACAC91 VA: 0x2ACAB90
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2ACAEC0 Offset: 0x2ACAFC1 VA: 0x2ACAEC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ACB1D0 Offset: 0x2ACB2D1 VA: 0x2ACB1D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ACB4B0 Offset: 0x2ACB5B1 VA: 0x2ACB4B0
	|-LazyPromise<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x2ACB700 Offset: 0x2ACB801 VA: 0x2ACB700
	|-LazyPromise<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x2ACB950 Offset: 0x2ACBA51 VA: 0x2ACB950
	|-LazyPromise<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x2ACBC20 Offset: 0x2ACBD21 VA: 0x2ACBC20
	|-LazyPromise<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x2ACBE70 Offset: 0x2ACBF71 VA: 0x2ACBE70
	|-LazyPromise<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x2ACC120 Offset: 0x2ACC221 VA: 0x2ACC120
	|-LazyPromise<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x2ACC3A0 Offset: 0x2ACC4A1 VA: 0x2ACC3A0
	|-LazyPromise<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x2ACC5F0 Offset: 0x2ACC6F1 VA: 0x2ACC5F0
	|-LazyPromise<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x2ACC870 Offset: 0x2ACC971 VA: 0x2ACC870
	|-LazyPromise<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2ACCAF0 Offset: 0x2ACCBF1 VA: 0x2ACCAF0
	|-LazyPromise<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x2ACCDA0 Offset: 0x2ACCEA1 VA: 0x2ACCDA0
	|-LazyPromise<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x2ACD050 Offset: 0x2ACD151 VA: 0x2ACD050
	|-LazyPromise<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x2ACD2A0 Offset: 0x2ACD3A1 VA: 0x2ACD2A0
	|-LazyPromise<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x2ACD520 Offset: 0x2ACD621 VA: 0x2ACD520
	|-LazyPromise<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x2ACD770 Offset: 0x2ACD871 VA: 0x2ACD770
	|-LazyPromise<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x2ACD9F0 Offset: 0x2ACDAF1 VA: 0x2ACD9F0
	|-LazyPromise<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x2ACDC70 Offset: 0x2ACDD71 VA: 0x2ACDC70
	|-LazyPromise<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x2ACDF20 Offset: 0x2ACE021 VA: 0x2ACDF20
	|-LazyPromise<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2ACE1A0 Offset: 0x2ACE2A1 VA: 0x2ACE1A0
	|-LazyPromise<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2ACE420 Offset: 0x2ACE521 VA: 0x2ACE420
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2ACE700 Offset: 0x2ACE801 VA: 0x2ACE700
	|-LazyPromise<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2ACE9B0 Offset: 0x2ACEAB1 VA: 0x2ACE9B0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2ACECB0 Offset: 0x2ACEDB1 VA: 0x2ACECB0
	|-LazyPromise<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x2ACEF70 Offset: 0x2ACF071 VA: 0x2ACEF70
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2ACF2A0 Offset: 0x2ACF3A1 VA: 0x2ACF2A0
	|-LazyPromise<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2ACF580 Offset: 0x2ACF681 VA: 0x2ACF580
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2ACF8D0 Offset: 0x2ACF9D1 VA: 0x2ACF8D0
	|-LazyPromise<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2ACFBC0 Offset: 0x2ACFCC1 VA: 0x2ACFBC0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2ACFF40 Offset: 0x2AD0041 VA: 0x2ACFF40
	|-LazyPromise<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2AD0240 Offset: 0x2AD0341 VA: 0x2AD0240
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2AD05E0 Offset: 0x2AD06E1 VA: 0x2AD05E0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2AD08C0 Offset: 0x2AD09C1 VA: 0x2AD08C0
	|-LazyPromise<AsyncUnit>..ctor
	|
	|-RVA: 0x2AD0B10 Offset: 0x2AD0C11 VA: 0x2AD0B10
	|-LazyPromise<bool>..ctor
	|
	|-RVA: 0x2AD0D60 Offset: 0x2AD0E61 VA: 0x2AD0D60
	|-LazyPromise<Bounds>..ctor
	|
	|-RVA: 0x2AD1010 Offset: 0x2AD1111 VA: 0x2AD1010
	|-LazyPromise<byte>..ctor
	|
	|-RVA: 0x2AD1260 Offset: 0x2AD1361 VA: 0x2AD1260
	|-LazyPromise<Color>..ctor
	|
	|-RVA: 0x2AD14E0 Offset: 0x2AD15E1 VA: 0x2AD14E0
	|-LazyPromise<double>..ctor
	|
	|-RVA: 0x2AD1730 Offset: 0x2AD1831 VA: 0x2AD1730
	|-LazyPromise<int>..ctor
	|
	|-RVA: 0x2AD1980 Offset: 0x2AD1A81 VA: 0x2AD1980
	|-LazyPromise<long>..ctor
	|
	|-RVA: 0x2AD1BD0 Offset: 0x2AD1CD1 VA: 0x2AD1BD0
	|-LazyPromise<object>..ctor
	|
	|-RVA: 0x2AD1E20 Offset: 0x2AD1F21 VA: 0x2AD1E20
	|-LazyPromise<Quaternion>..ctor
	|
	|-RVA: 0x2AD20A0 Offset: 0x2AD21A1 VA: 0x2AD20A0
	|-LazyPromise<Rect>..ctor
	|
	|-RVA: 0x2AD2320 Offset: 0x2AD2421 VA: 0x2AD2320
	|-LazyPromise<float>..ctor
	|
	|-RVA: 0x2AD2570 Offset: 0x2AD2671 VA: 0x2AD2570
	|-LazyPromise<UniTask>..ctor
	|
	|-RVA: 0x2AD27C0 Offset: 0x2AD28C1 VA: 0x2AD27C0
	|-LazyPromise<Unit>..ctor
	|
	|-RVA: 0x2AD2A10 Offset: 0x2AD2B11 VA: 0x2AD2A10
	|-LazyPromise<Vector2>..ctor
	|
	|-RVA: 0x2AD2C60 Offset: 0x2AD2D61 VA: 0x2AD2C60
	|-LazyPromise<Vector3>..ctor
	|
	|-RVA: 0x2AD2EE0 Offset: 0x2AD2FE1 VA: 0x2AD2EE0
	|-LazyPromise<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289F8F0 Offset: 0x289F9F1 VA: 0x289F8F0
	|-LazyPromise<UniTask<object>>.Create
	|
	|-RVA: 0x289FB70 Offset: 0x289FC71 VA: 0x289FB70
	|-LazyPromise<ValueTuple<bool, UniTask<object>>>.Create
	|
	|-RVA: 0x289FE20 Offset: 0x289FF21 VA: 0x289FE20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Create
	|
	|-RVA: 0x28A00E0 Offset: 0x28A01E1 VA: 0x28A00E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Create
	|
	|-RVA: 0x28A03C0 Offset: 0x28A04C1 VA: 0x28A03C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Create
	|
	|-RVA: 0x28A06B0 Offset: 0x28A07B1 VA: 0x28A06B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Create
	|
	|-RVA: 0x28A0900 Offset: 0x28A0A01 VA: 0x28A0900
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Create
	|
	|-RVA: 0x28A0B50 Offset: 0x28A0C51 VA: 0x28A0B50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Create
	|
	|-RVA: 0x28A0E40 Offset: 0x28A0F41 VA: 0x28A0E40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Create
	|
	|-RVA: 0x28A1090 Offset: 0x28A1191 VA: 0x28A1090
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Create
	|
	|-RVA: 0x28A1370 Offset: 0x28A1471 VA: 0x28A1370
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Create
	|
	|-RVA: 0x28A1660 Offset: 0x28A1761 VA: 0x28A1660
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Create
	|
	|-RVA: 0x28A1910 Offset: 0x28A1A11 VA: 0x28A1910
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Create
	|
	|-RVA: 0x28A1C00 Offset: 0x28A1D01 VA: 0x28A1C00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Create
	|
	|-RVA: 0x28A1EF0 Offset: 0x28A1FF1 VA: 0x28A1EF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Create
	|
	|-RVA: 0x28A21D0 Offset: 0x28A22D1 VA: 0x28A21D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Create
	|
	|-RVA: 0x28A24B0 Offset: 0x28A25B1 VA: 0x28A24B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Create
	|
	|-RVA: 0x28A2760 Offset: 0x28A2861 VA: 0x28A2760
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Create
	|
	|-RVA: 0x28A2A50 Offset: 0x28A2B51 VA: 0x28A2A50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Create
	|
	|-RVA: 0x28A2CA0 Offset: 0x28A2DA1 VA: 0x28A2CA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Create
	|
	|-RVA: 0x28A2F70 Offset: 0x28A3071 VA: 0x28A2F70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Create
	|
	|-RVA: 0x28A3230 Offset: 0x28A3331 VA: 0x28A3230
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Create
	|
	|-RVA: 0x28A3510 Offset: 0x28A3611 VA: 0x28A3510
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Create
	|
	|-RVA: 0x28A3800 Offset: 0x28A3901 VA: 0x28A3800
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Create
	|
	|-RVA: 0x28A3AF0 Offset: 0x28A3BF1 VA: 0x28A3AF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Create
	|
	|-RVA: 0x28A3DF0 Offset: 0x28A3EF1 VA: 0x28A3DF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Create
	|
	|-RVA: 0x28A4110 Offset: 0x28A4211 VA: 0x28A4110
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Create
	|
	|-RVA: 0x28A4450 Offset: 0x28A4551 VA: 0x28A4450
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Create
	|
	|-RVA: 0x28A4790 Offset: 0x28A4891 VA: 0x28A4790
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Create
	|
	|-RVA: 0x28A4AE0 Offset: 0x28A4BE1 VA: 0x28A4AE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Create
	|
	|-RVA: 0x28A4D30 Offset: 0x28A4E31 VA: 0x28A4D30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Create
	|
	|-RVA: 0x28A4F80 Offset: 0x28A5081 VA: 0x28A4F80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Create
	|
	|-RVA: 0x28A5260 Offset: 0x28A5361 VA: 0x28A5260
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Create
	|
	|-RVA: 0x28A54B0 Offset: 0x28A55B1 VA: 0x28A54B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Create
	|
	|-RVA: 0x28A5770 Offset: 0x28A5871 VA: 0x28A5770
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Create
	|
	|-RVA: 0x28A5A50 Offset: 0x28A5B51 VA: 0x28A5A50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Create
	|
	|-RVA: 0x28A5D00 Offset: 0x28A5E01 VA: 0x28A5D00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Create
	|
	|-RVA: 0x28A5FE0 Offset: 0x28A60E1 VA: 0x28A5FE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Create
	|
	|-RVA: 0x28A62C0 Offset: 0x28A63C1 VA: 0x28A62C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Create
	|
	|-RVA: 0x28A6580 Offset: 0x28A6681 VA: 0x28A6580
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Create
	|
	|-RVA: 0x28A6840 Offset: 0x28A6941 VA: 0x28A6840
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Create
	|
	|-RVA: 0x28A6AF0 Offset: 0x28A6BF1 VA: 0x28A6AF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Create
	|
	|-RVA: 0x28A6DD0 Offset: 0x28A6ED1 VA: 0x28A6DD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Create
	|
	|-RVA: 0x28A7020 Offset: 0x28A7121 VA: 0x28A7020
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Create
	|
	|-RVA: 0x28A72D0 Offset: 0x28A73D1 VA: 0x28A72D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Create
	|
	|-RVA: 0x28A75A0 Offset: 0x28A76A1 VA: 0x28A75A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Create
	|
	|-RVA: 0x28A7860 Offset: 0x28A7961 VA: 0x28A7860
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Create
	|
	|-RVA: 0x28A7B40 Offset: 0x28A7C41 VA: 0x28A7B40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Create
	|
	|-RVA: 0x28A7E20 Offset: 0x28A7F21 VA: 0x28A7E20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Create
	|
	|-RVA: 0x28A8150 Offset: 0x28A8251 VA: 0x28A8150
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Create
	|
	|-RVA: 0x28A8440 Offset: 0x28A8541 VA: 0x28A8440
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Create
	|
	|-RVA: 0x28A8790 Offset: 0x28A8891 VA: 0x28A8790
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Create
	|
	|-RVA: 0x28A8A90 Offset: 0x28A8B91 VA: 0x28A8A90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Create
	|
	|-RVA: 0x28A8E00 Offset: 0x28A8F01 VA: 0x28A8E00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Create
	|
	|-RVA: 0x28A9130 Offset: 0x28A9231 VA: 0x28A9130
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Create
	|
	|-RVA: 0x28A94D0 Offset: 0x28A95D1 VA: 0x28A94D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Create
	|
	|-RVA: 0x28A9800 Offset: 0x28A9901 VA: 0x28A9800
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Create
	|
	|-RVA: 0x28A9B10 Offset: 0x28A9C11 VA: 0x28A9B10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Create
	|
	|-RVA: 0x28A9E60 Offset: 0x28A9F61 VA: 0x28A9E60
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Create
	|
	|-RVA: 0x28AA0B0 Offset: 0x28AA1B1 VA: 0x28AA0B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Create
	|
	|-RVA: 0x28AA300 Offset: 0x28AA401 VA: 0x28AA300
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Create
	|
	|-RVA: 0x28AA5E0 Offset: 0x28AA6E1 VA: 0x28AA5E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Create
	|
	|-RVA: 0x28AA830 Offset: 0x28AA931 VA: 0x28AA830
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Create
	|
	|-RVA: 0x28AAB00 Offset: 0x28AAC01 VA: 0x28AAB00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Create
	|
	|-RVA: 0x28AADC0 Offset: 0x28AAEC1 VA: 0x28AADC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Create
	|
	|-RVA: 0x28AB040 Offset: 0x28AB141 VA: 0x28AB040
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Create
	|
	|-RVA: 0x28AB300 Offset: 0x28AB401 VA: 0x28AB300
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Create
	|
	|-RVA: 0x2AC1E10 Offset: 0x2AC1F11 VA: 0x2AC1E10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Create
	|
	|-RVA: 0x2AC20E0 Offset: 0x2AC21E1 VA: 0x2AC20E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Create
	|
	|-RVA: 0x2AC23B0 Offset: 0x2AC24B1 VA: 0x2AC23B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Create
	|
	|-RVA: 0x2AC2630 Offset: 0x2AC2731 VA: 0x2AC2630
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Create
	|
	|-RVA: 0x2AC2900 Offset: 0x2AC2A01 VA: 0x2AC2900
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Create
	|
	|-RVA: 0x2AC2B50 Offset: 0x2AC2C51 VA: 0x2AC2B50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Create
	|
	|-RVA: 0x2AC2E00 Offset: 0x2AC2F01 VA: 0x2AC2E00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Create
	|
	|-RVA: 0x2AC30B0 Offset: 0x2AC31B1 VA: 0x2AC30B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Create
	|
	|-RVA: 0x2AC3380 Offset: 0x2AC3481 VA: 0x2AC3380
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Create
	|
	|-RVA: 0x2AC3650 Offset: 0x2AC3751 VA: 0x2AC3650
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Create
	|
	|-RVA: 0x2AC3910 Offset: 0x2AC3A11 VA: 0x2AC3910
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Create
	|
	|-RVA: 0x2AC3C10 Offset: 0x2AC3D11 VA: 0x2AC3C10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Create
	|
	|-RVA: 0x2AC3EF0 Offset: 0x2AC3FF1 VA: 0x2AC3EF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Create
	|
	|-RVA: 0x2AC4230 Offset: 0x2AC4331 VA: 0x2AC4230
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Create
	|
	|-RVA: 0x2AC4520 Offset: 0x2AC4621 VA: 0x2AC4520
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Create
	|
	|-RVA: 0x2AC4870 Offset: 0x2AC4971 VA: 0x2AC4870
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Create
	|
	|-RVA: 0x2AC4B70 Offset: 0x2AC4C71 VA: 0x2AC4B70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Create
	|
	|-RVA: 0x2AC4EF0 Offset: 0x2AC4FF1 VA: 0x2AC4EF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Create
	|
	|-RVA: 0x2AC5210 Offset: 0x2AC5311 VA: 0x2AC5210
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Create
	|
	|-RVA: 0x2AC55B0 Offset: 0x2AC56B1 VA: 0x2AC55B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Create
	|
	|-RVA: 0x2AC58E0 Offset: 0x2AC59E1 VA: 0x2AC58E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Create
	|
	|-RVA: 0x2AC5BC0 Offset: 0x2AC5CC1 VA: 0x2AC5BC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Create
	|
	|-RVA: 0x2AC5EA0 Offset: 0x2AC5FA1 VA: 0x2AC5EA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Create
	|
	|-RVA: 0x2AC60F0 Offset: 0x2AC61F1 VA: 0x2AC60F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, bool>>>.Create
	|
	|-RVA: 0x2AC6340 Offset: 0x2AC6441 VA: 0x2AC6340
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Bounds>>>.Create
	|
	|-RVA: 0x2AC6600 Offset: 0x2AC6701 VA: 0x2AC6600
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, byte>>>.Create
	|
	|-RVA: 0x2AC6850 Offset: 0x2AC6951 VA: 0x2AC6850
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Color>>>.Create
	|
	|-RVA: 0x2AC6B00 Offset: 0x2AC6C01 VA: 0x2AC6B00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, double>>>.Create
	|
	|-RVA: 0x2AC6DB0 Offset: 0x2AC6EB1 VA: 0x2AC6DB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, int>>>.Create
	|
	|-RVA: 0x2AC7030 Offset: 0x2AC7131 VA: 0x2AC7030
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, long>>>.Create
	|
	|-RVA: 0x2AC72E0 Offset: 0x2AC73E1 VA: 0x2AC72E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2AC7590 Offset: 0x2AC7691 VA: 0x2AC7590
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Create
	|
	|-RVA: 0x2AC7840 Offset: 0x2AC7941 VA: 0x2AC7840
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Rect>>>.Create
	|
	|-RVA: 0x2AC7AF0 Offset: 0x2AC7BF1 VA: 0x2AC7AF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, float>>>.Create
	|
	|-RVA: 0x2AC7D70 Offset: 0x2AC7E71 VA: 0x2AC7D70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask>>>.Create
	|
	|-RVA: 0x2AC8020 Offset: 0x2AC8121 VA: 0x2AC8020
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Unit>>>.Create
	|
	|-RVA: 0x2AC8270 Offset: 0x2AC8371 VA: 0x2AC8270
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector2>>>.Create
	|
	|-RVA: 0x2AC84F0 Offset: 0x2AC85F1 VA: 0x2AC84F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector3>>>.Create
	|
	|-RVA: 0x2AC87A0 Offset: 0x2AC88A1 VA: 0x2AC87A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector4>>>.Create
	|
	|-RVA: 0x2AC8A50 Offset: 0x2AC8B51 VA: 0x2AC8A50
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, object>>>.Create
	|
	|-RVA: 0x2AC8D00 Offset: 0x2AC8E01 VA: 0x2AC8D00
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object>>>.Create
	|
	|-RVA: 0x2AC8FB0 Offset: 0x2AC90B1 VA: 0x2AC8FB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Create
	|
	|-RVA: 0x2AC92A0 Offset: 0x2AC93A1 VA: 0x2AC92A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object>>>.Create
	|
	|-RVA: 0x2AC9570 Offset: 0x2AC9671 VA: 0x2AC9570
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Create
	|
	|-RVA: 0x2AC98A0 Offset: 0x2AC99A1 VA: 0x2AC98A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object>>>.Create
	|
	|-RVA: 0x2AC9B80 Offset: 0x2AC9C81 VA: 0x2AC9B80
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Create
	|
	|-RVA: 0x2AC9ED0 Offset: 0x2AC9FD1 VA: 0x2AC9ED0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Create
	|
	|-RVA: 0x2ACA1C0 Offset: 0x2ACA2C1 VA: 0x2ACA1C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Create
	|
	|-RVA: 0x2ACA530 Offset: 0x2ACA631 VA: 0x2ACA530
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Create
	|
	|-RVA: 0x2ACA830 Offset: 0x2ACA931 VA: 0x2ACA830
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Create
	|
	|-RVA: 0x2ACABD0 Offset: 0x2ACACD1 VA: 0x2ACABD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Create
	|
	|-RVA: 0x2ACAF00 Offset: 0x2ACB001 VA: 0x2ACAF00
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Create
	|
	|-RVA: 0x2ACB210 Offset: 0x2ACB311 VA: 0x2ACB210
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Create
	|
	|-RVA: 0x2ACB4F0 Offset: 0x2ACB5F1 VA: 0x2ACB4F0
	|-LazyPromise<ValueTuple<bool, AsyncUnit>>.Create
	|
	|-RVA: 0x2ACB740 Offset: 0x2ACB841 VA: 0x2ACB740
	|-LazyPromise<ValueTuple<bool, bool>>.Create
	|
	|-RVA: 0x2ACB990 Offset: 0x2ACBA91 VA: 0x2ACB990
	|-LazyPromise<ValueTuple<bool, Bounds>>.Create
	|
	|-RVA: 0x2ACBC60 Offset: 0x2ACBD61 VA: 0x2ACBC60
	|-LazyPromise<ValueTuple<bool, byte>>.Create
	|
	|-RVA: 0x2ACBEB0 Offset: 0x2ACBFB1 VA: 0x2ACBEB0
	|-LazyPromise<ValueTuple<bool, Color>>.Create
	|
	|-RVA: 0x2ACC160 Offset: 0x2ACC261 VA: 0x2ACC160
	|-LazyPromise<ValueTuple<bool, double>>.Create
	|
	|-RVA: 0x2ACC3E0 Offset: 0x2ACC4E1 VA: 0x2ACC3E0
	|-LazyPromise<ValueTuple<bool, int>>.Create
	|
	|-RVA: 0x2ACC630 Offset: 0x2ACC731 VA: 0x2ACC630
	|-LazyPromise<ValueTuple<bool, long>>.Create
	|
	|-RVA: 0x2ACC8B0 Offset: 0x2ACC9B1 VA: 0x2ACC8B0
	|-LazyPromise<ValueTuple<bool, object>>.Create
	|
	|-RVA: 0x2ACCB30 Offset: 0x2ACCC31 VA: 0x2ACCB30
	|-LazyPromise<ValueTuple<bool, Quaternion>>.Create
	|
	|-RVA: 0x2ACCDE0 Offset: 0x2ACCEE1 VA: 0x2ACCDE0
	|-LazyPromise<ValueTuple<bool, Rect>>.Create
	|
	|-RVA: 0x2ACD090 Offset: 0x2ACD191 VA: 0x2ACD090
	|-LazyPromise<ValueTuple<bool, float>>.Create
	|
	|-RVA: 0x2ACD2E0 Offset: 0x2ACD3E1 VA: 0x2ACD2E0
	|-LazyPromise<ValueTuple<bool, UniTask>>.Create
	|
	|-RVA: 0x2ACD560 Offset: 0x2ACD661 VA: 0x2ACD560
	|-LazyPromise<ValueTuple<bool, Unit>>.Create
	|
	|-RVA: 0x2ACD7B0 Offset: 0x2ACD8B1 VA: 0x2ACD7B0
	|-LazyPromise<ValueTuple<bool, Vector2>>.Create
	|
	|-RVA: 0x2ACDA30 Offset: 0x2ACDB31 VA: 0x2ACDA30
	|-LazyPromise<ValueTuple<bool, Vector3>>.Create
	|
	|-RVA: 0x2ACDCB0 Offset: 0x2ACDDB1 VA: 0x2ACDCB0
	|-LazyPromise<ValueTuple<bool, Vector4>>.Create
	|
	|-RVA: 0x2ACDF60 Offset: 0x2ACE061 VA: 0x2ACDF60
	|-LazyPromise<ValueTuple<int, object>>.Create
	|
	|-RVA: 0x2ACE1E0 Offset: 0x2ACE2E1 VA: 0x2ACE1E0
	|-LazyPromise<ValueTuple<object, object>>.Create
	|
	|-RVA: 0x2ACE460 Offset: 0x2ACE561 VA: 0x2ACE460
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2ACE740 Offset: 0x2ACE841 VA: 0x2ACE740
	|-LazyPromise<ValueTuple<object, object, object>>.Create
	|
	|-RVA: 0x2ACE9F0 Offset: 0x2ACEAF1 VA: 0x2ACE9F0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2ACECF0 Offset: 0x2ACEDF1 VA: 0x2ACECF0
	|-LazyPromise<ValueTuple<object, object, object, object>>.Create
	|
	|-RVA: 0x2ACEFB0 Offset: 0x2ACF0B1 VA: 0x2ACEFB0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2ACF2E0 Offset: 0x2ACF3E1 VA: 0x2ACF2E0
	|-LazyPromise<ValueTuple<object, object, object, object, object>>.Create
	|
	|-RVA: 0x2ACF5C0 Offset: 0x2ACF6C1 VA: 0x2ACF5C0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2ACF910 Offset: 0x2ACFA11 VA: 0x2ACF910
	|-LazyPromise<ValueTuple<object, object, object, object, object, object>>.Create
	|
	|-RVA: 0x2ACFC00 Offset: 0x2ACFD01 VA: 0x2ACFC00
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Create
	|
	|-RVA: 0x2ACFF80 Offset: 0x2AD0081 VA: 0x2ACFF80
	|-LazyPromise<ValueTuple<object, object, object, object, object, object, object>>.Create
	|
	|-RVA: 0x2AD0280 Offset: 0x2AD0381 VA: 0x2AD0280
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Create
	|
	|-RVA: 0x2AD0620 Offset: 0x2AD0721 VA: 0x2AD0620
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Create
	|
	|-RVA: 0x2AD0900 Offset: 0x2AD0A01 VA: 0x2AD0900
	|-LazyPromise<AsyncUnit>.Create
	|
	|-RVA: 0x2AD0B50 Offset: 0x2AD0C51 VA: 0x2AD0B50
	|-LazyPromise<bool>.Create
	|
	|-RVA: 0x2AD0DA0 Offset: 0x2AD0EA1 VA: 0x2AD0DA0
	|-LazyPromise<Bounds>.Create
	|
	|-RVA: 0x2AD1050 Offset: 0x2AD1151 VA: 0x2AD1050
	|-LazyPromise<byte>.Create
	|
	|-RVA: 0x2AD12A0 Offset: 0x2AD13A1 VA: 0x2AD12A0
	|-LazyPromise<Color>.Create
	|
	|-RVA: 0x2AD1520 Offset: 0x2AD1621 VA: 0x2AD1520
	|-LazyPromise<double>.Create
	|
	|-RVA: 0x2AD1770 Offset: 0x2AD1871 VA: 0x2AD1770
	|-LazyPromise<int>.Create
	|
	|-RVA: 0x2AD19C0 Offset: 0x2AD1AC1 VA: 0x2AD19C0
	|-LazyPromise<long>.Create
	|
	|-RVA: 0x2AD1C10 Offset: 0x2AD1D11 VA: 0x2AD1C10
	|-LazyPromise<object>.Create
	|
	|-RVA: 0x2AD1E60 Offset: 0x2AD1F61 VA: 0x2AD1E60
	|-LazyPromise<Quaternion>.Create
	|
	|-RVA: 0x2AD20E0 Offset: 0x2AD21E1 VA: 0x2AD20E0
	|-LazyPromise<Rect>.Create
	|
	|-RVA: 0x2AD2360 Offset: 0x2AD2461 VA: 0x2AD2360
	|-LazyPromise<float>.Create
	|
	|-RVA: 0x2AD25B0 Offset: 0x2AD26B1 VA: 0x2AD25B0
	|-LazyPromise<UniTask>.Create
	|
	|-RVA: 0x2AD2800 Offset: 0x2AD2901 VA: 0x2AD2800
	|-LazyPromise<Unit>.Create
	|
	|-RVA: 0x2AD2A50 Offset: 0x2AD2B51 VA: 0x2AD2A50
	|-LazyPromise<Vector2>.Create
	|
	|-RVA: 0x2AD2CA0 Offset: 0x2AD2DA1 VA: 0x2AD2CA0
	|-LazyPromise<Vector3>.Create
	|
	|-RVA: 0x2AD2F20 Offset: 0x2AD3021 VA: 0x2AD2F20
	|-LazyPromise<Vector4>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289F970 Offset: 0x289FA71 VA: 0x289F970
	|-LazyPromise<UniTask<object>>.get_IsCompleted
	|
	|-RVA: 0x289FBF0 Offset: 0x289FCF1 VA: 0x289FBF0
	|-LazyPromise<ValueTuple<bool, UniTask<object>>>.get_IsCompleted
	|
	|-RVA: 0x289FEA0 Offset: 0x289FFA1 VA: 0x289FEA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_IsCompleted
	|
	|-RVA: 0x28A0170 Offset: 0x28A0271 VA: 0x28A0170
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A0450 Offset: 0x28A0551 VA: 0x28A0450
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A0710 Offset: 0x28A0811 VA: 0x28A0710
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A0960 Offset: 0x28A0A61 VA: 0x28A0960
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A0BE0 Offset: 0x28A0CE1 VA: 0x28A0BE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A0EA0 Offset: 0x28A0FA1 VA: 0x28A0EA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A1120 Offset: 0x28A1221 VA: 0x28A1120
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A1400 Offset: 0x28A1501 VA: 0x28A1400
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A16E0 Offset: 0x28A17E1 VA: 0x28A16E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A19A0 Offset: 0x28A1AA1 VA: 0x28A19A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A1C90 Offset: 0x28A1D91 VA: 0x28A1C90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A1F80 Offset: 0x28A2081 VA: 0x28A1F80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A2260 Offset: 0x28A2361 VA: 0x28A2260
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A2530 Offset: 0x28A2631 VA: 0x28A2530
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A27F0 Offset: 0x28A28F1 VA: 0x28A27F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A2AB0 Offset: 0x28A2BB1 VA: 0x28A2AB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A2D20 Offset: 0x28A2E21 VA: 0x28A2D20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A2FF0 Offset: 0x28A30F1 VA: 0x28A2FF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A32C0 Offset: 0x28A33C1 VA: 0x28A32C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A35A0 Offset: 0x28A36A1 VA: 0x28A35A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A3890 Offset: 0x28A3991 VA: 0x28A3890
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A3B90 Offset: 0x28A3C91 VA: 0x28A3B90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A3EA0 Offset: 0x28A3FA1 VA: 0x28A3EA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A41D0 Offset: 0x28A42D1 VA: 0x28A41D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A4510 Offset: 0x28A4611 VA: 0x28A4510
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A4860 Offset: 0x28A4961 VA: 0x28A4860
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A4B40 Offset: 0x28A4C41 VA: 0x28A4B40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A4D90 Offset: 0x28A4E91 VA: 0x28A4D90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A5010 Offset: 0x28A5111 VA: 0x28A5010
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A52C0 Offset: 0x28A53C1 VA: 0x28A52C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A5530 Offset: 0x28A5631 VA: 0x28A5530
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A5800 Offset: 0x28A5901 VA: 0x28A5800
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A5AD0 Offset: 0x28A5BD1 VA: 0x28A5AD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A5D90 Offset: 0x28A5E91 VA: 0x28A5D90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A6070 Offset: 0x28A6171 VA: 0x28A6070
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A6340 Offset: 0x28A6441 VA: 0x28A6340
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A6600 Offset: 0x28A6701 VA: 0x28A6600
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A68C0 Offset: 0x28A69C1 VA: 0x28A68C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A6B80 Offset: 0x28A6C81 VA: 0x28A6B80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A6E30 Offset: 0x28A6F31 VA: 0x28A6E30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A70A0 Offset: 0x28A71A1 VA: 0x28A70A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A7350 Offset: 0x28A7451 VA: 0x28A7350
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A7620 Offset: 0x28A7721 VA: 0x28A7620
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A78F0 Offset: 0x28A79F1 VA: 0x28A78F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A7BD0 Offset: 0x28A7CD1 VA: 0x28A7BD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A7EE0 Offset: 0x28A7FE1 VA: 0x28A7EE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A81E0 Offset: 0x28A82E1 VA: 0x28A81E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A8510 Offset: 0x28A8611 VA: 0x28A8510
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A8830 Offset: 0x28A8931 VA: 0x28A8830
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A8B70 Offset: 0x28A8C71 VA: 0x28A8B70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A8EC0 Offset: 0x28A8FC1 VA: 0x28A8EC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A9220 Offset: 0x28A9321 VA: 0x28A9220
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A9580 Offset: 0x28A9681 VA: 0x28A9580
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A9890 Offset: 0x28A9991 VA: 0x28A9890
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A9BE0 Offset: 0x28A9CE1 VA: 0x28A9BE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x28A9EC0 Offset: 0x28A9FC1 VA: 0x28A9EC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_IsCompleted
	|
	|-RVA: 0x28AA110 Offset: 0x28AA211 VA: 0x28AA110
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_IsCompleted
	|
	|-RVA: 0x28AA390 Offset: 0x28AA491 VA: 0x28AA390
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_IsCompleted
	|
	|-RVA: 0x28AA640 Offset: 0x28AA741 VA: 0x28AA640
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_IsCompleted
	|
	|-RVA: 0x28AA8B0 Offset: 0x28AA9B1 VA: 0x28AA8B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_IsCompleted
	|
	|-RVA: 0x28AAB80 Offset: 0x28AAC81 VA: 0x28AAB80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_IsCompleted
	|
	|-RVA: 0x28AAE40 Offset: 0x28AAF41 VA: 0x28AAE40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_IsCompleted
	|
	|-RVA: 0x28AB0C0 Offset: 0x28AB1C1 VA: 0x28AB0C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_IsCompleted
	|
	|-RVA: 0x28AB390 Offset: 0x28AB491 VA: 0x28AB390
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC1E90 Offset: 0x2AC1F91 VA: 0x2AC1E90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC2160 Offset: 0x2AC2261 VA: 0x2AC2160
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC2430 Offset: 0x2AC2531 VA: 0x2AC2430
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC26C0 Offset: 0x2AC27C1 VA: 0x2AC26C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC2960 Offset: 0x2AC2A61 VA: 0x2AC2960
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC2BD0 Offset: 0x2AC2CD1 VA: 0x2AC2BD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC2E80 Offset: 0x2AC2F81 VA: 0x2AC2E80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC3130 Offset: 0x2AC3231 VA: 0x2AC3130
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC3410 Offset: 0x2AC3511 VA: 0x2AC3410
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC36D0 Offset: 0x2AC37D1 VA: 0x2AC36D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC39B0 Offset: 0x2AC3AB1 VA: 0x2AC39B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC3CA0 Offset: 0x2AC3DA1 VA: 0x2AC3CA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC3FB0 Offset: 0x2AC40B1 VA: 0x2AC3FB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC42C0 Offset: 0x2AC43C1 VA: 0x2AC42C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC45F0 Offset: 0x2AC46F1 VA: 0x2AC45F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC4910 Offset: 0x2AC4A11 VA: 0x2AC4910
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC4C50 Offset: 0x2AC4D51 VA: 0x2AC4C50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC4FA0 Offset: 0x2AC50A1 VA: 0x2AC4FA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC5300 Offset: 0x2AC5401 VA: 0x2AC5300
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC5660 Offset: 0x2AC5761 VA: 0x2AC5660
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC5970 Offset: 0x2AC5A71 VA: 0x2AC5970
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC5C50 Offset: 0x2AC5D51 VA: 0x2AC5C50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC5F00 Offset: 0x2AC6001 VA: 0x2AC5F00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_IsCompleted
	|
	|-RVA: 0x2AC6150 Offset: 0x2AC6251 VA: 0x2AC6150
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, bool>>>.get_IsCompleted
	|
	|-RVA: 0x2AC63C0 Offset: 0x2AC64C1 VA: 0x2AC63C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_IsCompleted
	|
	|-RVA: 0x2AC6660 Offset: 0x2AC6761 VA: 0x2AC6660
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, byte>>>.get_IsCompleted
	|
	|-RVA: 0x2AC68D0 Offset: 0x2AC69D1 VA: 0x2AC68D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Color>>>.get_IsCompleted
	|
	|-RVA: 0x2AC6B80 Offset: 0x2AC6C81 VA: 0x2AC6B80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, double>>>.get_IsCompleted
	|
	|-RVA: 0x2AC6E30 Offset: 0x2AC6F31 VA: 0x2AC6E30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, int>>>.get_IsCompleted
	|
	|-RVA: 0x2AC70B0 Offset: 0x2AC71B1 VA: 0x2AC70B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, long>>>.get_IsCompleted
	|
	|-RVA: 0x2AC7360 Offset: 0x2AC7461 VA: 0x2AC7360
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2AC7610 Offset: 0x2AC7711 VA: 0x2AC7610
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_IsCompleted
	|
	|-RVA: 0x2AC78C0 Offset: 0x2AC79C1 VA: 0x2AC78C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_IsCompleted
	|
	|-RVA: 0x2AC7B70 Offset: 0x2AC7C71 VA: 0x2AC7B70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, float>>>.get_IsCompleted
	|
	|-RVA: 0x2AC7DF0 Offset: 0x2AC7EF1 VA: 0x2AC7DF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_IsCompleted
	|
	|-RVA: 0x2AC8080 Offset: 0x2AC8181 VA: 0x2AC8080
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_IsCompleted
	|
	|-RVA: 0x2AC82F0 Offset: 0x2AC83F1 VA: 0x2AC82F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_IsCompleted
	|
	|-RVA: 0x2AC8570 Offset: 0x2AC8671 VA: 0x2AC8570
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_IsCompleted
	|
	|-RVA: 0x2AC8820 Offset: 0x2AC8921 VA: 0x2AC8820
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_IsCompleted
	|
	|-RVA: 0x2AC8AD0 Offset: 0x2AC8BD1 VA: 0x2AC8AD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, object>>>.get_IsCompleted
	|
	|-RVA: 0x2AC8D80 Offset: 0x2AC8E81 VA: 0x2AC8D80
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2AC9040 Offset: 0x2AC9141 VA: 0x2AC9040
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC9330 Offset: 0x2AC9431 VA: 0x2AC9330
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2AC9630 Offset: 0x2AC9731 VA: 0x2AC9630
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC9930 Offset: 0x2AC9A31 VA: 0x2AC9930
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2AC9C50 Offset: 0x2AC9D51 VA: 0x2AC9C50
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC9F60 Offset: 0x2ACA061 VA: 0x2AC9F60
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2ACA2A0 Offset: 0x2ACA3A1 VA: 0x2ACA2A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2ACA5D0 Offset: 0x2ACA6D1 VA: 0x2ACA5D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2ACA920 Offset: 0x2ACAA21 VA: 0x2ACA920
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2ACAC90 Offset: 0x2ACAD91 VA: 0x2ACAC90
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2ACAF90 Offset: 0x2ACB091 VA: 0x2ACAF90
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2ACB2A0 Offset: 0x2ACB3A1 VA: 0x2ACB2A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2ACB550 Offset: 0x2ACB651 VA: 0x2ACB550
	|-LazyPromise<ValueTuple<bool, AsyncUnit>>.get_IsCompleted
	|
	|-RVA: 0x2ACB7A0 Offset: 0x2ACB8A1 VA: 0x2ACB7A0
	|-LazyPromise<ValueTuple<bool, bool>>.get_IsCompleted
	|
	|-RVA: 0x2ACBA10 Offset: 0x2ACBB11 VA: 0x2ACBA10
	|-LazyPromise<ValueTuple<bool, Bounds>>.get_IsCompleted
	|
	|-RVA: 0x2ACBCC0 Offset: 0x2ACBDC1 VA: 0x2ACBCC0
	|-LazyPromise<ValueTuple<bool, byte>>.get_IsCompleted
	|
	|-RVA: 0x2ACBF30 Offset: 0x2ACC031 VA: 0x2ACBF30
	|-LazyPromise<ValueTuple<bool, Color>>.get_IsCompleted
	|
	|-RVA: 0x2ACC1E0 Offset: 0x2ACC2E1 VA: 0x2ACC1E0
	|-LazyPromise<ValueTuple<bool, double>>.get_IsCompleted
	|
	|-RVA: 0x2ACC440 Offset: 0x2ACC541 VA: 0x2ACC440
	|-LazyPromise<ValueTuple<bool, int>>.get_IsCompleted
	|
	|-RVA: 0x2ACC6B0 Offset: 0x2ACC7B1 VA: 0x2ACC6B0
	|-LazyPromise<ValueTuple<bool, long>>.get_IsCompleted
	|
	|-RVA: 0x2ACC930 Offset: 0x2ACCA31 VA: 0x2ACC930
	|-LazyPromise<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x2ACCBB0 Offset: 0x2ACCCB1 VA: 0x2ACCBB0
	|-LazyPromise<ValueTuple<bool, Quaternion>>.get_IsCompleted
	|
	|-RVA: 0x2ACCE60 Offset: 0x2ACCF61 VA: 0x2ACCE60
	|-LazyPromise<ValueTuple<bool, Rect>>.get_IsCompleted
	|
	|-RVA: 0x2ACD0F0 Offset: 0x2ACD1F1 VA: 0x2ACD0F0
	|-LazyPromise<ValueTuple<bool, float>>.get_IsCompleted
	|
	|-RVA: 0x2ACD360 Offset: 0x2ACD461 VA: 0x2ACD360
	|-LazyPromise<ValueTuple<bool, UniTask>>.get_IsCompleted
	|
	|-RVA: 0x2ACD5C0 Offset: 0x2ACD6C1 VA: 0x2ACD5C0
	|-LazyPromise<ValueTuple<bool, Unit>>.get_IsCompleted
	|
	|-RVA: 0x2ACD830 Offset: 0x2ACD931 VA: 0x2ACD830
	|-LazyPromise<ValueTuple<bool, Vector2>>.get_IsCompleted
	|
	|-RVA: 0x2ACDAB0 Offset: 0x2ACDBB1 VA: 0x2ACDAB0
	|-LazyPromise<ValueTuple<bool, Vector3>>.get_IsCompleted
	|
	|-RVA: 0x2ACDD30 Offset: 0x2ACDE31 VA: 0x2ACDD30
	|-LazyPromise<ValueTuple<bool, Vector4>>.get_IsCompleted
	|
	|-RVA: 0x2ACDFE0 Offset: 0x2ACE0E1 VA: 0x2ACDFE0
	|-LazyPromise<ValueTuple<int, object>>.get_IsCompleted
	|
	|-RVA: 0x2ACE260 Offset: 0x2ACE361 VA: 0x2ACE260
	|-LazyPromise<ValueTuple<object, object>>.get_IsCompleted
	|
	|-RVA: 0x2ACE4F0 Offset: 0x2ACE5F1 VA: 0x2ACE4F0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2ACE7C0 Offset: 0x2ACE8C1 VA: 0x2ACE7C0
	|-LazyPromise<ValueTuple<object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2ACEA90 Offset: 0x2ACEB91 VA: 0x2ACEA90
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2ACED70 Offset: 0x2ACEE71 VA: 0x2ACED70
	|-LazyPromise<ValueTuple<object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2ACF060 Offset: 0x2ACF161 VA: 0x2ACF060
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2ACF370 Offset: 0x2ACF471 VA: 0x2ACF370
	|-LazyPromise<ValueTuple<object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2ACF690 Offset: 0x2ACF791 VA: 0x2ACF690
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2ACF9A0 Offset: 0x2ACFAA1 VA: 0x2ACF9A0
	|-LazyPromise<ValueTuple<object, object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2ACFCE0 Offset: 0x2ACFDE1 VA: 0x2ACFCE0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2AD0020 Offset: 0x2AD0121 VA: 0x2AD0020
	|-LazyPromise<ValueTuple<object, object, object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2AD0370 Offset: 0x2AD0471 VA: 0x2AD0370
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AD06B0 Offset: 0x2AD07B1 VA: 0x2AD06B0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AD0960 Offset: 0x2AD0A61 VA: 0x2AD0960
	|-LazyPromise<AsyncUnit>.get_IsCompleted
	|
	|-RVA: 0x2AD0BB0 Offset: 0x2AD0CB1 VA: 0x2AD0BB0
	|-LazyPromise<bool>.get_IsCompleted
	|
	|-RVA: 0x2AD0E20 Offset: 0x2AD0F21 VA: 0x2AD0E20
	|-LazyPromise<Bounds>.get_IsCompleted
	|
	|-RVA: 0x2AD10B0 Offset: 0x2AD11B1 VA: 0x2AD10B0
	|-LazyPromise<byte>.get_IsCompleted
	|
	|-RVA: 0x2AD1320 Offset: 0x2AD1421 VA: 0x2AD1320
	|-LazyPromise<Color>.get_IsCompleted
	|
	|-RVA: 0x2AD1580 Offset: 0x2AD1681 VA: 0x2AD1580
	|-LazyPromise<double>.get_IsCompleted
	|
	|-RVA: 0x2AD17D0 Offset: 0x2AD18D1 VA: 0x2AD17D0
	|-LazyPromise<int>.get_IsCompleted
	|
	|-RVA: 0x2AD1A20 Offset: 0x2AD1B21 VA: 0x2AD1A20
	|-LazyPromise<long>.get_IsCompleted
	|
	|-RVA: 0x2AD1C70 Offset: 0x2AD1D71 VA: 0x2AD1C70
	|-LazyPromise<object>.get_IsCompleted
	|
	|-RVA: 0x2AD1EE0 Offset: 0x2AD1FE1 VA: 0x2AD1EE0
	|-LazyPromise<Quaternion>.get_IsCompleted
	|
	|-RVA: 0x2AD2160 Offset: 0x2AD2261 VA: 0x2AD2160
	|-LazyPromise<Rect>.get_IsCompleted
	|
	|-RVA: 0x2AD23C0 Offset: 0x2AD24C1 VA: 0x2AD23C0
	|-LazyPromise<float>.get_IsCompleted
	|
	|-RVA: 0x2AD2610 Offset: 0x2AD2711 VA: 0x2AD2610
	|-LazyPromise<UniTask>.get_IsCompleted
	|
	|-RVA: 0x2AD2860 Offset: 0x2AD2961 VA: 0x2AD2860
	|-LazyPromise<Unit>.get_IsCompleted
	|
	|-RVA: 0x2AD2AB0 Offset: 0x2AD2BB1 VA: 0x2AD2AB0
	|-LazyPromise<Vector2>.get_IsCompleted
	|
	|-RVA: 0x2AD2D20 Offset: 0x2AD2E21 VA: 0x2AD2D20
	|-LazyPromise<Vector3>.get_IsCompleted
	|
	|-RVA: 0x2AD2FA0 Offset: 0x2AD30A1 VA: 0x2AD2FA0
	|-LazyPromise<Vector4>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public AwaiterStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289F9C0 Offset: 0x289FAC1 VA: 0x289F9C0
	|-LazyPromise<UniTask<object>>.get_Status
	|
	|-RVA: 0x289FC40 Offset: 0x289FD41 VA: 0x289FC40
	|-LazyPromise<ValueTuple<bool, UniTask<object>>>.get_Status
	|
	|-RVA: 0x289FEF0 Offset: 0x289FFF1 VA: 0x289FEF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_Status
	|
	|-RVA: 0x28A01C0 Offset: 0x28A02C1 VA: 0x28A01C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_Status
	|
	|-RVA: 0x28A04A0 Offset: 0x28A05A1 VA: 0x28A04A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_Status
	|
	|-RVA: 0x28A0760 Offset: 0x28A0861 VA: 0x28A0760
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_Status
	|
	|-RVA: 0x28A09B0 Offset: 0x28A0AB1 VA: 0x28A09B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_Status
	|
	|-RVA: 0x28A0C30 Offset: 0x28A0D31 VA: 0x28A0C30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_Status
	|
	|-RVA: 0x28A0EF0 Offset: 0x28A0FF1 VA: 0x28A0EF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_Status
	|
	|-RVA: 0x28A1170 Offset: 0x28A1271 VA: 0x28A1170
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_Status
	|
	|-RVA: 0x28A1450 Offset: 0x28A1551 VA: 0x28A1450
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_Status
	|
	|-RVA: 0x28A1730 Offset: 0x28A1831 VA: 0x28A1730
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_Status
	|
	|-RVA: 0x28A19F0 Offset: 0x28A1AF1 VA: 0x28A19F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_Status
	|
	|-RVA: 0x28A1CE0 Offset: 0x28A1DE1 VA: 0x28A1CE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x28A1FD0 Offset: 0x28A20D1 VA: 0x28A1FD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_Status
	|
	|-RVA: 0x28A22B0 Offset: 0x28A23B1 VA: 0x28A22B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_Status
	|
	|-RVA: 0x28A2580 Offset: 0x28A2681 VA: 0x28A2580
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_Status
	|
	|-RVA: 0x28A2840 Offset: 0x28A2941 VA: 0x28A2840
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_Status
	|
	|-RVA: 0x28A2B00 Offset: 0x28A2C01 VA: 0x28A2B00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_Status
	|
	|-RVA: 0x28A2D70 Offset: 0x28A2E71 VA: 0x28A2D70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_Status
	|
	|-RVA: 0x28A3040 Offset: 0x28A3141 VA: 0x28A3040
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_Status
	|
	|-RVA: 0x28A3310 Offset: 0x28A3411 VA: 0x28A3310
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_Status
	|
	|-RVA: 0x28A35F0 Offset: 0x28A36F1 VA: 0x28A35F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_Status
	|
	|-RVA: 0x28A38E0 Offset: 0x28A39E1 VA: 0x28A38E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_Status
	|
	|-RVA: 0x28A3BE0 Offset: 0x28A3CE1 VA: 0x28A3BE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x28A3EF0 Offset: 0x28A3FF1 VA: 0x28A3EF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x28A4220 Offset: 0x28A4321 VA: 0x28A4220
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x28A4560 Offset: 0x28A4661 VA: 0x28A4560
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x28A48B0 Offset: 0x28A49B1 VA: 0x28A48B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x28A4B90 Offset: 0x28A4C91 VA: 0x28A4B90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_Status
	|
	|-RVA: 0x28A4DE0 Offset: 0x28A4EE1 VA: 0x28A4DE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_Status
	|
	|-RVA: 0x28A5060 Offset: 0x28A5161 VA: 0x28A5060
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_Status
	|
	|-RVA: 0x28A5310 Offset: 0x28A5411 VA: 0x28A5310
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_Status
	|
	|-RVA: 0x28A5580 Offset: 0x28A5681 VA: 0x28A5580
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_Status
	|
	|-RVA: 0x28A5850 Offset: 0x28A5951 VA: 0x28A5850
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_Status
	|
	|-RVA: 0x28A5B20 Offset: 0x28A5C21 VA: 0x28A5B20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_Status
	|
	|-RVA: 0x28A5DE0 Offset: 0x28A5EE1 VA: 0x28A5DE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_Status
	|
	|-RVA: 0x28A60C0 Offset: 0x28A61C1 VA: 0x28A60C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x28A6390 Offset: 0x28A6491 VA: 0x28A6390
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_Status
	|
	|-RVA: 0x28A6650 Offset: 0x28A6751 VA: 0x28A6650
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_Status
	|
	|-RVA: 0x28A6910 Offset: 0x28A6A11 VA: 0x28A6910
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_Status
	|
	|-RVA: 0x28A6BD0 Offset: 0x28A6CD1 VA: 0x28A6BD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_Status
	|
	|-RVA: 0x28A6E80 Offset: 0x28A6F81 VA: 0x28A6E80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_Status
	|
	|-RVA: 0x28A70F0 Offset: 0x28A71F1 VA: 0x28A70F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_Status
	|
	|-RVA: 0x28A73A0 Offset: 0x28A74A1 VA: 0x28A73A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_Status
	|
	|-RVA: 0x28A7670 Offset: 0x28A7771 VA: 0x28A7670
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_Status
	|
	|-RVA: 0x28A7940 Offset: 0x28A7A41 VA: 0x28A7940
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_Status
	|
	|-RVA: 0x28A7C20 Offset: 0x28A7D21 VA: 0x28A7C20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_Status
	|
	|-RVA: 0x28A7F30 Offset: 0x28A8031 VA: 0x28A7F30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x28A8230 Offset: 0x28A8331 VA: 0x28A8230
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_Status
	|
	|-RVA: 0x28A8560 Offset: 0x28A8661 VA: 0x28A8560
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x28A8880 Offset: 0x28A8981 VA: 0x28A8880
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x28A8BC0 Offset: 0x28A8CC1 VA: 0x28A8BC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x28A8F10 Offset: 0x28A9011 VA: 0x28A8F10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x28A9270 Offset: 0x28A9371 VA: 0x28A9270
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x28A95D0 Offset: 0x28A96D1 VA: 0x28A95D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x28A98E0 Offset: 0x28A99E1 VA: 0x28A98E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x28A9C30 Offset: 0x28A9D31 VA: 0x28A9C30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x28A9F10 Offset: 0x28AA011 VA: 0x28A9F10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_Status
	|
	|-RVA: 0x28AA160 Offset: 0x28AA261 VA: 0x28AA160
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_Status
	|
	|-RVA: 0x28AA3E0 Offset: 0x28AA4E1 VA: 0x28AA3E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_Status
	|
	|-RVA: 0x28AA690 Offset: 0x28AA791 VA: 0x28AA690
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_Status
	|
	|-RVA: 0x28AA900 Offset: 0x28AAA01 VA: 0x28AA900
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_Status
	|
	|-RVA: 0x28AABD0 Offset: 0x28AACD1 VA: 0x28AABD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_Status
	|
	|-RVA: 0x28AAE90 Offset: 0x28AAF91 VA: 0x28AAE90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_Status
	|
	|-RVA: 0x28AB110 Offset: 0x28AB211 VA: 0x28AB110
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_Status
	|
	|-RVA: 0x28AB3E0 Offset: 0x28AB4E1 VA: 0x28AB3E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2AC1EE0 Offset: 0x2AC1FE1 VA: 0x2AC1EE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_Status
	|
	|-RVA: 0x2AC21B0 Offset: 0x2AC22B1 VA: 0x2AC21B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_Status
	|
	|-RVA: 0x2AC2480 Offset: 0x2AC2581 VA: 0x2AC2480
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_Status
	|
	|-RVA: 0x2AC2710 Offset: 0x2AC2811 VA: 0x2AC2710
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_Status
	|
	|-RVA: 0x2AC29B0 Offset: 0x2AC2AB1 VA: 0x2AC29B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_Status
	|
	|-RVA: 0x2AC2C20 Offset: 0x2AC2D21 VA: 0x2AC2C20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_Status
	|
	|-RVA: 0x2AC2ED0 Offset: 0x2AC2FD1 VA: 0x2AC2ED0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_Status
	|
	|-RVA: 0x2AC3180 Offset: 0x2AC3281 VA: 0x2AC3180
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_Status
	|
	|-RVA: 0x2AC3460 Offset: 0x2AC3561 VA: 0x2AC3460
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_Status
	|
	|-RVA: 0x2AC3720 Offset: 0x2AC3821 VA: 0x2AC3720
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_Status
	|
	|-RVA: 0x2AC3A00 Offset: 0x2AC3B01 VA: 0x2AC3A00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2AC3CF0 Offset: 0x2AC3DF1 VA: 0x2AC3CF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_Status
	|
	|-RVA: 0x2AC4000 Offset: 0x2AC4101 VA: 0x2AC4000
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2AC4310 Offset: 0x2AC4411 VA: 0x2AC4310
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2AC4640 Offset: 0x2AC4741 VA: 0x2AC4640
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2AC4960 Offset: 0x2AC4A61 VA: 0x2AC4960
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2AC4CA0 Offset: 0x2AC4DA1 VA: 0x2AC4CA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2AC4FF0 Offset: 0x2AC50F1 VA: 0x2AC4FF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2AC5350 Offset: 0x2AC5451 VA: 0x2AC5350
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2AC56B0 Offset: 0x2AC57B1 VA: 0x2AC56B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2AC59C0 Offset: 0x2AC5AC1 VA: 0x2AC59C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2AC5CA0 Offset: 0x2AC5DA1 VA: 0x2AC5CA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2AC5F50 Offset: 0x2AC6051 VA: 0x2AC5F50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_Status
	|
	|-RVA: 0x2AC61A0 Offset: 0x2AC62A1 VA: 0x2AC61A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, bool>>>.get_Status
	|
	|-RVA: 0x2AC6410 Offset: 0x2AC6511 VA: 0x2AC6410
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_Status
	|
	|-RVA: 0x2AC66B0 Offset: 0x2AC67B1 VA: 0x2AC66B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, byte>>>.get_Status
	|
	|-RVA: 0x2AC6920 Offset: 0x2AC6A21 VA: 0x2AC6920
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Color>>>.get_Status
	|
	|-RVA: 0x2AC6BD0 Offset: 0x2AC6CD1 VA: 0x2AC6BD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, double>>>.get_Status
	|
	|-RVA: 0x2AC6E80 Offset: 0x2AC6F81 VA: 0x2AC6E80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, int>>>.get_Status
	|
	|-RVA: 0x2AC7100 Offset: 0x2AC7201 VA: 0x2AC7100
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, long>>>.get_Status
	|
	|-RVA: 0x2AC73B0 Offset: 0x2AC74B1 VA: 0x2AC73B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2AC7660 Offset: 0x2AC7761 VA: 0x2AC7660
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_Status
	|
	|-RVA: 0x2AC7910 Offset: 0x2AC7A11 VA: 0x2AC7910
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_Status
	|
	|-RVA: 0x2AC7BC0 Offset: 0x2AC7CC1 VA: 0x2AC7BC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, float>>>.get_Status
	|
	|-RVA: 0x2AC7E40 Offset: 0x2AC7F41 VA: 0x2AC7E40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_Status
	|
	|-RVA: 0x2AC80D0 Offset: 0x2AC81D1 VA: 0x2AC80D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_Status
	|
	|-RVA: 0x2AC8340 Offset: 0x2AC8441 VA: 0x2AC8340
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_Status
	|
	|-RVA: 0x2AC85C0 Offset: 0x2AC86C1 VA: 0x2AC85C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_Status
	|
	|-RVA: 0x2AC8870 Offset: 0x2AC8971 VA: 0x2AC8870
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_Status
	|
	|-RVA: 0x2AC8B20 Offset: 0x2AC8C21 VA: 0x2AC8B20
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, object>>>.get_Status
	|
	|-RVA: 0x2AC8DD0 Offset: 0x2AC8ED1 VA: 0x2AC8DD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object>>>.get_Status
	|
	|-RVA: 0x2AC9090 Offset: 0x2AC9191 VA: 0x2AC9090
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2AC9380 Offset: 0x2AC9481 VA: 0x2AC9380
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object>>>.get_Status
	|
	|-RVA: 0x2AC9680 Offset: 0x2AC9781 VA: 0x2AC9680
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2AC9980 Offset: 0x2AC9A81 VA: 0x2AC9980
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2AC9CA0 Offset: 0x2AC9DA1 VA: 0x2AC9CA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2AC9FB0 Offset: 0x2ACA0B1 VA: 0x2AC9FB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2ACA2F0 Offset: 0x2ACA3F1 VA: 0x2ACA2F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2ACA620 Offset: 0x2ACA721 VA: 0x2ACA620
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2ACA970 Offset: 0x2ACAA71 VA: 0x2ACA970
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2ACACE0 Offset: 0x2ACADE1 VA: 0x2ACACE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2ACAFE0 Offset: 0x2ACB0E1 VA: 0x2ACAFE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2ACB2F0 Offset: 0x2ACB3F1 VA: 0x2ACB2F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2ACB5A0 Offset: 0x2ACB6A1 VA: 0x2ACB5A0
	|-LazyPromise<ValueTuple<bool, AsyncUnit>>.get_Status
	|
	|-RVA: 0x2ACB7F0 Offset: 0x2ACB8F1 VA: 0x2ACB7F0
	|-LazyPromise<ValueTuple<bool, bool>>.get_Status
	|
	|-RVA: 0x2ACBA60 Offset: 0x2ACBB61 VA: 0x2ACBA60
	|-LazyPromise<ValueTuple<bool, Bounds>>.get_Status
	|
	|-RVA: 0x2ACBD10 Offset: 0x2ACBE11 VA: 0x2ACBD10
	|-LazyPromise<ValueTuple<bool, byte>>.get_Status
	|
	|-RVA: 0x2ACBF80 Offset: 0x2ACC081 VA: 0x2ACBF80
	|-LazyPromise<ValueTuple<bool, Color>>.get_Status
	|
	|-RVA: 0x2ACC230 Offset: 0x2ACC331 VA: 0x2ACC230
	|-LazyPromise<ValueTuple<bool, double>>.get_Status
	|
	|-RVA: 0x2ACC490 Offset: 0x2ACC591 VA: 0x2ACC490
	|-LazyPromise<ValueTuple<bool, int>>.get_Status
	|
	|-RVA: 0x2ACC700 Offset: 0x2ACC801 VA: 0x2ACC700
	|-LazyPromise<ValueTuple<bool, long>>.get_Status
	|
	|-RVA: 0x2ACC980 Offset: 0x2ACCA81 VA: 0x2ACC980
	|-LazyPromise<ValueTuple<bool, object>>.get_Status
	|
	|-RVA: 0x2ACCC00 Offset: 0x2ACCD01 VA: 0x2ACCC00
	|-LazyPromise<ValueTuple<bool, Quaternion>>.get_Status
	|
	|-RVA: 0x2ACCEB0 Offset: 0x2ACCFB1 VA: 0x2ACCEB0
	|-LazyPromise<ValueTuple<bool, Rect>>.get_Status
	|
	|-RVA: 0x2ACD140 Offset: 0x2ACD241 VA: 0x2ACD140
	|-LazyPromise<ValueTuple<bool, float>>.get_Status
	|
	|-RVA: 0x2ACD3B0 Offset: 0x2ACD4B1 VA: 0x2ACD3B0
	|-LazyPromise<ValueTuple<bool, UniTask>>.get_Status
	|
	|-RVA: 0x2ACD610 Offset: 0x2ACD711 VA: 0x2ACD610
	|-LazyPromise<ValueTuple<bool, Unit>>.get_Status
	|
	|-RVA: 0x2ACD880 Offset: 0x2ACD981 VA: 0x2ACD880
	|-LazyPromise<ValueTuple<bool, Vector2>>.get_Status
	|
	|-RVA: 0x2ACDB00 Offset: 0x2ACDC01 VA: 0x2ACDB00
	|-LazyPromise<ValueTuple<bool, Vector3>>.get_Status
	|
	|-RVA: 0x2ACDD80 Offset: 0x2ACDE81 VA: 0x2ACDD80
	|-LazyPromise<ValueTuple<bool, Vector4>>.get_Status
	|
	|-RVA: 0x2ACE030 Offset: 0x2ACE131 VA: 0x2ACE030
	|-LazyPromise<ValueTuple<int, object>>.get_Status
	|
	|-RVA: 0x2ACE2B0 Offset: 0x2ACE3B1 VA: 0x2ACE2B0
	|-LazyPromise<ValueTuple<object, object>>.get_Status
	|
	|-RVA: 0x2ACE540 Offset: 0x2ACE641 VA: 0x2ACE540
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2ACE810 Offset: 0x2ACE911 VA: 0x2ACE810
	|-LazyPromise<ValueTuple<object, object, object>>.get_Status
	|
	|-RVA: 0x2ACEAE0 Offset: 0x2ACEBE1 VA: 0x2ACEAE0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2ACEDC0 Offset: 0x2ACEEC1 VA: 0x2ACEDC0
	|-LazyPromise<ValueTuple<object, object, object, object>>.get_Status
	|
	|-RVA: 0x2ACF0B0 Offset: 0x2ACF1B1 VA: 0x2ACF0B0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2ACF3C0 Offset: 0x2ACF4C1 VA: 0x2ACF3C0
	|-LazyPromise<ValueTuple<object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x2ACF6E0 Offset: 0x2ACF7E1 VA: 0x2ACF6E0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2ACF9F0 Offset: 0x2ACFAF1 VA: 0x2ACF9F0
	|-LazyPromise<ValueTuple<object, object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x2ACFD30 Offset: 0x2ACFE31 VA: 0x2ACFD30
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2AD0070 Offset: 0x2AD0171 VA: 0x2AD0070
	|-LazyPromise<ValueTuple<object, object, object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x2AD03C0 Offset: 0x2AD04C1 VA: 0x2AD03C0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2AD0700 Offset: 0x2AD0801 VA: 0x2AD0700
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2AD09B0 Offset: 0x2AD0AB1 VA: 0x2AD09B0
	|-LazyPromise<AsyncUnit>.get_Status
	|
	|-RVA: 0x2AD0C00 Offset: 0x2AD0D01 VA: 0x2AD0C00
	|-LazyPromise<bool>.get_Status
	|
	|-RVA: 0x2AD0E70 Offset: 0x2AD0F71 VA: 0x2AD0E70
	|-LazyPromise<Bounds>.get_Status
	|
	|-RVA: 0x2AD1100 Offset: 0x2AD1201 VA: 0x2AD1100
	|-LazyPromise<byte>.get_Status
	|
	|-RVA: 0x2AD1370 Offset: 0x2AD1471 VA: 0x2AD1370
	|-LazyPromise<Color>.get_Status
	|
	|-RVA: 0x2AD15D0 Offset: 0x2AD16D1 VA: 0x2AD15D0
	|-LazyPromise<double>.get_Status
	|
	|-RVA: 0x2AD1820 Offset: 0x2AD1921 VA: 0x2AD1820
	|-LazyPromise<int>.get_Status
	|
	|-RVA: 0x2AD1A70 Offset: 0x2AD1B71 VA: 0x2AD1A70
	|-LazyPromise<long>.get_Status
	|
	|-RVA: 0x2AD1CC0 Offset: 0x2AD1DC1 VA: 0x2AD1CC0
	|-LazyPromise<object>.get_Status
	|
	|-RVA: 0x2AD1F30 Offset: 0x2AD2031 VA: 0x2AD1F30
	|-LazyPromise<Quaternion>.get_Status
	|
	|-RVA: 0x2AD21B0 Offset: 0x2AD22B1 VA: 0x2AD21B0
	|-LazyPromise<Rect>.get_Status
	|
	|-RVA: 0x2AD2410 Offset: 0x2AD2511 VA: 0x2AD2410
	|-LazyPromise<float>.get_Status
	|
	|-RVA: 0x2AD2660 Offset: 0x2AD2761 VA: 0x2AD2660
	|-LazyPromise<UniTask>.get_Status
	|
	|-RVA: 0x2AD28B0 Offset: 0x2AD29B1 VA: 0x2AD28B0
	|-LazyPromise<Unit>.get_Status
	|
	|-RVA: 0x2AD2B00 Offset: 0x2AD2C01 VA: 0x2AD2B00
	|-LazyPromise<Vector2>.get_Status
	|
	|-RVA: 0x2AD2D70 Offset: 0x2AD2E71 VA: 0x2AD2D70
	|-LazyPromise<Vector3>.get_Status
	|
	|-RVA: 0x2AD2FF0 Offset: 0x2AD30F1 VA: 0x2AD2FF0
	|-LazyPromise<Vector4>.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289FA10 Offset: 0x289FB11 VA: 0x289FA10
	|-LazyPromise<UniTask<object>>.GetResult
	|
	|-RVA: 0x289FC90 Offset: 0x289FD91 VA: 0x289FC90
	|-LazyPromise<ValueTuple<bool, UniTask<object>>>.GetResult
	|
	|-RVA: 0x289FF40 Offset: 0x28A0041 VA: 0x289FF40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetResult
	|
	|-RVA: 0x28A0210 Offset: 0x28A0311 VA: 0x28A0210
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetResult
	|
	|-RVA: 0x28A04F0 Offset: 0x28A05F1 VA: 0x28A04F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetResult
	|
	|-RVA: 0x28A07B0 Offset: 0x28A08B1 VA: 0x28A07B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetResult
	|
	|-RVA: 0x28A0A00 Offset: 0x28A0B01 VA: 0x28A0A00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetResult
	|
	|-RVA: 0x28A0C80 Offset: 0x28A0D81 VA: 0x28A0C80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetResult
	|
	|-RVA: 0x28A0F40 Offset: 0x28A1041 VA: 0x28A0F40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetResult
	|
	|-RVA: 0x28A11C0 Offset: 0x28A12C1 VA: 0x28A11C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetResult
	|
	|-RVA: 0x28A14A0 Offset: 0x28A15A1 VA: 0x28A14A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetResult
	|
	|-RVA: 0x28A1780 Offset: 0x28A1881 VA: 0x28A1780
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetResult
	|
	|-RVA: 0x28A1A40 Offset: 0x28A1B41 VA: 0x28A1A40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetResult
	|
	|-RVA: 0x28A1D30 Offset: 0x28A1E31 VA: 0x28A1D30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x28A2020 Offset: 0x28A2121 VA: 0x28A2020
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetResult
	|
	|-RVA: 0x28A2300 Offset: 0x28A2401 VA: 0x28A2300
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetResult
	|
	|-RVA: 0x28A25D0 Offset: 0x28A26D1 VA: 0x28A25D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetResult
	|
	|-RVA: 0x28A2890 Offset: 0x28A2991 VA: 0x28A2890
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetResult
	|
	|-RVA: 0x28A2B50 Offset: 0x28A2C51 VA: 0x28A2B50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetResult
	|
	|-RVA: 0x28A2DC0 Offset: 0x28A2EC1 VA: 0x28A2DC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetResult
	|
	|-RVA: 0x28A3090 Offset: 0x28A3191 VA: 0x28A3090
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetResult
	|
	|-RVA: 0x28A3360 Offset: 0x28A3461 VA: 0x28A3360
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetResult
	|
	|-RVA: 0x28A3640 Offset: 0x28A3741 VA: 0x28A3640
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetResult
	|
	|-RVA: 0x28A3930 Offset: 0x28A3A31 VA: 0x28A3930
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetResult
	|
	|-RVA: 0x28A3C30 Offset: 0x28A3D31 VA: 0x28A3C30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x28A3F40 Offset: 0x28A4041 VA: 0x28A3F40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x28A4270 Offset: 0x28A4371 VA: 0x28A4270
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x28A45B0 Offset: 0x28A46B1 VA: 0x28A45B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x28A4900 Offset: 0x28A4A01 VA: 0x28A4900
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x28A4BE0 Offset: 0x28A4CE1 VA: 0x28A4BE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetResult
	|
	|-RVA: 0x28A4E30 Offset: 0x28A4F31 VA: 0x28A4E30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetResult
	|
	|-RVA: 0x28A50B0 Offset: 0x28A51B1 VA: 0x28A50B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetResult
	|
	|-RVA: 0x28A5360 Offset: 0x28A5461 VA: 0x28A5360
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetResult
	|
	|-RVA: 0x28A55D0 Offset: 0x28A56D1 VA: 0x28A55D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetResult
	|
	|-RVA: 0x28A58A0 Offset: 0x28A59A1 VA: 0x28A58A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetResult
	|
	|-RVA: 0x28A5B70 Offset: 0x28A5C71 VA: 0x28A5B70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetResult
	|
	|-RVA: 0x28A5E30 Offset: 0x28A5F31 VA: 0x28A5E30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetResult
	|
	|-RVA: 0x28A6110 Offset: 0x28A6211 VA: 0x28A6110
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x28A63E0 Offset: 0x28A64E1 VA: 0x28A63E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetResult
	|
	|-RVA: 0x28A66A0 Offset: 0x28A67A1 VA: 0x28A66A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetResult
	|
	|-RVA: 0x28A6960 Offset: 0x28A6A61 VA: 0x28A6960
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetResult
	|
	|-RVA: 0x28A6C20 Offset: 0x28A6D21 VA: 0x28A6C20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetResult
	|
	|-RVA: 0x28A6ED0 Offset: 0x28A6FD1 VA: 0x28A6ED0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetResult
	|
	|-RVA: 0x28A7140 Offset: 0x28A7241 VA: 0x28A7140
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetResult
	|
	|-RVA: 0x28A73F0 Offset: 0x28A74F1 VA: 0x28A73F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetResult
	|
	|-RVA: 0x28A76C0 Offset: 0x28A77C1 VA: 0x28A76C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetResult
	|
	|-RVA: 0x28A7990 Offset: 0x28A7A91 VA: 0x28A7990
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetResult
	|
	|-RVA: 0x28A7C70 Offset: 0x28A7D71 VA: 0x28A7C70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetResult
	|
	|-RVA: 0x28A7F80 Offset: 0x28A8081 VA: 0x28A7F80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x28A8280 Offset: 0x28A8381 VA: 0x28A8280
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetResult
	|
	|-RVA: 0x28A85B0 Offset: 0x28A86B1 VA: 0x28A85B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x28A88D0 Offset: 0x28A89D1 VA: 0x28A88D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x28A8C10 Offset: 0x28A8D11 VA: 0x28A8C10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x28A8F60 Offset: 0x28A9061 VA: 0x28A8F60
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x28A92C0 Offset: 0x28A93C1 VA: 0x28A92C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x28A9620 Offset: 0x28A9721 VA: 0x28A9620
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x28A9930 Offset: 0x28A9A31 VA: 0x28A9930
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x28A9C80 Offset: 0x28A9D81 VA: 0x28A9C80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x28A9F60 Offset: 0x28AA061 VA: 0x28A9F60
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetResult
	|
	|-RVA: 0x28AA1B0 Offset: 0x28AA2B1 VA: 0x28AA1B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetResult
	|
	|-RVA: 0x28AA430 Offset: 0x28AA531 VA: 0x28AA430
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetResult
	|
	|-RVA: 0x28AA6E0 Offset: 0x28AA7E1 VA: 0x28AA6E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetResult
	|
	|-RVA: 0x28AA950 Offset: 0x28AAA51 VA: 0x28AA950
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetResult
	|
	|-RVA: 0x28AAC20 Offset: 0x28AAD21 VA: 0x28AAC20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetResult
	|
	|-RVA: 0x28AAEE0 Offset: 0x28AAFE1 VA: 0x28AAEE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetResult
	|
	|-RVA: 0x28AB160 Offset: 0x28AB261 VA: 0x28AB160
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetResult
	|
	|-RVA: 0x28AB430 Offset: 0x28AB531 VA: 0x28AB430
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2AC1F30 Offset: 0x2AC2031 VA: 0x2AC1F30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetResult
	|
	|-RVA: 0x2AC2200 Offset: 0x2AC2301 VA: 0x2AC2200
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetResult
	|
	|-RVA: 0x2AC24D0 Offset: 0x2AC25D1 VA: 0x2AC24D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetResult
	|
	|-RVA: 0x2AC2760 Offset: 0x2AC2861 VA: 0x2AC2760
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetResult
	|
	|-RVA: 0x2AC2A00 Offset: 0x2AC2B01 VA: 0x2AC2A00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetResult
	|
	|-RVA: 0x2AC2C70 Offset: 0x2AC2D71 VA: 0x2AC2C70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetResult
	|
	|-RVA: 0x2AC2F20 Offset: 0x2AC3021 VA: 0x2AC2F20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetResult
	|
	|-RVA: 0x2AC31D0 Offset: 0x2AC32D1 VA: 0x2AC31D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetResult
	|
	|-RVA: 0x2AC34B0 Offset: 0x2AC35B1 VA: 0x2AC34B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetResult
	|
	|-RVA: 0x2AC3770 Offset: 0x2AC3871 VA: 0x2AC3770
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetResult
	|
	|-RVA: 0x2AC3A50 Offset: 0x2AC3B51 VA: 0x2AC3A50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2AC3D40 Offset: 0x2AC3E41 VA: 0x2AC3D40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetResult
	|
	|-RVA: 0x2AC4050 Offset: 0x2AC4151 VA: 0x2AC4050
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2AC4360 Offset: 0x2AC4461 VA: 0x2AC4360
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x2AC4690 Offset: 0x2AC4791 VA: 0x2AC4690
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2AC49B0 Offset: 0x2AC4AB1 VA: 0x2AC49B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x2AC4CF0 Offset: 0x2AC4DF1 VA: 0x2AC4CF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2AC5040 Offset: 0x2AC5141 VA: 0x2AC5040
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x2AC53A0 Offset: 0x2AC54A1 VA: 0x2AC53A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2AC5700 Offset: 0x2AC5801 VA: 0x2AC5700
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x2AC5A10 Offset: 0x2AC5B11 VA: 0x2AC5A10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2AC5CF0 Offset: 0x2AC5DF1 VA: 0x2AC5CF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2AC5FA0 Offset: 0x2AC60A1 VA: 0x2AC5FA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetResult
	|
	|-RVA: 0x2AC61F0 Offset: 0x2AC62F1 VA: 0x2AC61F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, bool>>>.GetResult
	|
	|-RVA: 0x2AC6460 Offset: 0x2AC6561 VA: 0x2AC6460
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetResult
	|
	|-RVA: 0x2AC6700 Offset: 0x2AC6801 VA: 0x2AC6700
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, byte>>>.GetResult
	|
	|-RVA: 0x2AC6970 Offset: 0x2AC6A71 VA: 0x2AC6970
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Color>>>.GetResult
	|
	|-RVA: 0x2AC6C20 Offset: 0x2AC6D21 VA: 0x2AC6C20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, double>>>.GetResult
	|
	|-RVA: 0x2AC6ED0 Offset: 0x2AC6FD1 VA: 0x2AC6ED0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, int>>>.GetResult
	|
	|-RVA: 0x2AC7150 Offset: 0x2AC7251 VA: 0x2AC7150
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, long>>>.GetResult
	|
	|-RVA: 0x2AC7400 Offset: 0x2AC7501 VA: 0x2AC7400
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2AC76B0 Offset: 0x2AC77B1 VA: 0x2AC76B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetResult
	|
	|-RVA: 0x2AC7960 Offset: 0x2AC7A61 VA: 0x2AC7960
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetResult
	|
	|-RVA: 0x2AC7C10 Offset: 0x2AC7D11 VA: 0x2AC7C10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, float>>>.GetResult
	|
	|-RVA: 0x2AC7E90 Offset: 0x2AC7F91 VA: 0x2AC7E90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetResult
	|
	|-RVA: 0x2AC8120 Offset: 0x2AC8221 VA: 0x2AC8120
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetResult
	|
	|-RVA: 0x2AC8390 Offset: 0x2AC8491 VA: 0x2AC8390
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetResult
	|
	|-RVA: 0x2AC8610 Offset: 0x2AC8711 VA: 0x2AC8610
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetResult
	|
	|-RVA: 0x2AC88C0 Offset: 0x2AC89C1 VA: 0x2AC88C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetResult
	|
	|-RVA: 0x2AC8B70 Offset: 0x2AC8C71 VA: 0x2AC8B70
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, object>>>.GetResult
	|
	|-RVA: 0x2AC8E20 Offset: 0x2AC8F21 VA: 0x2AC8E20
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object>>>.GetResult
	|
	|-RVA: 0x2AC90E0 Offset: 0x2AC91E1 VA: 0x2AC90E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2AC93D0 Offset: 0x2AC94D1 VA: 0x2AC93D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object>>>.GetResult
	|
	|-RVA: 0x2AC96D0 Offset: 0x2AC97D1 VA: 0x2AC96D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2AC99D0 Offset: 0x2AC9AD1 VA: 0x2AC99D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetResult
	|
	|-RVA: 0x2AC9CF0 Offset: 0x2AC9DF1 VA: 0x2AC9CF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2ACA000 Offset: 0x2ACA101 VA: 0x2ACA000
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x2ACA340 Offset: 0x2ACA441 VA: 0x2ACA340
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2ACA670 Offset: 0x2ACA771 VA: 0x2ACA670
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x2ACA9C0 Offset: 0x2ACAAC1 VA: 0x2ACA9C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2ACAD30 Offset: 0x2ACAE31 VA: 0x2ACAD30
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x2ACB030 Offset: 0x2ACB131 VA: 0x2ACB030
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2ACB340 Offset: 0x2ACB441 VA: 0x2ACB340
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2ACB5F0 Offset: 0x2ACB6F1 VA: 0x2ACB5F0
	|-LazyPromise<ValueTuple<bool, AsyncUnit>>.GetResult
	|
	|-RVA: 0x2ACB840 Offset: 0x2ACB941 VA: 0x2ACB840
	|-LazyPromise<ValueTuple<bool, bool>>.GetResult
	|
	|-RVA: 0x2ACBAB0 Offset: 0x2ACBBB1 VA: 0x2ACBAB0
	|-LazyPromise<ValueTuple<bool, Bounds>>.GetResult
	|
	|-RVA: 0x2ACBD60 Offset: 0x2ACBE61 VA: 0x2ACBD60
	|-LazyPromise<ValueTuple<bool, byte>>.GetResult
	|
	|-RVA: 0x2ACBFD0 Offset: 0x2ACC0D1 VA: 0x2ACBFD0
	|-LazyPromise<ValueTuple<bool, Color>>.GetResult
	|
	|-RVA: 0x2ACC280 Offset: 0x2ACC381 VA: 0x2ACC280
	|-LazyPromise<ValueTuple<bool, double>>.GetResult
	|
	|-RVA: 0x2ACC4E0 Offset: 0x2ACC5E1 VA: 0x2ACC4E0
	|-LazyPromise<ValueTuple<bool, int>>.GetResult
	|
	|-RVA: 0x2ACC750 Offset: 0x2ACC851 VA: 0x2ACC750
	|-LazyPromise<ValueTuple<bool, long>>.GetResult
	|
	|-RVA: 0x2ACC9D0 Offset: 0x2ACCAD1 VA: 0x2ACC9D0
	|-LazyPromise<ValueTuple<bool, object>>.GetResult
	|
	|-RVA: 0x2ACCC50 Offset: 0x2ACCD51 VA: 0x2ACCC50
	|-LazyPromise<ValueTuple<bool, Quaternion>>.GetResult
	|
	|-RVA: 0x2ACCF00 Offset: 0x2ACD001 VA: 0x2ACCF00
	|-LazyPromise<ValueTuple<bool, Rect>>.GetResult
	|
	|-RVA: 0x2ACD190 Offset: 0x2ACD291 VA: 0x2ACD190
	|-LazyPromise<ValueTuple<bool, float>>.GetResult
	|
	|-RVA: 0x2ACD400 Offset: 0x2ACD501 VA: 0x2ACD400
	|-LazyPromise<ValueTuple<bool, UniTask>>.GetResult
	|
	|-RVA: 0x2ACD660 Offset: 0x2ACD761 VA: 0x2ACD660
	|-LazyPromise<ValueTuple<bool, Unit>>.GetResult
	|
	|-RVA: 0x2ACD8D0 Offset: 0x2ACD9D1 VA: 0x2ACD8D0
	|-LazyPromise<ValueTuple<bool, Vector2>>.GetResult
	|
	|-RVA: 0x2ACDB50 Offset: 0x2ACDC51 VA: 0x2ACDB50
	|-LazyPromise<ValueTuple<bool, Vector3>>.GetResult
	|
	|-RVA: 0x2ACDDD0 Offset: 0x2ACDED1 VA: 0x2ACDDD0
	|-LazyPromise<ValueTuple<bool, Vector4>>.GetResult
	|
	|-RVA: 0x2ACE080 Offset: 0x2ACE181 VA: 0x2ACE080
	|-LazyPromise<ValueTuple<int, object>>.GetResult
	|
	|-RVA: 0x2ACE300 Offset: 0x2ACE401 VA: 0x2ACE300
	|-LazyPromise<ValueTuple<object, object>>.GetResult
	|
	|-RVA: 0x2ACE590 Offset: 0x2ACE691 VA: 0x2ACE590
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2ACE860 Offset: 0x2ACE961 VA: 0x2ACE860
	|-LazyPromise<ValueTuple<object, object, object>>.GetResult
	|
	|-RVA: 0x2ACEB30 Offset: 0x2ACEC31 VA: 0x2ACEB30
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2ACEE10 Offset: 0x2ACEF11 VA: 0x2ACEE10
	|-LazyPromise<ValueTuple<object, object, object, object>>.GetResult
	|
	|-RVA: 0x2ACF100 Offset: 0x2ACF201 VA: 0x2ACF100
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2ACF410 Offset: 0x2ACF511 VA: 0x2ACF410
	|-LazyPromise<ValueTuple<object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x2ACF730 Offset: 0x2ACF831 VA: 0x2ACF730
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2ACFA40 Offset: 0x2ACFB41 VA: 0x2ACFA40
	|-LazyPromise<ValueTuple<object, object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x2ACFD80 Offset: 0x2ACFE81 VA: 0x2ACFD80
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2AD00C0 Offset: 0x2AD01C1 VA: 0x2AD00C0
	|-LazyPromise<ValueTuple<object, object, object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x2AD0410 Offset: 0x2AD0511 VA: 0x2AD0410
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2AD0750 Offset: 0x2AD0851 VA: 0x2AD0750
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2AD0A00 Offset: 0x2AD0B01 VA: 0x2AD0A00
	|-LazyPromise<AsyncUnit>.GetResult
	|
	|-RVA: 0x2AD0C50 Offset: 0x2AD0D51 VA: 0x2AD0C50
	|-LazyPromise<bool>.GetResult
	|
	|-RVA: 0x2AD0EC0 Offset: 0x2AD0FC1 VA: 0x2AD0EC0
	|-LazyPromise<Bounds>.GetResult
	|
	|-RVA: 0x2AD1150 Offset: 0x2AD1251 VA: 0x2AD1150
	|-LazyPromise<byte>.GetResult
	|
	|-RVA: 0x2AD13C0 Offset: 0x2AD14C1 VA: 0x2AD13C0
	|-LazyPromise<Color>.GetResult
	|
	|-RVA: 0x2AD1620 Offset: 0x2AD1721 VA: 0x2AD1620
	|-LazyPromise<double>.GetResult
	|
	|-RVA: 0x2AD1870 Offset: 0x2AD1971 VA: 0x2AD1870
	|-LazyPromise<int>.GetResult
	|
	|-RVA: 0x2AD1AC0 Offset: 0x2AD1BC1 VA: 0x2AD1AC0
	|-LazyPromise<long>.GetResult
	|
	|-RVA: 0x2AD1D10 Offset: 0x2AD1E11 VA: 0x2AD1D10
	|-LazyPromise<object>.GetResult
	|
	|-RVA: 0x2AD1F80 Offset: 0x2AD2081 VA: 0x2AD1F80
	|-LazyPromise<Quaternion>.GetResult
	|
	|-RVA: 0x2AD2200 Offset: 0x2AD2301 VA: 0x2AD2200
	|-LazyPromise<Rect>.GetResult
	|
	|-RVA: 0x2AD2460 Offset: 0x2AD2561 VA: 0x2AD2460
	|-LazyPromise<float>.GetResult
	|
	|-RVA: 0x2AD26B0 Offset: 0x2AD27B1 VA: 0x2AD26B0
	|-LazyPromise<UniTask>.GetResult
	|
	|-RVA: 0x2AD2900 Offset: 0x2AD2A01 VA: 0x2AD2900
	|-LazyPromise<Unit>.GetResult
	|
	|-RVA: 0x2AD2B50 Offset: 0x2AD2C51 VA: 0x2AD2B50
	|-LazyPromise<Vector2>.GetResult
	|
	|-RVA: 0x2AD2DC0 Offset: 0x2AD2EC1 VA: 0x2AD2DC0
	|-LazyPromise<Vector3>.GetResult
	|
	|-RVA: 0x2AD3040 Offset: 0x2AD3141 VA: 0x2AD3040
	|-LazyPromise<Vector4>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289FA60 Offset: 0x289FB61 VA: 0x289FA60
	|-LazyPromise<UniTask<object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x289FD00 Offset: 0x289FE01 VA: 0x289FD00
	|-LazyPromise<ValueTuple<bool, UniTask<object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x289FFB0 Offset: 0x28A00B1 VA: 0x289FFB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A0290 Offset: 0x28A0391 VA: 0x28A0290
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A0570 Offset: 0x28A0671 VA: 0x28A0570
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A0800 Offset: 0x28A0901 VA: 0x28A0800
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A0A50 Offset: 0x28A0B51 VA: 0x28A0A50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A0D00 Offset: 0x28A0E01 VA: 0x28A0D00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A0F90 Offset: 0x28A1091 VA: 0x28A0F90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A1240 Offset: 0x28A1341 VA: 0x28A1240
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A1520 Offset: 0x28A1621 VA: 0x28A1520
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A17F0 Offset: 0x28A18F1 VA: 0x28A17F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A1AC0 Offset: 0x28A1BC1 VA: 0x28A1AC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A1DB0 Offset: 0x28A1EB1 VA: 0x28A1DB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A20A0 Offset: 0x28A21A1 VA: 0x28A20A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A2380 Offset: 0x28A2481 VA: 0x28A2380
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A2640 Offset: 0x28A2741 VA: 0x28A2640
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A2910 Offset: 0x28A2A11 VA: 0x28A2910
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A2BA0 Offset: 0x28A2CA1 VA: 0x28A2BA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A2E40 Offset: 0x28A2F41 VA: 0x28A2E40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A3100 Offset: 0x28A3201 VA: 0x28A3100
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A33E0 Offset: 0x28A34E1 VA: 0x28A33E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A36C0 Offset: 0x28A37C1 VA: 0x28A36C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A39B0 Offset: 0x28A3AB1 VA: 0x28A39B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A3CB0 Offset: 0x28A3DB1 VA: 0x28A3CB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A3FC0 Offset: 0x28A40C1 VA: 0x28A3FC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A4300 Offset: 0x28A4401 VA: 0x28A4300
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A4640 Offset: 0x28A4741 VA: 0x28A4640
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A4990 Offset: 0x28A4A91 VA: 0x28A4990
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A4C30 Offset: 0x28A4D31 VA: 0x28A4C30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A4E80 Offset: 0x28A4F81 VA: 0x28A4E80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A5130 Offset: 0x28A5231 VA: 0x28A5130
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A53B0 Offset: 0x28A54B1 VA: 0x28A53B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A5640 Offset: 0x28A5741 VA: 0x28A5640
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A5920 Offset: 0x28A5A21 VA: 0x28A5920
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A5BE0 Offset: 0x28A5CE1 VA: 0x28A5BE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A5EB0 Offset: 0x28A5FB1 VA: 0x28A5EB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A6190 Offset: 0x28A6291 VA: 0x28A6190
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A6450 Offset: 0x28A6551 VA: 0x28A6450
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A6710 Offset: 0x28A6811 VA: 0x28A6710
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A69D0 Offset: 0x28A6AD1 VA: 0x28A69D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A6CA0 Offset: 0x28A6DA1 VA: 0x28A6CA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A6F20 Offset: 0x28A7021 VA: 0x28A6F20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A71B0 Offset: 0x28A72B1 VA: 0x28A71B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A7470 Offset: 0x28A7571 VA: 0x28A7470
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A7730 Offset: 0x28A7831 VA: 0x28A7730
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A7A10 Offset: 0x28A7B11 VA: 0x28A7A10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A7CF0 Offset: 0x28A7DF1 VA: 0x28A7CF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A8000 Offset: 0x28A8101 VA: 0x28A8000
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A8300 Offset: 0x28A8401 VA: 0x28A8300
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A8640 Offset: 0x28A8741 VA: 0x28A8640
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A8950 Offset: 0x28A8A51 VA: 0x28A8950
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A8CA0 Offset: 0x28A8DA1 VA: 0x28A8CA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A8FE0 Offset: 0x28A90E1 VA: 0x28A8FE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A9360 Offset: 0x28A9461 VA: 0x28A9360
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A96B0 Offset: 0x28A97B1 VA: 0x28A96B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A99D0 Offset: 0x28A9AD1 VA: 0x28A99D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A9D10 Offset: 0x28A9E11 VA: 0x28A9D10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28A9FB0 Offset: 0x28AA0B1 VA: 0x28A9FB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28AA200 Offset: 0x28AA301 VA: 0x28AA200
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28AA4B0 Offset: 0x28AA5B1 VA: 0x28AA4B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28AA730 Offset: 0x28AA831 VA: 0x28AA730
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28AA9D0 Offset: 0x28AAAD1 VA: 0x28AA9D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28AAC90 Offset: 0x28AAD91 VA: 0x28AAC90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28AAF30 Offset: 0x28AB031 VA: 0x28AAF30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28AB1D0 Offset: 0x28AB2D1 VA: 0x28AB1D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x28AB4A0 Offset: 0x28AB5A1 VA: 0x28AB4A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC1FB0 Offset: 0x2AC20B1 VA: 0x2AC1FB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC2280 Offset: 0x2AC2381 VA: 0x2AC2280
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC2520 Offset: 0x2AC2621 VA: 0x2AC2520
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC27D0 Offset: 0x2AC28D1 VA: 0x2AC27D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC2A50 Offset: 0x2AC2B51 VA: 0x2AC2A50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC2CE0 Offset: 0x2AC2DE1 VA: 0x2AC2CE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC2F90 Offset: 0x2AC3091 VA: 0x2AC2F90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC3250 Offset: 0x2AC3351 VA: 0x2AC3250
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC3520 Offset: 0x2AC3621 VA: 0x2AC3520
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC37E0 Offset: 0x2AC38E1 VA: 0x2AC37E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC3AD0 Offset: 0x2AC3BD1 VA: 0x2AC3AD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC3DC0 Offset: 0x2AC3EC1 VA: 0x2AC3DC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC40E0 Offset: 0x2AC41E1 VA: 0x2AC40E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC43E0 Offset: 0x2AC44E1 VA: 0x2AC43E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC4720 Offset: 0x2AC4821 VA: 0x2AC4720
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC4A30 Offset: 0x2AC4B31 VA: 0x2AC4A30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC4D90 Offset: 0x2AC4E91 VA: 0x2AC4D90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC50C0 Offset: 0x2AC51C1 VA: 0x2AC50C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC5440 Offset: 0x2AC5541 VA: 0x2AC5440
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC5790 Offset: 0x2AC5891 VA: 0x2AC5790
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC5A80 Offset: 0x2AC5B81 VA: 0x2AC5A80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC5D60 Offset: 0x2AC5E61 VA: 0x2AC5D60
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC5FF0 Offset: 0x2AC60F1 VA: 0x2AC5FF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC6240 Offset: 0x2AC6341 VA: 0x2AC6240
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, bool>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC64D0 Offset: 0x2AC65D1 VA: 0x2AC64D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Bounds>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC6750 Offset: 0x2AC6851 VA: 0x2AC6750
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, byte>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC69E0 Offset: 0x2AC6AE1 VA: 0x2AC69E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Color>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC6C90 Offset: 0x2AC6D91 VA: 0x2AC6C90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, double>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC6F20 Offset: 0x2AC7021 VA: 0x2AC6F20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, int>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC71C0 Offset: 0x2AC72C1 VA: 0x2AC71C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, long>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC7470 Offset: 0x2AC7571 VA: 0x2AC7470
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC7720 Offset: 0x2AC7821 VA: 0x2AC7720
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC79D0 Offset: 0x2AC7AD1 VA: 0x2AC79D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Rect>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC7C60 Offset: 0x2AC7D61 VA: 0x2AC7C60
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, float>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC7F00 Offset: 0x2AC8001 VA: 0x2AC7F00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC8170 Offset: 0x2AC8271 VA: 0x2AC8170
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Unit>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC83E0 Offset: 0x2AC84E1 VA: 0x2AC83E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector2>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC8680 Offset: 0x2AC8781 VA: 0x2AC8680
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector3>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC8930 Offset: 0x2AC8A31 VA: 0x2AC8930
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector4>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC8BE0 Offset: 0x2AC8CE1 VA: 0x2AC8BE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC8E90 Offset: 0x2AC8F91 VA: 0x2AC8E90
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC9160 Offset: 0x2AC9261 VA: 0x2AC9160
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC9440 Offset: 0x2AC9541 VA: 0x2AC9440
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC9750 Offset: 0x2AC9851 VA: 0x2AC9750
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC9A50 Offset: 0x2AC9B51 VA: 0x2AC9A50
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AC9D80 Offset: 0x2AC9E81 VA: 0x2AC9D80
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACA080 Offset: 0x2ACA181 VA: 0x2ACA080
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACA3D0 Offset: 0x2ACA4D1 VA: 0x2ACA3D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACA6F0 Offset: 0x2ACA7F1 VA: 0x2ACA6F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACAA60 Offset: 0x2ACAB61 VA: 0x2ACAA60
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACADB0 Offset: 0x2ACAEB1 VA: 0x2ACADB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACB0D0 Offset: 0x2ACB1D1 VA: 0x2ACB0D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACB3B0 Offset: 0x2ACB4B1 VA: 0x2ACB3B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACB640 Offset: 0x2ACB741 VA: 0x2ACB640
	|-LazyPromise<ValueTuple<bool, AsyncUnit>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACB890 Offset: 0x2ACB991 VA: 0x2ACB890
	|-LazyPromise<ValueTuple<bool, bool>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACBB30 Offset: 0x2ACBC31 VA: 0x2ACBB30
	|-LazyPromise<ValueTuple<bool, Bounds>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACBDB0 Offset: 0x2ACBEB1 VA: 0x2ACBDB0
	|-LazyPromise<ValueTuple<bool, byte>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACC040 Offset: 0x2ACC141 VA: 0x2ACC040
	|-LazyPromise<ValueTuple<bool, Color>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACC2D0 Offset: 0x2ACC3D1 VA: 0x2ACC2D0
	|-LazyPromise<ValueTuple<bool, double>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACC530 Offset: 0x2ACC631 VA: 0x2ACC530
	|-LazyPromise<ValueTuple<bool, int>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACC7A0 Offset: 0x2ACC8A1 VA: 0x2ACC7A0
	|-LazyPromise<ValueTuple<bool, long>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACCA20 Offset: 0x2ACCB21 VA: 0x2ACCA20
	|-LazyPromise<ValueTuple<bool, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACCCC0 Offset: 0x2ACCDC1 VA: 0x2ACCCC0
	|-LazyPromise<ValueTuple<bool, Quaternion>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACCF70 Offset: 0x2ACD071 VA: 0x2ACCF70
	|-LazyPromise<ValueTuple<bool, Rect>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACD1E0 Offset: 0x2ACD2E1 VA: 0x2ACD1E0
	|-LazyPromise<ValueTuple<bool, float>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACD450 Offset: 0x2ACD551 VA: 0x2ACD450
	|-LazyPromise<ValueTuple<bool, UniTask>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACD6B0 Offset: 0x2ACD7B1 VA: 0x2ACD6B0
	|-LazyPromise<ValueTuple<bool, Unit>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACD920 Offset: 0x2ACDA21 VA: 0x2ACD920
	|-LazyPromise<ValueTuple<bool, Vector2>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACDBA0 Offset: 0x2ACDCA1 VA: 0x2ACDBA0
	|-LazyPromise<ValueTuple<bool, Vector3>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACDE40 Offset: 0x2ACDF41 VA: 0x2ACDE40
	|-LazyPromise<ValueTuple<bool, Vector4>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACE0D0 Offset: 0x2ACE1D1 VA: 0x2ACE0D0
	|-LazyPromise<ValueTuple<int, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACE350 Offset: 0x2ACE451 VA: 0x2ACE350
	|-LazyPromise<ValueTuple<object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACE610 Offset: 0x2ACE711 VA: 0x2ACE610
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACE8D0 Offset: 0x2ACE9D1 VA: 0x2ACE8D0
	|-LazyPromise<ValueTuple<object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACEBB0 Offset: 0x2ACECB1 VA: 0x2ACEBB0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACEE80 Offset: 0x2ACEF81 VA: 0x2ACEE80
	|-LazyPromise<ValueTuple<object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACF190 Offset: 0x2ACF291 VA: 0x2ACF190
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACF490 Offset: 0x2ACF591 VA: 0x2ACF490
	|-LazyPromise<ValueTuple<object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACF7C0 Offset: 0x2ACF8C1 VA: 0x2ACF7C0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACFAC0 Offset: 0x2ACFBC1 VA: 0x2ACFAC0
	|-LazyPromise<ValueTuple<object, object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2ACFE20 Offset: 0x2ACFF21 VA: 0x2ACFE20
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD0140 Offset: 0x2AD0241 VA: 0x2AD0140
	|-LazyPromise<ValueTuple<object, object, object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD04B0 Offset: 0x2AD05B1 VA: 0x2AD04B0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD07C0 Offset: 0x2AD08C1 VA: 0x2AD07C0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD0A50 Offset: 0x2AD0B51 VA: 0x2AD0A50
	|-LazyPromise<AsyncUnit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD0CA0 Offset: 0x2AD0DA1 VA: 0x2AD0CA0
	|-LazyPromise<bool>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD0F30 Offset: 0x2AD1031 VA: 0x2AD0F30
	|-LazyPromise<Bounds>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD11A0 Offset: 0x2AD12A1 VA: 0x2AD11A0
	|-LazyPromise<byte>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD1410 Offset: 0x2AD1511 VA: 0x2AD1410
	|-LazyPromise<Color>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD1670 Offset: 0x2AD1771 VA: 0x2AD1670
	|-LazyPromise<double>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD18C0 Offset: 0x2AD19C1 VA: 0x2AD18C0
	|-LazyPromise<int>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD1B10 Offset: 0x2AD1C11 VA: 0x2AD1B10
	|-LazyPromise<long>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD1D60 Offset: 0x2AD1E61 VA: 0x2AD1D60
	|-LazyPromise<object>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD1FD0 Offset: 0x2AD20D1 VA: 0x2AD1FD0
	|-LazyPromise<Quaternion>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD2250 Offset: 0x2AD2351 VA: 0x2AD2250
	|-LazyPromise<Rect>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD24B0 Offset: 0x2AD25B1 VA: 0x2AD24B0
	|-LazyPromise<float>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD2700 Offset: 0x2AD2801 VA: 0x2AD2700
	|-LazyPromise<UniTask>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD2950 Offset: 0x2AD2A51 VA: 0x2AD2950
	|-LazyPromise<Unit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD2BA0 Offset: 0x2AD2CA1 VA: 0x2AD2BA0
	|-LazyPromise<Vector2>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD2E10 Offset: 0x2AD2F11 VA: 0x2AD2E10
	|-LazyPromise<Vector3>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2AD3090 Offset: 0x2AD3191 VA: 0x2AD3090
	|-LazyPromise<Vector4>.UniRx.Async.IAwaiter.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289FA80 Offset: 0x289FB81 VA: 0x289FA80
	|-LazyPromise<UniTask<object>>.UnsafeOnCompleted
	|
	|-RVA: 0x289FD30 Offset: 0x289FE31 VA: 0x289FD30
	|-LazyPromise<ValueTuple<bool, UniTask<object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x289FFE0 Offset: 0x28A00E1 VA: 0x289FFE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A02C0 Offset: 0x28A03C1 VA: 0x28A02C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A05A0 Offset: 0x28A06A1 VA: 0x28A05A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A0820 Offset: 0x28A0921 VA: 0x28A0820
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A0A70 Offset: 0x28A0B71 VA: 0x28A0A70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A0D30 Offset: 0x28A0E31 VA: 0x28A0D30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A0FB0 Offset: 0x28A10B1 VA: 0x28A0FB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A1270 Offset: 0x28A1371 VA: 0x28A1270
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A1550 Offset: 0x28A1651 VA: 0x28A1550
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A1820 Offset: 0x28A1921 VA: 0x28A1820
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A1AF0 Offset: 0x28A1BF1 VA: 0x28A1AF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A1DE0 Offset: 0x28A1EE1 VA: 0x28A1DE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A20D0 Offset: 0x28A21D1 VA: 0x28A20D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A23B0 Offset: 0x28A24B1 VA: 0x28A23B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A2670 Offset: 0x28A2771 VA: 0x28A2670
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A2940 Offset: 0x28A2A41 VA: 0x28A2940
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A2BC0 Offset: 0x28A2CC1 VA: 0x28A2BC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A2E70 Offset: 0x28A2F71 VA: 0x28A2E70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A3130 Offset: 0x28A3231 VA: 0x28A3130
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A3410 Offset: 0x28A3511 VA: 0x28A3410
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A36F0 Offset: 0x28A37F1 VA: 0x28A36F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A39E0 Offset: 0x28A3AE1 VA: 0x28A39E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A3CE0 Offset: 0x28A3DE1 VA: 0x28A3CE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A3FF0 Offset: 0x28A40F1 VA: 0x28A3FF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A4330 Offset: 0x28A4431 VA: 0x28A4330
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A4670 Offset: 0x28A4771 VA: 0x28A4670
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A49C0 Offset: 0x28A4AC1 VA: 0x28A49C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A4C50 Offset: 0x28A4D51 VA: 0x28A4C50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A4EA0 Offset: 0x28A4FA1 VA: 0x28A4EA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A5160 Offset: 0x28A5261 VA: 0x28A5160
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A53D0 Offset: 0x28A54D1 VA: 0x28A53D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A5670 Offset: 0x28A5771 VA: 0x28A5670
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A5950 Offset: 0x28A5A51 VA: 0x28A5950
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A5C10 Offset: 0x28A5D11 VA: 0x28A5C10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A5EE0 Offset: 0x28A5FE1 VA: 0x28A5EE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A61C0 Offset: 0x28A62C1 VA: 0x28A61C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A6480 Offset: 0x28A6581 VA: 0x28A6480
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A6740 Offset: 0x28A6841 VA: 0x28A6740
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A6A00 Offset: 0x28A6B01 VA: 0x28A6A00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A6CD0 Offset: 0x28A6DD1 VA: 0x28A6CD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A6F40 Offset: 0x28A7041 VA: 0x28A6F40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A71E0 Offset: 0x28A72E1 VA: 0x28A71E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A74A0 Offset: 0x28A75A1 VA: 0x28A74A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A7760 Offset: 0x28A7861 VA: 0x28A7760
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A7A40 Offset: 0x28A7B41 VA: 0x28A7A40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A7D20 Offset: 0x28A7E21 VA: 0x28A7D20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A8030 Offset: 0x28A8131 VA: 0x28A8030
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A8330 Offset: 0x28A8431 VA: 0x28A8330
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A8670 Offset: 0x28A8771 VA: 0x28A8670
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A8980 Offset: 0x28A8A81 VA: 0x28A8980
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A8CD0 Offset: 0x28A8DD1 VA: 0x28A8CD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A9010 Offset: 0x28A9111 VA: 0x28A9010
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A9390 Offset: 0x28A9491 VA: 0x28A9390
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A96E0 Offset: 0x28A97E1 VA: 0x28A96E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A9A00 Offset: 0x28A9B01 VA: 0x28A9A00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A9D40 Offset: 0x28A9E41 VA: 0x28A9D40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28A9FD0 Offset: 0x28AA0D1 VA: 0x28A9FD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28AA220 Offset: 0x28AA321 VA: 0x28AA220
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28AA4E0 Offset: 0x28AA5E1 VA: 0x28AA4E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28AA750 Offset: 0x28AA851 VA: 0x28AA750
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28AAA00 Offset: 0x28AAB01 VA: 0x28AAA00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28AACC0 Offset: 0x28AADC1 VA: 0x28AACC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28AAF50 Offset: 0x28AB051 VA: 0x28AAF50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28AB200 Offset: 0x28AB301 VA: 0x28AB200
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x28AB4D0 Offset: 0x28AB5D1 VA: 0x28AB4D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC1FE0 Offset: 0x2AC20E1 VA: 0x2AC1FE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC22B0 Offset: 0x2AC23B1 VA: 0x2AC22B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC2540 Offset: 0x2AC2641 VA: 0x2AC2540
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC2800 Offset: 0x2AC2901 VA: 0x2AC2800
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC2A70 Offset: 0x2AC2B71 VA: 0x2AC2A70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC2D10 Offset: 0x2AC2E11 VA: 0x2AC2D10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC2FC0 Offset: 0x2AC30C1 VA: 0x2AC2FC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC3280 Offset: 0x2AC3381 VA: 0x2AC3280
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC3550 Offset: 0x2AC3651 VA: 0x2AC3550
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC3810 Offset: 0x2AC3911 VA: 0x2AC3810
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC3B00 Offset: 0x2AC3C01 VA: 0x2AC3B00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC3DF0 Offset: 0x2AC3EF1 VA: 0x2AC3DF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC4110 Offset: 0x2AC4211 VA: 0x2AC4110
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC4410 Offset: 0x2AC4511 VA: 0x2AC4410
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC4750 Offset: 0x2AC4851 VA: 0x2AC4750
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC4A60 Offset: 0x2AC4B61 VA: 0x2AC4A60
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC4DC0 Offset: 0x2AC4EC1 VA: 0x2AC4DC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC50F0 Offset: 0x2AC51F1 VA: 0x2AC50F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC5470 Offset: 0x2AC5571 VA: 0x2AC5470
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC57C0 Offset: 0x2AC58C1 VA: 0x2AC57C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC5AB0 Offset: 0x2AC5BB1 VA: 0x2AC5AB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC5D90 Offset: 0x2AC5E91 VA: 0x2AC5D90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC6010 Offset: 0x2AC6111 VA: 0x2AC6010
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC6260 Offset: 0x2AC6361 VA: 0x2AC6260
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, bool>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC6500 Offset: 0x2AC6601 VA: 0x2AC6500
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Bounds>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC6770 Offset: 0x2AC6871 VA: 0x2AC6770
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, byte>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC6A10 Offset: 0x2AC6B11 VA: 0x2AC6A10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Color>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC6CC0 Offset: 0x2AC6DC1 VA: 0x2AC6CC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, double>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC6F40 Offset: 0x2AC7041 VA: 0x2AC6F40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, int>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC71F0 Offset: 0x2AC72F1 VA: 0x2AC71F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, long>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC74A0 Offset: 0x2AC75A1 VA: 0x2AC74A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC7750 Offset: 0x2AC7851 VA: 0x2AC7750
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC7A00 Offset: 0x2AC7B01 VA: 0x2AC7A00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Rect>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC7C80 Offset: 0x2AC7D81 VA: 0x2AC7C80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, float>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC7F30 Offset: 0x2AC8031 VA: 0x2AC7F30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC8190 Offset: 0x2AC8291 VA: 0x2AC8190
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Unit>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC8400 Offset: 0x2AC8501 VA: 0x2AC8400
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector2>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC86B0 Offset: 0x2AC87B1 VA: 0x2AC86B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector3>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC8960 Offset: 0x2AC8A61 VA: 0x2AC8960
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector4>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC8C10 Offset: 0x2AC8D11 VA: 0x2AC8C10
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC8EC0 Offset: 0x2AC8FC1 VA: 0x2AC8EC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC9190 Offset: 0x2AC9291 VA: 0x2AC9190
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC9470 Offset: 0x2AC9571 VA: 0x2AC9470
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC9780 Offset: 0x2AC9881 VA: 0x2AC9780
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC9A80 Offset: 0x2AC9B81 VA: 0x2AC9A80
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AC9DB0 Offset: 0x2AC9EB1 VA: 0x2AC9DB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACA0B0 Offset: 0x2ACA1B1 VA: 0x2ACA0B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACA400 Offset: 0x2ACA501 VA: 0x2ACA400
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACA720 Offset: 0x2ACA821 VA: 0x2ACA720
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACAA90 Offset: 0x2ACAB91 VA: 0x2ACAA90
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACADE0 Offset: 0x2ACAEE1 VA: 0x2ACADE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACB100 Offset: 0x2ACB201 VA: 0x2ACB100
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACB3E0 Offset: 0x2ACB4E1 VA: 0x2ACB3E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACB660 Offset: 0x2ACB761 VA: 0x2ACB660
	|-LazyPromise<ValueTuple<bool, AsyncUnit>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACB8B0 Offset: 0x2ACB9B1 VA: 0x2ACB8B0
	|-LazyPromise<ValueTuple<bool, bool>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACBB60 Offset: 0x2ACBC61 VA: 0x2ACBB60
	|-LazyPromise<ValueTuple<bool, Bounds>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACBDD0 Offset: 0x2ACBED1 VA: 0x2ACBDD0
	|-LazyPromise<ValueTuple<bool, byte>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACC070 Offset: 0x2ACC171 VA: 0x2ACC070
	|-LazyPromise<ValueTuple<bool, Color>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACC2F0 Offset: 0x2ACC3F1 VA: 0x2ACC2F0
	|-LazyPromise<ValueTuple<bool, double>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACC550 Offset: 0x2ACC651 VA: 0x2ACC550
	|-LazyPromise<ValueTuple<bool, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACC7C0 Offset: 0x2ACC8C1 VA: 0x2ACC7C0
	|-LazyPromise<ValueTuple<bool, long>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACCA40 Offset: 0x2ACCB41 VA: 0x2ACCA40
	|-LazyPromise<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACCCF0 Offset: 0x2ACCDF1 VA: 0x2ACCCF0
	|-LazyPromise<ValueTuple<bool, Quaternion>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACCFA0 Offset: 0x2ACD0A1 VA: 0x2ACCFA0
	|-LazyPromise<ValueTuple<bool, Rect>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACD200 Offset: 0x2ACD301 VA: 0x2ACD200
	|-LazyPromise<ValueTuple<bool, float>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACD470 Offset: 0x2ACD571 VA: 0x2ACD470
	|-LazyPromise<ValueTuple<bool, UniTask>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACD6D0 Offset: 0x2ACD7D1 VA: 0x2ACD6D0
	|-LazyPromise<ValueTuple<bool, Unit>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACD940 Offset: 0x2ACDA41 VA: 0x2ACD940
	|-LazyPromise<ValueTuple<bool, Vector2>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACDBC0 Offset: 0x2ACDCC1 VA: 0x2ACDBC0
	|-LazyPromise<ValueTuple<bool, Vector3>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACDE70 Offset: 0x2ACDF71 VA: 0x2ACDE70
	|-LazyPromise<ValueTuple<bool, Vector4>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACE0F0 Offset: 0x2ACE1F1 VA: 0x2ACE0F0
	|-LazyPromise<ValueTuple<int, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACE370 Offset: 0x2ACE471 VA: 0x2ACE370
	|-LazyPromise<ValueTuple<object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACE640 Offset: 0x2ACE741 VA: 0x2ACE640
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACE900 Offset: 0x2ACEA01 VA: 0x2ACE900
	|-LazyPromise<ValueTuple<object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACEBE0 Offset: 0x2ACECE1 VA: 0x2ACEBE0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACEEB0 Offset: 0x2ACEFB1 VA: 0x2ACEEB0
	|-LazyPromise<ValueTuple<object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACF1C0 Offset: 0x2ACF2C1 VA: 0x2ACF1C0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACF4C0 Offset: 0x2ACF5C1 VA: 0x2ACF4C0
	|-LazyPromise<ValueTuple<object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACF7F0 Offset: 0x2ACF8F1 VA: 0x2ACF7F0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACFAF0 Offset: 0x2ACFBF1 VA: 0x2ACFAF0
	|-LazyPromise<ValueTuple<object, object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2ACFE50 Offset: 0x2ACFF51 VA: 0x2ACFE50
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD0170 Offset: 0x2AD0271 VA: 0x2AD0170
	|-LazyPromise<ValueTuple<object, object, object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD04E0 Offset: 0x2AD05E1 VA: 0x2AD04E0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD07F0 Offset: 0x2AD08F1 VA: 0x2AD07F0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD0A70 Offset: 0x2AD0B71 VA: 0x2AD0A70
	|-LazyPromise<AsyncUnit>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD0CC0 Offset: 0x2AD0DC1 VA: 0x2AD0CC0
	|-LazyPromise<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD0F60 Offset: 0x2AD1061 VA: 0x2AD0F60
	|-LazyPromise<Bounds>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD11C0 Offset: 0x2AD12C1 VA: 0x2AD11C0
	|-LazyPromise<byte>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD1430 Offset: 0x2AD1531 VA: 0x2AD1430
	|-LazyPromise<Color>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD1690 Offset: 0x2AD1791 VA: 0x2AD1690
	|-LazyPromise<double>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD18E0 Offset: 0x2AD19E1 VA: 0x2AD18E0
	|-LazyPromise<int>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD1B30 Offset: 0x2AD1C31 VA: 0x2AD1B30
	|-LazyPromise<long>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD1D80 Offset: 0x2AD1E81 VA: 0x2AD1D80
	|-LazyPromise<object>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD1FF0 Offset: 0x2AD20F1 VA: 0x2AD1FF0
	|-LazyPromise<Quaternion>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD2270 Offset: 0x2AD2371 VA: 0x2AD2270
	|-LazyPromise<Rect>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD24D0 Offset: 0x2AD25D1 VA: 0x2AD24D0
	|-LazyPromise<float>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD2720 Offset: 0x2AD2821 VA: 0x2AD2720
	|-LazyPromise<UniTask>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD2970 Offset: 0x2AD2A71 VA: 0x2AD2970
	|-LazyPromise<Unit>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD2BC0 Offset: 0x2AD2CC1 VA: 0x2AD2BC0
	|-LazyPromise<Vector2>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD2E30 Offset: 0x2AD2F31 VA: 0x2AD2E30
	|-LazyPromise<Vector3>.UnsafeOnCompleted
	|
	|-RVA: 0x2AD30B0 Offset: 0x2AD31B1 VA: 0x2AD30B0
	|-LazyPromise<Vector4>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289FB10 Offset: 0x289FC11 VA: 0x289FB10
	|-LazyPromise<UniTask<object>>.OnCompleted
	|
	|-RVA: 0x289FDC0 Offset: 0x289FEC1 VA: 0x289FDC0
	|-LazyPromise<ValueTuple<bool, UniTask<object>>>.OnCompleted
	|
	|-RVA: 0x28A0080 Offset: 0x28A0181 VA: 0x28A0080
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.OnCompleted
	|
	|-RVA: 0x28A0360 Offset: 0x28A0461 VA: 0x28A0360
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.OnCompleted
	|
	|-RVA: 0x28A0650 Offset: 0x28A0751 VA: 0x28A0650
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A08A0 Offset: 0x28A09A1 VA: 0x28A08A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.OnCompleted
	|
	|-RVA: 0x28A0AF0 Offset: 0x28A0BF1 VA: 0x28A0AF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.OnCompleted
	|
	|-RVA: 0x28A0DE0 Offset: 0x28A0EE1 VA: 0x28A0DE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.OnCompleted
	|
	|-RVA: 0x28A1030 Offset: 0x28A1131 VA: 0x28A1030
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.OnCompleted
	|
	|-RVA: 0x28A1310 Offset: 0x28A1411 VA: 0x28A1310
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.OnCompleted
	|
	|-RVA: 0x28A1600 Offset: 0x28A1701 VA: 0x28A1600
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.OnCompleted
	|
	|-RVA: 0x28A18B0 Offset: 0x28A19B1 VA: 0x28A18B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.OnCompleted
	|
	|-RVA: 0x28A1BA0 Offset: 0x28A1CA1 VA: 0x28A1BA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.OnCompleted
	|
	|-RVA: 0x28A1E90 Offset: 0x28A1F91 VA: 0x28A1E90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A2170 Offset: 0x28A2271 VA: 0x28A2170
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.OnCompleted
	|
	|-RVA: 0x28A2450 Offset: 0x28A2551 VA: 0x28A2450
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.OnCompleted
	|
	|-RVA: 0x28A2700 Offset: 0x28A2801 VA: 0x28A2700
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.OnCompleted
	|
	|-RVA: 0x28A29F0 Offset: 0x28A2AF1 VA: 0x28A29F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.OnCompleted
	|
	|-RVA: 0x28A2C40 Offset: 0x28A2D41 VA: 0x28A2C40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.OnCompleted
	|
	|-RVA: 0x28A2F10 Offset: 0x28A3011 VA: 0x28A2F10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.OnCompleted
	|
	|-RVA: 0x28A31D0 Offset: 0x28A32D1 VA: 0x28A31D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.OnCompleted
	|
	|-RVA: 0x28A34B0 Offset: 0x28A35B1 VA: 0x28A34B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.OnCompleted
	|
	|-RVA: 0x28A37A0 Offset: 0x28A38A1 VA: 0x28A37A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A3A90 Offset: 0x28A3B91 VA: 0x28A3A90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A3D90 Offset: 0x28A3E91 VA: 0x28A3D90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A40B0 Offset: 0x28A41B1 VA: 0x28A40B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A43F0 Offset: 0x28A44F1 VA: 0x28A43F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A4730 Offset: 0x28A4831 VA: 0x28A4730
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A4A80 Offset: 0x28A4B81 VA: 0x28A4A80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A4CD0 Offset: 0x28A4DD1 VA: 0x28A4CD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.OnCompleted
	|
	|-RVA: 0x28A4F20 Offset: 0x28A5021 VA: 0x28A4F20
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.OnCompleted
	|
	|-RVA: 0x28A5200 Offset: 0x28A5301 VA: 0x28A5200
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.OnCompleted
	|
	|-RVA: 0x28A5450 Offset: 0x28A5551 VA: 0x28A5450
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.OnCompleted
	|
	|-RVA: 0x28A5710 Offset: 0x28A5811 VA: 0x28A5710
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.OnCompleted
	|
	|-RVA: 0x28A59F0 Offset: 0x28A5AF1 VA: 0x28A59F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.OnCompleted
	|
	|-RVA: 0x28A5CA0 Offset: 0x28A5DA1 VA: 0x28A5CA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.OnCompleted
	|
	|-RVA: 0x28A5F80 Offset: 0x28A6081 VA: 0x28A5F80
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.OnCompleted
	|
	|-RVA: 0x28A6260 Offset: 0x28A6361 VA: 0x28A6260
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x28A6520 Offset: 0x28A6621 VA: 0x28A6520
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.OnCompleted
	|
	|-RVA: 0x28A67E0 Offset: 0x28A68E1 VA: 0x28A67E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.OnCompleted
	|
	|-RVA: 0x28A6A90 Offset: 0x28A6B91 VA: 0x28A6A90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.OnCompleted
	|
	|-RVA: 0x28A6D70 Offset: 0x28A6E71 VA: 0x28A6D70
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.OnCompleted
	|
	|-RVA: 0x28A6FC0 Offset: 0x28A70C1 VA: 0x28A6FC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.OnCompleted
	|
	|-RVA: 0x28A7270 Offset: 0x28A7371 VA: 0x28A7270
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.OnCompleted
	|
	|-RVA: 0x28A7540 Offset: 0x28A7641 VA: 0x28A7540
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.OnCompleted
	|
	|-RVA: 0x28A7800 Offset: 0x28A7901 VA: 0x28A7800
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.OnCompleted
	|
	|-RVA: 0x28A7AE0 Offset: 0x28A7BE1 VA: 0x28A7AE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.OnCompleted
	|
	|-RVA: 0x28A7DC0 Offset: 0x28A7EC1 VA: 0x28A7DC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.OnCompleted
	|
	|-RVA: 0x28A80F0 Offset: 0x28A81F1 VA: 0x28A80F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A83E0 Offset: 0x28A84E1 VA: 0x28A83E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x28A8730 Offset: 0x28A8831 VA: 0x28A8730
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A8A30 Offset: 0x28A8B31 VA: 0x28A8A30
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x28A8DA0 Offset: 0x28A8EA1 VA: 0x28A8DA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A90D0 Offset: 0x28A91D1 VA: 0x28A90D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x28A9470 Offset: 0x28A9571 VA: 0x28A9470
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A97A0 Offset: 0x28A98A1 VA: 0x28A97A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x28A9AB0 Offset: 0x28A9BB1 VA: 0x28A9AB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x28A9E00 Offset: 0x28A9F01 VA: 0x28A9E00
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x28AA050 Offset: 0x28AA151 VA: 0x28AA050
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.OnCompleted
	|
	|-RVA: 0x28AA2A0 Offset: 0x28AA3A1 VA: 0x28AA2A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.OnCompleted
	|
	|-RVA: 0x28AA580 Offset: 0x28AA681 VA: 0x28AA580
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.OnCompleted
	|
	|-RVA: 0x28AA7D0 Offset: 0x28AA8D1 VA: 0x28AA7D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.OnCompleted
	|
	|-RVA: 0x28AAAA0 Offset: 0x28AABA1 VA: 0x28AAAA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.OnCompleted
	|
	|-RVA: 0x28AAD60 Offset: 0x28AAE61 VA: 0x28AAD60
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.OnCompleted
	|
	|-RVA: 0x28AAFE0 Offset: 0x28AB0E1 VA: 0x28AAFE0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.OnCompleted
	|
	|-RVA: 0x28AB2A0 Offset: 0x28AB3A1 VA: 0x28AB2A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.OnCompleted
	|
	|-RVA: 0x28AB570 Offset: 0x28AB671 VA: 0x28AB570
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2AC2080 Offset: 0x2AC2181 VA: 0x2AC2080
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.OnCompleted
	|
	|-RVA: 0x2AC2350 Offset: 0x2AC2451 VA: 0x2AC2350
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.OnCompleted
	|
	|-RVA: 0x2AC25D0 Offset: 0x2AC26D1 VA: 0x2AC25D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.OnCompleted
	|
	|-RVA: 0x2AC28A0 Offset: 0x2AC29A1 VA: 0x2AC28A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.OnCompleted
	|
	|-RVA: 0x2AC2AF0 Offset: 0x2AC2BF1 VA: 0x2AC2AF0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.OnCompleted
	|
	|-RVA: 0x2AC2DA0 Offset: 0x2AC2EA1 VA: 0x2AC2DA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.OnCompleted
	|
	|-RVA: 0x2AC3050 Offset: 0x2AC3151 VA: 0x2AC3050
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.OnCompleted
	|
	|-RVA: 0x2AC3320 Offset: 0x2AC3421 VA: 0x2AC3320
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.OnCompleted
	|
	|-RVA: 0x2AC35F0 Offset: 0x2AC36F1 VA: 0x2AC35F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.OnCompleted
	|
	|-RVA: 0x2AC38B0 Offset: 0x2AC39B1 VA: 0x2AC38B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.OnCompleted
	|
	|-RVA: 0x2AC3BB0 Offset: 0x2AC3CB1 VA: 0x2AC3BB0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2AC3E90 Offset: 0x2AC3F91 VA: 0x2AC3E90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x2AC41D0 Offset: 0x2AC42D1 VA: 0x2AC41D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2AC44C0 Offset: 0x2AC45C1 VA: 0x2AC44C0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x2AC4810 Offset: 0x2AC4911 VA: 0x2AC4810
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2AC4B10 Offset: 0x2AC4C11 VA: 0x2AC4B10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x2AC4E90 Offset: 0x2AC4F91 VA: 0x2AC4E90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2AC51B0 Offset: 0x2AC52B1 VA: 0x2AC51B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x2AC5550 Offset: 0x2AC5651 VA: 0x2AC5550
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2AC5880 Offset: 0x2AC5981 VA: 0x2AC5880
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x2AC5B60 Offset: 0x2AC5C61 VA: 0x2AC5B60
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2AC5E40 Offset: 0x2AC5F41 VA: 0x2AC5E40
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2AC6090 Offset: 0x2AC6191 VA: 0x2AC6090
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.OnCompleted
	|
	|-RVA: 0x2AC62E0 Offset: 0x2AC63E1 VA: 0x2AC62E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, bool>>>.OnCompleted
	|
	|-RVA: 0x2AC65A0 Offset: 0x2AC66A1 VA: 0x2AC65A0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Bounds>>>.OnCompleted
	|
	|-RVA: 0x2AC67F0 Offset: 0x2AC68F1 VA: 0x2AC67F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, byte>>>.OnCompleted
	|
	|-RVA: 0x2AC6AA0 Offset: 0x2AC6BA1 VA: 0x2AC6AA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Color>>>.OnCompleted
	|
	|-RVA: 0x2AC6D50 Offset: 0x2AC6E51 VA: 0x2AC6D50
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, double>>>.OnCompleted
	|
	|-RVA: 0x2AC6FD0 Offset: 0x2AC70D1 VA: 0x2AC6FD0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, int>>>.OnCompleted
	|
	|-RVA: 0x2AC7280 Offset: 0x2AC7381 VA: 0x2AC7280
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, long>>>.OnCompleted
	|
	|-RVA: 0x2AC7530 Offset: 0x2AC7631 VA: 0x2AC7530
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2AC77E0 Offset: 0x2AC78E1 VA: 0x2AC77E0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.OnCompleted
	|
	|-RVA: 0x2AC7A90 Offset: 0x2AC7B91 VA: 0x2AC7A90
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Rect>>>.OnCompleted
	|
	|-RVA: 0x2AC7D10 Offset: 0x2AC7E11 VA: 0x2AC7D10
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, float>>>.OnCompleted
	|
	|-RVA: 0x2AC7FC0 Offset: 0x2AC80C1 VA: 0x2AC7FC0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, UniTask>>>.OnCompleted
	|
	|-RVA: 0x2AC8210 Offset: 0x2AC8311 VA: 0x2AC8210
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Unit>>>.OnCompleted
	|
	|-RVA: 0x2AC8490 Offset: 0x2AC8591 VA: 0x2AC8490
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector2>>>.OnCompleted
	|
	|-RVA: 0x2AC8740 Offset: 0x2AC8841 VA: 0x2AC8740
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector3>>>.OnCompleted
	|
	|-RVA: 0x2AC89F0 Offset: 0x2AC8AF1 VA: 0x2AC89F0
	|-LazyPromise<ValueTuple<bool, ValueTuple<bool, Vector4>>>.OnCompleted
	|
	|-RVA: 0x2AC8CA0 Offset: 0x2AC8DA1 VA: 0x2AC8CA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, object>>>.OnCompleted
	|
	|-RVA: 0x2AC8F50 Offset: 0x2AC9051 VA: 0x2AC8F50
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object>>>.OnCompleted
	|
	|-RVA: 0x2AC9240 Offset: 0x2AC9341 VA: 0x2AC9240
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2AC9510 Offset: 0x2AC9611 VA: 0x2AC9510
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object>>>.OnCompleted
	|
	|-RVA: 0x2AC9840 Offset: 0x2AC9941 VA: 0x2AC9840
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2AC9B20 Offset: 0x2AC9C21 VA: 0x2AC9B20
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x2AC9E70 Offset: 0x2AC9F71 VA: 0x2AC9E70
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2ACA160 Offset: 0x2ACA261 VA: 0x2ACA160
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x2ACA4D0 Offset: 0x2ACA5D1 VA: 0x2ACA4D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2ACA7D0 Offset: 0x2ACA8D1 VA: 0x2ACA7D0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x2ACAB70 Offset: 0x2ACAC71 VA: 0x2ACAB70
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2ACAEA0 Offset: 0x2ACAFA1 VA: 0x2ACAEA0
	|-LazyPromise<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x2ACB1B0 Offset: 0x2ACB2B1 VA: 0x2ACB1B0
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2ACB490 Offset: 0x2ACB591 VA: 0x2ACB490
	|-LazyPromise<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2ACB6E0 Offset: 0x2ACB7E1 VA: 0x2ACB6E0
	|-LazyPromise<ValueTuple<bool, AsyncUnit>>.OnCompleted
	|
	|-RVA: 0x2ACB930 Offset: 0x2ACBA31 VA: 0x2ACB930
	|-LazyPromise<ValueTuple<bool, bool>>.OnCompleted
	|
	|-RVA: 0x2ACBC00 Offset: 0x2ACBD01 VA: 0x2ACBC00
	|-LazyPromise<ValueTuple<bool, Bounds>>.OnCompleted
	|
	|-RVA: 0x2ACBE50 Offset: 0x2ACBF51 VA: 0x2ACBE50
	|-LazyPromise<ValueTuple<bool, byte>>.OnCompleted
	|
	|-RVA: 0x2ACC100 Offset: 0x2ACC201 VA: 0x2ACC100
	|-LazyPromise<ValueTuple<bool, Color>>.OnCompleted
	|
	|-RVA: 0x2ACC380 Offset: 0x2ACC481 VA: 0x2ACC380
	|-LazyPromise<ValueTuple<bool, double>>.OnCompleted
	|
	|-RVA: 0x2ACC5D0 Offset: 0x2ACC6D1 VA: 0x2ACC5D0
	|-LazyPromise<ValueTuple<bool, int>>.OnCompleted
	|
	|-RVA: 0x2ACC850 Offset: 0x2ACC951 VA: 0x2ACC850
	|-LazyPromise<ValueTuple<bool, long>>.OnCompleted
	|
	|-RVA: 0x2ACCAD0 Offset: 0x2ACCBD1 VA: 0x2ACCAD0
	|-LazyPromise<ValueTuple<bool, object>>.OnCompleted
	|
	|-RVA: 0x2ACCD80 Offset: 0x2ACCE81 VA: 0x2ACCD80
	|-LazyPromise<ValueTuple<bool, Quaternion>>.OnCompleted
	|
	|-RVA: 0x2ACD030 Offset: 0x2ACD131 VA: 0x2ACD030
	|-LazyPromise<ValueTuple<bool, Rect>>.OnCompleted
	|
	|-RVA: 0x2ACD280 Offset: 0x2ACD381 VA: 0x2ACD280
	|-LazyPromise<ValueTuple<bool, float>>.OnCompleted
	|
	|-RVA: 0x2ACD500 Offset: 0x2ACD601 VA: 0x2ACD500
	|-LazyPromise<ValueTuple<bool, UniTask>>.OnCompleted
	|
	|-RVA: 0x2ACD750 Offset: 0x2ACD851 VA: 0x2ACD750
	|-LazyPromise<ValueTuple<bool, Unit>>.OnCompleted
	|
	|-RVA: 0x2ACD9D0 Offset: 0x2ACDAD1 VA: 0x2ACD9D0
	|-LazyPromise<ValueTuple<bool, Vector2>>.OnCompleted
	|
	|-RVA: 0x2ACDC50 Offset: 0x2ACDD51 VA: 0x2ACDC50
	|-LazyPromise<ValueTuple<bool, Vector3>>.OnCompleted
	|
	|-RVA: 0x2ACDF00 Offset: 0x2ACE001 VA: 0x2ACDF00
	|-LazyPromise<ValueTuple<bool, Vector4>>.OnCompleted
	|
	|-RVA: 0x2ACE180 Offset: 0x2ACE281 VA: 0x2ACE180
	|-LazyPromise<ValueTuple<int, object>>.OnCompleted
	|
	|-RVA: 0x2ACE400 Offset: 0x2ACE501 VA: 0x2ACE400
	|-LazyPromise<ValueTuple<object, object>>.OnCompleted
	|
	|-RVA: 0x2ACE6E0 Offset: 0x2ACE7E1 VA: 0x2ACE6E0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2ACE990 Offset: 0x2ACEA91 VA: 0x2ACE990
	|-LazyPromise<ValueTuple<object, object, object>>.OnCompleted
	|
	|-RVA: 0x2ACEC90 Offset: 0x2ACED91 VA: 0x2ACEC90
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2ACEF50 Offset: 0x2ACF051 VA: 0x2ACEF50
	|-LazyPromise<ValueTuple<object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x2ACF280 Offset: 0x2ACF381 VA: 0x2ACF280
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2ACF560 Offset: 0x2ACF661 VA: 0x2ACF560
	|-LazyPromise<ValueTuple<object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x2ACF8B0 Offset: 0x2ACF9B1 VA: 0x2ACF8B0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2ACFBA0 Offset: 0x2ACFCA1 VA: 0x2ACFBA0
	|-LazyPromise<ValueTuple<object, object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x2ACFF20 Offset: 0x2AD0021 VA: 0x2ACFF20
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2AD0220 Offset: 0x2AD0321 VA: 0x2AD0220
	|-LazyPromise<ValueTuple<object, object, object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x2AD05C0 Offset: 0x2AD06C1 VA: 0x2AD05C0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2AD08A0 Offset: 0x2AD09A1 VA: 0x2AD08A0
	|-LazyPromise<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2AD0AF0 Offset: 0x2AD0BF1 VA: 0x2AD0AF0
	|-LazyPromise<AsyncUnit>.OnCompleted
	|
	|-RVA: 0x2AD0D40 Offset: 0x2AD0E41 VA: 0x2AD0D40
	|-LazyPromise<bool>.OnCompleted
	|
	|-RVA: 0x2AD0FF0 Offset: 0x2AD10F1 VA: 0x2AD0FF0
	|-LazyPromise<Bounds>.OnCompleted
	|
	|-RVA: 0x2AD1240 Offset: 0x2AD1341 VA: 0x2AD1240
	|-LazyPromise<byte>.OnCompleted
	|
	|-RVA: 0x2AD14C0 Offset: 0x2AD15C1 VA: 0x2AD14C0
	|-LazyPromise<Color>.OnCompleted
	|
	|-RVA: 0x2AD1710 Offset: 0x2AD1811 VA: 0x2AD1710
	|-LazyPromise<double>.OnCompleted
	|
	|-RVA: 0x2AD1960 Offset: 0x2AD1A61 VA: 0x2AD1960
	|-LazyPromise<int>.OnCompleted
	|
	|-RVA: 0x2AD1BB0 Offset: 0x2AD1CB1 VA: 0x2AD1BB0
	|-LazyPromise<long>.OnCompleted
	|
	|-RVA: 0x2AD1E00 Offset: 0x2AD1F01 VA: 0x2AD1E00
	|-LazyPromise<object>.OnCompleted
	|
	|-RVA: 0x2AD2080 Offset: 0x2AD2181 VA: 0x2AD2080
	|-LazyPromise<Quaternion>.OnCompleted
	|
	|-RVA: 0x2AD2300 Offset: 0x2AD2401 VA: 0x2AD2300
	|-LazyPromise<Rect>.OnCompleted
	|
	|-RVA: 0x2AD2550 Offset: 0x2AD2651 VA: 0x2AD2550
	|-LazyPromise<float>.OnCompleted
	|
	|-RVA: 0x2AD27A0 Offset: 0x2AD28A1 VA: 0x2AD27A0
	|-LazyPromise<UniTask>.OnCompleted
	|
	|-RVA: 0x2AD29F0 Offset: 0x2AD2AF1 VA: 0x2AD29F0
	|-LazyPromise<Unit>.OnCompleted
	|
	|-RVA: 0x2AD2C40 Offset: 0x2AD2D41 VA: 0x2AD2C40
	|-LazyPromise<Vector2>.OnCompleted
	|
	|-RVA: 0x2AD2EC0 Offset: 0x2AD2FC1 VA: 0x2AD2EC0
	|-LazyPromise<Vector3>.OnCompleted
	|
	|-RVA: 0x2AD3140 Offset: 0x2AD3241 VA: 0x2AD3140
	|-LazyPromise<Vector4>.OnCompleted
	*/
}

