// Namespace: System.Collections.Generic
[TypeDependencyAttribute] // RVA: 0x4776D0 Offset: 0x4777D1 VA: 0x4776D0
[Serializable]
public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> // TypeDefIndex: 1419
{
	// Fields
	private static EqualityComparer<T> defaultComparer; // 0x0

	// Properties
	public static EqualityComparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EqualityComparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3768100 Offset: 0x3768201 VA: 0x3768100
	|-EqualityComparer<AsyncOperationHandle<object>>.get_Default
	|
	|-RVA: 0x3768DA0 Offset: 0x3768EA1 VA: 0x3768DA0
	|-EqualityComparer<IntervalTree.Entry<object>>.get_Default
	|
	|-RVA: 0x3769A40 Offset: 0x3769B41 VA: 0x3769A40
	|-EqualityComparer<KeyValuePair<DateTime, object>>.get_Default
	|
	|-RVA: 0x376A5F0 Offset: 0x376A6F1 VA: 0x376A5F0
	|-EqualityComparer<KeyValuePair<int, object>>.get_Default
	|
	|-RVA: 0x376B1A0 Offset: 0x376B2A1 VA: 0x376B1A0
	|-EqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.get_Default
	|
	|-RVA: 0x376BE30 Offset: 0x376BF31 VA: 0x376BE30
	|-EqualityComparer<KeyValuePair<object, object>>.get_Default
	|
	|-RVA: 0x376C9E0 Offset: 0x376CAE1 VA: 0x376C9E0
	|-EqualityComparer<CommonBattleSequence.Reliance<object>>.get_Default
	|
	|-RVA: 0x376D680 Offset: 0x376D781 VA: 0x376D680
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Default
	|
	|-RVA: 0x376E230 Offset: 0x376E331 VA: 0x376E230
	|-EqualityComparer<TimeInterval<object>>.get_Default
	|
	|-RVA: 0x376EDE0 Offset: 0x376EEE1 VA: 0x376EDE0
	|-EqualityComparer<Timestamped<object>>.get_Default
	|
	|-RVA: 0x376FA80 Offset: 0x376FB81 VA: 0x376FA80
	|-EqualityComparer<UniTask<object>>.get_Default
	|
	|-RVA: 0x3770630 Offset: 0x3770731 VA: 0x3770630
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>>>.get_Default
	|
	|-RVA: 0x37711E0 Offset: 0x37712E1 VA: 0x37711E0
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Default
	|
	|-RVA: 0x3771E70 Offset: 0x3771F71 VA: 0x3771E70
	|-EqualityComparer<ValueTuple<bool, UniTask<object>>>.get_Default
	|
	|-RVA: 0x3772B10 Offset: 0x3772C11 VA: 0x3772B10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_Default
	|
	|-RVA: 0x37737A0 Offset: 0x37738A1 VA: 0x37737A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_Default
	|
	|-RVA: 0x37744C0 Offset: 0x37745C1 VA: 0x37744C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_Default
	|
	|-RVA: 0x37751D0 Offset: 0x37752D1 VA: 0x37751D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_Default
	|
	|-RVA: 0x3775DA0 Offset: 0x3775EA1 VA: 0x3775DA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_Default
	|
	|-RVA: 0x3776970 Offset: 0x3776A71 VA: 0x3776970
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_Default
	|
	|-RVA: 0x37776F0 Offset: 0x37777F1 VA: 0x37776F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_Default
	|
	|-RVA: 0x37782C0 Offset: 0x37783C1 VA: 0x37782C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_Default
	|
	|-RVA: 0x3779010 Offset: 0x3779111 VA: 0x3779010
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_Default
	|
	|-RVA: 0x3779D20 Offset: 0x3779E21 VA: 0x3779D20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_Default
	|
	|-RVA: 0x377A9C0 Offset: 0x377AAC1 VA: 0x377A9C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_Default
	|
	|-RVA: 0x377B6D0 Offset: 0x377B7D1 VA: 0x377B6D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_Default
	|
	|-RVA: 0x377C3E0 Offset: 0x377C4E1 VA: 0x377C3E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_Default
	|
	|-RVA: 0x377D130 Offset: 0x377D231 VA: 0x377D130
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_Default
	|
	|-RVA: 0x377DE80 Offset: 0x377DF81 VA: 0x377DE80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_Default
	|
	|-RVA: 0x37E7C70 Offset: 0x37E7D71 VA: 0x37E7C70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_Default
	|
	|-RVA: 0x37E8980 Offset: 0x37E8A81 VA: 0x37E8980
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_Default
	|
	|-RVA: 0x37E9550 Offset: 0x37E9651 VA: 0x37E9550
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_Default
	|
	|-RVA: 0x37EA260 Offset: 0x37EA361 VA: 0x37EA260
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_Default
	|
	|-RVA: 0x37EAEF0 Offset: 0x37EAFF1 VA: 0x37EAEF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_Default
	|
	|-RVA: 0x37EBC40 Offset: 0x37EBD41 VA: 0x37EBC40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_Default
	|
	|-RVA: 0x37EC950 Offset: 0x37ECA51 VA: 0x37EC950
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_Default
	|
	|-RVA: 0x37ED660 Offset: 0x37ED761 VA: 0x37ED660
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_Default
	|
	|-RVA: 0x37EE3F0 Offset: 0x37EE4F1 VA: 0x37EE3F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_Default
	|
	|-RVA: 0x37EF170 Offset: 0x37EF271 VA: 0x37EF170
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_Default
	|
	|-RVA: 0x37EFF70 Offset: 0x37F0071 VA: 0x37EFF70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_Default
	|
	|-RVA: 0x37F0D60 Offset: 0x37F0E61 VA: 0x37F0D60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_Default
	|
	|-RVA: 0x37F1BC0 Offset: 0x37F1CC1 VA: 0x37F1BC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_Default
	|
	|-RVA: 0x37F2790 Offset: 0x37F2891 VA: 0x37F2790
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_Default
	|
	|-RVA: 0x37F3360 Offset: 0x37F3461 VA: 0x37F3360
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_Default
	|
	|-RVA: 0x37F4080 Offset: 0x37F4181 VA: 0x37F4080
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_Default
	|
	|-RVA: 0x37F4C50 Offset: 0x37F4D51 VA: 0x37F4C50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_Default
	|
	|-RVA: 0x37F58E0 Offset: 0x37F59E1 VA: 0x37F58E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_Default
	|
	|-RVA: 0x37F6600 Offset: 0x37F6701 VA: 0x37F6600
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_Default
	|
	|-RVA: 0x37F72A0 Offset: 0x37F73A1 VA: 0x37F72A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_Default
	|
	|-RVA: 0x37F7FC0 Offset: 0x37F80C1 VA: 0x37F7FC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_Default
	|
	|-RVA: 0x37F8CE0 Offset: 0x37F8DE1 VA: 0x37F8CE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_Default
	|
	|-RVA: 0x37F9970 Offset: 0x37F9A71 VA: 0x37F9970
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_Default
	|
	|-RVA: 0x37FA600 Offset: 0x37FA701 VA: 0x37FA600
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_Default
	|
	|-RVA: 0x37FB2A0 Offset: 0x37FB3A1 VA: 0x37FB2A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_Default
	|
	|-RVA: 0x37FBFC0 Offset: 0x37FC0C1 VA: 0x37FBFC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_Default
	|
	|-RVA: 0x37FCB90 Offset: 0x37FCC91 VA: 0x37FCB90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_Default
	|
	|-RVA: 0x37FD830 Offset: 0x37FD931 VA: 0x37FD830
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_Default
	|
	|-RVA: 0x37FE540 Offset: 0x37FE641 VA: 0x37FE540
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_Default
	|
	|-RVA: 0x37FF1D0 Offset: 0x37FF2D1 VA: 0x37FF1D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_Default
	|
	|-RVA: 0x37FFEF0 Offset: 0x37FFFF1 VA: 0x37FFEF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_Default
	|
	|-RVA: 0x3800C10 Offset: 0x3800D11 VA: 0x3800C10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Default
	|
	|-RVA: 0x3801990 Offset: 0x3801A91 VA: 0x3801990
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_Default
	|
	|-RVA: 0x38026A0 Offset: 0x38027A1 VA: 0x38026A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Default
	|
	|-RVA: 0x3803490 Offset: 0x3803591 VA: 0x3803490
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_Default
	|
	|-RVA: 0x3804220 Offset: 0x3804321 VA: 0x3804220
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Default
	|
	|-RVA: 0x3805080 Offset: 0x3805181 VA: 0x3805080
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_Default
	|
	|-RVA: 0x3805E00 Offset: 0x3805F01 VA: 0x3805E00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Default
	|
	|-RVA: 0x3806CE0 Offset: 0x3806DE1 VA: 0x3806CE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_Default
	|
	|-RVA: 0x3807AE0 Offset: 0x3807BE1 VA: 0x3807AE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Default
	|
	|-RVA: 0x3808A30 Offset: 0x3808B31 VA: 0x3808A30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_Default
	|
	|-RVA: 0x3809820 Offset: 0x3809921 VA: 0x3809820
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_Default
	|
	|-RVA: 0x380A3B0 Offset: 0x380A4B1 VA: 0x380A3B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_Default
	|
	|-RVA: 0x380AF40 Offset: 0x380B041 VA: 0x380AF40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_Default
	|
	|-RVA: 0x380BC90 Offset: 0x380BD91 VA: 0x380BC90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_Default
	|
	|-RVA: 0x380C820 Offset: 0x380C921 VA: 0x380C820
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_Default
	|
	|-RVA: 0x39A03F0 Offset: 0x39A04F1 VA: 0x39A03F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_Default
	|
	|-RVA: 0x39A1080 Offset: 0x39A1181 VA: 0x39A1080
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_Default
	|
	|-RVA: 0x39A1C30 Offset: 0x39A1D31 VA: 0x39A1C30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_Default
	|
	|-RVA: 0x39A28C0 Offset: 0x39A29C1 VA: 0x39A28C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_Default
	|
	|-RVA: 0x39A3550 Offset: 0x39A3651 VA: 0x39A3550
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_Default
	|
	|-RVA: 0x39A4260 Offset: 0x39A4361 VA: 0x39A4260
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_Default
	|
	|-RVA: 0x39A4F70 Offset: 0x39A5071 VA: 0x39A4F70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_Default
	|
	|-RVA: 0x39A5B20 Offset: 0x39A5C21 VA: 0x39A5B20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_Default
	|
	|-RVA: 0x39A67B0 Offset: 0x39A68B1 VA: 0x39A67B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_Default
	|
	|-RVA: 0x39A7340 Offset: 0x39A7441 VA: 0x39A7340
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_Default
	|
	|-RVA: 0x39A7FE0 Offset: 0x39A80E1 VA: 0x39A7FE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_Default
	|
	|-RVA: 0x39A8C80 Offset: 0x39A8D81 VA: 0x39A8C80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_Default
	|
	|-RVA: 0x39A9990 Offset: 0x39A9A91 VA: 0x39A9990
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_Default
	|
	|-RVA: 0x39AA620 Offset: 0x39AA721 VA: 0x39AA620
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_Default
	|
	|-RVA: 0x39AB2B0 Offset: 0x39AB3B1 VA: 0x39AB2B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Default
	|
	|-RVA: 0x39AC040 Offset: 0x39AC141 VA: 0x39AC040
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_Default
	|
	|-RVA: 0x39ACD60 Offset: 0x39ACE61 VA: 0x39ACD60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Default
	|
	|-RVA: 0x39ADB60 Offset: 0x39ADC61 VA: 0x39ADB60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_Default
	|
	|-RVA: 0x39AE870 Offset: 0x39AE971 VA: 0x39AE870
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Default
	|
	|-RVA: 0x39AF6D0 Offset: 0x39AF7D1 VA: 0x39AF6D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_Default
	|
	|-RVA: 0x39B0460 Offset: 0x39B0561 VA: 0x39B0460
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Default
	|
	|-RVA: 0x39B1340 Offset: 0x39B1441 VA: 0x39B1340
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_Default
	|
	|-RVA: 0x39B20C0 Offset: 0x39B21C1 VA: 0x39B20C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Default
	|
	|-RVA: 0x39B3010 Offset: 0x39B3111 VA: 0x39B3010
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_Default
	|
	|-RVA: 0x39B3E10 Offset: 0x39B3F11 VA: 0x39B3E10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_Default
	|
	|-RVA: 0x39B4AC0 Offset: 0x39B4BC1 VA: 0x39B4AC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Default
	|
	|-RVA: 0x39B5770 Offset: 0x39B5871 VA: 0x39B5770
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_Default
	|
	|-RVA: 0x39B6340 Offset: 0x39B6441 VA: 0x39B6340
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.get_Default
	|
	|-RVA: 0x39B6F10 Offset: 0x39B7011 VA: 0x39B6F10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_Default
	|
	|-RVA: 0x39B7BA0 Offset: 0x39B7CA1 VA: 0x39B7BA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.get_Default
	|
	|-RVA: 0x39B8770 Offset: 0x39B8871 VA: 0x39B8770
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.get_Default
	|
	|-RVA: 0x39B9410 Offset: 0x39B9511 VA: 0x39B9410
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.get_Default
	|
	|-RVA: 0x39BA0B0 Offset: 0x39BA1B1 VA: 0x39BA0B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.get_Default
	|
	|-RVA: 0x39BAC80 Offset: 0x39BAD81 VA: 0x39BAC80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.get_Default
	|
	|-RVA: 0x39BB920 Offset: 0x39BBA21 VA: 0x39BB920
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.get_Default
	|
	|-RVA: 0x39BC5C0 Offset: 0x39BC6C1 VA: 0x39BC5C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_Default
	|
	|-RVA: 0x39BD260 Offset: 0x39BD361 VA: 0x39BD260
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_Default
	|
	|-RVA: 0x39BDF00 Offset: 0x39BE001 VA: 0x39BDF00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.get_Default
	|
	|-RVA: 0x39BEAD0 Offset: 0x39BEBD1 VA: 0x39BEAD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_Default
	|
	|-RVA: 0x39BF770 Offset: 0x39BF871 VA: 0x39BF770
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_Default
	|
	|-RVA: 0x39C0340 Offset: 0x39C0441 VA: 0x39C0340
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_Default
	|
	|-RVA: 0x39C0EF0 Offset: 0x39C0FF1 VA: 0x39C0EF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_Default
	|
	|-RVA: 0x39C1B90 Offset: 0x39C1C91 VA: 0x39C1B90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_Default
	|
	|-RVA: 0x39C2830 Offset: 0x39C2931 VA: 0x39C2830
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.get_Default
	|
	|-RVA: 0x39C34D0 Offset: 0x39C35D1 VA: 0x39C34D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.get_Default
	|
	|-RVA: 0x39C4170 Offset: 0x39C4271 VA: 0x39C4170
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Default
	|
	|-RVA: 0x3ADAAA0 Offset: 0x3ADABA1 VA: 0x3ADAAA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.get_Default
	|
	|-RVA: 0x3ADB730 Offset: 0x3ADB831 VA: 0x3ADB730
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Default
	|
	|-RVA: 0x3ADC4B0 Offset: 0x3ADC5B1 VA: 0x3ADC4B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_Default
	|
	|-RVA: 0x3ADD1D0 Offset: 0x3ADD2D1 VA: 0x3ADD1D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Default
	|
	|-RVA: 0x3ADDFC0 Offset: 0x3ADE0C1 VA: 0x3ADDFC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_Default
	|
	|-RVA: 0x3ADECD0 Offset: 0x3ADEDD1 VA: 0x3ADECD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Default
	|
	|-RVA: 0x3ADFB30 Offset: 0x3ADFC31 VA: 0x3ADFB30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_Default
	|
	|-RVA: 0x3AE08C0 Offset: 0x3AE09C1 VA: 0x3AE08C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Default
	|
	|-RVA: 0x3AE17A0 Offset: 0x3AE18A1 VA: 0x3AE17A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_Default
	|
	|-RVA: 0x3AE2520 Offset: 0x3AE2621 VA: 0x3AE2520
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_Default
	|
	|-RVA: 0x3AE3470 Offset: 0x3AE3571 VA: 0x3AE3470
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Default
	|
	|-RVA: 0x3AE4120 Offset: 0x3AE4221 VA: 0x3AE4120
	|-EqualityComparer<ValueTuple<bool, AsyncUnit>>.get_Default
	|
	|-RVA: 0x3AE4CB0 Offset: 0x3AE4DB1 VA: 0x3AE4CB0
	|-EqualityComparer<ValueTuple<bool, bool>>.get_Default
	|
	|-RVA: 0x3AE5840 Offset: 0x3AE5941 VA: 0x3AE5840
	|-EqualityComparer<ValueTuple<bool, Bounds>>.get_Default
	|
	|-RVA: 0x3AE6550 Offset: 0x3AE6651 VA: 0x3AE6550
	|-EqualityComparer<ValueTuple<bool, byte>>.get_Default
	|
	|-RVA: 0x3AE70E0 Offset: 0x3AE71E1 VA: 0x3AE70E0
	|-EqualityComparer<ValueTuple<bool, Color>>.get_Default
	|
	|-RVA: 0x3AE7D80 Offset: 0x3AE7E81 VA: 0x3AE7D80
	|-EqualityComparer<ValueTuple<bool, double>>.get_Default
	|
	|-RVA: 0x3AE8930 Offset: 0x3AE8A31 VA: 0x3AE8930
	|-EqualityComparer<ValueTuple<bool, int>>.get_Default
	|
	|-RVA: 0x3AE94C0 Offset: 0x3AE95C1 VA: 0x3AE94C0
	|-EqualityComparer<ValueTuple<bool, long>>.get_Default
	|
	|-RVA: 0x3AEA070 Offset: 0x3AEA171 VA: 0x3AEA070
	|-EqualityComparer<ValueTuple<bool, object>>.get_Default
	|
	|-RVA: 0x3AEAC20 Offset: 0x3AEAD21 VA: 0x3AEAC20
	|-EqualityComparer<ValueTuple<bool, Quaternion>>.get_Default
	|
	|-RVA: 0x3AEB8C0 Offset: 0x3AEB9C1 VA: 0x3AEB8C0
	|-EqualityComparer<ValueTuple<bool, Rect>>.get_Default
	|
	|-RVA: 0x3AEC560 Offset: 0x3AEC661 VA: 0x3AEC560
	|-EqualityComparer<ValueTuple<bool, float>>.get_Default
	|
	|-RVA: 0x3AED0F0 Offset: 0x3AED1F1 VA: 0x3AED0F0
	|-EqualityComparer<ValueTuple<bool, UniTask>>.get_Default
	|
	|-RVA: 0x3AEDCA0 Offset: 0x3AEDDA1 VA: 0x3AEDCA0
	|-EqualityComparer<ValueTuple<bool, Unit>>.get_Default
	|
	|-RVA: 0x3AEE830 Offset: 0x3AEE931 VA: 0x3AEE830
	|-EqualityComparer<ValueTuple<bool, Vector2>>.get_Default
	|
	|-RVA: 0x3AEF400 Offset: 0x3AEF501 VA: 0x3AEF400
	|-EqualityComparer<ValueTuple<bool, Vector3>>.get_Default
	|
	|-RVA: 0x3AEFFB0 Offset: 0x3AF00B1 VA: 0x3AEFFB0
	|-EqualityComparer<ValueTuple<bool, Vector4>>.get_Default
	|
	|-RVA: 0x3AF0C50 Offset: 0x3AF0D51 VA: 0x3AF0C50
	|-EqualityComparer<ValueTuple<int, object>>.get_Default
	|
	|-RVA: 0x3AF1800 Offset: 0x3AF1901 VA: 0x3AF1800
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.get_Default
	|
	|-RVA: 0x3AF2390 Offset: 0x3AF2491 VA: 0x3AF2390
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.get_Default
	|
	|-RVA: 0x3AF3030 Offset: 0x3AF3131 VA: 0x3AF3030
	|-EqualityComparer<ValueTuple<object, int>>.get_Default
	|
	|-RVA: 0x3AF3BE0 Offset: 0x3AF3CE1 VA: 0x3AF3BE0
	|-EqualityComparer<ValueTuple<object, object>>.get_Default
	|
	|-RVA: 0x3AF4790 Offset: 0x3AF4891 VA: 0x3AF4790
	|-EqualityComparer<ValueTuple<object, float>>.get_Default
	|
	|-RVA: 0x3AF5340 Offset: 0x3AF5441 VA: 0x3AF5340
	|-EqualityComparer<ValueTuple<Vector3, float>>.get_Default
	|
	|-RVA: 0x3AF5F50 Offset: 0x3AF6051 VA: 0x3AF5F50
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Default
	|
	|-RVA: 0x3AF6C70 Offset: 0x3AF6D71 VA: 0x3AF6C70
	|-EqualityComparer<ValueTuple<object, Int32Enum, int>>.get_Default
	|
	|-RVA: 0x3AF7820 Offset: 0x3AF7921 VA: 0x3AF7820
	|-EqualityComparer<ValueTuple<object, object, object>>.get_Default
	|
	|-RVA: 0x3AF84C0 Offset: 0x3AF85C1 VA: 0x3AF84C0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Default
	|
	|-RVA: 0x3AF9250 Offset: 0x3AF9351 VA: 0x3AF9250
	|-EqualityComparer<ValueTuple<object, int, int, int>>.get_Default
	|
	|-RVA: 0x3AF9EF0 Offset: 0x3AF9FF1 VA: 0x3AF9EF0
	|-EqualityComparer<ValueTuple<object, object, object, object>>.get_Default
	|
	|-RVA: 0x3AFAB80 Offset: 0x3AFAC81 VA: 0x3AFAB80
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Default
	|
	|-RVA: 0x3AFB980 Offset: 0x3AFBA81 VA: 0x3AFB980
	|-EqualityComparer<ValueTuple<object, object, object, object, object>>.get_Default
	|
	|-RVA: 0x3AFC6A0 Offset: 0x3AFC7A1 VA: 0x3AFC6A0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Default
	|
	|-RVA: 0x3AFD500 Offset: 0x3AFD601 VA: 0x3AFD500
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object>>.get_Default
	|
	|-RVA: 0x3AFE210 Offset: 0x3AFE311 VA: 0x3AFE210
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Default
	|
	|-RVA: 0x3BDA320 Offset: 0x3BDA421 VA: 0x3BDA320
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.get_Default
	|
	|-RVA: 0x3BDB0B0 Offset: 0x3BDB1B1 VA: 0x3BDB0B0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_Default
	|
	|-RVA: 0x3BDC000 Offset: 0x3BDC101 VA: 0x3BDC000
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Default
	|
	|-RVA: 0x3BDCCB0 Offset: 0x3BDCDB1 VA: 0x3BDCCB0
	|-EqualityComparer<AnimatorClipInfo>.get_Default
	|
	|-RVA: 0x3BDD840 Offset: 0x3BDD941 VA: 0x3BDD840
	|-EqualityComparer<AsyncOperationHandle>.get_Default
	|
	|-RVA: 0x3BDE4E0 Offset: 0x3BDE5E1 VA: 0x3BDE4E0
	|-EqualityComparer<AsyncUnit>.get_Default
	|
	|-RVA: 0x3BDF070 Offset: 0x3BDF171 VA: 0x3BDF070
	|-EqualityComparer<BoneWeight>.get_Default
	|
	|-RVA: 0x3BDFD00 Offset: 0x3BDFE01 VA: 0x3BDFD00
	|-EqualityComparer<bool>.get_Default
	|
	|-RVA: 0x3BE08A0 Offset: 0x3BE09A1 VA: 0x3BE08A0
	|-EqualityComparer<Bounds>.get_Default
	|
	|-RVA: 0x3BE1540 Offset: 0x3BE1641 VA: 0x3BE1540
	|-EqualityComparer<byte>.get_Default
	|
	|-RVA: 0x3BE20D0 Offset: 0x3BE21D1 VA: 0x3BE20D0
	|-EqualityComparer<CameraInfo>.get_Default
	|
	|-RVA: 0x3BE2C80 Offset: 0x3BE2D81 VA: 0x3BE2C80
	|-EqualityComparer<CancellationToken>.get_Default
	|
	|-RVA: 0x3BE3810 Offset: 0x3BE3911 VA: 0x3BE3810
	|-EqualityComparer<CancellationTokenRegistration>.get_Default
	|
	|-RVA: 0x3BE44B0 Offset: 0x3BE45B1 VA: 0x3BE44B0
	|-EqualityComparer<char>.get_Default
	|
	|-RVA: 0x3BE5040 Offset: 0x3BE5141 VA: 0x3BE5040
	|-EqualityComparer<Color>.get_Default
	|
	|-RVA: 0x3BE5C50 Offset: 0x3BE5D51 VA: 0x3BE5C50
	|-EqualityComparer<Color32>.get_Default
	|
	|-RVA: 0x3BE67E0 Offset: 0x3BE68E1 VA: 0x3BE67E0
	|-EqualityComparer<ColorBlock>.get_Default
	|
	|-RVA: 0x3BE7640 Offset: 0x3BE7741 VA: 0x3BE7640
	|-EqualityComparer<ConstraintSource>.get_Default
	|
	|-RVA: 0x3BE81F0 Offset: 0x3BE82F1 VA: 0x3BE81F0
	|-EqualityComparer<ContourVertex>.get_Default
	|
	|-RVA: 0x3BE8E90 Offset: 0x3BE8F91 VA: 0x3BE8E90
	|-EqualityComparer<DataStoreRatingInfo>.get_Default
	|
	|-RVA: 0x3BE9B30 Offset: 0x3BE9C31 VA: 0x3BE9B30
	|-EqualityComparer<DataStoreResult>.get_Default
	|
	|-RVA: 0x3BEA6C0 Offset: 0x3BEA7C1 VA: 0x3BEA6C0
	|-EqualityComparer<DateTime>.get_Default
	|
	|-RVA: 0x3BEB250 Offset: 0x3BEB351 VA: 0x3BEB250
	|-EqualityComparer<DateTimeOffset>.get_Default
	|
	|-RVA: 0x3BEBE00 Offset: 0x3BEBF01 VA: 0x3BEBE00
	|-EqualityComparer<Decimal>.get_Default
	|
	|-RVA: 0x3BEC9B0 Offset: 0x3BECAB1 VA: 0x3BEC9B0
	|-EqualityComparer<DiagnosticEvent>.get_Default
	|
	|-RVA: 0x3BED6C0 Offset: 0x3BED7C1 VA: 0x3BED6C0
	|-EqualityComparer<double>.get_Default
	|
	|-RVA: 0x3BEE270 Offset: 0x3BEE371 VA: 0x3BEE270
	|-EqualityComparer<FXZ>.get_Default
	|
	|-RVA: 0x3BEEE30 Offset: 0x3BEEF31 VA: 0x3BEEE30
	|-EqualityComparer<Friend>.get_Default
	|
	|-RVA: 0x3BEFAE0 Offset: 0x3BEFBE1 VA: 0x3BEFAE0
	|-EqualityComparer<GlyphRect>.get_Default
	|
	|-RVA: 0x3BF0690 Offset: 0x3BF0791 VA: 0x3BF0690
	|-EqualityComparer<Guid>.get_Default
	|
	|-RVA: 0x3BF1240 Offset: 0x3BF1341 VA: 0x3BF1240
	|-EqualityComparer<short>.get_Default
	|
	|-RVA: 0x3BF1DD0 Offset: 0x3BF1ED1 VA: 0x3BF1DD0
	|-EqualityComparer<int>.get_Default
	|
	|-RVA: 0x3BF2960 Offset: 0x3BF2A61 VA: 0x3BF2960
	|-EqualityComparer<Int32Enum>.get_Default
	|
	|-RVA: 0x3BF34F0 Offset: 0x3BF35F1 VA: 0x3BF34F0
	|-EqualityComparer<long>.get_Default
	|
	|-RVA: 0x3BF4080 Offset: 0x3BF4181 VA: 0x3BF4080
	|-EqualityComparer<Int64Enum>.get_Default
	|
	|-RVA: 0x3BF4C10 Offset: 0x3BF4D11 VA: 0x3BF4C10
	|-EqualityComparer<IntPtr>.get_Default
	|
	|-RVA: 0x3BF57A0 Offset: 0x3BF58A1 VA: 0x3BF57A0
	|-EqualityComparer<InterpretedFrameInfo>.get_Default
	|
	|-RVA: 0x3BF6350 Offset: 0x3BF6451 VA: 0x3BF6350
	|-EqualityComparer<IntervalTreeNode>.get_Default
	|
	|-RVA: 0x3BF6FF0 Offset: 0x3BF70F1 VA: 0x3BF6FF0
	|-EqualityComparer<LayerMask>.get_Default
	|
	|-RVA: 0x3BF7B80 Offset: 0x3BF7C81 VA: 0x3BF7B80
	|-EqualityComparer<LengthLimitProperties>.get_Default
	|
	|-RVA: 0x3BF8710 Offset: 0x3BF8811 VA: 0x3BF8710
	|-EqualityComparer<MapPos>.get_Default
	|
	|-RVA: 0x3BF92A0 Offset: 0x3BF93A1 VA: 0x3BF92A0
	|-EqualityComparer<Matrix4x4>.get_Default
	|
	|-RVA: 0x3BFA020 Offset: 0x3BFA121 VA: 0x3BFA020
	|-EqualityComparer<Navigation>.get_Default
	|
	|-RVA: 0x3BFAD40 Offset: 0x3BFAE41 VA: 0x3BFAD40
	|-EqualityComparer<object>.get_Default
	|-EqualityComparer<string>.get_Default
	|
	|-RVA: 0x3BFB8C0 Offset: 0x3BFB9C1 VA: 0x3BFB8C0
	|-EqualityComparer<ObjectInitializationData>.get_Default
	|
	|-RVA: 0x3BFC5D0 Offset: 0x3BFC6D1 VA: 0x3BFC5D0
	|-EqualityComparer<Playable>.get_Default
	|
	|-RVA: 0x3BB73E0 Offset: 0x3BB74E1 VA: 0x3BB73E0
	|-EqualityComparer<PlayableBinding>.get_Default
	|
	|-RVA: 0x3BB8070 Offset: 0x3BB8171 VA: 0x3BB8070
	|-EqualityComparer<PlayerLoopSystem>.get_Default
	|
	|-RVA: 0x3BB8D90 Offset: 0x3BB8E91 VA: 0x3BB8D90
	|-EqualityComparer<PlayerLoopSystemInternal>.get_Default
	|
	|-RVA: 0x3BB9AB0 Offset: 0x3BB9BB1 VA: 0x3BB9AB0
	|-EqualityComparer<Quaternion>.get_Default
	|
	|-RVA: 0x3BBA6C0 Offset: 0x3BBA7C1 VA: 0x3BBA6C0
	|-EqualityComparer<RandomSeed>.get_Default
	|
	|-RVA: 0x3BBB270 Offset: 0x3BBB371 VA: 0x3BBB270
	|-EqualityComparer<RangePositionInfo>.get_Default
	|
	|-RVA: 0x3BBBE20 Offset: 0x3BBBF21 VA: 0x3BBBE20
	|-EqualityComparer<Ranking2ChartInfoInput>.get_Default
	|
	|-RVA: 0x3BBC9B0 Offset: 0x3BBCAB1 VA: 0x3BBC9B0
	|-EqualityComparer<RaycastHit2D>.get_Default
	|
	|-RVA: 0x3BBD700 Offset: 0x3BBD801 VA: 0x3BBD700
	|-EqualityComparer<RaycastResult>.get_Default
	|
	|-RVA: 0x3BBE500 Offset: 0x3BBE601 VA: 0x3BBE500
	|-EqualityComparer<Rect>.get_Default
	|
	|-RVA: 0x3BBF110 Offset: 0x3BBF211 VA: 0x3BBF110
	|-EqualityComparer<RendererListHandle>.get_Default
	|
	|-RVA: 0x3BBFCA0 Offset: 0x3BBFDA1 VA: 0x3BBFCA0
	|-EqualityComparer<ResourceHandle>.get_Default
	|
	|-RVA: 0x3BC0830 Offset: 0x3BC0931 VA: 0x3BC0830
	|-EqualityComparer<ResourceLocator>.get_Default
	|
	|-RVA: 0x3BC13E0 Offset: 0x3BC14E1 VA: 0x3BC13E0
	|-EqualityComparer<sbyte>.get_Default
	|
	|-RVA: 0x3BC1F70 Offset: 0x3BC2071 VA: 0x3BC1F70
	|-EqualityComparer<ShaderTagId>.get_Default
	|
	|-RVA: 0x3BC2B00 Offset: 0x3BC2C01 VA: 0x3BC2B00
	|-EqualityComparer<float>.get_Default
	|
	|-RVA: 0x3BC36B0 Offset: 0x3BC37B1 VA: 0x3BC36B0
	|-EqualityComparer<SphericalHarmonicsL2>.get_Default
	|
	|-RVA: 0x3BC4600 Offset: 0x3BC4701 VA: 0x3BC4600
	|-EqualityComparer<SpriteState>.get_Default
	|
	|-RVA: 0x3BC5290 Offset: 0x3BC5391 VA: 0x3BC5290
	|-EqualityComparer<SubMeshDescriptor>.get_Default
	|
	|-RVA: 0x3BC5FA0 Offset: 0x3BC60A1 VA: 0x3BC5FA0
	|-EqualityComparer<TablePair>.get_Default
	|
	|-RVA: 0x3BC6B50 Offset: 0x3BC6C51 VA: 0x3BC6B50
	|-EqualityComparer<TimeSpan>.get_Default
	|
	|-RVA: 0x3BC76E0 Offset: 0x3BC77E1 VA: 0x3BC76E0
	|-EqualityComparer<UICharInfo>.get_Default
	|
	|-RVA: 0x3BC82E0 Offset: 0x3BC83E1 VA: 0x3BC82E0
	|-EqualityComparer<UILineInfo>.get_Default
	|
	|-RVA: 0x3BC8E90 Offset: 0x3BC8F91 VA: 0x3BC8E90
	|-EqualityComparer<UIVertex>.get_Default
	|
	|-RVA: 0x3BC9DE0 Offset: 0x3BC9EE1 VA: 0x3BC9DE0
	|-EqualityComparer<ushort>.get_Default
	|
	|-RVA: 0x3BCA970 Offset: 0x3BCAA71 VA: 0x3BCA970
	|-EqualityComparer<uint>.get_Default
	|
	|-RVA: 0x3BCB500 Offset: 0x3BCB601 VA: 0x3BCB500
	|-EqualityComparer<ulong>.get_Default
	|
	|-RVA: 0x3BCC090 Offset: 0x3BCC191 VA: 0x3BCC090
	|-EqualityComparer<UniTask>.get_Default
	|
	|-RVA: 0x3BCCC20 Offset: 0x3BCCD21 VA: 0x3BCCC20
	|-EqualityComparer<Unit>.get_Default
	|
	|-RVA: 0x3BCD7B0 Offset: 0x3BCD8B1 VA: 0x3BCD7B0
	|-EqualityComparer<Vector2>.get_Default
	|
	|-RVA: 0x3BCE370 Offset: 0x3BCE471 VA: 0x3BCE370
	|-EqualityComparer<Vector3>.get_Default
	|
	|-RVA: 0x3BCEF70 Offset: 0x3BCF071 VA: 0x3BCEF70
	|-EqualityComparer<Vector4>.get_Default
	|
	|-RVA: 0x3BCFB80 Offset: 0x3BCFC81 VA: 0x3BCFB80
	|-EqualityComparer<VertexAttributeDescriptor>.get_Default
	|
	|-RVA: 0x3BD0730 Offset: 0x3BD0831 VA: 0x3BD0730
	|-EqualityComparer<X509ChainStatus>.get_Default
	|
	|-RVA: 0x3BD12E0 Offset: 0x3BD13E1 VA: 0x3BD12E0
	|-EqualityComparer<XPathNodeRef>.get_Default
	|
	|-RVA: 0x3BD1E90 Offset: 0x3BD1F91 VA: 0x3BD1E90
	|-EqualityComparer<XRView>.get_Default
	|
	|-RVA: 0x3BD2B40 Offset: 0x3BD2C41 VA: 0x3BD2B40
	|-EqualityComparer<AmiiboSequence.GainItemData>.get_Default
	|
	|-RVA: 0x3BD36F0 Offset: 0x3BD37F1 VA: 0x3BD36F0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.get_Default
	|
	|-RVA: 0x3BD4410 Offset: 0x3BD4511 VA: 0x3BD4410
	|-EqualityComparer<ArenaOrderSequence.GodInfo>.get_Default
	|
	|-RVA: 0x3BD4FC0 Offset: 0x3BD50C1 VA: 0x3BD4FC0
	|-EqualityComparer<BattleInfo.SupportData>.get_Default
	|
	|-RVA: 0x3BD5B70 Offset: 0x3BD5C71 VA: 0x3BD5B70
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.get_Default
	|
	|-RVA: 0x3BD6720 Offset: 0x3BD6821 VA: 0x3BD6720
	|-EqualityComparer<Camera.RenderRequest>.get_Default
	|
	|-RVA: 0x3BD73C0 Offset: 0x3BD74C1 VA: 0x3BD73C0
	|-EqualityComparer<CameraState.CustomBlendable>.get_Default
	|
	|-RVA: 0x3BD7F70 Offset: 0x3BD8071 VA: 0x3BD7F70
	|-EqualityComparer<CinemachineClearShot.Pair>.get_Default
	|
	|-RVA: 0x3BD8B00 Offset: 0x3BD8C01 VA: 0x3BD8B00
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.get_Default
	|
	|-RVA: 0x3BD9690 Offset: 0x3BD9791 VA: 0x3BD9690
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.get_Default
	|
	|-RVA: 0x3B78B40 Offset: 0x3B78C41 VA: 0x3B78B40
	|-EqualityComparer<Detail.AsyncResultInt>.get_Default
	|
	|-RVA: 0x3B79850 Offset: 0x3B79951 VA: 0x3B79850
	|-EqualityComparer<Detail.CppArray>.get_Default
	|
	|-RVA: 0x3B7A400 Offset: 0x3B7A501 VA: 0x3B7A400
	|-EqualityComparer<Detail.NotificationEventInt>.get_Default
	|
	|-RVA: 0x3B7B110 Offset: 0x3B7B211 VA: 0x3B7B110
	|-EqualityComparer<DragonRideTargetGroup.ChainParam>.get_Default
	|
	|-RVA: 0x3B7BCC0 Offset: 0x3B7BDC1 VA: 0x3B7BCC0
	|-EqualityComparer<DynamicMesh.State>.get_Default
	|
	|-RVA: 0x3B7C850 Offset: 0x3B7C951 VA: 0x3B7C850
	|-EqualityComparer<GameVariable.Value>.get_Default
	|
	|-RVA: 0x3B7D400 Offset: 0x3B7D501 VA: 0x3B7D400
	|-EqualityComparer<GmapPathAdjuster.TargetModel>.get_Default
	|
	|-RVA: 0x3B7E0A0 Offset: 0x3B7E1A1 VA: 0x3B7E0A0
	|-EqualityComparer<GmapSpotAdjuster.TargetModel>.get_Default
	|
	|-RVA: 0x3B7ED40 Offset: 0x3B7EE41 VA: 0x3B7ED40
	|-EqualityComparer<HubFastTravel.Location>.get_Default
	|
	|-RVA: 0x3B7F9E0 Offset: 0x3B7FAE1 VA: 0x3B7F9E0
	|-EqualityComparer<HubLensFlare.Flare>.get_Default
	|
	|-RVA: 0x3B806F0 Offset: 0x3B807F1 VA: 0x3B806F0
	|-EqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.get_Default
	|
	|-RVA: 0x3B812A0 Offset: 0x3B813A1 VA: 0x3B812A0
	|-EqualityComparer<Map.Pos>.get_Default
	|
	|-RVA: 0x3B81E30 Offset: 0x3B81F31 VA: 0x3B81E30
	|-EqualityComparer<MapImage.BackupTerrain>.get_Default
	|
	|-RVA: 0x3B829E0 Offset: 0x3B82AE1 VA: 0x3B829E0
	|-EqualityComparer<MapImageRange.Pos>.get_Default
	|
	|-RVA: 0x3B83570 Offset: 0x3B83671 VA: 0x3B83570
	|-EqualityComparer<MapMind.Record>.get_Default
	|
	|-RVA: 0x3B84370 Offset: 0x3B84471 VA: 0x3B84370
	|-EqualityComparer<MapMind.Target>.get_Default
	|
	|-RVA: 0x3B85010 Offset: 0x3B85111 VA: 0x3B85010
	|-EqualityComparer<MapPanelDebug.Entity>.get_Default
	|
	|-RVA: 0x3B85CB0 Offset: 0x3B85DB1 VA: 0x3B85CB0
	|-EqualityComparer<NexRanking.Data>.get_Default
	|
	|-RVA: 0x3B86840 Offset: 0x3B86941 VA: 0x3B86840
	|-EqualityComparer<NexVersus.RatingData>.get_Default
	|
	|-RVA: 0x3B873F0 Offset: 0x3B874F1 VA: 0x3B873F0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Default
	|
	|-RVA: 0x3B87FA0 Offset: 0x3B880A1 VA: 0x3B87FA0
	|-EqualityComparer<ParticleSystem.Particle>.get_Default
	|
	|-RVA: 0x3B88C50 Offset: 0x3B88D51 VA: 0x3B88C50
	|-EqualityComparer<QualitySettingsStack.Settings>.get_Default
	|
	|-RVA: 0x3B89960 Offset: 0x3B89A61 VA: 0x3B89960
	|-EqualityComparer<RangeData.Offset>.get_Default
	|
	|-RVA: 0x3B8A4F0 Offset: 0x3B8A5F1 VA: 0x3B8A4F0
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.get_Default
	|
	|-RVA: 0x3B8B180 Offset: 0x3B8B281 VA: 0x3B8B180
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.get_Default
	|
	|-RVA: 0x3B8BEA0 Offset: 0x3B8BFA1 VA: 0x3B8BEA0
	|-EqualityComparer<RingCleaningUnitSelectMenu.GodParam>.get_Default
	|
	|-RVA: 0x3B8CA50 Offset: 0x3B8CB51 VA: 0x3B8CA50
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.get_Default
	|
	|-RVA: 0x3B8D770 Offset: 0x3B8D871 VA: 0x3B8D770
	|-EqualityComparer<ShadowUtility.Edge>.get_Default
	|
	|-RVA: 0x3B8E480 Offset: 0x3B8E581 VA: 0x3B8E480
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.get_Default
	|
	|-RVA: 0x3B8F030 Offset: 0x3B8F131 VA: 0x3B8F030
	|-EqualityComparer<SkillArray.Entity>.get_Default
	|
	|-RVA: 0x3B8FBC0 Offset: 0x3B8FCC1 VA: 0x3B8FBC0
	|-EqualityComparer<Stream.Info>.get_Default
	|
	|-RVA: 0x3B90790 Offset: 0x3B90891 VA: 0x3B90790
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.get_Default
	|
	|-RVA: 0x3B91510 Offset: 0x3B91611 VA: 0x3B91510
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.get_Default
	|
	|-RVA: 0x3B921B0 Offset: 0x3B922B1 VA: 0x3B921B0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.get_Default
	|
	|-RVA: 0x3B92E50 Offset: 0x3B92F51 VA: 0x3B92E50
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Default
	|
	|-RVA: 0x3B93A00 Offset: 0x3B93B01 VA: 0x3B93A00
	|-EqualityComparer<AIThink.EnchantThink.SurroundingInfo>.get_Default
	|
	|-RVA: 0x3B94590 Offset: 0x3B94691 VA: 0x3B94590
	|-EqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.get_Default
	|
	|-RVA: 0x3B95140 Offset: 0x3B95241 VA: 0x3B95140
	|-EqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.get_Default
	|
	|-RVA: 0x3B95DF0 Offset: 0x3B95EF1 VA: 0x3B95DF0
	|-EqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.get_Default
	|
	|-RVA: 0x3B969A0 Offset: 0x3B96AA1 VA: 0x3B969A0
	|-EqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.get_Default
	|
	|-RVA: 0x3B976C0 Offset: 0x3B977C1 VA: 0x3B976C0
	|-EqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.get_Default
	|
	|-RVA: 0x3B98370 Offset: 0x3B98471 VA: 0x3B98370
	|-EqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.get_Default
	|
	|-RVA: 0x3B99010 Offset: 0x3B99111 VA: 0x3B99010
	|-EqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.get_Default
	|
	|-RVA: 0x3B99CB0 Offset: 0x3B99DB1 VA: 0x3B99CB0
	|-EqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.get_Default
	|
	|-RVA: 0x3B9A960 Offset: 0x3B9AA61 VA: 0x3B9A960
	|-EqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.get_Default
	|
	|-RVA: 0x3B9B510 Offset: 0x3B9B611 VA: 0x3B9B510
	|-EqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.get_Default
	|
	|-RVA: 0x33BC830 Offset: 0x33BC931 VA: 0x33BC830
	|-EqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.get_Default
	|
	|-RVA: 0x33BD3E0 Offset: 0x33BD4E1 VA: 0x33BD3E0
	|-EqualityComparer<Detail.Ranking.RankingCachedResultInt>.get_Default
	|
	|-RVA: 0x33BE170 Offset: 0x33BE271 VA: 0x33BE170
	|-EqualityComparer<Detail.Ranking.RankingOrderParamInt>.get_Default
	|
	|-RVA: 0x33BED20 Offset: 0x33BEE21 VA: 0x33BED20
	|-EqualityComparer<Detail.Ranking.RankingRankDataInt>.get_Default
	|
	|-RVA: 0x33BFAA0 Offset: 0x33BFBA1 VA: 0x33BFAA0
	|-EqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.get_Default
	|
	|-RVA: 0x33C0900 Offset: 0x33C0A01 VA: 0x33C0900
	|-EqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.get_Default
	|
	|-RVA: 0x33C1680 Offset: 0x33C1781 VA: 0x33C1680
	|-EqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.get_Default
	|
	|-RVA: 0x33C2230 Offset: 0x33C2331 VA: 0x33C2230
	|-EqualityComparer<Detail.Screening.ScreeningContextInfoInt>.get_Default
	|
	|-RVA: 0x33C2EC0 Offset: 0x33C2FC1 VA: 0x33C2EC0
	|-EqualityComparer<Detail.Subscriber.SubscriberContentInt>.get_Default
	|
	|-RVA: 0x33C3CC0 Offset: 0x33C3DC1 VA: 0x33C3CC0
	|-EqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.get_Default
	|
	|-RVA: 0x33C4960 Offset: 0x33C4A61 VA: 0x33C4960
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.get_Default
	|
	|-RVA: 0x33C5680 Offset: 0x33C5781 VA: 0x33C5680
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.get_Default
	|
	|-RVA: 0x33C6320 Offset: 0x33C6421 VA: 0x33C6320
	|-EqualityComparer<Detail.Utility.IntegerSettings>.get_Default
	|
	|-RVA: 0x33C6EB0 Offset: 0x33C6FB1 VA: 0x33C6EB0
	|-EqualityComparer<Detail.Utility.UniqueIdInfoInt>.get_Default
	|
	|-RVA: 0x33C7A60 Offset: 0x33C7B61 VA: 0x33C7A60
	|-EqualityComparer<MapHistory.Rewind.LatestInspectorData>.get_Default
	|
	|-RVA: 0x33C8630 Offset: 0x33C8731 VA: 0x33C8630
	|-EqualityComparer<MapHistory.Rewind.WorkTerrainData>.get_Default
	|
	|-RVA: 0x33C9200 Offset: 0x33C9301 VA: 0x33C9200
	|-EqualityComparer<MapSkill.AroundCalculator.Result>.get_Default
	|
	|-RVA: 0x33C9DB0 Offset: 0x33C9EB1 VA: 0x33C9DB0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.get_Default
	|
	|-RVA: 0x33CAAC0 Offset: 0x33CABC1 VA: 0x33CAAC0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.get_Default
	|
	|-RVA: 0x33CB810 Offset: 0x33CB911 VA: 0x33CB810
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static EqualityComparer<T> CreateComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3768210 Offset: 0x3768311 VA: 0x3768210
	|-EqualityComparer<AsyncOperationHandle<object>>.CreateComparer
	|
	|-RVA: 0x3768EB0 Offset: 0x3768FB1 VA: 0x3768EB0
	|-EqualityComparer<IntervalTree.Entry<object>>.CreateComparer
	|
	|-RVA: 0x3769B50 Offset: 0x3769C51 VA: 0x3769B50
	|-EqualityComparer<KeyValuePair<DateTime, object>>.CreateComparer
	|
	|-RVA: 0x376A700 Offset: 0x376A801 VA: 0x376A700
	|-EqualityComparer<KeyValuePair<int, object>>.CreateComparer
	|
	|-RVA: 0x376B2B0 Offset: 0x376B3B1 VA: 0x376B2B0
	|-EqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.CreateComparer
	|
	|-RVA: 0x376BF40 Offset: 0x376C041 VA: 0x376BF40
	|-EqualityComparer<KeyValuePair<object, object>>.CreateComparer
	|
	|-RVA: 0x376CAF0 Offset: 0x376CBF1 VA: 0x376CAF0
	|-EqualityComparer<CommonBattleSequence.Reliance<object>>.CreateComparer
	|
	|-RVA: 0x376D790 Offset: 0x376D891 VA: 0x376D790
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.CreateComparer
	|
	|-RVA: 0x376E340 Offset: 0x376E441 VA: 0x376E340
	|-EqualityComparer<TimeInterval<object>>.CreateComparer
	|
	|-RVA: 0x376EEF0 Offset: 0x376EFF1 VA: 0x376EEF0
	|-EqualityComparer<Timestamped<object>>.CreateComparer
	|
	|-RVA: 0x376FB90 Offset: 0x376FC91 VA: 0x376FB90
	|-EqualityComparer<UniTask<object>>.CreateComparer
	|
	|-RVA: 0x3770740 Offset: 0x3770841 VA: 0x3770740
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>>>.CreateComparer
	|
	|-RVA: 0x37712F0 Offset: 0x37713F1 VA: 0x37712F0
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.CreateComparer
	|
	|-RVA: 0x3771F80 Offset: 0x3772081 VA: 0x3771F80
	|-EqualityComparer<ValueTuple<bool, UniTask<object>>>.CreateComparer
	|
	|-RVA: 0x3772C20 Offset: 0x3772D21 VA: 0x3772C20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.CreateComparer
	|
	|-RVA: 0x37738B0 Offset: 0x37739B1 VA: 0x37738B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.CreateComparer
	|
	|-RVA: 0x37745D0 Offset: 0x37746D1 VA: 0x37745D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.CreateComparer
	|
	|-RVA: 0x37752E0 Offset: 0x37753E1 VA: 0x37752E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.CreateComparer
	|
	|-RVA: 0x3775EB0 Offset: 0x3775FB1 VA: 0x3775EB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.CreateComparer
	|
	|-RVA: 0x3776A80 Offset: 0x3776B81 VA: 0x3776A80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.CreateComparer
	|
	|-RVA: 0x3777800 Offset: 0x3777901 VA: 0x3777800
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.CreateComparer
	|
	|-RVA: 0x37783D0 Offset: 0x37784D1 VA: 0x37783D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.CreateComparer
	|
	|-RVA: 0x3779120 Offset: 0x3779221 VA: 0x3779120
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.CreateComparer
	|
	|-RVA: 0x3779E30 Offset: 0x3779F31 VA: 0x3779E30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.CreateComparer
	|
	|-RVA: 0x377AAD0 Offset: 0x377ABD1 VA: 0x377AAD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.CreateComparer
	|
	|-RVA: 0x377B7E0 Offset: 0x377B8E1 VA: 0x377B7E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.CreateComparer
	|
	|-RVA: 0x377C4F0 Offset: 0x377C5F1 VA: 0x377C4F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.CreateComparer
	|
	|-RVA: 0x377D240 Offset: 0x377D341 VA: 0x377D240
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.CreateComparer
	|
	|-RVA: 0x377DF90 Offset: 0x377E091 VA: 0x377DF90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.CreateComparer
	|
	|-RVA: 0x37E7D80 Offset: 0x37E7E81 VA: 0x37E7D80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.CreateComparer
	|
	|-RVA: 0x37E8A90 Offset: 0x37E8B91 VA: 0x37E8A90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.CreateComparer
	|
	|-RVA: 0x37E9660 Offset: 0x37E9761 VA: 0x37E9660
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.CreateComparer
	|
	|-RVA: 0x37EA370 Offset: 0x37EA471 VA: 0x37EA370
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.CreateComparer
	|
	|-RVA: 0x37EB000 Offset: 0x37EB101 VA: 0x37EB000
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.CreateComparer
	|
	|-RVA: 0x37EBD50 Offset: 0x37EBE51 VA: 0x37EBD50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.CreateComparer
	|
	|-RVA: 0x37ECA60 Offset: 0x37ECB61 VA: 0x37ECA60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.CreateComparer
	|
	|-RVA: 0x37ED770 Offset: 0x37ED871 VA: 0x37ED770
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.CreateComparer
	|
	|-RVA: 0x37EE500 Offset: 0x37EE601 VA: 0x37EE500
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.CreateComparer
	|
	|-RVA: 0x37EF280 Offset: 0x37EF381 VA: 0x37EF280
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.CreateComparer
	|
	|-RVA: 0x37F0080 Offset: 0x37F0181 VA: 0x37F0080
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.CreateComparer
	|
	|-RVA: 0x37F0E70 Offset: 0x37F0F71 VA: 0x37F0E70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.CreateComparer
	|
	|-RVA: 0x37F1CD0 Offset: 0x37F1DD1 VA: 0x37F1CD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.CreateComparer
	|
	|-RVA: 0x37F28A0 Offset: 0x37F29A1 VA: 0x37F28A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.CreateComparer
	|
	|-RVA: 0x37F3470 Offset: 0x37F3571 VA: 0x37F3470
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.CreateComparer
	|
	|-RVA: 0x37F4190 Offset: 0x37F4291 VA: 0x37F4190
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.CreateComparer
	|
	|-RVA: 0x37F4D60 Offset: 0x37F4E61 VA: 0x37F4D60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.CreateComparer
	|
	|-RVA: 0x37F59F0 Offset: 0x37F5AF1 VA: 0x37F59F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.CreateComparer
	|
	|-RVA: 0x37F6710 Offset: 0x37F6811 VA: 0x37F6710
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.CreateComparer
	|
	|-RVA: 0x37F73B0 Offset: 0x37F74B1 VA: 0x37F73B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.CreateComparer
	|
	|-RVA: 0x37F80D0 Offset: 0x37F81D1 VA: 0x37F80D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.CreateComparer
	|
	|-RVA: 0x37F8DF0 Offset: 0x37F8EF1 VA: 0x37F8DF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.CreateComparer
	|
	|-RVA: 0x37F9A80 Offset: 0x37F9B81 VA: 0x37F9A80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.CreateComparer
	|
	|-RVA: 0x37FA710 Offset: 0x37FA811 VA: 0x37FA710
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.CreateComparer
	|
	|-RVA: 0x37FB3B0 Offset: 0x37FB4B1 VA: 0x37FB3B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.CreateComparer
	|
	|-RVA: 0x37FC0D0 Offset: 0x37FC1D1 VA: 0x37FC0D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.CreateComparer
	|
	|-RVA: 0x37FCCA0 Offset: 0x37FCDA1 VA: 0x37FCCA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.CreateComparer
	|
	|-RVA: 0x37FD940 Offset: 0x37FDA41 VA: 0x37FD940
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.CreateComparer
	|
	|-RVA: 0x37FE650 Offset: 0x37FE751 VA: 0x37FE650
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.CreateComparer
	|
	|-RVA: 0x37FF2E0 Offset: 0x37FF3E1 VA: 0x37FF2E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.CreateComparer
	|
	|-RVA: 0x3800000 Offset: 0x3800101 VA: 0x3800000
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.CreateComparer
	|
	|-RVA: 0x3800D20 Offset: 0x3800E21 VA: 0x3800D20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CreateComparer
	|
	|-RVA: 0x3801AA0 Offset: 0x3801BA1 VA: 0x3801AA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.CreateComparer
	|
	|-RVA: 0x38027B0 Offset: 0x38028B1 VA: 0x38027B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CreateComparer
	|
	|-RVA: 0x38035A0 Offset: 0x38036A1 VA: 0x38035A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.CreateComparer
	|
	|-RVA: 0x3804330 Offset: 0x3804431 VA: 0x3804330
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CreateComparer
	|
	|-RVA: 0x3805190 Offset: 0x3805291 VA: 0x3805190
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.CreateComparer
	|
	|-RVA: 0x3805F10 Offset: 0x3806011 VA: 0x3805F10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CreateComparer
	|
	|-RVA: 0x3806DF0 Offset: 0x3806EF1 VA: 0x3806DF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.CreateComparer
	|
	|-RVA: 0x3807BF0 Offset: 0x3807CF1 VA: 0x3807BF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CreateComparer
	|
	|-RVA: 0x3808B40 Offset: 0x3808C41 VA: 0x3808B40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.CreateComparer
	|
	|-RVA: 0x3809930 Offset: 0x3809A31 VA: 0x3809930
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.CreateComparer
	|
	|-RVA: 0x380A4C0 Offset: 0x380A5C1 VA: 0x380A4C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.CreateComparer
	|
	|-RVA: 0x380B050 Offset: 0x380B151 VA: 0x380B050
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.CreateComparer
	|
	|-RVA: 0x380BDA0 Offset: 0x380BEA1 VA: 0x380BDA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.CreateComparer
	|
	|-RVA: 0x380C930 Offset: 0x380CA31 VA: 0x380C930
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.CreateComparer
	|
	|-RVA: 0x39A0500 Offset: 0x39A0601 VA: 0x39A0500
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.CreateComparer
	|
	|-RVA: 0x39A1190 Offset: 0x39A1291 VA: 0x39A1190
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.CreateComparer
	|
	|-RVA: 0x39A1D40 Offset: 0x39A1E41 VA: 0x39A1D40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.CreateComparer
	|
	|-RVA: 0x39A29D0 Offset: 0x39A2AD1 VA: 0x39A29D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.CreateComparer
	|
	|-RVA: 0x39A3660 Offset: 0x39A3761 VA: 0x39A3660
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.CreateComparer
	|
	|-RVA: 0x39A4370 Offset: 0x39A4471 VA: 0x39A4370
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.CreateComparer
	|
	|-RVA: 0x39A5080 Offset: 0x39A5181 VA: 0x39A5080
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.CreateComparer
	|
	|-RVA: 0x39A5C30 Offset: 0x39A5D31 VA: 0x39A5C30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.CreateComparer
	|
	|-RVA: 0x39A68C0 Offset: 0x39A69C1 VA: 0x39A68C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.CreateComparer
	|
	|-RVA: 0x39A7450 Offset: 0x39A7551 VA: 0x39A7450
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.CreateComparer
	|
	|-RVA: 0x39A80F0 Offset: 0x39A81F1 VA: 0x39A80F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.CreateComparer
	|
	|-RVA: 0x39A8D90 Offset: 0x39A8E91 VA: 0x39A8D90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.CreateComparer
	|
	|-RVA: 0x39A9AA0 Offset: 0x39A9BA1 VA: 0x39A9AA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.CreateComparer
	|
	|-RVA: 0x39AA730 Offset: 0x39AA831 VA: 0x39AA730
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.CreateComparer
	|
	|-RVA: 0x39AB3C0 Offset: 0x39AB4C1 VA: 0x39AB3C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CreateComparer
	|
	|-RVA: 0x39AC150 Offset: 0x39AC251 VA: 0x39AC150
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.CreateComparer
	|
	|-RVA: 0x39ACE70 Offset: 0x39ACF71 VA: 0x39ACE70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CreateComparer
	|
	|-RVA: 0x39ADC70 Offset: 0x39ADD71 VA: 0x39ADC70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.CreateComparer
	|
	|-RVA: 0x39AE980 Offset: 0x39AEA81 VA: 0x39AE980
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CreateComparer
	|
	|-RVA: 0x39AF7E0 Offset: 0x39AF8E1 VA: 0x39AF7E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.CreateComparer
	|
	|-RVA: 0x39B0570 Offset: 0x39B0671 VA: 0x39B0570
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CreateComparer
	|
	|-RVA: 0x39B1450 Offset: 0x39B1551 VA: 0x39B1450
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.CreateComparer
	|
	|-RVA: 0x39B21D0 Offset: 0x39B22D1 VA: 0x39B21D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CreateComparer
	|
	|-RVA: 0x39B3120 Offset: 0x39B3221 VA: 0x39B3120
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.CreateComparer
	|
	|-RVA: 0x39B3F20 Offset: 0x39B4021 VA: 0x39B3F20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.CreateComparer
	|
	|-RVA: 0x39B4BD0 Offset: 0x39B4CD1 VA: 0x39B4BD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.CreateComparer
	|
	|-RVA: 0x39B5880 Offset: 0x39B5981 VA: 0x39B5880
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.CreateComparer
	|
	|-RVA: 0x39B6450 Offset: 0x39B6551 VA: 0x39B6450
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.CreateComparer
	|
	|-RVA: 0x39B7020 Offset: 0x39B7121 VA: 0x39B7020
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.CreateComparer
	|
	|-RVA: 0x39B7CB0 Offset: 0x39B7DB1 VA: 0x39B7CB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.CreateComparer
	|
	|-RVA: 0x39B8880 Offset: 0x39B8981 VA: 0x39B8880
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.CreateComparer
	|
	|-RVA: 0x39B9520 Offset: 0x39B9621 VA: 0x39B9520
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.CreateComparer
	|
	|-RVA: 0x39BA1C0 Offset: 0x39BA2C1 VA: 0x39BA1C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.CreateComparer
	|
	|-RVA: 0x39BAD90 Offset: 0x39BAE91 VA: 0x39BAD90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.CreateComparer
	|
	|-RVA: 0x39BBA30 Offset: 0x39BBB31 VA: 0x39BBA30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.CreateComparer
	|
	|-RVA: 0x39BC6D0 Offset: 0x39BC7D1 VA: 0x39BC6D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.CreateComparer
	|
	|-RVA: 0x39BD370 Offset: 0x39BD471 VA: 0x39BD370
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.CreateComparer
	|
	|-RVA: 0x39BE010 Offset: 0x39BE111 VA: 0x39BE010
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.CreateComparer
	|
	|-RVA: 0x39BEBE0 Offset: 0x39BECE1 VA: 0x39BEBE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.CreateComparer
	|
	|-RVA: 0x39BF880 Offset: 0x39BF981 VA: 0x39BF880
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.CreateComparer
	|
	|-RVA: 0x39C0450 Offset: 0x39C0551 VA: 0x39C0450
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.CreateComparer
	|
	|-RVA: 0x39C1000 Offset: 0x39C1101 VA: 0x39C1000
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.CreateComparer
	|
	|-RVA: 0x39C1CA0 Offset: 0x39C1DA1 VA: 0x39C1CA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.CreateComparer
	|
	|-RVA: 0x39C2940 Offset: 0x39C2A41 VA: 0x39C2940
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.CreateComparer
	|
	|-RVA: 0x39C35E0 Offset: 0x39C36E1 VA: 0x39C35E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.CreateComparer
	|
	|-RVA: 0x39C4280 Offset: 0x39C4381 VA: 0x39C4280
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CreateComparer
	|
	|-RVA: 0x3ADABB0 Offset: 0x3ADACB1 VA: 0x3ADABB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.CreateComparer
	|
	|-RVA: 0x3ADB840 Offset: 0x3ADB941 VA: 0x3ADB840
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CreateComparer
	|
	|-RVA: 0x3ADC5C0 Offset: 0x3ADC6C1 VA: 0x3ADC5C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.CreateComparer
	|
	|-RVA: 0x3ADD2E0 Offset: 0x3ADD3E1 VA: 0x3ADD2E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CreateComparer
	|
	|-RVA: 0x3ADE0D0 Offset: 0x3ADE1D1 VA: 0x3ADE0D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.CreateComparer
	|
	|-RVA: 0x3ADEDE0 Offset: 0x3ADEEE1 VA: 0x3ADEDE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CreateComparer
	|
	|-RVA: 0x3ADFC40 Offset: 0x3ADFD41 VA: 0x3ADFC40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.CreateComparer
	|
	|-RVA: 0x3AE09D0 Offset: 0x3AE0AD1 VA: 0x3AE09D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CreateComparer
	|
	|-RVA: 0x3AE18B0 Offset: 0x3AE19B1 VA: 0x3AE18B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.CreateComparer
	|
	|-RVA: 0x3AE2630 Offset: 0x3AE2731 VA: 0x3AE2630
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.CreateComparer
	|
	|-RVA: 0x3AE3580 Offset: 0x3AE3681 VA: 0x3AE3580
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.CreateComparer
	|
	|-RVA: 0x3AE4230 Offset: 0x3AE4331 VA: 0x3AE4230
	|-EqualityComparer<ValueTuple<bool, AsyncUnit>>.CreateComparer
	|
	|-RVA: 0x3AE4DC0 Offset: 0x3AE4EC1 VA: 0x3AE4DC0
	|-EqualityComparer<ValueTuple<bool, bool>>.CreateComparer
	|
	|-RVA: 0x3AE5950 Offset: 0x3AE5A51 VA: 0x3AE5950
	|-EqualityComparer<ValueTuple<bool, Bounds>>.CreateComparer
	|
	|-RVA: 0x3AE6660 Offset: 0x3AE6761 VA: 0x3AE6660
	|-EqualityComparer<ValueTuple<bool, byte>>.CreateComparer
	|
	|-RVA: 0x3AE71F0 Offset: 0x3AE72F1 VA: 0x3AE71F0
	|-EqualityComparer<ValueTuple<bool, Color>>.CreateComparer
	|
	|-RVA: 0x3AE7E90 Offset: 0x3AE7F91 VA: 0x3AE7E90
	|-EqualityComparer<ValueTuple<bool, double>>.CreateComparer
	|
	|-RVA: 0x3AE8A40 Offset: 0x3AE8B41 VA: 0x3AE8A40
	|-EqualityComparer<ValueTuple<bool, int>>.CreateComparer
	|
	|-RVA: 0x3AE95D0 Offset: 0x3AE96D1 VA: 0x3AE95D0
	|-EqualityComparer<ValueTuple<bool, long>>.CreateComparer
	|
	|-RVA: 0x3AEA180 Offset: 0x3AEA281 VA: 0x3AEA180
	|-EqualityComparer<ValueTuple<bool, object>>.CreateComparer
	|
	|-RVA: 0x3AEAD30 Offset: 0x3AEAE31 VA: 0x3AEAD30
	|-EqualityComparer<ValueTuple<bool, Quaternion>>.CreateComparer
	|
	|-RVA: 0x3AEB9D0 Offset: 0x3AEBAD1 VA: 0x3AEB9D0
	|-EqualityComparer<ValueTuple<bool, Rect>>.CreateComparer
	|
	|-RVA: 0x3AEC670 Offset: 0x3AEC771 VA: 0x3AEC670
	|-EqualityComparer<ValueTuple<bool, float>>.CreateComparer
	|
	|-RVA: 0x3AED200 Offset: 0x3AED301 VA: 0x3AED200
	|-EqualityComparer<ValueTuple<bool, UniTask>>.CreateComparer
	|
	|-RVA: 0x3AEDDB0 Offset: 0x3AEDEB1 VA: 0x3AEDDB0
	|-EqualityComparer<ValueTuple<bool, Unit>>.CreateComparer
	|
	|-RVA: 0x3AEE940 Offset: 0x3AEEA41 VA: 0x3AEE940
	|-EqualityComparer<ValueTuple<bool, Vector2>>.CreateComparer
	|
	|-RVA: 0x3AEF510 Offset: 0x3AEF611 VA: 0x3AEF510
	|-EqualityComparer<ValueTuple<bool, Vector3>>.CreateComparer
	|
	|-RVA: 0x3AF00C0 Offset: 0x3AF01C1 VA: 0x3AF00C0
	|-EqualityComparer<ValueTuple<bool, Vector4>>.CreateComparer
	|
	|-RVA: 0x3AF0D60 Offset: 0x3AF0E61 VA: 0x3AF0D60
	|-EqualityComparer<ValueTuple<int, object>>.CreateComparer
	|
	|-RVA: 0x3AF1910 Offset: 0x3AF1A11 VA: 0x3AF1910
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x3AF24A0 Offset: 0x3AF25A1 VA: 0x3AF24A0
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.CreateComparer
	|
	|-RVA: 0x3AF3140 Offset: 0x3AF3241 VA: 0x3AF3140
	|-EqualityComparer<ValueTuple<object, int>>.CreateComparer
	|
	|-RVA: 0x3AF3CF0 Offset: 0x3AF3DF1 VA: 0x3AF3CF0
	|-EqualityComparer<ValueTuple<object, object>>.CreateComparer
	|
	|-RVA: 0x3AF48A0 Offset: 0x3AF49A1 VA: 0x3AF48A0
	|-EqualityComparer<ValueTuple<object, float>>.CreateComparer
	|
	|-RVA: 0x3AF5450 Offset: 0x3AF5551 VA: 0x3AF5450
	|-EqualityComparer<ValueTuple<Vector3, float>>.CreateComparer
	|
	|-RVA: 0x3AF6060 Offset: 0x3AF6161 VA: 0x3AF6060
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.CreateComparer
	|
	|-RVA: 0x3AF6D80 Offset: 0x3AF6E81 VA: 0x3AF6D80
	|-EqualityComparer<ValueTuple<object, Int32Enum, int>>.CreateComparer
	|
	|-RVA: 0x3AF7930 Offset: 0x3AF7A31 VA: 0x3AF7930
	|-EqualityComparer<ValueTuple<object, object, object>>.CreateComparer
	|
	|-RVA: 0x3AF85D0 Offset: 0x3AF86D1 VA: 0x3AF85D0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.CreateComparer
	|
	|-RVA: 0x3AF9360 Offset: 0x3AF9461 VA: 0x3AF9360
	|-EqualityComparer<ValueTuple<object, int, int, int>>.CreateComparer
	|
	|-RVA: 0x3AFA000 Offset: 0x3AFA101 VA: 0x3AFA000
	|-EqualityComparer<ValueTuple<object, object, object, object>>.CreateComparer
	|
	|-RVA: 0x3AFAC90 Offset: 0x3AFAD91 VA: 0x3AFAC90
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.CreateComparer
	|
	|-RVA: 0x3AFBA90 Offset: 0x3AFBB91 VA: 0x3AFBA90
	|-EqualityComparer<ValueTuple<object, object, object, object, object>>.CreateComparer
	|
	|-RVA: 0x3AFC7B0 Offset: 0x3AFC8B1 VA: 0x3AFC7B0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.CreateComparer
	|
	|-RVA: 0x3AFD610 Offset: 0x3AFD711 VA: 0x3AFD610
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object>>.CreateComparer
	|
	|-RVA: 0x3AFE320 Offset: 0x3AFE421 VA: 0x3AFE320
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.CreateComparer
	|
	|-RVA: 0x3BDA430 Offset: 0x3BDA531 VA: 0x3BDA430
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.CreateComparer
	|
	|-RVA: 0x3BDB1C0 Offset: 0x3BDB2C1 VA: 0x3BDB1C0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.CreateComparer
	|
	|-RVA: 0x3BDC110 Offset: 0x3BDC211 VA: 0x3BDC110
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.CreateComparer
	|
	|-RVA: 0x3BDCDC0 Offset: 0x3BDCEC1 VA: 0x3BDCDC0
	|-EqualityComparer<AnimatorClipInfo>.CreateComparer
	|
	|-RVA: 0x3BDD950 Offset: 0x3BDDA51 VA: 0x3BDD950
	|-EqualityComparer<AsyncOperationHandle>.CreateComparer
	|
	|-RVA: 0x3BDE5F0 Offset: 0x3BDE6F1 VA: 0x3BDE5F0
	|-EqualityComparer<AsyncUnit>.CreateComparer
	|
	|-RVA: 0x3BDF180 Offset: 0x3BDF281 VA: 0x3BDF180
	|-EqualityComparer<BoneWeight>.CreateComparer
	|
	|-RVA: 0x3BDFE10 Offset: 0x3BDFF11 VA: 0x3BDFE10
	|-EqualityComparer<bool>.CreateComparer
	|
	|-RVA: 0x3BE09B0 Offset: 0x3BE0AB1 VA: 0x3BE09B0
	|-EqualityComparer<Bounds>.CreateComparer
	|
	|-RVA: 0x3BE1650 Offset: 0x3BE1751 VA: 0x3BE1650
	|-EqualityComparer<byte>.CreateComparer
	|
	|-RVA: 0x3BE21E0 Offset: 0x3BE22E1 VA: 0x3BE21E0
	|-EqualityComparer<CameraInfo>.CreateComparer
	|
	|-RVA: 0x3BE2D90 Offset: 0x3BE2E91 VA: 0x3BE2D90
	|-EqualityComparer<CancellationToken>.CreateComparer
	|
	|-RVA: 0x3BE3920 Offset: 0x3BE3A21 VA: 0x3BE3920
	|-EqualityComparer<CancellationTokenRegistration>.CreateComparer
	|
	|-RVA: 0x3BE45C0 Offset: 0x3BE46C1 VA: 0x3BE45C0
	|-EqualityComparer<char>.CreateComparer
	|
	|-RVA: 0x3BE5150 Offset: 0x3BE5251 VA: 0x3BE5150
	|-EqualityComparer<Color>.CreateComparer
	|
	|-RVA: 0x3BE5D60 Offset: 0x3BE5E61 VA: 0x3BE5D60
	|-EqualityComparer<Color32>.CreateComparer
	|
	|-RVA: 0x3BE68F0 Offset: 0x3BE69F1 VA: 0x3BE68F0
	|-EqualityComparer<ColorBlock>.CreateComparer
	|
	|-RVA: 0x3BE7750 Offset: 0x3BE7851 VA: 0x3BE7750
	|-EqualityComparer<ConstraintSource>.CreateComparer
	|
	|-RVA: 0x3BE8300 Offset: 0x3BE8401 VA: 0x3BE8300
	|-EqualityComparer<ContourVertex>.CreateComparer
	|
	|-RVA: 0x3BE8FA0 Offset: 0x3BE90A1 VA: 0x3BE8FA0
	|-EqualityComparer<DataStoreRatingInfo>.CreateComparer
	|
	|-RVA: 0x3BE9C40 Offset: 0x3BE9D41 VA: 0x3BE9C40
	|-EqualityComparer<DataStoreResult>.CreateComparer
	|
	|-RVA: 0x3BEA7D0 Offset: 0x3BEA8D1 VA: 0x3BEA7D0
	|-EqualityComparer<DateTime>.CreateComparer
	|
	|-RVA: 0x3BEB360 Offset: 0x3BEB461 VA: 0x3BEB360
	|-EqualityComparer<DateTimeOffset>.CreateComparer
	|
	|-RVA: 0x3BEBF10 Offset: 0x3BEC011 VA: 0x3BEBF10
	|-EqualityComparer<Decimal>.CreateComparer
	|
	|-RVA: 0x3BECAC0 Offset: 0x3BECBC1 VA: 0x3BECAC0
	|-EqualityComparer<DiagnosticEvent>.CreateComparer
	|
	|-RVA: 0x3BED7D0 Offset: 0x3BED8D1 VA: 0x3BED7D0
	|-EqualityComparer<double>.CreateComparer
	|
	|-RVA: 0x3BEE380 Offset: 0x3BEE481 VA: 0x3BEE380
	|-EqualityComparer<FXZ>.CreateComparer
	|
	|-RVA: 0x3BEEF40 Offset: 0x3BEF041 VA: 0x3BEEF40
	|-EqualityComparer<Friend>.CreateComparer
	|
	|-RVA: 0x3BEFBF0 Offset: 0x3BEFCF1 VA: 0x3BEFBF0
	|-EqualityComparer<GlyphRect>.CreateComparer
	|
	|-RVA: 0x3BF07A0 Offset: 0x3BF08A1 VA: 0x3BF07A0
	|-EqualityComparer<Guid>.CreateComparer
	|
	|-RVA: 0x3BF1350 Offset: 0x3BF1451 VA: 0x3BF1350
	|-EqualityComparer<short>.CreateComparer
	|
	|-RVA: 0x3BF1EE0 Offset: 0x3BF1FE1 VA: 0x3BF1EE0
	|-EqualityComparer<int>.CreateComparer
	|
	|-RVA: 0x3BF2A70 Offset: 0x3BF2B71 VA: 0x3BF2A70
	|-EqualityComparer<Int32Enum>.CreateComparer
	|
	|-RVA: 0x3BF3600 Offset: 0x3BF3701 VA: 0x3BF3600
	|-EqualityComparer<long>.CreateComparer
	|
	|-RVA: 0x3BF4190 Offset: 0x3BF4291 VA: 0x3BF4190
	|-EqualityComparer<Int64Enum>.CreateComparer
	|
	|-RVA: 0x3BF4D20 Offset: 0x3BF4E21 VA: 0x3BF4D20
	|-EqualityComparer<IntPtr>.CreateComparer
	|
	|-RVA: 0x3BF58B0 Offset: 0x3BF59B1 VA: 0x3BF58B0
	|-EqualityComparer<InterpretedFrameInfo>.CreateComparer
	|
	|-RVA: 0x3BF6460 Offset: 0x3BF6561 VA: 0x3BF6460
	|-EqualityComparer<IntervalTreeNode>.CreateComparer
	|
	|-RVA: 0x3BF7100 Offset: 0x3BF7201 VA: 0x3BF7100
	|-EqualityComparer<LayerMask>.CreateComparer
	|
	|-RVA: 0x3BF7C90 Offset: 0x3BF7D91 VA: 0x3BF7C90
	|-EqualityComparer<LengthLimitProperties>.CreateComparer
	|
	|-RVA: 0x3BF8820 Offset: 0x3BF8921 VA: 0x3BF8820
	|-EqualityComparer<MapPos>.CreateComparer
	|
	|-RVA: 0x3BF93B0 Offset: 0x3BF94B1 VA: 0x3BF93B0
	|-EqualityComparer<Matrix4x4>.CreateComparer
	|
	|-RVA: 0x3BFA130 Offset: 0x3BFA231 VA: 0x3BFA130
	|-EqualityComparer<Navigation>.CreateComparer
	|
	|-RVA: 0x3BFAE50 Offset: 0x3BFAF51 VA: 0x3BFAE50
	|-EqualityComparer<object>.CreateComparer
	|
	|-RVA: 0x3BFB9D0 Offset: 0x3BFBAD1 VA: 0x3BFB9D0
	|-EqualityComparer<ObjectInitializationData>.CreateComparer
	|
	|-RVA: 0x3BFC6E0 Offset: 0x3BFC7E1 VA: 0x3BFC6E0
	|-EqualityComparer<Playable>.CreateComparer
	|
	|-RVA: 0x3BB74F0 Offset: 0x3BB75F1 VA: 0x3BB74F0
	|-EqualityComparer<PlayableBinding>.CreateComparer
	|
	|-RVA: 0x3BB8180 Offset: 0x3BB8281 VA: 0x3BB8180
	|-EqualityComparer<PlayerLoopSystem>.CreateComparer
	|
	|-RVA: 0x3BB8EA0 Offset: 0x3BB8FA1 VA: 0x3BB8EA0
	|-EqualityComparer<PlayerLoopSystemInternal>.CreateComparer
	|
	|-RVA: 0x3BB9BC0 Offset: 0x3BB9CC1 VA: 0x3BB9BC0
	|-EqualityComparer<Quaternion>.CreateComparer
	|
	|-RVA: 0x3BBA7D0 Offset: 0x3BBA8D1 VA: 0x3BBA7D0
	|-EqualityComparer<RandomSeed>.CreateComparer
	|
	|-RVA: 0x3BBB380 Offset: 0x3BBB481 VA: 0x3BBB380
	|-EqualityComparer<RangePositionInfo>.CreateComparer
	|
	|-RVA: 0x3BBBF30 Offset: 0x3BBC031 VA: 0x3BBBF30
	|-EqualityComparer<Ranking2ChartInfoInput>.CreateComparer
	|
	|-RVA: 0x3BBCAC0 Offset: 0x3BBCBC1 VA: 0x3BBCAC0
	|-EqualityComparer<RaycastHit2D>.CreateComparer
	|
	|-RVA: 0x3BBD810 Offset: 0x3BBD911 VA: 0x3BBD810
	|-EqualityComparer<RaycastResult>.CreateComparer
	|
	|-RVA: 0x3BBE610 Offset: 0x3BBE711 VA: 0x3BBE610
	|-EqualityComparer<Rect>.CreateComparer
	|
	|-RVA: 0x3BBF220 Offset: 0x3BBF321 VA: 0x3BBF220
	|-EqualityComparer<RendererListHandle>.CreateComparer
	|
	|-RVA: 0x3BBFDB0 Offset: 0x3BBFEB1 VA: 0x3BBFDB0
	|-EqualityComparer<ResourceHandle>.CreateComparer
	|
	|-RVA: 0x3BC0940 Offset: 0x3BC0A41 VA: 0x3BC0940
	|-EqualityComparer<ResourceLocator>.CreateComparer
	|
	|-RVA: 0x3BC14F0 Offset: 0x3BC15F1 VA: 0x3BC14F0
	|-EqualityComparer<sbyte>.CreateComparer
	|
	|-RVA: 0x3BC2080 Offset: 0x3BC2181 VA: 0x3BC2080
	|-EqualityComparer<ShaderTagId>.CreateComparer
	|
	|-RVA: 0x3BC2C10 Offset: 0x3BC2D11 VA: 0x3BC2C10
	|-EqualityComparer<float>.CreateComparer
	|
	|-RVA: 0x3BC37C0 Offset: 0x3BC38C1 VA: 0x3BC37C0
	|-EqualityComparer<SphericalHarmonicsL2>.CreateComparer
	|
	|-RVA: 0x3BC4710 Offset: 0x3BC4811 VA: 0x3BC4710
	|-EqualityComparer<SpriteState>.CreateComparer
	|
	|-RVA: 0x3BC53A0 Offset: 0x3BC54A1 VA: 0x3BC53A0
	|-EqualityComparer<SubMeshDescriptor>.CreateComparer
	|
	|-RVA: 0x3BC60B0 Offset: 0x3BC61B1 VA: 0x3BC60B0
	|-EqualityComparer<TablePair>.CreateComparer
	|
	|-RVA: 0x3BC6C60 Offset: 0x3BC6D61 VA: 0x3BC6C60
	|-EqualityComparer<TimeSpan>.CreateComparer
	|
	|-RVA: 0x3BC77F0 Offset: 0x3BC78F1 VA: 0x3BC77F0
	|-EqualityComparer<UICharInfo>.CreateComparer
	|
	|-RVA: 0x3BC83F0 Offset: 0x3BC84F1 VA: 0x3BC83F0
	|-EqualityComparer<UILineInfo>.CreateComparer
	|
	|-RVA: 0x3BC8FA0 Offset: 0x3BC90A1 VA: 0x3BC8FA0
	|-EqualityComparer<UIVertex>.CreateComparer
	|
	|-RVA: 0x3BC9EF0 Offset: 0x3BC9FF1 VA: 0x3BC9EF0
	|-EqualityComparer<ushort>.CreateComparer
	|
	|-RVA: 0x3BCAA80 Offset: 0x3BCAB81 VA: 0x3BCAA80
	|-EqualityComparer<uint>.CreateComparer
	|
	|-RVA: 0x3BCB610 Offset: 0x3BCB711 VA: 0x3BCB610
	|-EqualityComparer<ulong>.CreateComparer
	|
	|-RVA: 0x3BCC1A0 Offset: 0x3BCC2A1 VA: 0x3BCC1A0
	|-EqualityComparer<UniTask>.CreateComparer
	|
	|-RVA: 0x3BCCD30 Offset: 0x3BCCE31 VA: 0x3BCCD30
	|-EqualityComparer<Unit>.CreateComparer
	|
	|-RVA: 0x3BCD8C0 Offset: 0x3BCD9C1 VA: 0x3BCD8C0
	|-EqualityComparer<Vector2>.CreateComparer
	|
	|-RVA: 0x3BCE480 Offset: 0x3BCE581 VA: 0x3BCE480
	|-EqualityComparer<Vector3>.CreateComparer
	|
	|-RVA: 0x3BCF080 Offset: 0x3BCF181 VA: 0x3BCF080
	|-EqualityComparer<Vector4>.CreateComparer
	|
	|-RVA: 0x3BCFC90 Offset: 0x3BCFD91 VA: 0x3BCFC90
	|-EqualityComparer<VertexAttributeDescriptor>.CreateComparer
	|
	|-RVA: 0x3BD0840 Offset: 0x3BD0941 VA: 0x3BD0840
	|-EqualityComparer<X509ChainStatus>.CreateComparer
	|
	|-RVA: 0x3BD13F0 Offset: 0x3BD14F1 VA: 0x3BD13F0
	|-EqualityComparer<XPathNodeRef>.CreateComparer
	|
	|-RVA: 0x3BD1FA0 Offset: 0x3BD20A1 VA: 0x3BD1FA0
	|-EqualityComparer<XRView>.CreateComparer
	|
	|-RVA: 0x3BD2C50 Offset: 0x3BD2D51 VA: 0x3BD2C50
	|-EqualityComparer<AmiiboSequence.GainItemData>.CreateComparer
	|
	|-RVA: 0x3BD3800 Offset: 0x3BD3901 VA: 0x3BD3800
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.CreateComparer
	|
	|-RVA: 0x3BD4520 Offset: 0x3BD4621 VA: 0x3BD4520
	|-EqualityComparer<ArenaOrderSequence.GodInfo>.CreateComparer
	|
	|-RVA: 0x3BD50D0 Offset: 0x3BD51D1 VA: 0x3BD50D0
	|-EqualityComparer<BattleInfo.SupportData>.CreateComparer
	|
	|-RVA: 0x3BD5C80 Offset: 0x3BD5D81 VA: 0x3BD5C80
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.CreateComparer
	|
	|-RVA: 0x3BD6830 Offset: 0x3BD6931 VA: 0x3BD6830
	|-EqualityComparer<Camera.RenderRequest>.CreateComparer
	|
	|-RVA: 0x3BD74D0 Offset: 0x3BD75D1 VA: 0x3BD74D0
	|-EqualityComparer<CameraState.CustomBlendable>.CreateComparer
	|
	|-RVA: 0x3BD8080 Offset: 0x3BD8181 VA: 0x3BD8080
	|-EqualityComparer<CinemachineClearShot.Pair>.CreateComparer
	|
	|-RVA: 0x3BD8C10 Offset: 0x3BD8D11 VA: 0x3BD8C10
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.CreateComparer
	|
	|-RVA: 0x3BD97A0 Offset: 0x3BD98A1 VA: 0x3BD97A0
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.CreateComparer
	|
	|-RVA: 0x3B78C50 Offset: 0x3B78D51 VA: 0x3B78C50
	|-EqualityComparer<Detail.AsyncResultInt>.CreateComparer
	|
	|-RVA: 0x3B79960 Offset: 0x3B79A61 VA: 0x3B79960
	|-EqualityComparer<Detail.CppArray>.CreateComparer
	|
	|-RVA: 0x3B7A510 Offset: 0x3B7A611 VA: 0x3B7A510
	|-EqualityComparer<Detail.NotificationEventInt>.CreateComparer
	|
	|-RVA: 0x3B7B220 Offset: 0x3B7B321 VA: 0x3B7B220
	|-EqualityComparer<DragonRideTargetGroup.ChainParam>.CreateComparer
	|
	|-RVA: 0x3B7BDD0 Offset: 0x3B7BED1 VA: 0x3B7BDD0
	|-EqualityComparer<DynamicMesh.State>.CreateComparer
	|
	|-RVA: 0x3B7C960 Offset: 0x3B7CA61 VA: 0x3B7C960
	|-EqualityComparer<GameVariable.Value>.CreateComparer
	|
	|-RVA: 0x3B7D510 Offset: 0x3B7D611 VA: 0x3B7D510
	|-EqualityComparer<GmapPathAdjuster.TargetModel>.CreateComparer
	|
	|-RVA: 0x3B7E1B0 Offset: 0x3B7E2B1 VA: 0x3B7E1B0
	|-EqualityComparer<GmapSpotAdjuster.TargetModel>.CreateComparer
	|
	|-RVA: 0x3B7EE50 Offset: 0x3B7EF51 VA: 0x3B7EE50
	|-EqualityComparer<HubFastTravel.Location>.CreateComparer
	|
	|-RVA: 0x3B7FAF0 Offset: 0x3B7FBF1 VA: 0x3B7FAF0
	|-EqualityComparer<HubLensFlare.Flare>.CreateComparer
	|
	|-RVA: 0x3B80800 Offset: 0x3B80901 VA: 0x3B80800
	|-EqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.CreateComparer
	|
	|-RVA: 0x3B813B0 Offset: 0x3B814B1 VA: 0x3B813B0
	|-EqualityComparer<Map.Pos>.CreateComparer
	|
	|-RVA: 0x3B81F40 Offset: 0x3B82041 VA: 0x3B81F40
	|-EqualityComparer<MapImage.BackupTerrain>.CreateComparer
	|
	|-RVA: 0x3B82AF0 Offset: 0x3B82BF1 VA: 0x3B82AF0
	|-EqualityComparer<MapImageRange.Pos>.CreateComparer
	|
	|-RVA: 0x3B83680 Offset: 0x3B83781 VA: 0x3B83680
	|-EqualityComparer<MapMind.Record>.CreateComparer
	|
	|-RVA: 0x3B84480 Offset: 0x3B84581 VA: 0x3B84480
	|-EqualityComparer<MapMind.Target>.CreateComparer
	|
	|-RVA: 0x3B85120 Offset: 0x3B85221 VA: 0x3B85120
	|-EqualityComparer<MapPanelDebug.Entity>.CreateComparer
	|
	|-RVA: 0x3B85DC0 Offset: 0x3B85EC1 VA: 0x3B85DC0
	|-EqualityComparer<NexRanking.Data>.CreateComparer
	|
	|-RVA: 0x3B86950 Offset: 0x3B86A51 VA: 0x3B86950
	|-EqualityComparer<NexVersus.RatingData>.CreateComparer
	|
	|-RVA: 0x3B87500 Offset: 0x3B87601 VA: 0x3B87500
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.CreateComparer
	|
	|-RVA: 0x3B880B0 Offset: 0x3B881B1 VA: 0x3B880B0
	|-EqualityComparer<ParticleSystem.Particle>.CreateComparer
	|
	|-RVA: 0x3B88D60 Offset: 0x3B88E61 VA: 0x3B88D60
	|-EqualityComparer<QualitySettingsStack.Settings>.CreateComparer
	|
	|-RVA: 0x3B89A70 Offset: 0x3B89B71 VA: 0x3B89A70
	|-EqualityComparer<RangeData.Offset>.CreateComparer
	|
	|-RVA: 0x3B8A600 Offset: 0x3B8A701 VA: 0x3B8A600
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.CreateComparer
	|
	|-RVA: 0x3B8B290 Offset: 0x3B8B391 VA: 0x3B8B290
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.CreateComparer
	|
	|-RVA: 0x3B8BFB0 Offset: 0x3B8C0B1 VA: 0x3B8BFB0
	|-EqualityComparer<RingCleaningUnitSelectMenu.GodParam>.CreateComparer
	|
	|-RVA: 0x3B8CB60 Offset: 0x3B8CC61 VA: 0x3B8CB60
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.CreateComparer
	|
	|-RVA: 0x3B8D880 Offset: 0x3B8D981 VA: 0x3B8D880
	|-EqualityComparer<ShadowUtility.Edge>.CreateComparer
	|
	|-RVA: 0x3B8E590 Offset: 0x3B8E691 VA: 0x3B8E590
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.CreateComparer
	|
	|-RVA: 0x3B8F140 Offset: 0x3B8F241 VA: 0x3B8F140
	|-EqualityComparer<SkillArray.Entity>.CreateComparer
	|
	|-RVA: 0x3B8FCD0 Offset: 0x3B8FDD1 VA: 0x3B8FCD0
	|-EqualityComparer<Stream.Info>.CreateComparer
	|
	|-RVA: 0x3B908A0 Offset: 0x3B909A1 VA: 0x3B908A0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.CreateComparer
	|
	|-RVA: 0x3B91620 Offset: 0x3B91721 VA: 0x3B91620
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.CreateComparer
	|
	|-RVA: 0x3B922C0 Offset: 0x3B923C1 VA: 0x3B922C0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.CreateComparer
	|
	|-RVA: 0x3B92F60 Offset: 0x3B93061 VA: 0x3B92F60
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CreateComparer
	|
	|-RVA: 0x3B93B10 Offset: 0x3B93C11 VA: 0x3B93B10
	|-EqualityComparer<AIThink.EnchantThink.SurroundingInfo>.CreateComparer
	|
	|-RVA: 0x3B946A0 Offset: 0x3B947A1 VA: 0x3B946A0
	|-EqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.CreateComparer
	|
	|-RVA: 0x3B95250 Offset: 0x3B95351 VA: 0x3B95250
	|-EqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.CreateComparer
	|
	|-RVA: 0x3B95F00 Offset: 0x3B96001 VA: 0x3B95F00
	|-EqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.CreateComparer
	|
	|-RVA: 0x3B96AB0 Offset: 0x3B96BB1 VA: 0x3B96AB0
	|-EqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.CreateComparer
	|
	|-RVA: 0x3B977D0 Offset: 0x3B978D1 VA: 0x3B977D0
	|-EqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.CreateComparer
	|
	|-RVA: 0x3B98480 Offset: 0x3B98581 VA: 0x3B98480
	|-EqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.CreateComparer
	|
	|-RVA: 0x3B99120 Offset: 0x3B99221 VA: 0x3B99120
	|-EqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.CreateComparer
	|
	|-RVA: 0x3B99DC0 Offset: 0x3B99EC1 VA: 0x3B99DC0
	|-EqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.CreateComparer
	|
	|-RVA: 0x3B9AA70 Offset: 0x3B9AB71 VA: 0x3B9AA70
	|-EqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.CreateComparer
	|
	|-RVA: 0x3B9B620 Offset: 0x3B9B721 VA: 0x3B9B620
	|-EqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.CreateComparer
	|
	|-RVA: 0x33BC940 Offset: 0x33BCA41 VA: 0x33BC940
	|-EqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.CreateComparer
	|
	|-RVA: 0x33BD4F0 Offset: 0x33BD5F1 VA: 0x33BD4F0
	|-EqualityComparer<Detail.Ranking.RankingCachedResultInt>.CreateComparer
	|
	|-RVA: 0x33BE280 Offset: 0x33BE381 VA: 0x33BE280
	|-EqualityComparer<Detail.Ranking.RankingOrderParamInt>.CreateComparer
	|
	|-RVA: 0x33BEE30 Offset: 0x33BEF31 VA: 0x33BEE30
	|-EqualityComparer<Detail.Ranking.RankingRankDataInt>.CreateComparer
	|
	|-RVA: 0x33BFBB0 Offset: 0x33BFCB1 VA: 0x33BFBB0
	|-EqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.CreateComparer
	|
	|-RVA: 0x33C0A10 Offset: 0x33C0B11 VA: 0x33C0A10
	|-EqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.CreateComparer
	|
	|-RVA: 0x33C1790 Offset: 0x33C1891 VA: 0x33C1790
	|-EqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.CreateComparer
	|
	|-RVA: 0x33C2340 Offset: 0x33C2441 VA: 0x33C2340
	|-EqualityComparer<Detail.Screening.ScreeningContextInfoInt>.CreateComparer
	|
	|-RVA: 0x33C2FD0 Offset: 0x33C30D1 VA: 0x33C2FD0
	|-EqualityComparer<Detail.Subscriber.SubscriberContentInt>.CreateComparer
	|
	|-RVA: 0x33C3DD0 Offset: 0x33C3ED1 VA: 0x33C3DD0
	|-EqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.CreateComparer
	|
	|-RVA: 0x33C4A70 Offset: 0x33C4B71 VA: 0x33C4A70
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.CreateComparer
	|
	|-RVA: 0x33C5790 Offset: 0x33C5891 VA: 0x33C5790
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.CreateComparer
	|
	|-RVA: 0x33C6430 Offset: 0x33C6531 VA: 0x33C6430
	|-EqualityComparer<Detail.Utility.IntegerSettings>.CreateComparer
	|
	|-RVA: 0x33C6FC0 Offset: 0x33C70C1 VA: 0x33C6FC0
	|-EqualityComparer<Detail.Utility.UniqueIdInfoInt>.CreateComparer
	|
	|-RVA: 0x33C7B70 Offset: 0x33C7C71 VA: 0x33C7B70
	|-EqualityComparer<MapHistory.Rewind.LatestInspectorData>.CreateComparer
	|
	|-RVA: 0x33C8740 Offset: 0x33C8841 VA: 0x33C8740
	|-EqualityComparer<MapHistory.Rewind.WorkTerrainData>.CreateComparer
	|
	|-RVA: 0x33C9310 Offset: 0x33C9411 VA: 0x33C9310
	|-EqualityComparer<MapSkill.AroundCalculator.Result>.CreateComparer
	|
	|-RVA: 0x33C9EC0 Offset: 0x33C9FC1 VA: 0x33C9EC0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.CreateComparer
	|
	|-RVA: 0x33CABD0 Offset: 0x33CACD1 VA: 0x33CABD0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.CreateComparer
	|
	|-RVA: 0x33CB920 Offset: 0x33CBA21 VA: 0x33CB920
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.CreateComparer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Equals(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetHashCode(T obj);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37688E0 Offset: 0x37689E1 VA: 0x37688E0
	|-EqualityComparer<AsyncOperationHandle<object>>.IndexOf
	|
	|-RVA: 0x3769580 Offset: 0x3769681 VA: 0x3769580
	|-EqualityComparer<IntervalTree.Entry<object>>.IndexOf
	|
	|-RVA: 0x376A220 Offset: 0x376A321 VA: 0x376A220
	|-EqualityComparer<KeyValuePair<DateTime, object>>.IndexOf
	|
	|-RVA: 0x376ADD0 Offset: 0x376AED1 VA: 0x376ADD0
	|-EqualityComparer<KeyValuePair<int, object>>.IndexOf
	|
	|-RVA: 0x376B980 Offset: 0x376BA81 VA: 0x376B980
	|-EqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.IndexOf
	|
	|-RVA: 0x376C610 Offset: 0x376C711 VA: 0x376C610
	|-EqualityComparer<KeyValuePair<object, object>>.IndexOf
	|
	|-RVA: 0x376D1C0 Offset: 0x376D2C1 VA: 0x376D1C0
	|-EqualityComparer<CommonBattleSequence.Reliance<object>>.IndexOf
	|
	|-RVA: 0x376DE60 Offset: 0x376DF61 VA: 0x376DE60
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.IndexOf
	|
	|-RVA: 0x376EA10 Offset: 0x376EB11 VA: 0x376EA10
	|-EqualityComparer<TimeInterval<object>>.IndexOf
	|
	|-RVA: 0x376F5C0 Offset: 0x376F6C1 VA: 0x376F5C0
	|-EqualityComparer<Timestamped<object>>.IndexOf
	|
	|-RVA: 0x3770260 Offset: 0x3770361 VA: 0x3770260
	|-EqualityComparer<UniTask<object>>.IndexOf
	|
	|-RVA: 0x3770E10 Offset: 0x3770F11 VA: 0x3770E10
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x37719C0 Offset: 0x3771AC1 VA: 0x37719C0
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3772650 Offset: 0x3772751 VA: 0x3772650
	|-EqualityComparer<ValueTuple<bool, UniTask<object>>>.IndexOf
	|
	|-RVA: 0x37732F0 Offset: 0x37733F1 VA: 0x37732F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.IndexOf
	|
	|-RVA: 0x3773F80 Offset: 0x3774081 VA: 0x3773F80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.IndexOf
	|
	|-RVA: 0x3774CA0 Offset: 0x3774DA1 VA: 0x3774CA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.IndexOf
	|
	|-RVA: 0x37759B0 Offset: 0x3775AB1 VA: 0x37759B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.IndexOf
	|
	|-RVA: 0x3776580 Offset: 0x3776681 VA: 0x3776580
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.IndexOf
	|
	|-RVA: 0x3777150 Offset: 0x3777251 VA: 0x3777150
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.IndexOf
	|
	|-RVA: 0x3777ED0 Offset: 0x3777FD1 VA: 0x3777ED0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.IndexOf
	|
	|-RVA: 0x3778AA0 Offset: 0x3778BA1 VA: 0x3778AA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.IndexOf
	|
	|-RVA: 0x37797F0 Offset: 0x37798F1 VA: 0x37797F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.IndexOf
	|
	|-RVA: 0x377A500 Offset: 0x377A601 VA: 0x377A500
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.IndexOf
	|
	|-RVA: 0x377B1A0 Offset: 0x377B2A1 VA: 0x377B1A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.IndexOf
	|
	|-RVA: 0x377BEB0 Offset: 0x377BFB1 VA: 0x377BEB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x377CBC0 Offset: 0x377CCC1 VA: 0x377CBC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.IndexOf
	|
	|-RVA: 0x377D910 Offset: 0x377DA11 VA: 0x377D910
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.IndexOf
	|
	|-RVA: 0x377E660 Offset: 0x377E761 VA: 0x377E660
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.IndexOf
	|
	|-RVA: 0x37E8450 Offset: 0x37E8551 VA: 0x37E8450
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.IndexOf
	|
	|-RVA: 0x37E9160 Offset: 0x37E9261 VA: 0x37E9160
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.IndexOf
	|
	|-RVA: 0x37E9D30 Offset: 0x37E9E31 VA: 0x37E9D30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.IndexOf
	|
	|-RVA: 0x37EAA40 Offset: 0x37EAB41 VA: 0x37EAA40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.IndexOf
	|
	|-RVA: 0x37EB6D0 Offset: 0x37EB7D1 VA: 0x37EB6D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.IndexOf
	|
	|-RVA: 0x37EC420 Offset: 0x37EC521 VA: 0x37EC420
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.IndexOf
	|
	|-RVA: 0x37ED130 Offset: 0x37ED231 VA: 0x37ED130
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.IndexOf
	|
	|-RVA: 0x37EDE40 Offset: 0x37EDF41 VA: 0x37EDE40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x37EEBD0 Offset: 0x37EECD1 VA: 0x37EEBD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x37EF950 Offset: 0x37EFA51 VA: 0x37EF950
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x37F0750 Offset: 0x37F0851 VA: 0x37F0750
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x37F1540 Offset: 0x37F1641 VA: 0x37F1540
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.IndexOf
	|
	|-RVA: 0x37F23A0 Offset: 0x37F24A1 VA: 0x37F23A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.IndexOf
	|
	|-RVA: 0x37F2F70 Offset: 0x37F3071 VA: 0x37F2F70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.IndexOf
	|
	|-RVA: 0x37F3B40 Offset: 0x37F3C41 VA: 0x37F3B40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.IndexOf
	|
	|-RVA: 0x37F4860 Offset: 0x37F4961 VA: 0x37F4860
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.IndexOf
	|
	|-RVA: 0x37F5430 Offset: 0x37F5531 VA: 0x37F5430
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.IndexOf
	|
	|-RVA: 0x37F60C0 Offset: 0x37F61C1 VA: 0x37F60C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.IndexOf
	|
	|-RVA: 0x37F6DE0 Offset: 0x37F6EE1 VA: 0x37F6DE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.IndexOf
	|
	|-RVA: 0x37F7A80 Offset: 0x37F7B81 VA: 0x37F7A80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.IndexOf
	|
	|-RVA: 0x37F87A0 Offset: 0x37F88A1 VA: 0x37F87A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x37F94C0 Offset: 0x37F95C1 VA: 0x37F94C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.IndexOf
	|
	|-RVA: 0x37FA150 Offset: 0x37FA251 VA: 0x37FA150
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.IndexOf
	|
	|-RVA: 0x37FADE0 Offset: 0x37FAEE1 VA: 0x37FADE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.IndexOf
	|
	|-RVA: 0x37FBA80 Offset: 0x37FBB81 VA: 0x37FBA80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.IndexOf
	|
	|-RVA: 0x37FC7A0 Offset: 0x37FC8A1 VA: 0x37FC7A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.IndexOf
	|
	|-RVA: 0x37FD370 Offset: 0x37FD471 VA: 0x37FD370
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.IndexOf
	|
	|-RVA: 0x37FE010 Offset: 0x37FE111 VA: 0x37FE010
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.IndexOf
	|
	|-RVA: 0x37FED20 Offset: 0x37FEE21 VA: 0x37FED20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.IndexOf
	|
	|-RVA: 0x37FF9B0 Offset: 0x37FFAB1 VA: 0x37FF9B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.IndexOf
	|
	|-RVA: 0x38006D0 Offset: 0x38007D1 VA: 0x38006D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.IndexOf
	|
	|-RVA: 0x38013F0 Offset: 0x38014F1 VA: 0x38013F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3802170 Offset: 0x3802271 VA: 0x3802170
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3802E80 Offset: 0x3802F81 VA: 0x3802E80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3803C70 Offset: 0x3803D71 VA: 0x3803C70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x3804A00 Offset: 0x3804B01 VA: 0x3804A00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3805860 Offset: 0x3805961 VA: 0x3805860
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x38065E0 Offset: 0x38066E1 VA: 0x38065E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x38074C0 Offset: 0x38075C1 VA: 0x38074C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x38082C0 Offset: 0x38083C1 VA: 0x38082C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x3809210 Offset: 0x3809311 VA: 0x3809210
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.IndexOf
	|
	|-RVA: 0x380A000 Offset: 0x380A101 VA: 0x380A000
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.IndexOf
	|
	|-RVA: 0x380AB90 Offset: 0x380AC91 VA: 0x380AB90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.IndexOf
	|
	|-RVA: 0x380B720 Offset: 0x380B821 VA: 0x380B720
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.IndexOf
	|
	|-RVA: 0x380C470 Offset: 0x380C571 VA: 0x380C470
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.IndexOf
	|
	|-RVA: 0x380D000 Offset: 0x380D101 VA: 0x380D000
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.IndexOf
	|
	|-RVA: 0x39A0BD0 Offset: 0x39A0CD1 VA: 0x39A0BD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.IndexOf
	|
	|-RVA: 0x39A1860 Offset: 0x39A1961 VA: 0x39A1860
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.IndexOf
	|
	|-RVA: 0x39A2410 Offset: 0x39A2511 VA: 0x39A2410
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.IndexOf
	|
	|-RVA: 0x39A30A0 Offset: 0x39A31A1 VA: 0x39A30A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x39A3D30 Offset: 0x39A3E31 VA: 0x39A3D30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.IndexOf
	|
	|-RVA: 0x39A4A40 Offset: 0x39A4B41 VA: 0x39A4A40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.IndexOf
	|
	|-RVA: 0x39A5750 Offset: 0x39A5851 VA: 0x39A5750
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.IndexOf
	|
	|-RVA: 0x39A6300 Offset: 0x39A6401 VA: 0x39A6300
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.IndexOf
	|
	|-RVA: 0x39A6F90 Offset: 0x39A7091 VA: 0x39A6F90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.IndexOf
	|
	|-RVA: 0x39A7B20 Offset: 0x39A7C21 VA: 0x39A7B20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.IndexOf
	|
	|-RVA: 0x39A87C0 Offset: 0x39A88C1 VA: 0x39A87C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.IndexOf
	|
	|-RVA: 0x39A9460 Offset: 0x39A9561 VA: 0x39A9460
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.IndexOf
	|
	|-RVA: 0x39AA170 Offset: 0x39AA271 VA: 0x39AA170
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.IndexOf
	|
	|-RVA: 0x39AAE00 Offset: 0x39AAF01 VA: 0x39AAE00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.IndexOf
	|
	|-RVA: 0x39ABA90 Offset: 0x39ABB91 VA: 0x39ABA90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x39AC820 Offset: 0x39AC921 VA: 0x39AC820
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.IndexOf
	|
	|-RVA: 0x39AD540 Offset: 0x39AD641 VA: 0x39AD540
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x39AE340 Offset: 0x39AE441 VA: 0x39AE340
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x39AF050 Offset: 0x39AF151 VA: 0x39AF050
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x39AFEB0 Offset: 0x39AFFB1 VA: 0x39AFEB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x39B0C40 Offset: 0x39B0D41 VA: 0x39B0C40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x39B1B20 Offset: 0x39B1C21 VA: 0x39B1B20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x39B28A0 Offset: 0x39B29A1 VA: 0x39B28A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x39B37F0 Offset: 0x39B38F1 VA: 0x39B37F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.IndexOf
	|
	|-RVA: 0x39B45F0 Offset: 0x39B46F1 VA: 0x39B45F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x39B52A0 Offset: 0x39B53A1 VA: 0x39B52A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.IndexOf
	|
	|-RVA: 0x39B5F50 Offset: 0x39B6051 VA: 0x39B5F50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.IndexOf
	|
	|-RVA: 0x39B6B20 Offset: 0x39B6C21 VA: 0x39B6B20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.IndexOf
	|
	|-RVA: 0x39B76F0 Offset: 0x39B77F1 VA: 0x39B76F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.IndexOf
	|
	|-RVA: 0x39B8380 Offset: 0x39B8481 VA: 0x39B8380
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.IndexOf
	|
	|-RVA: 0x39B8F50 Offset: 0x39B9051 VA: 0x39B8F50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.IndexOf
	|
	|-RVA: 0x39B9BF0 Offset: 0x39B9CF1 VA: 0x39B9BF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.IndexOf
	|
	|-RVA: 0x39BA890 Offset: 0x39BA991 VA: 0x39BA890
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.IndexOf
	|
	|-RVA: 0x39BB460 Offset: 0x39BB561 VA: 0x39BB460
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.IndexOf
	|
	|-RVA: 0x39BC100 Offset: 0x39BC201 VA: 0x39BC100
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x39BCDA0 Offset: 0x39BCEA1 VA: 0x39BCDA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.IndexOf
	|
	|-RVA: 0x39BDA40 Offset: 0x39BDB41 VA: 0x39BDA40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.IndexOf
	|
	|-RVA: 0x39BE6E0 Offset: 0x39BE7E1 VA: 0x39BE6E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.IndexOf
	|
	|-RVA: 0x39BF2B0 Offset: 0x39BF3B1 VA: 0x39BF2B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.IndexOf
	|
	|-RVA: 0x39BFF50 Offset: 0x39C0051 VA: 0x39BFF50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.IndexOf
	|
	|-RVA: 0x39C0B20 Offset: 0x39C0C21 VA: 0x39C0B20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.IndexOf
	|
	|-RVA: 0x39C16D0 Offset: 0x39C17D1 VA: 0x39C16D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.IndexOf
	|
	|-RVA: 0x39C2370 Offset: 0x39C2471 VA: 0x39C2370
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.IndexOf
	|
	|-RVA: 0x39C3010 Offset: 0x39C3111 VA: 0x39C3010
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.IndexOf
	|
	|-RVA: 0x39C3CB0 Offset: 0x39C3DB1 VA: 0x39C3CB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.IndexOf
	|
	|-RVA: 0x39C4950 Offset: 0x39C4A51 VA: 0x39C4950
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3ADB280 Offset: 0x3ADB381 VA: 0x3ADB280
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.IndexOf
	|
	|-RVA: 0x3ADBF10 Offset: 0x3ADC011 VA: 0x3ADBF10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3ADCC90 Offset: 0x3ADCD91 VA: 0x3ADCC90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3ADD9B0 Offset: 0x3ADDAB1 VA: 0x3ADD9B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3ADE7A0 Offset: 0x3ADE8A1 VA: 0x3ADE7A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3ADF4B0 Offset: 0x3ADF5B1 VA: 0x3ADF4B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3AE0310 Offset: 0x3AE0411 VA: 0x3AE0310
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3AE10A0 Offset: 0x3AE11A1 VA: 0x3AE10A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3AE1F80 Offset: 0x3AE2081 VA: 0x3AE1F80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.IndexOf
	|
	|-RVA: 0x3AE2D00 Offset: 0x3AE2E01 VA: 0x3AE2D00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3AE3C50 Offset: 0x3AE3D51 VA: 0x3AE3C50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.IndexOf
	|
	|-RVA: 0x3AE4900 Offset: 0x3AE4A01 VA: 0x3AE4900
	|-EqualityComparer<ValueTuple<bool, AsyncUnit>>.IndexOf
	|
	|-RVA: 0x3AE5490 Offset: 0x3AE5591 VA: 0x3AE5490
	|-EqualityComparer<ValueTuple<bool, bool>>.IndexOf
	|
	|-RVA: 0x3AE6020 Offset: 0x3AE6121 VA: 0x3AE6020
	|-EqualityComparer<ValueTuple<bool, Bounds>>.IndexOf
	|
	|-RVA: 0x3AE6D30 Offset: 0x3AE6E31 VA: 0x3AE6D30
	|-EqualityComparer<ValueTuple<bool, byte>>.IndexOf
	|
	|-RVA: 0x3AE78C0 Offset: 0x3AE79C1 VA: 0x3AE78C0
	|-EqualityComparer<ValueTuple<bool, Color>>.IndexOf
	|
	|-RVA: 0x3AE8560 Offset: 0x3AE8661 VA: 0x3AE8560
	|-EqualityComparer<ValueTuple<bool, double>>.IndexOf
	|
	|-RVA: 0x3AE9110 Offset: 0x3AE9211 VA: 0x3AE9110
	|-EqualityComparer<ValueTuple<bool, int>>.IndexOf
	|
	|-RVA: 0x3AE9CA0 Offset: 0x3AE9DA1 VA: 0x3AE9CA0
	|-EqualityComparer<ValueTuple<bool, long>>.IndexOf
	|
	|-RVA: 0x3AEA850 Offset: 0x3AEA951 VA: 0x3AEA850
	|-EqualityComparer<ValueTuple<bool, object>>.IndexOf
	|
	|-RVA: 0x3AEB400 Offset: 0x3AEB501 VA: 0x3AEB400
	|-EqualityComparer<ValueTuple<bool, Quaternion>>.IndexOf
	|
	|-RVA: 0x3AEC0A0 Offset: 0x3AEC1A1 VA: 0x3AEC0A0
	|-EqualityComparer<ValueTuple<bool, Rect>>.IndexOf
	|
	|-RVA: 0x3AECD40 Offset: 0x3AECE41 VA: 0x3AECD40
	|-EqualityComparer<ValueTuple<bool, float>>.IndexOf
	|
	|-RVA: 0x3AED8D0 Offset: 0x3AED9D1 VA: 0x3AED8D0
	|-EqualityComparer<ValueTuple<bool, UniTask>>.IndexOf
	|
	|-RVA: 0x3AEE480 Offset: 0x3AEE581 VA: 0x3AEE480
	|-EqualityComparer<ValueTuple<bool, Unit>>.IndexOf
	|
	|-RVA: 0x3AEF010 Offset: 0x3AEF111 VA: 0x3AEF010
	|-EqualityComparer<ValueTuple<bool, Vector2>>.IndexOf
	|
	|-RVA: 0x3AEFBE0 Offset: 0x3AEFCE1 VA: 0x3AEFBE0
	|-EqualityComparer<ValueTuple<bool, Vector3>>.IndexOf
	|
	|-RVA: 0x3AF0790 Offset: 0x3AF0891 VA: 0x3AF0790
	|-EqualityComparer<ValueTuple<bool, Vector4>>.IndexOf
	|
	|-RVA: 0x3AF1430 Offset: 0x3AF1531 VA: 0x3AF1430
	|-EqualityComparer<ValueTuple<int, object>>.IndexOf
	|
	|-RVA: 0x3AF1FE0 Offset: 0x3AF20E1 VA: 0x3AF1FE0
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3AF2B70 Offset: 0x3AF2C71 VA: 0x3AF2B70
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.IndexOf
	|
	|-RVA: 0x3AF3810 Offset: 0x3AF3911 VA: 0x3AF3810
	|-EqualityComparer<ValueTuple<object, int>>.IndexOf
	|
	|-RVA: 0x3AF43C0 Offset: 0x3AF44C1 VA: 0x3AF43C0
	|-EqualityComparer<ValueTuple<object, object>>.IndexOf
	|
	|-RVA: 0x3AF4F70 Offset: 0x3AF5071 VA: 0x3AF4F70
	|-EqualityComparer<ValueTuple<object, float>>.IndexOf
	|
	|-RVA: 0x3AF5B20 Offset: 0x3AF5C21 VA: 0x3AF5B20
	|-EqualityComparer<ValueTuple<Vector3, float>>.IndexOf
	|
	|-RVA: 0x3AF6730 Offset: 0x3AF6831 VA: 0x3AF6730
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3AF7450 Offset: 0x3AF7551 VA: 0x3AF7450
	|-EqualityComparer<ValueTuple<object, Int32Enum, int>>.IndexOf
	|
	|-RVA: 0x3AF8000 Offset: 0x3AF8101 VA: 0x3AF8000
	|-EqualityComparer<ValueTuple<object, object, object>>.IndexOf
	|
	|-RVA: 0x3AF8CA0 Offset: 0x3AF8DA1 VA: 0x3AF8CA0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3AF9A30 Offset: 0x3AF9B31 VA: 0x3AF9A30
	|-EqualityComparer<ValueTuple<object, int, int, int>>.IndexOf
	|
	|-RVA: 0x3AFA6D0 Offset: 0x3AFA7D1 VA: 0x3AFA6D0
	|-EqualityComparer<ValueTuple<object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3AFB360 Offset: 0x3AFB461 VA: 0x3AFB360
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3AFC160 Offset: 0x3AFC261 VA: 0x3AFC160
	|-EqualityComparer<ValueTuple<object, object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3AFCE80 Offset: 0x3AFCF81 VA: 0x3AFCE80
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3AFDCE0 Offset: 0x3AFDDE1 VA: 0x3AFDCE0
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3AFE9F0 Offset: 0x3AFEAF1 VA: 0x3AFE9F0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.IndexOf
	|
	|-RVA: 0x3BDAB00 Offset: 0x3BDAC01 VA: 0x3BDAB00
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.IndexOf
	|
	|-RVA: 0x3BDB890 Offset: 0x3BDB991 VA: 0x3BDB890
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3BDC7E0 Offset: 0x3BDC8E1 VA: 0x3BDC7E0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.IndexOf
	|
	|-RVA: 0x3BDD490 Offset: 0x3BDD591 VA: 0x3BDD490
	|-EqualityComparer<AnimatorClipInfo>.IndexOf
	|
	|-RVA: 0x3BDE020 Offset: 0x3BDE121 VA: 0x3BDE020
	|-EqualityComparer<AsyncOperationHandle>.IndexOf
	|
	|-RVA: 0x3BDECC0 Offset: 0x3BDEDC1 VA: 0x3BDECC0
	|-EqualityComparer<AsyncUnit>.IndexOf
	|
	|-RVA: 0x3BDF850 Offset: 0x3BDF951 VA: 0x3BDF850
	|-EqualityComparer<BoneWeight>.IndexOf
	|
	|-RVA: 0x3BE04E0 Offset: 0x3BE05E1 VA: 0x3BE04E0
	|-EqualityComparer<bool>.IndexOf
	|
	|-RVA: 0x3BE1080 Offset: 0x3BE1181 VA: 0x3BE1080
	|-EqualityComparer<Bounds>.IndexOf
	|
	|-RVA: 0x3BE1D20 Offset: 0x3BE1E21 VA: 0x3BE1D20
	|-EqualityComparer<byte>.IndexOf
	|
	|-RVA: 0x3BE28B0 Offset: 0x3BE29B1 VA: 0x3BE28B0
	|-EqualityComparer<CameraInfo>.IndexOf
	|
	|-RVA: 0x3BE3460 Offset: 0x3BE3561 VA: 0x3BE3460
	|-EqualityComparer<CancellationToken>.IndexOf
	|
	|-RVA: 0x3BE3FF0 Offset: 0x3BE40F1 VA: 0x3BE3FF0
	|-EqualityComparer<CancellationTokenRegistration>.IndexOf
	|
	|-RVA: 0x3BE4C90 Offset: 0x3BE4D91 VA: 0x3BE4C90
	|-EqualityComparer<char>.IndexOf
	|
	|-RVA: 0x3BE5820 Offset: 0x3BE5921 VA: 0x3BE5820
	|-EqualityComparer<Color>.IndexOf
	|
	|-RVA: 0x3BE6430 Offset: 0x3BE6531 VA: 0x3BE6430
	|-EqualityComparer<Color32>.IndexOf
	|
	|-RVA: 0x3BE6FC0 Offset: 0x3BE70C1 VA: 0x3BE6FC0
	|-EqualityComparer<ColorBlock>.IndexOf
	|
	|-RVA: 0x3BE7E20 Offset: 0x3BE7F21 VA: 0x3BE7E20
	|-EqualityComparer<ConstraintSource>.IndexOf
	|
	|-RVA: 0x3BE89D0 Offset: 0x3BE8AD1 VA: 0x3BE89D0
	|-EqualityComparer<ContourVertex>.IndexOf
	|
	|-RVA: 0x3BE9670 Offset: 0x3BE9771 VA: 0x3BE9670
	|-EqualityComparer<DataStoreRatingInfo>.IndexOf
	|
	|-RVA: 0x3BEA310 Offset: 0x3BEA411 VA: 0x3BEA310
	|-EqualityComparer<DataStoreResult>.IndexOf
	|
	|-RVA: 0x3BEAEA0 Offset: 0x3BEAFA1 VA: 0x3BEAEA0
	|-EqualityComparer<DateTime>.IndexOf
	|
	|-RVA: 0x3BEBA30 Offset: 0x3BEBB31 VA: 0x3BEBA30
	|-EqualityComparer<DateTimeOffset>.IndexOf
	|
	|-RVA: 0x3BEC5E0 Offset: 0x3BEC6E1 VA: 0x3BEC5E0
	|-EqualityComparer<Decimal>.IndexOf
	|
	|-RVA: 0x3BED190 Offset: 0x3BED291 VA: 0x3BED190
	|-EqualityComparer<DiagnosticEvent>.IndexOf
	|
	|-RVA: 0x3BEDEA0 Offset: 0x3BEDFA1 VA: 0x3BEDEA0
	|-EqualityComparer<double>.IndexOf
	|
	|-RVA: 0x3BEEA50 Offset: 0x3BEEB51 VA: 0x3BEEA50
	|-EqualityComparer<FXZ>.IndexOf
	|
	|-RVA: 0x3BEF610 Offset: 0x3BEF711 VA: 0x3BEF610
	|-EqualityComparer<Friend>.IndexOf
	|
	|-RVA: 0x3BF02C0 Offset: 0x3BF03C1 VA: 0x3BF02C0
	|-EqualityComparer<GlyphRect>.IndexOf
	|
	|-RVA: 0x3BF0E70 Offset: 0x3BF0F71 VA: 0x3BF0E70
	|-EqualityComparer<Guid>.IndexOf
	|
	|-RVA: 0x3BF1A20 Offset: 0x3BF1B21 VA: 0x3BF1A20
	|-EqualityComparer<short>.IndexOf
	|
	|-RVA: 0x3BF25B0 Offset: 0x3BF26B1 VA: 0x3BF25B0
	|-EqualityComparer<int>.IndexOf
	|
	|-RVA: 0x3BF3140 Offset: 0x3BF3241 VA: 0x3BF3140
	|-EqualityComparer<Int32Enum>.IndexOf
	|
	|-RVA: 0x3BF3CD0 Offset: 0x3BF3DD1 VA: 0x3BF3CD0
	|-EqualityComparer<long>.IndexOf
	|
	|-RVA: 0x3BF4860 Offset: 0x3BF4961 VA: 0x3BF4860
	|-EqualityComparer<Int64Enum>.IndexOf
	|
	|-RVA: 0x3BF53F0 Offset: 0x3BF54F1 VA: 0x3BF53F0
	|-EqualityComparer<IntPtr>.IndexOf
	|
	|-RVA: 0x3BF5F80 Offset: 0x3BF6081 VA: 0x3BF5F80
	|-EqualityComparer<InterpretedFrameInfo>.IndexOf
	|
	|-RVA: 0x3BF6B30 Offset: 0x3BF6C31 VA: 0x3BF6B30
	|-EqualityComparer<IntervalTreeNode>.IndexOf
	|
	|-RVA: 0x3BF77D0 Offset: 0x3BF78D1 VA: 0x3BF77D0
	|-EqualityComparer<LayerMask>.IndexOf
	|
	|-RVA: 0x3BF8360 Offset: 0x3BF8461 VA: 0x3BF8360
	|-EqualityComparer<LengthLimitProperties>.IndexOf
	|
	|-RVA: 0x3BF8EF0 Offset: 0x3BF8FF1 VA: 0x3BF8EF0
	|-EqualityComparer<MapPos>.IndexOf
	|
	|-RVA: 0x3BF9A80 Offset: 0x3BF9B81 VA: 0x3BF9A80
	|-EqualityComparer<Matrix4x4>.IndexOf
	|
	|-RVA: 0x3BFA800 Offset: 0x3BFA901 VA: 0x3BFA800
	|-EqualityComparer<Navigation>.IndexOf
	|
	|-RVA: 0x3BFB520 Offset: 0x3BFB621 VA: 0x3BFB520
	|-EqualityComparer<object>.IndexOf
	|-EqualityComparer<string>.IndexOf
	|
	|-RVA: 0x3BFC0A0 Offset: 0x3BFC1A1 VA: 0x3BFC0A0
	|-EqualityComparer<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x3BFCDB0 Offset: 0x3BFCEB1 VA: 0x3BFCDB0
	|-EqualityComparer<Playable>.IndexOf
	|
	|-RVA: 0x3BB7BC0 Offset: 0x3BB7CC1 VA: 0x3BB7BC0
	|-EqualityComparer<PlayableBinding>.IndexOf
	|
	|-RVA: 0x3BB8850 Offset: 0x3BB8951 VA: 0x3BB8850
	|-EqualityComparer<PlayerLoopSystem>.IndexOf
	|
	|-RVA: 0x3BB9570 Offset: 0x3BB9671 VA: 0x3BB9570
	|-EqualityComparer<PlayerLoopSystemInternal>.IndexOf
	|
	|-RVA: 0x3BBA290 Offset: 0x3BBA391 VA: 0x3BBA290
	|-EqualityComparer<Quaternion>.IndexOf
	|
	|-RVA: 0x3BBAEA0 Offset: 0x3BBAFA1 VA: 0x3BBAEA0
	|-EqualityComparer<RandomSeed>.IndexOf
	|
	|-RVA: 0x3BBBA50 Offset: 0x3BBBB51 VA: 0x3BBBA50
	|-EqualityComparer<RangePositionInfo>.IndexOf
	|
	|-RVA: 0x3BBC600 Offset: 0x3BBC701 VA: 0x3BBC600
	|-EqualityComparer<Ranking2ChartInfoInput>.IndexOf
	|
	|-RVA: 0x3BBD190 Offset: 0x3BBD291 VA: 0x3BBD190
	|-EqualityComparer<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x3BBDEE0 Offset: 0x3BBDFE1 VA: 0x3BBDEE0
	|-EqualityComparer<RaycastResult>.IndexOf
	|
	|-RVA: 0x3BBECE0 Offset: 0x3BBEDE1 VA: 0x3BBECE0
	|-EqualityComparer<Rect>.IndexOf
	|
	|-RVA: 0x3BBF8F0 Offset: 0x3BBF9F1 VA: 0x3BBF8F0
	|-EqualityComparer<RendererListHandle>.IndexOf
	|
	|-RVA: 0x3BC0480 Offset: 0x3BC0581 VA: 0x3BC0480
	|-EqualityComparer<ResourceHandle>.IndexOf
	|
	|-RVA: 0x3BC1010 Offset: 0x3BC1111 VA: 0x3BC1010
	|-EqualityComparer<ResourceLocator>.IndexOf
	|
	|-RVA: 0x3BC1BC0 Offset: 0x3BC1CC1 VA: 0x3BC1BC0
	|-EqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x3BC2750 Offset: 0x3BC2851 VA: 0x3BC2750
	|-EqualityComparer<ShaderTagId>.IndexOf
	|
	|-RVA: 0x3BC32E0 Offset: 0x3BC33E1 VA: 0x3BC32E0
	|-EqualityComparer<float>.IndexOf
	|
	|-RVA: 0x3BC3E90 Offset: 0x3BC3F91 VA: 0x3BC3E90
	|-EqualityComparer<SphericalHarmonicsL2>.IndexOf
	|
	|-RVA: 0x3BC4DE0 Offset: 0x3BC4EE1 VA: 0x3BC4DE0
	|-EqualityComparer<SpriteState>.IndexOf
	|
	|-RVA: 0x3BC5A70 Offset: 0x3BC5B71 VA: 0x3BC5A70
	|-EqualityComparer<SubMeshDescriptor>.IndexOf
	|
	|-RVA: 0x3BC6780 Offset: 0x3BC6881 VA: 0x3BC6780
	|-EqualityComparer<TablePair>.IndexOf
	|
	|-RVA: 0x3BC7330 Offset: 0x3BC7431 VA: 0x3BC7330
	|-EqualityComparer<TimeSpan>.IndexOf
	|
	|-RVA: 0x3BC7EC0 Offset: 0x3BC7FC1 VA: 0x3BC7EC0
	|-EqualityComparer<UICharInfo>.IndexOf
	|
	|-RVA: 0x3BC8AC0 Offset: 0x3BC8BC1 VA: 0x3BC8AC0
	|-EqualityComparer<UILineInfo>.IndexOf
	|
	|-RVA: 0x3BC9670 Offset: 0x3BC9771 VA: 0x3BC9670
	|-EqualityComparer<UIVertex>.IndexOf
	|
	|-RVA: 0x3BCA5C0 Offset: 0x3BCA6C1 VA: 0x3BCA5C0
	|-EqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x3BCB150 Offset: 0x3BCB251 VA: 0x3BCB150
	|-EqualityComparer<uint>.IndexOf
	|
	|-RVA: 0x3BCBCE0 Offset: 0x3BCBDE1 VA: 0x3BCBCE0
	|-EqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x3BCC870 Offset: 0x3BCC971 VA: 0x3BCC870
	|-EqualityComparer<UniTask>.IndexOf
	|
	|-RVA: 0x3BCD400 Offset: 0x3BCD501 VA: 0x3BCD400
	|-EqualityComparer<Unit>.IndexOf
	|
	|-RVA: 0x3BCDF90 Offset: 0x3BCE091 VA: 0x3BCDF90
	|-EqualityComparer<Vector2>.IndexOf
	|
	|-RVA: 0x3BCEB50 Offset: 0x3BCEC51 VA: 0x3BCEB50
	|-EqualityComparer<Vector3>.IndexOf
	|
	|-RVA: 0x3BCF750 Offset: 0x3BCF851 VA: 0x3BCF750
	|-EqualityComparer<Vector4>.IndexOf
	|
	|-RVA: 0x3BD0360 Offset: 0x3BD0461 VA: 0x3BD0360
	|-EqualityComparer<VertexAttributeDescriptor>.IndexOf
	|
	|-RVA: 0x3BD0F10 Offset: 0x3BD1011 VA: 0x3BD0F10
	|-EqualityComparer<X509ChainStatus>.IndexOf
	|
	|-RVA: 0x3BD1AC0 Offset: 0x3BD1BC1 VA: 0x3BD1AC0
	|-EqualityComparer<XPathNodeRef>.IndexOf
	|
	|-RVA: 0x3BD2670 Offset: 0x3BD2771 VA: 0x3BD2670
	|-EqualityComparer<XRView>.IndexOf
	|
	|-RVA: 0x3BD3320 Offset: 0x3BD3421 VA: 0x3BD3320
	|-EqualityComparer<AmiiboSequence.GainItemData>.IndexOf
	|
	|-RVA: 0x3BD3ED0 Offset: 0x3BD3FD1 VA: 0x3BD3ED0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|
	|-RVA: 0x3BD4BF0 Offset: 0x3BD4CF1 VA: 0x3BD4BF0
	|-EqualityComparer<ArenaOrderSequence.GodInfo>.IndexOf
	|
	|-RVA: 0x3BD57A0 Offset: 0x3BD58A1 VA: 0x3BD57A0
	|-EqualityComparer<BattleInfo.SupportData>.IndexOf
	|
	|-RVA: 0x3BD6350 Offset: 0x3BD6451 VA: 0x3BD6350
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.IndexOf
	|
	|-RVA: 0x3BD6F00 Offset: 0x3BD7001 VA: 0x3BD6F00
	|-EqualityComparer<Camera.RenderRequest>.IndexOf
	|
	|-RVA: 0x3BD7BA0 Offset: 0x3BD7CA1 VA: 0x3BD7BA0
	|-EqualityComparer<CameraState.CustomBlendable>.IndexOf
	|
	|-RVA: 0x3BD8750 Offset: 0x3BD8851 VA: 0x3BD8750
	|-EqualityComparer<CinemachineClearShot.Pair>.IndexOf
	|
	|-RVA: 0x3BD92E0 Offset: 0x3BD93E1 VA: 0x3BD92E0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|
	|-RVA: 0x3BD9E70 Offset: 0x3BD9F71 VA: 0x3BD9E70
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.IndexOf
	|
	|-RVA: 0x3B79320 Offset: 0x3B79421 VA: 0x3B79320
	|-EqualityComparer<Detail.AsyncResultInt>.IndexOf
	|
	|-RVA: 0x3B7A030 Offset: 0x3B7A131 VA: 0x3B7A030
	|-EqualityComparer<Detail.CppArray>.IndexOf
	|
	|-RVA: 0x3B7ABE0 Offset: 0x3B7ACE1 VA: 0x3B7ABE0
	|-EqualityComparer<Detail.NotificationEventInt>.IndexOf
	|
	|-RVA: 0x3B7B8F0 Offset: 0x3B7B9F1 VA: 0x3B7B8F0
	|-EqualityComparer<DragonRideTargetGroup.ChainParam>.IndexOf
	|
	|-RVA: 0x3B7C4A0 Offset: 0x3B7C5A1 VA: 0x3B7C4A0
	|-EqualityComparer<DynamicMesh.State>.IndexOf
	|
	|-RVA: 0x3B7D030 Offset: 0x3B7D131 VA: 0x3B7D030
	|-EqualityComparer<GameVariable.Value>.IndexOf
	|
	|-RVA: 0x3B7DBE0 Offset: 0x3B7DCE1 VA: 0x3B7DBE0
	|-EqualityComparer<GmapPathAdjuster.TargetModel>.IndexOf
	|
	|-RVA: 0x3B7E880 Offset: 0x3B7E981 VA: 0x3B7E880
	|-EqualityComparer<GmapSpotAdjuster.TargetModel>.IndexOf
	|
	|-RVA: 0x3B7F520 Offset: 0x3B7F621 VA: 0x3B7F520
	|-EqualityComparer<HubFastTravel.Location>.IndexOf
	|
	|-RVA: 0x3B801C0 Offset: 0x3B802C1 VA: 0x3B801C0
	|-EqualityComparer<HubLensFlare.Flare>.IndexOf
	|
	|-RVA: 0x3B80ED0 Offset: 0x3B80FD1 VA: 0x3B80ED0
	|-EqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.IndexOf
	|
	|-RVA: 0x3B81A80 Offset: 0x3B81B81 VA: 0x3B81A80
	|-EqualityComparer<Map.Pos>.IndexOf
	|
	|-RVA: 0x3B82610 Offset: 0x3B82711 VA: 0x3B82610
	|-EqualityComparer<MapImage.BackupTerrain>.IndexOf
	|
	|-RVA: 0x3B831C0 Offset: 0x3B832C1 VA: 0x3B831C0
	|-EqualityComparer<MapImageRange.Pos>.IndexOf
	|
	|-RVA: 0x3B83D50 Offset: 0x3B83E51 VA: 0x3B83D50
	|-EqualityComparer<MapMind.Record>.IndexOf
	|
	|-RVA: 0x3B84B50 Offset: 0x3B84C51 VA: 0x3B84B50
	|-EqualityComparer<MapMind.Target>.IndexOf
	|
	|-RVA: 0x3B857F0 Offset: 0x3B858F1 VA: 0x3B857F0
	|-EqualityComparer<MapPanelDebug.Entity>.IndexOf
	|
	|-RVA: 0x3B86490 Offset: 0x3B86591 VA: 0x3B86490
	|-EqualityComparer<NexRanking.Data>.IndexOf
	|
	|-RVA: 0x3B87020 Offset: 0x3B87121 VA: 0x3B87020
	|-EqualityComparer<NexVersus.RatingData>.IndexOf
	|
	|-RVA: 0x3B87BD0 Offset: 0x3B87CD1 VA: 0x3B87BD0
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|
	|-RVA: 0x3B88780 Offset: 0x3B88881 VA: 0x3B88780
	|-EqualityComparer<ParticleSystem.Particle>.IndexOf
	|
	|-RVA: 0x3B89430 Offset: 0x3B89531 VA: 0x3B89430
	|-EqualityComparer<QualitySettingsStack.Settings>.IndexOf
	|
	|-RVA: 0x3B8A140 Offset: 0x3B8A241 VA: 0x3B8A140
	|-EqualityComparer<RangeData.Offset>.IndexOf
	|
	|-RVA: 0x3B8ACD0 Offset: 0x3B8ADD1 VA: 0x3B8ACD0
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.IndexOf
	|
	|-RVA: 0x3B8B960 Offset: 0x3B8BA61 VA: 0x3B8B960
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.IndexOf
	|
	|-RVA: 0x3B8C680 Offset: 0x3B8C781 VA: 0x3B8C680
	|-EqualityComparer<RingCleaningUnitSelectMenu.GodParam>.IndexOf
	|
	|-RVA: 0x3B8D230 Offset: 0x3B8D331 VA: 0x3B8D230
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.IndexOf
	|
	|-RVA: 0x3B8DF50 Offset: 0x3B8E051 VA: 0x3B8DF50
	|-EqualityComparer<ShadowUtility.Edge>.IndexOf
	|
	|-RVA: 0x3B8EC60 Offset: 0x3B8ED61 VA: 0x3B8EC60
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.IndexOf
	|
	|-RVA: 0x3B8F810 Offset: 0x3B8F911 VA: 0x3B8F810
	|-EqualityComparer<SkillArray.Entity>.IndexOf
	|
	|-RVA: 0x3B903A0 Offset: 0x3B904A1 VA: 0x3B903A0
	|-EqualityComparer<Stream.Info>.IndexOf
	|
	|-RVA: 0x3B90F70 Offset: 0x3B91071 VA: 0x3B90F70
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x3B91CF0 Offset: 0x3B91DF1 VA: 0x3B91CF0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|
	|-RVA: 0x3B92990 Offset: 0x3B92A91 VA: 0x3B92990
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.IndexOf
	|
	|-RVA: 0x3B93630 Offset: 0x3B93731 VA: 0x3B93630
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IndexOf
	|
	|-RVA: 0x3B941E0 Offset: 0x3B942E1 VA: 0x3B941E0
	|-EqualityComparer<AIThink.EnchantThink.SurroundingInfo>.IndexOf
	|
	|-RVA: 0x3B94D70 Offset: 0x3B94E71 VA: 0x3B94D70
	|-EqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.IndexOf
	|
	|-RVA: 0x3B95920 Offset: 0x3B95A21 VA: 0x3B95920
	|-EqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.IndexOf
	|
	|-RVA: 0x3B965D0 Offset: 0x3B966D1 VA: 0x3B965D0
	|-EqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.IndexOf
	|
	|-RVA: 0x3B97180 Offset: 0x3B97281 VA: 0x3B97180
	|-EqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.IndexOf
	|
	|-RVA: 0x3B97EA0 Offset: 0x3B97FA1 VA: 0x3B97EA0
	|-EqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.IndexOf
	|
	|-RVA: 0x3B98B50 Offset: 0x3B98C51 VA: 0x3B98B50
	|-EqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.IndexOf
	|
	|-RVA: 0x3B997F0 Offset: 0x3B998F1 VA: 0x3B997F0
	|-EqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.IndexOf
	|
	|-RVA: 0x3B9A490 Offset: 0x3B9A591 VA: 0x3B9A490
	|-EqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.IndexOf
	|
	|-RVA: 0x3B9B140 Offset: 0x3B9B241 VA: 0x3B9B140
	|-EqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.IndexOf
	|
	|-RVA: 0x3B9BCF0 Offset: 0x3B9BDF1 VA: 0x3B9BCF0
	|-EqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.IndexOf
	|
	|-RVA: 0x33BD010 Offset: 0x33BD111 VA: 0x33BD010
	|-EqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.IndexOf
	|
	|-RVA: 0x33BDBC0 Offset: 0x33BDCC1 VA: 0x33BDBC0
	|-EqualityComparer<Detail.Ranking.RankingCachedResultInt>.IndexOf
	|
	|-RVA: 0x33BE950 Offset: 0x33BEA51 VA: 0x33BE950
	|-EqualityComparer<Detail.Ranking.RankingOrderParamInt>.IndexOf
	|
	|-RVA: 0x33BF500 Offset: 0x33BF601 VA: 0x33BF500
	|-EqualityComparer<Detail.Ranking.RankingRankDataInt>.IndexOf
	|
	|-RVA: 0x33C0280 Offset: 0x33C0381 VA: 0x33C0280
	|-EqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.IndexOf
	|
	|-RVA: 0x33C10E0 Offset: 0x33C11E1 VA: 0x33C10E0
	|-EqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.IndexOf
	|
	|-RVA: 0x33C1E60 Offset: 0x33C1F61 VA: 0x33C1E60
	|-EqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.IndexOf
	|
	|-RVA: 0x33C2A10 Offset: 0x33C2B11 VA: 0x33C2A10
	|-EqualityComparer<Detail.Screening.ScreeningContextInfoInt>.IndexOf
	|
	|-RVA: 0x33C36A0 Offset: 0x33C37A1 VA: 0x33C36A0
	|-EqualityComparer<Detail.Subscriber.SubscriberContentInt>.IndexOf
	|
	|-RVA: 0x33C44A0 Offset: 0x33C45A1 VA: 0x33C44A0
	|-EqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.IndexOf
	|
	|-RVA: 0x33C5140 Offset: 0x33C5241 VA: 0x33C5140
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.IndexOf
	|
	|-RVA: 0x33C5E60 Offset: 0x33C5F61 VA: 0x33C5E60
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.IndexOf
	|
	|-RVA: 0x33C6B00 Offset: 0x33C6C01 VA: 0x33C6B00
	|-EqualityComparer<Detail.Utility.IntegerSettings>.IndexOf
	|
	|-RVA: 0x33C7690 Offset: 0x33C7791 VA: 0x33C7690
	|-EqualityComparer<Detail.Utility.UniqueIdInfoInt>.IndexOf
	|
	|-RVA: 0x33C8240 Offset: 0x33C8341 VA: 0x33C8240
	|-EqualityComparer<MapHistory.Rewind.LatestInspectorData>.IndexOf
	|
	|-RVA: 0x33C8E10 Offset: 0x33C8F11 VA: 0x33C8E10
	|-EqualityComparer<MapHistory.Rewind.WorkTerrainData>.IndexOf
	|
	|-RVA: 0x33C99E0 Offset: 0x33C9AE1 VA: 0x33C99E0
	|-EqualityComparer<MapSkill.AroundCalculator.Result>.IndexOf
	|
	|-RVA: 0x33CA590 Offset: 0x33CA691 VA: 0x33CA590
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x33CB2A0 Offset: 0x33CB3A1 VA: 0x33CB2A0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x33CBFF0 Offset: 0x33CC0F1 VA: 0x33CBFF0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37689F0 Offset: 0x3768AF1 VA: 0x37689F0
	|-EqualityComparer<AsyncOperationHandle<object>>.LastIndexOf
	|
	|-RVA: 0x3769690 Offset: 0x3769791 VA: 0x3769690
	|-EqualityComparer<IntervalTree.Entry<object>>.LastIndexOf
	|
	|-RVA: 0x376A2E0 Offset: 0x376A3E1 VA: 0x376A2E0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.LastIndexOf
	|
	|-RVA: 0x376AE90 Offset: 0x376AF91 VA: 0x376AE90
	|-EqualityComparer<KeyValuePair<int, object>>.LastIndexOf
	|
	|-RVA: 0x376BA90 Offset: 0x376BB91 VA: 0x376BA90
	|-EqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.LastIndexOf
	|
	|-RVA: 0x376C6D0 Offset: 0x376C7D1 VA: 0x376C6D0
	|-EqualityComparer<KeyValuePair<object, object>>.LastIndexOf
	|
	|-RVA: 0x376D2D0 Offset: 0x376D3D1 VA: 0x376D2D0
	|-EqualityComparer<CommonBattleSequence.Reliance<object>>.LastIndexOf
	|
	|-RVA: 0x376DF20 Offset: 0x376E021 VA: 0x376DF20
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.LastIndexOf
	|
	|-RVA: 0x376EAD0 Offset: 0x376EBD1 VA: 0x376EAD0
	|-EqualityComparer<TimeInterval<object>>.LastIndexOf
	|
	|-RVA: 0x376F6D0 Offset: 0x376F7D1 VA: 0x376F6D0
	|-EqualityComparer<Timestamped<object>>.LastIndexOf
	|
	|-RVA: 0x3770320 Offset: 0x3770421 VA: 0x3770320
	|-EqualityComparer<UniTask<object>>.LastIndexOf
	|
	|-RVA: 0x3770ED0 Offset: 0x3770FD1 VA: 0x3770ED0
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3771AD0 Offset: 0x3771BD1 VA: 0x3771AD0
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3772760 Offset: 0x3772861 VA: 0x3772760
	|-EqualityComparer<ValueTuple<bool, UniTask<object>>>.LastIndexOf
	|
	|-RVA: 0x3773400 Offset: 0x3773501 VA: 0x3773400
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.LastIndexOf
	|
	|-RVA: 0x37740B0 Offset: 0x37741B1 VA: 0x37740B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.LastIndexOf
	|
	|-RVA: 0x3774DD0 Offset: 0x3774ED1 VA: 0x3774DD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3775A70 Offset: 0x3775B71 VA: 0x3775A70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.LastIndexOf
	|
	|-RVA: 0x3776640 Offset: 0x3776741 VA: 0x3776640
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.LastIndexOf
	|
	|-RVA: 0x37772A0 Offset: 0x37773A1 VA: 0x37772A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.LastIndexOf
	|
	|-RVA: 0x3777F90 Offset: 0x3778091 VA: 0x3777F90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.LastIndexOf
	|
	|-RVA: 0x3778BE0 Offset: 0x3778CE1 VA: 0x3778BE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.LastIndexOf
	|
	|-RVA: 0x3779920 Offset: 0x3779A21 VA: 0x3779920
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.LastIndexOf
	|
	|-RVA: 0x377A610 Offset: 0x377A711 VA: 0x377A610
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.LastIndexOf
	|
	|-RVA: 0x377B2D0 Offset: 0x377B3D1 VA: 0x377B2D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.LastIndexOf
	|
	|-RVA: 0x377BFE0 Offset: 0x377C0E1 VA: 0x377BFE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x377CD00 Offset: 0x377CE01 VA: 0x377CD00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.LastIndexOf
	|
	|-RVA: 0x377DA50 Offset: 0x377DB51 VA: 0x377DA50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.LastIndexOf
	|
	|-RVA: 0x377E770 Offset: 0x377E871 VA: 0x377E770
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.LastIndexOf
	|
	|-RVA: 0x37E8580 Offset: 0x37E8681 VA: 0x37E8580
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.LastIndexOf
	|
	|-RVA: 0x37E9220 Offset: 0x37E9321 VA: 0x37E9220
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.LastIndexOf
	|
	|-RVA: 0x37E9E60 Offset: 0x37E9F61 VA: 0x37E9E60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.LastIndexOf
	|
	|-RVA: 0x37EAB50 Offset: 0x37EAC51 VA: 0x37EAB50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.LastIndexOf
	|
	|-RVA: 0x37EB810 Offset: 0x37EB911 VA: 0x37EB810
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.LastIndexOf
	|
	|-RVA: 0x37EC550 Offset: 0x37EC651 VA: 0x37EC550
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x37ED260 Offset: 0x37ED361 VA: 0x37ED260
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x37EDF90 Offset: 0x37EE091 VA: 0x37EDF90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x37EED20 Offset: 0x37EEE21 VA: 0x37EED20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x37EFAC0 Offset: 0x37EFBC1 VA: 0x37EFAC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x37F08C0 Offset: 0x37F09C1 VA: 0x37F08C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x37F16D0 Offset: 0x37F17D1 VA: 0x37F16D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x37F2470 Offset: 0x37F2571 VA: 0x37F2470
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.LastIndexOf
	|
	|-RVA: 0x37F3040 Offset: 0x37F3141 VA: 0x37F3040
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.LastIndexOf
	|
	|-RVA: 0x37F3C70 Offset: 0x37F3D71 VA: 0x37F3C70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.LastIndexOf
	|
	|-RVA: 0x37F4930 Offset: 0x37F4A31 VA: 0x37F4930
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.LastIndexOf
	|
	|-RVA: 0x37F5540 Offset: 0x37F5641 VA: 0x37F5540
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.LastIndexOf
	|
	|-RVA: 0x37F61F0 Offset: 0x37F62F1 VA: 0x37F61F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.LastIndexOf
	|
	|-RVA: 0x37F6EF0 Offset: 0x37F6FF1 VA: 0x37F6EF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.LastIndexOf
	|
	|-RVA: 0x37F7BB0 Offset: 0x37F7CB1 VA: 0x37F7BB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.LastIndexOf
	|
	|-RVA: 0x37F88D0 Offset: 0x37F89D1 VA: 0x37F88D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x37F95D0 Offset: 0x37F96D1 VA: 0x37F95D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.LastIndexOf
	|
	|-RVA: 0x37FA260 Offset: 0x37FA361 VA: 0x37FA260
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.LastIndexOf
	|
	|-RVA: 0x37FAEF0 Offset: 0x37FAFF1 VA: 0x37FAEF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.LastIndexOf
	|
	|-RVA: 0x37FBBB0 Offset: 0x37FBCB1 VA: 0x37FBBB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.LastIndexOf
	|
	|-RVA: 0x37FC870 Offset: 0x37FC971 VA: 0x37FC870
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.LastIndexOf
	|
	|-RVA: 0x37FD480 Offset: 0x37FD581 VA: 0x37FD480
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.LastIndexOf
	|
	|-RVA: 0x37FE140 Offset: 0x37FE241 VA: 0x37FE140
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.LastIndexOf
	|
	|-RVA: 0x37FEE30 Offset: 0x37FEF31 VA: 0x37FEE30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.LastIndexOf
	|
	|-RVA: 0x37FFAE0 Offset: 0x37FFBE1 VA: 0x37FFAE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3800800 Offset: 0x3800901 VA: 0x3800800
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3801540 Offset: 0x3801641 VA: 0x3801540
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x38022A0 Offset: 0x38023A1 VA: 0x38022A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3802FF0 Offset: 0x38030F1 VA: 0x3802FF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3803DC0 Offset: 0x3803EC1 VA: 0x3803DC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3804B90 Offset: 0x3804C91 VA: 0x3804B90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x38059B0 Offset: 0x3805AB1 VA: 0x38059B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3806790 Offset: 0x3806891 VA: 0x3806790
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3807630 Offset: 0x3807731 VA: 0x3807630
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3808490 Offset: 0x3808591 VA: 0x3808490
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x3809380 Offset: 0x3809481 VA: 0x3809380
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.LastIndexOf
	|
	|-RVA: 0x380A0C0 Offset: 0x380A1C1 VA: 0x380A0C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.LastIndexOf
	|
	|-RVA: 0x380AC50 Offset: 0x380AD51 VA: 0x380AC50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.LastIndexOf
	|
	|-RVA: 0x380B860 Offset: 0x380B961 VA: 0x380B860
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.LastIndexOf
	|
	|-RVA: 0x380C530 Offset: 0x380C631 VA: 0x380C530
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.LastIndexOf
	|
	|-RVA: 0x380D130 Offset: 0x380D231 VA: 0x380D130
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.LastIndexOf
	|
	|-RVA: 0x39A0CE0 Offset: 0x39A0DE1 VA: 0x39A0CE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.LastIndexOf
	|
	|-RVA: 0x39A1920 Offset: 0x39A1A21 VA: 0x39A1920
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.LastIndexOf
	|
	|-RVA: 0x39A2520 Offset: 0x39A2621 VA: 0x39A2520
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.LastIndexOf
	|
	|-RVA: 0x39A31B0 Offset: 0x39A32B1 VA: 0x39A31B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x39A3E60 Offset: 0x39A3F61 VA: 0x39A3E60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.LastIndexOf
	|
	|-RVA: 0x39A4B70 Offset: 0x39A4C71 VA: 0x39A4B70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.LastIndexOf
	|
	|-RVA: 0x39A5810 Offset: 0x39A5911 VA: 0x39A5810
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.LastIndexOf
	|
	|-RVA: 0x39A6410 Offset: 0x39A6511 VA: 0x39A6410
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.LastIndexOf
	|
	|-RVA: 0x39A7050 Offset: 0x39A7151 VA: 0x39A7050
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.LastIndexOf
	|
	|-RVA: 0x39A7C30 Offset: 0x39A7D31 VA: 0x39A7C30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.LastIndexOf
	|
	|-RVA: 0x39A88D0 Offset: 0x39A89D1 VA: 0x39A88D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.LastIndexOf
	|
	|-RVA: 0x39A9590 Offset: 0x39A9691 VA: 0x39A9590
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.LastIndexOf
	|
	|-RVA: 0x39AA280 Offset: 0x39AA381 VA: 0x39AA280
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.LastIndexOf
	|
	|-RVA: 0x39AAF10 Offset: 0x39AB011 VA: 0x39AAF10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.LastIndexOf
	|
	|-RVA: 0x39ABBE0 Offset: 0x39ABCE1 VA: 0x39ABBE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x39AC950 Offset: 0x39ACA51 VA: 0x39AC950
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x39AD6B0 Offset: 0x39AD7B1 VA: 0x39AD6B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x39AE470 Offset: 0x39AE571 VA: 0x39AE470
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x39AF1E0 Offset: 0x39AF2E1 VA: 0x39AF1E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x39B0000 Offset: 0x39B0101 VA: 0x39B0000
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x39B0DF0 Offset: 0x39B0EF1 VA: 0x39B0DF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x39B1C70 Offset: 0x39B1D71 VA: 0x39B1C70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x39B2A70 Offset: 0x39B2B71 VA: 0x39B2A70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x39B3960 Offset: 0x39B3A61 VA: 0x39B3960
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.LastIndexOf
	|
	|-RVA: 0x39B4700 Offset: 0x39B4801 VA: 0x39B4700
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x39B53B0 Offset: 0x39B54B1 VA: 0x39B53B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.LastIndexOf
	|
	|-RVA: 0x39B6020 Offset: 0x39B6121 VA: 0x39B6020
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.LastIndexOf
	|
	|-RVA: 0x39B6BF0 Offset: 0x39B6CF1 VA: 0x39B6BF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.LastIndexOf
	|
	|-RVA: 0x39B7800 Offset: 0x39B7901 VA: 0x39B7800
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.LastIndexOf
	|
	|-RVA: 0x39B8450 Offset: 0x39B8551 VA: 0x39B8450
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.LastIndexOf
	|
	|-RVA: 0x39B9060 Offset: 0x39B9161 VA: 0x39B9060
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.LastIndexOf
	|
	|-RVA: 0x39B9D00 Offset: 0x39B9E01 VA: 0x39B9D00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.LastIndexOf
	|
	|-RVA: 0x39BA960 Offset: 0x39BAA61 VA: 0x39BA960
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.LastIndexOf
	|
	|-RVA: 0x39BB570 Offset: 0x39BB671 VA: 0x39BB570
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.LastIndexOf
	|
	|-RVA: 0x39BC210 Offset: 0x39BC311 VA: 0x39BC210
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x39BCEB0 Offset: 0x39BCFB1 VA: 0x39BCEB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.LastIndexOf
	|
	|-RVA: 0x39BDB50 Offset: 0x39BDC51 VA: 0x39BDB50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.LastIndexOf
	|
	|-RVA: 0x39BE7B0 Offset: 0x39BE8B1 VA: 0x39BE7B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.LastIndexOf
	|
	|-RVA: 0x39BF3C0 Offset: 0x39BF4C1 VA: 0x39BF3C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.LastIndexOf
	|
	|-RVA: 0x39C0020 Offset: 0x39C0121 VA: 0x39C0020
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.LastIndexOf
	|
	|-RVA: 0x39C0BE0 Offset: 0x39C0CE1 VA: 0x39C0BE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.LastIndexOf
	|
	|-RVA: 0x39C17E0 Offset: 0x39C18E1 VA: 0x39C17E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.LastIndexOf
	|
	|-RVA: 0x39C2480 Offset: 0x39C2581 VA: 0x39C2480
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.LastIndexOf
	|
	|-RVA: 0x39C3120 Offset: 0x39C3221 VA: 0x39C3120
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.LastIndexOf
	|
	|-RVA: 0x39C3DC0 Offset: 0x39C3EC1 VA: 0x39C3DC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.LastIndexOf
	|
	|-RVA: 0x39C4A80 Offset: 0x39C4B81 VA: 0x39C4A80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3ADB390 Offset: 0x3ADB491 VA: 0x3ADB390
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3ADC060 Offset: 0x3ADC161 VA: 0x3ADC060
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3ADCDC0 Offset: 0x3ADCEC1 VA: 0x3ADCDC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3ADDB20 Offset: 0x3ADDC21 VA: 0x3ADDB20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3ADE8D0 Offset: 0x3ADE9D1 VA: 0x3ADE8D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3ADF640 Offset: 0x3ADF741 VA: 0x3ADF640
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3AE0460 Offset: 0x3AE0561 VA: 0x3AE0460
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3AE1250 Offset: 0x3AE1351 VA: 0x3AE1250
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3AE20D0 Offset: 0x3AE21D1 VA: 0x3AE20D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.LastIndexOf
	|
	|-RVA: 0x3AE2ED0 Offset: 0x3AE2FD1 VA: 0x3AE2ED0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3AE3D60 Offset: 0x3AE3E61 VA: 0x3AE3D60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.LastIndexOf
	|
	|-RVA: 0x3AE49C0 Offset: 0x3AE4AC1 VA: 0x3AE49C0
	|-EqualityComparer<ValueTuple<bool, AsyncUnit>>.LastIndexOf
	|
	|-RVA: 0x3AE5550 Offset: 0x3AE5651 VA: 0x3AE5550
	|-EqualityComparer<ValueTuple<bool, bool>>.LastIndexOf
	|
	|-RVA: 0x3AE6150 Offset: 0x3AE6251 VA: 0x3AE6150
	|-EqualityComparer<ValueTuple<bool, Bounds>>.LastIndexOf
	|
	|-RVA: 0x3AE6DF0 Offset: 0x3AE6EF1 VA: 0x3AE6DF0
	|-EqualityComparer<ValueTuple<bool, byte>>.LastIndexOf
	|
	|-RVA: 0x3AE79D0 Offset: 0x3AE7AD1 VA: 0x3AE79D0
	|-EqualityComparer<ValueTuple<bool, Color>>.LastIndexOf
	|
	|-RVA: 0x3AE8620 Offset: 0x3AE8721 VA: 0x3AE8620
	|-EqualityComparer<ValueTuple<bool, double>>.LastIndexOf
	|
	|-RVA: 0x3AE91D0 Offset: 0x3AE92D1 VA: 0x3AE91D0
	|-EqualityComparer<ValueTuple<bool, int>>.LastIndexOf
	|
	|-RVA: 0x3AE9D60 Offset: 0x3AE9E61 VA: 0x3AE9D60
	|-EqualityComparer<ValueTuple<bool, long>>.LastIndexOf
	|
	|-RVA: 0x3AEA910 Offset: 0x3AEAA11 VA: 0x3AEA910
	|-EqualityComparer<ValueTuple<bool, object>>.LastIndexOf
	|
	|-RVA: 0x3AEB510 Offset: 0x3AEB611 VA: 0x3AEB510
	|-EqualityComparer<ValueTuple<bool, Quaternion>>.LastIndexOf
	|
	|-RVA: 0x3AEC1B0 Offset: 0x3AEC2B1 VA: 0x3AEC1B0
	|-EqualityComparer<ValueTuple<bool, Rect>>.LastIndexOf
	|
	|-RVA: 0x3AECE00 Offset: 0x3AECF01 VA: 0x3AECE00
	|-EqualityComparer<ValueTuple<bool, float>>.LastIndexOf
	|
	|-RVA: 0x3AED990 Offset: 0x3AEDA91 VA: 0x3AED990
	|-EqualityComparer<ValueTuple<bool, UniTask>>.LastIndexOf
	|
	|-RVA: 0x3AEE540 Offset: 0x3AEE641 VA: 0x3AEE540
	|-EqualityComparer<ValueTuple<bool, Unit>>.LastIndexOf
	|
	|-RVA: 0x3AEF0E0 Offset: 0x3AEF1E1 VA: 0x3AEF0E0
	|-EqualityComparer<ValueTuple<bool, Vector2>>.LastIndexOf
	|
	|-RVA: 0x3AEFCA0 Offset: 0x3AEFDA1 VA: 0x3AEFCA0
	|-EqualityComparer<ValueTuple<bool, Vector3>>.LastIndexOf
	|
	|-RVA: 0x3AF08A0 Offset: 0x3AF09A1 VA: 0x3AF08A0
	|-EqualityComparer<ValueTuple<bool, Vector4>>.LastIndexOf
	|
	|-RVA: 0x3AF14F0 Offset: 0x3AF15F1 VA: 0x3AF14F0
	|-EqualityComparer<ValueTuple<int, object>>.LastIndexOf
	|
	|-RVA: 0x3AF20A0 Offset: 0x3AF21A1 VA: 0x3AF20A0
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3AF2C80 Offset: 0x3AF2D81 VA: 0x3AF2C80
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.LastIndexOf
	|
	|-RVA: 0x3AF38D0 Offset: 0x3AF39D1 VA: 0x3AF38D0
	|-EqualityComparer<ValueTuple<object, int>>.LastIndexOf
	|
	|-RVA: 0x3AF4480 Offset: 0x3AF4581 VA: 0x3AF4480
	|-EqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|
	|-RVA: 0x3AF5030 Offset: 0x3AF5131 VA: 0x3AF5030
	|-EqualityComparer<ValueTuple<object, float>>.LastIndexOf
	|
	|-RVA: 0x3AF5C00 Offset: 0x3AF5D01 VA: 0x3AF5C00
	|-EqualityComparer<ValueTuple<Vector3, float>>.LastIndexOf
	|
	|-RVA: 0x3AF6860 Offset: 0x3AF6961 VA: 0x3AF6860
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3AF7510 Offset: 0x3AF7611 VA: 0x3AF7510
	|-EqualityComparer<ValueTuple<object, Int32Enum, int>>.LastIndexOf
	|
	|-RVA: 0x3AF8110 Offset: 0x3AF8211 VA: 0x3AF8110
	|-EqualityComparer<ValueTuple<object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3AF8DF0 Offset: 0x3AF8EF1 VA: 0x3AF8DF0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3AF9B40 Offset: 0x3AF9C41 VA: 0x3AF9B40
	|-EqualityComparer<ValueTuple<object, int, int, int>>.LastIndexOf
	|
	|-RVA: 0x3AFA7E0 Offset: 0x3AFA8E1 VA: 0x3AFA7E0
	|-EqualityComparer<ValueTuple<object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3AFB4D0 Offset: 0x3AFB5D1 VA: 0x3AFB4D0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3AFC290 Offset: 0x3AFC391 VA: 0x3AFC290
	|-EqualityComparer<ValueTuple<object, object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3AFD010 Offset: 0x3AFD111 VA: 0x3AFD010
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3AFDE10 Offset: 0x3AFDF11 VA: 0x3AFDE10
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3AFEBA0 Offset: 0x3AFECA1 VA: 0x3AFEBA0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.LastIndexOf
	|
	|-RVA: 0x3BDAC50 Offset: 0x3BDAD51 VA: 0x3BDAC50
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.LastIndexOf
	|
	|-RVA: 0x3BDBA60 Offset: 0x3BDBB61 VA: 0x3BDBA60
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3BDC8F0 Offset: 0x3BDC9F1 VA: 0x3BDC8F0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.LastIndexOf
	|
	|-RVA: 0x3BDD550 Offset: 0x3BDD651 VA: 0x3BDD550
	|-EqualityComparer<AnimatorClipInfo>.LastIndexOf
	|
	|-RVA: 0x3BDE130 Offset: 0x3BDE231 VA: 0x3BDE130
	|-EqualityComparer<AsyncOperationHandle>.LastIndexOf
	|
	|-RVA: 0x3BDED80 Offset: 0x3BDEE81 VA: 0x3BDED80
	|-EqualityComparer<AsyncUnit>.LastIndexOf
	|
	|-RVA: 0x3BDF960 Offset: 0x3BDFA61 VA: 0x3BDF960
	|-EqualityComparer<BoneWeight>.LastIndexOf
	|
	|-RVA: 0x3BE05A0 Offset: 0x3BE06A1 VA: 0x3BE05A0
	|-EqualityComparer<bool>.LastIndexOf
	|
	|-RVA: 0x3BE1190 Offset: 0x3BE1291 VA: 0x3BE1190
	|-EqualityComparer<Bounds>.LastIndexOf
	|
	|-RVA: 0x3BE1DE0 Offset: 0x3BE1EE1 VA: 0x3BE1DE0
	|-EqualityComparer<byte>.LastIndexOf
	|
	|-RVA: 0x3BE2970 Offset: 0x3BE2A71 VA: 0x3BE2970
	|-EqualityComparer<CameraInfo>.LastIndexOf
	|
	|-RVA: 0x3BE3520 Offset: 0x3BE3621 VA: 0x3BE3520
	|-EqualityComparer<CancellationToken>.LastIndexOf
	|
	|-RVA: 0x3BE4100 Offset: 0x3BE4201 VA: 0x3BE4100
	|-EqualityComparer<CancellationTokenRegistration>.LastIndexOf
	|
	|-RVA: 0x3BE4D50 Offset: 0x3BE4E51 VA: 0x3BE4D50
	|-EqualityComparer<char>.LastIndexOf
	|
	|-RVA: 0x3BE5900 Offset: 0x3BE5A01 VA: 0x3BE5900
	|-EqualityComparer<Color>.LastIndexOf
	|
	|-RVA: 0x3BE64F0 Offset: 0x3BE65F1 VA: 0x3BE64F0
	|-EqualityComparer<Color32>.LastIndexOf
	|
	|-RVA: 0x3BE7150 Offset: 0x3BE7251 VA: 0x3BE7150
	|-EqualityComparer<ColorBlock>.LastIndexOf
	|
	|-RVA: 0x3BE7EE0 Offset: 0x3BE7FE1 VA: 0x3BE7EE0
	|-EqualityComparer<ConstraintSource>.LastIndexOf
	|
	|-RVA: 0x3BE8AE0 Offset: 0x3BE8BE1 VA: 0x3BE8AE0
	|-EqualityComparer<ContourVertex>.LastIndexOf
	|
	|-RVA: 0x3BE9780 Offset: 0x3BE9881 VA: 0x3BE9780
	|-EqualityComparer<DataStoreRatingInfo>.LastIndexOf
	|
	|-RVA: 0x3BEA3D0 Offset: 0x3BEA4D1 VA: 0x3BEA3D0
	|-EqualityComparer<DataStoreResult>.LastIndexOf
	|
	|-RVA: 0x3BEAF60 Offset: 0x3BEB061 VA: 0x3BEAF60
	|-EqualityComparer<DateTime>.LastIndexOf
	|
	|-RVA: 0x3BEBAF0 Offset: 0x3BEBBF1 VA: 0x3BEBAF0
	|-EqualityComparer<DateTimeOffset>.LastIndexOf
	|
	|-RVA: 0x3BEC6A0 Offset: 0x3BEC7A1 VA: 0x3BEC6A0
	|-EqualityComparer<Decimal>.LastIndexOf
	|
	|-RVA: 0x3BED2C0 Offset: 0x3BED3C1 VA: 0x3BED2C0
	|-EqualityComparer<DiagnosticEvent>.LastIndexOf
	|
	|-RVA: 0x3BEDF60 Offset: 0x3BEE061 VA: 0x3BEDF60
	|-EqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x3BEEB10 Offset: 0x3BEEC11 VA: 0x3BEEB10
	|-EqualityComparer<FXZ>.LastIndexOf
	|
	|-RVA: 0x3BEF720 Offset: 0x3BEF821 VA: 0x3BEF720
	|-EqualityComparer<Friend>.LastIndexOf
	|
	|-RVA: 0x3BF0380 Offset: 0x3BF0481 VA: 0x3BF0380
	|-EqualityComparer<GlyphRect>.LastIndexOf
	|
	|-RVA: 0x3BF0F30 Offset: 0x3BF1031 VA: 0x3BF0F30
	|-EqualityComparer<Guid>.LastIndexOf
	|
	|-RVA: 0x3BF1AE0 Offset: 0x3BF1BE1 VA: 0x3BF1AE0
	|-EqualityComparer<short>.LastIndexOf
	|
	|-RVA: 0x3BF2670 Offset: 0x3BF2771 VA: 0x3BF2670
	|-EqualityComparer<int>.LastIndexOf
	|
	|-RVA: 0x3BF3200 Offset: 0x3BF3301 VA: 0x3BF3200
	|-EqualityComparer<Int32Enum>.LastIndexOf
	|
	|-RVA: 0x3BF3D90 Offset: 0x3BF3E91 VA: 0x3BF3D90
	|-EqualityComparer<long>.LastIndexOf
	|
	|-RVA: 0x3BF4920 Offset: 0x3BF4A21 VA: 0x3BF4920
	|-EqualityComparer<Int64Enum>.LastIndexOf
	|
	|-RVA: 0x3BF54B0 Offset: 0x3BF55B1 VA: 0x3BF54B0
	|-EqualityComparer<IntPtr>.LastIndexOf
	|
	|-RVA: 0x3BF6040 Offset: 0x3BF6141 VA: 0x3BF6040
	|-EqualityComparer<InterpretedFrameInfo>.LastIndexOf
	|
	|-RVA: 0x3BF6C40 Offset: 0x3BF6D41 VA: 0x3BF6C40
	|-EqualityComparer<IntervalTreeNode>.LastIndexOf
	|
	|-RVA: 0x3BF7890 Offset: 0x3BF7991 VA: 0x3BF7890
	|-EqualityComparer<LayerMask>.LastIndexOf
	|
	|-RVA: 0x3BF8420 Offset: 0x3BF8521 VA: 0x3BF8420
	|-EqualityComparer<LengthLimitProperties>.LastIndexOf
	|
	|-RVA: 0x3BF8FB0 Offset: 0x3BF90B1 VA: 0x3BF8FB0
	|-EqualityComparer<MapPos>.LastIndexOf
	|
	|-RVA: 0x3BF9BD0 Offset: 0x3BF9CD1 VA: 0x3BF9BD0
	|-EqualityComparer<Matrix4x4>.LastIndexOf
	|
	|-RVA: 0x3BFA930 Offset: 0x3BFAA31 VA: 0x3BFA930
	|-EqualityComparer<Navigation>.LastIndexOf
	|
	|-RVA: 0x3BFB5E0 Offset: 0x3BFB6E1 VA: 0x3BFB5E0
	|-EqualityComparer<object>.LastIndexOf
	|-EqualityComparer<string>.LastIndexOf
	|
	|-RVA: 0x3BFC1D0 Offset: 0x3BFC2D1 VA: 0x3BFC1D0
	|-EqualityComparer<ObjectInitializationData>.LastIndexOf
	|
	|-RVA: 0x3BFCE70 Offset: 0x3BFCF71 VA: 0x3BFCE70
	|-EqualityComparer<Playable>.LastIndexOf
	|
	|-RVA: 0x3BB7CD0 Offset: 0x3BB7DD1 VA: 0x3BB7CD0
	|-EqualityComparer<PlayableBinding>.LastIndexOf
	|
	|-RVA: 0x3BB8980 Offset: 0x3BB8A81 VA: 0x3BB8980
	|-EqualityComparer<PlayerLoopSystem>.LastIndexOf
	|
	|-RVA: 0x3BB96A0 Offset: 0x3BB97A1 VA: 0x3BB96A0
	|-EqualityComparer<PlayerLoopSystemInternal>.LastIndexOf
	|
	|-RVA: 0x3BBA370 Offset: 0x3BBA471 VA: 0x3BBA370
	|-EqualityComparer<Quaternion>.LastIndexOf
	|
	|-RVA: 0x3BBAF60 Offset: 0x3BBB061 VA: 0x3BBAF60
	|-EqualityComparer<RandomSeed>.LastIndexOf
	|
	|-RVA: 0x3BBBB10 Offset: 0x3BBBC11 VA: 0x3BBBB10
	|-EqualityComparer<RangePositionInfo>.LastIndexOf
	|
	|-RVA: 0x3BBC6C0 Offset: 0x3BBC7C1 VA: 0x3BBC6C0
	|-EqualityComparer<Ranking2ChartInfoInput>.LastIndexOf
	|
	|-RVA: 0x3BBD2D0 Offset: 0x3BBD3D1 VA: 0x3BBD2D0
	|-EqualityComparer<RaycastHit2D>.LastIndexOf
	|
	|-RVA: 0x3BBE050 Offset: 0x3BBE151 VA: 0x3BBE050
	|-EqualityComparer<RaycastResult>.LastIndexOf
	|
	|-RVA: 0x3BBEDC0 Offset: 0x3BBEEC1 VA: 0x3BBEDC0
	|-EqualityComparer<Rect>.LastIndexOf
	|
	|-RVA: 0x3BBF9B0 Offset: 0x3BBFAB1 VA: 0x3BBF9B0
	|-EqualityComparer<RendererListHandle>.LastIndexOf
	|
	|-RVA: 0x3BC0540 Offset: 0x3BC0641 VA: 0x3BC0540
	|-EqualityComparer<ResourceHandle>.LastIndexOf
	|
	|-RVA: 0x3BC10D0 Offset: 0x3BC11D1 VA: 0x3BC10D0
	|-EqualityComparer<ResourceLocator>.LastIndexOf
	|
	|-RVA: 0x3BC1C80 Offset: 0x3BC1D81 VA: 0x3BC1C80
	|-EqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x3BC2810 Offset: 0x3BC2911 VA: 0x3BC2810
	|-EqualityComparer<ShaderTagId>.LastIndexOf
	|
	|-RVA: 0x3BC33A0 Offset: 0x3BC34A1 VA: 0x3BC33A0
	|-EqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x3BC4060 Offset: 0x3BC4161 VA: 0x3BC4060
	|-EqualityComparer<SphericalHarmonicsL2>.LastIndexOf
	|
	|-RVA: 0x3BC4EF0 Offset: 0x3BC4FF1 VA: 0x3BC4EF0
	|-EqualityComparer<SpriteState>.LastIndexOf
	|
	|-RVA: 0x3BC5BA0 Offset: 0x3BC5CA1 VA: 0x3BC5BA0
	|-EqualityComparer<SubMeshDescriptor>.LastIndexOf
	|
	|-RVA: 0x3BC6840 Offset: 0x3BC6941 VA: 0x3BC6840
	|-EqualityComparer<TablePair>.LastIndexOf
	|
	|-RVA: 0x3BC73F0 Offset: 0x3BC74F1 VA: 0x3BC73F0
	|-EqualityComparer<TimeSpan>.LastIndexOf
	|
	|-RVA: 0x3BC7FA0 Offset: 0x3BC80A1 VA: 0x3BC7FA0
	|-EqualityComparer<UICharInfo>.LastIndexOf
	|
	|-RVA: 0x3BC8B80 Offset: 0x3BC8C81 VA: 0x3BC8B80
	|-EqualityComparer<UILineInfo>.LastIndexOf
	|
	|-RVA: 0x3BC9840 Offset: 0x3BC9941 VA: 0x3BC9840
	|-EqualityComparer<UIVertex>.LastIndexOf
	|
	|-RVA: 0x3BCA680 Offset: 0x3BCA781 VA: 0x3BCA680
	|-EqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x3BCB210 Offset: 0x3BCB311 VA: 0x3BCB210
	|-EqualityComparer<uint>.LastIndexOf
	|
	|-RVA: 0x3BCBDA0 Offset: 0x3BCBEA1 VA: 0x3BCBDA0
	|-EqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x3BCC930 Offset: 0x3BCCA31 VA: 0x3BCC930
	|-EqualityComparer<UniTask>.LastIndexOf
	|
	|-RVA: 0x3BCD4C0 Offset: 0x3BCD5C1 VA: 0x3BCD4C0
	|-EqualityComparer<Unit>.LastIndexOf
	|
	|-RVA: 0x3BCE050 Offset: 0x3BCE151 VA: 0x3BCE050
	|-EqualityComparer<Vector2>.LastIndexOf
	|
	|-RVA: 0x3BCEC30 Offset: 0x3BCED31 VA: 0x3BCEC30
	|-EqualityComparer<Vector3>.LastIndexOf
	|
	|-RVA: 0x3BCF830 Offset: 0x3BCF931 VA: 0x3BCF830
	|-EqualityComparer<Vector4>.LastIndexOf
	|
	|-RVA: 0x3BD0420 Offset: 0x3BD0521 VA: 0x3BD0420
	|-EqualityComparer<VertexAttributeDescriptor>.LastIndexOf
	|
	|-RVA: 0x3BD0FD0 Offset: 0x3BD10D1 VA: 0x3BD0FD0
	|-EqualityComparer<X509ChainStatus>.LastIndexOf
	|
	|-RVA: 0x3BD1B80 Offset: 0x3BD1C81 VA: 0x3BD1B80
	|-EqualityComparer<XPathNodeRef>.LastIndexOf
	|
	|-RVA: 0x3BD2780 Offset: 0x3BD2881 VA: 0x3BD2780
	|-EqualityComparer<XRView>.LastIndexOf
	|
	|-RVA: 0x3BD33E0 Offset: 0x3BD34E1 VA: 0x3BD33E0
	|-EqualityComparer<AmiiboSequence.GainItemData>.LastIndexOf
	|
	|-RVA: 0x3BD4000 Offset: 0x3BD4101 VA: 0x3BD4000
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.LastIndexOf
	|
	|-RVA: 0x3BD4CB0 Offset: 0x3BD4DB1 VA: 0x3BD4CB0
	|-EqualityComparer<ArenaOrderSequence.GodInfo>.LastIndexOf
	|
	|-RVA: 0x3BD5860 Offset: 0x3BD5961 VA: 0x3BD5860
	|-EqualityComparer<BattleInfo.SupportData>.LastIndexOf
	|
	|-RVA: 0x3BD6410 Offset: 0x3BD6511 VA: 0x3BD6410
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.LastIndexOf
	|
	|-RVA: 0x3BD7010 Offset: 0x3BD7111 VA: 0x3BD7010
	|-EqualityComparer<Camera.RenderRequest>.LastIndexOf
	|
	|-RVA: 0x3BD7C60 Offset: 0x3BD7D61 VA: 0x3BD7C60
	|-EqualityComparer<CameraState.CustomBlendable>.LastIndexOf
	|
	|-RVA: 0x3BD8810 Offset: 0x3BD8911 VA: 0x3BD8810
	|-EqualityComparer<CinemachineClearShot.Pair>.LastIndexOf
	|
	|-RVA: 0x3BD93A0 Offset: 0x3BD94A1 VA: 0x3BD93A0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.LastIndexOf
	|
	|-RVA: 0x3BD9F80 Offset: 0x3BDA081 VA: 0x3BD9F80
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.LastIndexOf
	|
	|-RVA: 0x3B79450 Offset: 0x3B79551 VA: 0x3B79450
	|-EqualityComparer<Detail.AsyncResultInt>.LastIndexOf
	|
	|-RVA: 0x3B7A0F0 Offset: 0x3B7A1F1 VA: 0x3B7A0F0
	|-EqualityComparer<Detail.CppArray>.LastIndexOf
	|
	|-RVA: 0x3B7AD10 Offset: 0x3B7AE11 VA: 0x3B7AD10
	|-EqualityComparer<Detail.NotificationEventInt>.LastIndexOf
	|
	|-RVA: 0x3B7B9B0 Offset: 0x3B7BAB1 VA: 0x3B7B9B0
	|-EqualityComparer<DragonRideTargetGroup.ChainParam>.LastIndexOf
	|
	|-RVA: 0x3B7C560 Offset: 0x3B7C661 VA: 0x3B7C560
	|-EqualityComparer<DynamicMesh.State>.LastIndexOf
	|
	|-RVA: 0x3B7D0F0 Offset: 0x3B7D1F1 VA: 0x3B7D0F0
	|-EqualityComparer<GameVariable.Value>.LastIndexOf
	|
	|-RVA: 0x3B7DCF0 Offset: 0x3B7DDF1 VA: 0x3B7DCF0
	|-EqualityComparer<GmapPathAdjuster.TargetModel>.LastIndexOf
	|
	|-RVA: 0x3B7E990 Offset: 0x3B7EA91 VA: 0x3B7E990
	|-EqualityComparer<GmapSpotAdjuster.TargetModel>.LastIndexOf
	|
	|-RVA: 0x3B7F630 Offset: 0x3B7F731 VA: 0x3B7F630
	|-EqualityComparer<HubFastTravel.Location>.LastIndexOf
	|
	|-RVA: 0x3B802F0 Offset: 0x3B803F1 VA: 0x3B802F0
	|-EqualityComparer<HubLensFlare.Flare>.LastIndexOf
	|
	|-RVA: 0x3B80F90 Offset: 0x3B81091 VA: 0x3B80F90
	|-EqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.LastIndexOf
	|
	|-RVA: 0x3B81B40 Offset: 0x3B81C41 VA: 0x3B81B40
	|-EqualityComparer<Map.Pos>.LastIndexOf
	|
	|-RVA: 0x3B826D0 Offset: 0x3B827D1 VA: 0x3B826D0
	|-EqualityComparer<MapImage.BackupTerrain>.LastIndexOf
	|
	|-RVA: 0x3B83280 Offset: 0x3B83381 VA: 0x3B83280
	|-EqualityComparer<MapImageRange.Pos>.LastIndexOf
	|
	|-RVA: 0x3B83EC0 Offset: 0x3B83FC1 VA: 0x3B83EC0
	|-EqualityComparer<MapMind.Record>.LastIndexOf
	|
	|-RVA: 0x3B84C60 Offset: 0x3B84D61 VA: 0x3B84C60
	|-EqualityComparer<MapMind.Target>.LastIndexOf
	|
	|-RVA: 0x3B85900 Offset: 0x3B85A01 VA: 0x3B85900
	|-EqualityComparer<MapPanelDebug.Entity>.LastIndexOf
	|
	|-RVA: 0x3B86550 Offset: 0x3B86651 VA: 0x3B86550
	|-EqualityComparer<NexRanking.Data>.LastIndexOf
	|
	|-RVA: 0x3B870E0 Offset: 0x3B871E1 VA: 0x3B870E0
	|-EqualityComparer<NexVersus.RatingData>.LastIndexOf
	|
	|-RVA: 0x3B87C90 Offset: 0x3B87D91 VA: 0x3B87C90
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.LastIndexOf
	|
	|-RVA: 0x3B88890 Offset: 0x3B88991 VA: 0x3B88890
	|-EqualityComparer<ParticleSystem.Particle>.LastIndexOf
	|
	|-RVA: 0x3B89560 Offset: 0x3B89661 VA: 0x3B89560
	|-EqualityComparer<QualitySettingsStack.Settings>.LastIndexOf
	|
	|-RVA: 0x3B8A200 Offset: 0x3B8A301 VA: 0x3B8A200
	|-EqualityComparer<RangeData.Offset>.LastIndexOf
	|
	|-RVA: 0x3B8ADE0 Offset: 0x3B8AEE1 VA: 0x3B8ADE0
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.LastIndexOf
	|
	|-RVA: 0x3B8BA90 Offset: 0x3B8BB91 VA: 0x3B8BA90
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.LastIndexOf
	|
	|-RVA: 0x3B8C740 Offset: 0x3B8C841 VA: 0x3B8C740
	|-EqualityComparer<RingCleaningUnitSelectMenu.GodParam>.LastIndexOf
	|
	|-RVA: 0x3B8D360 Offset: 0x3B8D461 VA: 0x3B8D360
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.LastIndexOf
	|
	|-RVA: 0x3B8E080 Offset: 0x3B8E181 VA: 0x3B8E080
	|-EqualityComparer<ShadowUtility.Edge>.LastIndexOf
	|
	|-RVA: 0x3B8ED20 Offset: 0x3B8EE21 VA: 0x3B8ED20
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.LastIndexOf
	|
	|-RVA: 0x3B8F8D0 Offset: 0x3B8F9D1 VA: 0x3B8F8D0
	|-EqualityComparer<SkillArray.Entity>.LastIndexOf
	|
	|-RVA: 0x3B90470 Offset: 0x3B90571 VA: 0x3B90470
	|-EqualityComparer<Stream.Info>.LastIndexOf
	|
	|-RVA: 0x3B910C0 Offset: 0x3B911C1 VA: 0x3B910C0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.LastIndexOf
	|
	|-RVA: 0x3B91E00 Offset: 0x3B91F01 VA: 0x3B91E00
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.LastIndexOf
	|
	|-RVA: 0x3B92AA0 Offset: 0x3B92BA1 VA: 0x3B92AA0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.LastIndexOf
	|
	|-RVA: 0x3B936F0 Offset: 0x3B937F1 VA: 0x3B936F0
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.LastIndexOf
	|
	|-RVA: 0x3B942A0 Offset: 0x3B943A1 VA: 0x3B942A0
	|-EqualityComparer<AIThink.EnchantThink.SurroundingInfo>.LastIndexOf
	|
	|-RVA: 0x3B94E30 Offset: 0x3B94F31 VA: 0x3B94E30
	|-EqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.LastIndexOf
	|
	|-RVA: 0x3B95A30 Offset: 0x3B95B31 VA: 0x3B95A30
	|-EqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.LastIndexOf
	|
	|-RVA: 0x3B96690 Offset: 0x3B96791 VA: 0x3B96690
	|-EqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.LastIndexOf
	|
	|-RVA: 0x3B972B0 Offset: 0x3B973B1 VA: 0x3B972B0
	|-EqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.LastIndexOf
	|
	|-RVA: 0x3B97FB0 Offset: 0x3B980B1 VA: 0x3B97FB0
	|-EqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.LastIndexOf
	|
	|-RVA: 0x3B98C60 Offset: 0x3B98D61 VA: 0x3B98C60
	|-EqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.LastIndexOf
	|
	|-RVA: 0x3B99900 Offset: 0x3B99A01 VA: 0x3B99900
	|-EqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.LastIndexOf
	|
	|-RVA: 0x3B9A5A0 Offset: 0x3B9A6A1 VA: 0x3B9A5A0
	|-EqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.LastIndexOf
	|
	|-RVA: 0x3B9B200 Offset: 0x3B9B301 VA: 0x3B9B200
	|-EqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.LastIndexOf
	|
	|-RVA: 0x3B9BE00 Offset: 0x3B9BF01 VA: 0x3B9BE00
	|-EqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.LastIndexOf
	|
	|-RVA: 0x33BD0D0 Offset: 0x33BD1D1 VA: 0x33BD0D0
	|-EqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.LastIndexOf
	|
	|-RVA: 0x33BDD10 Offset: 0x33BDE11 VA: 0x33BDD10
	|-EqualityComparer<Detail.Ranking.RankingCachedResultInt>.LastIndexOf
	|
	|-RVA: 0x33BEA10 Offset: 0x33BEB11 VA: 0x33BEA10
	|-EqualityComparer<Detail.Ranking.RankingOrderParamInt>.LastIndexOf
	|
	|-RVA: 0x33BF650 Offset: 0x33BF751 VA: 0x33BF650
	|-EqualityComparer<Detail.Ranking.RankingRankDataInt>.LastIndexOf
	|
	|-RVA: 0x33C0410 Offset: 0x33C0511 VA: 0x33C0410
	|-EqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.LastIndexOf
	|
	|-RVA: 0x33C1230 Offset: 0x33C1331 VA: 0x33C1230
	|-EqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.LastIndexOf
	|
	|-RVA: 0x33C1F20 Offset: 0x33C2021 VA: 0x33C1F20
	|-EqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.LastIndexOf
	|
	|-RVA: 0x33C2B20 Offset: 0x33C2C21 VA: 0x33C2B20
	|-EqualityComparer<Detail.Screening.ScreeningContextInfoInt>.LastIndexOf
	|
	|-RVA: 0x33C3810 Offset: 0x33C3911 VA: 0x33C3810
	|-EqualityComparer<Detail.Subscriber.SubscriberContentInt>.LastIndexOf
	|
	|-RVA: 0x33C45B0 Offset: 0x33C46B1 VA: 0x33C45B0
	|-EqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.LastIndexOf
	|
	|-RVA: 0x33C5270 Offset: 0x33C5371 VA: 0x33C5270
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.LastIndexOf
	|
	|-RVA: 0x33C5F70 Offset: 0x33C6071 VA: 0x33C5F70
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.LastIndexOf
	|
	|-RVA: 0x33C6BC0 Offset: 0x33C6CC1 VA: 0x33C6BC0
	|-EqualityComparer<Detail.Utility.IntegerSettings>.LastIndexOf
	|
	|-RVA: 0x33C7750 Offset: 0x33C7851 VA: 0x33C7750
	|-EqualityComparer<Detail.Utility.UniqueIdInfoInt>.LastIndexOf
	|
	|-RVA: 0x33C8310 Offset: 0x33C8411 VA: 0x33C8310
	|-EqualityComparer<MapHistory.Rewind.LatestInspectorData>.LastIndexOf
	|
	|-RVA: 0x33C8EE0 Offset: 0x33C8FE1 VA: 0x33C8EE0
	|-EqualityComparer<MapHistory.Rewind.WorkTerrainData>.LastIndexOf
	|
	|-RVA: 0x33C9AA0 Offset: 0x33C9BA1 VA: 0x33C9AA0
	|-EqualityComparer<MapSkill.AroundCalculator.Result>.LastIndexOf
	|
	|-RVA: 0x33CA6C0 Offset: 0x33CA7C1 VA: 0x33CA6C0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.LastIndexOf
	|
	|-RVA: 0x33CB3E0 Offset: 0x33CB4E1 VA: 0x33CB3E0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.LastIndexOf
	|
	|-RVA: 0x33CC0B0 Offset: 0x33CC1B1 VA: 0x33CC0B0
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3768AF0 Offset: 0x3768BF1 VA: 0x3768AF0
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3769790 Offset: 0x3769891 VA: 0x3769790
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x376A3A0 Offset: 0x376A4A1 VA: 0x376A3A0
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x376AF50 Offset: 0x376B051 VA: 0x376AF50
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x376BB80 Offset: 0x376BC81 VA: 0x376BB80
	|-EqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x376C790 Offset: 0x376C891 VA: 0x376C790
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x376D3D0 Offset: 0x376D4D1 VA: 0x376D3D0
	|-EqualityComparer<CommonBattleSequence.Reliance<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x376DFE0 Offset: 0x376E0E1 VA: 0x376DFE0
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x376EB90 Offset: 0x376EC91 VA: 0x376EB90
	|-EqualityComparer<TimeInterval<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x376F7D0 Offset: 0x376F8D1 VA: 0x376F7D0
	|-EqualityComparer<Timestamped<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37703E0 Offset: 0x37704E1 VA: 0x37703E0
	|-EqualityComparer<UniTask<object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3770F90 Offset: 0x3771091 VA: 0x3770F90
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3771BC0 Offset: 0x3771CC1 VA: 0x3771BC0
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3772860 Offset: 0x3772961 VA: 0x3772860
	|-EqualityComparer<ValueTuple<bool, UniTask<object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37734F0 Offset: 0x37735F1 VA: 0x37734F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37741D0 Offset: 0x37742D1 VA: 0x37741D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3774EF0 Offset: 0x3774FF1 VA: 0x3774EF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3775B30 Offset: 0x3775C31 VA: 0x3775B30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3776700 Offset: 0x3776801 VA: 0x3776700
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37773E0 Offset: 0x37774E1 VA: 0x37773E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3778050 Offset: 0x3778151 VA: 0x3778050
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3778D10 Offset: 0x3778E11 VA: 0x3778D10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3779A40 Offset: 0x3779B41 VA: 0x3779A40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x377A710 Offset: 0x377A811 VA: 0x377A710
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x377B3F0 Offset: 0x377B4F1 VA: 0x377B3F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x377C100 Offset: 0x377C201 VA: 0x377C100
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x377CE30 Offset: 0x377CF31 VA: 0x377CE30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x377DB80 Offset: 0x377DC81 VA: 0x377DB80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x377E870 Offset: 0x377E971 VA: 0x377E870
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37E86A0 Offset: 0x37E87A1 VA: 0x37E86A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37E92E0 Offset: 0x37E93E1 VA: 0x37E92E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37E9F80 Offset: 0x37EA081 VA: 0x37E9F80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37EAC40 Offset: 0x37EAD41 VA: 0x37EAC40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37EB940 Offset: 0x37EBA41 VA: 0x37EB940
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37EC670 Offset: 0x37EC771 VA: 0x37EC670
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37ED380 Offset: 0x37ED481 VA: 0x37ED380
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37EE0D0 Offset: 0x37EE1D1 VA: 0x37EE0D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37EEE60 Offset: 0x37EEF61 VA: 0x37EEE60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37EFC20 Offset: 0x37EFD21 VA: 0x37EFC20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F0A20 Offset: 0x37F0B21 VA: 0x37F0A20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F1850 Offset: 0x37F1951 VA: 0x37F1850
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F2520 Offset: 0x37F2621 VA: 0x37F2520
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F30F0 Offset: 0x37F31F1 VA: 0x37F30F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F3D90 Offset: 0x37F3E91 VA: 0x37F3D90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F49E0 Offset: 0x37F4AE1 VA: 0x37F49E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F5630 Offset: 0x37F5731 VA: 0x37F5630
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F6310 Offset: 0x37F6411 VA: 0x37F6310
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F6FF0 Offset: 0x37F70F1 VA: 0x37F6FF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F7CD0 Offset: 0x37F7DD1 VA: 0x37F7CD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F89F0 Offset: 0x37F8AF1 VA: 0x37F89F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37F96C0 Offset: 0x37F97C1 VA: 0x37F96C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37FA350 Offset: 0x37FA451 VA: 0x37FA350
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37FAFF0 Offset: 0x37FB0F1 VA: 0x37FAFF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37FBCD0 Offset: 0x37FBDD1 VA: 0x37FBCD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37FC920 Offset: 0x37FCA21 VA: 0x37FC920
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37FD580 Offset: 0x37FD681 VA: 0x37FD580
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37FE260 Offset: 0x37FE361 VA: 0x37FE260
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37FEF20 Offset: 0x37FF021 VA: 0x37FEF20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x37FFC00 Offset: 0x37FFD01 VA: 0x37FFC00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3800920 Offset: 0x3800A21 VA: 0x3800920
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3801680 Offset: 0x3801781 VA: 0x3801680
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x38023C0 Offset: 0x38024C1 VA: 0x38023C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3803150 Offset: 0x3803251 VA: 0x3803150
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3803F00 Offset: 0x3804001 VA: 0x3803F00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3804D10 Offset: 0x3804E11 VA: 0x3804D10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3805AF0 Offset: 0x3805BF1 VA: 0x3805AF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3806930 Offset: 0x3806A31 VA: 0x3806930
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3807790 Offset: 0x3807891 VA: 0x3807790
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3808650 Offset: 0x3808751 VA: 0x3808650
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x38094E0 Offset: 0x38095E1 VA: 0x38094E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x380A160 Offset: 0x380A261 VA: 0x380A160
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x380ACF0 Offset: 0x380ADF1 VA: 0x380ACF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x380B990 Offset: 0x380BA91 VA: 0x380B990
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x380C5D0 Offset: 0x380C6D1 VA: 0x380C5D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x380D250 Offset: 0x380D351 VA: 0x380D250
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A0DD0 Offset: 0x39A0ED1 VA: 0x39A0DD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A19E0 Offset: 0x39A1AE1 VA: 0x39A19E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A2610 Offset: 0x39A2711 VA: 0x39A2610
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A32A0 Offset: 0x39A33A1 VA: 0x39A32A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A3F80 Offset: 0x39A4081 VA: 0x39A3F80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A4C90 Offset: 0x39A4D91 VA: 0x39A4C90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A58D0 Offset: 0x39A59D1 VA: 0x39A58D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A6500 Offset: 0x39A6601 VA: 0x39A6500
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A70F0 Offset: 0x39A71F1 VA: 0x39A70F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A7D30 Offset: 0x39A7E31 VA: 0x39A7D30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A89D0 Offset: 0x39A8AD1 VA: 0x39A89D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39A96B0 Offset: 0x39A97B1 VA: 0x39A96B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39AA370 Offset: 0x39AA471 VA: 0x39AA370
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39AB000 Offset: 0x39AB101 VA: 0x39AB000
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39ABD20 Offset: 0x39ABE21 VA: 0x39ABD20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39ACA70 Offset: 0x39ACB71 VA: 0x39ACA70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39AD810 Offset: 0x39AD911 VA: 0x39AD810
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39AE590 Offset: 0x39AE691 VA: 0x39AE590
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39AF360 Offset: 0x39AF461 VA: 0x39AF360
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B0140 Offset: 0x39B0241 VA: 0x39B0140
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B0F90 Offset: 0x39B1091 VA: 0x39B0F90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B1DB0 Offset: 0x39B1EB1 VA: 0x39B1DB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B2C30 Offset: 0x39B2D31 VA: 0x39B2C30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B3AC0 Offset: 0x39B3BC1 VA: 0x39B3AC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B4800 Offset: 0x39B4901 VA: 0x39B4800
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B54B0 Offset: 0x39B55B1 VA: 0x39B54B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B60D0 Offset: 0x39B61D1 VA: 0x39B60D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B6CA0 Offset: 0x39B6DA1 VA: 0x39B6CA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B78F0 Offset: 0x39B79F1 VA: 0x39B78F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B8500 Offset: 0x39B8601 VA: 0x39B8500
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B9160 Offset: 0x39B9261 VA: 0x39B9160
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39B9E00 Offset: 0x39B9F01 VA: 0x39B9E00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39BAA20 Offset: 0x39BAB21 VA: 0x39BAA20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39BB670 Offset: 0x39BB771 VA: 0x39BB670
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39BC310 Offset: 0x39BC411 VA: 0x39BC310
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39BCFB0 Offset: 0x39BD0B1 VA: 0x39BCFB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39BDC50 Offset: 0x39BDD51 VA: 0x39BDC50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39BE870 Offset: 0x39BE971 VA: 0x39BE870
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39BF4C0 Offset: 0x39BF5C1 VA: 0x39BF4C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39C00D0 Offset: 0x39C01D1 VA: 0x39C00D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39C0CA0 Offset: 0x39C0DA1 VA: 0x39C0CA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39C18E0 Offset: 0x39C19E1 VA: 0x39C18E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39C2580 Offset: 0x39C2681 VA: 0x39C2580
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39C3220 Offset: 0x39C3321 VA: 0x39C3220
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39C3EC0 Offset: 0x39C3FC1 VA: 0x39C3EC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x39C4BA0 Offset: 0x39C4CA1 VA: 0x39C4BA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3ADB480 Offset: 0x3ADB581 VA: 0x3ADB480
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3ADC1A0 Offset: 0x3ADC2A1 VA: 0x3ADC1A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3ADCEE0 Offset: 0x3ADCFE1 VA: 0x3ADCEE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3ADDC80 Offset: 0x3ADDD81 VA: 0x3ADDC80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3ADE9F0 Offset: 0x3ADEAF1 VA: 0x3ADE9F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3ADF7C0 Offset: 0x3ADF8C1 VA: 0x3ADF7C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE05A0 Offset: 0x3AE06A1 VA: 0x3AE05A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE13F0 Offset: 0x3AE14F1 VA: 0x3AE13F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE2210 Offset: 0x3AE2311 VA: 0x3AE2210
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE3090 Offset: 0x3AE3191 VA: 0x3AE3090
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE3E60 Offset: 0x3AE3F61 VA: 0x3AE3E60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE4A60 Offset: 0x3AE4B61 VA: 0x3AE4A60
	|-EqualityComparer<ValueTuple<bool, AsyncUnit>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE55F0 Offset: 0x3AE56F1 VA: 0x3AE55F0
	|-EqualityComparer<ValueTuple<bool, bool>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE6270 Offset: 0x3AE6371 VA: 0x3AE6270
	|-EqualityComparer<ValueTuple<bool, Bounds>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE6E90 Offset: 0x3AE6F91 VA: 0x3AE6E90
	|-EqualityComparer<ValueTuple<bool, byte>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE7AD0 Offset: 0x3AE7BD1 VA: 0x3AE7AD0
	|-EqualityComparer<ValueTuple<bool, Color>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE86E0 Offset: 0x3AE87E1 VA: 0x3AE86E0
	|-EqualityComparer<ValueTuple<bool, double>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE9270 Offset: 0x3AE9371 VA: 0x3AE9270
	|-EqualityComparer<ValueTuple<bool, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AE9E20 Offset: 0x3AE9F21 VA: 0x3AE9E20
	|-EqualityComparer<ValueTuple<bool, long>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AEA9D0 Offset: 0x3AEAAD1 VA: 0x3AEA9D0
	|-EqualityComparer<ValueTuple<bool, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AEB610 Offset: 0x3AEB711 VA: 0x3AEB610
	|-EqualityComparer<ValueTuple<bool, Quaternion>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AEC2B0 Offset: 0x3AEC3B1 VA: 0x3AEC2B0
	|-EqualityComparer<ValueTuple<bool, Rect>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AECEA0 Offset: 0x3AECFA1 VA: 0x3AECEA0
	|-EqualityComparer<ValueTuple<bool, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AEDA50 Offset: 0x3AEDB51 VA: 0x3AEDA50
	|-EqualityComparer<ValueTuple<bool, UniTask>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AEE5E0 Offset: 0x3AEE6E1 VA: 0x3AEE5E0
	|-EqualityComparer<ValueTuple<bool, Unit>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AEF1A0 Offset: 0x3AEF2A1 VA: 0x3AEF1A0
	|-EqualityComparer<ValueTuple<bool, Vector2>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AEFD60 Offset: 0x3AEFE61 VA: 0x3AEFD60
	|-EqualityComparer<ValueTuple<bool, Vector3>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF09A0 Offset: 0x3AF0AA1 VA: 0x3AF09A0
	|-EqualityComparer<ValueTuple<bool, Vector4>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF15B0 Offset: 0x3AF16B1 VA: 0x3AF15B0
	|-EqualityComparer<ValueTuple<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF2140 Offset: 0x3AF2241 VA: 0x3AF2140
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF2D80 Offset: 0x3AF2E81 VA: 0x3AF2D80
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF3990 Offset: 0x3AF3A91 VA: 0x3AF3990
	|-EqualityComparer<ValueTuple<object, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF4540 Offset: 0x3AF4641 VA: 0x3AF4540
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF50F0 Offset: 0x3AF51F1 VA: 0x3AF50F0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF5CD0 Offset: 0x3AF5DD1 VA: 0x3AF5CD0
	|-EqualityComparer<ValueTuple<Vector3, float>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF6980 Offset: 0x3AF6A81 VA: 0x3AF6980
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF75D0 Offset: 0x3AF76D1 VA: 0x3AF75D0
	|-EqualityComparer<ValueTuple<object, Int32Enum, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF8210 Offset: 0x3AF8311 VA: 0x3AF8210
	|-EqualityComparer<ValueTuple<object, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF8F30 Offset: 0x3AF9031 VA: 0x3AF8F30
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AF9C40 Offset: 0x3AF9D41 VA: 0x3AF9C40
	|-EqualityComparer<ValueTuple<object, int, int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AFA8D0 Offset: 0x3AFA9D1 VA: 0x3AFA8D0
	|-EqualityComparer<ValueTuple<object, object, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AFB630 Offset: 0x3AFB731 VA: 0x3AFB630
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AFC3B0 Offset: 0x3AFC4B1 VA: 0x3AFC3B0
	|-EqualityComparer<ValueTuple<object, object, object, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AFD190 Offset: 0x3AFD291 VA: 0x3AFD190
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AFDF30 Offset: 0x3AFE031 VA: 0x3AFDF30
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3AFED40 Offset: 0x3AFEE41 VA: 0x3AFED40
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BDAD90 Offset: 0x3BDAE91 VA: 0x3BDAD90
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BDBC20 Offset: 0x3BDBD21 VA: 0x3BDBC20
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BDC9F0 Offset: 0x3BDCAF1 VA: 0x3BDC9F0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BDD5F0 Offset: 0x3BDD6F1 VA: 0x3BDD5F0
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BDE230 Offset: 0x3BDE331 VA: 0x3BDE230
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BDEE20 Offset: 0x3BDEF21 VA: 0x3BDEE20
	|-EqualityComparer<AsyncUnit>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BDFA50 Offset: 0x3BDFB51 VA: 0x3BDFA50
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE0640 Offset: 0x3BE0741 VA: 0x3BE0640
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE1290 Offset: 0x3BE1391 VA: 0x3BE1290
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE1E80 Offset: 0x3BE1F81 VA: 0x3BE1E80
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE2A30 Offset: 0x3BE2B31 VA: 0x3BE2A30
	|-EqualityComparer<CameraInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE35C0 Offset: 0x3BE36C1 VA: 0x3BE35C0
	|-EqualityComparer<CancellationToken>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE4200 Offset: 0x3BE4301 VA: 0x3BE4200
	|-EqualityComparer<CancellationTokenRegistration>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE4DF0 Offset: 0x3BE4EF1 VA: 0x3BE4DF0
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE59D0 Offset: 0x3BE5AD1 VA: 0x3BE59D0
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE6590 Offset: 0x3BE6691 VA: 0x3BE6590
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE72D0 Offset: 0x3BE73D1 VA: 0x3BE72D0
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE7FA0 Offset: 0x3BE80A1 VA: 0x3BE7FA0
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE8BE0 Offset: 0x3BE8CE1 VA: 0x3BE8BE0
	|-EqualityComparer<ContourVertex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BE9880 Offset: 0x3BE9981 VA: 0x3BE9880
	|-EqualityComparer<DataStoreRatingInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BEA470 Offset: 0x3BEA571 VA: 0x3BEA470
	|-EqualityComparer<DataStoreResult>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BEB000 Offset: 0x3BEB101 VA: 0x3BEB000
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BEBBB0 Offset: 0x3BEBCB1 VA: 0x3BEBBB0
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BEC760 Offset: 0x3BEC861 VA: 0x3BEC760
	|-EqualityComparer<Decimal>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BED3E0 Offset: 0x3BED4E1 VA: 0x3BED3E0
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BEE010 Offset: 0x3BEE111 VA: 0x3BEE010
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BEEBD0 Offset: 0x3BEECD1 VA: 0x3BEEBD0
	|-EqualityComparer<FXZ>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BEF820 Offset: 0x3BEF921 VA: 0x3BEF820
	|-EqualityComparer<Friend>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF0440 Offset: 0x3BF0541 VA: 0x3BF0440
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF0FF0 Offset: 0x3BF10F1 VA: 0x3BF0FF0
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF1B80 Offset: 0x3BF1C81 VA: 0x3BF1B80
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF2710 Offset: 0x3BF2811 VA: 0x3BF2710
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF32A0 Offset: 0x3BF33A1 VA: 0x3BF32A0
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF3E30 Offset: 0x3BF3F31 VA: 0x3BF3E30
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF49C0 Offset: 0x3BF4AC1 VA: 0x3BF49C0
	|-EqualityComparer<Int64Enum>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF5550 Offset: 0x3BF5651 VA: 0x3BF5550
	|-EqualityComparer<IntPtr>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF6100 Offset: 0x3BF6201 VA: 0x3BF6100
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF6D40 Offset: 0x3BF6E41 VA: 0x3BF6D40
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF7930 Offset: 0x3BF7A31 VA: 0x3BF7930
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF84C0 Offset: 0x3BF85C1 VA: 0x3BF84C0
	|-EqualityComparer<LengthLimitProperties>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF9050 Offset: 0x3BF9151 VA: 0x3BF9050
	|-EqualityComparer<MapPos>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BF9D10 Offset: 0x3BF9E11 VA: 0x3BF9D10
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BFAA50 Offset: 0x3BFAB51 VA: 0x3BFAA50
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BFB680 Offset: 0x3BFB781 VA: 0x3BFB680
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BFC2F0 Offset: 0x3BFC3F1 VA: 0x3BFC2F0
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BFCF30 Offset: 0x3BFD031 VA: 0x3BFCF30
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BB7DC0 Offset: 0x3BB7EC1 VA: 0x3BB7DC0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BB8AA0 Offset: 0x3BB8BA1 VA: 0x3BB8AA0
	|-EqualityComparer<PlayerLoopSystem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BB97C0 Offset: 0x3BB98C1 VA: 0x3BB97C0
	|-EqualityComparer<PlayerLoopSystemInternal>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BBA440 Offset: 0x3BBA541 VA: 0x3BBA440
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BBB020 Offset: 0x3BBB121 VA: 0x3BBB020
	|-EqualityComparer<RandomSeed>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BBBBD0 Offset: 0x3BBBCD1 VA: 0x3BBBBD0
	|-EqualityComparer<RangePositionInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BBC760 Offset: 0x3BBC861 VA: 0x3BBC760
	|-EqualityComparer<Ranking2ChartInfoInput>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BBD400 Offset: 0x3BBD501 VA: 0x3BBD400
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BBE1B0 Offset: 0x3BBE2B1 VA: 0x3BBE1B0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BBEE90 Offset: 0x3BBEF91 VA: 0x3BBEE90
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BBFA50 Offset: 0x3BBFB51 VA: 0x3BBFA50
	|-EqualityComparer<RendererListHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC05E0 Offset: 0x3BC06E1 VA: 0x3BC05E0
	|-EqualityComparer<ResourceHandle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC1190 Offset: 0x3BC1291 VA: 0x3BC1190
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC1D20 Offset: 0x3BC1E21 VA: 0x3BC1D20
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC28B0 Offset: 0x3BC29B1 VA: 0x3BC28B0
	|-EqualityComparer<ShaderTagId>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC3450 Offset: 0x3BC3551 VA: 0x3BC3450
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC4220 Offset: 0x3BC4321 VA: 0x3BC4220
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC4FE0 Offset: 0x3BC50E1 VA: 0x3BC4FE0
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC5CC0 Offset: 0x3BC5DC1 VA: 0x3BC5CC0
	|-EqualityComparer<SubMeshDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC6900 Offset: 0x3BC6A01 VA: 0x3BC6900
	|-EqualityComparer<TablePair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC7490 Offset: 0x3BC7591 VA: 0x3BC7490
	|-EqualityComparer<TimeSpan>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC8070 Offset: 0x3BC8171 VA: 0x3BC8070
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC8C40 Offset: 0x3BC8D41 VA: 0x3BC8C40
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BC9A00 Offset: 0x3BC9B01 VA: 0x3BC9A00
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BCA720 Offset: 0x3BCA821 VA: 0x3BCA720
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BCB2B0 Offset: 0x3BCB3B1 VA: 0x3BCB2B0
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BCBE40 Offset: 0x3BCBF41 VA: 0x3BCBE40
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BCC9D0 Offset: 0x3BCCAD1 VA: 0x3BCC9D0
	|-EqualityComparer<UniTask>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BCD560 Offset: 0x3BCD661 VA: 0x3BCD560
	|-EqualityComparer<Unit>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BCE110 Offset: 0x3BCE211 VA: 0x3BCE110
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BCED00 Offset: 0x3BCEE01 VA: 0x3BCED00
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BCF900 Offset: 0x3BCFA01 VA: 0x3BCF900
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD04E0 Offset: 0x3BD05E1 VA: 0x3BD04E0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD1090 Offset: 0x3BD1191 VA: 0x3BD1090
	|-EqualityComparer<X509ChainStatus>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD1C40 Offset: 0x3BD1D41 VA: 0x3BD1C40
	|-EqualityComparer<XPathNodeRef>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD2880 Offset: 0x3BD2981 VA: 0x3BD2880
	|-EqualityComparer<XRView>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD34A0 Offset: 0x3BD35A1 VA: 0x3BD34A0
	|-EqualityComparer<AmiiboSequence.GainItemData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD4120 Offset: 0x3BD4221 VA: 0x3BD4120
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD4D70 Offset: 0x3BD4E71 VA: 0x3BD4D70
	|-EqualityComparer<ArenaOrderSequence.GodInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD5920 Offset: 0x3BD5A21 VA: 0x3BD5920
	|-EqualityComparer<BattleInfo.SupportData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD64D0 Offset: 0x3BD65D1 VA: 0x3BD64D0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD7110 Offset: 0x3BD7211 VA: 0x3BD7110
	|-EqualityComparer<Camera.RenderRequest>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD7D20 Offset: 0x3BD7E21 VA: 0x3BD7D20
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD88B0 Offset: 0x3BD89B1 VA: 0x3BD88B0
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BD9440 Offset: 0x3BD9541 VA: 0x3BD9440
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3BDA070 Offset: 0x3BDA171 VA: 0x3BDA070
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B79570 Offset: 0x3B79671 VA: 0x3B79570
	|-EqualityComparer<Detail.AsyncResultInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B7A1B0 Offset: 0x3B7A2B1 VA: 0x3B7A1B0
	|-EqualityComparer<Detail.CppArray>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B7AE30 Offset: 0x3B7AF31 VA: 0x3B7AE30
	|-EqualityComparer<Detail.NotificationEventInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B7BA70 Offset: 0x3B7BB71 VA: 0x3B7BA70
	|-EqualityComparer<DragonRideTargetGroup.ChainParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B7C600 Offset: 0x3B7C701 VA: 0x3B7C600
	|-EqualityComparer<DynamicMesh.State>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B7D1B0 Offset: 0x3B7D2B1 VA: 0x3B7D1B0
	|-EqualityComparer<GameVariable.Value>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B7DDF0 Offset: 0x3B7DEF1 VA: 0x3B7DDF0
	|-EqualityComparer<GmapPathAdjuster.TargetModel>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B7EA90 Offset: 0x3B7EB91 VA: 0x3B7EA90
	|-EqualityComparer<GmapSpotAdjuster.TargetModel>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B7F730 Offset: 0x3B7F831 VA: 0x3B7F730
	|-EqualityComparer<HubFastTravel.Location>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B80410 Offset: 0x3B80511 VA: 0x3B80410
	|-EqualityComparer<HubLensFlare.Flare>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B81050 Offset: 0x3B81151 VA: 0x3B81050
	|-EqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B81BE0 Offset: 0x3B81CE1 VA: 0x3B81BE0
	|-EqualityComparer<Map.Pos>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B82790 Offset: 0x3B82891 VA: 0x3B82790
	|-EqualityComparer<MapImage.BackupTerrain>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B83320 Offset: 0x3B83421 VA: 0x3B83320
	|-EqualityComparer<MapImageRange.Pos>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B84020 Offset: 0x3B84121 VA: 0x3B84020
	|-EqualityComparer<MapMind.Record>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B84D60 Offset: 0x3B84E61 VA: 0x3B84D60
	|-EqualityComparer<MapMind.Target>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B85A00 Offset: 0x3B85B01 VA: 0x3B85A00
	|-EqualityComparer<MapPanelDebug.Entity>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B865F0 Offset: 0x3B866F1 VA: 0x3B865F0
	|-EqualityComparer<NexRanking.Data>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B871A0 Offset: 0x3B872A1 VA: 0x3B871A0
	|-EqualityComparer<NexVersus.RatingData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B87D50 Offset: 0x3B87E51 VA: 0x3B87D50
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B88990 Offset: 0x3B88A91 VA: 0x3B88990
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B89680 Offset: 0x3B89781 VA: 0x3B89680
	|-EqualityComparer<QualitySettingsStack.Settings>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B8A2A0 Offset: 0x3B8A3A1 VA: 0x3B8A2A0
	|-EqualityComparer<RangeData.Offset>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B8AED0 Offset: 0x3B8AFD1 VA: 0x3B8AED0
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B8BBB0 Offset: 0x3B8BCB1 VA: 0x3B8BBB0
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B8C800 Offset: 0x3B8C901 VA: 0x3B8C800
	|-EqualityComparer<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B8D480 Offset: 0x3B8D581 VA: 0x3B8D480
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B8E1A0 Offset: 0x3B8E2A1 VA: 0x3B8E1A0
	|-EqualityComparer<ShadowUtility.Edge>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B8EDE0 Offset: 0x3B8EEE1 VA: 0x3B8EDE0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B8F970 Offset: 0x3B8FA71 VA: 0x3B8F970
	|-EqualityComparer<SkillArray.Entity>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B90530 Offset: 0x3B90631 VA: 0x3B90530
	|-EqualityComparer<Stream.Info>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B91200 Offset: 0x3B91301 VA: 0x3B91200
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B91F00 Offset: 0x3B92001 VA: 0x3B91F00
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B92BA0 Offset: 0x3B92CA1 VA: 0x3B92BA0
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B937B0 Offset: 0x3B938B1 VA: 0x3B937B0
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B94340 Offset: 0x3B94441 VA: 0x3B94340
	|-EqualityComparer<AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B94EF0 Offset: 0x3B94FF1 VA: 0x3B94EF0
	|-EqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B95B30 Offset: 0x3B95C31 VA: 0x3B95B30
	|-EqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B96750 Offset: 0x3B96851 VA: 0x3B96750
	|-EqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B973D0 Offset: 0x3B974D1 VA: 0x3B973D0
	|-EqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B980B0 Offset: 0x3B981B1 VA: 0x3B980B0
	|-EqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B98D60 Offset: 0x3B98E61 VA: 0x3B98D60
	|-EqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B99A00 Offset: 0x3B99B01 VA: 0x3B99A00
	|-EqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B9A6A0 Offset: 0x3B9A7A1 VA: 0x3B9A6A0
	|-EqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B9B2C0 Offset: 0x3B9B3C1 VA: 0x3B9B2C0
	|-EqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x3B9BEF0 Offset: 0x3B9BFF1 VA: 0x3B9BEF0
	|-EqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33BD190 Offset: 0x33BD291 VA: 0x33BD190
	|-EqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33BDE50 Offset: 0x33BDF51 VA: 0x33BDE50
	|-EqualityComparer<Detail.Ranking.RankingCachedResultInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33BEAD0 Offset: 0x33BEBD1 VA: 0x33BEAD0
	|-EqualityComparer<Detail.Ranking.RankingOrderParamInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33BF790 Offset: 0x33BF891 VA: 0x33BF790
	|-EqualityComparer<Detail.Ranking.RankingRankDataInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C0590 Offset: 0x33C0691 VA: 0x33C0590
	|-EqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C1370 Offset: 0x33C1471 VA: 0x33C1370
	|-EqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C1FE0 Offset: 0x33C20E1 VA: 0x33C1FE0
	|-EqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C2C10 Offset: 0x33C2D11 VA: 0x33C2C10
	|-EqualityComparer<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C3970 Offset: 0x33C3A71 VA: 0x33C3970
	|-EqualityComparer<Detail.Subscriber.SubscriberContentInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C46B0 Offset: 0x33C47B1 VA: 0x33C46B0
	|-EqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C5390 Offset: 0x33C5491 VA: 0x33C5390
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C6070 Offset: 0x33C6171 VA: 0x33C6070
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C6C60 Offset: 0x33C6D61 VA: 0x33C6C60
	|-EqualityComparer<Detail.Utility.IntegerSettings>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C7810 Offset: 0x33C7911 VA: 0x33C7810
	|-EqualityComparer<Detail.Utility.UniqueIdInfoInt>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C83C0 Offset: 0x33C84C1 VA: 0x33C83C0
	|-EqualityComparer<MapHistory.Rewind.LatestInspectorData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C8F90 Offset: 0x33C9091 VA: 0x33C8F90
	|-EqualityComparer<MapHistory.Rewind.WorkTerrainData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33C9B60 Offset: 0x33C9C61 VA: 0x33C9B60
	|-EqualityComparer<MapSkill.AroundCalculator.Result>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33CA7E0 Offset: 0x33CA8E1 VA: 0x33CA7E0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33CB510 Offset: 0x33CB611 VA: 0x33CB510
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x33CC150 Offset: 0x33CC251 VA: 0x33CC150
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3768BE0 Offset: 0x3768CE1 VA: 0x3768BE0
	|-EqualityComparer<AsyncOperationHandle<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3769880 Offset: 0x3769981 VA: 0x3769880
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x376A470 Offset: 0x376A571 VA: 0x376A470
	|-EqualityComparer<KeyValuePair<DateTime, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x376B020 Offset: 0x376B121 VA: 0x376B020
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x376BC70 Offset: 0x376BD71 VA: 0x376BC70
	|-EqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x376C860 Offset: 0x376C961 VA: 0x376C860
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x376D4C0 Offset: 0x376D5C1 VA: 0x376D4C0
	|-EqualityComparer<CommonBattleSequence.Reliance<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x376E0B0 Offset: 0x376E1B1 VA: 0x376E0B0
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x376EC60 Offset: 0x376ED61 VA: 0x376EC60
	|-EqualityComparer<TimeInterval<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x376F8C0 Offset: 0x376F9C1 VA: 0x376F8C0
	|-EqualityComparer<Timestamped<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37704B0 Offset: 0x37705B1 VA: 0x37704B0
	|-EqualityComparer<UniTask<object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3771060 Offset: 0x3771161 VA: 0x3771060
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3771CB0 Offset: 0x3771DB1 VA: 0x3771CB0
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3772950 Offset: 0x3772A51 VA: 0x3772950
	|-EqualityComparer<ValueTuple<bool, UniTask<object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37735E0 Offset: 0x37736E1 VA: 0x37735E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37742E0 Offset: 0x37743E1 VA: 0x37742E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3774FF0 Offset: 0x37750F1 VA: 0x3774FF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3775C10 Offset: 0x3775D11 VA: 0x3775C10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37767E0 Offset: 0x37768E1 VA: 0x37767E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37774F0 Offset: 0x37775F1 VA: 0x37774F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3778130 Offset: 0x3778231 VA: 0x3778130
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3778E20 Offset: 0x3778F21 VA: 0x3778E20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3779B40 Offset: 0x3779C41 VA: 0x3779B40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x377A800 Offset: 0x377A901 VA: 0x377A800
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x377B4F0 Offset: 0x377B5F1 VA: 0x377B4F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x377C200 Offset: 0x377C301 VA: 0x377C200
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x377CF40 Offset: 0x377D041 VA: 0x377CF40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x377DC90 Offset: 0x377DD91 VA: 0x377DC90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x377E960 Offset: 0x377EA61 VA: 0x377E960
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37E87A0 Offset: 0x37E88A1 VA: 0x37E87A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37E93C0 Offset: 0x37E94C1 VA: 0x37E93C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37EA080 Offset: 0x37EA181 VA: 0x37EA080
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37EAD30 Offset: 0x37EAE31 VA: 0x37EAD30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37EBA50 Offset: 0x37EBB51 VA: 0x37EBA50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37EC770 Offset: 0x37EC871 VA: 0x37EC770
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37ED480 Offset: 0x37ED581 VA: 0x37ED480
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37EE1F0 Offset: 0x37EE2F1 VA: 0x37EE1F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37EEF70 Offset: 0x37EF071 VA: 0x37EEF70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37EFD50 Offset: 0x37EFE51 VA: 0x37EFD50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F0B40 Offset: 0x37F0C41 VA: 0x37F0B40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F1980 Offset: 0x37F1A81 VA: 0x37F1980
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F2600 Offset: 0x37F2701 VA: 0x37F2600
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F31D0 Offset: 0x37F32D1 VA: 0x37F31D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F3EA0 Offset: 0x37F3FA1 VA: 0x37F3EA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F4AC0 Offset: 0x37F4BC1 VA: 0x37F4AC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F5720 Offset: 0x37F5821 VA: 0x37F5720
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F6420 Offset: 0x37F6521 VA: 0x37F6420
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F70E0 Offset: 0x37F71E1 VA: 0x37F70E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F7DE0 Offset: 0x37F7EE1 VA: 0x37F7DE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F8B00 Offset: 0x37F8C01 VA: 0x37F8B00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37F97B0 Offset: 0x37F98B1 VA: 0x37F97B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37FA440 Offset: 0x37FA541 VA: 0x37FA440
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37FB0E0 Offset: 0x37FB1E1 VA: 0x37FB0E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37FBDE0 Offset: 0x37FBEE1 VA: 0x37FBDE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37FCA00 Offset: 0x37FCB01 VA: 0x37FCA00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37FD670 Offset: 0x37FD771 VA: 0x37FD670
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37FE360 Offset: 0x37FE461 VA: 0x37FE360
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37FF010 Offset: 0x37FF111 VA: 0x37FF010
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x37FFD10 Offset: 0x37FFE11 VA: 0x37FFD10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3800A30 Offset: 0x3800B31 VA: 0x3800A30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3801790 Offset: 0x3801891 VA: 0x3801790
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x38024C0 Offset: 0x38025C1 VA: 0x38024C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3803270 Offset: 0x3803371 VA: 0x3803270
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3804020 Offset: 0x3804121 VA: 0x3804020
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3804E40 Offset: 0x3804F41 VA: 0x3804E40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3805C00 Offset: 0x3805D01 VA: 0x3805C00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3806A80 Offset: 0x3806B81 VA: 0x3806A80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x38078C0 Offset: 0x38079C1 VA: 0x38078C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x38087B0 Offset: 0x38088B1 VA: 0x38087B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3809600 Offset: 0x3809701 VA: 0x3809600
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x380A230 Offset: 0x380A331 VA: 0x380A230
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x380ADC0 Offset: 0x380AEC1 VA: 0x380ADC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x380BAA0 Offset: 0x380BBA1 VA: 0x380BAA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x380C6A0 Offset: 0x380C7A1 VA: 0x380C6A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x380D350 Offset: 0x380D451 VA: 0x380D350
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A0EC0 Offset: 0x39A0FC1 VA: 0x39A0EC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A1AB0 Offset: 0x39A1BB1 VA: 0x39A1AB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A2700 Offset: 0x39A2801 VA: 0x39A2700
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A3390 Offset: 0x39A3491 VA: 0x39A3390
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A4080 Offset: 0x39A4181 VA: 0x39A4080
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A4D90 Offset: 0x39A4E91 VA: 0x39A4D90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A59A0 Offset: 0x39A5AA1 VA: 0x39A59A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A65F0 Offset: 0x39A66F1 VA: 0x39A65F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A71C0 Offset: 0x39A72C1 VA: 0x39A71C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A7E20 Offset: 0x39A7F21 VA: 0x39A7E20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A8AC0 Offset: 0x39A8BC1 VA: 0x39A8AC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39A97B0 Offset: 0x39A98B1 VA: 0x39A97B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39AA460 Offset: 0x39AA561 VA: 0x39AA460
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39AB0F0 Offset: 0x39AB1F1 VA: 0x39AB0F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39ABE40 Offset: 0x39ABF41 VA: 0x39ABE40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39ACB80 Offset: 0x39ACC81 VA: 0x39ACB80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39AD940 Offset: 0x39ADA41 VA: 0x39AD940
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39AE690 Offset: 0x39AE791 VA: 0x39AE690
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39AF490 Offset: 0x39AF591 VA: 0x39AF490
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B0260 Offset: 0x39B0361 VA: 0x39B0260
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B10E0 Offset: 0x39B11E1 VA: 0x39B10E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B1EC0 Offset: 0x39B1FC1 VA: 0x39B1EC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B2D90 Offset: 0x39B2E91 VA: 0x39B2D90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B3BF0 Offset: 0x39B3CF1 VA: 0x39B3BF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B4900 Offset: 0x39B4A01 VA: 0x39B4900
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B55B0 Offset: 0x39B56B1 VA: 0x39B55B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B61B0 Offset: 0x39B62B1 VA: 0x39B61B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B6D80 Offset: 0x39B6E81 VA: 0x39B6D80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B79E0 Offset: 0x39B7AE1 VA: 0x39B79E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B85E0 Offset: 0x39B86E1 VA: 0x39B85E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B9250 Offset: 0x39B9351 VA: 0x39B9250
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39B9EF0 Offset: 0x39B9FF1 VA: 0x39B9EF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39BAAF0 Offset: 0x39BABF1 VA: 0x39BAAF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39BB760 Offset: 0x39BB861 VA: 0x39BB760
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39BC400 Offset: 0x39BC501 VA: 0x39BC400
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39BD0A0 Offset: 0x39BD1A1 VA: 0x39BD0A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39BDD40 Offset: 0x39BDE41 VA: 0x39BDD40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39BE940 Offset: 0x39BEA41 VA: 0x39BE940
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39BF5B0 Offset: 0x39BF6B1 VA: 0x39BF5B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39C01B0 Offset: 0x39C02B1 VA: 0x39C01B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39C0D70 Offset: 0x39C0E71 VA: 0x39C0D70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39C19D0 Offset: 0x39C1AD1 VA: 0x39C19D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39C2670 Offset: 0x39C2771 VA: 0x39C2670
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39C3310 Offset: 0x39C3411 VA: 0x39C3310
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39C3FB0 Offset: 0x39C40B1 VA: 0x39C3FB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x39C4CA0 Offset: 0x39C4DA1 VA: 0x39C4CA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3ADB570 Offset: 0x3ADB671 VA: 0x3ADB570
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3ADC2B0 Offset: 0x3ADC3B1 VA: 0x3ADC2B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3ADCFF0 Offset: 0x3ADD0F1 VA: 0x3ADCFF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3ADDDA0 Offset: 0x3ADDEA1 VA: 0x3ADDDA0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3ADEAF0 Offset: 0x3ADEBF1 VA: 0x3ADEAF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3ADF8F0 Offset: 0x3ADF9F1 VA: 0x3ADF8F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE06C0 Offset: 0x3AE07C1 VA: 0x3AE06C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE1540 Offset: 0x3AE1641 VA: 0x3AE1540
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE2320 Offset: 0x3AE2421 VA: 0x3AE2320
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE31F0 Offset: 0x3AE32F1 VA: 0x3AE31F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE3F60 Offset: 0x3AE4061 VA: 0x3AE3F60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE4B30 Offset: 0x3AE4C31 VA: 0x3AE4B30
	|-EqualityComparer<ValueTuple<bool, AsyncUnit>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE56C0 Offset: 0x3AE57C1 VA: 0x3AE56C0
	|-EqualityComparer<ValueTuple<bool, bool>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE6370 Offset: 0x3AE6471 VA: 0x3AE6370
	|-EqualityComparer<ValueTuple<bool, Bounds>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE6F60 Offset: 0x3AE7061 VA: 0x3AE6F60
	|-EqualityComparer<ValueTuple<bool, byte>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE7BC0 Offset: 0x3AE7CC1 VA: 0x3AE7BC0
	|-EqualityComparer<ValueTuple<bool, Color>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE87B0 Offset: 0x3AE88B1 VA: 0x3AE87B0
	|-EqualityComparer<ValueTuple<bool, double>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE9340 Offset: 0x3AE9441 VA: 0x3AE9340
	|-EqualityComparer<ValueTuple<bool, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AE9EF0 Offset: 0x3AE9FF1 VA: 0x3AE9EF0
	|-EqualityComparer<ValueTuple<bool, long>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AEAAA0 Offset: 0x3AEABA1 VA: 0x3AEAAA0
	|-EqualityComparer<ValueTuple<bool, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AEB700 Offset: 0x3AEB801 VA: 0x3AEB700
	|-EqualityComparer<ValueTuple<bool, Quaternion>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AEC3A0 Offset: 0x3AEC4A1 VA: 0x3AEC3A0
	|-EqualityComparer<ValueTuple<bool, Rect>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AECF70 Offset: 0x3AED071 VA: 0x3AECF70
	|-EqualityComparer<ValueTuple<bool, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AEDB20 Offset: 0x3AEDC21 VA: 0x3AEDB20
	|-EqualityComparer<ValueTuple<bool, UniTask>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AEE6B0 Offset: 0x3AEE7B1 VA: 0x3AEE6B0
	|-EqualityComparer<ValueTuple<bool, Unit>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AEF270 Offset: 0x3AEF371 VA: 0x3AEF270
	|-EqualityComparer<ValueTuple<bool, Vector2>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AEFE30 Offset: 0x3AEFF31 VA: 0x3AEFE30
	|-EqualityComparer<ValueTuple<bool, Vector3>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF0A90 Offset: 0x3AF0B91 VA: 0x3AF0A90
	|-EqualityComparer<ValueTuple<bool, Vector4>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF1680 Offset: 0x3AF1781 VA: 0x3AF1680
	|-EqualityComparer<ValueTuple<int, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF2210 Offset: 0x3AF2311 VA: 0x3AF2210
	|-EqualityComparer<ValueTuple<Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF2E70 Offset: 0x3AF2F71 VA: 0x3AF2E70
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF3A60 Offset: 0x3AF3B61 VA: 0x3AF3A60
	|-EqualityComparer<ValueTuple<object, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF4610 Offset: 0x3AF4711 VA: 0x3AF4610
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF51C0 Offset: 0x3AF52C1 VA: 0x3AF51C0
	|-EqualityComparer<ValueTuple<object, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF5DA0 Offset: 0x3AF5EA1 VA: 0x3AF5DA0
	|-EqualityComparer<ValueTuple<Vector3, float>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF6A90 Offset: 0x3AF6B91 VA: 0x3AF6A90
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF76A0 Offset: 0x3AF77A1 VA: 0x3AF76A0
	|-EqualityComparer<ValueTuple<object, Int32Enum, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF8300 Offset: 0x3AF8401 VA: 0x3AF8300
	|-EqualityComparer<ValueTuple<object, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF9050 Offset: 0x3AF9151 VA: 0x3AF9050
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AF9D30 Offset: 0x3AF9E31 VA: 0x3AF9D30
	|-EqualityComparer<ValueTuple<object, int, int, int>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AFA9C0 Offset: 0x3AFAAC1 VA: 0x3AFA9C0
	|-EqualityComparer<ValueTuple<object, object, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AFB760 Offset: 0x3AFB861 VA: 0x3AFB760
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AFC4C0 Offset: 0x3AFC5C1 VA: 0x3AFC4C0
	|-EqualityComparer<ValueTuple<object, object, object, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AFD2C0 Offset: 0x3AFD3C1 VA: 0x3AFD2C0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AFE030 Offset: 0x3AFE131 VA: 0x3AFE030
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3AFEE90 Offset: 0x3AFEF91 VA: 0x3AFEE90
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BDAEB0 Offset: 0x3BDAFB1 VA: 0x3BDAEB0
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object, object>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BDBD80 Offset: 0x3BDBE81 VA: 0x3BDBD80
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BDCAF0 Offset: 0x3BDCBF1 VA: 0x3BDCAF0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BDD6C0 Offset: 0x3BDD7C1 VA: 0x3BDD6C0
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BDE320 Offset: 0x3BDE421 VA: 0x3BDE320
	|-EqualityComparer<AsyncOperationHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BDEEF0 Offset: 0x3BDEFF1 VA: 0x3BDEEF0
	|-EqualityComparer<AsyncUnit>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BDFB40 Offset: 0x3BDFC41 VA: 0x3BDFB40
	|-EqualityComparer<BoneWeight>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE0710 Offset: 0x3BE0811 VA: 0x3BE0710
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE1380 Offset: 0x3BE1481 VA: 0x3BE1380
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE1F50 Offset: 0x3BE2051 VA: 0x3BE1F50
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE2B00 Offset: 0x3BE2C01 VA: 0x3BE2B00
	|-EqualityComparer<CameraInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE3690 Offset: 0x3BE3791 VA: 0x3BE3690
	|-EqualityComparer<CancellationToken>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE42F0 Offset: 0x3BE43F1 VA: 0x3BE42F0
	|-EqualityComparer<CancellationTokenRegistration>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE4EC0 Offset: 0x3BE4FC1 VA: 0x3BE4EC0
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE5AA0 Offset: 0x3BE5BA1 VA: 0x3BE5AA0
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE6660 Offset: 0x3BE6761 VA: 0x3BE6660
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE7400 Offset: 0x3BE7501 VA: 0x3BE7400
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE8070 Offset: 0x3BE8171 VA: 0x3BE8070
	|-EqualityComparer<ConstraintSource>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE8CD0 Offset: 0x3BE8DD1 VA: 0x3BE8CD0
	|-EqualityComparer<ContourVertex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BE9970 Offset: 0x3BE9A71 VA: 0x3BE9970
	|-EqualityComparer<DataStoreRatingInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BEA540 Offset: 0x3BEA641 VA: 0x3BEA540
	|-EqualityComparer<DataStoreResult>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BEB0D0 Offset: 0x3BEB1D1 VA: 0x3BEB0D0
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BEBC80 Offset: 0x3BEBD81 VA: 0x3BEBC80
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BEC830 Offset: 0x3BEC931 VA: 0x3BEC830
	|-EqualityComparer<Decimal>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BED4E0 Offset: 0x3BED5E1 VA: 0x3BED4E0
	|-EqualityComparer<DiagnosticEvent>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BEE0E0 Offset: 0x3BEE1E1 VA: 0x3BEE0E0
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BEECA0 Offset: 0x3BEEDA1 VA: 0x3BEECA0
	|-EqualityComparer<FXZ>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BEF920 Offset: 0x3BEFA21 VA: 0x3BEF920
	|-EqualityComparer<Friend>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF0510 Offset: 0x3BF0611 VA: 0x3BF0510
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF10C0 Offset: 0x3BF11C1 VA: 0x3BF10C0
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF1C50 Offset: 0x3BF1D51 VA: 0x3BF1C50
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF27E0 Offset: 0x3BF28E1 VA: 0x3BF27E0
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF3370 Offset: 0x3BF3471 VA: 0x3BF3370
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF3F00 Offset: 0x3BF4001 VA: 0x3BF3F00
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF4A90 Offset: 0x3BF4B91 VA: 0x3BF4A90
	|-EqualityComparer<Int64Enum>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF5620 Offset: 0x3BF5721 VA: 0x3BF5620
	|-EqualityComparer<IntPtr>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF61D0 Offset: 0x3BF62D1 VA: 0x3BF61D0
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF6E30 Offset: 0x3BF6F31 VA: 0x3BF6E30
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF7A00 Offset: 0x3BF7B01 VA: 0x3BF7A00
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF8590 Offset: 0x3BF8691 VA: 0x3BF8590
	|-EqualityComparer<LengthLimitProperties>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF9120 Offset: 0x3BF9221 VA: 0x3BF9120
	|-EqualityComparer<MapPos>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BF9E20 Offset: 0x3BF9F21 VA: 0x3BF9E20
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BFAB60 Offset: 0x3BFAC61 VA: 0x3BFAB60
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BFB750 Offset: 0x3BFB851 VA: 0x3BFB750
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<string>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BFC3F0 Offset: 0x3BFC4F1 VA: 0x3BFC3F0
	|-EqualityComparer<ObjectInitializationData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BFD000 Offset: 0x3BFD101 VA: 0x3BFD000
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BB7EB0 Offset: 0x3BB7FB1 VA: 0x3BB7EB0
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BB8BB0 Offset: 0x3BB8CB1 VA: 0x3BB8BB0
	|-EqualityComparer<PlayerLoopSystem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BB98D0 Offset: 0x3BB99D1 VA: 0x3BB98D0
	|-EqualityComparer<PlayerLoopSystemInternal>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BBA510 Offset: 0x3BBA611 VA: 0x3BBA510
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BBB0F0 Offset: 0x3BBB1F1 VA: 0x3BBB0F0
	|-EqualityComparer<RandomSeed>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BBBCA0 Offset: 0x3BBBDA1 VA: 0x3BBBCA0
	|-EqualityComparer<RangePositionInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BBC830 Offset: 0x3BBC931 VA: 0x3BBC830
	|-EqualityComparer<Ranking2ChartInfoInput>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BBD510 Offset: 0x3BBD611 VA: 0x3BBD510
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BBE2E0 Offset: 0x3BBE3E1 VA: 0x3BBE2E0
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BBEF60 Offset: 0x3BBF061 VA: 0x3BBEF60
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BBFB20 Offset: 0x3BBFC21 VA: 0x3BBFB20
	|-EqualityComparer<RendererListHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC06B0 Offset: 0x3BC07B1 VA: 0x3BC06B0
	|-EqualityComparer<ResourceHandle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC1260 Offset: 0x3BC1361 VA: 0x3BC1260
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC1DF0 Offset: 0x3BC1EF1 VA: 0x3BC1DF0
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC2980 Offset: 0x3BC2A81 VA: 0x3BC2980
	|-EqualityComparer<ShaderTagId>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC3520 Offset: 0x3BC3621 VA: 0x3BC3520
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC4380 Offset: 0x3BC4481 VA: 0x3BC4380
	|-EqualityComparer<SphericalHarmonicsL2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC50D0 Offset: 0x3BC51D1 VA: 0x3BC50D0
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC5DC0 Offset: 0x3BC5EC1 VA: 0x3BC5DC0
	|-EqualityComparer<SubMeshDescriptor>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC69D0 Offset: 0x3BC6AD1 VA: 0x3BC69D0
	|-EqualityComparer<TablePair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC7560 Offset: 0x3BC7661 VA: 0x3BC7560
	|-EqualityComparer<TimeSpan>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC8140 Offset: 0x3BC8241 VA: 0x3BC8140
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC8D10 Offset: 0x3BC8E11 VA: 0x3BC8D10
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BC9B60 Offset: 0x3BC9C61 VA: 0x3BC9B60
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BCA7F0 Offset: 0x3BCA8F1 VA: 0x3BCA7F0
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BCB380 Offset: 0x3BCB481 VA: 0x3BCB380
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BCBF10 Offset: 0x3BCC011 VA: 0x3BCBF10
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BCCAA0 Offset: 0x3BCCBA1 VA: 0x3BCCAA0
	|-EqualityComparer<UniTask>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BCD630 Offset: 0x3BCD731 VA: 0x3BCD630
	|-EqualityComparer<Unit>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BCE1E0 Offset: 0x3BCE2E1 VA: 0x3BCE1E0
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BCEDD0 Offset: 0x3BCEED1 VA: 0x3BCEDD0
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BCF9D0 Offset: 0x3BCFAD1 VA: 0x3BCF9D0
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD05B0 Offset: 0x3BD06B1 VA: 0x3BD05B0
	|-EqualityComparer<VertexAttributeDescriptor>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD1160 Offset: 0x3BD1261 VA: 0x3BD1160
	|-EqualityComparer<X509ChainStatus>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD1D10 Offset: 0x3BD1E11 VA: 0x3BD1D10
	|-EqualityComparer<XPathNodeRef>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD2980 Offset: 0x3BD2A81 VA: 0x3BD2980
	|-EqualityComparer<XRView>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD3570 Offset: 0x3BD3671 VA: 0x3BD3570
	|-EqualityComparer<AmiiboSequence.GainItemData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD4230 Offset: 0x3BD4331 VA: 0x3BD4230
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD4E40 Offset: 0x3BD4F41 VA: 0x3BD4E40
	|-EqualityComparer<ArenaOrderSequence.GodInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD59F0 Offset: 0x3BD5AF1 VA: 0x3BD59F0
	|-EqualityComparer<BattleInfo.SupportData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD65A0 Offset: 0x3BD66A1 VA: 0x3BD65A0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD7200 Offset: 0x3BD7301 VA: 0x3BD7200
	|-EqualityComparer<Camera.RenderRequest>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD7DF0 Offset: 0x3BD7EF1 VA: 0x3BD7DF0
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD8980 Offset: 0x3BD8A81 VA: 0x3BD8980
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BD9510 Offset: 0x3BD9611 VA: 0x3BD9510
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3BDA160 Offset: 0x3BDA261 VA: 0x3BDA160
	|-EqualityComparer<DelayedActionManager.DelegateInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B79670 Offset: 0x3B79771 VA: 0x3B79670
	|-EqualityComparer<Detail.AsyncResultInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B7A280 Offset: 0x3B7A381 VA: 0x3B7A280
	|-EqualityComparer<Detail.CppArray>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B7AF30 Offset: 0x3B7B031 VA: 0x3B7AF30
	|-EqualityComparer<Detail.NotificationEventInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B7BB40 Offset: 0x3B7BC41 VA: 0x3B7BB40
	|-EqualityComparer<DragonRideTargetGroup.ChainParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B7C6D0 Offset: 0x3B7C7D1 VA: 0x3B7C6D0
	|-EqualityComparer<DynamicMesh.State>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B7D280 Offset: 0x3B7D381 VA: 0x3B7D280
	|-EqualityComparer<GameVariable.Value>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B7DEE0 Offset: 0x3B7DFE1 VA: 0x3B7DEE0
	|-EqualityComparer<GmapPathAdjuster.TargetModel>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B7EB80 Offset: 0x3B7EC81 VA: 0x3B7EB80
	|-EqualityComparer<GmapSpotAdjuster.TargetModel>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B7F820 Offset: 0x3B7F921 VA: 0x3B7F820
	|-EqualityComparer<HubFastTravel.Location>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B80510 Offset: 0x3B80611 VA: 0x3B80510
	|-EqualityComparer<HubLensFlare.Flare>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B81120 Offset: 0x3B81221 VA: 0x3B81120
	|-EqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B81CB0 Offset: 0x3B81DB1 VA: 0x3B81CB0
	|-EqualityComparer<Map.Pos>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B82860 Offset: 0x3B82961 VA: 0x3B82860
	|-EqualityComparer<MapImage.BackupTerrain>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B833F0 Offset: 0x3B834F1 VA: 0x3B833F0
	|-EqualityComparer<MapImageRange.Pos>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B84150 Offset: 0x3B84251 VA: 0x3B84150
	|-EqualityComparer<MapMind.Record>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B84E50 Offset: 0x3B84F51 VA: 0x3B84E50
	|-EqualityComparer<MapMind.Target>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B85AF0 Offset: 0x3B85BF1 VA: 0x3B85AF0
	|-EqualityComparer<MapPanelDebug.Entity>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B866C0 Offset: 0x3B867C1 VA: 0x3B866C0
	|-EqualityComparer<NexRanking.Data>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B87270 Offset: 0x3B87371 VA: 0x3B87270
	|-EqualityComparer<NexVersus.RatingData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B87E20 Offset: 0x3B87F21 VA: 0x3B87E20
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B88A90 Offset: 0x3B88B91 VA: 0x3B88A90
	|-EqualityComparer<ParticleSystem.Particle>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B89780 Offset: 0x3B89881 VA: 0x3B89780
	|-EqualityComparer<QualitySettingsStack.Settings>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B8A370 Offset: 0x3B8A471 VA: 0x3B8A370
	|-EqualityComparer<RangeData.Offset>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B8AFC0 Offset: 0x3B8B0C1 VA: 0x3B8AFC0
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B8BCC0 Offset: 0x3B8BDC1 VA: 0x3B8BCC0
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B8C8D0 Offset: 0x3B8C9D1 VA: 0x3B8C8D0
	|-EqualityComparer<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B8D590 Offset: 0x3B8D691 VA: 0x3B8D590
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B8E2A0 Offset: 0x3B8E3A1 VA: 0x3B8E2A0
	|-EqualityComparer<ShadowUtility.Edge>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B8EEB0 Offset: 0x3B8EFB1 VA: 0x3B8EEB0
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B8FA40 Offset: 0x3B8FB41 VA: 0x3B8FA40
	|-EqualityComparer<SkillArray.Entity>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B90600 Offset: 0x3B90701 VA: 0x3B90600
	|-EqualityComparer<Stream.Info>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B91310 Offset: 0x3B91411 VA: 0x3B91310
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B91FF0 Offset: 0x3B920F1 VA: 0x3B91FF0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B92C90 Offset: 0x3B92D91 VA: 0x3B92C90
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B93880 Offset: 0x3B93981 VA: 0x3B93880
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B94410 Offset: 0x3B94511 VA: 0x3B94410
	|-EqualityComparer<AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B94FC0 Offset: 0x3B950C1 VA: 0x3B94FC0
	|-EqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B95C30 Offset: 0x3B95D31 VA: 0x3B95C30
	|-EqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B96820 Offset: 0x3B96921 VA: 0x3B96820
	|-EqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B974E0 Offset: 0x3B975E1 VA: 0x3B974E0
	|-EqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B981B0 Offset: 0x3B982B1 VA: 0x3B981B0
	|-EqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B98E50 Offset: 0x3B98F51 VA: 0x3B98E50
	|-EqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B99AF0 Offset: 0x3B99BF1 VA: 0x3B99AF0
	|-EqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B9A7A0 Offset: 0x3B9A8A1 VA: 0x3B9A7A0
	|-EqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B9B390 Offset: 0x3B9B491 VA: 0x3B9B390
	|-EqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x3B9BFE0 Offset: 0x3B9C0E1 VA: 0x3B9BFE0
	|-EqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33BD260 Offset: 0x33BD361 VA: 0x33BD260
	|-EqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33BDF70 Offset: 0x33BE071 VA: 0x33BDF70
	|-EqualityComparer<Detail.Ranking.RankingCachedResultInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33BEBA0 Offset: 0x33BECA1 VA: 0x33BEBA0
	|-EqualityComparer<Detail.Ranking.RankingOrderParamInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33BF8A0 Offset: 0x33BF9A1 VA: 0x33BF8A0
	|-EqualityComparer<Detail.Ranking.RankingRankDataInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C06C0 Offset: 0x33C07C1 VA: 0x33C06C0
	|-EqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C1480 Offset: 0x33C1581 VA: 0x33C1480
	|-EqualityComparer<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C20B0 Offset: 0x33C21B1 VA: 0x33C20B0
	|-EqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C2D00 Offset: 0x33C2E01 VA: 0x33C2D00
	|-EqualityComparer<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C3AA0 Offset: 0x33C3BA1 VA: 0x33C3AA0
	|-EqualityComparer<Detail.Subscriber.SubscriberContentInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C47A0 Offset: 0x33C48A1 VA: 0x33C47A0
	|-EqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C54A0 Offset: 0x33C55A1 VA: 0x33C54A0
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C6160 Offset: 0x33C6261 VA: 0x33C6160
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C6D30 Offset: 0x33C6E31 VA: 0x33C6D30
	|-EqualityComparer<Detail.Utility.IntegerSettings>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C78E0 Offset: 0x33C79E1 VA: 0x33C78E0
	|-EqualityComparer<Detail.Utility.UniqueIdInfoInt>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C84A0 Offset: 0x33C85A1 VA: 0x33C84A0
	|-EqualityComparer<MapHistory.Rewind.LatestInspectorData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C9070 Offset: 0x33C9171 VA: 0x33C9070
	|-EqualityComparer<MapHistory.Rewind.WorkTerrainData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33C9C30 Offset: 0x33C9D31 VA: 0x33C9C30
	|-EqualityComparer<MapSkill.AroundCalculator.Result>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33CA8E0 Offset: 0x33CA9E1 VA: 0x33CA8E0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33CB620 Offset: 0x33CB721 VA: 0x33CB620
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x33CC220 Offset: 0x33CC321 VA: 0x33CC220
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEqualityComparer.Equals
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3768D90 Offset: 0x3768E91 VA: 0x3768D90
	|-EqualityComparer<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x3769A30 Offset: 0x3769B31 VA: 0x3769A30
	|-EqualityComparer<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x376A5E0 Offset: 0x376A6E1 VA: 0x376A5E0
	|-EqualityComparer<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x376B190 Offset: 0x376B291 VA: 0x376B190
	|-EqualityComparer<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x376BE20 Offset: 0x376BF21 VA: 0x376BE20
	|-EqualityComparer<KeyValuePair<object, ValueTuple<int, DateTime, object>>>..ctor
	|
	|-RVA: 0x376C9D0 Offset: 0x376CAD1 VA: 0x376C9D0
	|-EqualityComparer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x376D670 Offset: 0x376D771 VA: 0x376D670
	|-EqualityComparer<CommonBattleSequence.Reliance<object>>..ctor
	|
	|-RVA: 0x376E220 Offset: 0x376E321 VA: 0x376E220
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|
	|-RVA: 0x376EDD0 Offset: 0x376EED1 VA: 0x376EDD0
	|-EqualityComparer<TimeInterval<object>>..ctor
	|
	|-RVA: 0x376FA70 Offset: 0x376FB71 VA: 0x376FA70
	|-EqualityComparer<Timestamped<object>>..ctor
	|
	|-RVA: 0x3770620 Offset: 0x3770721 VA: 0x3770620
	|-EqualityComparer<UniTask<object>>..ctor
	|
	|-RVA: 0x37711D0 Offset: 0x37712D1 VA: 0x37711D0
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3771E60 Offset: 0x3771F61 VA: 0x3771E60
	|-EqualityComparer<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3772B00 Offset: 0x3772C01 VA: 0x3772B00
	|-EqualityComparer<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x3773790 Offset: 0x3773891 VA: 0x3773790
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x37744B0 Offset: 0x37745B1 VA: 0x37744B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x37751C0 Offset: 0x37752C1 VA: 0x37751C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x3775D90 Offset: 0x3775E91 VA: 0x3775D90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x3776960 Offset: 0x3776A61 VA: 0x3776960
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x37776E0 Offset: 0x37777E1 VA: 0x37776E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x37782B0 Offset: 0x37783B1 VA: 0x37782B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x3779000 Offset: 0x3779101 VA: 0x3779000
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x3779D10 Offset: 0x3779E11 VA: 0x3779D10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x377A9B0 Offset: 0x377AAB1 VA: 0x377A9B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x377B6C0 Offset: 0x377B7C1 VA: 0x377B6C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x377C3D0 Offset: 0x377C4D1 VA: 0x377C3D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x377D120 Offset: 0x377D221 VA: 0x377D120
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x377DE70 Offset: 0x377DF71 VA: 0x377DE70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x377EB10 Offset: 0x377EC11 VA: 0x377EB10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x37E8970 Offset: 0x37E8A71 VA: 0x37E8970
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x37E9540 Offset: 0x37E9641 VA: 0x37E9540
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x37EA250 Offset: 0x37EA351 VA: 0x37EA250
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x37EAEE0 Offset: 0x37EAFE1 VA: 0x37EAEE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x37EBC30 Offset: 0x37EBD31 VA: 0x37EBC30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x37EC940 Offset: 0x37ECA41 VA: 0x37EC940
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x37ED650 Offset: 0x37ED751 VA: 0x37ED650
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x37EE3E0 Offset: 0x37EE4E1 VA: 0x37EE3E0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x37EF160 Offset: 0x37EF261 VA: 0x37EF160
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x37EFF60 Offset: 0x37F0061 VA: 0x37EFF60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x37F0D50 Offset: 0x37F0E51 VA: 0x37F0D50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x37F1BB0 Offset: 0x37F1CB1 VA: 0x37F1BB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x37F2780 Offset: 0x37F2881 VA: 0x37F2780
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x37F3350 Offset: 0x37F3451 VA: 0x37F3350
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x37F4070 Offset: 0x37F4171 VA: 0x37F4070
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x37F4C40 Offset: 0x37F4D41 VA: 0x37F4C40
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x37F58D0 Offset: 0x37F59D1 VA: 0x37F58D0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x37F65F0 Offset: 0x37F66F1 VA: 0x37F65F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x37F7290 Offset: 0x37F7391 VA: 0x37F7290
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x37F7FB0 Offset: 0x37F80B1 VA: 0x37F7FB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x37F8CD0 Offset: 0x37F8DD1 VA: 0x37F8CD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x37F9960 Offset: 0x37F9A61 VA: 0x37F9960
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x37FA5F0 Offset: 0x37FA6F1 VA: 0x37FA5F0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x37FB290 Offset: 0x37FB391 VA: 0x37FB290
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x37FBFB0 Offset: 0x37FC0B1 VA: 0x37FBFB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x37FCB80 Offset: 0x37FCC81 VA: 0x37FCB80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x37FD820 Offset: 0x37FD921 VA: 0x37FD820
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x37FE530 Offset: 0x37FE631 VA: 0x37FE530
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x37FF1C0 Offset: 0x37FF2C1 VA: 0x37FF1C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x37FFEE0 Offset: 0x37FFFE1 VA: 0x37FFEE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x3800C00 Offset: 0x3800D01 VA: 0x3800C00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x3801980 Offset: 0x3801A81 VA: 0x3801980
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3802690 Offset: 0x3802791 VA: 0x3802690
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x3803480 Offset: 0x3803581 VA: 0x3803480
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3804210 Offset: 0x3804311 VA: 0x3804210
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3805070 Offset: 0x3805171 VA: 0x3805070
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3805DF0 Offset: 0x3805EF1 VA: 0x3805DF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3806CD0 Offset: 0x3806DD1 VA: 0x3806CD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3807AD0 Offset: 0x3807BD1 VA: 0x3807AD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x3808A20 Offset: 0x3808B21 VA: 0x3808A20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3809810 Offset: 0x3809911 VA: 0x3809810
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x380A3A0 Offset: 0x380A4A1 VA: 0x380A3A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x380AF30 Offset: 0x380B031 VA: 0x380AF30
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x380BC80 Offset: 0x380BD81 VA: 0x380BC80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x380C810 Offset: 0x380C911 VA: 0x380C810
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x380D520 Offset: 0x380D621 VA: 0x380D520
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x39A1070 Offset: 0x39A1171 VA: 0x39A1070
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x39A1C20 Offset: 0x39A1D21 VA: 0x39A1C20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x39A28B0 Offset: 0x39A29B1 VA: 0x39A28B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x39A3540 Offset: 0x39A3641 VA: 0x39A3540
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x39A4250 Offset: 0x39A4351 VA: 0x39A4250
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x39A4F60 Offset: 0x39A5061 VA: 0x39A4F60
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x39A5B10 Offset: 0x39A5C11 VA: 0x39A5B10
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x39A67A0 Offset: 0x39A68A1 VA: 0x39A67A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x39A7330 Offset: 0x39A7431 VA: 0x39A7330
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x39A7FD0 Offset: 0x39A80D1 VA: 0x39A7FD0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x39A8C70 Offset: 0x39A8D71 VA: 0x39A8C70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x39A9980 Offset: 0x39A9A81 VA: 0x39A9980
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x39AA610 Offset: 0x39AA711 VA: 0x39AA610
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x39AB2A0 Offset: 0x39AB3A1 VA: 0x39AB2A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x39AC030 Offset: 0x39AC131 VA: 0x39AC030
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x39ACD50 Offset: 0x39ACE51 VA: 0x39ACD50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x39ADB50 Offset: 0x39ADC51 VA: 0x39ADB50
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x39AE860 Offset: 0x39AE961 VA: 0x39AE860
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x39AF6C0 Offset: 0x39AF7C1 VA: 0x39AF6C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x39B0450 Offset: 0x39B0551 VA: 0x39B0450
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x39B1330 Offset: 0x39B1431 VA: 0x39B1330
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x39B20B0 Offset: 0x39B21B1 VA: 0x39B20B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x39B3000 Offset: 0x39B3101 VA: 0x39B3000
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x39B3E00 Offset: 0x39B3F01 VA: 0x39B3E00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x39B4AB0 Offset: 0x39B4BB1 VA: 0x39B4AB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x39B5760 Offset: 0x39B5861 VA: 0x39B5760
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x39B6330 Offset: 0x39B6431 VA: 0x39B6330
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x39B6F00 Offset: 0x39B7001 VA: 0x39B6F00
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x39B7B90 Offset: 0x39B7C91 VA: 0x39B7B90
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x39B8760 Offset: 0x39B8861 VA: 0x39B8760
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x39B9400 Offset: 0x39B9501 VA: 0x39B9400
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x39BA0A0 Offset: 0x39BA1A1 VA: 0x39BA0A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x39BAC70 Offset: 0x39BAD71 VA: 0x39BAC70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x39BB910 Offset: 0x39BBA11 VA: 0x39BB910
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x39BC5B0 Offset: 0x39BC6B1 VA: 0x39BC5B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x39BD250 Offset: 0x39BD351 VA: 0x39BD250
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x39BDEF0 Offset: 0x39BDFF1 VA: 0x39BDEF0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x39BEAC0 Offset: 0x39BEBC1 VA: 0x39BEAC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x39BF760 Offset: 0x39BF861 VA: 0x39BF760
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x39C0330 Offset: 0x39C0431 VA: 0x39C0330
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x39C0EE0 Offset: 0x39C0FE1 VA: 0x39C0EE0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x39C1B80 Offset: 0x39C1C81 VA: 0x39C1B80
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x39C2820 Offset: 0x39C2921 VA: 0x39C2820
	|-EqualityComparer<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x39C34C0 Offset: 0x39C35C1 VA: 0x39C34C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x39C4160 Offset: 0x39C4261 VA: 0x39C4160
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x39C4E70 Offset: 0x39C4F71 VA: 0x39C4E70
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3ADB720 Offset: 0x3ADB821 VA: 0x3ADB720
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x3ADC4A0 Offset: 0x3ADC5A1 VA: 0x3ADC4A0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3ADD1C0 Offset: 0x3ADD2C1 VA: 0x3ADD1C0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x3ADDFB0 Offset: 0x3ADE0B1 VA: 0x3ADDFB0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3ADECC0 Offset: 0x3ADEDC1 VA: 0x3ADECC0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x3ADFB20 Offset: 0x3ADFC21 VA: 0x3ADFB20
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3AE08B0 Offset: 0x3AE09B1 VA: 0x3AE08B0
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x3AE1790 Offset: 0x3AE1891 VA: 0x3AE1790
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3AE2510 Offset: 0x3AE2611 VA: 0x3AE2510
	|-EqualityComparer<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x3AE3460 Offset: 0x3AE3561 VA: 0x3AE3460
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3AE4110 Offset: 0x3AE4211 VA: 0x3AE4110
	|-EqualityComparer<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x3AE4CA0 Offset: 0x3AE4DA1 VA: 0x3AE4CA0
	|-EqualityComparer<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x3AE5830 Offset: 0x3AE5931 VA: 0x3AE5830
	|-EqualityComparer<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x3AE6540 Offset: 0x3AE6641 VA: 0x3AE6540
	|-EqualityComparer<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x3AE70D0 Offset: 0x3AE71D1 VA: 0x3AE70D0
	|-EqualityComparer<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x3AE7D70 Offset: 0x3AE7E71 VA: 0x3AE7D70
	|-EqualityComparer<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x3AE8920 Offset: 0x3AE8A21 VA: 0x3AE8920
	|-EqualityComparer<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x3AE94B0 Offset: 0x3AE95B1 VA: 0x3AE94B0
	|-EqualityComparer<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x3AEA060 Offset: 0x3AEA161 VA: 0x3AEA060
	|-EqualityComparer<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x3AEAC10 Offset: 0x3AEAD11 VA: 0x3AEAC10
	|-EqualityComparer<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x3AEB8B0 Offset: 0x3AEB9B1 VA: 0x3AEB8B0
	|-EqualityComparer<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x3AEC550 Offset: 0x3AEC651 VA: 0x3AEC550
	|-EqualityComparer<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x3AED0E0 Offset: 0x3AED1E1 VA: 0x3AED0E0
	|-EqualityComparer<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x3AEDC90 Offset: 0x3AEDD91 VA: 0x3AEDC90
	|-EqualityComparer<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x3AEE820 Offset: 0x3AEE921 VA: 0x3AEE820
	|-EqualityComparer<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x3AEF3F0 Offset: 0x3AEF4F1 VA: 0x3AEF3F0
	|-EqualityComparer<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x3AEFFA0 Offset: 0x3AF00A1 VA: 0x3AEFFA0
	|-EqualityComparer<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x3AF0C40 Offset: 0x3AF0D41 VA: 0x3AF0C40
	|-EqualityComparer<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x3AF17F0 Offset: 0x3AF18F1 VA: 0x3AF17F0
	|-EqualityComparer<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x3AF2380 Offset: 0x3AF2481 VA: 0x3AF2380
	|-EqualityComparer<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x3AF3020 Offset: 0x3AF3121 VA: 0x3AF3020
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|
	|-RVA: 0x3AF3BD0 Offset: 0x3AF3CD1 VA: 0x3AF3BD0
	|-EqualityComparer<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x3AF4780 Offset: 0x3AF4881 VA: 0x3AF4780
	|-EqualityComparer<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x3AF5330 Offset: 0x3AF5431 VA: 0x3AF5330
	|-EqualityComparer<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x3AF5F40 Offset: 0x3AF6041 VA: 0x3AF5F40
	|-EqualityComparer<ValueTuple<Vector3, float>>..ctor
	|
	|-RVA: 0x3AF6C60 Offset: 0x3AF6D61 VA: 0x3AF6C60
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3AF7810 Offset: 0x3AF7911 VA: 0x3AF7810
	|-EqualityComparer<ValueTuple<object, Int32Enum, int>>..ctor
	|
	|-RVA: 0x3AF84B0 Offset: 0x3AF85B1 VA: 0x3AF84B0
	|-EqualityComparer<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x3AF9240 Offset: 0x3AF9341 VA: 0x3AF9240
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3AF9EE0 Offset: 0x3AF9FE1 VA: 0x3AF9EE0
	|-EqualityComparer<ValueTuple<object, int, int, int>>..ctor
	|
	|-RVA: 0x3AFAB70 Offset: 0x3AFAC71 VA: 0x3AFAB70
	|-EqualityComparer<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x3AFB970 Offset: 0x3AFBA71 VA: 0x3AFB970
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3AFC690 Offset: 0x3AFC791 VA: 0x3AFC690
	|-EqualityComparer<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3AFD4F0 Offset: 0x3AFD5F1 VA: 0x3AFD4F0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3AFE200 Offset: 0x3AFE301 VA: 0x3AFE200
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3AFF0E0 Offset: 0x3AFF1E1 VA: 0x3AFF0E0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3BDB0A0 Offset: 0x3BDB1A1 VA: 0x3BDB0A0
	|-EqualityComparer<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3BDBFF0 Offset: 0x3BDC0F1 VA: 0x3BDBFF0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3BDCCA0 Offset: 0x3BDCDA1 VA: 0x3BDCCA0
	|-EqualityComparer<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3BDD830 Offset: 0x3BDD931 VA: 0x3BDD830
	|-EqualityComparer<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x3BDE4D0 Offset: 0x3BDE5D1 VA: 0x3BDE4D0
	|-EqualityComparer<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3BDF060 Offset: 0x3BDF161 VA: 0x3BDF060
	|-EqualityComparer<AsyncUnit>..ctor
	|
	|-RVA: 0x3BDFCF0 Offset: 0x3BDFDF1 VA: 0x3BDFCF0
	|-EqualityComparer<BoneWeight>..ctor
	|
	|-RVA: 0x3BE0890 Offset: 0x3BE0991 VA: 0x3BE0890
	|-EqualityComparer<bool>..ctor
	|
	|-RVA: 0x3BE1530 Offset: 0x3BE1631 VA: 0x3BE1530
	|-EqualityComparer<Bounds>..ctor
	|
	|-RVA: 0x3BE20C0 Offset: 0x3BE21C1 VA: 0x3BE20C0
	|-EqualityComparer<byte>..ctor
	|
	|-RVA: 0x3BE2C70 Offset: 0x3BE2D71 VA: 0x3BE2C70
	|-EqualityComparer<CameraInfo>..ctor
	|
	|-RVA: 0x3BE3800 Offset: 0x3BE3901 VA: 0x3BE3800
	|-EqualityComparer<CancellationToken>..ctor
	|
	|-RVA: 0x3BE44A0 Offset: 0x3BE45A1 VA: 0x3BE44A0
	|-EqualityComparer<CancellationTokenRegistration>..ctor
	|
	|-RVA: 0x3BE5030 Offset: 0x3BE5131 VA: 0x3BE5030
	|-EqualityComparer<char>..ctor
	|
	|-RVA: 0x3BE5C40 Offset: 0x3BE5D41 VA: 0x3BE5C40
	|-EqualityComparer<Color>..ctor
	|
	|-RVA: 0x3BE67D0 Offset: 0x3BE68D1 VA: 0x3BE67D0
	|-EqualityComparer<Color32>..ctor
	|
	|-RVA: 0x3BE7630 Offset: 0x3BE7731 VA: 0x3BE7630
	|-EqualityComparer<ColorBlock>..ctor
	|
	|-RVA: 0x3BE81E0 Offset: 0x3BE82E1 VA: 0x3BE81E0
	|-EqualityComparer<ConstraintSource>..ctor
	|
	|-RVA: 0x3BE8E80 Offset: 0x3BE8F81 VA: 0x3BE8E80
	|-EqualityComparer<ContourVertex>..ctor
	|
	|-RVA: 0x3BE9B20 Offset: 0x3BE9C21 VA: 0x3BE9B20
	|-EqualityComparer<DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x3BEA6B0 Offset: 0x3BEA7B1 VA: 0x3BEA6B0
	|-EqualityComparer<DataStoreResult>..ctor
	|
	|-RVA: 0x3BEB240 Offset: 0x3BEB341 VA: 0x3BEB240
	|-EqualityComparer<DateTime>..ctor
	|
	|-RVA: 0x3BEBDF0 Offset: 0x3BEBEF1 VA: 0x3BEBDF0
	|-EqualityComparer<DateTimeOffset>..ctor
	|
	|-RVA: 0x3BEC9A0 Offset: 0x3BECAA1 VA: 0x3BEC9A0
	|-EqualityComparer<Decimal>..ctor
	|
	|-RVA: 0x3BED6B0 Offset: 0x3BED7B1 VA: 0x3BED6B0
	|-EqualityComparer<DiagnosticEvent>..ctor
	|
	|-RVA: 0x3BEE260 Offset: 0x3BEE361 VA: 0x3BEE260
	|-EqualityComparer<double>..ctor
	|
	|-RVA: 0x3BEEE20 Offset: 0x3BEEF21 VA: 0x3BEEE20
	|-EqualityComparer<FXZ>..ctor
	|
	|-RVA: 0x3BEFAD0 Offset: 0x3BEFBD1 VA: 0x3BEFAD0
	|-EqualityComparer<Friend>..ctor
	|
	|-RVA: 0x3BF0680 Offset: 0x3BF0781 VA: 0x3BF0680
	|-EqualityComparer<GlyphRect>..ctor
	|
	|-RVA: 0x3BF1230 Offset: 0x3BF1331 VA: 0x3BF1230
	|-EqualityComparer<Guid>..ctor
	|
	|-RVA: 0x3BF1DC0 Offset: 0x3BF1EC1 VA: 0x3BF1DC0
	|-EqualityComparer<short>..ctor
	|
	|-RVA: 0x3BF2950 Offset: 0x3BF2A51 VA: 0x3BF2950
	|-EqualityComparer<int>..ctor
	|
	|-RVA: 0x3BF34E0 Offset: 0x3BF35E1 VA: 0x3BF34E0
	|-EqualityComparer<Int32Enum>..ctor
	|
	|-RVA: 0x3BF4070 Offset: 0x3BF4171 VA: 0x3BF4070
	|-EqualityComparer<long>..ctor
	|
	|-RVA: 0x3BF4C00 Offset: 0x3BF4D01 VA: 0x3BF4C00
	|-EqualityComparer<Int64Enum>..ctor
	|
	|-RVA: 0x3BF5790 Offset: 0x3BF5891 VA: 0x3BF5790
	|-EqualityComparer<IntPtr>..ctor
	|
	|-RVA: 0x3BF6340 Offset: 0x3BF6441 VA: 0x3BF6340
	|-EqualityComparer<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x3BF6FE0 Offset: 0x3BF70E1 VA: 0x3BF6FE0
	|-EqualityComparer<IntervalTreeNode>..ctor
	|
	|-RVA: 0x3BF7B70 Offset: 0x3BF7C71 VA: 0x3BF7B70
	|-EqualityComparer<LayerMask>..ctor
	|
	|-RVA: 0x3BF8700 Offset: 0x3BF8801 VA: 0x3BF8700
	|-EqualityComparer<LengthLimitProperties>..ctor
	|
	|-RVA: 0x3BF9290 Offset: 0x3BF9391 VA: 0x3BF9290
	|-EqualityComparer<MapPos>..ctor
	|
	|-RVA: 0x3BFA010 Offset: 0x3BFA111 VA: 0x3BFA010
	|-EqualityComparer<Matrix4x4>..ctor
	|
	|-RVA: 0x3BFAD30 Offset: 0x3BFAE31 VA: 0x3BFAD30
	|-EqualityComparer<Navigation>..ctor
	|
	|-RVA: 0x3BFB8B0 Offset: 0x3BFB9B1 VA: 0x3BFB8B0
	|-EqualityComparer<object>..ctor
	|-EqualityComparer<string>..ctor
	|
	|-RVA: 0x3BFC5C0 Offset: 0x3BFC6C1 VA: 0x3BFC5C0
	|-EqualityComparer<ObjectInitializationData>..ctor
	|
	|-RVA: 0x3BFD170 Offset: 0x3BFD271 VA: 0x3BFD170
	|-EqualityComparer<Playable>..ctor
	|
	|-RVA: 0x3BB8060 Offset: 0x3BB8161 VA: 0x3BB8060
	|-EqualityComparer<PlayableBinding>..ctor
	|
	|-RVA: 0x3BB8D80 Offset: 0x3BB8E81 VA: 0x3BB8D80
	|-EqualityComparer<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x3BB9AA0 Offset: 0x3BB9BA1 VA: 0x3BB9AA0
	|-EqualityComparer<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x3BBA6B0 Offset: 0x3BBA7B1 VA: 0x3BBA6B0
	|-EqualityComparer<Quaternion>..ctor
	|
	|-RVA: 0x3BBB260 Offset: 0x3BBB361 VA: 0x3BBB260
	|-EqualityComparer<RandomSeed>..ctor
	|
	|-RVA: 0x3BBBE10 Offset: 0x3BBBF11 VA: 0x3BBBE10
	|-EqualityComparer<RangePositionInfo>..ctor
	|
	|-RVA: 0x3BBC9A0 Offset: 0x3BBCAA1 VA: 0x3BBC9A0
	|-EqualityComparer<Ranking2ChartInfoInput>..ctor
	|
	|-RVA: 0x3BBD6F0 Offset: 0x3BBD7F1 VA: 0x3BBD6F0
	|-EqualityComparer<RaycastHit2D>..ctor
	|
	|-RVA: 0x3BBE4F0 Offset: 0x3BBE5F1 VA: 0x3BBE4F0
	|-EqualityComparer<RaycastResult>..ctor
	|
	|-RVA: 0x3BBF100 Offset: 0x3BBF201 VA: 0x3BBF100
	|-EqualityComparer<Rect>..ctor
	|
	|-RVA: 0x3BBFC90 Offset: 0x3BBFD91 VA: 0x3BBFC90
	|-EqualityComparer<RendererListHandle>..ctor
	|
	|-RVA: 0x3BC0820 Offset: 0x3BC0921 VA: 0x3BC0820
	|-EqualityComparer<ResourceHandle>..ctor
	|
	|-RVA: 0x3BC13D0 Offset: 0x3BC14D1 VA: 0x3BC13D0
	|-EqualityComparer<ResourceLocator>..ctor
	|
	|-RVA: 0x3BC1F60 Offset: 0x3BC2061 VA: 0x3BC1F60
	|-EqualityComparer<sbyte>..ctor
	|
	|-RVA: 0x3BC2AF0 Offset: 0x3BC2BF1 VA: 0x3BC2AF0
	|-EqualityComparer<ShaderTagId>..ctor
	|
	|-RVA: 0x3BC36A0 Offset: 0x3BC37A1 VA: 0x3BC36A0
	|-EqualityComparer<float>..ctor
	|
	|-RVA: 0x3BC45F0 Offset: 0x3BC46F1 VA: 0x3BC45F0
	|-EqualityComparer<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x3BC5280 Offset: 0x3BC5381 VA: 0x3BC5280
	|-EqualityComparer<SpriteState>..ctor
	|
	|-RVA: 0x3BC5F90 Offset: 0x3BC6091 VA: 0x3BC5F90
	|-EqualityComparer<SubMeshDescriptor>..ctor
	|
	|-RVA: 0x3BC6B40 Offset: 0x3BC6C41 VA: 0x3BC6B40
	|-EqualityComparer<TablePair>..ctor
	|
	|-RVA: 0x3BC76D0 Offset: 0x3BC77D1 VA: 0x3BC76D0
	|-EqualityComparer<TimeSpan>..ctor
	|
	|-RVA: 0x3BC82D0 Offset: 0x3BC83D1 VA: 0x3BC82D0
	|-EqualityComparer<UICharInfo>..ctor
	|
	|-RVA: 0x3BC8E80 Offset: 0x3BC8F81 VA: 0x3BC8E80
	|-EqualityComparer<UILineInfo>..ctor
	|
	|-RVA: 0x3BC9DD0 Offset: 0x3BC9ED1 VA: 0x3BC9DD0
	|-EqualityComparer<UIVertex>..ctor
	|
	|-RVA: 0x3BCA960 Offset: 0x3BCAA61 VA: 0x3BCA960
	|-EqualityComparer<ushort>..ctor
	|
	|-RVA: 0x3BCB4F0 Offset: 0x3BCB5F1 VA: 0x3BCB4F0
	|-EqualityComparer<uint>..ctor
	|
	|-RVA: 0x3BCC080 Offset: 0x3BCC181 VA: 0x3BCC080
	|-EqualityComparer<ulong>..ctor
	|
	|-RVA: 0x3BCCC10 Offset: 0x3BCCD11 VA: 0x3BCCC10
	|-EqualityComparer<UniTask>..ctor
	|
	|-RVA: 0x3BCD7A0 Offset: 0x3BCD8A1 VA: 0x3BCD7A0
	|-EqualityComparer<Unit>..ctor
	|
	|-RVA: 0x3BCE360 Offset: 0x3BCE461 VA: 0x3BCE360
	|-EqualityComparer<Vector2>..ctor
	|
	|-RVA: 0x3BCEF60 Offset: 0x3BCF061 VA: 0x3BCEF60
	|-EqualityComparer<Vector3>..ctor
	|
	|-RVA: 0x3BCFB70 Offset: 0x3BCFC71 VA: 0x3BCFB70
	|-EqualityComparer<Vector4>..ctor
	|
	|-RVA: 0x3BD0720 Offset: 0x3BD0821 VA: 0x3BD0720
	|-EqualityComparer<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x3BD12D0 Offset: 0x3BD13D1 VA: 0x3BD12D0
	|-EqualityComparer<X509ChainStatus>..ctor
	|
	|-RVA: 0x3BD1E80 Offset: 0x3BD1F81 VA: 0x3BD1E80
	|-EqualityComparer<XPathNodeRef>..ctor
	|
	|-RVA: 0x3BD2B30 Offset: 0x3BD2C31 VA: 0x3BD2B30
	|-EqualityComparer<XRView>..ctor
	|
	|-RVA: 0x3BD36E0 Offset: 0x3BD37E1 VA: 0x3BD36E0
	|-EqualityComparer<AmiiboSequence.GainItemData>..ctor
	|
	|-RVA: 0x3BD4400 Offset: 0x3BD4501 VA: 0x3BD4400
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x3BD4FB0 Offset: 0x3BD50B1 VA: 0x3BD4FB0
	|-EqualityComparer<ArenaOrderSequence.GodInfo>..ctor
	|
	|-RVA: 0x3BD5B60 Offset: 0x3BD5C61 VA: 0x3BD5B60
	|-EqualityComparer<BattleInfo.SupportData>..ctor
	|
	|-RVA: 0x3BD6710 Offset: 0x3BD6811 VA: 0x3BD6710
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x3BD73B0 Offset: 0x3BD74B1 VA: 0x3BD73B0
	|-EqualityComparer<Camera.RenderRequest>..ctor
	|
	|-RVA: 0x3BD7F60 Offset: 0x3BD8061 VA: 0x3BD7F60
	|-EqualityComparer<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x3BD8AF0 Offset: 0x3BD8BF1 VA: 0x3BD8AF0
	|-EqualityComparer<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x3BD9680 Offset: 0x3BD9781 VA: 0x3BD9680
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x3BDA310 Offset: 0x3BDA411 VA: 0x3BDA310
	|-EqualityComparer<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x3B79840 Offset: 0x3B79941 VA: 0x3B79840
	|-EqualityComparer<Detail.AsyncResultInt>..ctor
	|
	|-RVA: 0x3B7A3F0 Offset: 0x3B7A4F1 VA: 0x3B7A3F0
	|-EqualityComparer<Detail.CppArray>..ctor
	|
	|-RVA: 0x3B7B100 Offset: 0x3B7B201 VA: 0x3B7B100
	|-EqualityComparer<Detail.NotificationEventInt>..ctor
	|
	|-RVA: 0x3B7BCB0 Offset: 0x3B7BDB1 VA: 0x3B7BCB0
	|-EqualityComparer<DragonRideTargetGroup.ChainParam>..ctor
	|
	|-RVA: 0x3B7C840 Offset: 0x3B7C941 VA: 0x3B7C840
	|-EqualityComparer<DynamicMesh.State>..ctor
	|
	|-RVA: 0x3B7D3F0 Offset: 0x3B7D4F1 VA: 0x3B7D3F0
	|-EqualityComparer<GameVariable.Value>..ctor
	|
	|-RVA: 0x3B7E090 Offset: 0x3B7E191 VA: 0x3B7E090
	|-EqualityComparer<GmapPathAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3B7ED30 Offset: 0x3B7EE31 VA: 0x3B7ED30
	|-EqualityComparer<GmapSpotAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x3B7F9D0 Offset: 0x3B7FAD1 VA: 0x3B7F9D0
	|-EqualityComparer<HubFastTravel.Location>..ctor
	|
	|-RVA: 0x3B806E0 Offset: 0x3B807E1 VA: 0x3B806E0
	|-EqualityComparer<HubLensFlare.Flare>..ctor
	|
	|-RVA: 0x3B81290 Offset: 0x3B81391 VA: 0x3B81290
	|-EqualityComparer<InventoryPoolItemMenuContent.KindBgNameClass>..ctor
	|
	|-RVA: 0x3B81E20 Offset: 0x3B81F21 VA: 0x3B81E20
	|-EqualityComparer<Map.Pos>..ctor
	|
	|-RVA: 0x3B829D0 Offset: 0x3B82AD1 VA: 0x3B829D0
	|-EqualityComparer<MapImage.BackupTerrain>..ctor
	|
	|-RVA: 0x3B83560 Offset: 0x3B83661 VA: 0x3B83560
	|-EqualityComparer<MapImageRange.Pos>..ctor
	|
	|-RVA: 0x3B84360 Offset: 0x3B84461 VA: 0x3B84360
	|-EqualityComparer<MapMind.Record>..ctor
	|
	|-RVA: 0x3B85000 Offset: 0x3B85101 VA: 0x3B85000
	|-EqualityComparer<MapMind.Target>..ctor
	|
	|-RVA: 0x3B85CA0 Offset: 0x3B85DA1 VA: 0x3B85CA0
	|-EqualityComparer<MapPanelDebug.Entity>..ctor
	|
	|-RVA: 0x3B86830 Offset: 0x3B86931 VA: 0x3B86830
	|-EqualityComparer<NexRanking.Data>..ctor
	|
	|-RVA: 0x3B873E0 Offset: 0x3B874E1 VA: 0x3B873E0
	|-EqualityComparer<NexVersus.RatingData>..ctor
	|
	|-RVA: 0x3B87F90 Offset: 0x3B88091 VA: 0x3B87F90
	|-EqualityComparer<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x3B88C40 Offset: 0x3B88D41 VA: 0x3B88C40
	|-EqualityComparer<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x3B89950 Offset: 0x3B89A51 VA: 0x3B89950
	|-EqualityComparer<QualitySettingsStack.Settings>..ctor
	|
	|-RVA: 0x3B8A4E0 Offset: 0x3B8A5E1 VA: 0x3B8A4E0
	|-EqualityComparer<RangeData.Offset>..ctor
	|
	|-RVA: 0x3B8B170 Offset: 0x3B8B271 VA: 0x3B8B170
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>..ctor
	|
	|-RVA: 0x3B8BE90 Offset: 0x3B8BF91 VA: 0x3B8BE90
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>..ctor
	|
	|-RVA: 0x3B8CA40 Offset: 0x3B8CB41 VA: 0x3B8CA40
	|-EqualityComparer<RingCleaningUnitSelectMenu.GodParam>..ctor
	|
	|-RVA: 0x3B8D760 Offset: 0x3B8D861 VA: 0x3B8D760
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x3B8E470 Offset: 0x3B8E571 VA: 0x3B8E470
	|-EqualityComparer<ShadowUtility.Edge>..ctor
	|
	|-RVA: 0x3B8F020 Offset: 0x3B8F121 VA: 0x3B8F020
	|-EqualityComparer<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x3B8FBB0 Offset: 0x3B8FCB1 VA: 0x3B8FBB0
	|-EqualityComparer<SkillArray.Entity>..ctor
	|
	|-RVA: 0x3B90780 Offset: 0x3B90881 VA: 0x3B90780
	|-EqualityComparer<Stream.Info>..ctor
	|
	|-RVA: 0x3B91500 Offset: 0x3B91601 VA: 0x3B91500
	|-EqualityComparer<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x3B921A0 Offset: 0x3B922A1 VA: 0x3B921A0
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x3B92E40 Offset: 0x3B92F41 VA: 0x3B92E40
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x3B939F0 Offset: 0x3B93AF1 VA: 0x3B939F0
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x3B94580 Offset: 0x3B94681 VA: 0x3B94580
	|-EqualityComparer<AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x3B95130 Offset: 0x3B95231 VA: 0x3B95130
	|-EqualityComparer<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	|
	|-RVA: 0x3B95DE0 Offset: 0x3B95EE1 VA: 0x3B95DE0
	|-EqualityComparer<Detail.DataStore.DataStoreChangeMetaParamInt>..ctor
	|
	|-RVA: 0x3B96990 Offset: 0x3B96A91 VA: 0x3B96990
	|-EqualityComparer<Detail.DataStore.DataStoreDeleteParamInt>..ctor
	|
	|-RVA: 0x3B976B0 Offset: 0x3B977B1 VA: 0x3B976B0
	|-EqualityComparer<Detail.DataStore.DataStoreGetMetaParamInt>..ctor
	|
	|-RVA: 0x3B98360 Offset: 0x3B98461 VA: 0x3B98360
	|-EqualityComparer<Detail.DataStore.DataStoreMetaInfoInt>..ctor
	|
	|-RVA: 0x3B99000 Offset: 0x3B99101 VA: 0x3B99000
	|-EqualityComparer<Detail.DataStore.DataStorePasswordInfoInt>..ctor
	|
	|-RVA: 0x3B99CA0 Offset: 0x3B99DA1 VA: 0x3B99CA0
	|-EqualityComparer<Detail.DataStore.DataStorePersistenceInfoInt>..ctor
	|
	|-RVA: 0x3B9A950 Offset: 0x3B9AA51 VA: 0x3B9A950
	|-EqualityComparer<Detail.DataStore.DataStorePreparePostParamInt>..ctor
	|
	|-RVA: 0x3B9B500 Offset: 0x3B9B601 VA: 0x3B9B500
	|-EqualityComparer<Detail.DataStore.DataStoreRateObjectParamInt>..ctor
	|
	|-RVA: 0x3B9C190 Offset: 0x3B9C291 VA: 0x3B9C190
	|-EqualityComparer<Detail.DataStore.DataStoreRatingInitParamInt>..ctor
	|
	|-RVA: 0x33BD3D0 Offset: 0x33BD4D1 VA: 0x33BD3D0
	|-EqualityComparer<Detail.DataStore.DataStoreRatingTargetInt>..ctor
	|
	|-RVA: 0x33BE160 Offset: 0x33BE261 VA: 0x33BE160
	|-EqualityComparer<Detail.Ranking.RankingCachedResultInt>..ctor
	|
	|-RVA: 0x33BED10 Offset: 0x33BEE11 VA: 0x33BED10
	|-EqualityComparer<Detail.Ranking.RankingOrderParamInt>..ctor
	|
	|-RVA: 0x33BFA90 Offset: 0x33BFB91 VA: 0x33BFA90
	|-EqualityComparer<Detail.Ranking.RankingRankDataInt>..ctor
	|
	|-RVA: 0x33C08F0 Offset: 0x33C09F1 VA: 0x33C08F0
	|-EqualityComparer<Detail.Ranking2.Ranking2ChartInfoInt>..ctor
	|
	|-RVA: 0x33C1670 Offset: 0x33C1771 VA: 0x33C1670
	|-EqualityComparer<Detail.Ranking2.Ranking2RankDataInt>..ctor
	|
	|-RVA: 0x33C2220 Offset: 0x33C2321 VA: 0x33C2220
	|-EqualityComparer<Detail.Ranking2.Ranking2ScoreDataInt>..ctor
	|
	|-RVA: 0x33C2EB0 Offset: 0x33C2FB1 VA: 0x33C2EB0
	|-EqualityComparer<Detail.Screening.ScreeningContextInfoInt>..ctor
	|
	|-RVA: 0x33C3CB0 Offset: 0x33C3DB1 VA: 0x33C3CB0
	|-EqualityComparer<Detail.Subscriber.SubscriberContentInt>..ctor
	|
	|-RVA: 0x33C4950 Offset: 0x33C4A51 VA: 0x33C4950
	|-EqualityComparer<Detail.Subscriber.SubscriberGetContentParamInt>..ctor
	|
	|-RVA: 0x33C5670 Offset: 0x33C5771 VA: 0x33C5670
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusInfoInt>..ctor
	|
	|-RVA: 0x33C6310 Offset: 0x33C6411 VA: 0x33C6310
	|-EqualityComparer<Detail.Subscriber.SubscriberUserStatusParamInt>..ctor
	|
	|-RVA: 0x33C6EA0 Offset: 0x33C6FA1 VA: 0x33C6EA0
	|-EqualityComparer<Detail.Utility.IntegerSettings>..ctor
	|
	|-RVA: 0x33C7A50 Offset: 0x33C7B51 VA: 0x33C7A50
	|-EqualityComparer<Detail.Utility.UniqueIdInfoInt>..ctor
	|
	|-RVA: 0x33C8620 Offset: 0x33C8721 VA: 0x33C8620
	|-EqualityComparer<MapHistory.Rewind.LatestInspectorData>..ctor
	|
	|-RVA: 0x33C91F0 Offset: 0x33C92F1 VA: 0x33C91F0
	|-EqualityComparer<MapHistory.Rewind.WorkTerrainData>..ctor
	|
	|-RVA: 0x33C9DA0 Offset: 0x33C9EA1 VA: 0x33C9DA0
	|-EqualityComparer<MapSkill.AroundCalculator.Result>..ctor
	|
	|-RVA: 0x33CAAB0 Offset: 0x33CABB1 VA: 0x33CAAB0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x33CB800 Offset: 0x33CB901 VA: 0x33CB800
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x33CC390 Offset: 0x33CC491 VA: 0x33CC390
	|-EqualityComparer<TerrainUtility.TerrainMap.TileCoord>..ctor
	*/
}

