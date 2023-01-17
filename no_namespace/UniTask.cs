// Namespace: 
public struct UniTask.Awaiter<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5097
{
	// Fields
	private readonly UniTask<T> task; // 0x0

	// Properties
	[DebuggerHiddenAttribute] // RVA: 0x2F2F0 Offset: 0x2F3F1 VA: 0x2F2F0
	public bool IsCompleted { get; }
	[DebuggerHiddenAttribute] // RVA: 0x2F300 Offset: 0x2F401 VA: 0x2F300
	public AwaiterStatus Status { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CF20 Offset: 0x2D021 VA: 0x2CF20
	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F160 Offset: 0x2F5F261 VA: 0x2F5F160
	|-UniTask.Awaiter<UniTask<object>>..ctor
	|
	|-RVA: 0x2F5F4C0 Offset: 0x2F5F5C1 VA: 0x2F5F4C0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x2F5F830 Offset: 0x2F5F931 VA: 0x2F5F830
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x2F5FBC0 Offset: 0x2F5FCC1 VA: 0x2F5FBC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x2F5FF50 Offset: 0x2F60051 VA: 0x2F5FF50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x2F60320 Offset: 0x2F60421 VA: 0x2F60320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x2F60630 Offset: 0x2F60731 VA: 0x2F60630
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x2F60940 Offset: 0x2F60A41 VA: 0x2F60940
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x2F60D10 Offset: 0x2F60E11 VA: 0x2F60D10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x2F61020 Offset: 0x2F61121 VA: 0x2F61020
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x2F613B0 Offset: 0x2F614B1 VA: 0x2F613B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x2F61780 Offset: 0x2F61881 VA: 0x2F61780
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x2F61AF0 Offset: 0x2F61BF1 VA: 0x2F61AF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x2F61EC0 Offset: 0x2F61FC1 VA: 0x2F61EC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2F62290 Offset: 0x2F62391 VA: 0x2F62290
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x2F62620 Offset: 0x2F62721 VA: 0x2F62620
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x2F629B0 Offset: 0x2F62AB1 VA: 0x2F629B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x2F62D20 Offset: 0x2F62E21 VA: 0x2F62D20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x2F630F0 Offset: 0x2F631F1 VA: 0x2F630F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x2F63400 Offset: 0x2F63501 VA: 0x2F63400
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x2F63790 Offset: 0x2F63891 VA: 0x2F63790
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x2F63B20 Offset: 0x2F63C21 VA: 0x2F63B20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x2F63EB0 Offset: 0x2F63FB1 VA: 0x2F63EB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x2F64280 Offset: 0x2F64381 VA: 0x2F64280
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x2F64650 Offset: 0x2F64751 VA: 0x2F64650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2F64A20 Offset: 0x2F64B21 VA: 0x2F64A20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1DD4520 Offset: 0x1DD4621 VA: 0x1DD4520
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1DD4900 Offset: 0x1DD4A01 VA: 0x1DD4900
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1DD4D20 Offset: 0x1DD4E21 VA: 0x1DD4D20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1DD5140 Offset: 0x1DD5241 VA: 0x1DD5140
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x1DD5450 Offset: 0x1DD5551 VA: 0x1DD5450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x1DD5760 Offset: 0x1DD5861 VA: 0x1DD5760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x1DD5AF0 Offset: 0x1DD5BF1 VA: 0x1DD5AF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x1DD5E00 Offset: 0x1DD5F01 VA: 0x1DD5E00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x1DD6190 Offset: 0x1DD6291 VA: 0x1DD6190
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x1DD6520 Offset: 0x1DD6621 VA: 0x1DD6520
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x1DD6890 Offset: 0x1DD6991 VA: 0x1DD6890
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x1DD6C20 Offset: 0x1DD6D21 VA: 0x1DD6C20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DD6FB0 Offset: 0x1DD70B1 VA: 0x1DD6FB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x1DD7340 Offset: 0x1DD7441 VA: 0x1DD7340
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x1DD76D0 Offset: 0x1DD77D1 VA: 0x1DD76D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x1DD7A40 Offset: 0x1DD7B41 VA: 0x1DD7A40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x1DD7DD0 Offset: 0x1DD7ED1 VA: 0x1DD7DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x1DD80E0 Offset: 0x1DD81E1 VA: 0x1DD80E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x1DD8450 Offset: 0x1DD8551 VA: 0x1DD8450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x1DD87E0 Offset: 0x1DD88E1 VA: 0x1DD87E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x1DD8B70 Offset: 0x1DD8C71 VA: 0x1DD8B70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x1DD8F00 Offset: 0x1DD9001 VA: 0x1DD8F00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x1DD9290 Offset: 0x1DD9391 VA: 0x1DD9290
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DD9670 Offset: 0x1DD9771 VA: 0x1DD9670
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x1DD9A40 Offset: 0x1DD9B41 VA: 0x1DD9A40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DD9E60 Offset: 0x1DD9F61 VA: 0x1DD9E60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1DDA230 Offset: 0x1DDA331 VA: 0x1DDA230
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DDA660 Offset: 0x1DDA761 VA: 0x1DDA660
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1DDAA40 Offset: 0x1DDAB41 VA: 0x1DDAA40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DDAEB0 Offset: 0x1DDAFB1 VA: 0x1DDAEB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1DDB290 Offset: 0x1DDB391 VA: 0x1DDB290
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DDB650 Offset: 0x1DDB751 VA: 0x1DDB650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1DDBA70 Offset: 0x1DDBB71 VA: 0x1DDBA70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x1DDBD80 Offset: 0x1DDBE81 VA: 0x1DDBD80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x1DDC090 Offset: 0x1DDC191 VA: 0x1DDC090
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x1DDC420 Offset: 0x1DDC521 VA: 0x1DDC420
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x1DDC730 Offset: 0x1DDC831 VA: 0x1DDC730
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x1DDCAC0 Offset: 0x1DDCBC1 VA: 0x1DDCAC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x1DDCE50 Offset: 0x1DDCF51 VA: 0x1DDCE50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x1DDD1B0 Offset: 0x1DDD2B1 VA: 0x1DDD1B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x1DDD540 Offset: 0x1DDD641 VA: 0x1DDD540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DDD8D0 Offset: 0x1DDD9D1 VA: 0x1DDD8D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x1DDDC60 Offset: 0x1DDDD61 VA: 0x1DDDC60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x1DDDFF0 Offset: 0x1DDE0F1 VA: 0x1DDDFF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x1DDE350 Offset: 0x1DDE451 VA: 0x1DDE350
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x1DDE6E0 Offset: 0x1DDE7E1 VA: 0x1DDE6E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x1DDE9F0 Offset: 0x1DDEAF1 VA: 0x1DDE9F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x1DDED60 Offset: 0x1DDEE61 VA: 0x1DDED60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x1DDF0D0 Offset: 0x1DDF1D1 VA: 0x1DDF0D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x1DDF460 Offset: 0x1DDF561 VA: 0x1DDF460
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x1DDF7F0 Offset: 0x1DDF8F1 VA: 0x1DDF7F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x1DDFB80 Offset: 0x1DDFC81 VA: 0x1DDFB80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DDFF50 Offset: 0x1DE0051 VA: 0x1DDFF50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x1DE02E0 Offset: 0x1DE03E1 VA: 0x1DE02E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE06C0 Offset: 0x1DE07C1 VA: 0x1DE06C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1DE0A90 Offset: 0x1DE0B91 VA: 0x1DE0A90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE0EB0 Offset: 0x1DE0FB1 VA: 0x1DE0EB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1DE1280 Offset: 0x1DE1381 VA: 0x1DE1280
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE16B0 Offset: 0x1DE17B1 VA: 0x1DE16B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1DE1A90 Offset: 0x1DE1B91 VA: 0x1DE1A90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE1F10 Offset: 0x1DE2011 VA: 0x1DE1F10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1DE22F0 Offset: 0x1DE23F1 VA: 0x1DE22F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DE2680 Offset: 0x1DE2781 VA: 0x1DE2680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DE2A10 Offset: 0x1DE2B11 VA: 0x1DE2A10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x1DE2D20 Offset: 0x1DE2E21 VA: 0x1DE2D20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x1DE3030 Offset: 0x1DE3131 VA: 0x1DE3030
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x1DE33C0 Offset: 0x1DE34C1 VA: 0x1DE33C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x1DE36D0 Offset: 0x1DE37D1 VA: 0x1DE36D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x1DE3A40 Offset: 0x1DE3B41 VA: 0x1DE3A40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x1DE3DB0 Offset: 0x1DE3EB1 VA: 0x1DE3DB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x1DE4110 Offset: 0x1DE4211 VA: 0x1DE4110
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x1DE4480 Offset: 0x1DE4581 VA: 0x1DE4480
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DE47F0 Offset: 0x1DE48F1 VA: 0x1DE47F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x1DE4B60 Offset: 0x1DE4C61 VA: 0x1DE4B60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x1DE4ED0 Offset: 0x1DE4FD1 VA: 0x1DE4ED0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x1DE5230 Offset: 0x1DE5331 VA: 0x1DE5230
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x1DE55A0 Offset: 0x1DE56A1 VA: 0x1DE55A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x1DE58B0 Offset: 0x1DE59B1 VA: 0x1DE58B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x1DE5C10 Offset: 0x1DE5D11 VA: 0x1DE5C10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x1DE5F80 Offset: 0x1DE6081 VA: 0x1DE5F80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x1DE62F0 Offset: 0x1DE63F1 VA: 0x1DE62F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x1DE6660 Offset: 0x1DE6761 VA: 0x1DE6660
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x1DE69D0 Offset: 0x1DE6AD1 VA: 0x1DE69D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DE6DA0 Offset: 0x1DE6EA1 VA: 0x1DE6DA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x1DE7130 Offset: 0x1DE7231 VA: 0x1DE7130
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DE7510 Offset: 0x1DE7611 VA: 0x1DE7510
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x1DE78A0 Offset: 0x1DE79A1 VA: 0x1DE78A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DE7CC0 Offset: 0x1DE7DC1 VA: 0x1DE7CC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1DE8090 Offset: 0x1DE8191 VA: 0x1DE8090
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DE84C0 Offset: 0x1DE85C1 VA: 0x1DE84C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1DE8890 Offset: 0x1DE8991 VA: 0x1DE8890
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DE8D00 Offset: 0x1DE8E01 VA: 0x1DE8D00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1DE90E0 Offset: 0x1DE91E1 VA: 0x1DE90E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE94A0 Offset: 0x1DE95A1 VA: 0x1DE94A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE9830 Offset: 0x1DE9931 VA: 0x1DE9830
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x1DE9D90 Offset: 0x1DE9E91 VA: 0x1DE9D90
	|-UniTask.Awaiter<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x1DEA0A0 Offset: 0x1DEA1A1 VA: 0x1DEA0A0
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x1DEA430 Offset: 0x1DEA531 VA: 0x1DEA430
	|-UniTask.Awaiter<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x1DEA740 Offset: 0x1DEA841 VA: 0x1DEA740
	|-UniTask.Awaiter<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x1DEAAB0 Offset: 0x1DEABB1 VA: 0x1DEAAB0
	|-UniTask.Awaiter<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x1DEAE10 Offset: 0x1DEAF11 VA: 0x1DEAE10
	|-UniTask.Awaiter<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x1DEB120 Offset: 0x1DEB221 VA: 0x1DEB120
	|-UniTask.Awaiter<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x1DEB480 Offset: 0x1DEB581 VA: 0x1DEB480
	|-UniTask.Awaiter<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1DEBA50 Offset: 0x1DEBB51 VA: 0x1DEBA50
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x1DEBDC0 Offset: 0x1DEBEC1 VA: 0x1DEBDC0
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x1DEC130 Offset: 0x1DEC231 VA: 0x1DEC130
	|-UniTask.Awaiter<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x1DEC440 Offset: 0x1DEC541 VA: 0x1DEC440
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x1DEC7A0 Offset: 0x1DEC8A1 VA: 0x1DEC7A0
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x1DECAB0 Offset: 0x1DECBB1 VA: 0x1DECAB0
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x1DECE10 Offset: 0x1DECF11 VA: 0x1DECE10
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x1DED170 Offset: 0x1DED271 VA: 0x1DED170
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x1DED4E0 Offset: 0x1DED5E1 VA: 0x1DED4E0
	|-UniTask.Awaiter<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x1DED840 Offset: 0x1DED941 VA: 0x1DED840
	|-UniTask.Awaiter<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x1DEDBA0 Offset: 0x1DEDCA1 VA: 0x1DEDBA0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DEDF30 Offset: 0x1DEE031 VA: 0x1DEDF30
	|-UniTask.Awaiter<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x1DEE2A0 Offset: 0x1DEE3A1 VA: 0x1DEE2A0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DEE670 Offset: 0x1DEE771 VA: 0x1DEE670
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x1DEEA00 Offset: 0x1DEEB01 VA: 0x1DEEA00
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DEEDE0 Offset: 0x1DEEEE1 VA: 0x1DEEDE0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1DEF170 Offset: 0x1DEF271 VA: 0x1DEF170
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DEF590 Offset: 0x1DEF691 VA: 0x1DEF590
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1DEF960 Offset: 0x1DEFA61 VA: 0x1DEF960
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DEFD90 Offset: 0x1DEFE91 VA: 0x1DEFD90
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1DF0160 Offset: 0x1DF0261 VA: 0x1DF0160
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DF05E0 Offset: 0x1DF06E1 VA: 0x1DF05E0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DF0970 Offset: 0x1DF0A71 VA: 0x1DF0970
	|-UniTask.Awaiter<AsyncUnit>..ctor
	|
	|-RVA: 0x1DF0C80 Offset: 0x1DF0D81 VA: 0x1DF0C80
	|-UniTask.Awaiter<bool>..ctor
	|
	|-RVA: 0x1DF0F90 Offset: 0x1DF1091 VA: 0x1DF0F90
	|-UniTask.Awaiter<Bounds>..ctor
	|
	|-RVA: 0x1DF1300 Offset: 0x1DF1401 VA: 0x1DF1300
	|-UniTask.Awaiter<byte>..ctor
	|
	|-RVA: 0x1DF1610 Offset: 0x1DF1711 VA: 0x1DF1610
	|-UniTask.Awaiter<Color>..ctor
	|
	|-RVA: 0x1DF1970 Offset: 0x1DF1A71 VA: 0x1DF1970
	|-UniTask.Awaiter<double>..ctor
	|
	|-RVA: 0x1DF1C80 Offset: 0x1DF1D81 VA: 0x1DF1C80
	|-UniTask.Awaiter<int>..ctor
	|
	|-RVA: 0x1DF1F90 Offset: 0x1DF2091 VA: 0x1DF1F90
	|-UniTask.Awaiter<long>..ctor
	|
	|-RVA: 0x1DF22A0 Offset: 0x1DF23A1 VA: 0x1DF22A0
	|-UniTask.Awaiter<object>..ctor
	|
	|-RVA: 0x1DF2C00 Offset: 0x1DF2D01 VA: 0x1DF2C00
	|-UniTask.Awaiter<Quaternion>..ctor
	|
	|-RVA: 0x1DF2F60 Offset: 0x1DF3061 VA: 0x1DF2F60
	|-UniTask.Awaiter<Rect>..ctor
	|
	|-RVA: 0x1DF32C0 Offset: 0x1DF33C1 VA: 0x1DF32C0
	|-UniTask.Awaiter<float>..ctor
	|
	|-RVA: 0x1DF35D0 Offset: 0x1DF36D1 VA: 0x1DF35D0
	|-UniTask.Awaiter<UniTask>..ctor
	|
	|-RVA: 0x1DF38E0 Offset: 0x1DF39E1 VA: 0x1DF38E0
	|-UniTask.Awaiter<Unit>..ctor
	|
	|-RVA: 0x1DF3BF0 Offset: 0x1DF3CF1 VA: 0x1DF3BF0
	|-UniTask.Awaiter<Vector2>..ctor
	|
	|-RVA: 0x1DF3F00 Offset: 0x1DF4001 VA: 0x1DF3F00
	|-UniTask.Awaiter<Vector3>..ctor
	|
	|-RVA: 0x1DF4260 Offset: 0x1DF4361 VA: 0x1DF4260
	|-UniTask.Awaiter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F180 Offset: 0x2F5F281 VA: 0x2F5F180
	|-UniTask.Awaiter<UniTask<object>>.get_IsCompleted
	|
	|-RVA: 0x2F5F4E0 Offset: 0x2F5F5E1 VA: 0x2F5F4E0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.get_IsCompleted
	|
	|-RVA: 0x2F5F860 Offset: 0x2F5F961 VA: 0x2F5F860
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_IsCompleted
	|
	|-RVA: 0x2F5FBF0 Offset: 0x2F5FCF1 VA: 0x2F5FBF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F5FF80 Offset: 0x2F60081 VA: 0x2F5FF80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F60330 Offset: 0x2F60431 VA: 0x2F60330
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F60640 Offset: 0x2F60741 VA: 0x2F60640
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F60970 Offset: 0x2F60A71 VA: 0x2F60970
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F60D20 Offset: 0x2F60E21 VA: 0x2F60D20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F61050 Offset: 0x2F61151 VA: 0x2F61050
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F613E0 Offset: 0x2F614E1 VA: 0x2F613E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F617A0 Offset: 0x2F618A1 VA: 0x2F617A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F61B20 Offset: 0x2F61C21 VA: 0x2F61B20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F61EF0 Offset: 0x2F61FF1 VA: 0x2F61EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F622C0 Offset: 0x2F623C1 VA: 0x2F622C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F62650 Offset: 0x2F62751 VA: 0x2F62650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F629D0 Offset: 0x2F62AD1 VA: 0x2F629D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F62D50 Offset: 0x2F62E51 VA: 0x2F62D50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F63100 Offset: 0x2F63201 VA: 0x2F63100
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F63430 Offset: 0x2F63531 VA: 0x2F63430
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F637C0 Offset: 0x2F638C1 VA: 0x2F637C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F63B50 Offset: 0x2F63C51 VA: 0x2F63B50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F63EE0 Offset: 0x2F63FE1 VA: 0x2F63EE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F642B0 Offset: 0x2F643B1 VA: 0x2F642B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F64680 Offset: 0x2F64781 VA: 0x2F64680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F64A50 Offset: 0x2F64B51 VA: 0x2F64A50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD4550 Offset: 0x1DD4651 VA: 0x1DD4550
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD4930 Offset: 0x1DD4A31 VA: 0x1DD4930
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD4D50 Offset: 0x1DD4E51 VA: 0x1DD4D50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD5150 Offset: 0x1DD5251 VA: 0x1DD5150
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD5460 Offset: 0x1DD5561 VA: 0x1DD5460
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD5790 Offset: 0x1DD5891 VA: 0x1DD5790
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD5B00 Offset: 0x1DD5C01 VA: 0x1DD5B00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD5E30 Offset: 0x1DD5F31 VA: 0x1DD5E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD61C0 Offset: 0x1DD62C1 VA: 0x1DD61C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD6540 Offset: 0x1DD6641 VA: 0x1DD6540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD68C0 Offset: 0x1DD69C1 VA: 0x1DD68C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD6C50 Offset: 0x1DD6D51 VA: 0x1DD6C50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD6FE0 Offset: 0x1DD70E1 VA: 0x1DD6FE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD7370 Offset: 0x1DD7471 VA: 0x1DD7370
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD76F0 Offset: 0x1DD77F1 VA: 0x1DD76F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD7A70 Offset: 0x1DD7B71 VA: 0x1DD7A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD7DE0 Offset: 0x1DD7EE1 VA: 0x1DD7DE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD8100 Offset: 0x1DD8201 VA: 0x1DD8100
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD8480 Offset: 0x1DD8581 VA: 0x1DD8480
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD8810 Offset: 0x1DD8911 VA: 0x1DD8810
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD8BA0 Offset: 0x1DD8CA1 VA: 0x1DD8BA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD8F30 Offset: 0x1DD9031 VA: 0x1DD8F30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD92C0 Offset: 0x1DD93C1 VA: 0x1DD92C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD96A0 Offset: 0x1DD97A1 VA: 0x1DD96A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD9A70 Offset: 0x1DD9B71 VA: 0x1DD9A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD9E90 Offset: 0x1DD9F91 VA: 0x1DD9E90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDA260 Offset: 0x1DDA361 VA: 0x1DDA260
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDA690 Offset: 0x1DDA791 VA: 0x1DDA690
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDAA70 Offset: 0x1DDAB71 VA: 0x1DDAA70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDAEE0 Offset: 0x1DDAFE1 VA: 0x1DDAEE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDB2C0 Offset: 0x1DDB3C1 VA: 0x1DDB2C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDB680 Offset: 0x1DDB781 VA: 0x1DDB680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDBA80 Offset: 0x1DDBB81 VA: 0x1DDBA80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDBD90 Offset: 0x1DDBE91 VA: 0x1DDBD90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDC0C0 Offset: 0x1DDC1C1 VA: 0x1DDC0C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDC430 Offset: 0x1DDC531 VA: 0x1DDC430
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDC760 Offset: 0x1DDC861 VA: 0x1DDC760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDCAF0 Offset: 0x1DDCBF1 VA: 0x1DDCAF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDCE70 Offset: 0x1DDCF71 VA: 0x1DDCE70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDD1E0 Offset: 0x1DDD2E1 VA: 0x1DDD1E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDD570 Offset: 0x1DDD671 VA: 0x1DDD570
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDD900 Offset: 0x1DDDA01 VA: 0x1DDD900
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDDC90 Offset: 0x1DDDD91 VA: 0x1DDDC90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDE010 Offset: 0x1DDE111 VA: 0x1DDE010
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDE380 Offset: 0x1DDE481 VA: 0x1DDE380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDE6F0 Offset: 0x1DDE7F1 VA: 0x1DDE6F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDEA10 Offset: 0x1DDEB11 VA: 0x1DDEA10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDED80 Offset: 0x1DDEE81 VA: 0x1DDED80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDF100 Offset: 0x1DDF201 VA: 0x1DDF100
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDF490 Offset: 0x1DDF591 VA: 0x1DDF490
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDF820 Offset: 0x1DDF921 VA: 0x1DDF820
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDFBB0 Offset: 0x1DDFCB1 VA: 0x1DDFBB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDFF80 Offset: 0x1DE0081 VA: 0x1DDFF80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE0310 Offset: 0x1DE0411 VA: 0x1DE0310
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE06F0 Offset: 0x1DE07F1 VA: 0x1DE06F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE0AC0 Offset: 0x1DE0BC1 VA: 0x1DE0AC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE0EE0 Offset: 0x1DE0FE1 VA: 0x1DE0EE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE12B0 Offset: 0x1DE13B1 VA: 0x1DE12B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE16E0 Offset: 0x1DE17E1 VA: 0x1DE16E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE1AC0 Offset: 0x1DE1BC1 VA: 0x1DE1AC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE1F40 Offset: 0x1DE2041 VA: 0x1DE1F40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE2320 Offset: 0x1DE2421 VA: 0x1DE2320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE26B0 Offset: 0x1DE27B1 VA: 0x1DE26B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE2A20 Offset: 0x1DE2B21 VA: 0x1DE2A20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_IsCompleted
	|
	|-RVA: 0x1DE2D30 Offset: 0x1DE2E31 VA: 0x1DE2D30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.get_IsCompleted
	|
	|-RVA: 0x1DE3060 Offset: 0x1DE3161 VA: 0x1DE3060
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_IsCompleted
	|
	|-RVA: 0x1DE33D0 Offset: 0x1DE34D1 VA: 0x1DE33D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.get_IsCompleted
	|
	|-RVA: 0x1DE36F0 Offset: 0x1DE37F1 VA: 0x1DE36F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.get_IsCompleted
	|
	|-RVA: 0x1DE3A60 Offset: 0x1DE3B61 VA: 0x1DE3A60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.get_IsCompleted
	|
	|-RVA: 0x1DE3DD0 Offset: 0x1DE3ED1 VA: 0x1DE3DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.get_IsCompleted
	|
	|-RVA: 0x1DE4130 Offset: 0x1DE4231 VA: 0x1DE4130
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.get_IsCompleted
	|
	|-RVA: 0x1DE44A0 Offset: 0x1DE45A1 VA: 0x1DE44A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE4810 Offset: 0x1DE4911 VA: 0x1DE4810
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_IsCompleted
	|
	|-RVA: 0x1DE4B80 Offset: 0x1DE4C81 VA: 0x1DE4B80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_IsCompleted
	|
	|-RVA: 0x1DE4EF0 Offset: 0x1DE4FF1 VA: 0x1DE4EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.get_IsCompleted
	|
	|-RVA: 0x1DE5250 Offset: 0x1DE5351 VA: 0x1DE5250
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_IsCompleted
	|
	|-RVA: 0x1DE55B0 Offset: 0x1DE56B1 VA: 0x1DE55B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_IsCompleted
	|
	|-RVA: 0x1DE58D0 Offset: 0x1DE59D1 VA: 0x1DE58D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_IsCompleted
	|
	|-RVA: 0x1DE5C30 Offset: 0x1DE5D31 VA: 0x1DE5C30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_IsCompleted
	|
	|-RVA: 0x1DE5FA0 Offset: 0x1DE60A1 VA: 0x1DE5FA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_IsCompleted
	|
	|-RVA: 0x1DE6310 Offset: 0x1DE6411 VA: 0x1DE6310
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE6680 Offset: 0x1DE6781 VA: 0x1DE6680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE6A00 Offset: 0x1DE6B01 VA: 0x1DE6A00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE6DD0 Offset: 0x1DE6ED1 VA: 0x1DE6DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE7160 Offset: 0x1DE7261 VA: 0x1DE7160
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE7540 Offset: 0x1DE7641 VA: 0x1DE7540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE78D0 Offset: 0x1DE79D1 VA: 0x1DE78D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE7CF0 Offset: 0x1DE7DF1 VA: 0x1DE7CF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE80C0 Offset: 0x1DE81C1 VA: 0x1DE80C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE84F0 Offset: 0x1DE85F1 VA: 0x1DE84F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE88C0 Offset: 0x1DE89C1 VA: 0x1DE88C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE8D30 Offset: 0x1DE8E31 VA: 0x1DE8D30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE9110 Offset: 0x1DE9211 VA: 0x1DE9110
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE94D0 Offset: 0x1DE95D1 VA: 0x1DE94D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE9840 Offset: 0x1DE9941 VA: 0x1DE9840
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.get_IsCompleted
	|
	|-RVA: 0x1DE9DA0 Offset: 0x1DE9EA1 VA: 0x1DE9DA0
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.get_IsCompleted
	|
	|-RVA: 0x1DEA0D0 Offset: 0x1DEA1D1 VA: 0x1DEA0D0
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.get_IsCompleted
	|
	|-RVA: 0x1DEA440 Offset: 0x1DEA541 VA: 0x1DEA440
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.get_IsCompleted
	|
	|-RVA: 0x1DEA760 Offset: 0x1DEA861 VA: 0x1DEA760
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.get_IsCompleted
	|
	|-RVA: 0x1DEAAD0 Offset: 0x1DEABD1 VA: 0x1DEAAD0
	|-UniTask.Awaiter<ValueTuple<bool, double>>.get_IsCompleted
	|
	|-RVA: 0x1DEAE20 Offset: 0x1DEAF21 VA: 0x1DEAE20
	|-UniTask.Awaiter<ValueTuple<bool, int>>.get_IsCompleted
	|
	|-RVA: 0x1DEB140 Offset: 0x1DEB241 VA: 0x1DEB140
	|-UniTask.Awaiter<ValueTuple<bool, long>>.get_IsCompleted
	|
	|-RVA: 0x1DEB4A0 Offset: 0x1DEB5A1 VA: 0x1DEB4A0
	|-UniTask.Awaiter<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEBA70 Offset: 0x1DEBB71 VA: 0x1DEBA70
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.get_IsCompleted
	|
	|-RVA: 0x1DEBDE0 Offset: 0x1DEBEE1 VA: 0x1DEBDE0
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.get_IsCompleted
	|
	|-RVA: 0x1DEC140 Offset: 0x1DEC241 VA: 0x1DEC140
	|-UniTask.Awaiter<ValueTuple<bool, float>>.get_IsCompleted
	|
	|-RVA: 0x1DEC460 Offset: 0x1DEC561 VA: 0x1DEC460
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.get_IsCompleted
	|
	|-RVA: 0x1DEC7B0 Offset: 0x1DEC8B1 VA: 0x1DEC7B0
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.get_IsCompleted
	|
	|-RVA: 0x1DECAD0 Offset: 0x1DECBD1 VA: 0x1DECAD0
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.get_IsCompleted
	|
	|-RVA: 0x1DECE30 Offset: 0x1DECF31 VA: 0x1DECE30
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.get_IsCompleted
	|
	|-RVA: 0x1DED190 Offset: 0x1DED291 VA: 0x1DED190
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.get_IsCompleted
	|
	|-RVA: 0x1DED500 Offset: 0x1DED601 VA: 0x1DED500
	|-UniTask.Awaiter<ValueTuple<int, object>>.get_IsCompleted
	|
	|-RVA: 0x1DED860 Offset: 0x1DED961 VA: 0x1DED860
	|-UniTask.Awaiter<ValueTuple<object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEDBD0 Offset: 0x1DEDCD1 VA: 0x1DEDBD0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DEDF50 Offset: 0x1DEE051 VA: 0x1DEDF50
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEE2D0 Offset: 0x1DEE3D1 VA: 0x1DEE2D0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DEE6A0 Offset: 0x1DEE7A1 VA: 0x1DEE6A0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEEA30 Offset: 0x1DEEB31 VA: 0x1DEEA30
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DEEE10 Offset: 0x1DEEF11 VA: 0x1DEEE10
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEF1A0 Offset: 0x1DEF2A1 VA: 0x1DEF1A0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DEF5C0 Offset: 0x1DEF6C1 VA: 0x1DEF5C0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEF990 Offset: 0x1DEFA91 VA: 0x1DEF990
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DEFDC0 Offset: 0x1DEFEC1 VA: 0x1DEFDC0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DF0190 Offset: 0x1DF0291 VA: 0x1DF0190
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DF0610 Offset: 0x1DF0711 VA: 0x1DF0610
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DF0980 Offset: 0x1DF0A81 VA: 0x1DF0980
	|-UniTask.Awaiter<AsyncUnit>.get_IsCompleted
	|
	|-RVA: 0x1DF0C90 Offset: 0x1DF0D91 VA: 0x1DF0C90
	|-UniTask.Awaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x1DF0FB0 Offset: 0x1DF10B1 VA: 0x1DF0FB0
	|-UniTask.Awaiter<Bounds>.get_IsCompleted
	|
	|-RVA: 0x1DF1310 Offset: 0x1DF1411 VA: 0x1DF1310
	|-UniTask.Awaiter<byte>.get_IsCompleted
	|
	|-RVA: 0x1DF1630 Offset: 0x1DF1731 VA: 0x1DF1630
	|-UniTask.Awaiter<Color>.get_IsCompleted
	|
	|-RVA: 0x1DF1980 Offset: 0x1DF1A81 VA: 0x1DF1980
	|-UniTask.Awaiter<double>.get_IsCompleted
	|
	|-RVA: 0x1DF1C90 Offset: 0x1DF1D91 VA: 0x1DF1C90
	|-UniTask.Awaiter<int>.get_IsCompleted
	|
	|-RVA: 0x1DF1FA0 Offset: 0x1DF20A1 VA: 0x1DF1FA0
	|-UniTask.Awaiter<long>.get_IsCompleted
	|
	|-RVA: 0x1DF22B0 Offset: 0x1DF23B1 VA: 0x1DF22B0
	|-UniTask.Awaiter<object>.get_IsCompleted
	|
	|-RVA: 0x1DF2C20 Offset: 0x1DF2D21 VA: 0x1DF2C20
	|-UniTask.Awaiter<Quaternion>.get_IsCompleted
	|
	|-RVA: 0x1DF2F80 Offset: 0x1DF3081 VA: 0x1DF2F80
	|-UniTask.Awaiter<Rect>.get_IsCompleted
	|
	|-RVA: 0x1DF32D0 Offset: 0x1DF33D1 VA: 0x1DF32D0
	|-UniTask.Awaiter<float>.get_IsCompleted
	|
	|-RVA: 0x1DF35E0 Offset: 0x1DF36E1 VA: 0x1DF35E0
	|-UniTask.Awaiter<UniTask>.get_IsCompleted
	|
	|-RVA: 0x1DF38F0 Offset: 0x1DF39F1 VA: 0x1DF38F0
	|-UniTask.Awaiter<Unit>.get_IsCompleted
	|
	|-RVA: 0x1DF3C00 Offset: 0x1DF3D01 VA: 0x1DF3C00
	|-UniTask.Awaiter<Vector2>.get_IsCompleted
	|
	|-RVA: 0x1DF3F20 Offset: 0x1DF4021 VA: 0x1DF3F20
	|-UniTask.Awaiter<Vector3>.get_IsCompleted
	|
	|-RVA: 0x1DF4280 Offset: 0x1DF4381 VA: 0x1DF4280
	|-UniTask.Awaiter<Vector4>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public AwaiterStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F1E0 Offset: 0x2F5F2E1 VA: 0x2F5F1E0
	|-UniTask.Awaiter<UniTask<object>>.get_Status
	|
	|-RVA: 0x2F5F540 Offset: 0x2F5F641 VA: 0x2F5F540
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.get_Status
	|
	|-RVA: 0x2F5F8C0 Offset: 0x2F5F9C1 VA: 0x2F5F8C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_Status
	|
	|-RVA: 0x2F5FC50 Offset: 0x2F5FD51 VA: 0x2F5FC50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_Status
	|
	|-RVA: 0x2F5FFF0 Offset: 0x2F600F1 VA: 0x2F5FFF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_Status
	|
	|-RVA: 0x2F60380 Offset: 0x2F60481 VA: 0x2F60380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_Status
	|
	|-RVA: 0x2F60690 Offset: 0x2F60791 VA: 0x2F60690
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_Status
	|
	|-RVA: 0x2F609E0 Offset: 0x2F60AE1 VA: 0x2F609E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_Status
	|
	|-RVA: 0x2F60D70 Offset: 0x2F60E71 VA: 0x2F60D70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_Status
	|
	|-RVA: 0x2F610B0 Offset: 0x2F611B1 VA: 0x2F610B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_Status
	|
	|-RVA: 0x2F61450 Offset: 0x2F61551 VA: 0x2F61450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_Status
	|
	|-RVA: 0x2F61800 Offset: 0x2F61901 VA: 0x2F61800
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_Status
	|
	|-RVA: 0x2F61B90 Offset: 0x2F61C91 VA: 0x2F61B90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_Status
	|
	|-RVA: 0x2F61F60 Offset: 0x2F62061 VA: 0x2F61F60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2F62320 Offset: 0x2F62421 VA: 0x2F62320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_Status
	|
	|-RVA: 0x2F626B0 Offset: 0x2F627B1 VA: 0x2F626B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_Status
	|
	|-RVA: 0x2F62A30 Offset: 0x2F62B31 VA: 0x2F62A30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_Status
	|
	|-RVA: 0x2F62DC0 Offset: 0x2F62EC1 VA: 0x2F62DC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_Status
	|
	|-RVA: 0x2F63150 Offset: 0x2F63251 VA: 0x2F63150
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_Status
	|
	|-RVA: 0x2F63490 Offset: 0x2F63591 VA: 0x2F63490
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_Status
	|
	|-RVA: 0x2F63820 Offset: 0x2F63921 VA: 0x2F63820
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_Status
	|
	|-RVA: 0x2F63BB0 Offset: 0x2F63CB1 VA: 0x2F63BB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_Status
	|
	|-RVA: 0x2F63F50 Offset: 0x2F64051 VA: 0x2F63F50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_Status
	|
	|-RVA: 0x2F64320 Offset: 0x2F64421 VA: 0x2F64320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_Status
	|
	|-RVA: 0x2F646F0 Offset: 0x2F647F1 VA: 0x2F646F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x2F64AC0 Offset: 0x2F64BC1 VA: 0x2F64AC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD45C0 Offset: 0x1DD46C1 VA: 0x1DD45C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD49B0 Offset: 0x1DD4AB1 VA: 0x1DD49B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD4DD0 Offset: 0x1DD4ED1 VA: 0x1DD4DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD51A0 Offset: 0x1DD52A1 VA: 0x1DD51A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_Status
	|
	|-RVA: 0x1DD54B0 Offset: 0x1DD55B1 VA: 0x1DD54B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_Status
	|
	|-RVA: 0x1DD57F0 Offset: 0x1DD58F1 VA: 0x1DD57F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_Status
	|
	|-RVA: 0x1DD5B50 Offset: 0x1DD5C51 VA: 0x1DD5B50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_Status
	|
	|-RVA: 0x1DD5E90 Offset: 0x1DD5F91 VA: 0x1DD5E90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_Status
	|
	|-RVA: 0x1DD6220 Offset: 0x1DD6321 VA: 0x1DD6220
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_Status
	|
	|-RVA: 0x1DD65A0 Offset: 0x1DD66A1 VA: 0x1DD65A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_Status
	|
	|-RVA: 0x1DD6920 Offset: 0x1DD6A21 VA: 0x1DD6920
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_Status
	|
	|-RVA: 0x1DD6CB0 Offset: 0x1DD6DB1 VA: 0x1DD6CB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DD7040 Offset: 0x1DD7141 VA: 0x1DD7040
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_Status
	|
	|-RVA: 0x1DD73D0 Offset: 0x1DD74D1 VA: 0x1DD73D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_Status
	|
	|-RVA: 0x1DD7750 Offset: 0x1DD7851 VA: 0x1DD7750
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_Status
	|
	|-RVA: 0x1DD7AD0 Offset: 0x1DD7BD1 VA: 0x1DD7AD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_Status
	|
	|-RVA: 0x1DD7E30 Offset: 0x1DD7F31 VA: 0x1DD7E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_Status
	|
	|-RVA: 0x1DD8160 Offset: 0x1DD8261 VA: 0x1DD8160
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_Status
	|
	|-RVA: 0x1DD84E0 Offset: 0x1DD85E1 VA: 0x1DD84E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_Status
	|
	|-RVA: 0x1DD8870 Offset: 0x1DD8971 VA: 0x1DD8870
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_Status
	|
	|-RVA: 0x1DD8C00 Offset: 0x1DD8D01 VA: 0x1DD8C00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_Status
	|
	|-RVA: 0x1DD8F90 Offset: 0x1DD9091 VA: 0x1DD8F90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_Status
	|
	|-RVA: 0x1DD9330 Offset: 0x1DD9431 VA: 0x1DD9330
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD9710 Offset: 0x1DD9811 VA: 0x1DD9710
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_Status
	|
	|-RVA: 0x1DD9AF0 Offset: 0x1DD9BF1 VA: 0x1DD9AF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD9F00 Offset: 0x1DDA001 VA: 0x1DD9F00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x1DDA2E0 Offset: 0x1DDA3E1 VA: 0x1DDA2E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DDA700 Offset: 0x1DDA801 VA: 0x1DDA700
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x1DDAB00 Offset: 0x1DDAC01 VA: 0x1DDAB00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DDAF50 Offset: 0x1DDB051 VA: 0x1DDAF50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x1DDB320 Offset: 0x1DDB421 VA: 0x1DDB320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DDB700 Offset: 0x1DDB801 VA: 0x1DDB700
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x1DDBAD0 Offset: 0x1DDBBD1 VA: 0x1DDBAD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_Status
	|
	|-RVA: 0x1DDBDE0 Offset: 0x1DDBEE1 VA: 0x1DDBDE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_Status
	|
	|-RVA: 0x1DDC120 Offset: 0x1DDC221 VA: 0x1DDC120
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_Status
	|
	|-RVA: 0x1DDC480 Offset: 0x1DDC581 VA: 0x1DDC480
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_Status
	|
	|-RVA: 0x1DDC7C0 Offset: 0x1DDC8C1 VA: 0x1DDC7C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_Status
	|
	|-RVA: 0x1DDCB50 Offset: 0x1DDCC51 VA: 0x1DDCB50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_Status
	|
	|-RVA: 0x1DDCED0 Offset: 0x1DDCFD1 VA: 0x1DDCED0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_Status
	|
	|-RVA: 0x1DDD240 Offset: 0x1DDD341 VA: 0x1DDD240
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_Status
	|
	|-RVA: 0x1DDD5D0 Offset: 0x1DDD6D1 VA: 0x1DDD5D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DDD960 Offset: 0x1DDDA61 VA: 0x1DDD960
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_Status
	|
	|-RVA: 0x1DDDCF0 Offset: 0x1DDDDF1 VA: 0x1DDDCF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_Status
	|
	|-RVA: 0x1DDE070 Offset: 0x1DDE171 VA: 0x1DDE070
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_Status
	|
	|-RVA: 0x1DDE3E0 Offset: 0x1DDE4E1 VA: 0x1DDE3E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_Status
	|
	|-RVA: 0x1DDE740 Offset: 0x1DDE841 VA: 0x1DDE740
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_Status
	|
	|-RVA: 0x1DDEA70 Offset: 0x1DDEB71 VA: 0x1DDEA70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_Status
	|
	|-RVA: 0x1DDEDE0 Offset: 0x1DDEEE1 VA: 0x1DDEDE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_Status
	|
	|-RVA: 0x1DDF160 Offset: 0x1DDF261 VA: 0x1DDF160
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_Status
	|
	|-RVA: 0x1DDF4F0 Offset: 0x1DDF5F1 VA: 0x1DDF4F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_Status
	|
	|-RVA: 0x1DDF880 Offset: 0x1DDF981 VA: 0x1DDF880
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_Status
	|
	|-RVA: 0x1DDFC20 Offset: 0x1DDFD21 VA: 0x1DDFC20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DDFFE0 Offset: 0x1DE00E1 VA: 0x1DDFFE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_Status
	|
	|-RVA: 0x1DE0380 Offset: 0x1DE0481 VA: 0x1DE0380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE0760 Offset: 0x1DE0861 VA: 0x1DE0760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x1DE0B40 Offset: 0x1DE0C41 VA: 0x1DE0B40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE0F50 Offset: 0x1DE1051 VA: 0x1DE0F50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x1DE1330 Offset: 0x1DE1431 VA: 0x1DE1330
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE1750 Offset: 0x1DE1851 VA: 0x1DE1750
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x1DE1B50 Offset: 0x1DE1C51 VA: 0x1DE1B50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE1FB0 Offset: 0x1DE20B1 VA: 0x1DE1FB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x1DE2380 Offset: 0x1DE2481 VA: 0x1DE2380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DE2710 Offset: 0x1DE2811 VA: 0x1DE2710
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DE2A70 Offset: 0x1DE2B71 VA: 0x1DE2A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_Status
	|
	|-RVA: 0x1DE2D80 Offset: 0x1DE2E81 VA: 0x1DE2D80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.get_Status
	|
	|-RVA: 0x1DE30C0 Offset: 0x1DE31C1 VA: 0x1DE30C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_Status
	|
	|-RVA: 0x1DE3420 Offset: 0x1DE3521 VA: 0x1DE3420
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.get_Status
	|
	|-RVA: 0x1DE3750 Offset: 0x1DE3851 VA: 0x1DE3750
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.get_Status
	|
	|-RVA: 0x1DE3AC0 Offset: 0x1DE3BC1 VA: 0x1DE3AC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.get_Status
	|
	|-RVA: 0x1DE3E30 Offset: 0x1DE3F31 VA: 0x1DE3E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.get_Status
	|
	|-RVA: 0x1DE4190 Offset: 0x1DE4291 VA: 0x1DE4190
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.get_Status
	|
	|-RVA: 0x1DE4500 Offset: 0x1DE4601 VA: 0x1DE4500
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DE4870 Offset: 0x1DE4971 VA: 0x1DE4870
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_Status
	|
	|-RVA: 0x1DE4BE0 Offset: 0x1DE4CE1 VA: 0x1DE4BE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_Status
	|
	|-RVA: 0x1DE4F50 Offset: 0x1DE5051 VA: 0x1DE4F50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.get_Status
	|
	|-RVA: 0x1DE52B0 Offset: 0x1DE53B1 VA: 0x1DE52B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_Status
	|
	|-RVA: 0x1DE5600 Offset: 0x1DE5701 VA: 0x1DE5600
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_Status
	|
	|-RVA: 0x1DE5930 Offset: 0x1DE5A31 VA: 0x1DE5930
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_Status
	|
	|-RVA: 0x1DE5C90 Offset: 0x1DE5D91 VA: 0x1DE5C90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_Status
	|
	|-RVA: 0x1DE6000 Offset: 0x1DE6101 VA: 0x1DE6000
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_Status
	|
	|-RVA: 0x1DE6370 Offset: 0x1DE6471 VA: 0x1DE6370
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.get_Status
	|
	|-RVA: 0x1DE66E0 Offset: 0x1DE67E1 VA: 0x1DE66E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.get_Status
	|
	|-RVA: 0x1DE6A70 Offset: 0x1DE6B71 VA: 0x1DE6A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DE6E30 Offset: 0x1DE6F31 VA: 0x1DE6E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.get_Status
	|
	|-RVA: 0x1DE71D0 Offset: 0x1DE72D1 VA: 0x1DE71D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DE75A0 Offset: 0x1DE76A1 VA: 0x1DE75A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_Status
	|
	|-RVA: 0x1DE7950 Offset: 0x1DE7A51 VA: 0x1DE7950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DE7D60 Offset: 0x1DE7E61 VA: 0x1DE7D60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x1DE8140 Offset: 0x1DE8241 VA: 0x1DE8140
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DE8560 Offset: 0x1DE8661 VA: 0x1DE8560
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x1DE8950 Offset: 0x1DE8A51 VA: 0x1DE8950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DE8DA0 Offset: 0x1DE8EA1 VA: 0x1DE8DA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x1DE9170 Offset: 0x1DE9271 VA: 0x1DE9170
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE9530 Offset: 0x1DE9631 VA: 0x1DE9530
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE9890 Offset: 0x1DE9991 VA: 0x1DE9890
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.get_Status
	|
	|-RVA: 0x1DE9DF0 Offset: 0x1DE9EF1 VA: 0x1DE9DF0
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.get_Status
	|
	|-RVA: 0x1DEA130 Offset: 0x1DEA231 VA: 0x1DEA130
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.get_Status
	|
	|-RVA: 0x1DEA490 Offset: 0x1DEA591 VA: 0x1DEA490
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.get_Status
	|
	|-RVA: 0x1DEA7C0 Offset: 0x1DEA8C1 VA: 0x1DEA7C0
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.get_Status
	|
	|-RVA: 0x1DEAB30 Offset: 0x1DEAC31 VA: 0x1DEAB30
	|-UniTask.Awaiter<ValueTuple<bool, double>>.get_Status
	|
	|-RVA: 0x1DEAE70 Offset: 0x1DEAF71 VA: 0x1DEAE70
	|-UniTask.Awaiter<ValueTuple<bool, int>>.get_Status
	|
	|-RVA: 0x1DEB1A0 Offset: 0x1DEB2A1 VA: 0x1DEB1A0
	|-UniTask.Awaiter<ValueTuple<bool, long>>.get_Status
	|
	|-RVA: 0x1DEB500 Offset: 0x1DEB601 VA: 0x1DEB500
	|-UniTask.Awaiter<ValueTuple<bool, object>>.get_Status
	|
	|-RVA: 0x1DEBAD0 Offset: 0x1DEBBD1 VA: 0x1DEBAD0
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.get_Status
	|
	|-RVA: 0x1DEBE40 Offset: 0x1DEBF41 VA: 0x1DEBE40
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.get_Status
	|
	|-RVA: 0x1DEC190 Offset: 0x1DEC291 VA: 0x1DEC190
	|-UniTask.Awaiter<ValueTuple<bool, float>>.get_Status
	|
	|-RVA: 0x1DEC4C0 Offset: 0x1DEC5C1 VA: 0x1DEC4C0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.get_Status
	|
	|-RVA: 0x1DEC800 Offset: 0x1DEC901 VA: 0x1DEC800
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.get_Status
	|
	|-RVA: 0x1DECB30 Offset: 0x1DECC31 VA: 0x1DECB30
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.get_Status
	|
	|-RVA: 0x1DECE90 Offset: 0x1DECF91 VA: 0x1DECE90
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.get_Status
	|
	|-RVA: 0x1DED1F0 Offset: 0x1DED2F1 VA: 0x1DED1F0
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.get_Status
	|
	|-RVA: 0x1DED560 Offset: 0x1DED661 VA: 0x1DED560
	|-UniTask.Awaiter<ValueTuple<int, object>>.get_Status
	|
	|-RVA: 0x1DED8C0 Offset: 0x1DED9C1 VA: 0x1DED8C0
	|-UniTask.Awaiter<ValueTuple<object, object>>.get_Status
	|
	|-RVA: 0x1DEDC30 Offset: 0x1DEDD31 VA: 0x1DEDC30
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DEDFB0 Offset: 0x1DEE0B1 VA: 0x1DEDFB0
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.get_Status
	|
	|-RVA: 0x1DEE340 Offset: 0x1DEE441 VA: 0x1DEE340
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DEE700 Offset: 0x1DEE801 VA: 0x1DEE700
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.get_Status
	|
	|-RVA: 0x1DEEAA0 Offset: 0x1DEEBA1 VA: 0x1DEEAA0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DEEE70 Offset: 0x1DEEF71 VA: 0x1DEEE70
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x1DEF220 Offset: 0x1DEF321 VA: 0x1DEF220
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DEF630 Offset: 0x1DEF731 VA: 0x1DEF630
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x1DEFA10 Offset: 0x1DEFB11 VA: 0x1DEFA10
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DEFE30 Offset: 0x1DEFF31 VA: 0x1DEFE30
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x1DF0220 Offset: 0x1DF0321 VA: 0x1DF0220
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DF0670 Offset: 0x1DF0771 VA: 0x1DF0670
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DF09D0 Offset: 0x1DF0AD1 VA: 0x1DF09D0
	|-UniTask.Awaiter<AsyncUnit>.get_Status
	|
	|-RVA: 0x1DF0CE0 Offset: 0x1DF0DE1 VA: 0x1DF0CE0
	|-UniTask.Awaiter<bool>.get_Status
	|
	|-RVA: 0x1DF1010 Offset: 0x1DF1111 VA: 0x1DF1010
	|-UniTask.Awaiter<Bounds>.get_Status
	|
	|-RVA: 0x1DF1360 Offset: 0x1DF1461 VA: 0x1DF1360
	|-UniTask.Awaiter<byte>.get_Status
	|
	|-RVA: 0x1DF1690 Offset: 0x1DF1791 VA: 0x1DF1690
	|-UniTask.Awaiter<Color>.get_Status
	|
	|-RVA: 0x1DF19D0 Offset: 0x1DF1AD1 VA: 0x1DF19D0
	|-UniTask.Awaiter<double>.get_Status
	|
	|-RVA: 0x1DF1CE0 Offset: 0x1DF1DE1 VA: 0x1DF1CE0
	|-UniTask.Awaiter<int>.get_Status
	|
	|-RVA: 0x1DF1FF0 Offset: 0x1DF20F1 VA: 0x1DF1FF0
	|-UniTask.Awaiter<long>.get_Status
	|
	|-RVA: 0x1DF2300 Offset: 0x1DF2401 VA: 0x1DF2300
	|-UniTask.Awaiter<object>.get_Status
	|
	|-RVA: 0x1DF2C80 Offset: 0x1DF2D81 VA: 0x1DF2C80
	|-UniTask.Awaiter<Quaternion>.get_Status
	|
	|-RVA: 0x1DF2FE0 Offset: 0x1DF30E1 VA: 0x1DF2FE0
	|-UniTask.Awaiter<Rect>.get_Status
	|
	|-RVA: 0x1DF3320 Offset: 0x1DF3421 VA: 0x1DF3320
	|-UniTask.Awaiter<float>.get_Status
	|
	|-RVA: 0x1DF3630 Offset: 0x1DF3731 VA: 0x1DF3630
	|-UniTask.Awaiter<UniTask>.get_Status
	|
	|-RVA: 0x1DF3940 Offset: 0x1DF3A41 VA: 0x1DF3940
	|-UniTask.Awaiter<Unit>.get_Status
	|
	|-RVA: 0x1DF3C50 Offset: 0x1DF3D51 VA: 0x1DF3C50
	|-UniTask.Awaiter<Vector2>.get_Status
	|
	|-RVA: 0x1DF3F80 Offset: 0x1DF4081 VA: 0x1DF3F80
	|-UniTask.Awaiter<Vector3>.get_Status
	|
	|-RVA: 0x1DF42E0 Offset: 0x1DF43E1 VA: 0x1DF42E0
	|-UniTask.Awaiter<Vector4>.get_Status
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CF30 Offset: 0x2D031 VA: 0x2CF30
	// RVA: -1 Offset: -1 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F240 Offset: 0x2F5F341 VA: 0x2F5F240
	|-UniTask.Awaiter<UniTask<object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F5F5A0 Offset: 0x2F5F6A1 VA: 0x2F5F5A0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F5F920 Offset: 0x2F5FA21 VA: 0x2F5F920
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F5FCB0 Offset: 0x2F5FDB1 VA: 0x2F5FCB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F60060 Offset: 0x2F60161 VA: 0x2F60060
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F603D0 Offset: 0x2F604D1 VA: 0x2F603D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F606E0 Offset: 0x2F607E1 VA: 0x2F606E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F60A50 Offset: 0x2F60B51 VA: 0x2F60A50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F60DC0 Offset: 0x2F60EC1 VA: 0x2F60DC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F61110 Offset: 0x2F61211 VA: 0x2F61110
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F614C0 Offset: 0x2F615C1 VA: 0x2F614C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F61860 Offset: 0x2F61961 VA: 0x2F61860
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F61C00 Offset: 0x2F61D01 VA: 0x2F61C00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F61FD0 Offset: 0x2F620D1 VA: 0x2F61FD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F62380 Offset: 0x2F62481 VA: 0x2F62380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F62710 Offset: 0x2F62811 VA: 0x2F62710
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F62A90 Offset: 0x2F62B91 VA: 0x2F62A90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F62E30 Offset: 0x2F62F31 VA: 0x2F62E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F631A0 Offset: 0x2F632A1 VA: 0x2F631A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F634F0 Offset: 0x2F635F1 VA: 0x2F634F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F63880 Offset: 0x2F63981 VA: 0x2F63880
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F63C10 Offset: 0x2F63D11 VA: 0x2F63C10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F63FC0 Offset: 0x2F640C1 VA: 0x2F63FC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F64390 Offset: 0x2F64491 VA: 0x2F64390
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F64760 Offset: 0x2F64861 VA: 0x2F64760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F64B30 Offset: 0x2F64C31 VA: 0x2F64B30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD4630 Offset: 0x1DD4731 VA: 0x1DD4630
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD4A30 Offset: 0x1DD4B31 VA: 0x1DD4A30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD4E50 Offset: 0x1DD4F51 VA: 0x1DD4E50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD51F0 Offset: 0x1DD52F1 VA: 0x1DD51F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD5500 Offset: 0x1DD5601 VA: 0x1DD5500
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD5850 Offset: 0x1DD5951 VA: 0x1DD5850
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD5BA0 Offset: 0x1DD5CA1 VA: 0x1DD5BA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD5EF0 Offset: 0x1DD5FF1 VA: 0x1DD5EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD6280 Offset: 0x1DD6381 VA: 0x1DD6280
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD6600 Offset: 0x1DD6701 VA: 0x1DD6600
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD6980 Offset: 0x1DD6A81 VA: 0x1DD6980
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD6D10 Offset: 0x1DD6E11 VA: 0x1DD6D10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD70A0 Offset: 0x1DD71A1 VA: 0x1DD70A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD7430 Offset: 0x1DD7531 VA: 0x1DD7430
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD77B0 Offset: 0x1DD78B1 VA: 0x1DD77B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD7B30 Offset: 0x1DD7C31 VA: 0x1DD7B30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD7E80 Offset: 0x1DD7F81 VA: 0x1DD7E80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD81C0 Offset: 0x1DD82C1 VA: 0x1DD81C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD8540 Offset: 0x1DD8641 VA: 0x1DD8540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD88D0 Offset: 0x1DD89D1 VA: 0x1DD88D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD8C60 Offset: 0x1DD8D61 VA: 0x1DD8C60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD8FF0 Offset: 0x1DD90F1 VA: 0x1DD8FF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD93A0 Offset: 0x1DD94A1 VA: 0x1DD93A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD9780 Offset: 0x1DD9881 VA: 0x1DD9780
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD9B70 Offset: 0x1DD9C71 VA: 0x1DD9B70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD9F70 Offset: 0x1DDA071 VA: 0x1DD9F70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDA360 Offset: 0x1DDA461 VA: 0x1DDA360
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDA770 Offset: 0x1DDA871 VA: 0x1DDA770
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDAB90 Offset: 0x1DDAC91 VA: 0x1DDAB90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDAFC0 Offset: 0x1DDB0C1 VA: 0x1DDAFC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDB380 Offset: 0x1DDB481 VA: 0x1DDB380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDB780 Offset: 0x1DDB881 VA: 0x1DDB780
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDBB20 Offset: 0x1DDBC21 VA: 0x1DDBB20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDBE30 Offset: 0x1DDBF31 VA: 0x1DDBE30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDC180 Offset: 0x1DDC281 VA: 0x1DDC180
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDC4D0 Offset: 0x1DDC5D1 VA: 0x1DDC4D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDC820 Offset: 0x1DDC921 VA: 0x1DDC820
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDCBB0 Offset: 0x1DDCCB1 VA: 0x1DDCBB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDCF30 Offset: 0x1DDD031 VA: 0x1DDCF30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDD2A0 Offset: 0x1DDD3A1 VA: 0x1DDD2A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDD630 Offset: 0x1DDD731 VA: 0x1DDD630
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDD9C0 Offset: 0x1DDDAC1 VA: 0x1DDD9C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDDD50 Offset: 0x1DDDE51 VA: 0x1DDDD50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDE0D0 Offset: 0x1DDE1D1 VA: 0x1DDE0D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDE440 Offset: 0x1DDE541 VA: 0x1DDE440
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDE790 Offset: 0x1DDE891 VA: 0x1DDE790
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDEAD0 Offset: 0x1DDEBD1 VA: 0x1DDEAD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDEE40 Offset: 0x1DDEF41 VA: 0x1DDEE40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDF1C0 Offset: 0x1DDF2C1 VA: 0x1DDF1C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDF550 Offset: 0x1DDF651 VA: 0x1DDF550
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDF8E0 Offset: 0x1DDF9E1 VA: 0x1DDF8E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDFC90 Offset: 0x1DDFD91 VA: 0x1DDFC90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE0040 Offset: 0x1DE0141 VA: 0x1DE0040
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE03F0 Offset: 0x1DE04F1 VA: 0x1DE03F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE07D0 Offset: 0x1DE08D1 VA: 0x1DE07D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE0BC0 Offset: 0x1DE0CC1 VA: 0x1DE0BC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE0FC0 Offset: 0x1DE10C1 VA: 0x1DE0FC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE13B0 Offset: 0x1DE14B1 VA: 0x1DE13B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE17C0 Offset: 0x1DE18C1 VA: 0x1DE17C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE1BE0 Offset: 0x1DE1CE1 VA: 0x1DE1BE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE2020 Offset: 0x1DE2121 VA: 0x1DE2020
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE23E0 Offset: 0x1DE24E1 VA: 0x1DE23E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE2770 Offset: 0x1DE2871 VA: 0x1DE2770
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE2AC0 Offset: 0x1DE2BC1 VA: 0x1DE2AC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE2DD0 Offset: 0x1DE2ED1 VA: 0x1DE2DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE3120 Offset: 0x1DE3221 VA: 0x1DE3120
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE3470 Offset: 0x1DE3571 VA: 0x1DE3470
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE37B0 Offset: 0x1DE38B1 VA: 0x1DE37B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE3B20 Offset: 0x1DE3C21 VA: 0x1DE3B20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE3E90 Offset: 0x1DE3F91 VA: 0x1DE3E90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE41F0 Offset: 0x1DE42F1 VA: 0x1DE41F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE4560 Offset: 0x1DE4661 VA: 0x1DE4560
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE48D0 Offset: 0x1DE49D1 VA: 0x1DE48D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE4C40 Offset: 0x1DE4D41 VA: 0x1DE4C40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE4FB0 Offset: 0x1DE50B1 VA: 0x1DE4FB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE5310 Offset: 0x1DE5411 VA: 0x1DE5310
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE5650 Offset: 0x1DE5751 VA: 0x1DE5650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE5990 Offset: 0x1DE5A91 VA: 0x1DE5990
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE5CF0 Offset: 0x1DE5DF1 VA: 0x1DE5CF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE6060 Offset: 0x1DE6161 VA: 0x1DE6060
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE63D0 Offset: 0x1DE64D1 VA: 0x1DE63D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE6740 Offset: 0x1DE6841 VA: 0x1DE6740
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE6AE0 Offset: 0x1DE6BE1 VA: 0x1DE6AE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE6E90 Offset: 0x1DE6F91 VA: 0x1DE6E90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE7240 Offset: 0x1DE7341 VA: 0x1DE7240
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE7600 Offset: 0x1DE7701 VA: 0x1DE7600
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE79D0 Offset: 0x1DE7AD1 VA: 0x1DE79D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE7DD0 Offset: 0x1DE7ED1 VA: 0x1DE7DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE81C0 Offset: 0x1DE82C1 VA: 0x1DE81C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE85D0 Offset: 0x1DE86D1 VA: 0x1DE85D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE89E0 Offset: 0x1DE8AE1 VA: 0x1DE89E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE8E10 Offset: 0x1DE8F11 VA: 0x1DE8E10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE91D0 Offset: 0x1DE92D1 VA: 0x1DE91D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE9590 Offset: 0x1DE9691 VA: 0x1DE9590
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE98E0 Offset: 0x1DE99E1 VA: 0x1DE98E0
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE9E40 Offset: 0x1DE9F41 VA: 0x1DE9E40
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEA190 Offset: 0x1DEA291 VA: 0x1DEA190
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEA4E0 Offset: 0x1DEA5E1 VA: 0x1DEA4E0
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEA820 Offset: 0x1DEA921 VA: 0x1DEA820
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEAB90 Offset: 0x1DEAC91 VA: 0x1DEAB90
	|-UniTask.Awaiter<ValueTuple<bool, double>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEAEC0 Offset: 0x1DEAFC1 VA: 0x1DEAEC0
	|-UniTask.Awaiter<ValueTuple<bool, int>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEB200 Offset: 0x1DEB301 VA: 0x1DEB200
	|-UniTask.Awaiter<ValueTuple<bool, long>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEB560 Offset: 0x1DEB661 VA: 0x1DEB560
	|-UniTask.Awaiter<ValueTuple<bool, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEBB30 Offset: 0x1DEBC31 VA: 0x1DEBB30
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEBEA0 Offset: 0x1DEBFA1 VA: 0x1DEBEA0
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEC1E0 Offset: 0x1DEC2E1 VA: 0x1DEC1E0
	|-UniTask.Awaiter<ValueTuple<bool, float>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEC520 Offset: 0x1DEC621 VA: 0x1DEC520
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEC850 Offset: 0x1DEC951 VA: 0x1DEC850
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DECB90 Offset: 0x1DECC91 VA: 0x1DECB90
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DECEF0 Offset: 0x1DECFF1 VA: 0x1DECEF0
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DED250 Offset: 0x1DED351 VA: 0x1DED250
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DED5C0 Offset: 0x1DED6C1 VA: 0x1DED5C0
	|-UniTask.Awaiter<ValueTuple<int, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DED920 Offset: 0x1DEDA21 VA: 0x1DED920
	|-UniTask.Awaiter<ValueTuple<object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEDC90 Offset: 0x1DEDD91 VA: 0x1DEDC90
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEE010 Offset: 0x1DEE111 VA: 0x1DEE010
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEE3B0 Offset: 0x1DEE4B1 VA: 0x1DEE3B0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEE760 Offset: 0x1DEE861 VA: 0x1DEE760
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEEB10 Offset: 0x1DEEC11 VA: 0x1DEEB10
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEEED0 Offset: 0x1DEEFD1 VA: 0x1DEEED0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEF2A0 Offset: 0x1DEF3A1 VA: 0x1DEF2A0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEF6A0 Offset: 0x1DEF7A1 VA: 0x1DEF6A0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEFA90 Offset: 0x1DEFB91 VA: 0x1DEFA90
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEFEA0 Offset: 0x1DEFFA1 VA: 0x1DEFEA0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF02B0 Offset: 0x1DF03B1 VA: 0x1DF02B0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF06D0 Offset: 0x1DF07D1 VA: 0x1DF06D0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF0A20 Offset: 0x1DF0B21 VA: 0x1DF0A20
	|-UniTask.Awaiter<AsyncUnit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF0D30 Offset: 0x1DF0E31 VA: 0x1DF0D30
	|-UniTask.Awaiter<bool>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF1070 Offset: 0x1DF1171 VA: 0x1DF1070
	|-UniTask.Awaiter<Bounds>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF13B0 Offset: 0x1DF14B1 VA: 0x1DF13B0
	|-UniTask.Awaiter<byte>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF16F0 Offset: 0x1DF17F1 VA: 0x1DF16F0
	|-UniTask.Awaiter<Color>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF1A20 Offset: 0x1DF1B21 VA: 0x1DF1A20
	|-UniTask.Awaiter<double>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF1D30 Offset: 0x1DF1E31 VA: 0x1DF1D30
	|-UniTask.Awaiter<int>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF2040 Offset: 0x1DF2141 VA: 0x1DF2040
	|-UniTask.Awaiter<long>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF2350 Offset: 0x1DF2451 VA: 0x1DF2350
	|-UniTask.Awaiter<object>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF2CE0 Offset: 0x1DF2DE1 VA: 0x1DF2CE0
	|-UniTask.Awaiter<Quaternion>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3040 Offset: 0x1DF3141 VA: 0x1DF3040
	|-UniTask.Awaiter<Rect>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3370 Offset: 0x1DF3471 VA: 0x1DF3370
	|-UniTask.Awaiter<float>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3680 Offset: 0x1DF3781 VA: 0x1DF3680
	|-UniTask.Awaiter<UniTask>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3990 Offset: 0x1DF3A91 VA: 0x1DF3990
	|-UniTask.Awaiter<Unit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3CA0 Offset: 0x1DF3DA1 VA: 0x1DF3CA0
	|-UniTask.Awaiter<Vector2>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3FE0 Offset: 0x1DF40E1 VA: 0x1DF3FE0
	|-UniTask.Awaiter<Vector3>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF4340 Offset: 0x1DF4441 VA: 0x1DF4340
	|-UniTask.Awaiter<Vector4>.UniRx.Async.IAwaiter.GetResult
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CF40 Offset: 0x2D041 VA: 0x2CF40
	// RVA: -1 Offset: -1 Slot: 4
	public T GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F2C0 Offset: 0x2F5F3C1 VA: 0x2F5F2C0
	|-UniTask.Awaiter<UniTask<object>>.GetResult
	|
	|-RVA: 0x2F5F620 Offset: 0x2F5F721 VA: 0x2F5F620
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.GetResult
	|
	|-RVA: 0x2F5F9A0 Offset: 0x2F5FAA1 VA: 0x2F5F9A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetResult
	|
	|-RVA: 0x2F5FD30 Offset: 0x2F5FE31 VA: 0x2F5FD30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetResult
	|
	|-RVA: 0x2F600F0 Offset: 0x2F601F1 VA: 0x2F600F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetResult
	|
	|-RVA: 0x2F60440 Offset: 0x2F60541 VA: 0x2F60440
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetResult
	|
	|-RVA: 0x2F60750 Offset: 0x2F60851 VA: 0x2F60750
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetResult
	|
	|-RVA: 0x2F60AE0 Offset: 0x2F60BE1 VA: 0x2F60AE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetResult
	|
	|-RVA: 0x2F60E30 Offset: 0x2F60F31 VA: 0x2F60E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetResult
	|
	|-RVA: 0x2F61190 Offset: 0x2F61291 VA: 0x2F61190
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetResult
	|
	|-RVA: 0x2F61550 Offset: 0x2F61651 VA: 0x2F61550
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetResult
	|
	|-RVA: 0x2F618E0 Offset: 0x2F619E1 VA: 0x2F618E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetResult
	|
	|-RVA: 0x2F61C90 Offset: 0x2F61D91 VA: 0x2F61C90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetResult
	|
	|-RVA: 0x2F62060 Offset: 0x2F62161 VA: 0x2F62060
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2F62400 Offset: 0x2F62501 VA: 0x2F62400
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetResult
	|
	|-RVA: 0x2F62790 Offset: 0x2F62891 VA: 0x2F62790
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetResult
	|
	|-RVA: 0x2F62B10 Offset: 0x2F62C11 VA: 0x2F62B10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetResult
	|
	|-RVA: 0x2F62EC0 Offset: 0x2F62FC1 VA: 0x2F62EC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetResult
	|
	|-RVA: 0x2F63210 Offset: 0x2F63311 VA: 0x2F63210
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetResult
	|
	|-RVA: 0x2F63570 Offset: 0x2F63671 VA: 0x2F63570
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetResult
	|
	|-RVA: 0x2F63900 Offset: 0x2F63A01 VA: 0x2F63900
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetResult
	|
	|-RVA: 0x2F63C90 Offset: 0x2F63D91 VA: 0x2F63C90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetResult
	|
	|-RVA: 0x2F64050 Offset: 0x2F64151 VA: 0x2F64050
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetResult
	|
	|-RVA: 0x2F64420 Offset: 0x2F64521 VA: 0x2F64420
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetResult
	|
	|-RVA: 0x2F647F0 Offset: 0x2F648F1 VA: 0x2F647F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x2F64BC0 Offset: 0x2F64CC1 VA: 0x2F64BC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x1DD46C0 Offset: 0x1DD47C1 VA: 0x1DD46C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x1DD4AD0 Offset: 0x1DD4BD1 VA: 0x1DD4AD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x1DD4EF0 Offset: 0x1DD4FF1 VA: 0x1DD4EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x1DD5260 Offset: 0x1DD5361 VA: 0x1DD5260
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetResult
	|
	|-RVA: 0x1DD5570 Offset: 0x1DD5671 VA: 0x1DD5570
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetResult
	|
	|-RVA: 0x1DD58D0 Offset: 0x1DD59D1 VA: 0x1DD58D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetResult
	|
	|-RVA: 0x1DD5C10 Offset: 0x1DD5D11 VA: 0x1DD5C10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetResult
	|
	|-RVA: 0x1DD5F70 Offset: 0x1DD6071 VA: 0x1DD5F70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetResult
	|
	|-RVA: 0x1DD6300 Offset: 0x1DD6401 VA: 0x1DD6300
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetResult
	|
	|-RVA: 0x1DD6680 Offset: 0x1DD6781 VA: 0x1DD6680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetResult
	|
	|-RVA: 0x1DD6A00 Offset: 0x1DD6B01 VA: 0x1DD6A00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetResult
	|
	|-RVA: 0x1DD6D90 Offset: 0x1DD6E91 VA: 0x1DD6D90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DD7120 Offset: 0x1DD7221 VA: 0x1DD7120
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetResult
	|
	|-RVA: 0x1DD74B0 Offset: 0x1DD75B1 VA: 0x1DD74B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetResult
	|
	|-RVA: 0x1DD7830 Offset: 0x1DD7931 VA: 0x1DD7830
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetResult
	|
	|-RVA: 0x1DD7BB0 Offset: 0x1DD7CB1 VA: 0x1DD7BB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetResult
	|
	|-RVA: 0x1DD7EF0 Offset: 0x1DD7FF1 VA: 0x1DD7EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetResult
	|
	|-RVA: 0x1DD8240 Offset: 0x1DD8341 VA: 0x1DD8240
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetResult
	|
	|-RVA: 0x1DD85C0 Offset: 0x1DD86C1 VA: 0x1DD85C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetResult
	|
	|-RVA: 0x1DD8950 Offset: 0x1DD8A51 VA: 0x1DD8950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetResult
	|
	|-RVA: 0x1DD8CE0 Offset: 0x1DD8DE1 VA: 0x1DD8CE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetResult
	|
	|-RVA: 0x1DD9070 Offset: 0x1DD9171 VA: 0x1DD9070
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetResult
	|
	|-RVA: 0x1DD9430 Offset: 0x1DD9531 VA: 0x1DD9430
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DD9810 Offset: 0x1DD9911 VA: 0x1DD9810
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetResult
	|
	|-RVA: 0x1DD9C10 Offset: 0x1DD9D11 VA: 0x1DD9C10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DDA000 Offset: 0x1DDA101 VA: 0x1DDA000
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x1DDA400 Offset: 0x1DDA501 VA: 0x1DDA400
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DDA800 Offset: 0x1DDA901 VA: 0x1DDA800
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x1DDAC40 Offset: 0x1DDAD41 VA: 0x1DDAC40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DDB050 Offset: 0x1DDB151 VA: 0x1DDB050
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x1DDB400 Offset: 0x1DDB501 VA: 0x1DDB400
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DDB820 Offset: 0x1DDB921 VA: 0x1DDB820
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x1DDBB90 Offset: 0x1DDBC91 VA: 0x1DDBB90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetResult
	|
	|-RVA: 0x1DDBEA0 Offset: 0x1DDBFA1 VA: 0x1DDBEA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetResult
	|
	|-RVA: 0x1DDC200 Offset: 0x1DDC301 VA: 0x1DDC200
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetResult
	|
	|-RVA: 0x1DDC540 Offset: 0x1DDC641 VA: 0x1DDC540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetResult
	|
	|-RVA: 0x1DDC8A0 Offset: 0x1DDC9A1 VA: 0x1DDC8A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetResult
	|
	|-RVA: 0x1DDCC30 Offset: 0x1DDCD31 VA: 0x1DDCC30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetResult
	|
	|-RVA: 0x1DDCFB0 Offset: 0x1DDD0B1 VA: 0x1DDCFB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetResult
	|
	|-RVA: 0x1DDD320 Offset: 0x1DDD421 VA: 0x1DDD320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetResult
	|
	|-RVA: 0x1DDD6B0 Offset: 0x1DDD7B1 VA: 0x1DDD6B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DDDA40 Offset: 0x1DDDB41 VA: 0x1DDDA40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetResult
	|
	|-RVA: 0x1DDDDD0 Offset: 0x1DDDED1 VA: 0x1DDDDD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetResult
	|
	|-RVA: 0x1DDE150 Offset: 0x1DDE251 VA: 0x1DDE150
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetResult
	|
	|-RVA: 0x1DDE4C0 Offset: 0x1DDE5C1 VA: 0x1DDE4C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetResult
	|
	|-RVA: 0x1DDE800 Offset: 0x1DDE901 VA: 0x1DDE800
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetResult
	|
	|-RVA: 0x1DDEB50 Offset: 0x1DDEC51 VA: 0x1DDEB50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetResult
	|
	|-RVA: 0x1DDEEC0 Offset: 0x1DDEFC1 VA: 0x1DDEEC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetResult
	|
	|-RVA: 0x1DDF240 Offset: 0x1DDF341 VA: 0x1DDF240
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetResult
	|
	|-RVA: 0x1DDF5D0 Offset: 0x1DDF6D1 VA: 0x1DDF5D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetResult
	|
	|-RVA: 0x1DDF960 Offset: 0x1DDFA61 VA: 0x1DDF960
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetResult
	|
	|-RVA: 0x1DDFD20 Offset: 0x1DDFE21 VA: 0x1DDFD20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE00C0 Offset: 0x1DE01C1 VA: 0x1DE00C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetResult
	|
	|-RVA: 0x1DE0480 Offset: 0x1DE0581 VA: 0x1DE0480
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE0860 Offset: 0x1DE0961 VA: 0x1DE0860
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x1DE0C60 Offset: 0x1DE0D61 VA: 0x1DE0C60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE1050 Offset: 0x1DE1151 VA: 0x1DE1050
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x1DE1450 Offset: 0x1DE1551 VA: 0x1DE1450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE1850 Offset: 0x1DE1951 VA: 0x1DE1850
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x1DE1C90 Offset: 0x1DE1D91 VA: 0x1DE1C90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE20B0 Offset: 0x1DE21B1 VA: 0x1DE20B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x1DE2460 Offset: 0x1DE2561 VA: 0x1DE2460
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DE27F0 Offset: 0x1DE28F1 VA: 0x1DE27F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DE2B30 Offset: 0x1DE2C31 VA: 0x1DE2B30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetResult
	|
	|-RVA: 0x1DE2E40 Offset: 0x1DE2F41 VA: 0x1DE2E40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.GetResult
	|
	|-RVA: 0x1DE31A0 Offset: 0x1DE32A1 VA: 0x1DE31A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetResult
	|
	|-RVA: 0x1DE34E0 Offset: 0x1DE35E1 VA: 0x1DE34E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.GetResult
	|
	|-RVA: 0x1DE3830 Offset: 0x1DE3931 VA: 0x1DE3830
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.GetResult
	|
	|-RVA: 0x1DE3BA0 Offset: 0x1DE3CA1 VA: 0x1DE3BA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.GetResult
	|
	|-RVA: 0x1DE3F10 Offset: 0x1DE4011 VA: 0x1DE3F10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.GetResult
	|
	|-RVA: 0x1DE4270 Offset: 0x1DE4371 VA: 0x1DE4270
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.GetResult
	|
	|-RVA: 0x1DE45E0 Offset: 0x1DE46E1 VA: 0x1DE45E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DE4950 Offset: 0x1DE4A51 VA: 0x1DE4950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetResult
	|
	|-RVA: 0x1DE4CC0 Offset: 0x1DE4DC1 VA: 0x1DE4CC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetResult
	|
	|-RVA: 0x1DE5030 Offset: 0x1DE5131 VA: 0x1DE5030
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.GetResult
	|
	|-RVA: 0x1DE5390 Offset: 0x1DE5491 VA: 0x1DE5390
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetResult
	|
	|-RVA: 0x1DE56C0 Offset: 0x1DE57C1 VA: 0x1DE56C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetResult
	|
	|-RVA: 0x1DE5A10 Offset: 0x1DE5B11 VA: 0x1DE5A10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetResult
	|
	|-RVA: 0x1DE5D70 Offset: 0x1DE5E71 VA: 0x1DE5D70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetResult
	|
	|-RVA: 0x1DE60E0 Offset: 0x1DE61E1 VA: 0x1DE60E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetResult
	|
	|-RVA: 0x1DE6450 Offset: 0x1DE6551 VA: 0x1DE6450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.GetResult
	|
	|-RVA: 0x1DE67C0 Offset: 0x1DE68C1 VA: 0x1DE67C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.GetResult
	|
	|-RVA: 0x1DE6B70 Offset: 0x1DE6C71 VA: 0x1DE6B70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DE6F10 Offset: 0x1DE7011 VA: 0x1DE6F10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.GetResult
	|
	|-RVA: 0x1DE72D0 Offset: 0x1DE73D1 VA: 0x1DE72D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DE7680 Offset: 0x1DE7781 VA: 0x1DE7680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetResult
	|
	|-RVA: 0x1DE7A70 Offset: 0x1DE7B71 VA: 0x1DE7A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DE7E60 Offset: 0x1DE7F61 VA: 0x1DE7E60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x1DE8260 Offset: 0x1DE8361 VA: 0x1DE8260
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DE8660 Offset: 0x1DE8761 VA: 0x1DE8660
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x1DE8A90 Offset: 0x1DE8B91 VA: 0x1DE8A90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DE8EA0 Offset: 0x1DE8FA1 VA: 0x1DE8EA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x1DE9250 Offset: 0x1DE9351 VA: 0x1DE9250
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE9610 Offset: 0x1DE9711 VA: 0x1DE9610
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE9950 Offset: 0x1DE9A51 VA: 0x1DE9950
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.GetResult
	|
	|-RVA: 0x1DE9EB0 Offset: 0x1DE9FB1 VA: 0x1DE9EB0
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.GetResult
	|
	|-RVA: 0x1DEA210 Offset: 0x1DEA311 VA: 0x1DEA210
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.GetResult
	|
	|-RVA: 0x1DEA550 Offset: 0x1DEA651 VA: 0x1DEA550
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.GetResult
	|
	|-RVA: 0x1DEA8A0 Offset: 0x1DEA9A1 VA: 0x1DEA8A0
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.GetResult
	|
	|-RVA: 0x1DEAC10 Offset: 0x1DEAD11 VA: 0x1DEAC10
	|-UniTask.Awaiter<ValueTuple<bool, double>>.GetResult
	|
	|-RVA: 0x1DEAF30 Offset: 0x1DEB031 VA: 0x1DEAF30
	|-UniTask.Awaiter<ValueTuple<bool, int>>.GetResult
	|
	|-RVA: 0x1DEB280 Offset: 0x1DEB381 VA: 0x1DEB280
	|-UniTask.Awaiter<ValueTuple<bool, long>>.GetResult
	|
	|-RVA: 0x1DEB5E0 Offset: 0x1DEB6E1 VA: 0x1DEB5E0
	|-UniTask.Awaiter<ValueTuple<bool, object>>.GetResult
	|
	|-RVA: 0x1DEBBB0 Offset: 0x1DEBCB1 VA: 0x1DEBBB0
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.GetResult
	|
	|-RVA: 0x1DEBF20 Offset: 0x1DEC021 VA: 0x1DEBF20
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.GetResult
	|
	|-RVA: 0x1DEC250 Offset: 0x1DEC351 VA: 0x1DEC250
	|-UniTask.Awaiter<ValueTuple<bool, float>>.GetResult
	|
	|-RVA: 0x1DEC5A0 Offset: 0x1DEC6A1 VA: 0x1DEC5A0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.GetResult
	|
	|-RVA: 0x1DEC8C0 Offset: 0x1DEC9C1 VA: 0x1DEC8C0
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.GetResult
	|
	|-RVA: 0x1DECC10 Offset: 0x1DECD11 VA: 0x1DECC10
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.GetResult
	|
	|-RVA: 0x1DECF70 Offset: 0x1DED071 VA: 0x1DECF70
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.GetResult
	|
	|-RVA: 0x1DED2D0 Offset: 0x1DED3D1 VA: 0x1DED2D0
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.GetResult
	|
	|-RVA: 0x1DED640 Offset: 0x1DED741 VA: 0x1DED640
	|-UniTask.Awaiter<ValueTuple<int, object>>.GetResult
	|
	|-RVA: 0x1DED9A0 Offset: 0x1DEDAA1 VA: 0x1DED9A0
	|-UniTask.Awaiter<ValueTuple<object, object>>.GetResult
	|
	|-RVA: 0x1DEDD10 Offset: 0x1DEDE11 VA: 0x1DEDD10
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DEE090 Offset: 0x1DEE191 VA: 0x1DEE090
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.GetResult
	|
	|-RVA: 0x1DEE440 Offset: 0x1DEE541 VA: 0x1DEE440
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DEE7E0 Offset: 0x1DEE8E1 VA: 0x1DEE7E0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.GetResult
	|
	|-RVA: 0x1DEEBA0 Offset: 0x1DEECA1 VA: 0x1DEEBA0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DEEF50 Offset: 0x1DEF051 VA: 0x1DEEF50
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x1DEF340 Offset: 0x1DEF441 VA: 0x1DEF340
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DEF730 Offset: 0x1DEF831 VA: 0x1DEF730
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x1DEFB30 Offset: 0x1DEFC31 VA: 0x1DEFB30
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DEFF30 Offset: 0x1DF0031 VA: 0x1DEFF30
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x1DF0360 Offset: 0x1DF0461 VA: 0x1DF0360
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DF0750 Offset: 0x1DF0851 VA: 0x1DF0750
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DF0A90 Offset: 0x1DF0B91 VA: 0x1DF0A90
	|-UniTask.Awaiter<AsyncUnit>.GetResult
	|
	|-RVA: 0x1DF0DA0 Offset: 0x1DF0EA1 VA: 0x1DF0DA0
	|-UniTask.Awaiter<bool>.GetResult
	|
	|-RVA: 0x1DF10F0 Offset: 0x1DF11F1 VA: 0x1DF10F0
	|-UniTask.Awaiter<Bounds>.GetResult
	|
	|-RVA: 0x1DF1420 Offset: 0x1DF1521 VA: 0x1DF1420
	|-UniTask.Awaiter<byte>.GetResult
	|
	|-RVA: 0x1DF1770 Offset: 0x1DF1871 VA: 0x1DF1770
	|-UniTask.Awaiter<Color>.GetResult
	|
	|-RVA: 0x1DF1A90 Offset: 0x1DF1B91 VA: 0x1DF1A90
	|-UniTask.Awaiter<double>.GetResult
	|
	|-RVA: 0x1DF1DA0 Offset: 0x1DF1EA1 VA: 0x1DF1DA0
	|-UniTask.Awaiter<int>.GetResult
	|
	|-RVA: 0x1DF20B0 Offset: 0x1DF21B1 VA: 0x1DF20B0
	|-UniTask.Awaiter<long>.GetResult
	|
	|-RVA: 0x1DF23C0 Offset: 0x1DF24C1 VA: 0x1DF23C0
	|-UniTask.Awaiter<object>.GetResult
	|
	|-RVA: 0x1DF2D60 Offset: 0x1DF2E61 VA: 0x1DF2D60
	|-UniTask.Awaiter<Quaternion>.GetResult
	|
	|-RVA: 0x1DF30C0 Offset: 0x1DF31C1 VA: 0x1DF30C0
	|-UniTask.Awaiter<Rect>.GetResult
	|
	|-RVA: 0x1DF33E0 Offset: 0x1DF34E1 VA: 0x1DF33E0
	|-UniTask.Awaiter<float>.GetResult
	|
	|-RVA: 0x1DF36F0 Offset: 0x1DF37F1 VA: 0x1DF36F0
	|-UniTask.Awaiter<UniTask>.GetResult
	|
	|-RVA: 0x1DF3A00 Offset: 0x1DF3B01 VA: 0x1DF3A00
	|-UniTask.Awaiter<Unit>.GetResult
	|
	|-RVA: 0x1DF3D10 Offset: 0x1DF3E11 VA: 0x1DF3D10
	|-UniTask.Awaiter<Vector2>.GetResult
	|
	|-RVA: 0x1DF4060 Offset: 0x1DF4161 VA: 0x1DF4060
	|-UniTask.Awaiter<Vector3>.GetResult
	|
	|-RVA: 0x1DF43C0 Offset: 0x1DF44C1 VA: 0x1DF43C0
	|-UniTask.Awaiter<Vector4>.GetResult
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CF50 Offset: 0x2D051 VA: 0x2CF50
	// RVA: -1 Offset: -1 Slot: 9
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F320 Offset: 0x2F5F421 VA: 0x2F5F320
	|-UniTask.Awaiter<UniTask<object>>.OnCompleted
	|
	|-RVA: 0x2F5F690 Offset: 0x2F5F791 VA: 0x2F5F690
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.OnCompleted
	|
	|-RVA: 0x2F5FA20 Offset: 0x2F5FB21 VA: 0x2F5FA20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.OnCompleted
	|
	|-RVA: 0x2F5FDB0 Offset: 0x2F5FEB1 VA: 0x2F5FDB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.OnCompleted
	|
	|-RVA: 0x2F60180 Offset: 0x2F60281 VA: 0x2F60180
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.OnCompleted
	|
	|-RVA: 0x2F60490 Offset: 0x2F60591 VA: 0x2F60490
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.OnCompleted
	|
	|-RVA: 0x2F607A0 Offset: 0x2F608A1 VA: 0x2F607A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.OnCompleted
	|
	|-RVA: 0x2F60B70 Offset: 0x2F60C71 VA: 0x2F60B70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.OnCompleted
	|
	|-RVA: 0x2F60E80 Offset: 0x2F60F81 VA: 0x2F60E80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.OnCompleted
	|
	|-RVA: 0x2F61210 Offset: 0x2F61311 VA: 0x2F61210
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.OnCompleted
	|
	|-RVA: 0x2F615E0 Offset: 0x2F616E1 VA: 0x2F615E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.OnCompleted
	|
	|-RVA: 0x2F61950 Offset: 0x2F61A51 VA: 0x2F61950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.OnCompleted
	|
	|-RVA: 0x2F61D20 Offset: 0x2F61E21 VA: 0x2F61D20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.OnCompleted
	|
	|-RVA: 0x2F620F0 Offset: 0x2F621F1 VA: 0x2F620F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2F62480 Offset: 0x2F62581 VA: 0x2F62480
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.OnCompleted
	|
	|-RVA: 0x2F62810 Offset: 0x2F62911 VA: 0x2F62810
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.OnCompleted
	|
	|-RVA: 0x2F62B80 Offset: 0x2F62C81 VA: 0x2F62B80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.OnCompleted
	|
	|-RVA: 0x2F62F50 Offset: 0x2F63051 VA: 0x2F62F50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.OnCompleted
	|
	|-RVA: 0x2F63260 Offset: 0x2F63361 VA: 0x2F63260
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.OnCompleted
	|
	|-RVA: 0x2F635F0 Offset: 0x2F636F1 VA: 0x2F635F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.OnCompleted
	|
	|-RVA: 0x2F63980 Offset: 0x2F63A81 VA: 0x2F63980
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.OnCompleted
	|
	|-RVA: 0x2F63D10 Offset: 0x2F63E11 VA: 0x2F63D10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.OnCompleted
	|
	|-RVA: 0x2F640E0 Offset: 0x2F641E1 VA: 0x2F640E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2F644B0 Offset: 0x2F645B1 VA: 0x2F644B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2F64880 Offset: 0x2F64981 VA: 0x2F64880
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2F64C60 Offset: 0x2F64D61 VA: 0x2F64C60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DD4760 Offset: 0x1DD4861 VA: 0x1DD4760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DD4B80 Offset: 0x1DD4C81 VA: 0x1DD4B80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DD4FA0 Offset: 0x1DD50A1 VA: 0x1DD4FA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DD52B0 Offset: 0x1DD53B1 VA: 0x1DD52B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.OnCompleted
	|
	|-RVA: 0x1DD55C0 Offset: 0x1DD56C1 VA: 0x1DD55C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.OnCompleted
	|
	|-RVA: 0x1DD5950 Offset: 0x1DD5A51 VA: 0x1DD5950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.OnCompleted
	|
	|-RVA: 0x1DD5C60 Offset: 0x1DD5D61 VA: 0x1DD5C60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.OnCompleted
	|
	|-RVA: 0x1DD5FF0 Offset: 0x1DD60F1 VA: 0x1DD5FF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.OnCompleted
	|
	|-RVA: 0x1DD6380 Offset: 0x1DD6481 VA: 0x1DD6380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.OnCompleted
	|
	|-RVA: 0x1DD66F0 Offset: 0x1DD67F1 VA: 0x1DD66F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.OnCompleted
	|
	|-RVA: 0x1DD6A80 Offset: 0x1DD6B81 VA: 0x1DD6A80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.OnCompleted
	|
	|-RVA: 0x1DD6E10 Offset: 0x1DD6F11 VA: 0x1DD6E10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DD71A0 Offset: 0x1DD72A1 VA: 0x1DD71A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.OnCompleted
	|
	|-RVA: 0x1DD7530 Offset: 0x1DD7631 VA: 0x1DD7530
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.OnCompleted
	|
	|-RVA: 0x1DD78A0 Offset: 0x1DD79A1 VA: 0x1DD78A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.OnCompleted
	|
	|-RVA: 0x1DD7C30 Offset: 0x1DD7D31 VA: 0x1DD7C30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.OnCompleted
	|
	|-RVA: 0x1DD7F40 Offset: 0x1DD8041 VA: 0x1DD7F40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.OnCompleted
	|
	|-RVA: 0x1DD82B0 Offset: 0x1DD83B1 VA: 0x1DD82B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.OnCompleted
	|
	|-RVA: 0x1DD8640 Offset: 0x1DD8741 VA: 0x1DD8640
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.OnCompleted
	|
	|-RVA: 0x1DD89D0 Offset: 0x1DD8AD1 VA: 0x1DD89D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.OnCompleted
	|
	|-RVA: 0x1DD8D60 Offset: 0x1DD8E61 VA: 0x1DD8D60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DD90F0 Offset: 0x1DD91F1 VA: 0x1DD90F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DD94D0 Offset: 0x1DD95D1 VA: 0x1DD94D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DD98A0 Offset: 0x1DD99A1 VA: 0x1DD98A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DD9CC0 Offset: 0x1DD9DC1 VA: 0x1DD9CC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DDA090 Offset: 0x1DDA191 VA: 0x1DDA090
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DDA4C0 Offset: 0x1DDA5C1 VA: 0x1DDA4C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DDA8A0 Offset: 0x1DDA9A1 VA: 0x1DDA8A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DDAD10 Offset: 0x1DDAE11 VA: 0x1DDAD10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DDB0F0 Offset: 0x1DDB1F1 VA: 0x1DDB0F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DDB4B0 Offset: 0x1DDB5B1 VA: 0x1DDB4B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DDB8D0 Offset: 0x1DDB9D1 VA: 0x1DDB8D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DDBBE0 Offset: 0x1DDBCE1 VA: 0x1DDBBE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.OnCompleted
	|
	|-RVA: 0x1DDBEF0 Offset: 0x1DDBFF1 VA: 0x1DDBEF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.OnCompleted
	|
	|-RVA: 0x1DDC280 Offset: 0x1DDC381 VA: 0x1DDC280
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.OnCompleted
	|
	|-RVA: 0x1DDC590 Offset: 0x1DDC691 VA: 0x1DDC590
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.OnCompleted
	|
	|-RVA: 0x1DDC920 Offset: 0x1DDCA21 VA: 0x1DDC920
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.OnCompleted
	|
	|-RVA: 0x1DDCCB0 Offset: 0x1DDCDB1 VA: 0x1DDCCB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.OnCompleted
	|
	|-RVA: 0x1DDD010 Offset: 0x1DDD111 VA: 0x1DDD010
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.OnCompleted
	|
	|-RVA: 0x1DDD3A0 Offset: 0x1DDD4A1 VA: 0x1DDD3A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.OnCompleted
	|
	|-RVA: 0x1DDD730 Offset: 0x1DDD831 VA: 0x1DDD730
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DDDAC0 Offset: 0x1DDDBC1 VA: 0x1DDDAC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.OnCompleted
	|
	|-RVA: 0x1DDDE50 Offset: 0x1DDDF51 VA: 0x1DDDE50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.OnCompleted
	|
	|-RVA: 0x1DDE1B0 Offset: 0x1DDE2B1 VA: 0x1DDE1B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.OnCompleted
	|
	|-RVA: 0x1DDE540 Offset: 0x1DDE641 VA: 0x1DDE540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.OnCompleted
	|
	|-RVA: 0x1DDE850 Offset: 0x1DDE951 VA: 0x1DDE850
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.OnCompleted
	|
	|-RVA: 0x1DDEBC0 Offset: 0x1DDECC1 VA: 0x1DDEBC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.OnCompleted
	|
	|-RVA: 0x1DDEF30 Offset: 0x1DDF031 VA: 0x1DDEF30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.OnCompleted
	|
	|-RVA: 0x1DDF2C0 Offset: 0x1DDF3C1 VA: 0x1DDF2C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.OnCompleted
	|
	|-RVA: 0x1DDF650 Offset: 0x1DDF751 VA: 0x1DDF650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.OnCompleted
	|
	|-RVA: 0x1DDF9E0 Offset: 0x1DDFAE1 VA: 0x1DDF9E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DDFDB0 Offset: 0x1DDFEB1 VA: 0x1DDFDB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE0140 Offset: 0x1DE0241 VA: 0x1DE0140
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE0520 Offset: 0x1DE0621 VA: 0x1DE0520
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE08F0 Offset: 0x1DE09F1 VA: 0x1DE08F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE0D10 Offset: 0x1DE0E11 VA: 0x1DE0D10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE10E0 Offset: 0x1DE11E1 VA: 0x1DE10E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE1510 Offset: 0x1DE1611 VA: 0x1DE1510
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE18F0 Offset: 0x1DE19F1 VA: 0x1DE18F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE1D70 Offset: 0x1DE1E71 VA: 0x1DE1D70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE2150 Offset: 0x1DE2251 VA: 0x1DE2150
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE24E0 Offset: 0x1DE25E1 VA: 0x1DE24E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DE2870 Offset: 0x1DE2971 VA: 0x1DE2870
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DE2B80 Offset: 0x1DE2C81 VA: 0x1DE2B80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.OnCompleted
	|
	|-RVA: 0x1DE2E90 Offset: 0x1DE2F91 VA: 0x1DE2E90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.OnCompleted
	|
	|-RVA: 0x1DE3220 Offset: 0x1DE3321 VA: 0x1DE3220
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.OnCompleted
	|
	|-RVA: 0x1DE3530 Offset: 0x1DE3631 VA: 0x1DE3530
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.OnCompleted
	|
	|-RVA: 0x1DE38A0 Offset: 0x1DE39A1 VA: 0x1DE38A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.OnCompleted
	|
	|-RVA: 0x1DE3C10 Offset: 0x1DE3D11 VA: 0x1DE3C10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.OnCompleted
	|
	|-RVA: 0x1DE3F70 Offset: 0x1DE4071 VA: 0x1DE3F70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.OnCompleted
	|
	|-RVA: 0x1DE42E0 Offset: 0x1DE43E1 VA: 0x1DE42E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.OnCompleted
	|
	|-RVA: 0x1DE4650 Offset: 0x1DE4751 VA: 0x1DE4650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DE49C0 Offset: 0x1DE4AC1 VA: 0x1DE49C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.OnCompleted
	|
	|-RVA: 0x1DE4D30 Offset: 0x1DE4E31 VA: 0x1DE4D30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.OnCompleted
	|
	|-RVA: 0x1DE5090 Offset: 0x1DE5191 VA: 0x1DE5090
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.OnCompleted
	|
	|-RVA: 0x1DE5400 Offset: 0x1DE5501 VA: 0x1DE5400
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.OnCompleted
	|
	|-RVA: 0x1DE5710 Offset: 0x1DE5811 VA: 0x1DE5710
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.OnCompleted
	|
	|-RVA: 0x1DE5A70 Offset: 0x1DE5B71 VA: 0x1DE5A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.OnCompleted
	|
	|-RVA: 0x1DE5DE0 Offset: 0x1DE5EE1 VA: 0x1DE5DE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.OnCompleted
	|
	|-RVA: 0x1DE6150 Offset: 0x1DE6251 VA: 0x1DE6150
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.OnCompleted
	|
	|-RVA: 0x1DE64C0 Offset: 0x1DE65C1 VA: 0x1DE64C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.OnCompleted
	|
	|-RVA: 0x1DE6830 Offset: 0x1DE6931 VA: 0x1DE6830
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE6C00 Offset: 0x1DE6D01 VA: 0x1DE6C00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE6F90 Offset: 0x1DE7091 VA: 0x1DE6F90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE7370 Offset: 0x1DE7471 VA: 0x1DE7370
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE7700 Offset: 0x1DE7801 VA: 0x1DE7700
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE7B20 Offset: 0x1DE7C21 VA: 0x1DE7B20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE7EF0 Offset: 0x1DE7FF1 VA: 0x1DE7EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE8320 Offset: 0x1DE8421 VA: 0x1DE8320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE86F0 Offset: 0x1DE87F1 VA: 0x1DE86F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE8B60 Offset: 0x1DE8C61 VA: 0x1DE8B60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE8F40 Offset: 0x1DE9041 VA: 0x1DE8F40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE9300 Offset: 0x1DE9401 VA: 0x1DE9300
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE9690 Offset: 0x1DE9791 VA: 0x1DE9690
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE99A0 Offset: 0x1DE9AA1 VA: 0x1DE99A0
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.OnCompleted
	|
	|-RVA: 0x1DE9F00 Offset: 0x1DEA001 VA: 0x1DE9F00
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.OnCompleted
	|
	|-RVA: 0x1DEA290 Offset: 0x1DEA391 VA: 0x1DEA290
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.OnCompleted
	|
	|-RVA: 0x1DEA5A0 Offset: 0x1DEA6A1 VA: 0x1DEA5A0
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.OnCompleted
	|
	|-RVA: 0x1DEA910 Offset: 0x1DEAA11 VA: 0x1DEA910
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.OnCompleted
	|
	|-RVA: 0x1DEAC70 Offset: 0x1DEAD71 VA: 0x1DEAC70
	|-UniTask.Awaiter<ValueTuple<bool, double>>.OnCompleted
	|
	|-RVA: 0x1DEAF80 Offset: 0x1DEB081 VA: 0x1DEAF80
	|-UniTask.Awaiter<ValueTuple<bool, int>>.OnCompleted
	|
	|-RVA: 0x1DEB2E0 Offset: 0x1DEB3E1 VA: 0x1DEB2E0
	|-UniTask.Awaiter<ValueTuple<bool, long>>.OnCompleted
	|
	|-RVA: 0x1DEB640 Offset: 0x1DEB741 VA: 0x1DEB640
	|-UniTask.Awaiter<ValueTuple<bool, object>>.OnCompleted
	|
	|-RVA: 0x1DEBC20 Offset: 0x1DEBD21 VA: 0x1DEBC20
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.OnCompleted
	|
	|-RVA: 0x1DEBF90 Offset: 0x1DEC091 VA: 0x1DEBF90
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.OnCompleted
	|
	|-RVA: 0x1DEC2A0 Offset: 0x1DEC3A1 VA: 0x1DEC2A0
	|-UniTask.Awaiter<ValueTuple<bool, float>>.OnCompleted
	|
	|-RVA: 0x1DEC600 Offset: 0x1DEC701 VA: 0x1DEC600
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.OnCompleted
	|
	|-RVA: 0x1DEC910 Offset: 0x1DECA11 VA: 0x1DEC910
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.OnCompleted
	|
	|-RVA: 0x1DECC70 Offset: 0x1DECD71 VA: 0x1DECC70
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.OnCompleted
	|
	|-RVA: 0x1DECFD0 Offset: 0x1DED0D1 VA: 0x1DECFD0
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.OnCompleted
	|
	|-RVA: 0x1DED340 Offset: 0x1DED441 VA: 0x1DED340
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.OnCompleted
	|
	|-RVA: 0x1DED6A0 Offset: 0x1DED7A1 VA: 0x1DED6A0
	|-UniTask.Awaiter<ValueTuple<int, object>>.OnCompleted
	|
	|-RVA: 0x1DEDA00 Offset: 0x1DEDB01 VA: 0x1DEDA00
	|-UniTask.Awaiter<ValueTuple<object, object>>.OnCompleted
	|
	|-RVA: 0x1DEDD90 Offset: 0x1DEDE91 VA: 0x1DEDD90
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DEE100 Offset: 0x1DEE201 VA: 0x1DEE100
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.OnCompleted
	|
	|-RVA: 0x1DEE4D0 Offset: 0x1DEE5D1 VA: 0x1DEE4D0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DEE860 Offset: 0x1DEE961 VA: 0x1DEE860
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x1DEEC40 Offset: 0x1DEED41 VA: 0x1DEEC40
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DEEFD0 Offset: 0x1DEF0D1 VA: 0x1DEEFD0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x1DEF3F0 Offset: 0x1DEF4F1 VA: 0x1DEF3F0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DEF7C0 Offset: 0x1DEF8C1 VA: 0x1DEF7C0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x1DEFBF0 Offset: 0x1DEFCF1 VA: 0x1DEFBF0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DEFFC0 Offset: 0x1DF00C1 VA: 0x1DEFFC0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x1DF0440 Offset: 0x1DF0541 VA: 0x1DF0440
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DF07D0 Offset: 0x1DF08D1 VA: 0x1DF07D0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DF0AE0 Offset: 0x1DF0BE1 VA: 0x1DF0AE0
	|-UniTask.Awaiter<AsyncUnit>.OnCompleted
	|
	|-RVA: 0x1DF0DF0 Offset: 0x1DF0EF1 VA: 0x1DF0DF0
	|-UniTask.Awaiter<bool>.OnCompleted
	|
	|-RVA: 0x1DF1160 Offset: 0x1DF1261 VA: 0x1DF1160
	|-UniTask.Awaiter<Bounds>.OnCompleted
	|
	|-RVA: 0x1DF1470 Offset: 0x1DF1571 VA: 0x1DF1470
	|-UniTask.Awaiter<byte>.OnCompleted
	|
	|-RVA: 0x1DF17D0 Offset: 0x1DF18D1 VA: 0x1DF17D0
	|-UniTask.Awaiter<Color>.OnCompleted
	|
	|-RVA: 0x1DF1AE0 Offset: 0x1DF1BE1 VA: 0x1DF1AE0
	|-UniTask.Awaiter<double>.OnCompleted
	|
	|-RVA: 0x1DF1DF0 Offset: 0x1DF1EF1 VA: 0x1DF1DF0
	|-UniTask.Awaiter<int>.OnCompleted
	|
	|-RVA: 0x1DF2100 Offset: 0x1DF2201 VA: 0x1DF2100
	|-UniTask.Awaiter<long>.OnCompleted
	|
	|-RVA: 0x1DF2410 Offset: 0x1DF2511 VA: 0x1DF2410
	|-UniTask.Awaiter<object>.OnCompleted
	|
	|-RVA: 0x1DF2DC0 Offset: 0x1DF2EC1 VA: 0x1DF2DC0
	|-UniTask.Awaiter<Quaternion>.OnCompleted
	|
	|-RVA: 0x1DF3120 Offset: 0x1DF3221 VA: 0x1DF3120
	|-UniTask.Awaiter<Rect>.OnCompleted
	|
	|-RVA: 0x1DF3430 Offset: 0x1DF3531 VA: 0x1DF3430
	|-UniTask.Awaiter<float>.OnCompleted
	|
	|-RVA: 0x1DF3740 Offset: 0x1DF3841 VA: 0x1DF3740
	|-UniTask.Awaiter<UniTask>.OnCompleted
	|
	|-RVA: 0x1DF3A50 Offset: 0x1DF3B51 VA: 0x1DF3A50
	|-UniTask.Awaiter<Unit>.OnCompleted
	|
	|-RVA: 0x1DF3D60 Offset: 0x1DF3E61 VA: 0x1DF3D60
	|-UniTask.Awaiter<Vector2>.OnCompleted
	|
	|-RVA: 0x1DF40C0 Offset: 0x1DF41C1 VA: 0x1DF40C0
	|-UniTask.Awaiter<Vector3>.OnCompleted
	|
	|-RVA: 0x1DF4420 Offset: 0x1DF4521 VA: 0x1DF4420
	|-UniTask.Awaiter<Vector4>.OnCompleted
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CF60 Offset: 0x2D061 VA: 0x2CF60
	// RVA: -1 Offset: -1 Slot: 8
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F3F0 Offset: 0x2F5F4F1 VA: 0x2F5F3F0
	|-UniTask.Awaiter<UniTask<object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F5F760 Offset: 0x2F5F861 VA: 0x2F5F760
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F5FAF0 Offset: 0x2F5FBF1 VA: 0x2F5FAF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F5FE80 Offset: 0x2F5FF81 VA: 0x2F5FE80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F60250 Offset: 0x2F60351 VA: 0x2F60250
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F60560 Offset: 0x2F60661 VA: 0x2F60560
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F60870 Offset: 0x2F60971 VA: 0x2F60870
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F60C40 Offset: 0x2F60D41 VA: 0x2F60C40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F60F50 Offset: 0x2F61051 VA: 0x2F60F50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F612E0 Offset: 0x2F613E1 VA: 0x2F612E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F616B0 Offset: 0x2F617B1 VA: 0x2F616B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F61A20 Offset: 0x2F61B21 VA: 0x2F61A20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F61DF0 Offset: 0x2F61EF1 VA: 0x2F61DF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F621C0 Offset: 0x2F622C1 VA: 0x2F621C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F62550 Offset: 0x2F62651 VA: 0x2F62550
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F628E0 Offset: 0x2F629E1 VA: 0x2F628E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F62C50 Offset: 0x2F62D51 VA: 0x2F62C50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F63020 Offset: 0x2F63121 VA: 0x2F63020
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F63330 Offset: 0x2F63431 VA: 0x2F63330
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F636C0 Offset: 0x2F637C1 VA: 0x2F636C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F63A50 Offset: 0x2F63B51 VA: 0x2F63A50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F63DE0 Offset: 0x2F63EE1 VA: 0x2F63DE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F641B0 Offset: 0x2F642B1 VA: 0x2F641B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F64580 Offset: 0x2F64681 VA: 0x2F64580
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F64950 Offset: 0x2F64A51 VA: 0x2F64950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F64D30 Offset: 0x2F64E31 VA: 0x2F64D30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD4830 Offset: 0x1DD4931 VA: 0x1DD4830
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD4C50 Offset: 0x1DD4D51 VA: 0x1DD4C50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD5070 Offset: 0x1DD5171 VA: 0x1DD5070
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD5380 Offset: 0x1DD5481 VA: 0x1DD5380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD5690 Offset: 0x1DD5791 VA: 0x1DD5690
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD5A20 Offset: 0x1DD5B21 VA: 0x1DD5A20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD5D30 Offset: 0x1DD5E31 VA: 0x1DD5D30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD60C0 Offset: 0x1DD61C1 VA: 0x1DD60C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD6450 Offset: 0x1DD6551 VA: 0x1DD6450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD67C0 Offset: 0x1DD68C1 VA: 0x1DD67C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD6B50 Offset: 0x1DD6C51 VA: 0x1DD6B50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD6EE0 Offset: 0x1DD6FE1 VA: 0x1DD6EE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD7270 Offset: 0x1DD7371 VA: 0x1DD7270
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD7600 Offset: 0x1DD7701 VA: 0x1DD7600
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD7970 Offset: 0x1DD7A71 VA: 0x1DD7970
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD7D00 Offset: 0x1DD7E01 VA: 0x1DD7D00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD8010 Offset: 0x1DD8111 VA: 0x1DD8010
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD8380 Offset: 0x1DD8481 VA: 0x1DD8380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD8710 Offset: 0x1DD8811 VA: 0x1DD8710
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD8AA0 Offset: 0x1DD8BA1 VA: 0x1DD8AA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD8E30 Offset: 0x1DD8F31 VA: 0x1DD8E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD91C0 Offset: 0x1DD92C1 VA: 0x1DD91C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD95A0 Offset: 0x1DD96A1 VA: 0x1DD95A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD9970 Offset: 0x1DD9A71 VA: 0x1DD9970
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD9D90 Offset: 0x1DD9E91 VA: 0x1DD9D90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDA160 Offset: 0x1DDA261 VA: 0x1DDA160
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDA590 Offset: 0x1DDA691 VA: 0x1DDA590
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDA970 Offset: 0x1DDAA71 VA: 0x1DDA970
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDADE0 Offset: 0x1DDAEE1 VA: 0x1DDADE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDB1C0 Offset: 0x1DDB2C1 VA: 0x1DDB1C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDB580 Offset: 0x1DDB681 VA: 0x1DDB580
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDB9A0 Offset: 0x1DDBAA1 VA: 0x1DDB9A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDBCB0 Offset: 0x1DDBDB1 VA: 0x1DDBCB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDBFC0 Offset: 0x1DDC0C1 VA: 0x1DDBFC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDC350 Offset: 0x1DDC451 VA: 0x1DDC350
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDC660 Offset: 0x1DDC761 VA: 0x1DDC660
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDC9F0 Offset: 0x1DDCAF1 VA: 0x1DDC9F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDCD80 Offset: 0x1DDCE81 VA: 0x1DDCD80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDD0E0 Offset: 0x1DDD1E1 VA: 0x1DDD0E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDD470 Offset: 0x1DDD571 VA: 0x1DDD470
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDD800 Offset: 0x1DDD901 VA: 0x1DDD800
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDDB90 Offset: 0x1DDDC91 VA: 0x1DDDB90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDDF20 Offset: 0x1DDE021 VA: 0x1DDDF20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDE280 Offset: 0x1DDE381 VA: 0x1DDE280
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDE610 Offset: 0x1DDE711 VA: 0x1DDE610
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDE920 Offset: 0x1DDEA21 VA: 0x1DDE920
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDEC90 Offset: 0x1DDED91 VA: 0x1DDEC90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDF000 Offset: 0x1DDF101 VA: 0x1DDF000
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDF390 Offset: 0x1DDF491 VA: 0x1DDF390
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDF720 Offset: 0x1DDF821 VA: 0x1DDF720
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDFAB0 Offset: 0x1DDFBB1 VA: 0x1DDFAB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDFE80 Offset: 0x1DDFF81 VA: 0x1DDFE80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE0210 Offset: 0x1DE0311 VA: 0x1DE0210
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE05F0 Offset: 0x1DE06F1 VA: 0x1DE05F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE09C0 Offset: 0x1DE0AC1 VA: 0x1DE09C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE0DE0 Offset: 0x1DE0EE1 VA: 0x1DE0DE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE11B0 Offset: 0x1DE12B1 VA: 0x1DE11B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE15E0 Offset: 0x1DE16E1 VA: 0x1DE15E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE19C0 Offset: 0x1DE1AC1 VA: 0x1DE19C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE1E40 Offset: 0x1DE1F41 VA: 0x1DE1E40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE2220 Offset: 0x1DE2321 VA: 0x1DE2220
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE25B0 Offset: 0x1DE26B1 VA: 0x1DE25B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE2940 Offset: 0x1DE2A41 VA: 0x1DE2940
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE2C50 Offset: 0x1DE2D51 VA: 0x1DE2C50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE2F60 Offset: 0x1DE3061 VA: 0x1DE2F60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE32F0 Offset: 0x1DE33F1 VA: 0x1DE32F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE3600 Offset: 0x1DE3701 VA: 0x1DE3600
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE3970 Offset: 0x1DE3A71 VA: 0x1DE3970
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE3CE0 Offset: 0x1DE3DE1 VA: 0x1DE3CE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE4040 Offset: 0x1DE4141 VA: 0x1DE4040
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE43B0 Offset: 0x1DE44B1 VA: 0x1DE43B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE4720 Offset: 0x1DE4821 VA: 0x1DE4720
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE4A90 Offset: 0x1DE4B91 VA: 0x1DE4A90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE4E00 Offset: 0x1DE4F01 VA: 0x1DE4E00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE5160 Offset: 0x1DE5261 VA: 0x1DE5160
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE54D0 Offset: 0x1DE55D1 VA: 0x1DE54D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE57E0 Offset: 0x1DE58E1 VA: 0x1DE57E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE5B40 Offset: 0x1DE5C41 VA: 0x1DE5B40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE5EB0 Offset: 0x1DE5FB1 VA: 0x1DE5EB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE6220 Offset: 0x1DE6321 VA: 0x1DE6220
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE6590 Offset: 0x1DE6691 VA: 0x1DE6590
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE6900 Offset: 0x1DE6A01 VA: 0x1DE6900
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE6CD0 Offset: 0x1DE6DD1 VA: 0x1DE6CD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE7060 Offset: 0x1DE7161 VA: 0x1DE7060
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE7440 Offset: 0x1DE7541 VA: 0x1DE7440
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE77D0 Offset: 0x1DE78D1 VA: 0x1DE77D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE7BF0 Offset: 0x1DE7CF1 VA: 0x1DE7BF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE7FC0 Offset: 0x1DE80C1 VA: 0x1DE7FC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE83F0 Offset: 0x1DE84F1 VA: 0x1DE83F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE87C0 Offset: 0x1DE88C1 VA: 0x1DE87C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE8C30 Offset: 0x1DE8D31 VA: 0x1DE8C30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE9010 Offset: 0x1DE9111 VA: 0x1DE9010
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE93D0 Offset: 0x1DE94D1 VA: 0x1DE93D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE9760 Offset: 0x1DE9861 VA: 0x1DE9760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE9A70 Offset: 0x1DE9B71 VA: 0x1DE9A70
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE9FD0 Offset: 0x1DEA0D1 VA: 0x1DE9FD0
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEA360 Offset: 0x1DEA461 VA: 0x1DEA360
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEA670 Offset: 0x1DEA771 VA: 0x1DEA670
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEA9E0 Offset: 0x1DEAAE1 VA: 0x1DEA9E0
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEAD40 Offset: 0x1DEAE41 VA: 0x1DEAD40
	|-UniTask.Awaiter<ValueTuple<bool, double>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEB050 Offset: 0x1DEB151 VA: 0x1DEB050
	|-UniTask.Awaiter<ValueTuple<bool, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEB3B0 Offset: 0x1DEB4B1 VA: 0x1DEB3B0
	|-UniTask.Awaiter<ValueTuple<bool, long>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEB710 Offset: 0x1DEB811 VA: 0x1DEB710
	|-UniTask.Awaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEBCF0 Offset: 0x1DEBDF1 VA: 0x1DEBCF0
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEC060 Offset: 0x1DEC161 VA: 0x1DEC060
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEC370 Offset: 0x1DEC471 VA: 0x1DEC370
	|-UniTask.Awaiter<ValueTuple<bool, float>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEC6D0 Offset: 0x1DEC7D1 VA: 0x1DEC6D0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEC9E0 Offset: 0x1DECAE1 VA: 0x1DEC9E0
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DECD40 Offset: 0x1DECE41 VA: 0x1DECD40
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DED0A0 Offset: 0x1DED1A1 VA: 0x1DED0A0
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DED410 Offset: 0x1DED511 VA: 0x1DED410
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DED770 Offset: 0x1DED871 VA: 0x1DED770
	|-UniTask.Awaiter<ValueTuple<int, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEDAD0 Offset: 0x1DEDBD1 VA: 0x1DEDAD0
	|-UniTask.Awaiter<ValueTuple<object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEDE60 Offset: 0x1DEDF61 VA: 0x1DEDE60
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEE1D0 Offset: 0x1DEE2D1 VA: 0x1DEE1D0
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEE5A0 Offset: 0x1DEE6A1 VA: 0x1DEE5A0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEE930 Offset: 0x1DEEA31 VA: 0x1DEE930
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEED10 Offset: 0x1DEEE11 VA: 0x1DEED10
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEF0A0 Offset: 0x1DEF1A1 VA: 0x1DEF0A0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEF4C0 Offset: 0x1DEF5C1 VA: 0x1DEF4C0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEF890 Offset: 0x1DEF991 VA: 0x1DEF890
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEFCC0 Offset: 0x1DEFDC1 VA: 0x1DEFCC0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF0090 Offset: 0x1DF0191 VA: 0x1DF0090
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF0510 Offset: 0x1DF0611 VA: 0x1DF0510
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF08A0 Offset: 0x1DF09A1 VA: 0x1DF08A0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF0BB0 Offset: 0x1DF0CB1 VA: 0x1DF0BB0
	|-UniTask.Awaiter<AsyncUnit>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF0EC0 Offset: 0x1DF0FC1 VA: 0x1DF0EC0
	|-UniTask.Awaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF1230 Offset: 0x1DF1331 VA: 0x1DF1230
	|-UniTask.Awaiter<Bounds>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF1540 Offset: 0x1DF1641 VA: 0x1DF1540
	|-UniTask.Awaiter<byte>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF18A0 Offset: 0x1DF19A1 VA: 0x1DF18A0
	|-UniTask.Awaiter<Color>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF1BB0 Offset: 0x1DF1CB1 VA: 0x1DF1BB0
	|-UniTask.Awaiter<double>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF1EC0 Offset: 0x1DF1FC1 VA: 0x1DF1EC0
	|-UniTask.Awaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF21D0 Offset: 0x1DF22D1 VA: 0x1DF21D0
	|-UniTask.Awaiter<long>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF24E0 Offset: 0x1DF25E1 VA: 0x1DF24E0
	|-UniTask.Awaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF2E90 Offset: 0x1DF2F91 VA: 0x1DF2E90
	|-UniTask.Awaiter<Quaternion>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF31F0 Offset: 0x1DF32F1 VA: 0x1DF31F0
	|-UniTask.Awaiter<Rect>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF3500 Offset: 0x1DF3601 VA: 0x1DF3500
	|-UniTask.Awaiter<float>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF3810 Offset: 0x1DF3911 VA: 0x1DF3810
	|-UniTask.Awaiter<UniTask>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF3B20 Offset: 0x1DF3C21 VA: 0x1DF3B20
	|-UniTask.Awaiter<Unit>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF3E30 Offset: 0x1DF3F31 VA: 0x1DF3E30
	|-UniTask.Awaiter<Vector2>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF4190 Offset: 0x1DF4291 VA: 0x1DF4190
	|-UniTask.Awaiter<Vector3>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF44F0 Offset: 0x1DF45F1 VA: 0x1DF44F0
	|-UniTask.Awaiter<Vector4>.UnsafeOnCompleted
	*/
}

