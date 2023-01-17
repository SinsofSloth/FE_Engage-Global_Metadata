// Namespace: System.Collections.Generic
[Serializable]
internal class GenericEqualityComparer<T> : EqualityComparer<T> // TypeDefIndex: 1420
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public override bool Equals(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EA2490 Offset: 0x1EA2591 VA: 0x1EA2490
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.Equals
	|
	|-RVA: 0x1EA2A10 Offset: 0x1EA2B11 VA: 0x1EA2A10
	|-GenericEqualityComparer<TimeInterval<object>>.Equals
	|
	|-RVA: 0x1EA2F00 Offset: 0x1EA3001 VA: 0x1EA2F00
	|-GenericEqualityComparer<Timestamped<object>>.Equals
	|
	|-RVA: 0x1EA3480 Offset: 0x1EA3581 VA: 0x1EA3480
	|-GenericEqualityComparer<UniTask<object>>.Equals
	|
	|-RVA: 0x1EA3960 Offset: 0x1EA3A61 VA: 0x1EA3960
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1EA3E50 Offset: 0x1EA3F51 VA: 0x1EA3E50
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1EA43E0 Offset: 0x1EA44E1 VA: 0x1EA43E0
	|-GenericEqualityComparer<ValueTuple<bool, UniTask<object>>>.Equals
	|
	|-RVA: 0x1EA4970 Offset: 0x1EA4A71 VA: 0x1EA4970
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Equals
	|
	|-RVA: 0x1EA4F00 Offset: 0x1EA5001 VA: 0x1EA4F00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Equals
	|
	|-RVA: 0x1EA5500 Offset: 0x1EA5601 VA: 0x1EA5500
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Equals
	|
	|-RVA: 0x1EA5B00 Offset: 0x1EA5C01 VA: 0x1EA5B00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Equals
	|
	|-RVA: 0x1EA5FF0 Offset: 0x1EA60F1 VA: 0x1EA5FF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Equals
	|
	|-RVA: 0x1EA64E0 Offset: 0x1EA65E1 VA: 0x1EA64E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Equals
	|
	|-RVA: 0x1EA6B50 Offset: 0x1EA6C51 VA: 0x1EA6B50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Equals
	|
	|-RVA: 0x1EA7040 Offset: 0x1EA7141 VA: 0x1EA7040
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Equals
	|
	|-RVA: 0x1EA7680 Offset: 0x1EA7781 VA: 0x1EA7680
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Equals
	|
	|-RVA: 0x1EA7C80 Offset: 0x1EA7D81 VA: 0x1EA7C80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Equals
	|
	|-RVA: 0x1EA8210 Offset: 0x1EA8311 VA: 0x1EA8210
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Equals
	|
	|-RVA: 0x1EA8810 Offset: 0x1EA8911 VA: 0x1EA8810
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x1EA8E10 Offset: 0x1EA8F11 VA: 0x1EA8E10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Equals
	|
	|-RVA: 0x1EA9450 Offset: 0x1EA9551 VA: 0x1EA9450
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Equals
	|
	|-RVA: 0x1EA9A90 Offset: 0x1EA9B91 VA: 0x1EA9A90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Equals
	|
	|-RVA: 0x1EAA020 Offset: 0x1EAA121 VA: 0x1EAA020
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Equals
	|
	|-RVA: 0x1EAA620 Offset: 0x1EAA721 VA: 0x1EAA620
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Equals
	|
	|-RVA: 0x1EAAB10 Offset: 0x1EAAC11 VA: 0x1EAAB10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Equals
	|
	|-RVA: 0x1EAB110 Offset: 0x1EAB211 VA: 0x1EAB110
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Equals
	|
	|-RVA: 0x1EAB6A0 Offset: 0x1EAB7A1 VA: 0x1EAB6A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Equals
	|
	|-RVA: 0x1EABCE0 Offset: 0x1EABDE1 VA: 0x1EABCE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Equals
	|
	|-RVA: 0x1EAC2E0 Offset: 0x1EAC3E1 VA: 0x1EAC2E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Equals
	|
	|-RVA: 0x1EAC8E0 Offset: 0x1EAC9E1 VA: 0x1EAC8E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1EACF50 Offset: 0x1EAD051 VA: 0x1EACF50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1EAD5C0 Offset: 0x1EAD6C1 VA: 0x1EAD5C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1EADCA0 Offset: 0x1EADDA1 VA: 0x1EADCA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1EAE380 Offset: 0x1EAE481 VA: 0x1EAE380
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A13A50 Offset: 0x3A13B51 VA: 0x3A13A50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Equals
	|
	|-RVA: 0x3A13F40 Offset: 0x3A14041 VA: 0x3A13F40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Equals
	|
	|-RVA: 0x3A14430 Offset: 0x3A14531 VA: 0x3A14430
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Equals
	|
	|-RVA: 0x3A14A30 Offset: 0x3A14B31 VA: 0x3A14A30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Equals
	|
	|-RVA: 0x3A14F20 Offset: 0x3A15021 VA: 0x3A14F20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Equals
	|
	|-RVA: 0x3A154B0 Offset: 0x3A155B1 VA: 0x3A154B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Equals
	|
	|-RVA: 0x3A15AB0 Offset: 0x3A15BB1 VA: 0x3A15AB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Equals
	|
	|-RVA: 0x3A16040 Offset: 0x3A16141 VA: 0x3A16040
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Equals
	|
	|-RVA: 0x3A16640 Offset: 0x3A16741 VA: 0x3A16640
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A16C40 Offset: 0x3A16D41 VA: 0x3A16C40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Equals
	|
	|-RVA: 0x3A171D0 Offset: 0x3A172D1 VA: 0x3A171D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Equals
	|
	|-RVA: 0x3A17760 Offset: 0x3A17861 VA: 0x3A17760
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Equals
	|
	|-RVA: 0x3A17CF0 Offset: 0x3A17DF1 VA: 0x3A17CF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Equals
	|
	|-RVA: 0x3A182F0 Offset: 0x3A183F1 VA: 0x3A182F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Equals
	|
	|-RVA: 0x3A187E0 Offset: 0x3A188E1 VA: 0x3A187E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Equals
	|
	|-RVA: 0x3A18D70 Offset: 0x3A18E71 VA: 0x3A18D70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Equals
	|
	|-RVA: 0x3A19370 Offset: 0x3A19471 VA: 0x3A19370
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Equals
	|
	|-RVA: 0x3A19900 Offset: 0x3A19A01 VA: 0x3A19900
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Equals
	|
	|-RVA: 0x3A19F00 Offset: 0x3A1A001 VA: 0x3A19F00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Equals
	|
	|-RVA: 0x3A1A500 Offset: 0x3A1A601 VA: 0x3A1A500
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A1AB70 Offset: 0x3A1AC71 VA: 0x3A1AB70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A1B170 Offset: 0x3A1B271 VA: 0x3A1B170
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A1B850 Offset: 0x3A1B951 VA: 0x3A1B850
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A1BEC0 Offset: 0x3A1BFC1 VA: 0x3A1BEC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A1C610 Offset: 0x3A1C711 VA: 0x3A1C610
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A1CC80 Offset: 0x3A1CD81 VA: 0x3A1CC80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A1D440 Offset: 0x3A1D541 VA: 0x3A1D440
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A1DB20 Offset: 0x3A1DC21 VA: 0x3A1DB20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A1E350 Offset: 0x3A1E451 VA: 0x3A1E350
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A1EA30 Offset: 0x3A1EB31 VA: 0x3A1EA30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Equals
	|
	|-RVA: 0x3A1EEF0 Offset: 0x3A1EFF1 VA: 0x3A1EEF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Equals
	|
	|-RVA: 0x3A1F3B0 Offset: 0x3A1F4B1 VA: 0x3A1F3B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Equals
	|
	|-RVA: 0x3A1F9F0 Offset: 0x3A1FAF1 VA: 0x3A1F9F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Equals
	|
	|-RVA: 0x3A1FEB0 Offset: 0x3A1FFB1 VA: 0x3A1FEB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Equals
	|
	|-RVA: 0x3A204B0 Offset: 0x3A205B1 VA: 0x3A204B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Equals
	|
	|-RVA: 0x3A20A40 Offset: 0x3A20B41 VA: 0x3A20A40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Equals
	|
	|-RVA: 0x3A20F30 Offset: 0x3A21031 VA: 0x3A20F30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Equals
	|
	|-RVA: 0x3A214C0 Offset: 0x3A215C1 VA: 0x3A214C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A21A50 Offset: 0x3A21B51 VA: 0x3A21A50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Equals
	|
	|-RVA: 0x3A22050 Offset: 0x3A22151 VA: 0x3A22050
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Equals
	|
	|-RVA: 0x3A22650 Offset: 0x3A22751 VA: 0x3A22650
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Equals
	|
	|-RVA: 0x3A22B40 Offset: 0x3A22C41 VA: 0x3A22B40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Equals
	|
	|-RVA: 0x3A230D0 Offset: 0x3A231D1 VA: 0x3A230D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Equals
	|
	|-RVA: 0x3A23590 Offset: 0x3A23691 VA: 0x3A23590
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Equals
	|
	|-RVA: 0x3A23B20 Offset: 0x3A23C21 VA: 0x3A23B20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Equals
	|
	|-RVA: 0x3A240B0 Offset: 0x3A241B1 VA: 0x3A240B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Equals
	|
	|-RVA: 0x3A246B0 Offset: 0x3A247B1 VA: 0x3A246B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Equals
	|
	|-RVA: 0x3A24C40 Offset: 0x3A24D41 VA: 0x3A24C40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Equals
	|
	|-RVA: 0x3A251D0 Offset: 0x3A252D1 VA: 0x3A251D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A25840 Offset: 0x3A25941 VA: 0x3A25840
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Equals
	|
	|-RVA: 0x3A25E40 Offset: 0x3A25F41 VA: 0x3A25E40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A26520 Offset: 0x3A26621 VA: 0x3A26520
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A26B20 Offset: 0x3A26C21 VA: 0x3A26B20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A27270 Offset: 0x3A27371 VA: 0x3A27270
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A278E0 Offset: 0x3A279E1 VA: 0x3A278E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A280A0 Offset: 0x3A281A1 VA: 0x3A280A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A28710 Offset: 0x3A28811 VA: 0x3A28710
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A28F40 Offset: 0x3A29041 VA: 0x3A28F40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A29620 Offset: 0x3A29721 VA: 0x3A29620
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A29BF0 Offset: 0x3A29CF1 VA: 0x3A29BF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A2A1C0 Offset: 0x3A2A2C1 VA: 0x3A2A1C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Equals
	|
	|-RVA: 0x3A2A6B0 Offset: 0x3A2A7B1 VA: 0x3A2A6B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.Equals
	|
	|-RVA: 0x3A2ABA0 Offset: 0x3A2ACA1 VA: 0x3A2ABA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.Equals
	|
	|-RVA: 0x3A2B130 Offset: 0x3A2B231 VA: 0x3A2B130
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.Equals
	|
	|-RVA: 0x3A2B620 Offset: 0x3A2B721 VA: 0x3A2B620
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.Equals
	|
	|-RVA: 0x3A2BBB0 Offset: 0x3A2BCB1 VA: 0x3A2BBB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.Equals
	|
	|-RVA: 0x3A2C140 Offset: 0x3A2C241 VA: 0x3A2C140
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.Equals
	|
	|-RVA: 0x3A2C670 Offset: 0x3A2C771 VA: 0x3A2C670
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.Equals
	|
	|-RVA: 0x3A2CC00 Offset: 0x3A2CD01 VA: 0x3A2CC00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A2D190 Offset: 0x3A2D291 VA: 0x3A2D190
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Equals
	|
	|-RVA: 0x3A2D720 Offset: 0x3A2D821 VA: 0x3A2D720
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.Equals
	|
	|-RVA: 0x3A2DCB0 Offset: 0x3A2DDB1 VA: 0x3A2DCB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.Equals
	|
	|-RVA: 0x3A2E1E0 Offset: 0x3A2E2E1 VA: 0x3A2E1E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.Equals
	|
	|-RVA: 0x3A2E770 Offset: 0x3A2E871 VA: 0x3A2E770
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.Equals
	|
	|-RVA: 0x3A2EC60 Offset: 0x3A2ED61 VA: 0x3A2EC60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.Equals
	|
	|-RVA: 0x3A2F150 Offset: 0x3A2F251 VA: 0x3A2F150
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.Equals
	|
	|-RVA: 0x3A2F6E0 Offset: 0x3A2F7E1 VA: 0x3A2F6E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.Equals
	|
	|-RVA: 0x3A2FC70 Offset: 0x3A2FD71 VA: 0x3A2FC70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.Equals
	|
	|-RVA: 0x3A30200 Offset: 0x3A30301 VA: 0x3A30200
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.Equals
	|
	|-RVA: 0x3A30790 Offset: 0x3A30891 VA: 0x3A30790
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A30D90 Offset: 0x3A30E91 VA: 0x3A30D90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.Equals
	|
	|-RVA: 0x3A31320 Offset: 0x3A31421 VA: 0x3A31320
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A31990 Offset: 0x3A31A91 VA: 0x3A31990
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.Equals
	|
	|-RVA: 0x3A31F90 Offset: 0x3A32091 VA: 0x3A31F90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A32670 Offset: 0x3A32771 VA: 0x3A32670
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3A32C70 Offset: 0x3A32D71 VA: 0x3A32C70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A333C0 Offset: 0x3A334C1 VA: 0x3A333C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3A33A30 Offset: 0x3A33B31 VA: 0x3A33A30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x39FB2B0 Offset: 0x39FB3B1 VA: 0x39FB2B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x39FB920 Offset: 0x39FBA21 VA: 0x39FB920
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x39FC150 Offset: 0x39FC251 VA: 0x39FC150
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x39FC720 Offset: 0x39FC821 VA: 0x39FC720
	|-GenericEqualityComparer<ValueTuple<bool, AsyncUnit>>.Equals
	|
	|-RVA: 0x39FCBE0 Offset: 0x39FCCE1 VA: 0x39FCBE0
	|-GenericEqualityComparer<ValueTuple<bool, bool>>.Equals
	|
	|-RVA: 0x39FD0A0 Offset: 0x39FD1A1 VA: 0x39FD0A0
	|-GenericEqualityComparer<ValueTuple<bool, Bounds>>.Equals
	|
	|-RVA: 0x39FD6A0 Offset: 0x39FD7A1 VA: 0x39FD6A0
	|-GenericEqualityComparer<ValueTuple<bool, byte>>.Equals
	|
	|-RVA: 0x39FDB60 Offset: 0x39FDC61 VA: 0x39FDB60
	|-GenericEqualityComparer<ValueTuple<bool, Color>>.Equals
	|
	|-RVA: 0x39FE0F0 Offset: 0x39FE1F1 VA: 0x39FE0F0
	|-GenericEqualityComparer<ValueTuple<bool, double>>.Equals
	|
	|-RVA: 0x39FE5E0 Offset: 0x39FE6E1 VA: 0x39FE5E0
	|-GenericEqualityComparer<ValueTuple<bool, int>>.Equals
	|
	|-RVA: 0x39FEAA0 Offset: 0x39FEBA1 VA: 0x39FEAA0
	|-GenericEqualityComparer<ValueTuple<bool, long>>.Equals
	|
	|-RVA: 0x39FEF90 Offset: 0x39FF091 VA: 0x39FEF90
	|-GenericEqualityComparer<ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x39FF480 Offset: 0x39FF581 VA: 0x39FF480
	|-GenericEqualityComparer<ValueTuple<bool, Quaternion>>.Equals
	|
	|-RVA: 0x39FFA10 Offset: 0x39FFB11 VA: 0x39FFA10
	|-GenericEqualityComparer<ValueTuple<bool, Rect>>.Equals
	|
	|-RVA: 0x39FFFA0 Offset: 0x3A000A1 VA: 0x39FFFA0
	|-GenericEqualityComparer<ValueTuple<bool, float>>.Equals
	|
	|-RVA: 0x3A00460 Offset: 0x3A00561 VA: 0x3A00460
	|-GenericEqualityComparer<ValueTuple<bool, UniTask>>.Equals
	|
	|-RVA: 0x3A00950 Offset: 0x3A00A51 VA: 0x3A00950
	|-GenericEqualityComparer<ValueTuple<bool, Unit>>.Equals
	|
	|-RVA: 0x3A00E10 Offset: 0x3A00F11 VA: 0x3A00E10
	|-GenericEqualityComparer<ValueTuple<bool, Vector2>>.Equals
	|
	|-RVA: 0x3A01340 Offset: 0x3A01441 VA: 0x3A01340
	|-GenericEqualityComparer<ValueTuple<bool, Vector3>>.Equals
	|
	|-RVA: 0x3A01830 Offset: 0x3A01931 VA: 0x3A01830
	|-GenericEqualityComparer<ValueTuple<bool, Vector4>>.Equals
	|
	|-RVA: 0x3A01DC0 Offset: 0x3A01EC1 VA: 0x3A01DC0
	|-GenericEqualityComparer<ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x3A022A0 Offset: 0x3A023A1 VA: 0x3A022A0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.Equals
	|
	|-RVA: 0x3A02760 Offset: 0x3A02861 VA: 0x3A02760
	|-GenericEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.Equals
	|
	|-RVA: 0x3A02CE0 Offset: 0x3A02DE1 VA: 0x3A02CE0
	|-GenericEqualityComparer<ValueTuple<object, int>>.Equals
	|
	|-RVA: 0x3A031C0 Offset: 0x3A032C1 VA: 0x3A031C0
	|-GenericEqualityComparer<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x3A036A0 Offset: 0x3A037A1 VA: 0x3A036A0
	|-GenericEqualityComparer<ValueTuple<object, float>>.Equals
	|
	|-RVA: 0x3A03B80 Offset: 0x3A03C81 VA: 0x3A03B80
	|-GenericEqualityComparer<ValueTuple<Vector3, float>>.Equals
	|
	|-RVA: 0x3A04100 Offset: 0x3A04201 VA: 0x3A04100
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A046F0 Offset: 0x3A047F1 VA: 0x3A046F0
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum, int>>.Equals
	|
	|-RVA: 0x3A04BD0 Offset: 0x3A04CD1 VA: 0x3A04BD0
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.Equals
	|
	|-RVA: 0x3A05150 Offset: 0x3A05251 VA: 0x3A05150
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A057B0 Offset: 0x3A058B1 VA: 0x3A057B0
	|-GenericEqualityComparer<ValueTuple<object, int, int, int>>.Equals
	|
	|-RVA: 0x3A05D30 Offset: 0x3A05E31 VA: 0x3A05D30
	|-GenericEqualityComparer<ValueTuple<object, object, object, object>>.Equals
	|
	|-RVA: 0x3A062C0 Offset: 0x3A063C1 VA: 0x3A062C0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A06990 Offset: 0x3A06A91 VA: 0x3A06990
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3A06F80 Offset: 0x3A07081 VA: 0x3A06F80
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A076C0 Offset: 0x3A077C1 VA: 0x3A076C0
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3A07CB0 Offset: 0x3A07DB1 VA: 0x3A07CB0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A08460 Offset: 0x3A08561 VA: 0x3A08460
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3A08AC0 Offset: 0x3A08BC1 VA: 0x3A08AC0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A092E0 Offset: 0x3A093E1 VA: 0x3A092E0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A098A0 Offset: 0x3A099A1 VA: 0x3A098A0
	|-GenericEqualityComparer<AsyncUnit>.Equals
	|
	|-RVA: 0x3A09AF0 Offset: 0x3A09BF1 VA: 0x3A09AF0
	|-GenericEqualityComparer<BoneWeight>.Equals
	|
	|-RVA: 0x3A09D50 Offset: 0x3A09E51 VA: 0x3A09D50
	|-GenericEqualityComparer<bool>.Equals
	|
	|-RVA: 0x3A09FB0 Offset: 0x3A0A0B1 VA: 0x3A09FB0
	|-GenericEqualityComparer<Bounds>.Equals
	|
	|-RVA: 0x3A0A210 Offset: 0x3A0A311 VA: 0x3A0A210
	|-GenericEqualityComparer<byte>.Equals
	|
	|-RVA: 0x3A0A460 Offset: 0x3A0A561 VA: 0x3A0A460
	|-GenericEqualityComparer<CancellationTokenRegistration>.Equals
	|
	|-RVA: 0x3A0A6C0 Offset: 0x3A0A7C1 VA: 0x3A0A6C0
	|-GenericEqualityComparer<char>.Equals
	|
	|-RVA: 0x3A0A900 Offset: 0x3A0AA01 VA: 0x3A0A900
	|-GenericEqualityComparer<Color>.Equals
	|
	|-RVA: 0x3A0ABA0 Offset: 0x3A0ACA1 VA: 0x3A0ABA0
	|-GenericEqualityComparer<ColorBlock>.Equals
	|
	|-RVA: 0x3A0AE60 Offset: 0x3A0AF61 VA: 0x3A0AE60
	|-GenericEqualityComparer<DateTime>.Equals
	|
	|-RVA: 0x3A0B0A0 Offset: 0x3A0B1A1 VA: 0x3A0B0A0
	|-GenericEqualityComparer<DateTimeOffset>.Equals
	|
	|-RVA: 0x3A0B300 Offset: 0x3A0B401 VA: 0x3A0B300
	|-GenericEqualityComparer<Decimal>.Equals
	|
	|-RVA: 0x3A0B560 Offset: 0x3A0B661 VA: 0x3A0B560
	|-GenericEqualityComparer<double>.Equals
	|
	|-RVA: 0x3A0B7B0 Offset: 0x3A0B8B1 VA: 0x3A0B7B0
	|-GenericEqualityComparer<GlyphRect>.Equals
	|
	|-RVA: 0x3A0BA10 Offset: 0x3A0BB11 VA: 0x3A0BA10
	|-GenericEqualityComparer<Guid>.Equals
	|
	|-RVA: 0x3A0BC70 Offset: 0x3A0BD71 VA: 0x3A0BC70
	|-GenericEqualityComparer<short>.Equals
	|
	|-RVA: 0x3A0BEB0 Offset: 0x3A0BFB1 VA: 0x3A0BEB0
	|-GenericEqualityComparer<int>.Equals
	|
	|-RVA: 0x3A0C0F0 Offset: 0x3A0C1F1 VA: 0x3A0C0F0
	|-GenericEqualityComparer<long>.Equals
	|
	|-RVA: 0x3A0C330 Offset: 0x3A0C431 VA: 0x3A0C330
	|-GenericEqualityComparer<Matrix4x4>.Equals
	|
	|-RVA: 0x3A0C5C0 Offset: 0x3A0C6C1 VA: 0x3A0C5C0
	|-GenericEqualityComparer<Navigation>.Equals
	|
	|-RVA: 0x3A0C8D0 Offset: 0x3A0C9D1 VA: 0x3A0C8D0
	|-GenericEqualityComparer<object>.Equals
	|
	|-RVA: 0x3A0CD30 Offset: 0x3A0CE31 VA: 0x3A0CD30
	|-GenericEqualityComparer<Playable>.Equals
	|
	|-RVA: 0x3A0CFE0 Offset: 0x3A0D0E1 VA: 0x3A0CFE0
	|-GenericEqualityComparer<Quaternion>.Equals
	|
	|-RVA: 0x3A0D280 Offset: 0x3A0D381 VA: 0x3A0D280
	|-GenericEqualityComparer<Rect>.Equals
	|
	|-RVA: 0x3A0D520 Offset: 0x3A0D621 VA: 0x3A0D520
	|-GenericEqualityComparer<sbyte>.Equals
	|
	|-RVA: 0x3A0D770 Offset: 0x3A0D871 VA: 0x3A0D770
	|-GenericEqualityComparer<ShaderTagId>.Equals
	|
	|-RVA: 0x3A0D9B0 Offset: 0x3A0DAB1 VA: 0x3A0D9B0
	|-GenericEqualityComparer<float>.Equals
	|
	|-RVA: 0x3A0DC00 Offset: 0x3A0DD01 VA: 0x3A0DC00
	|-GenericEqualityComparer<SphericalHarmonicsL2>.Equals
	|
	|-RVA: 0x3A0DEF0 Offset: 0x3A0DFF1 VA: 0x3A0DEF0
	|-GenericEqualityComparer<SpriteState>.Equals
	|
	|-RVA: 0x3A0E1D0 Offset: 0x3A0E2D1 VA: 0x3A0E1D0
	|-GenericEqualityComparer<TimeSpan>.Equals
	|
	|-RVA: 0x3A0E410 Offset: 0x3A0E511 VA: 0x3A0E410
	|-GenericEqualityComparer<ushort>.Equals
	|
	|-RVA: 0x3A0E650 Offset: 0x3A0E751 VA: 0x3A0E650
	|-GenericEqualityComparer<uint>.Equals
	|
	|-RVA: 0x3A0E890 Offset: 0x3A0E991 VA: 0x3A0E890
	|-GenericEqualityComparer<ulong>.Equals
	|
	|-RVA: 0x3A0EAD0 Offset: 0x3A0EBD1 VA: 0x3A0EAD0
	|-GenericEqualityComparer<UniTask>.Equals
	|
	|-RVA: 0x3A0ED10 Offset: 0x3A0EE11 VA: 0x3A0ED10
	|-GenericEqualityComparer<Unit>.Equals
	|
	|-RVA: 0x3A0EF60 Offset: 0x3A0F061 VA: 0x3A0EF60
	|-GenericEqualityComparer<Vector2>.Equals
	|
	|-RVA: 0x3A0F170 Offset: 0x3A0F271 VA: 0x3A0F170
	|-GenericEqualityComparer<Vector3>.Equals
	|
	|-RVA: 0x3A0F410 Offset: 0x3A0F511 VA: 0x3A0F410
	|-GenericEqualityComparer<Vector4>.Equals
	|
	|-RVA: 0x3A0F670 Offset: 0x3A0F771 VA: 0x3A0F670
	|-GenericEqualityComparer<VertexAttributeDescriptor>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override int GetHashCode(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EA25B0 Offset: 0x1EA26B1 VA: 0x1EA25B0
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.GetHashCode
	|
	|-RVA: 0x1EA2B00 Offset: 0x1EA2C01 VA: 0x1EA2B00
	|-GenericEqualityComparer<TimeInterval<object>>.GetHashCode
	|
	|-RVA: 0x1EA3020 Offset: 0x1EA3121 VA: 0x1EA3020
	|-GenericEqualityComparer<Timestamped<object>>.GetHashCode
	|
	|-RVA: 0x1EA3570 Offset: 0x1EA3671 VA: 0x1EA3570
	|-GenericEqualityComparer<UniTask<object>>.GetHashCode
	|
	|-RVA: 0x1EA3A50 Offset: 0x1EA3B51 VA: 0x1EA3A50
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1EA3F70 Offset: 0x1EA4071 VA: 0x1EA3F70
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1EA4500 Offset: 0x1EA4601 VA: 0x1EA4500
	|-GenericEqualityComparer<ValueTuple<bool, UniTask<object>>>.GetHashCode
	|
	|-RVA: 0x1EA4A90 Offset: 0x1EA4B91 VA: 0x1EA4A90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetHashCode
	|
	|-RVA: 0x1EA5040 Offset: 0x1EA5141 VA: 0x1EA5040
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetHashCode
	|
	|-RVA: 0x1EA5640 Offset: 0x1EA5741 VA: 0x1EA5640
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA5BE0 Offset: 0x1EA5CE1 VA: 0x1EA5BE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA60D0 Offset: 0x1EA61D1 VA: 0x1EA60D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA6640 Offset: 0x1EA6741 VA: 0x1EA6640
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA6C30 Offset: 0x1EA6D31 VA: 0x1EA6C30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA7190 Offset: 0x1EA7291 VA: 0x1EA7190
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA77C0 Offset: 0x1EA78C1 VA: 0x1EA77C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA7DA0 Offset: 0x1EA7EA1 VA: 0x1EA7DA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA8350 Offset: 0x1EA8451 VA: 0x1EA8350
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA8950 Offset: 0x1EA8A51 VA: 0x1EA8950
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA8F60 Offset: 0x1EA9061 VA: 0x1EA8F60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA95A0 Offset: 0x1EA96A1 VA: 0x1EA95A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA9BB0 Offset: 0x1EA9CB1 VA: 0x1EA9BB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAA160 Offset: 0x1EAA261 VA: 0x1EAA160
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAA700 Offset: 0x1EAA801 VA: 0x1EAA700
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAAC50 Offset: 0x1EAAD51 VA: 0x1EAAC50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAB230 Offset: 0x1EAB331 VA: 0x1EAB230
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAB7F0 Offset: 0x1EAB8F1 VA: 0x1EAB7F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetHashCode
	|
	|-RVA: 0x1EABE20 Offset: 0x1EABF21 VA: 0x1EABE20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAC420 Offset: 0x1EAC521 VA: 0x1EAC420
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EACA40 Offset: 0x1EACB41 VA: 0x1EACA40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAD0B0 Offset: 0x1EAD1B1 VA: 0x1EAD0B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAD740 Offset: 0x1EAD841 VA: 0x1EAD740
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EADE20 Offset: 0x1EADF21 VA: 0x1EADE20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAE520 Offset: 0x1EAE621 VA: 0x1EAE520
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A13B30 Offset: 0x3A13C31 VA: 0x3A13B30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetHashCode
	|
	|-RVA: 0x3A14020 Offset: 0x3A14121 VA: 0x3A14020
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetHashCode
	|
	|-RVA: 0x3A14570 Offset: 0x3A14671 VA: 0x3A14570
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetHashCode
	|
	|-RVA: 0x3A14B10 Offset: 0x3A14C11 VA: 0x3A14B10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetHashCode
	|
	|-RVA: 0x3A15040 Offset: 0x3A15141 VA: 0x3A15040
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetHashCode
	|
	|-RVA: 0x3A155F0 Offset: 0x3A156F1 VA: 0x3A155F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetHashCode
	|
	|-RVA: 0x3A15BD0 Offset: 0x3A15CD1 VA: 0x3A15BD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetHashCode
	|
	|-RVA: 0x3A16180 Offset: 0x3A16281 VA: 0x3A16180
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetHashCode
	|
	|-RVA: 0x3A16780 Offset: 0x3A16881 VA: 0x3A16780
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A16D60 Offset: 0x3A16E61 VA: 0x3A16D60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetHashCode
	|
	|-RVA: 0x3A172F0 Offset: 0x3A173F1 VA: 0x3A172F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetHashCode
	|
	|-RVA: 0x3A17880 Offset: 0x3A17981 VA: 0x3A17880
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetHashCode
	|
	|-RVA: 0x3A17E30 Offset: 0x3A17F31 VA: 0x3A17E30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetHashCode
	|
	|-RVA: 0x3A183D0 Offset: 0x3A184D1 VA: 0x3A183D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetHashCode
	|
	|-RVA: 0x3A18900 Offset: 0x3A18A01 VA: 0x3A18900
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetHashCode
	|
	|-RVA: 0x3A18EB0 Offset: 0x3A18FB1 VA: 0x3A18EB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetHashCode
	|
	|-RVA: 0x3A19490 Offset: 0x3A19591 VA: 0x3A19490
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetHashCode
	|
	|-RVA: 0x3A19A40 Offset: 0x3A19B41 VA: 0x3A19A40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1A040 Offset: 0x3A1A141 VA: 0x3A1A040
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1A660 Offset: 0x3A1A761 VA: 0x3A1A660
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A1ACB0 Offset: 0x3A1ADB1 VA: 0x3A1ACB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1B2F0 Offset: 0x3A1B3F1 VA: 0x3A1B2F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A1B9B0 Offset: 0x3A1BAB1 VA: 0x3A1B9B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1C060 Offset: 0x3A1C161 VA: 0x3A1C060
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A1C770 Offset: 0x3A1C871 VA: 0x3A1C770
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1CE40 Offset: 0x3A1CF41 VA: 0x3A1CE40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A1D5C0 Offset: 0x3A1D6C1 VA: 0x3A1D5C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1DD00 Offset: 0x3A1DE01 VA: 0x3A1DD00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A1E4D0 Offset: 0x3A1E5D1 VA: 0x3A1E4D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1EB10 Offset: 0x3A1EC11 VA: 0x3A1EB10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetHashCode
	|
	|-RVA: 0x3A1EFD0 Offset: 0x3A1F0D1 VA: 0x3A1EFD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetHashCode
	|
	|-RVA: 0x3A1F500 Offset: 0x3A1F601 VA: 0x3A1F500
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetHashCode
	|
	|-RVA: 0x3A1FAD0 Offset: 0x3A1FBD1 VA: 0x3A1FAD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetHashCode
	|
	|-RVA: 0x3A1FFF0 Offset: 0x3A200F1 VA: 0x3A1FFF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetHashCode
	|
	|-RVA: 0x3A205D0 Offset: 0x3A206D1 VA: 0x3A205D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetHashCode
	|
	|-RVA: 0x3A20B30 Offset: 0x3A20C31 VA: 0x3A20B30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetHashCode
	|
	|-RVA: 0x3A21050 Offset: 0x3A21151 VA: 0x3A21050
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetHashCode
	|
	|-RVA: 0x3A215E0 Offset: 0x3A216E1 VA: 0x3A215E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A21B90 Offset: 0x3A21C91 VA: 0x3A21B90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetHashCode
	|
	|-RVA: 0x3A22190 Offset: 0x3A22291 VA: 0x3A22190
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetHashCode
	|
	|-RVA: 0x3A22740 Offset: 0x3A22841 VA: 0x3A22740
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetHashCode
	|
	|-RVA: 0x3A22C60 Offset: 0x3A22D61 VA: 0x3A22C60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetHashCode
	|
	|-RVA: 0x3A231B0 Offset: 0x3A232B1 VA: 0x3A231B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetHashCode
	|
	|-RVA: 0x3A236B0 Offset: 0x3A237B1 VA: 0x3A236B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetHashCode
	|
	|-RVA: 0x3A23C40 Offset: 0x3A23D41 VA: 0x3A23C40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetHashCode
	|
	|-RVA: 0x3A241F0 Offset: 0x3A242F1 VA: 0x3A241F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetHashCode
	|
	|-RVA: 0x3A247D0 Offset: 0x3A248D1 VA: 0x3A247D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetHashCode
	|
	|-RVA: 0x3A24D60 Offset: 0x3A24E61 VA: 0x3A24D60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A25330 Offset: 0x3A25431 VA: 0x3A25330
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A25980 Offset: 0x3A25A81 VA: 0x3A25980
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A25FC0 Offset: 0x3A260C1 VA: 0x3A25FC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A26660 Offset: 0x3A26761 VA: 0x3A26660
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A26CC0 Offset: 0x3A26DC1 VA: 0x3A26CC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A273D0 Offset: 0x3A274D1 VA: 0x3A273D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A27AA0 Offset: 0x3A27BA1 VA: 0x3A27AA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A28200 Offset: 0x3A28301 VA: 0x3A28200
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A288F0 Offset: 0x3A289F1 VA: 0x3A288F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A290C0 Offset: 0x3A291C1 VA: 0x3A290C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A29750 Offset: 0x3A29851 VA: 0x3A29750
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A29D20 Offset: 0x3A29E21 VA: 0x3A29D20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A2A2A0 Offset: 0x3A2A3A1 VA: 0x3A2A2A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetHashCode
	|
	|-RVA: 0x3A2A790 Offset: 0x3A2A891 VA: 0x3A2A790
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.GetHashCode
	|
	|-RVA: 0x3A2ACC0 Offset: 0x3A2ADC1 VA: 0x3A2ACC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetHashCode
	|
	|-RVA: 0x3A2B210 Offset: 0x3A2B311 VA: 0x3A2B210
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.GetHashCode
	|
	|-RVA: 0x3A2B740 Offset: 0x3A2B841 VA: 0x3A2B740
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.GetHashCode
	|
	|-RVA: 0x3A2BCD0 Offset: 0x3A2BDD1 VA: 0x3A2BCD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.GetHashCode
	|
	|-RVA: 0x3A2C230 Offset: 0x3A2C331 VA: 0x3A2C230
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.GetHashCode
	|
	|-RVA: 0x3A2C790 Offset: 0x3A2C891 VA: 0x3A2C790
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.GetHashCode
	|
	|-RVA: 0x3A2CD20 Offset: 0x3A2CE21 VA: 0x3A2CD20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A2D2B0 Offset: 0x3A2D3B1 VA: 0x3A2D2B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetHashCode
	|
	|-RVA: 0x3A2D840 Offset: 0x3A2D941 VA: 0x3A2D840
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetHashCode
	|
	|-RVA: 0x3A2DDA0 Offset: 0x3A2DEA1 VA: 0x3A2DDA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.GetHashCode
	|
	|-RVA: 0x3A2E300 Offset: 0x3A2E401 VA: 0x3A2E300
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetHashCode
	|
	|-RVA: 0x3A2E850 Offset: 0x3A2E951 VA: 0x3A2E850
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetHashCode
	|
	|-RVA: 0x3A2ED50 Offset: 0x3A2EE51 VA: 0x3A2ED50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetHashCode
	|
	|-RVA: 0x3A2F270 Offset: 0x3A2F371 VA: 0x3A2F270
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetHashCode
	|
	|-RVA: 0x3A2F800 Offset: 0x3A2F901 VA: 0x3A2F800
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetHashCode
	|
	|-RVA: 0x3A2FD90 Offset: 0x3A2FE91 VA: 0x3A2FD90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.GetHashCode
	|
	|-RVA: 0x3A30320 Offset: 0x3A30421 VA: 0x3A30320
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.GetHashCode
	|
	|-RVA: 0x3A308D0 Offset: 0x3A309D1 VA: 0x3A308D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A30EB0 Offset: 0x3A30FB1 VA: 0x3A30EB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3A31480 Offset: 0x3A31581 VA: 0x3A31480
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A31AD0 Offset: 0x3A31BD1 VA: 0x3A31AD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3A32110 Offset: 0x3A32211 VA: 0x3A32110
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A327B0 Offset: 0x3A328B1 VA: 0x3A327B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3A32E10 Offset: 0x3A32F11 VA: 0x3A32E10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A33520 Offset: 0x3A33621 VA: 0x3A33520
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3A33BF0 Offset: 0x3A33CF1 VA: 0x3A33BF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x39FB410 Offset: 0x39FB511 VA: 0x39FB410
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x39FBB00 Offset: 0x39FBC01 VA: 0x39FBB00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x39FC280 Offset: 0x39FC381 VA: 0x39FC280
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x39FC800 Offset: 0x39FC901 VA: 0x39FC800
	|-GenericEqualityComparer<ValueTuple<bool, AsyncUnit>>.GetHashCode
	|
	|-RVA: 0x39FCCC0 Offset: 0x39FCDC1 VA: 0x39FCCC0
	|-GenericEqualityComparer<ValueTuple<bool, bool>>.GetHashCode
	|
	|-RVA: 0x39FD1E0 Offset: 0x39FD2E1 VA: 0x39FD1E0
	|-GenericEqualityComparer<ValueTuple<bool, Bounds>>.GetHashCode
	|
	|-RVA: 0x39FD780 Offset: 0x39FD881 VA: 0x39FD780
	|-GenericEqualityComparer<ValueTuple<bool, byte>>.GetHashCode
	|
	|-RVA: 0x39FDC80 Offset: 0x39FDD81 VA: 0x39FDC80
	|-GenericEqualityComparer<ValueTuple<bool, Color>>.GetHashCode
	|
	|-RVA: 0x39FE1E0 Offset: 0x39FE2E1 VA: 0x39FE1E0
	|-GenericEqualityComparer<ValueTuple<bool, double>>.GetHashCode
	|
	|-RVA: 0x39FE6C0 Offset: 0x39FE7C1 VA: 0x39FE6C0
	|-GenericEqualityComparer<ValueTuple<bool, int>>.GetHashCode
	|
	|-RVA: 0x39FEB90 Offset: 0x39FEC91 VA: 0x39FEB90
	|-GenericEqualityComparer<ValueTuple<bool, long>>.GetHashCode
	|
	|-RVA: 0x39FF080 Offset: 0x39FF181 VA: 0x39FF080
	|-GenericEqualityComparer<ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x39FF5A0 Offset: 0x39FF6A1 VA: 0x39FF5A0
	|-GenericEqualityComparer<ValueTuple<bool, Quaternion>>.GetHashCode
	|
	|-RVA: 0x39FFB30 Offset: 0x39FFC31 VA: 0x39FFB30
	|-GenericEqualityComparer<ValueTuple<bool, Rect>>.GetHashCode
	|
	|-RVA: 0x3A00080 Offset: 0x3A00181 VA: 0x3A00080
	|-GenericEqualityComparer<ValueTuple<bool, float>>.GetHashCode
	|
	|-RVA: 0x3A00550 Offset: 0x3A00651 VA: 0x3A00550
	|-GenericEqualityComparer<ValueTuple<bool, UniTask>>.GetHashCode
	|
	|-RVA: 0x3A00A30 Offset: 0x3A00B31 VA: 0x3A00A30
	|-GenericEqualityComparer<ValueTuple<bool, Unit>>.GetHashCode
	|
	|-RVA: 0x3A00F00 Offset: 0x3A01001 VA: 0x3A00F00
	|-GenericEqualityComparer<ValueTuple<bool, Vector2>>.GetHashCode
	|
	|-RVA: 0x3A01430 Offset: 0x3A01531 VA: 0x3A01430
	|-GenericEqualityComparer<ValueTuple<bool, Vector3>>.GetHashCode
	|
	|-RVA: 0x3A01950 Offset: 0x3A01A51 VA: 0x3A01950
	|-GenericEqualityComparer<ValueTuple<bool, Vector4>>.GetHashCode
	|
	|-RVA: 0x3A01EB0 Offset: 0x3A01FB1 VA: 0x3A01EB0
	|-GenericEqualityComparer<ValueTuple<int, object>>.GetHashCode
	|
	|-RVA: 0x3A02380 Offset: 0x3A02481 VA: 0x3A02380
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x3A02880 Offset: 0x3A02981 VA: 0x3A02880
	|-GenericEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.GetHashCode
	|
	|-RVA: 0x3A02DD0 Offset: 0x3A02ED1 VA: 0x3A02DD0
	|-GenericEqualityComparer<ValueTuple<object, int>>.GetHashCode
	|
	|-RVA: 0x3A032B0 Offset: 0x3A033B1 VA: 0x3A032B0
	|-GenericEqualityComparer<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x3A03790 Offset: 0x3A03891 VA: 0x3A03790
	|-GenericEqualityComparer<ValueTuple<object, float>>.GetHashCode
	|
	|-RVA: 0x3A03CA0 Offset: 0x3A03DA1 VA: 0x3A03CA0
	|-GenericEqualityComparer<ValueTuple<Vector3, float>>.GetHashCode
	|
	|-RVA: 0x3A04240 Offset: 0x3A04341 VA: 0x3A04240
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A047E0 Offset: 0x3A048E1 VA: 0x3A047E0
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x3A04CF0 Offset: 0x3A04DF1 VA: 0x3A04CF0
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.GetHashCode
	|
	|-RVA: 0x3A052B0 Offset: 0x3A053B1 VA: 0x3A052B0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A058D0 Offset: 0x3A059D1 VA: 0x3A058D0
	|-GenericEqualityComparer<ValueTuple<object, int, int, int>>.GetHashCode
	|
	|-RVA: 0x3A05E50 Offset: 0x3A05F51 VA: 0x3A05E50
	|-GenericEqualityComparer<ValueTuple<object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3A06440 Offset: 0x3A06541 VA: 0x3A06440
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A06AD0 Offset: 0x3A06BD1 VA: 0x3A06AD0
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3A07120 Offset: 0x3A07221 VA: 0x3A07120
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A07800 Offset: 0x3A07901 VA: 0x3A07800
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3A07E70 Offset: 0x3A07F71 VA: 0x3A07E70
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A085C0 Offset: 0x3A086C1 VA: 0x3A085C0
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3A08CA0 Offset: 0x3A08DA1 VA: 0x3A08CA0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A09410 Offset: 0x3A09511 VA: 0x3A09410
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A098D0 Offset: 0x3A099D1 VA: 0x3A098D0
	|-GenericEqualityComparer<AsyncUnit>.GetHashCode
	|
	|-RVA: 0x3A09B30 Offset: 0x3A09C31 VA: 0x3A09B30
	|-GenericEqualityComparer<BoneWeight>.GetHashCode
	|
	|-RVA: 0x3A09D90 Offset: 0x3A09E91 VA: 0x3A09D90
	|-GenericEqualityComparer<bool>.GetHashCode
	|
	|-RVA: 0x3A09FF0 Offset: 0x3A0A0F1 VA: 0x3A09FF0
	|-GenericEqualityComparer<Bounds>.GetHashCode
	|
	|-RVA: 0x3A0A240 Offset: 0x3A0A341 VA: 0x3A0A240
	|-GenericEqualityComparer<byte>.GetHashCode
	|
	|-RVA: 0x3A0A4A0 Offset: 0x3A0A5A1 VA: 0x3A0A4A0
	|-GenericEqualityComparer<CancellationTokenRegistration>.GetHashCode
	|
	|-RVA: 0x3A0A6F0 Offset: 0x3A0A7F1 VA: 0x3A0A6F0
	|-GenericEqualityComparer<char>.GetHashCode
	|
	|-RVA: 0x3A0A940 Offset: 0x3A0AA41 VA: 0x3A0A940
	|-GenericEqualityComparer<Color>.GetHashCode
	|
	|-RVA: 0x3A0AC00 Offset: 0x3A0AD01 VA: 0x3A0AC00
	|-GenericEqualityComparer<ColorBlock>.GetHashCode
	|
	|-RVA: 0x3A0AE90 Offset: 0x3A0AF91 VA: 0x3A0AE90
	|-GenericEqualityComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x3A0B0E0 Offset: 0x3A0B1E1 VA: 0x3A0B0E0
	|-GenericEqualityComparer<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x3A0B340 Offset: 0x3A0B441 VA: 0x3A0B340
	|-GenericEqualityComparer<Decimal>.GetHashCode
	|
	|-RVA: 0x3A0B590 Offset: 0x3A0B691 VA: 0x3A0B590
	|-GenericEqualityComparer<double>.GetHashCode
	|
	|-RVA: 0x3A0B7F0 Offset: 0x3A0B8F1 VA: 0x3A0B7F0
	|-GenericEqualityComparer<GlyphRect>.GetHashCode
	|
	|-RVA: 0x3A0BA50 Offset: 0x3A0BB51 VA: 0x3A0BA50
	|-GenericEqualityComparer<Guid>.GetHashCode
	|
	|-RVA: 0x3A0BCA0 Offset: 0x3A0BDA1 VA: 0x3A0BCA0
	|-GenericEqualityComparer<short>.GetHashCode
	|
	|-RVA: 0x3A0BEE0 Offset: 0x3A0BFE1 VA: 0x3A0BEE0
	|-GenericEqualityComparer<int>.GetHashCode
	|
	|-RVA: 0x3A0C120 Offset: 0x3A0C221 VA: 0x3A0C120
	|-GenericEqualityComparer<long>.GetHashCode
	|
	|-RVA: 0x3A0C380 Offset: 0x3A0C481 VA: 0x3A0C380
	|-GenericEqualityComparer<Matrix4x4>.GetHashCode
	|
	|-RVA: 0x3A0C610 Offset: 0x3A0C711 VA: 0x3A0C610
	|-GenericEqualityComparer<Navigation>.GetHashCode
	|
	|-RVA: 0x3A0C9A0 Offset: 0x3A0CAA1 VA: 0x3A0C9A0
	|-GenericEqualityComparer<object>.GetHashCode
	|
	|-RVA: 0x3A0CD70 Offset: 0x3A0CE71 VA: 0x3A0CD70
	|-GenericEqualityComparer<Playable>.GetHashCode
	|
	|-RVA: 0x3A0D020 Offset: 0x3A0D121 VA: 0x3A0D020
	|-GenericEqualityComparer<Quaternion>.GetHashCode
	|
	|-RVA: 0x3A0D2C0 Offset: 0x3A0D3C1 VA: 0x3A0D2C0
	|-GenericEqualityComparer<Rect>.GetHashCode
	|
	|-RVA: 0x3A0D550 Offset: 0x3A0D651 VA: 0x3A0D550
	|-GenericEqualityComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x3A0D7A0 Offset: 0x3A0D8A1 VA: 0x3A0D7A0
	|-GenericEqualityComparer<ShaderTagId>.GetHashCode
	|
	|-RVA: 0x3A0D9E0 Offset: 0x3A0DAE1 VA: 0x3A0D9E0
	|-GenericEqualityComparer<float>.GetHashCode
	|
	|-RVA: 0x3A0DC70 Offset: 0x3A0DD71 VA: 0x3A0DC70
	|-GenericEqualityComparer<SphericalHarmonicsL2>.GetHashCode
	|
	|-RVA: 0x3A0DF30 Offset: 0x3A0E031 VA: 0x3A0DF30
	|-GenericEqualityComparer<SpriteState>.GetHashCode
	|
	|-RVA: 0x3A0E200 Offset: 0x3A0E301 VA: 0x3A0E200
	|-GenericEqualityComparer<TimeSpan>.GetHashCode
	|
	|-RVA: 0x3A0E440 Offset: 0x3A0E541 VA: 0x3A0E440
	|-GenericEqualityComparer<ushort>.GetHashCode
	|
	|-RVA: 0x3A0E680 Offset: 0x3A0E781 VA: 0x3A0E680
	|-GenericEqualityComparer<uint>.GetHashCode
	|
	|-RVA: 0x3A0E8C0 Offset: 0x3A0E9C1 VA: 0x3A0E8C0
	|-GenericEqualityComparer<ulong>.GetHashCode
	|
	|-RVA: 0x3A0EB00 Offset: 0x3A0EC01 VA: 0x3A0EB00
	|-GenericEqualityComparer<UniTask>.GetHashCode
	|
	|-RVA: 0x3A0ED40 Offset: 0x3A0EE41 VA: 0x3A0ED40
	|-GenericEqualityComparer<Unit>.GetHashCode
	|
	|-RVA: 0x3A0EF80 Offset: 0x3A0F081 VA: 0x3A0EF80
	|-GenericEqualityComparer<Vector2>.GetHashCode
	|
	|-RVA: 0x3A0F1B0 Offset: 0x3A0F2B1 VA: 0x3A0F1B0
	|-GenericEqualityComparer<Vector3>.GetHashCode
	|
	|-RVA: 0x3A0F440 Offset: 0x3A0F541 VA: 0x3A0F440
	|-GenericEqualityComparer<Vector4>.GetHashCode
	|
	|-RVA: 0x3A0F6B0 Offset: 0x3A0F7B1 VA: 0x3A0F6B0
	|-GenericEqualityComparer<VertexAttributeDescriptor>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal override int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EA2630 Offset: 0x1EA2731 VA: 0x1EA2630
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.IndexOf
	|
	|-RVA: 0x1EA2B70 Offset: 0x1EA2C71 VA: 0x1EA2B70
	|-GenericEqualityComparer<TimeInterval<object>>.IndexOf
	|
	|-RVA: 0x1EA30A0 Offset: 0x1EA31A1 VA: 0x1EA30A0
	|-GenericEqualityComparer<Timestamped<object>>.IndexOf
	|
	|-RVA: 0x1EA35E0 Offset: 0x1EA36E1 VA: 0x1EA35E0
	|-GenericEqualityComparer<UniTask<object>>.IndexOf
	|
	|-RVA: 0x1EA3AC0 Offset: 0x1EA3BC1 VA: 0x1EA3AC0
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x1EA3FF0 Offset: 0x1EA40F1 VA: 0x1EA3FF0
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x1EA4580 Offset: 0x1EA4681 VA: 0x1EA4580
	|-GenericEqualityComparer<ValueTuple<bool, UniTask<object>>>.IndexOf
	|
	|-RVA: 0x1EA4B10 Offset: 0x1EA4C11 VA: 0x1EA4B10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.IndexOf
	|
	|-RVA: 0x1EA50D0 Offset: 0x1EA51D1 VA: 0x1EA50D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.IndexOf
	|
	|-RVA: 0x1EA56D0 Offset: 0x1EA57D1 VA: 0x1EA56D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.IndexOf
	|
	|-RVA: 0x1EA5C40 Offset: 0x1EA5D41 VA: 0x1EA5C40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.IndexOf
	|
	|-RVA: 0x1EA6130 Offset: 0x1EA6231 VA: 0x1EA6130
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.IndexOf
	|
	|-RVA: 0x1EA66E0 Offset: 0x1EA67E1 VA: 0x1EA66E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.IndexOf
	|
	|-RVA: 0x1EA6C90 Offset: 0x1EA6D91 VA: 0x1EA6C90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.IndexOf
	|
	|-RVA: 0x1EA7220 Offset: 0x1EA7321 VA: 0x1EA7220
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.IndexOf
	|
	|-RVA: 0x1EA7850 Offset: 0x1EA7951 VA: 0x1EA7850
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.IndexOf
	|
	|-RVA: 0x1EA7E20 Offset: 0x1EA7F21 VA: 0x1EA7E20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.IndexOf
	|
	|-RVA: 0x1EA83E0 Offset: 0x1EA84E1 VA: 0x1EA83E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.IndexOf
	|
	|-RVA: 0x1EA89E0 Offset: 0x1EA8AE1 VA: 0x1EA89E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x1EA8FF0 Offset: 0x1EA90F1 VA: 0x1EA8FF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.IndexOf
	|
	|-RVA: 0x1EA9630 Offset: 0x1EA9731 VA: 0x1EA9630
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.IndexOf
	|
	|-RVA: 0x1EA9C30 Offset: 0x1EA9D31 VA: 0x1EA9C30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.IndexOf
	|
	|-RVA: 0x1EAA1F0 Offset: 0x1EAA2F1 VA: 0x1EAA1F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.IndexOf
	|
	|-RVA: 0x1EAA760 Offset: 0x1EAA861 VA: 0x1EAA760
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.IndexOf
	|
	|-RVA: 0x1EAACE0 Offset: 0x1EAADE1 VA: 0x1EAACE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.IndexOf
	|
	|-RVA: 0x1EAB2B0 Offset: 0x1EAB3B1 VA: 0x1EAB2B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.IndexOf
	|
	|-RVA: 0x1EAB880 Offset: 0x1EAB981 VA: 0x1EAB880
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.IndexOf
	|
	|-RVA: 0x1EABEB0 Offset: 0x1EABFB1 VA: 0x1EABEB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.IndexOf
	|
	|-RVA: 0x1EAC4B0 Offset: 0x1EAC5B1 VA: 0x1EAC4B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.IndexOf
	|
	|-RVA: 0x1EACAE0 Offset: 0x1EACBE1 VA: 0x1EACAE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x1EAD150 Offset: 0x1EAD251 VA: 0x1EAD150
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x1EAD7F0 Offset: 0x1EAD8F1 VA: 0x1EAD7F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x1EADED0 Offset: 0x1EADFD1 VA: 0x1EADED0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x1EAE5E0 Offset: 0x1EAE6E1 VA: 0x1EAE5E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A13B90 Offset: 0x3A13C91 VA: 0x3A13B90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.IndexOf
	|
	|-RVA: 0x3A14080 Offset: 0x3A14181 VA: 0x3A14080
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.IndexOf
	|
	|-RVA: 0x3A14600 Offset: 0x3A14701 VA: 0x3A14600
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.IndexOf
	|
	|-RVA: 0x3A14B70 Offset: 0x3A14C71 VA: 0x3A14B70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.IndexOf
	|
	|-RVA: 0x3A150C0 Offset: 0x3A151C1 VA: 0x3A150C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.IndexOf
	|
	|-RVA: 0x3A15680 Offset: 0x3A15781 VA: 0x3A15680
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.IndexOf
	|
	|-RVA: 0x3A15C50 Offset: 0x3A15D51 VA: 0x3A15C50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.IndexOf
	|
	|-RVA: 0x3A16210 Offset: 0x3A16311 VA: 0x3A16210
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.IndexOf
	|
	|-RVA: 0x3A16810 Offset: 0x3A16911 VA: 0x3A16810
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A16DE0 Offset: 0x3A16EE1 VA: 0x3A16DE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.IndexOf
	|
	|-RVA: 0x3A17370 Offset: 0x3A17471 VA: 0x3A17370
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.IndexOf
	|
	|-RVA: 0x3A17900 Offset: 0x3A17A01 VA: 0x3A17900
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.IndexOf
	|
	|-RVA: 0x3A17EC0 Offset: 0x3A17FC1 VA: 0x3A17EC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.IndexOf
	|
	|-RVA: 0x3A18430 Offset: 0x3A18531 VA: 0x3A18430
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.IndexOf
	|
	|-RVA: 0x3A18980 Offset: 0x3A18A81 VA: 0x3A18980
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.IndexOf
	|
	|-RVA: 0x3A18F40 Offset: 0x3A19041 VA: 0x3A18F40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.IndexOf
	|
	|-RVA: 0x3A19510 Offset: 0x3A19611 VA: 0x3A19510
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.IndexOf
	|
	|-RVA: 0x3A19AD0 Offset: 0x3A19BD1 VA: 0x3A19AD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.IndexOf
	|
	|-RVA: 0x3A1A0D0 Offset: 0x3A1A1D1 VA: 0x3A1A0D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A1A700 Offset: 0x3A1A801 VA: 0x3A1A700
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A1AD40 Offset: 0x3A1AE41 VA: 0x3A1AD40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A1B3A0 Offset: 0x3A1B4A1 VA: 0x3A1B3A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A1BA50 Offset: 0x3A1BB51 VA: 0x3A1BA50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A1C120 Offset: 0x3A1C221 VA: 0x3A1C120
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A1C810 Offset: 0x3A1C911 VA: 0x3A1C810
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A1CF10 Offset: 0x3A1D011 VA: 0x3A1CF10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A1D670 Offset: 0x3A1D771 VA: 0x3A1D670
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A1DDE0 Offset: 0x3A1DEE1 VA: 0x3A1DDE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A1E580 Offset: 0x3A1E681 VA: 0x3A1E580
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3A1EB70 Offset: 0x3A1EC71 VA: 0x3A1EB70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.IndexOf
	|
	|-RVA: 0x3A1F030 Offset: 0x3A1F131 VA: 0x3A1F030
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.IndexOf
	|
	|-RVA: 0x3A1F590 Offset: 0x3A1F691 VA: 0x3A1F590
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.IndexOf
	|
	|-RVA: 0x3A1FB30 Offset: 0x3A1FC31 VA: 0x3A1FB30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.IndexOf
	|
	|-RVA: 0x3A20080 Offset: 0x3A20181 VA: 0x3A20080
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.IndexOf
	|
	|-RVA: 0x3A20650 Offset: 0x3A20751 VA: 0x3A20650
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.IndexOf
	|
	|-RVA: 0x3A20BA0 Offset: 0x3A20CA1 VA: 0x3A20BA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.IndexOf
	|
	|-RVA: 0x3A210D0 Offset: 0x3A211D1 VA: 0x3A210D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.IndexOf
	|
	|-RVA: 0x3A21660 Offset: 0x3A21761 VA: 0x3A21660
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3A21C20 Offset: 0x3A21D21 VA: 0x3A21C20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.IndexOf
	|
	|-RVA: 0x3A22220 Offset: 0x3A22321 VA: 0x3A22220
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.IndexOf
	|
	|-RVA: 0x3A227B0 Offset: 0x3A228B1 VA: 0x3A227B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.IndexOf
	|
	|-RVA: 0x3A22CE0 Offset: 0x3A22DE1 VA: 0x3A22CE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.IndexOf
	|
	|-RVA: 0x3A23210 Offset: 0x3A23311 VA: 0x3A23210
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.IndexOf
	|
	|-RVA: 0x3A23730 Offset: 0x3A23831 VA: 0x3A23730
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.IndexOf
	|
	|-RVA: 0x3A23CC0 Offset: 0x3A23DC1 VA: 0x3A23CC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.IndexOf
	|
	|-RVA: 0x3A24280 Offset: 0x3A24381 VA: 0x3A24280
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.IndexOf
	|
	|-RVA: 0x3A24850 Offset: 0x3A24951 VA: 0x3A24850
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.IndexOf
	|
	|-RVA: 0x3A24DE0 Offset: 0x3A24EE1 VA: 0x3A24DE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.IndexOf
	|
	|-RVA: 0x3A253D0 Offset: 0x3A254D1 VA: 0x3A253D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A25A10 Offset: 0x3A25B11 VA: 0x3A25A10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.IndexOf
	|
	|-RVA: 0x3A26070 Offset: 0x3A26171 VA: 0x3A26070
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A266F0 Offset: 0x3A267F1 VA: 0x3A266F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x3A26D80 Offset: 0x3A26E81 VA: 0x3A26D80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A27470 Offset: 0x3A27571 VA: 0x3A27470
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x3A27B70 Offset: 0x3A27C71 VA: 0x3A27B70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A282A0 Offset: 0x3A283A1 VA: 0x3A282A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x3A289D0 Offset: 0x3A28AD1 VA: 0x3A289D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3A29170 Offset: 0x3A29271 VA: 0x3A29170
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x3A297E0 Offset: 0x3A298E1 VA: 0x3A297E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A29DB0 Offset: 0x3A29EB1 VA: 0x3A29DB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3A2A300 Offset: 0x3A2A401 VA: 0x3A2A300
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.IndexOf
	|
	|-RVA: 0x3A2A7F0 Offset: 0x3A2A8F1 VA: 0x3A2A7F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.IndexOf
	|
	|-RVA: 0x3A2AD40 Offset: 0x3A2AE41 VA: 0x3A2AD40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.IndexOf
	|
	|-RVA: 0x3A2B270 Offset: 0x3A2B371 VA: 0x3A2B270
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.IndexOf
	|
	|-RVA: 0x3A2B7C0 Offset: 0x3A2B8C1 VA: 0x3A2B7C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.IndexOf
	|
	|-RVA: 0x3A2BD50 Offset: 0x3A2BE51 VA: 0x3A2BD50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.IndexOf
	|
	|-RVA: 0x3A2C2A0 Offset: 0x3A2C3A1 VA: 0x3A2C2A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.IndexOf
	|
	|-RVA: 0x3A2C810 Offset: 0x3A2C911 VA: 0x3A2C810
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.IndexOf
	|
	|-RVA: 0x3A2CDA0 Offset: 0x3A2CEA1 VA: 0x3A2CDA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3A2D330 Offset: 0x3A2D431 VA: 0x3A2D330
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.IndexOf
	|
	|-RVA: 0x3A2D8C0 Offset: 0x3A2D9C1 VA: 0x3A2D8C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.IndexOf
	|
	|-RVA: 0x3A2DE10 Offset: 0x3A2DF11 VA: 0x3A2DE10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.IndexOf
	|
	|-RVA: 0x3A2E380 Offset: 0x3A2E481 VA: 0x3A2E380
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.IndexOf
	|
	|-RVA: 0x3A2E8B0 Offset: 0x3A2E9B1 VA: 0x3A2E8B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.IndexOf
	|
	|-RVA: 0x3A2EDC0 Offset: 0x3A2EEC1 VA: 0x3A2EDC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.IndexOf
	|
	|-RVA: 0x3A2F2F0 Offset: 0x3A2F3F1 VA: 0x3A2F2F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.IndexOf
	|
	|-RVA: 0x3A2F880 Offset: 0x3A2F981 VA: 0x3A2F880
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.IndexOf
	|
	|-RVA: 0x3A2FE10 Offset: 0x3A2FF11 VA: 0x3A2FE10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.IndexOf
	|
	|-RVA: 0x3A303A0 Offset: 0x3A304A1 VA: 0x3A303A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.IndexOf
	|
	|-RVA: 0x3A30960 Offset: 0x3A30A61 VA: 0x3A30960
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3A30F30 Offset: 0x3A31031 VA: 0x3A30F30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.IndexOf
	|
	|-RVA: 0x3A31520 Offset: 0x3A31621 VA: 0x3A31520
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3A31B60 Offset: 0x3A31C61 VA: 0x3A31B60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3A321C0 Offset: 0x3A322C1 VA: 0x3A321C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3A32840 Offset: 0x3A32941 VA: 0x3A32840
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3A32ED0 Offset: 0x3A32FD1 VA: 0x3A32ED0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3A335C0 Offset: 0x3A336C1 VA: 0x3A335C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3A33CC0 Offset: 0x3A33DC1 VA: 0x3A33CC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x39FB4B0 Offset: 0x39FB5B1 VA: 0x39FB4B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x39FBBE0 Offset: 0x39FBCE1 VA: 0x39FBBE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x39FC310 Offset: 0x39FC411 VA: 0x39FC310
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x39FC860 Offset: 0x39FC961 VA: 0x39FC860
	|-GenericEqualityComparer<ValueTuple<bool, AsyncUnit>>.IndexOf
	|
	|-RVA: 0x39FCD20 Offset: 0x39FCE21 VA: 0x39FCD20
	|-GenericEqualityComparer<ValueTuple<bool, bool>>.IndexOf
	|
	|-RVA: 0x39FD270 Offset: 0x39FD371 VA: 0x39FD270
	|-GenericEqualityComparer<ValueTuple<bool, Bounds>>.IndexOf
	|
	|-RVA: 0x39FD7E0 Offset: 0x39FD8E1 VA: 0x39FD7E0
	|-GenericEqualityComparer<ValueTuple<bool, byte>>.IndexOf
	|
	|-RVA: 0x39FDD00 Offset: 0x39FDE01 VA: 0x39FDD00
	|-GenericEqualityComparer<ValueTuple<bool, Color>>.IndexOf
	|
	|-RVA: 0x39FE250 Offset: 0x39FE351 VA: 0x39FE250
	|-GenericEqualityComparer<ValueTuple<bool, double>>.IndexOf
	|
	|-RVA: 0x39FE720 Offset: 0x39FE821 VA: 0x39FE720
	|-GenericEqualityComparer<ValueTuple<bool, int>>.IndexOf
	|
	|-RVA: 0x39FEC00 Offset: 0x39FED01 VA: 0x39FEC00
	|-GenericEqualityComparer<ValueTuple<bool, long>>.IndexOf
	|
	|-RVA: 0x39FF0F0 Offset: 0x39FF1F1 VA: 0x39FF0F0
	|-GenericEqualityComparer<ValueTuple<bool, object>>.IndexOf
	|
	|-RVA: 0x39FF620 Offset: 0x39FF721 VA: 0x39FF620
	|-GenericEqualityComparer<ValueTuple<bool, Quaternion>>.IndexOf
	|
	|-RVA: 0x39FFBB0 Offset: 0x39FFCB1 VA: 0x39FFBB0
	|-GenericEqualityComparer<ValueTuple<bool, Rect>>.IndexOf
	|
	|-RVA: 0x3A000E0 Offset: 0x3A001E1 VA: 0x3A000E0
	|-GenericEqualityComparer<ValueTuple<bool, float>>.IndexOf
	|
	|-RVA: 0x3A005C0 Offset: 0x3A006C1 VA: 0x3A005C0
	|-GenericEqualityComparer<ValueTuple<bool, UniTask>>.IndexOf
	|
	|-RVA: 0x3A00A90 Offset: 0x3A00B91 VA: 0x3A00A90
	|-GenericEqualityComparer<ValueTuple<bool, Unit>>.IndexOf
	|
	|-RVA: 0x3A00F70 Offset: 0x3A01071 VA: 0x3A00F70
	|-GenericEqualityComparer<ValueTuple<bool, Vector2>>.IndexOf
	|
	|-RVA: 0x3A014A0 Offset: 0x3A015A1 VA: 0x3A014A0
	|-GenericEqualityComparer<ValueTuple<bool, Vector3>>.IndexOf
	|
	|-RVA: 0x3A019D0 Offset: 0x3A01AD1 VA: 0x3A019D0
	|-GenericEqualityComparer<ValueTuple<bool, Vector4>>.IndexOf
	|
	|-RVA: 0x3A01F20 Offset: 0x3A02021 VA: 0x3A01F20
	|-GenericEqualityComparer<ValueTuple<int, object>>.IndexOf
	|
	|-RVA: 0x3A023E0 Offset: 0x3A024E1 VA: 0x3A023E0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3A02900 Offset: 0x3A02A01 VA: 0x3A02900
	|-GenericEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.IndexOf
	|
	|-RVA: 0x3A02E40 Offset: 0x3A02F41 VA: 0x3A02E40
	|-GenericEqualityComparer<ValueTuple<object, int>>.IndexOf
	|
	|-RVA: 0x3A03320 Offset: 0x3A03421 VA: 0x3A03320
	|-GenericEqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x3A03800 Offset: 0x3A03901 VA: 0x3A03800
	|-GenericEqualityComparer<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x3A03D20 Offset: 0x3A03E21 VA: 0x3A03D20
	|-GenericEqualityComparer<ValueTuple<Vector3, float>>.IndexOf
	|
	|-RVA: 0x3A042D0 Offset: 0x3A043D1 VA: 0x3A042D0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3A04850 Offset: 0x3A04951 VA: 0x3A04850
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3A04D70 Offset: 0x3A04E71 VA: 0x3A04D70
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.IndexOf
	|
	|-RVA: 0x3A05350 Offset: 0x3A05451 VA: 0x3A05350
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3A05950 Offset: 0x3A05A51 VA: 0x3A05950
	|-GenericEqualityComparer<ValueTuple<object, int, int, int>>.IndexOf
	|
	|-RVA: 0x3A05ED0 Offset: 0x3A05FD1 VA: 0x3A05ED0
	|-GenericEqualityComparer<ValueTuple<object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3A064F0 Offset: 0x3A065F1 VA: 0x3A064F0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3A06B60 Offset: 0x3A06C61 VA: 0x3A06B60
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3A071E0 Offset: 0x3A072E1 VA: 0x3A071E0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3A07890 Offset: 0x3A07991 VA: 0x3A07890
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3A07F40 Offset: 0x3A08041 VA: 0x3A07F40
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3A08660 Offset: 0x3A08761 VA: 0x3A08660
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3A08D80 Offset: 0x3A08E81 VA: 0x3A08D80
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3A094A0 Offset: 0x3A095A1 VA: 0x3A094A0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3A09900 Offset: 0x3A09A01 VA: 0x3A09900
	|-GenericEqualityComparer<AsyncUnit>.IndexOf
	|
	|-RVA: 0x3A09B40 Offset: 0x3A09C41 VA: 0x3A09B40
	|-GenericEqualityComparer<BoneWeight>.IndexOf
	|
	|-RVA: 0x3A09DC0 Offset: 0x3A09EC1 VA: 0x3A09DC0
	|-GenericEqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x3A0A000 Offset: 0x3A0A101 VA: 0x3A0A000
	|-GenericEqualityComparer<Bounds>.IndexOf
	|
	|-RVA: 0x3A0A270 Offset: 0x3A0A371 VA: 0x3A0A270
	|-GenericEqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x3A0A4B0 Offset: 0x3A0A5B1 VA: 0x3A0A4B0
	|-GenericEqualityComparer<CancellationTokenRegistration>.IndexOf
	|
	|-RVA: 0x3A0A720 Offset: 0x3A0A821 VA: 0x3A0A720
	|-GenericEqualityComparer<char>.IndexOf
	|
	|-RVA: 0x3A0A970 Offset: 0x3A0AA71 VA: 0x3A0A970
	|-GenericEqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x3A0AC10 Offset: 0x3A0AD11 VA: 0x3A0AC10
	|-GenericEqualityComparer<ColorBlock>.IndexOf
	|
	|-RVA: 0x3A0AEC0 Offset: 0x3A0AFC1 VA: 0x3A0AEC0
	|-GenericEqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x3A0B110 Offset: 0x3A0B211 VA: 0x3A0B110
	|-GenericEqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x3A0B370 Offset: 0x3A0B471 VA: 0x3A0B370
	|-GenericEqualityComparer<Decimal>.IndexOf
	|
	|-RVA: 0x3A0B5C0 Offset: 0x3A0B6C1 VA: 0x3A0B5C0
	|-GenericEqualityComparer<double>.IndexOf
	|
	|-RVA: 0x3A0B820 Offset: 0x3A0B921 VA: 0x3A0B820
	|-GenericEqualityComparer<GlyphRect>.IndexOf
	|
	|-RVA: 0x3A0BA80 Offset: 0x3A0BB81 VA: 0x3A0BA80
	|-GenericEqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x3A0BCD0 Offset: 0x3A0BDD1 VA: 0x3A0BCD0
	|-GenericEqualityComparer<short>.IndexOf
	|
	|-RVA: 0x3A0BF10 Offset: 0x3A0C011 VA: 0x3A0BF10
	|-GenericEqualityComparer<int>.IndexOf
	|
	|-RVA: 0x3A0C150 Offset: 0x3A0C251 VA: 0x3A0C150
	|-GenericEqualityComparer<long>.IndexOf
	|
	|-RVA: 0x3A0C390 Offset: 0x3A0C491 VA: 0x3A0C390
	|-GenericEqualityComparer<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3A0C6A0 Offset: 0x3A0C7A1 VA: 0x3A0C6A0
	|-GenericEqualityComparer<Navigation>.IndexOf
	|
	|-RVA: 0x3A0C9C0 Offset: 0x3A0CAC1 VA: 0x3A0C9C0
	|-GenericEqualityComparer<object>.IndexOf
	|
	|-RVA: 0x3A0CDF0 Offset: 0x3A0CEF1 VA: 0x3A0CDF0
	|-GenericEqualityComparer<Playable>.IndexOf
	|
	|-RVA: 0x3A0D050 Offset: 0x3A0D151 VA: 0x3A0D050
	|-GenericEqualityComparer<Quaternion>.IndexOf
	|
	|-RVA: 0x3A0D2F0 Offset: 0x3A0D3F1 VA: 0x3A0D2F0
	|-GenericEqualityComparer<Rect>.IndexOf
	|
	|-RVA: 0x3A0D580 Offset: 0x3A0D681 VA: 0x3A0D580
	|-GenericEqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x3A0D7D0 Offset: 0x3A0D8D1 VA: 0x3A0D7D0
	|-GenericEqualityComparer<ShaderTagId>.IndexOf
	|
	|-RVA: 0x3A0DA10 Offset: 0x3A0DB11 VA: 0x3A0DA10
	|-GenericEqualityComparer<float>.IndexOf
	|
	|-RVA: 0x3A0DC80 Offset: 0x3A0DD81 VA: 0x3A0DC80
	|-GenericEqualityComparer<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x3A0DFC0 Offset: 0x3A0E0C1 VA: 0x3A0DFC0
	|-GenericEqualityComparer<SpriteState>.IndexOf
	|
	|-RVA: 0x3A0E230 Offset: 0x3A0E331 VA: 0x3A0E230
	|-GenericEqualityComparer<TimeSpan>.IndexOf
	|
	|-RVA: 0x3A0E470 Offset: 0x3A0E571 VA: 0x3A0E470
	|-GenericEqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x3A0E6B0 Offset: 0x3A0E7B1 VA: 0x3A0E6B0
	|-GenericEqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x3A0E8F0 Offset: 0x3A0E9F1 VA: 0x3A0E8F0
	|-GenericEqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x3A0EB30 Offset: 0x3A0EC31 VA: 0x3A0EB30
	|-GenericEqualityComparer<UniTask>.IndexOf
	|
	|-RVA: 0x3A0ED70 Offset: 0x3A0EE71 VA: 0x3A0ED70
	|-GenericEqualityComparer<Unit>.IndexOf
	|
	|-RVA: 0x3A0EFB0 Offset: 0x3A0F0B1 VA: 0x3A0EFB0
	|-GenericEqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x3A0F1E0 Offset: 0x3A0F2E1 VA: 0x3A0F1E0
	|-GenericEqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x3A0F470 Offset: 0x3A0F571 VA: 0x3A0F470
	|-GenericEqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x3A0F6E0 Offset: 0x3A0F7E1 VA: 0x3A0F6E0
	|-GenericEqualityComparer<VertexAttributeDescriptor>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal override int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EA27D0 Offset: 0x1EA28D1 VA: 0x1EA27D0
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.LastIndexOf
	|
	|-RVA: 0x1EA2CE0 Offset: 0x1EA2DE1 VA: 0x1EA2CE0
	|-GenericEqualityComparer<TimeInterval<object>>.LastIndexOf
	|
	|-RVA: 0x1EA3240 Offset: 0x1EA3341 VA: 0x1EA3240
	|-GenericEqualityComparer<Timestamped<object>>.LastIndexOf
	|
	|-RVA: 0x1EA3750 Offset: 0x1EA3851 VA: 0x1EA3750
	|-GenericEqualityComparer<UniTask<object>>.LastIndexOf
	|
	|-RVA: 0x1EA3C30 Offset: 0x1EA3D31 VA: 0x1EA3C30
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x1EA4190 Offset: 0x1EA4291 VA: 0x1EA4190
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x1EA4720 Offset: 0x1EA4821 VA: 0x1EA4720
	|-GenericEqualityComparer<ValueTuple<bool, UniTask<object>>>.LastIndexOf
	|
	|-RVA: 0x1EA4CB0 Offset: 0x1EA4DB1 VA: 0x1EA4CB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.LastIndexOf
	|
	|-RVA: 0x1EA5290 Offset: 0x1EA5391 VA: 0x1EA5290
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA5890 Offset: 0x1EA5991 VA: 0x1EA5890
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA5DC0 Offset: 0x1EA5EC1 VA: 0x1EA5DC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA62B0 Offset: 0x1EA63B1 VA: 0x1EA62B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA68C0 Offset: 0x1EA69C1 VA: 0x1EA68C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA6E10 Offset: 0x1EA6F11 VA: 0x1EA6E10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA7400 Offset: 0x1EA7501 VA: 0x1EA7400
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA7A10 Offset: 0x1EA7B11 VA: 0x1EA7A10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA7FC0 Offset: 0x1EA80C1 VA: 0x1EA7FC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA85A0 Offset: 0x1EA86A1 VA: 0x1EA85A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA8BA0 Offset: 0x1EA8CA1 VA: 0x1EA8BA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA91D0 Offset: 0x1EA92D1 VA: 0x1EA91D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA9810 Offset: 0x1EA9911 VA: 0x1EA9810
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EA9DD0 Offset: 0x1EA9ED1 VA: 0x1EA9DD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EAA3B0 Offset: 0x1EAA4B1 VA: 0x1EAA3B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EAA8E0 Offset: 0x1EAA9E1 VA: 0x1EAA8E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EAAEA0 Offset: 0x1EAAFA1 VA: 0x1EAAEA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EAB450 Offset: 0x1EAB551 VA: 0x1EAB450
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EABA60 Offset: 0x1EABB61 VA: 0x1EABA60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EAC070 Offset: 0x1EAC171 VA: 0x1EAC070
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EAC670 Offset: 0x1EAC771 VA: 0x1EAC670
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EACCC0 Offset: 0x1EACDC1 VA: 0x1EACCC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EAD330 Offset: 0x1EAD431 VA: 0x1EAD330
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EAD9F0 Offset: 0x1EADAF1 VA: 0x1EAD9F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EAE0D0 Offset: 0x1EAE1D1 VA: 0x1EAE0D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x1EAE800 Offset: 0x1EAE901 VA: 0x1EAE800
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A13D10 Offset: 0x3A13E11 VA: 0x3A13D10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.LastIndexOf
	|
	|-RVA: 0x3A14200 Offset: 0x3A14301 VA: 0x3A14200
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.LastIndexOf
	|
	|-RVA: 0x3A147C0 Offset: 0x3A148C1 VA: 0x3A147C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.LastIndexOf
	|
	|-RVA: 0x3A14CF0 Offset: 0x3A14DF1 VA: 0x3A14CF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.LastIndexOf
	|
	|-RVA: 0x3A15260 Offset: 0x3A15361 VA: 0x3A15260
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.LastIndexOf
	|
	|-RVA: 0x3A15840 Offset: 0x3A15941 VA: 0x3A15840
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.LastIndexOf
	|
	|-RVA: 0x3A15DF0 Offset: 0x3A15EF1 VA: 0x3A15DF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.LastIndexOf
	|
	|-RVA: 0x3A163D0 Offset: 0x3A164D1 VA: 0x3A163D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.LastIndexOf
	|
	|-RVA: 0x3A169D0 Offset: 0x3A16AD1 VA: 0x3A169D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A16F80 Offset: 0x3A17081 VA: 0x3A16F80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.LastIndexOf
	|
	|-RVA: 0x3A17510 Offset: 0x3A17611 VA: 0x3A17510
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.LastIndexOf
	|
	|-RVA: 0x3A17AA0 Offset: 0x3A17BA1 VA: 0x3A17AA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.LastIndexOf
	|
	|-RVA: 0x3A18080 Offset: 0x3A18181 VA: 0x3A18080
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.LastIndexOf
	|
	|-RVA: 0x3A185B0 Offset: 0x3A186B1 VA: 0x3A185B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.LastIndexOf
	|
	|-RVA: 0x3A18B20 Offset: 0x3A18C21 VA: 0x3A18B20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.LastIndexOf
	|
	|-RVA: 0x3A19100 Offset: 0x3A19201 VA: 0x3A19100
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.LastIndexOf
	|
	|-RVA: 0x3A196B0 Offset: 0x3A197B1 VA: 0x3A196B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.LastIndexOf
	|
	|-RVA: 0x3A19C90 Offset: 0x3A19D91 VA: 0x3A19C90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1A290 Offset: 0x3A1A391 VA: 0x3A1A290
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1A8E0 Offset: 0x3A1A9E1 VA: 0x3A1A8E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1AF00 Offset: 0x3A1B001 VA: 0x3A1AF00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1B5A0 Offset: 0x3A1B6A1 VA: 0x3A1B5A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1BC30 Offset: 0x3A1BD31 VA: 0x3A1BC30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1C340 Offset: 0x3A1C441 VA: 0x3A1C340
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1C9F0 Offset: 0x3A1CAF1 VA: 0x3A1C9F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1D150 Offset: 0x3A1D251 VA: 0x3A1D150
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1D870 Offset: 0x3A1D971 VA: 0x3A1D870
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1E040 Offset: 0x3A1E141 VA: 0x3A1E040
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1E780 Offset: 0x3A1E881 VA: 0x3A1E780
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A1ECE0 Offset: 0x3A1EDE1 VA: 0x3A1ECE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.LastIndexOf
	|
	|-RVA: 0x3A1F1A0 Offset: 0x3A1F2A1 VA: 0x3A1F1A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.LastIndexOf
	|
	|-RVA: 0x3A1F770 Offset: 0x3A1F871 VA: 0x3A1F770
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.LastIndexOf
	|
	|-RVA: 0x3A1FCA0 Offset: 0x3A1FDA1 VA: 0x3A1FCA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.LastIndexOf
	|
	|-RVA: 0x3A20240 Offset: 0x3A20341 VA: 0x3A20240
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.LastIndexOf
	|
	|-RVA: 0x3A207F0 Offset: 0x3A208F1 VA: 0x3A207F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.LastIndexOf
	|
	|-RVA: 0x3A20D10 Offset: 0x3A20E11 VA: 0x3A20D10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.LastIndexOf
	|
	|-RVA: 0x3A21270 Offset: 0x3A21371 VA: 0x3A21270
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.LastIndexOf
	|
	|-RVA: 0x3A21800 Offset: 0x3A21901 VA: 0x3A21800
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A21DE0 Offset: 0x3A21EE1 VA: 0x3A21DE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.LastIndexOf
	|
	|-RVA: 0x3A223E0 Offset: 0x3A224E1 VA: 0x3A223E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.LastIndexOf
	|
	|-RVA: 0x3A22920 Offset: 0x3A22A21 VA: 0x3A22920
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.LastIndexOf
	|
	|-RVA: 0x3A22E80 Offset: 0x3A22F81 VA: 0x3A22E80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.LastIndexOf
	|
	|-RVA: 0x3A23380 Offset: 0x3A23481 VA: 0x3A23380
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.LastIndexOf
	|
	|-RVA: 0x3A238D0 Offset: 0x3A239D1 VA: 0x3A238D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.LastIndexOf
	|
	|-RVA: 0x3A23E60 Offset: 0x3A23F61 VA: 0x3A23E60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.LastIndexOf
	|
	|-RVA: 0x3A24440 Offset: 0x3A24541 VA: 0x3A24440
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.LastIndexOf
	|
	|-RVA: 0x3A249F0 Offset: 0x3A24AF1 VA: 0x3A249F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A24F80 Offset: 0x3A25081 VA: 0x3A24F80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A255B0 Offset: 0x3A256B1 VA: 0x3A255B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A25BD0 Offset: 0x3A25CD1 VA: 0x3A25BD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A26270 Offset: 0x3A26371 VA: 0x3A26270
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A268B0 Offset: 0x3A269B1 VA: 0x3A268B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A26FA0 Offset: 0x3A270A1 VA: 0x3A26FA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A27650 Offset: 0x3A27751 VA: 0x3A27650
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A27DB0 Offset: 0x3A27EB1 VA: 0x3A27DB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A28480 Offset: 0x3A28581 VA: 0x3A28480
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A28C30 Offset: 0x3A28D31 VA: 0x3A28C30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3A29370 Offset: 0x3A29471 VA: 0x3A29370
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A29990 Offset: 0x3A29A91 VA: 0x3A29990
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A29F60 Offset: 0x3A2A061 VA: 0x3A29F60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3A2A480 Offset: 0x3A2A581 VA: 0x3A2A480
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.LastIndexOf
	|
	|-RVA: 0x3A2A970 Offset: 0x3A2AA71 VA: 0x3A2A970
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.LastIndexOf
	|
	|-RVA: 0x3A2AEE0 Offset: 0x3A2AFE1 VA: 0x3A2AEE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.LastIndexOf
	|
	|-RVA: 0x3A2B3F0 Offset: 0x3A2B4F1 VA: 0x3A2B3F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.LastIndexOf
	|
	|-RVA: 0x3A2B960 Offset: 0x3A2BA61 VA: 0x3A2B960
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.LastIndexOf
	|
	|-RVA: 0x3A2BEF0 Offset: 0x3A2BFF1 VA: 0x3A2BEF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.LastIndexOf
	|
	|-RVA: 0x3A2C430 Offset: 0x3A2C531 VA: 0x3A2C430
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.LastIndexOf
	|
	|-RVA: 0x3A2C9B0 Offset: 0x3A2CAB1 VA: 0x3A2C9B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.LastIndexOf
	|
	|-RVA: 0x3A2CF40 Offset: 0x3A2D041 VA: 0x3A2CF40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3A2D4D0 Offset: 0x3A2D5D1 VA: 0x3A2D4D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.LastIndexOf
	|
	|-RVA: 0x3A2DA60 Offset: 0x3A2DB61 VA: 0x3A2DA60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.LastIndexOf
	|
	|-RVA: 0x3A2DFA0 Offset: 0x3A2E0A1 VA: 0x3A2DFA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.LastIndexOf
	|
	|-RVA: 0x3A2E520 Offset: 0x3A2E621 VA: 0x3A2E520
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.LastIndexOf
	|
	|-RVA: 0x3A2EA30 Offset: 0x3A2EB31 VA: 0x3A2EA30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.LastIndexOf
	|
	|-RVA: 0x3A2EF30 Offset: 0x3A2F031 VA: 0x3A2EF30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.LastIndexOf
	|
	|-RVA: 0x3A2F490 Offset: 0x3A2F591 VA: 0x3A2F490
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.LastIndexOf
	|
	|-RVA: 0x3A2FA20 Offset: 0x3A2FB21 VA: 0x3A2FA20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.LastIndexOf
	|
	|-RVA: 0x3A2FFB0 Offset: 0x3A300B1 VA: 0x3A2FFB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.LastIndexOf
	|
	|-RVA: 0x3A30540 Offset: 0x3A30641 VA: 0x3A30540
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.LastIndexOf
	|
	|-RVA: 0x3A30B20 Offset: 0x3A30C21 VA: 0x3A30B20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A310D0 Offset: 0x3A311D1 VA: 0x3A310D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3A31700 Offset: 0x3A31801 VA: 0x3A31700
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A31D20 Offset: 0x3A31E21 VA: 0x3A31D20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3A323C0 Offset: 0x3A324C1 VA: 0x3A323C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A32A00 Offset: 0x3A32B01 VA: 0x3A32A00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3A330F0 Offset: 0x3A331F1 VA: 0x3A330F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A337A0 Offset: 0x3A338A1 VA: 0x3A337A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3A33F00 Offset: 0x3A34001 VA: 0x3A33F00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x39FB690 Offset: 0x39FB791 VA: 0x39FB690
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x39FBE40 Offset: 0x39FBF41 VA: 0x39FBE40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x39FC4C0 Offset: 0x39FC5C1 VA: 0x39FC4C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x39FC9D0 Offset: 0x39FCAD1 VA: 0x39FC9D0
	|-GenericEqualityComparer<ValueTuple<bool, AsyncUnit>>.LastIndexOf
	|
	|-RVA: 0x39FCE90 Offset: 0x39FCF91 VA: 0x39FCE90
	|-GenericEqualityComparer<ValueTuple<bool, bool>>.LastIndexOf
	|
	|-RVA: 0x39FD430 Offset: 0x39FD531 VA: 0x39FD430
	|-GenericEqualityComparer<ValueTuple<bool, Bounds>>.LastIndexOf
	|
	|-RVA: 0x39FD950 Offset: 0x39FDA51 VA: 0x39FD950
	|-GenericEqualityComparer<ValueTuple<bool, byte>>.LastIndexOf
	|
	|-RVA: 0x39FDEA0 Offset: 0x39FDFA1 VA: 0x39FDEA0
	|-GenericEqualityComparer<ValueTuple<bool, Color>>.LastIndexOf
	|
	|-RVA: 0x39FE3C0 Offset: 0x39FE4C1 VA: 0x39FE3C0
	|-GenericEqualityComparer<ValueTuple<bool, double>>.LastIndexOf
	|
	|-RVA: 0x39FE890 Offset: 0x39FE991 VA: 0x39FE890
	|-GenericEqualityComparer<ValueTuple<bool, int>>.LastIndexOf
	|
	|-RVA: 0x39FED70 Offset: 0x39FEE71 VA: 0x39FED70
	|-GenericEqualityComparer<ValueTuple<bool, long>>.LastIndexOf
	|
	|-RVA: 0x39FF260 Offset: 0x39FF361 VA: 0x39FF260
	|-GenericEqualityComparer<ValueTuple<bool, object>>.LastIndexOf
	|
	|-RVA: 0x39FF7C0 Offset: 0x39FF8C1 VA: 0x39FF7C0
	|-GenericEqualityComparer<ValueTuple<bool, Quaternion>>.LastIndexOf
	|
	|-RVA: 0x39FFD50 Offset: 0x39FFE51 VA: 0x39FFD50
	|-GenericEqualityComparer<ValueTuple<bool, Rect>>.LastIndexOf
	|
	|-RVA: 0x3A00250 Offset: 0x3A00351 VA: 0x3A00250
	|-GenericEqualityComparer<ValueTuple<bool, float>>.LastIndexOf
	|
	|-RVA: 0x3A00730 Offset: 0x3A00831 VA: 0x3A00730
	|-GenericEqualityComparer<ValueTuple<bool, UniTask>>.LastIndexOf
	|
	|-RVA: 0x3A00C00 Offset: 0x3A00D01 VA: 0x3A00C00
	|-GenericEqualityComparer<ValueTuple<bool, Unit>>.LastIndexOf
	|
	|-RVA: 0x3A01100 Offset: 0x3A01201 VA: 0x3A01100
	|-GenericEqualityComparer<ValueTuple<bool, Vector2>>.LastIndexOf
	|
	|-RVA: 0x3A01610 Offset: 0x3A01711 VA: 0x3A01610
	|-GenericEqualityComparer<ValueTuple<bool, Vector3>>.LastIndexOf
	|
	|-RVA: 0x3A01B70 Offset: 0x3A01C71 VA: 0x3A01B70
	|-GenericEqualityComparer<ValueTuple<bool, Vector4>>.LastIndexOf
	|
	|-RVA: 0x3A02090 Offset: 0x3A02191 VA: 0x3A02090
	|-GenericEqualityComparer<ValueTuple<int, object>>.LastIndexOf
	|
	|-RVA: 0x3A02550 Offset: 0x3A02651 VA: 0x3A02550
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3A02AA0 Offset: 0x3A02BA1 VA: 0x3A02AA0
	|-GenericEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.LastIndexOf
	|
	|-RVA: 0x3A02FB0 Offset: 0x3A030B1 VA: 0x3A02FB0
	|-GenericEqualityComparer<ValueTuple<object, int>>.LastIndexOf
	|
	|-RVA: 0x3A03490 Offset: 0x3A03591 VA: 0x3A03490
	|-GenericEqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x3A03970 Offset: 0x3A03A71 VA: 0x3A03970
	|-GenericEqualityComparer<ValueTuple<object, float>>.LastIndexOf
	|
	|-RVA: 0x3A03EC0 Offset: 0x3A03FC1 VA: 0x3A03EC0
	|-GenericEqualityComparer<ValueTuple<Vector3, float>>.LastIndexOf
	|
	|-RVA: 0x3A04490 Offset: 0x3A04591 VA: 0x3A04490
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3A049C0 Offset: 0x3A04AC1 VA: 0x3A049C0
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3A04F10 Offset: 0x3A05011 VA: 0x3A04F10
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3A05530 Offset: 0x3A05631 VA: 0x3A05530
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3A05AF0 Offset: 0x3A05BF1 VA: 0x3A05AF0
	|-GenericEqualityComparer<ValueTuple<object, int, int, int>>.LastIndexOf
	|
	|-RVA: 0x3A06070 Offset: 0x3A06171 VA: 0x3A06070
	|-GenericEqualityComparer<ValueTuple<object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3A066F0 Offset: 0x3A067F1 VA: 0x3A066F0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3A06D20 Offset: 0x3A06E21 VA: 0x3A06D20
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3A07400 Offset: 0x3A07501 VA: 0x3A07400
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3A07A50 Offset: 0x3A07B51 VA: 0x3A07A50
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3A08180 Offset: 0x3A08281 VA: 0x3A08180
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3A08840 Offset: 0x3A08941 VA: 0x3A08840
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3A08FE0 Offset: 0x3A090E1 VA: 0x3A08FE0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A09650 Offset: 0x3A09751 VA: 0x3A09650
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3A099B0 Offset: 0x3A09AB1 VA: 0x3A099B0
	|-GenericEqualityComparer<AsyncUnit>.LastIndexOf
	|
	|-RVA: 0x3A09C00 Offset: 0x3A09D01 VA: 0x3A09C00
	|-GenericEqualityComparer<BoneWeight>.LastIndexOf
	|
	|-RVA: 0x3A09E70 Offset: 0x3A09F71 VA: 0x3A09E70
	|-GenericEqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x3A0A0C0 Offset: 0x3A0A1C1 VA: 0x3A0A0C0
	|-GenericEqualityComparer<Bounds>.LastIndexOf
	|
	|-RVA: 0x3A0A320 Offset: 0x3A0A421 VA: 0x3A0A320
	|-GenericEqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x3A0A570 Offset: 0x3A0A671 VA: 0x3A0A570
	|-GenericEqualityComparer<CancellationTokenRegistration>.LastIndexOf
	|
	|-RVA: 0x3A0A7C0 Offset: 0x3A0A8C1 VA: 0x3A0A7C0
	|-GenericEqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x3A0AA40 Offset: 0x3A0AB41 VA: 0x3A0AA40
	|-GenericEqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x3A0ACF0 Offset: 0x3A0ADF1 VA: 0x3A0ACF0
	|-GenericEqualityComparer<ColorBlock>.LastIndexOf
	|
	|-RVA: 0x3A0AF60 Offset: 0x3A0B061 VA: 0x3A0AF60
	|-GenericEqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x3A0B1C0 Offset: 0x3A0B2C1 VA: 0x3A0B1C0
	|-GenericEqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x3A0B420 Offset: 0x3A0B521 VA: 0x3A0B420
	|-GenericEqualityComparer<Decimal>.LastIndexOf
	|
	|-RVA: 0x3A0B670 Offset: 0x3A0B771 VA: 0x3A0B670
	|-GenericEqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x3A0B8D0 Offset: 0x3A0B9D1 VA: 0x3A0B8D0
	|-GenericEqualityComparer<GlyphRect>.LastIndexOf
	|
	|-RVA: 0x3A0BB30 Offset: 0x3A0BC31 VA: 0x3A0BB30
	|-GenericEqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x3A0BD70 Offset: 0x3A0BE71 VA: 0x3A0BD70
	|-GenericEqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x3A0BFB0 Offset: 0x3A0C0B1 VA: 0x3A0BFB0
	|-GenericEqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x3A0C1F0 Offset: 0x3A0C2F1 VA: 0x3A0C1F0
	|-GenericEqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x3A0C460 Offset: 0x3A0C561 VA: 0x3A0C460
	|-GenericEqualityComparer<Matrix4x4>.LastIndexOf
	|
	|-RVA: 0x3A0C770 Offset: 0x3A0C871 VA: 0x3A0C770
	|-GenericEqualityComparer<Navigation>.LastIndexOf
	|
	|-RVA: 0x3A0CB30 Offset: 0x3A0CC31 VA: 0x3A0CB30
	|-GenericEqualityComparer<object>.LastIndexOf
	|
	|-RVA: 0x3A0CEA0 Offset: 0x3A0CFA1 VA: 0x3A0CEA0
	|-GenericEqualityComparer<Playable>.LastIndexOf
	|
	|-RVA: 0x3A0D120 Offset: 0x3A0D221 VA: 0x3A0D120
	|-GenericEqualityComparer<Quaternion>.LastIndexOf
	|
	|-RVA: 0x3A0D3C0 Offset: 0x3A0D4C1 VA: 0x3A0D3C0
	|-GenericEqualityComparer<Rect>.LastIndexOf
	|
	|-RVA: 0x3A0D630 Offset: 0x3A0D731 VA: 0x3A0D630
	|-GenericEqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x3A0D870 Offset: 0x3A0D971 VA: 0x3A0D870
	|-GenericEqualityComparer<ShaderTagId>.LastIndexOf
	|
	|-RVA: 0x3A0DAC0 Offset: 0x3A0DBC1 VA: 0x3A0DAC0
	|-GenericEqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x3A0DD70 Offset: 0x3A0DE71 VA: 0x3A0DD70
	|-GenericEqualityComparer<SphericalHarmonicsL2>.LastIndexOf
	|
	|-RVA: 0x3A0E080 Offset: 0x3A0E181 VA: 0x3A0E080
	|-GenericEqualityComparer<SpriteState>.LastIndexOf
	|
	|-RVA: 0x3A0E2D0 Offset: 0x3A0E3D1 VA: 0x3A0E2D0
	|-GenericEqualityComparer<TimeSpan>.LastIndexOf
	|
	|-RVA: 0x3A0E510 Offset: 0x3A0E611 VA: 0x3A0E510
	|-GenericEqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x3A0E750 Offset: 0x3A0E851 VA: 0x3A0E750
	|-GenericEqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x3A0E990 Offset: 0x3A0EA91 VA: 0x3A0E990
	|-GenericEqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x3A0EBD0 Offset: 0x3A0ECD1 VA: 0x3A0EBD0
	|-GenericEqualityComparer<UniTask>.LastIndexOf
	|
	|-RVA: 0x3A0EE20 Offset: 0x3A0EF21 VA: 0x3A0EE20
	|-GenericEqualityComparer<Unit>.LastIndexOf
	|
	|-RVA: 0x3A0F040 Offset: 0x3A0F141 VA: 0x3A0F040
	|-GenericEqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x3A0F2B0 Offset: 0x3A0F3B1 VA: 0x3A0F2B0
	|-GenericEqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x3A0F520 Offset: 0x3A0F621 VA: 0x3A0F520
	|-GenericEqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x3A0F790 Offset: 0x3A0F891 VA: 0x3A0F790
	|-GenericEqualityComparer<VertexAttributeDescriptor>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EA2970 Offset: 0x1EA2A71 VA: 0x1EA2970
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.Equals
	|
	|-RVA: 0x1EA2E60 Offset: 0x1EA2F61 VA: 0x1EA2E60
	|-GenericEqualityComparer<TimeInterval<object>>.Equals
	|
	|-RVA: 0x1EA33E0 Offset: 0x1EA34E1 VA: 0x1EA33E0
	|-GenericEqualityComparer<Timestamped<object>>.Equals
	|
	|-RVA: 0x1EA38C0 Offset: 0x1EA39C1 VA: 0x1EA38C0
	|-GenericEqualityComparer<UniTask<object>>.Equals
	|
	|-RVA: 0x1EA3DB0 Offset: 0x1EA3EB1 VA: 0x1EA3DB0
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1EA4340 Offset: 0x1EA4441 VA: 0x1EA4340
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x1EA48D0 Offset: 0x1EA49D1 VA: 0x1EA48D0
	|-GenericEqualityComparer<ValueTuple<bool, UniTask<object>>>.Equals
	|
	|-RVA: 0x1EA4E60 Offset: 0x1EA4F61 VA: 0x1EA4E60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Equals
	|
	|-RVA: 0x1EA5460 Offset: 0x1EA5561 VA: 0x1EA5460
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Equals
	|
	|-RVA: 0x1EA5A60 Offset: 0x1EA5B61 VA: 0x1EA5A60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Equals
	|
	|-RVA: 0x1EA5F50 Offset: 0x1EA6051 VA: 0x1EA5F50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Equals
	|
	|-RVA: 0x1EA6440 Offset: 0x1EA6541 VA: 0x1EA6440
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Equals
	|
	|-RVA: 0x1EA6AB0 Offset: 0x1EA6BB1 VA: 0x1EA6AB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Equals
	|
	|-RVA: 0x1EA6FA0 Offset: 0x1EA70A1 VA: 0x1EA6FA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Equals
	|
	|-RVA: 0x1EA75E0 Offset: 0x1EA76E1 VA: 0x1EA75E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Equals
	|
	|-RVA: 0x1EA7BE0 Offset: 0x1EA7CE1 VA: 0x1EA7BE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Equals
	|
	|-RVA: 0x1EA8170 Offset: 0x1EA8271 VA: 0x1EA8170
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Equals
	|
	|-RVA: 0x1EA8770 Offset: 0x1EA8871 VA: 0x1EA8770
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Equals
	|
	|-RVA: 0x1EA8D70 Offset: 0x1EA8E71 VA: 0x1EA8D70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x1EA93B0 Offset: 0x1EA94B1 VA: 0x1EA93B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Equals
	|
	|-RVA: 0x1EA99F0 Offset: 0x1EA9AF1 VA: 0x1EA99F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Equals
	|
	|-RVA: 0x1EA9F80 Offset: 0x1EAA081 VA: 0x1EA9F80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Equals
	|
	|-RVA: 0x1EAA580 Offset: 0x1EAA681 VA: 0x1EAA580
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Equals
	|
	|-RVA: 0x1EAAA70 Offset: 0x1EAAB71 VA: 0x1EAAA70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Equals
	|
	|-RVA: 0x1EAB070 Offset: 0x1EAB171 VA: 0x1EAB070
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Equals
	|
	|-RVA: 0x1EAB600 Offset: 0x1EAB701 VA: 0x1EAB600
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Equals
	|
	|-RVA: 0x1EABC40 Offset: 0x1EABD41 VA: 0x1EABC40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Equals
	|
	|-RVA: 0x1EAC240 Offset: 0x1EAC341 VA: 0x1EAC240
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Equals
	|
	|-RVA: 0x1EAC840 Offset: 0x1EAC941 VA: 0x1EAC840
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Equals
	|
	|-RVA: 0x1EACEB0 Offset: 0x1EACFB1 VA: 0x1EACEB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1EAD520 Offset: 0x1EAD621 VA: 0x1EAD520
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1EADC00 Offset: 0x1EADD01 VA: 0x1EADC00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1EAE2E0 Offset: 0x1EAE3E1 VA: 0x1EAE2E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x1EAEA30 Offset: 0x1EAEB31 VA: 0x1EAEA30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x3A13EA0 Offset: 0x3A13FA1 VA: 0x3A13EA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Equals
	|
	|-RVA: 0x3A14390 Offset: 0x3A14491 VA: 0x3A14390
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Equals
	|
	|-RVA: 0x3A14990 Offset: 0x3A14A91 VA: 0x3A14990
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Equals
	|
	|-RVA: 0x3A14E80 Offset: 0x3A14F81 VA: 0x3A14E80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Equals
	|
	|-RVA: 0x3A15410 Offset: 0x3A15511 VA: 0x3A15410
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Equals
	|
	|-RVA: 0x3A15A10 Offset: 0x3A15B11 VA: 0x3A15A10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Equals
	|
	|-RVA: 0x3A15FA0 Offset: 0x3A160A1 VA: 0x3A15FA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Equals
	|
	|-RVA: 0x3A165A0 Offset: 0x3A166A1 VA: 0x3A165A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Equals
	|
	|-RVA: 0x3A16BA0 Offset: 0x3A16CA1 VA: 0x3A16BA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A17130 Offset: 0x3A17231 VA: 0x3A17130
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Equals
	|
	|-RVA: 0x3A176C0 Offset: 0x3A177C1 VA: 0x3A176C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Equals
	|
	|-RVA: 0x3A17C50 Offset: 0x3A17D51 VA: 0x3A17C50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Equals
	|
	|-RVA: 0x3A18250 Offset: 0x3A18351 VA: 0x3A18250
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Equals
	|
	|-RVA: 0x3A18740 Offset: 0x3A18841 VA: 0x3A18740
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Equals
	|
	|-RVA: 0x3A18CD0 Offset: 0x3A18DD1 VA: 0x3A18CD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Equals
	|
	|-RVA: 0x3A192D0 Offset: 0x3A193D1 VA: 0x3A192D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Equals
	|
	|-RVA: 0x3A19860 Offset: 0x3A19961 VA: 0x3A19860
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Equals
	|
	|-RVA: 0x3A19E60 Offset: 0x3A19F61 VA: 0x3A19E60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Equals
	|
	|-RVA: 0x3A1A460 Offset: 0x3A1A561 VA: 0x3A1A460
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Equals
	|
	|-RVA: 0x3A1AAD0 Offset: 0x3A1ABD1 VA: 0x3A1AAD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A1B0D0 Offset: 0x3A1B1D1 VA: 0x3A1B0D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A1B7B0 Offset: 0x3A1B8B1 VA: 0x3A1B7B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A1BE20 Offset: 0x3A1BF21 VA: 0x3A1BE20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A1C570 Offset: 0x3A1C671 VA: 0x3A1C570
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A1CBE0 Offset: 0x3A1CCE1 VA: 0x3A1CBE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A1D3A0 Offset: 0x3A1D4A1 VA: 0x3A1D3A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A1DA80 Offset: 0x3A1DB81 VA: 0x3A1DA80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A1E2B0 Offset: 0x3A1E3B1 VA: 0x3A1E2B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A1E990 Offset: 0x3A1EA91 VA: 0x3A1E990
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x3A1EE50 Offset: 0x3A1EF51 VA: 0x3A1EE50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Equals
	|
	|-RVA: 0x3A1F310 Offset: 0x3A1F411 VA: 0x3A1F310
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Equals
	|
	|-RVA: 0x3A1F950 Offset: 0x3A1FA51 VA: 0x3A1F950
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Equals
	|
	|-RVA: 0x3A1FE10 Offset: 0x3A1FF11 VA: 0x3A1FE10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Equals
	|
	|-RVA: 0x3A20410 Offset: 0x3A20511 VA: 0x3A20410
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Equals
	|
	|-RVA: 0x3A209A0 Offset: 0x3A20AA1 VA: 0x3A209A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Equals
	|
	|-RVA: 0x3A20E90 Offset: 0x3A20F91 VA: 0x3A20E90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Equals
	|
	|-RVA: 0x3A21420 Offset: 0x3A21521 VA: 0x3A21420
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Equals
	|
	|-RVA: 0x3A219B0 Offset: 0x3A21AB1 VA: 0x3A219B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A21FB0 Offset: 0x3A220B1 VA: 0x3A21FB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Equals
	|
	|-RVA: 0x3A225B0 Offset: 0x3A226B1 VA: 0x3A225B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Equals
	|
	|-RVA: 0x3A22AA0 Offset: 0x3A22BA1 VA: 0x3A22AA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Equals
	|
	|-RVA: 0x3A23030 Offset: 0x3A23131 VA: 0x3A23030
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Equals
	|
	|-RVA: 0x3A234F0 Offset: 0x3A235F1 VA: 0x3A234F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Equals
	|
	|-RVA: 0x3A23A80 Offset: 0x3A23B81 VA: 0x3A23A80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Equals
	|
	|-RVA: 0x3A24010 Offset: 0x3A24111 VA: 0x3A24010
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Equals
	|
	|-RVA: 0x3A24610 Offset: 0x3A24711 VA: 0x3A24610
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Equals
	|
	|-RVA: 0x3A24BA0 Offset: 0x3A24CA1 VA: 0x3A24BA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Equals
	|
	|-RVA: 0x3A25130 Offset: 0x3A25231 VA: 0x3A25130
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Equals
	|
	|-RVA: 0x3A257A0 Offset: 0x3A258A1 VA: 0x3A257A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A25DA0 Offset: 0x3A25EA1 VA: 0x3A25DA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Equals
	|
	|-RVA: 0x3A26480 Offset: 0x3A26581 VA: 0x3A26480
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A26A80 Offset: 0x3A26B81 VA: 0x3A26A80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A271D0 Offset: 0x3A272D1 VA: 0x3A271D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A27840 Offset: 0x3A27941 VA: 0x3A27840
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A28000 Offset: 0x3A28101 VA: 0x3A28000
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A28670 Offset: 0x3A28771 VA: 0x3A28670
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A28EA0 Offset: 0x3A28FA1 VA: 0x3A28EA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x3A29580 Offset: 0x3A29681 VA: 0x3A29580
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x3A29B50 Offset: 0x3A29C51 VA: 0x3A29B50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A2A120 Offset: 0x3A2A221 VA: 0x3A2A120
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3A2A610 Offset: 0x3A2A711 VA: 0x3A2A610
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Equals
	|
	|-RVA: 0x3A2AB00 Offset: 0x3A2AC01 VA: 0x3A2AB00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.Equals
	|
	|-RVA: 0x3A2B090 Offset: 0x3A2B191 VA: 0x3A2B090
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.Equals
	|
	|-RVA: 0x3A2B580 Offset: 0x3A2B681 VA: 0x3A2B580
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.Equals
	|
	|-RVA: 0x3A2BB10 Offset: 0x3A2BC11 VA: 0x3A2BB10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.Equals
	|
	|-RVA: 0x3A2C0A0 Offset: 0x3A2C1A1 VA: 0x3A2C0A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.Equals
	|
	|-RVA: 0x3A2C5D0 Offset: 0x3A2C6D1 VA: 0x3A2C5D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.Equals
	|
	|-RVA: 0x3A2CB60 Offset: 0x3A2CC61 VA: 0x3A2CB60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.Equals
	|
	|-RVA: 0x3A2D0F0 Offset: 0x3A2D1F1 VA: 0x3A2D0F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A2D680 Offset: 0x3A2D781 VA: 0x3A2D680
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Equals
	|
	|-RVA: 0x3A2DC10 Offset: 0x3A2DD11 VA: 0x3A2DC10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.Equals
	|
	|-RVA: 0x3A2E140 Offset: 0x3A2E241 VA: 0x3A2E140
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.Equals
	|
	|-RVA: 0x3A2E6D0 Offset: 0x3A2E7D1 VA: 0x3A2E6D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.Equals
	|
	|-RVA: 0x3A2EBC0 Offset: 0x3A2ECC1 VA: 0x3A2EBC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.Equals
	|
	|-RVA: 0x3A2F0B0 Offset: 0x3A2F1B1 VA: 0x3A2F0B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.Equals
	|
	|-RVA: 0x3A2F640 Offset: 0x3A2F741 VA: 0x3A2F640
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.Equals
	|
	|-RVA: 0x3A2FBD0 Offset: 0x3A2FCD1 VA: 0x3A2FBD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.Equals
	|
	|-RVA: 0x3A30160 Offset: 0x3A30261 VA: 0x3A30160
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.Equals
	|
	|-RVA: 0x3A306F0 Offset: 0x3A307F1 VA: 0x3A306F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.Equals
	|
	|-RVA: 0x3A30CF0 Offset: 0x3A30DF1 VA: 0x3A30CF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A31280 Offset: 0x3A31381 VA: 0x3A31280
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.Equals
	|
	|-RVA: 0x3A318F0 Offset: 0x3A319F1 VA: 0x3A318F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A31EF0 Offset: 0x3A31FF1 VA: 0x3A31EF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.Equals
	|
	|-RVA: 0x3A325D0 Offset: 0x3A326D1 VA: 0x3A325D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A32BD0 Offset: 0x3A32CD1 VA: 0x3A32BD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3A33320 Offset: 0x3A33421 VA: 0x3A33320
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A33990 Offset: 0x3A33A91 VA: 0x3A33990
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x3A34150 Offset: 0x3A34251 VA: 0x3A34150
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x39FB880 Offset: 0x39FB981 VA: 0x39FB880
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x39FC0B0 Offset: 0x39FC1B1 VA: 0x39FC0B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x39FC680 Offset: 0x39FC781 VA: 0x39FC680
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x39FCB40 Offset: 0x39FCC41 VA: 0x39FCB40
	|-GenericEqualityComparer<ValueTuple<bool, AsyncUnit>>.Equals
	|
	|-RVA: 0x39FD000 Offset: 0x39FD101 VA: 0x39FD000
	|-GenericEqualityComparer<ValueTuple<bool, bool>>.Equals
	|
	|-RVA: 0x39FD600 Offset: 0x39FD701 VA: 0x39FD600
	|-GenericEqualityComparer<ValueTuple<bool, Bounds>>.Equals
	|
	|-RVA: 0x39FDAC0 Offset: 0x39FDBC1 VA: 0x39FDAC0
	|-GenericEqualityComparer<ValueTuple<bool, byte>>.Equals
	|
	|-RVA: 0x39FE050 Offset: 0x39FE151 VA: 0x39FE050
	|-GenericEqualityComparer<ValueTuple<bool, Color>>.Equals
	|
	|-RVA: 0x39FE540 Offset: 0x39FE641 VA: 0x39FE540
	|-GenericEqualityComparer<ValueTuple<bool, double>>.Equals
	|
	|-RVA: 0x39FEA00 Offset: 0x39FEB01 VA: 0x39FEA00
	|-GenericEqualityComparer<ValueTuple<bool, int>>.Equals
	|
	|-RVA: 0x39FEEF0 Offset: 0x39FEFF1 VA: 0x39FEEF0
	|-GenericEqualityComparer<ValueTuple<bool, long>>.Equals
	|
	|-RVA: 0x39FF3E0 Offset: 0x39FF4E1 VA: 0x39FF3E0
	|-GenericEqualityComparer<ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x39FF970 Offset: 0x39FFA71 VA: 0x39FF970
	|-GenericEqualityComparer<ValueTuple<bool, Quaternion>>.Equals
	|
	|-RVA: 0x39FFF00 Offset: 0x3A00001 VA: 0x39FFF00
	|-GenericEqualityComparer<ValueTuple<bool, Rect>>.Equals
	|
	|-RVA: 0x3A003C0 Offset: 0x3A004C1 VA: 0x3A003C0
	|-GenericEqualityComparer<ValueTuple<bool, float>>.Equals
	|
	|-RVA: 0x3A008B0 Offset: 0x3A009B1 VA: 0x3A008B0
	|-GenericEqualityComparer<ValueTuple<bool, UniTask>>.Equals
	|
	|-RVA: 0x3A00D70 Offset: 0x3A00E71 VA: 0x3A00D70
	|-GenericEqualityComparer<ValueTuple<bool, Unit>>.Equals
	|
	|-RVA: 0x3A012A0 Offset: 0x3A013A1 VA: 0x3A012A0
	|-GenericEqualityComparer<ValueTuple<bool, Vector2>>.Equals
	|
	|-RVA: 0x3A01790 Offset: 0x3A01891 VA: 0x3A01790
	|-GenericEqualityComparer<ValueTuple<bool, Vector3>>.Equals
	|
	|-RVA: 0x3A01D20 Offset: 0x3A01E21 VA: 0x3A01D20
	|-GenericEqualityComparer<ValueTuple<bool, Vector4>>.Equals
	|
	|-RVA: 0x3A02200 Offset: 0x3A02301 VA: 0x3A02200
	|-GenericEqualityComparer<ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x3A026C0 Offset: 0x3A027C1 VA: 0x3A026C0
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.Equals
	|
	|-RVA: 0x3A02C40 Offset: 0x3A02D41 VA: 0x3A02C40
	|-GenericEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.Equals
	|
	|-RVA: 0x3A03120 Offset: 0x3A03221 VA: 0x3A03120
	|-GenericEqualityComparer<ValueTuple<object, int>>.Equals
	|
	|-RVA: 0x3A03600 Offset: 0x3A03701 VA: 0x3A03600
	|-GenericEqualityComparer<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x3A03AE0 Offset: 0x3A03BE1 VA: 0x3A03AE0
	|-GenericEqualityComparer<ValueTuple<object, float>>.Equals
	|
	|-RVA: 0x3A04060 Offset: 0x3A04161 VA: 0x3A04060
	|-GenericEqualityComparer<ValueTuple<Vector3, float>>.Equals
	|
	|-RVA: 0x3A04650 Offset: 0x3A04751 VA: 0x3A04650
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A04B30 Offset: 0x3A04C31 VA: 0x3A04B30
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum, int>>.Equals
	|
	|-RVA: 0x3A050B0 Offset: 0x3A051B1 VA: 0x3A050B0
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.Equals
	|
	|-RVA: 0x3A05710 Offset: 0x3A05811 VA: 0x3A05710
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A05C90 Offset: 0x3A05D91 VA: 0x3A05C90
	|-GenericEqualityComparer<ValueTuple<object, int, int, int>>.Equals
	|
	|-RVA: 0x3A06220 Offset: 0x3A06321 VA: 0x3A06220
	|-GenericEqualityComparer<ValueTuple<object, object, object, object>>.Equals
	|
	|-RVA: 0x3A068F0 Offset: 0x3A069F1 VA: 0x3A068F0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A06EE0 Offset: 0x3A06FE1 VA: 0x3A06EE0
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3A07620 Offset: 0x3A07721 VA: 0x3A07620
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A07C10 Offset: 0x3A07D11 VA: 0x3A07C10
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3A083C0 Offset: 0x3A084C1 VA: 0x3A083C0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x3A08A20 Offset: 0x3A08B21 VA: 0x3A08A20
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x3A09240 Offset: 0x3A09341 VA: 0x3A09240
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A09800 Offset: 0x3A09901 VA: 0x3A09800
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x3A09A50 Offset: 0x3A09B51 VA: 0x3A09A50
	|-GenericEqualityComparer<AsyncUnit>.Equals
	|
	|-RVA: 0x3A09CB0 Offset: 0x3A09DB1 VA: 0x3A09CB0
	|-GenericEqualityComparer<BoneWeight>.Equals
	|
	|-RVA: 0x3A09F10 Offset: 0x3A0A011 VA: 0x3A09F10
	|-GenericEqualityComparer<bool>.Equals
	|
	|-RVA: 0x3A0A170 Offset: 0x3A0A271 VA: 0x3A0A170
	|-GenericEqualityComparer<Bounds>.Equals
	|
	|-RVA: 0x3A0A3C0 Offset: 0x3A0A4C1 VA: 0x3A0A3C0
	|-GenericEqualityComparer<byte>.Equals
	|
	|-RVA: 0x3A0A620 Offset: 0x3A0A721 VA: 0x3A0A620
	|-GenericEqualityComparer<CancellationTokenRegistration>.Equals
	|
	|-RVA: 0x3A0A860 Offset: 0x3A0A961 VA: 0x3A0A860
	|-GenericEqualityComparer<char>.Equals
	|
	|-RVA: 0x3A0AB00 Offset: 0x3A0AC01 VA: 0x3A0AB00
	|-GenericEqualityComparer<Color>.Equals
	|
	|-RVA: 0x3A0ADC0 Offset: 0x3A0AEC1 VA: 0x3A0ADC0
	|-GenericEqualityComparer<ColorBlock>.Equals
	|
	|-RVA: 0x3A0B000 Offset: 0x3A0B101 VA: 0x3A0B000
	|-GenericEqualityComparer<DateTime>.Equals
	|
	|-RVA: 0x3A0B260 Offset: 0x3A0B361 VA: 0x3A0B260
	|-GenericEqualityComparer<DateTimeOffset>.Equals
	|
	|-RVA: 0x3A0B4C0 Offset: 0x3A0B5C1 VA: 0x3A0B4C0
	|-GenericEqualityComparer<Decimal>.Equals
	|
	|-RVA: 0x3A0B710 Offset: 0x3A0B811 VA: 0x3A0B710
	|-GenericEqualityComparer<double>.Equals
	|
	|-RVA: 0x3A0B970 Offset: 0x3A0BA71 VA: 0x3A0B970
	|-GenericEqualityComparer<GlyphRect>.Equals
	|
	|-RVA: 0x3A0BBD0 Offset: 0x3A0BCD1 VA: 0x3A0BBD0
	|-GenericEqualityComparer<Guid>.Equals
	|
	|-RVA: 0x3A0BE10 Offset: 0x3A0BF11 VA: 0x3A0BE10
	|-GenericEqualityComparer<short>.Equals
	|
	|-RVA: 0x3A0C050 Offset: 0x3A0C151 VA: 0x3A0C050
	|-GenericEqualityComparer<int>.Equals
	|
	|-RVA: 0x3A0C290 Offset: 0x3A0C391 VA: 0x3A0C290
	|-GenericEqualityComparer<long>.Equals
	|
	|-RVA: 0x3A0C520 Offset: 0x3A0C621 VA: 0x3A0C520
	|-GenericEqualityComparer<Matrix4x4>.Equals
	|
	|-RVA: 0x3A0C830 Offset: 0x3A0C931 VA: 0x3A0C830
	|-GenericEqualityComparer<Navigation>.Equals
	|
	|-RVA: 0x3A0CC90 Offset: 0x3A0CD91 VA: 0x3A0CC90
	|-GenericEqualityComparer<object>.Equals
	|
	|-RVA: 0x3A0CF40 Offset: 0x3A0D041 VA: 0x3A0CF40
	|-GenericEqualityComparer<Playable>.Equals
	|
	|-RVA: 0x3A0D1E0 Offset: 0x3A0D2E1 VA: 0x3A0D1E0
	|-GenericEqualityComparer<Quaternion>.Equals
	|
	|-RVA: 0x3A0D480 Offset: 0x3A0D581 VA: 0x3A0D480
	|-GenericEqualityComparer<Rect>.Equals
	|
	|-RVA: 0x3A0D6D0 Offset: 0x3A0D7D1 VA: 0x3A0D6D0
	|-GenericEqualityComparer<sbyte>.Equals
	|
	|-RVA: 0x3A0D910 Offset: 0x3A0DA11 VA: 0x3A0D910
	|-GenericEqualityComparer<ShaderTagId>.Equals
	|
	|-RVA: 0x3A0DB60 Offset: 0x3A0DC61 VA: 0x3A0DB60
	|-GenericEqualityComparer<float>.Equals
	|
	|-RVA: 0x3A0DE50 Offset: 0x3A0DF51 VA: 0x3A0DE50
	|-GenericEqualityComparer<SphericalHarmonicsL2>.Equals
	|
	|-RVA: 0x3A0E130 Offset: 0x3A0E231 VA: 0x3A0E130
	|-GenericEqualityComparer<SpriteState>.Equals
	|
	|-RVA: 0x3A0E370 Offset: 0x3A0E471 VA: 0x3A0E370
	|-GenericEqualityComparer<TimeSpan>.Equals
	|
	|-RVA: 0x3A0E5B0 Offset: 0x3A0E6B1 VA: 0x3A0E5B0
	|-GenericEqualityComparer<ushort>.Equals
	|
	|-RVA: 0x3A0E7F0 Offset: 0x3A0E8F1 VA: 0x3A0E7F0
	|-GenericEqualityComparer<uint>.Equals
	|
	|-RVA: 0x3A0EA30 Offset: 0x3A0EB31 VA: 0x3A0EA30
	|-GenericEqualityComparer<ulong>.Equals
	|
	|-RVA: 0x3A0EC70 Offset: 0x3A0ED71 VA: 0x3A0EC70
	|-GenericEqualityComparer<UniTask>.Equals
	|
	|-RVA: 0x3A0EEC0 Offset: 0x3A0EFC1 VA: 0x3A0EEC0
	|-GenericEqualityComparer<Unit>.Equals
	|
	|-RVA: 0x3A0F0D0 Offset: 0x3A0F1D1 VA: 0x3A0F0D0
	|-GenericEqualityComparer<Vector2>.Equals
	|
	|-RVA: 0x3A0F370 Offset: 0x3A0F471 VA: 0x3A0F370
	|-GenericEqualityComparer<Vector3>.Equals
	|
	|-RVA: 0x3A0F5D0 Offset: 0x3A0F6D1 VA: 0x3A0F5D0
	|-GenericEqualityComparer<Vector4>.Equals
	|
	|-RVA: 0x3A0F830 Offset: 0x3A0F931 VA: 0x3A0F830
	|-GenericEqualityComparer<VertexAttributeDescriptor>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EA29C0 Offset: 0x1EA2AC1 VA: 0x1EA29C0
	|-GenericEqualityComparer<AsyncOperationHandle<object>>.GetHashCode
	|
	|-RVA: 0x1EA2EB0 Offset: 0x1EA2FB1 VA: 0x1EA2EB0
	|-GenericEqualityComparer<TimeInterval<object>>.GetHashCode
	|
	|-RVA: 0x1EA3430 Offset: 0x1EA3531 VA: 0x1EA3430
	|-GenericEqualityComparer<Timestamped<object>>.GetHashCode
	|
	|-RVA: 0x1EA3910 Offset: 0x1EA3A11 VA: 0x1EA3910
	|-GenericEqualityComparer<UniTask<object>>.GetHashCode
	|
	|-RVA: 0x1EA3E00 Offset: 0x1EA3F01 VA: 0x1EA3E00
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1EA4390 Offset: 0x1EA4491 VA: 0x1EA4390
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x1EA4920 Offset: 0x1EA4A21 VA: 0x1EA4920
	|-GenericEqualityComparer<ValueTuple<bool, UniTask<object>>>.GetHashCode
	|
	|-RVA: 0x1EA4EB0 Offset: 0x1EA4FB1 VA: 0x1EA4EB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetHashCode
	|
	|-RVA: 0x1EA54B0 Offset: 0x1EA55B1 VA: 0x1EA54B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetHashCode
	|
	|-RVA: 0x1EA5AB0 Offset: 0x1EA5BB1 VA: 0x1EA5AB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA5FA0 Offset: 0x1EA60A1 VA: 0x1EA5FA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA6490 Offset: 0x1EA6591 VA: 0x1EA6490
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA6B00 Offset: 0x1EA6C01 VA: 0x1EA6B00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA6FF0 Offset: 0x1EA70F1 VA: 0x1EA6FF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA7630 Offset: 0x1EA7731 VA: 0x1EA7630
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA7C30 Offset: 0x1EA7D31 VA: 0x1EA7C30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA81C0 Offset: 0x1EA82C1 VA: 0x1EA81C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA87C0 Offset: 0x1EA88C1 VA: 0x1EA87C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA8DC0 Offset: 0x1EA8EC1 VA: 0x1EA8DC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA9400 Offset: 0x1EA9501 VA: 0x1EA9400
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA9A40 Offset: 0x1EA9B41 VA: 0x1EA9A40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetHashCode
	|
	|-RVA: 0x1EA9FD0 Offset: 0x1EAA0D1 VA: 0x1EA9FD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAA5D0 Offset: 0x1EAA6D1 VA: 0x1EAA5D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAAAC0 Offset: 0x1EAABC1 VA: 0x1EAAAC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAB0C0 Offset: 0x1EAB1C1 VA: 0x1EAB0C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAB650 Offset: 0x1EAB751 VA: 0x1EAB650
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetHashCode
	|
	|-RVA: 0x1EABC90 Offset: 0x1EABD91 VA: 0x1EABC90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAC290 Offset: 0x1EAC391 VA: 0x1EAC290
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAC890 Offset: 0x1EAC991 VA: 0x1EAC890
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EACF00 Offset: 0x1EAD001 VA: 0x1EACF00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAD570 Offset: 0x1EAD671 VA: 0x1EAD570
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EADC50 Offset: 0x1EADD51 VA: 0x1EADC50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAE330 Offset: 0x1EAE431 VA: 0x1EAE330
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x1EAEA80 Offset: 0x1EAEB81 VA: 0x1EAEA80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A13EF0 Offset: 0x3A13FF1 VA: 0x3A13EF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetHashCode
	|
	|-RVA: 0x3A143E0 Offset: 0x3A144E1 VA: 0x3A143E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetHashCode
	|
	|-RVA: 0x3A149E0 Offset: 0x3A14AE1 VA: 0x3A149E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetHashCode
	|
	|-RVA: 0x3A14ED0 Offset: 0x3A14FD1 VA: 0x3A14ED0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetHashCode
	|
	|-RVA: 0x3A15460 Offset: 0x3A15561 VA: 0x3A15460
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetHashCode
	|
	|-RVA: 0x3A15A60 Offset: 0x3A15B61 VA: 0x3A15A60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetHashCode
	|
	|-RVA: 0x3A15FF0 Offset: 0x3A160F1 VA: 0x3A15FF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetHashCode
	|
	|-RVA: 0x3A165F0 Offset: 0x3A166F1 VA: 0x3A165F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetHashCode
	|
	|-RVA: 0x3A16BF0 Offset: 0x3A16CF1 VA: 0x3A16BF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A17180 Offset: 0x3A17281 VA: 0x3A17180
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetHashCode
	|
	|-RVA: 0x3A17710 Offset: 0x3A17811 VA: 0x3A17710
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetHashCode
	|
	|-RVA: 0x3A17CA0 Offset: 0x3A17DA1 VA: 0x3A17CA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetHashCode
	|
	|-RVA: 0x3A182A0 Offset: 0x3A183A1 VA: 0x3A182A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetHashCode
	|
	|-RVA: 0x3A18790 Offset: 0x3A18891 VA: 0x3A18790
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetHashCode
	|
	|-RVA: 0x3A18D20 Offset: 0x3A18E21 VA: 0x3A18D20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetHashCode
	|
	|-RVA: 0x3A19320 Offset: 0x3A19421 VA: 0x3A19320
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetHashCode
	|
	|-RVA: 0x3A198B0 Offset: 0x3A199B1 VA: 0x3A198B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetHashCode
	|
	|-RVA: 0x3A19EB0 Offset: 0x3A19FB1 VA: 0x3A19EB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1A4B0 Offset: 0x3A1A5B1 VA: 0x3A1A4B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1AB20 Offset: 0x3A1AC21 VA: 0x3A1AB20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A1B120 Offset: 0x3A1B221 VA: 0x3A1B120
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1B800 Offset: 0x3A1B901 VA: 0x3A1B800
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A1BE70 Offset: 0x3A1BF71 VA: 0x3A1BE70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1C5C0 Offset: 0x3A1C6C1 VA: 0x3A1C5C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A1CC30 Offset: 0x3A1CD31 VA: 0x3A1CC30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1D3F0 Offset: 0x3A1D4F1 VA: 0x3A1D3F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A1DAD0 Offset: 0x3A1DBD1 VA: 0x3A1DAD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1E300 Offset: 0x3A1E401 VA: 0x3A1E300
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A1E9E0 Offset: 0x3A1EAE1 VA: 0x3A1E9E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A1EEA0 Offset: 0x3A1EFA1 VA: 0x3A1EEA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetHashCode
	|
	|-RVA: 0x3A1F360 Offset: 0x3A1F461 VA: 0x3A1F360
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetHashCode
	|
	|-RVA: 0x3A1F9A0 Offset: 0x3A1FAA1 VA: 0x3A1F9A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetHashCode
	|
	|-RVA: 0x3A1FE60 Offset: 0x3A1FF61 VA: 0x3A1FE60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetHashCode
	|
	|-RVA: 0x3A20460 Offset: 0x3A20561 VA: 0x3A20460
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetHashCode
	|
	|-RVA: 0x3A209F0 Offset: 0x3A20AF1 VA: 0x3A209F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetHashCode
	|
	|-RVA: 0x3A20EE0 Offset: 0x3A20FE1 VA: 0x3A20EE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetHashCode
	|
	|-RVA: 0x3A21470 Offset: 0x3A21571 VA: 0x3A21470
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetHashCode
	|
	|-RVA: 0x3A21A00 Offset: 0x3A21B01 VA: 0x3A21A00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A22000 Offset: 0x3A22101 VA: 0x3A22000
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetHashCode
	|
	|-RVA: 0x3A22600 Offset: 0x3A22701 VA: 0x3A22600
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetHashCode
	|
	|-RVA: 0x3A22AF0 Offset: 0x3A22BF1 VA: 0x3A22AF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetHashCode
	|
	|-RVA: 0x3A23080 Offset: 0x3A23181 VA: 0x3A23080
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetHashCode
	|
	|-RVA: 0x3A23540 Offset: 0x3A23641 VA: 0x3A23540
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetHashCode
	|
	|-RVA: 0x3A23AD0 Offset: 0x3A23BD1 VA: 0x3A23AD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetHashCode
	|
	|-RVA: 0x3A24060 Offset: 0x3A24161 VA: 0x3A24060
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetHashCode
	|
	|-RVA: 0x3A24660 Offset: 0x3A24761 VA: 0x3A24660
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetHashCode
	|
	|-RVA: 0x3A24BF0 Offset: 0x3A24CF1 VA: 0x3A24BF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetHashCode
	|
	|-RVA: 0x3A25180 Offset: 0x3A25281 VA: 0x3A25180
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A257F0 Offset: 0x3A258F1 VA: 0x3A257F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A25DF0 Offset: 0x3A25EF1 VA: 0x3A25DF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A264D0 Offset: 0x3A265D1 VA: 0x3A264D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A26AD0 Offset: 0x3A26BD1 VA: 0x3A26AD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A27220 Offset: 0x3A27321 VA: 0x3A27220
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A27890 Offset: 0x3A27991 VA: 0x3A27890
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A28050 Offset: 0x3A28151 VA: 0x3A28050
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A286C0 Offset: 0x3A287C1 VA: 0x3A286C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A28EF0 Offset: 0x3A28FF1 VA: 0x3A28EF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x3A295D0 Offset: 0x3A296D1 VA: 0x3A295D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x3A29BA0 Offset: 0x3A29CA1 VA: 0x3A29BA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A2A170 Offset: 0x3A2A271 VA: 0x3A2A170
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3A2A660 Offset: 0x3A2A761 VA: 0x3A2A660
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetHashCode
	|
	|-RVA: 0x3A2AB50 Offset: 0x3A2AC51 VA: 0x3A2AB50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.GetHashCode
	|
	|-RVA: 0x3A2B0E0 Offset: 0x3A2B1E1 VA: 0x3A2B0E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetHashCode
	|
	|-RVA: 0x3A2B5D0 Offset: 0x3A2B6D1 VA: 0x3A2B5D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.GetHashCode
	|
	|-RVA: 0x3A2BB60 Offset: 0x3A2BC61 VA: 0x3A2BB60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.GetHashCode
	|
	|-RVA: 0x3A2C0F0 Offset: 0x3A2C1F1 VA: 0x3A2C0F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.GetHashCode
	|
	|-RVA: 0x3A2C620 Offset: 0x3A2C721 VA: 0x3A2C620
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.GetHashCode
	|
	|-RVA: 0x3A2CBB0 Offset: 0x3A2CCB1 VA: 0x3A2CBB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.GetHashCode
	|
	|-RVA: 0x3A2D140 Offset: 0x3A2D241 VA: 0x3A2D140
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A2D6D0 Offset: 0x3A2D7D1 VA: 0x3A2D6D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetHashCode
	|
	|-RVA: 0x3A2DC60 Offset: 0x3A2DD61 VA: 0x3A2DC60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetHashCode
	|
	|-RVA: 0x3A2E190 Offset: 0x3A2E291 VA: 0x3A2E190
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.GetHashCode
	|
	|-RVA: 0x3A2E720 Offset: 0x3A2E821 VA: 0x3A2E720
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetHashCode
	|
	|-RVA: 0x3A2EC10 Offset: 0x3A2ED11 VA: 0x3A2EC10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetHashCode
	|
	|-RVA: 0x3A2F100 Offset: 0x3A2F201 VA: 0x3A2F100
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetHashCode
	|
	|-RVA: 0x3A2F690 Offset: 0x3A2F791 VA: 0x3A2F690
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetHashCode
	|
	|-RVA: 0x3A2FC20 Offset: 0x3A2FD21 VA: 0x3A2FC20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetHashCode
	|
	|-RVA: 0x3A301B0 Offset: 0x3A302B1 VA: 0x3A301B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.GetHashCode
	|
	|-RVA: 0x3A30740 Offset: 0x3A30841 VA: 0x3A30740
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.GetHashCode
	|
	|-RVA: 0x3A30D40 Offset: 0x3A30E41 VA: 0x3A30D40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A312D0 Offset: 0x3A313D1 VA: 0x3A312D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3A31940 Offset: 0x3A31A41 VA: 0x3A31940
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A31F40 Offset: 0x3A32041 VA: 0x3A31F40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3A32620 Offset: 0x3A32721 VA: 0x3A32620
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A32C20 Offset: 0x3A32D21 VA: 0x3A32C20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3A33370 Offset: 0x3A33471 VA: 0x3A33370
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A339E0 Offset: 0x3A33AE1 VA: 0x3A339E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x3A341A0 Offset: 0x3A342A1 VA: 0x3A341A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x39FB8D0 Offset: 0x39FB9D1 VA: 0x39FB8D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x39FC100 Offset: 0x39FC201 VA: 0x39FC100
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x39FC6D0 Offset: 0x39FC7D1 VA: 0x39FC6D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x39FCB90 Offset: 0x39FCC91 VA: 0x39FCB90
	|-GenericEqualityComparer<ValueTuple<bool, AsyncUnit>>.GetHashCode
	|
	|-RVA: 0x39FD050 Offset: 0x39FD151 VA: 0x39FD050
	|-GenericEqualityComparer<ValueTuple<bool, bool>>.GetHashCode
	|
	|-RVA: 0x39FD650 Offset: 0x39FD751 VA: 0x39FD650
	|-GenericEqualityComparer<ValueTuple<bool, Bounds>>.GetHashCode
	|
	|-RVA: 0x39FDB10 Offset: 0x39FDC11 VA: 0x39FDB10
	|-GenericEqualityComparer<ValueTuple<bool, byte>>.GetHashCode
	|
	|-RVA: 0x39FE0A0 Offset: 0x39FE1A1 VA: 0x39FE0A0
	|-GenericEqualityComparer<ValueTuple<bool, Color>>.GetHashCode
	|
	|-RVA: 0x39FE590 Offset: 0x39FE691 VA: 0x39FE590
	|-GenericEqualityComparer<ValueTuple<bool, double>>.GetHashCode
	|
	|-RVA: 0x39FEA50 Offset: 0x39FEB51 VA: 0x39FEA50
	|-GenericEqualityComparer<ValueTuple<bool, int>>.GetHashCode
	|
	|-RVA: 0x39FEF40 Offset: 0x39FF041 VA: 0x39FEF40
	|-GenericEqualityComparer<ValueTuple<bool, long>>.GetHashCode
	|
	|-RVA: 0x39FF430 Offset: 0x39FF531 VA: 0x39FF430
	|-GenericEqualityComparer<ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x39FF9C0 Offset: 0x39FFAC1 VA: 0x39FF9C0
	|-GenericEqualityComparer<ValueTuple<bool, Quaternion>>.GetHashCode
	|
	|-RVA: 0x39FFF50 Offset: 0x3A00051 VA: 0x39FFF50
	|-GenericEqualityComparer<ValueTuple<bool, Rect>>.GetHashCode
	|
	|-RVA: 0x3A00410 Offset: 0x3A00511 VA: 0x3A00410
	|-GenericEqualityComparer<ValueTuple<bool, float>>.GetHashCode
	|
	|-RVA: 0x3A00900 Offset: 0x3A00A01 VA: 0x3A00900
	|-GenericEqualityComparer<ValueTuple<bool, UniTask>>.GetHashCode
	|
	|-RVA: 0x3A00DC0 Offset: 0x3A00EC1 VA: 0x3A00DC0
	|-GenericEqualityComparer<ValueTuple<bool, Unit>>.GetHashCode
	|
	|-RVA: 0x3A012F0 Offset: 0x3A013F1 VA: 0x3A012F0
	|-GenericEqualityComparer<ValueTuple<bool, Vector2>>.GetHashCode
	|
	|-RVA: 0x3A017E0 Offset: 0x3A018E1 VA: 0x3A017E0
	|-GenericEqualityComparer<ValueTuple<bool, Vector3>>.GetHashCode
	|
	|-RVA: 0x3A01D70 Offset: 0x3A01E71 VA: 0x3A01D70
	|-GenericEqualityComparer<ValueTuple<bool, Vector4>>.GetHashCode
	|
	|-RVA: 0x3A02250 Offset: 0x3A02351 VA: 0x3A02250
	|-GenericEqualityComparer<ValueTuple<int, object>>.GetHashCode
	|
	|-RVA: 0x3A02710 Offset: 0x3A02811 VA: 0x3A02710
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x3A02C90 Offset: 0x3A02D91 VA: 0x3A02C90
	|-GenericEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.GetHashCode
	|
	|-RVA: 0x3A03170 Offset: 0x3A03271 VA: 0x3A03170
	|-GenericEqualityComparer<ValueTuple<object, int>>.GetHashCode
	|
	|-RVA: 0x3A03650 Offset: 0x3A03751 VA: 0x3A03650
	|-GenericEqualityComparer<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x3A03B30 Offset: 0x3A03C31 VA: 0x3A03B30
	|-GenericEqualityComparer<ValueTuple<object, float>>.GetHashCode
	|
	|-RVA: 0x3A040B0 Offset: 0x3A041B1 VA: 0x3A040B0
	|-GenericEqualityComparer<ValueTuple<Vector3, float>>.GetHashCode
	|
	|-RVA: 0x3A046A0 Offset: 0x3A047A1 VA: 0x3A046A0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A04B80 Offset: 0x3A04C81 VA: 0x3A04B80
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum, int>>.GetHashCode
	|
	|-RVA: 0x3A05100 Offset: 0x3A05201 VA: 0x3A05100
	|-GenericEqualityComparer<ValueTuple<object, object, object>>.GetHashCode
	|
	|-RVA: 0x3A05760 Offset: 0x3A05861 VA: 0x3A05760
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A05CE0 Offset: 0x3A05DE1 VA: 0x3A05CE0
	|-GenericEqualityComparer<ValueTuple<object, int, int, int>>.GetHashCode
	|
	|-RVA: 0x3A06270 Offset: 0x3A06371 VA: 0x3A06270
	|-GenericEqualityComparer<ValueTuple<object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3A06940 Offset: 0x3A06A41 VA: 0x3A06940
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A06F30 Offset: 0x3A07031 VA: 0x3A06F30
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3A07670 Offset: 0x3A07771 VA: 0x3A07670
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A07C60 Offset: 0x3A07D61 VA: 0x3A07C60
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3A08410 Offset: 0x3A08511 VA: 0x3A08410
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x3A08A70 Offset: 0x3A08B71 VA: 0x3A08A70
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x3A09290 Offset: 0x3A09391 VA: 0x3A09290
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A09850 Offset: 0x3A09951 VA: 0x3A09850
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x3A09AA0 Offset: 0x3A09BA1 VA: 0x3A09AA0
	|-GenericEqualityComparer<AsyncUnit>.GetHashCode
	|
	|-RVA: 0x3A09D00 Offset: 0x3A09E01 VA: 0x3A09D00
	|-GenericEqualityComparer<BoneWeight>.GetHashCode
	|
	|-RVA: 0x3A09F60 Offset: 0x3A0A061 VA: 0x3A09F60
	|-GenericEqualityComparer<bool>.GetHashCode
	|
	|-RVA: 0x3A0A1C0 Offset: 0x3A0A2C1 VA: 0x3A0A1C0
	|-GenericEqualityComparer<Bounds>.GetHashCode
	|
	|-RVA: 0x3A0A410 Offset: 0x3A0A511 VA: 0x3A0A410
	|-GenericEqualityComparer<byte>.GetHashCode
	|
	|-RVA: 0x3A0A670 Offset: 0x3A0A771 VA: 0x3A0A670
	|-GenericEqualityComparer<CancellationTokenRegistration>.GetHashCode
	|
	|-RVA: 0x3A0A8B0 Offset: 0x3A0A9B1 VA: 0x3A0A8B0
	|-GenericEqualityComparer<char>.GetHashCode
	|
	|-RVA: 0x3A0AB50 Offset: 0x3A0AC51 VA: 0x3A0AB50
	|-GenericEqualityComparer<Color>.GetHashCode
	|
	|-RVA: 0x3A0AE10 Offset: 0x3A0AF11 VA: 0x3A0AE10
	|-GenericEqualityComparer<ColorBlock>.GetHashCode
	|
	|-RVA: 0x3A0B050 Offset: 0x3A0B151 VA: 0x3A0B050
	|-GenericEqualityComparer<DateTime>.GetHashCode
	|
	|-RVA: 0x3A0B2B0 Offset: 0x3A0B3B1 VA: 0x3A0B2B0
	|-GenericEqualityComparer<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x3A0B510 Offset: 0x3A0B611 VA: 0x3A0B510
	|-GenericEqualityComparer<Decimal>.GetHashCode
	|
	|-RVA: 0x3A0B760 Offset: 0x3A0B861 VA: 0x3A0B760
	|-GenericEqualityComparer<double>.GetHashCode
	|
	|-RVA: 0x3A0B9C0 Offset: 0x3A0BAC1 VA: 0x3A0B9C0
	|-GenericEqualityComparer<GlyphRect>.GetHashCode
	|
	|-RVA: 0x3A0BC20 Offset: 0x3A0BD21 VA: 0x3A0BC20
	|-GenericEqualityComparer<Guid>.GetHashCode
	|
	|-RVA: 0x3A0BE60 Offset: 0x3A0BF61 VA: 0x3A0BE60
	|-GenericEqualityComparer<short>.GetHashCode
	|
	|-RVA: 0x3A0C0A0 Offset: 0x3A0C1A1 VA: 0x3A0C0A0
	|-GenericEqualityComparer<int>.GetHashCode
	|
	|-RVA: 0x3A0C2E0 Offset: 0x3A0C3E1 VA: 0x3A0C2E0
	|-GenericEqualityComparer<long>.GetHashCode
	|
	|-RVA: 0x3A0C570 Offset: 0x3A0C671 VA: 0x3A0C570
	|-GenericEqualityComparer<Matrix4x4>.GetHashCode
	|
	|-RVA: 0x3A0C880 Offset: 0x3A0C981 VA: 0x3A0C880
	|-GenericEqualityComparer<Navigation>.GetHashCode
	|
	|-RVA: 0x3A0CCE0 Offset: 0x3A0CDE1 VA: 0x3A0CCE0
	|-GenericEqualityComparer<object>.GetHashCode
	|
	|-RVA: 0x3A0CF90 Offset: 0x3A0D091 VA: 0x3A0CF90
	|-GenericEqualityComparer<Playable>.GetHashCode
	|
	|-RVA: 0x3A0D230 Offset: 0x3A0D331 VA: 0x3A0D230
	|-GenericEqualityComparer<Quaternion>.GetHashCode
	|
	|-RVA: 0x3A0D4D0 Offset: 0x3A0D5D1 VA: 0x3A0D4D0
	|-GenericEqualityComparer<Rect>.GetHashCode
	|
	|-RVA: 0x3A0D720 Offset: 0x3A0D821 VA: 0x3A0D720
	|-GenericEqualityComparer<sbyte>.GetHashCode
	|
	|-RVA: 0x3A0D960 Offset: 0x3A0DA61 VA: 0x3A0D960
	|-GenericEqualityComparer<ShaderTagId>.GetHashCode
	|
	|-RVA: 0x3A0DBB0 Offset: 0x3A0DCB1 VA: 0x3A0DBB0
	|-GenericEqualityComparer<float>.GetHashCode
	|
	|-RVA: 0x3A0DEA0 Offset: 0x3A0DFA1 VA: 0x3A0DEA0
	|-GenericEqualityComparer<SphericalHarmonicsL2>.GetHashCode
	|
	|-RVA: 0x3A0E180 Offset: 0x3A0E281 VA: 0x3A0E180
	|-GenericEqualityComparer<SpriteState>.GetHashCode
	|
	|-RVA: 0x3A0E3C0 Offset: 0x3A0E4C1 VA: 0x3A0E3C0
	|-GenericEqualityComparer<TimeSpan>.GetHashCode
	|
	|-RVA: 0x3A0E600 Offset: 0x3A0E701 VA: 0x3A0E600
	|-GenericEqualityComparer<ushort>.GetHashCode
	|
	|-RVA: 0x3A0E840 Offset: 0x3A0E941 VA: 0x3A0E840
	|-GenericEqualityComparer<uint>.GetHashCode
	|
	|-RVA: 0x3A0EA80 Offset: 0x3A0EB81 VA: 0x3A0EA80
	|-GenericEqualityComparer<ulong>.GetHashCode
	|
	|-RVA: 0x3A0ECC0 Offset: 0x3A0EDC1 VA: 0x3A0ECC0
	|-GenericEqualityComparer<UniTask>.GetHashCode
	|
	|-RVA: 0x3A0EF10 Offset: 0x3A0F011 VA: 0x3A0EF10
	|-GenericEqualityComparer<Unit>.GetHashCode
	|
	|-RVA: 0x3A0F120 Offset: 0x3A0F221 VA: 0x3A0F120
	|-GenericEqualityComparer<Vector2>.GetHashCode
	|
	|-RVA: 0x3A0F3C0 Offset: 0x3A0F4C1 VA: 0x3A0F3C0
	|-GenericEqualityComparer<Vector3>.GetHashCode
	|
	|-RVA: 0x3A0F620 Offset: 0x3A0F721 VA: 0x3A0F620
	|-GenericEqualityComparer<Vector4>.GetHashCode
	|
	|-RVA: 0x3A0F880 Offset: 0x3A0F981 VA: 0x3A0F880
	|-GenericEqualityComparer<VertexAttributeDescriptor>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EA29F0 Offset: 0x1EA2AF1 VA: 0x1EA29F0
	|-GenericEqualityComparer<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x1EA2EE0 Offset: 0x1EA2FE1 VA: 0x1EA2EE0
	|-GenericEqualityComparer<TimeInterval<object>>..ctor
	|
	|-RVA: 0x1EA3460 Offset: 0x1EA3561 VA: 0x1EA3460
	|-GenericEqualityComparer<Timestamped<object>>..ctor
	|
	|-RVA: 0x1EA3940 Offset: 0x1EA3A41 VA: 0x1EA3940
	|-GenericEqualityComparer<UniTask<object>>..ctor
	|
	|-RVA: 0x1EA3E30 Offset: 0x1EA3F31 VA: 0x1EA3E30
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1EA43C0 Offset: 0x1EA44C1 VA: 0x1EA43C0
	|-GenericEqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1EA4950 Offset: 0x1EA4A51 VA: 0x1EA4950
	|-GenericEqualityComparer<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x1EA4EE0 Offset: 0x1EA4FE1 VA: 0x1EA4EE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x1EA54E0 Offset: 0x1EA55E1 VA: 0x1EA54E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x1EA5AE0 Offset: 0x1EA5BE1 VA: 0x1EA5AE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x1EA5FD0 Offset: 0x1EA60D1 VA: 0x1EA5FD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x1EA64C0 Offset: 0x1EA65C1 VA: 0x1EA64C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x1EA6B30 Offset: 0x1EA6C31 VA: 0x1EA6B30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x1EA7020 Offset: 0x1EA7121 VA: 0x1EA7020
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x1EA7660 Offset: 0x1EA7761 VA: 0x1EA7660
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x1EA7C60 Offset: 0x1EA7D61 VA: 0x1EA7C60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x1EA81F0 Offset: 0x1EA82F1 VA: 0x1EA81F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x1EA87F0 Offset: 0x1EA88F1 VA: 0x1EA87F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x1EA8DF0 Offset: 0x1EA8EF1 VA: 0x1EA8DF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1EA9430 Offset: 0x1EA9531 VA: 0x1EA9430
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x1EA9A70 Offset: 0x1EA9B71 VA: 0x1EA9A70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x1EAA000 Offset: 0x1EAA101 VA: 0x1EAA000
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x1EAA600 Offset: 0x1EAA701 VA: 0x1EAA600
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x1EAAAF0 Offset: 0x1EAABF1 VA: 0x1EAAAF0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x1EAB0F0 Offset: 0x1EAB1F1 VA: 0x1EAB0F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x1EAB680 Offset: 0x1EAB781 VA: 0x1EAB680
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x1EABCC0 Offset: 0x1EABDC1 VA: 0x1EABCC0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x1EAC2C0 Offset: 0x1EAC3C1 VA: 0x1EAC2C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x1EAC8C0 Offset: 0x1EAC9C1 VA: 0x1EAC8C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x1EACF30 Offset: 0x1EAD031 VA: 0x1EACF30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1EAD5A0 Offset: 0x1EAD6A1 VA: 0x1EAD5A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1EADC80 Offset: 0x1EADD81 VA: 0x1EADC80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1EAE360 Offset: 0x1EAE461 VA: 0x1EAE360
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1EAEAB0 Offset: 0x1EAEBB1 VA: 0x1EAEAB0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x3A13F20 Offset: 0x3A14021 VA: 0x3A13F20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x3A14410 Offset: 0x3A14511 VA: 0x3A14410
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x3A14A10 Offset: 0x3A14B11 VA: 0x3A14A10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x3A14F00 Offset: 0x3A15001 VA: 0x3A14F00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x3A15490 Offset: 0x3A15591 VA: 0x3A15490
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x3A15A90 Offset: 0x3A15B91 VA: 0x3A15A90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x3A16020 Offset: 0x3A16121 VA: 0x3A16020
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x3A16620 Offset: 0x3A16721 VA: 0x3A16620
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x3A16C20 Offset: 0x3A16D21 VA: 0x3A16C20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A171B0 Offset: 0x3A172B1 VA: 0x3A171B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x3A17740 Offset: 0x3A17841 VA: 0x3A17740
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x3A17CD0 Offset: 0x3A17DD1 VA: 0x3A17CD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x3A182D0 Offset: 0x3A183D1 VA: 0x3A182D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x3A187C0 Offset: 0x3A188C1 VA: 0x3A187C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x3A18D50 Offset: 0x3A18E51 VA: 0x3A18D50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x3A19350 Offset: 0x3A19451 VA: 0x3A19350
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x3A198E0 Offset: 0x3A199E1 VA: 0x3A198E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x3A19EE0 Offset: 0x3A19FE1 VA: 0x3A19EE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x3A1A4E0 Offset: 0x3A1A5E1 VA: 0x3A1A4E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x3A1AB50 Offset: 0x3A1AC51 VA: 0x3A1AB50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A1B150 Offset: 0x3A1B251 VA: 0x3A1B150
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x3A1B830 Offset: 0x3A1B931 VA: 0x3A1B830
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A1BEA0 Offset: 0x3A1BFA1 VA: 0x3A1BEA0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3A1C5F0 Offset: 0x3A1C6F1 VA: 0x3A1C5F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A1CC60 Offset: 0x3A1CD61 VA: 0x3A1CC60
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3A1D420 Offset: 0x3A1D521 VA: 0x3A1D420
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A1DB00 Offset: 0x3A1DC01 VA: 0x3A1DB00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3A1E330 Offset: 0x3A1E431 VA: 0x3A1E330
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A1EA10 Offset: 0x3A1EB11 VA: 0x3A1EA10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3A1EED0 Offset: 0x3A1EFD1 VA: 0x3A1EED0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x3A1F390 Offset: 0x3A1F491 VA: 0x3A1F390
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x3A1F9D0 Offset: 0x3A1FAD1 VA: 0x3A1F9D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x3A1FE90 Offset: 0x3A1FF91 VA: 0x3A1FE90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x3A20490 Offset: 0x3A20591 VA: 0x3A20490
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x3A20A20 Offset: 0x3A20B21 VA: 0x3A20A20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x3A20F10 Offset: 0x3A21011 VA: 0x3A20F10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x3A214A0 Offset: 0x3A215A1 VA: 0x3A214A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x3A21A30 Offset: 0x3A21B31 VA: 0x3A21A30
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3A22030 Offset: 0x3A22131 VA: 0x3A22030
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x3A22630 Offset: 0x3A22731 VA: 0x3A22630
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x3A22B20 Offset: 0x3A22C21 VA: 0x3A22B20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x3A230B0 Offset: 0x3A231B1 VA: 0x3A230B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x3A23570 Offset: 0x3A23671 VA: 0x3A23570
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x3A23B00 Offset: 0x3A23C01 VA: 0x3A23B00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x3A24090 Offset: 0x3A24191 VA: 0x3A24090
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x3A24690 Offset: 0x3A24791 VA: 0x3A24690
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x3A24C20 Offset: 0x3A24D21 VA: 0x3A24C20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x3A251B0 Offset: 0x3A252B1 VA: 0x3A251B0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x3A25820 Offset: 0x3A25921 VA: 0x3A25820
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A25E20 Offset: 0x3A25F21 VA: 0x3A25E20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x3A26500 Offset: 0x3A26601 VA: 0x3A26500
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A26B00 Offset: 0x3A26C01 VA: 0x3A26B00
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x3A27250 Offset: 0x3A27351 VA: 0x3A27250
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A278C0 Offset: 0x3A279C1 VA: 0x3A278C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x3A28080 Offset: 0x3A28181 VA: 0x3A28080
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A286F0 Offset: 0x3A287F1 VA: 0x3A286F0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x3A28F20 Offset: 0x3A29021 VA: 0x3A28F20
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3A29600 Offset: 0x3A29701 VA: 0x3A29600
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x3A29BD0 Offset: 0x3A29CD1 VA: 0x3A29BD0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A2A1A0 Offset: 0x3A2A2A1 VA: 0x3A2A1A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3A2A690 Offset: 0x3A2A791 VA: 0x3A2A690
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x3A2AB80 Offset: 0x3A2AC81 VA: 0x3A2AB80
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x3A2B110 Offset: 0x3A2B211 VA: 0x3A2B110
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x3A2B600 Offset: 0x3A2B701 VA: 0x3A2B600
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x3A2BB90 Offset: 0x3A2BC91 VA: 0x3A2BB90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x3A2C120 Offset: 0x3A2C221 VA: 0x3A2C120
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x3A2C650 Offset: 0x3A2C751 VA: 0x3A2C650
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x3A2CBE0 Offset: 0x3A2CCE1 VA: 0x3A2CBE0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x3A2D170 Offset: 0x3A2D271 VA: 0x3A2D170
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3A2D700 Offset: 0x3A2D801 VA: 0x3A2D700
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x3A2DC90 Offset: 0x3A2DD91 VA: 0x3A2DC90
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x3A2E1C0 Offset: 0x3A2E2C1 VA: 0x3A2E1C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x3A2E750 Offset: 0x3A2E851 VA: 0x3A2E750
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x3A2EC40 Offset: 0x3A2ED41 VA: 0x3A2EC40
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x3A2F130 Offset: 0x3A2F231 VA: 0x3A2F130
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x3A2F6C0 Offset: 0x3A2F7C1 VA: 0x3A2F6C0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x3A2FC50 Offset: 0x3A2FD51 VA: 0x3A2FC50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x3A301E0 Offset: 0x3A302E1 VA: 0x3A301E0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x3A30770 Offset: 0x3A30871 VA: 0x3A30770
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x3A30D70 Offset: 0x3A30E71 VA: 0x3A30D70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3A31300 Offset: 0x3A31401 VA: 0x3A31300
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x3A31970 Offset: 0x3A31A71 VA: 0x3A31970
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3A31F70 Offset: 0x3A32071 VA: 0x3A31F70
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x3A32650 Offset: 0x3A32751 VA: 0x3A32650
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3A32C50 Offset: 0x3A32D51 VA: 0x3A32C50
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x3A333A0 Offset: 0x3A334A1 VA: 0x3A333A0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3A33A10 Offset: 0x3A33B11 VA: 0x3A33A10
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x3A341D0 Offset: 0x3A342D1 VA: 0x3A341D0
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x39FB900 Offset: 0x39FBA01 VA: 0x39FB900
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x39FC130 Offset: 0x39FC231 VA: 0x39FC130
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x39FC700 Offset: 0x39FC801 VA: 0x39FC700
	|-GenericEqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x39FCBC0 Offset: 0x39FCCC1 VA: 0x39FCBC0
	|-GenericEqualityComparer<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x39FD080 Offset: 0x39FD181 VA: 0x39FD080
	|-GenericEqualityComparer<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x39FD680 Offset: 0x39FD781 VA: 0x39FD680
	|-GenericEqualityComparer<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x39FDB40 Offset: 0x39FDC41 VA: 0x39FDB40
	|-GenericEqualityComparer<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x39FE0D0 Offset: 0x39FE1D1 VA: 0x39FE0D0
	|-GenericEqualityComparer<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x39FE5C0 Offset: 0x39FE6C1 VA: 0x39FE5C0
	|-GenericEqualityComparer<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x39FEA80 Offset: 0x39FEB81 VA: 0x39FEA80
	|-GenericEqualityComparer<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x39FEF70 Offset: 0x39FF071 VA: 0x39FEF70
	|-GenericEqualityComparer<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x39FF460 Offset: 0x39FF561 VA: 0x39FF460
	|-GenericEqualityComparer<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x39FF9F0 Offset: 0x39FFAF1 VA: 0x39FF9F0
	|-GenericEqualityComparer<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x39FFF80 Offset: 0x3A00081 VA: 0x39FFF80
	|-GenericEqualityComparer<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x3A00440 Offset: 0x3A00541 VA: 0x3A00440
	|-GenericEqualityComparer<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x3A00930 Offset: 0x3A00A31 VA: 0x3A00930
	|-GenericEqualityComparer<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x3A00DF0 Offset: 0x3A00EF1 VA: 0x3A00DF0
	|-GenericEqualityComparer<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x3A01320 Offset: 0x3A01421 VA: 0x3A01320
	|-GenericEqualityComparer<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x3A01810 Offset: 0x3A01911 VA: 0x3A01810
	|-GenericEqualityComparer<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x3A01DA0 Offset: 0x3A01EA1 VA: 0x3A01DA0
	|-GenericEqualityComparer<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x3A02280 Offset: 0x3A02381 VA: 0x3A02280
	|-GenericEqualityComparer<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x3A02740 Offset: 0x3A02841 VA: 0x3A02740
	|-GenericEqualityComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3A02CC0 Offset: 0x3A02DC1 VA: 0x3A02CC0
	|-GenericEqualityComparer<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|
	|-RVA: 0x3A031A0 Offset: 0x3A032A1 VA: 0x3A031A0
	|-GenericEqualityComparer<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x3A03680 Offset: 0x3A03781 VA: 0x3A03680
	|-GenericEqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x3A03B60 Offset: 0x3A03C61 VA: 0x3A03B60
	|-GenericEqualityComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x3A040E0 Offset: 0x3A041E1 VA: 0x3A040E0
	|-GenericEqualityComparer<ValueTuple<Vector3, float>>..ctor
	|
	|-RVA: 0x3A046D0 Offset: 0x3A047D1 VA: 0x3A046D0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3A04BB0 Offset: 0x3A04CB1 VA: 0x3A04BB0
	|-GenericEqualityComparer<ValueTuple<object, Int32Enum, int>>..ctor
	|
	|-RVA: 0x3A05130 Offset: 0x3A05231 VA: 0x3A05130
	|-GenericEqualityComparer<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x3A05790 Offset: 0x3A05891 VA: 0x3A05790
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3A05D10 Offset: 0x3A05E11 VA: 0x3A05D10
	|-GenericEqualityComparer<ValueTuple<object, int, int, int>>..ctor
	|
	|-RVA: 0x3A062A0 Offset: 0x3A063A1 VA: 0x3A062A0
	|-GenericEqualityComparer<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x3A06970 Offset: 0x3A06A71 VA: 0x3A06970
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3A06F60 Offset: 0x3A07061 VA: 0x3A06F60
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3A076A0 Offset: 0x3A077A1 VA: 0x3A076A0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3A07C90 Offset: 0x3A07D91 VA: 0x3A07C90
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3A08440 Offset: 0x3A08541 VA: 0x3A08440
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3A08AA0 Offset: 0x3A08BA1 VA: 0x3A08AA0
	|-GenericEqualityComparer<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3A092C0 Offset: 0x3A093C1 VA: 0x3A092C0
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3A09880 Offset: 0x3A09981 VA: 0x3A09880
	|-GenericEqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3A09AD0 Offset: 0x3A09BD1 VA: 0x3A09AD0
	|-GenericEqualityComparer<AsyncUnit>..ctor
	|
	|-RVA: 0x3A09D30 Offset: 0x3A09E31 VA: 0x3A09D30
	|-GenericEqualityComparer<BoneWeight>..ctor
	|
	|-RVA: 0x3A09F90 Offset: 0x3A0A091 VA: 0x3A09F90
	|-GenericEqualityComparer<bool>..ctor
	|
	|-RVA: 0x3A0A1F0 Offset: 0x3A0A2F1 VA: 0x3A0A1F0
	|-GenericEqualityComparer<Bounds>..ctor
	|
	|-RVA: 0x3A0A440 Offset: 0x3A0A541 VA: 0x3A0A440
	|-GenericEqualityComparer<byte>..ctor
	|
	|-RVA: 0x3A0A6A0 Offset: 0x3A0A7A1 VA: 0x3A0A6A0
	|-GenericEqualityComparer<CancellationTokenRegistration>..ctor
	|
	|-RVA: 0x3A0A8E0 Offset: 0x3A0A9E1 VA: 0x3A0A8E0
	|-GenericEqualityComparer<char>..ctor
	|
	|-RVA: 0x3A0AB80 Offset: 0x3A0AC81 VA: 0x3A0AB80
	|-GenericEqualityComparer<Color>..ctor
	|
	|-RVA: 0x3A0AE40 Offset: 0x3A0AF41 VA: 0x3A0AE40
	|-GenericEqualityComparer<ColorBlock>..ctor
	|
	|-RVA: 0x3A0B080 Offset: 0x3A0B181 VA: 0x3A0B080
	|-GenericEqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x3A0B2E0 Offset: 0x3A0B3E1 VA: 0x3A0B2E0
	|-GenericEqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x3A0B540 Offset: 0x3A0B641 VA: 0x3A0B540
	|-GenericEqualityComparer<Decimal>..ctor
	|
	|-RVA: 0x3A0B790 Offset: 0x3A0B891 VA: 0x3A0B790
	|-GenericEqualityComparer<double>..ctor
	|
	|-RVA: 0x3A0B9F0 Offset: 0x3A0BAF1 VA: 0x3A0B9F0
	|-GenericEqualityComparer<GlyphRect>..ctor
	|
	|-RVA: 0x3A0BC50 Offset: 0x3A0BD51 VA: 0x3A0BC50
	|-GenericEqualityComparer<Guid>..ctor
	|
	|-RVA: 0x3A0BE90 Offset: 0x3A0BF91 VA: 0x3A0BE90
	|-GenericEqualityComparer<short>..ctor
	|
	|-RVA: 0x3A0C0D0 Offset: 0x3A0C1D1 VA: 0x3A0C0D0
	|-GenericEqualityComparer<int>..ctor
	|
	|-RVA: 0x3A0C310 Offset: 0x3A0C411 VA: 0x3A0C310
	|-GenericEqualityComparer<long>..ctor
	|
	|-RVA: 0x3A0C5A0 Offset: 0x3A0C6A1 VA: 0x3A0C5A0
	|-GenericEqualityComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x3A0C8B0 Offset: 0x3A0C9B1 VA: 0x3A0C8B0
	|-GenericEqualityComparer<Navigation>..ctor
	|
	|-RVA: 0x3A0CD10 Offset: 0x3A0CE11 VA: 0x3A0CD10
	|-GenericEqualityComparer<object>..ctor
	|
	|-RVA: 0x3A0CFC0 Offset: 0x3A0D0C1 VA: 0x3A0CFC0
	|-GenericEqualityComparer<Playable>..ctor
	|
	|-RVA: 0x3A0D260 Offset: 0x3A0D361 VA: 0x3A0D260
	|-GenericEqualityComparer<Quaternion>..ctor
	|
	|-RVA: 0x3A0D500 Offset: 0x3A0D601 VA: 0x3A0D500
	|-GenericEqualityComparer<Rect>..ctor
	|
	|-RVA: 0x3A0D750 Offset: 0x3A0D851 VA: 0x3A0D750
	|-GenericEqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x3A0D990 Offset: 0x3A0DA91 VA: 0x3A0D990
	|-GenericEqualityComparer<ShaderTagId>..ctor
	|
	|-RVA: 0x3A0DBE0 Offset: 0x3A0DCE1 VA: 0x3A0DBE0
	|-GenericEqualityComparer<float>..ctor
	|
	|-RVA: 0x3A0DED0 Offset: 0x3A0DFD1 VA: 0x3A0DED0
	|-GenericEqualityComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x3A0E1B0 Offset: 0x3A0E2B1 VA: 0x3A0E1B0
	|-GenericEqualityComparer<SpriteState>..ctor
	|
	|-RVA: 0x3A0E3F0 Offset: 0x3A0E4F1 VA: 0x3A0E3F0
	|-GenericEqualityComparer<TimeSpan>..ctor
	|
	|-RVA: 0x3A0E630 Offset: 0x3A0E731 VA: 0x3A0E630
	|-GenericEqualityComparer<ushort>..ctor
	|
	|-RVA: 0x3A0E870 Offset: 0x3A0E971 VA: 0x3A0E870
	|-GenericEqualityComparer<uint>..ctor
	|
	|-RVA: 0x3A0EAB0 Offset: 0x3A0EBB1 VA: 0x3A0EAB0
	|-GenericEqualityComparer<ulong>..ctor
	|
	|-RVA: 0x3A0ECF0 Offset: 0x3A0EDF1 VA: 0x3A0ECF0
	|-GenericEqualityComparer<UniTask>..ctor
	|
	|-RVA: 0x3A0EF40 Offset: 0x3A0F041 VA: 0x3A0EF40
	|-GenericEqualityComparer<Unit>..ctor
	|
	|-RVA: 0x3A0F150 Offset: 0x3A0F251 VA: 0x3A0F150
	|-GenericEqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x3A0F3F0 Offset: 0x3A0F4F1 VA: 0x3A0F3F0
	|-GenericEqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x3A0F650 Offset: 0x3A0F751 VA: 0x3A0F650
	|-GenericEqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x3A0F8B0 Offset: 0x3A0F9B1 VA: 0x3A0F8B0
	|-GenericEqualityComparer<VertexAttributeDescriptor>..ctor
	*/
}

