// Namespace: System
[ComVisibleAttribute] // RVA: 0x4710B0 Offset: 0x4711B1 VA: 0x4710B0
public static class Nullable // TypeDefIndex: 381
{
	// Methods

	// RVA: 0x3856C80 Offset: 0x3856D81 VA: 0x3856C80
	public static Type GetUnderlyingType(Type nullableType) { }
}

// Namespace: System
[DebuggerStepThroughAttribute] // RVA: 0x4710D0 Offset: 0x4711D1 VA: 0x4710D0
[Serializable]
public struct Nullable<T> // TypeDefIndex: 382
{
	// Fields
	internal T value; // 0x0
	internal bool has_value; // 0x0

	// Properties
	public bool HasValue { get; }
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9E80 Offset: 0x31A9F81 VA: 0x31A9E80
	|-Nullable<UniTask<ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x31AA430 Offset: 0x31AA531 VA: 0x31AA430
	|-Nullable<UniTask<ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x31AA9E0 Offset: 0x31AAAE1 VA: 0x31AA9E0
	|-Nullable<UniTask<ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x31AB020 Offset: 0x31AB121 VA: 0x31AB020
	|-Nullable<UniTask<ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x31AB5D0 Offset: 0x31AB6D1 VA: 0x31AB5D0
	|-Nullable<UniTask<ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x31ABC00 Offset: 0x31ABD01 VA: 0x31ABC00
	|-Nullable<UniTask<bool>>..ctor
	|
	|-RVA: 0x31AC1B0 Offset: 0x31AC2B1 VA: 0x31AC1B0
	|-Nullable<AnimatorStateInfo>..ctor
	|
	|-RVA: 0x31AC870 Offset: 0x31AC971 VA: 0x31AC870
	|-Nullable<bool>..ctor
	|
	|-RVA: 0x31ACD00 Offset: 0x31ACE01 VA: 0x31ACD00
	|-Nullable<DateTime>..ctor
	|
	|-RVA: 0x31AD190 Offset: 0x31AD291 VA: 0x31AD190
	|-Nullable<DateTimeOffset>..ctor
	|
	|-RVA: 0x31ADF70 Offset: 0x31AE071 VA: 0x31ADF70
	|-Nullable<Difficulty>..ctor
	|-Nullable<FinishStyle>..ctor
	|-Nullable<Int32Enum>..ctor
	|-Nullable<MonoSslPolicyErrors>..ctor
	|-Nullable<TokenType>..ctor
	|-Nullable<AccessoryData.Kinds>..ctor
	|-Nullable<BattleSide.Type>..ctor
	|-Nullable<Common.DispachFlag>..ctor
	|-Nullable<Force.Type>..ctor
	|-Nullable<GameUserData.Sequences>..ctor
	|-Nullable<ItemData.Kinds>..ctor
	|-Nullable<ItemData.UseTypes>..ctor
	|
	|-RVA: 0x31AD660 Offset: 0x31AD761 VA: 0x31AD660
	|-Nullable<double>..ctor
	|
	|-RVA: 0x31ADAF0 Offset: 0x31ADBF1 VA: 0x31ADAF0
	|-Nullable<int>..ctor
	|
	|-RVA: 0x31AE4A0 Offset: 0x31AE5A1 VA: 0x31AE4A0
	|-Nullable<LocalDefinition>..ctor
	|
	|-RVA: 0x31AE9F0 Offset: 0x31AEAF1 VA: 0x31AE9F0
	|-Nullable<RenderQueueRange>..ctor
	|
	|-RVA: 0x2B82FD0 Offset: 0x2B830D1 VA: 0x2B82FD0
	|-Nullable<RenderStateBlock>..ctor
	|
	|-RVA: 0x2B83740 Offset: 0x2B83841 VA: 0x2B83740
	|-Nullable<float>..ctor
	|
	|-RVA: 0x2B83BC0 Offset: 0x2B83CC1 VA: 0x2B83BC0
	|-Nullable<TablePair>..ctor
	|
	|-RVA: 0x2B84190 Offset: 0x2B84291 VA: 0x2B84190
	|-Nullable<TimeSpan>..ctor
	|
	|-RVA: 0x2B84620 Offset: 0x2B84721 VA: 0x2B84620
	|-Nullable<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9EA0 Offset: 0x31A9FA1 VA: 0x31A9EA0
	|-Nullable<UniTask<ValueTuple<bool, bool>>>.get_HasValue
	|
	|-RVA: 0x31AA450 Offset: 0x31AA551 VA: 0x31AA450
	|-Nullable<UniTask<ValueTuple<bool, int>>>.get_HasValue
	|
	|-RVA: 0x31AAA10 Offset: 0x31AAB11 VA: 0x31AAA10
	|-Nullable<UniTask<ValueTuple<bool, object>>>.get_HasValue
	|
	|-RVA: 0x31AB040 Offset: 0x31AB141 VA: 0x31AB040
	|-Nullable<UniTask<ValueTuple<bool, float>>>.get_HasValue
	|
	|-RVA: 0x31AB5F0 Offset: 0x31AB6F1 VA: 0x31AB5F0
	|-Nullable<UniTask<ValueTuple<bool, Vector2>>>.get_HasValue
	|
	|-RVA: 0x31ABC20 Offset: 0x31ABD21 VA: 0x31ABC20
	|-Nullable<UniTask<bool>>.get_HasValue
	|
	|-RVA: 0x31AC1D0 Offset: 0x31AC2D1 VA: 0x31AC1D0
	|-Nullable<AnimatorStateInfo>.get_HasValue
	|
	|-RVA: 0x31AC890 Offset: 0x31AC991 VA: 0x31AC890
	|-Nullable<bool>.get_HasValue
	|
	|-RVA: 0x31ACD10 Offset: 0x31ACE11 VA: 0x31ACD10
	|-Nullable<DateTime>.get_HasValue
	|
	|-RVA: 0x31AD1A0 Offset: 0x31AD2A1 VA: 0x31AD1A0
	|-Nullable<DateTimeOffset>.get_HasValue
	|
	|-RVA: 0x31ADF80 Offset: 0x31AE081 VA: 0x31ADF80
	|-Nullable<Difficulty>.get_HasValue
	|-Nullable<FinishStyle>.get_HasValue
	|-Nullable<Int32Enum>.get_HasValue
	|-Nullable<TokenType>.get_HasValue
	|-Nullable<AccessoryData.Kinds>.get_HasValue
	|-Nullable<BattleSide.Type>.get_HasValue
	|-Nullable<Common.DispachFlag>.get_HasValue
	|-Nullable<Force.Type>.get_HasValue
	|-Nullable<GameUserData.Sequences>.get_HasValue
	|-Nullable<ItemData.Kinds>.get_HasValue
	|-Nullable<ItemData.UseTypes>.get_HasValue
	|
	|-RVA: 0x31AD670 Offset: 0x31AD771 VA: 0x31AD670
	|-Nullable<double>.get_HasValue
	|
	|-RVA: 0x31ADB00 Offset: 0x31ADC01 VA: 0x31ADB00
	|-Nullable<int>.get_HasValue
	|
	|-RVA: 0x31AE4C0 Offset: 0x31AE5C1 VA: 0x31AE4C0
	|-Nullable<LocalDefinition>.get_HasValue
	|
	|-RVA: 0x31AEA00 Offset: 0x31AEB01 VA: 0x31AEA00
	|-Nullable<RenderQueueRange>.get_HasValue
	|
	|-RVA: 0x2B82FF0 Offset: 0x2B830F1 VA: 0x2B82FF0
	|-Nullable<RenderStateBlock>.get_HasValue
	|
	|-RVA: 0x2B83750 Offset: 0x2B83851 VA: 0x2B83750
	|-Nullable<float>.get_HasValue
	|
	|-RVA: 0x2B83BE0 Offset: 0x2B83CE1 VA: 0x2B83BE0
	|-Nullable<TablePair>.get_HasValue
	|
	|-RVA: 0x2B841A0 Offset: 0x2B842A1 VA: 0x2B841A0
	|-Nullable<TimeSpan>.get_HasValue
	|
	|-RVA: 0x2B84640 Offset: 0x2B84741 VA: 0x2B84640
	|-Nullable<Vector3>.get_HasValue
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9EB0 Offset: 0x31A9FB1 VA: 0x31A9EB0
	|-Nullable<UniTask<ValueTuple<bool, bool>>>.get_Value
	|
	|-RVA: 0x31AA460 Offset: 0x31AA561 VA: 0x31AA460
	|-Nullable<UniTask<ValueTuple<bool, int>>>.get_Value
	|
	|-RVA: 0x31AAA20 Offset: 0x31AAB21 VA: 0x31AAA20
	|-Nullable<UniTask<ValueTuple<bool, object>>>.get_Value
	|
	|-RVA: 0x31AB050 Offset: 0x31AB151 VA: 0x31AB050
	|-Nullable<UniTask<ValueTuple<bool, float>>>.get_Value
	|
	|-RVA: 0x31AB600 Offset: 0x31AB701 VA: 0x31AB600
	|-Nullable<UniTask<ValueTuple<bool, Vector2>>>.get_Value
	|
	|-RVA: 0x31ABC30 Offset: 0x31ABD31 VA: 0x31ABC30
	|-Nullable<UniTask<bool>>.get_Value
	|
	|-RVA: 0x31AC1E0 Offset: 0x31AC2E1 VA: 0x31AC1E0
	|-Nullable<AnimatorStateInfo>.get_Value
	|
	|-RVA: 0x31AC8A0 Offset: 0x31AC9A1 VA: 0x31AC8A0
	|-Nullable<bool>.get_Value
	|
	|-RVA: 0x31ACD20 Offset: 0x31ACE21 VA: 0x31ACD20
	|-Nullable<DateTime>.get_Value
	|
	|-RVA: 0x31AD1B0 Offset: 0x31AD2B1 VA: 0x31AD1B0
	|-Nullable<DateTimeOffset>.get_Value
	|
	|-RVA: 0x31AD680 Offset: 0x31AD781 VA: 0x31AD680
	|-Nullable<double>.get_Value
	|
	|-RVA: 0x31ADB10 Offset: 0x31ADC11 VA: 0x31ADB10
	|-Nullable<int>.get_Value
	|
	|-RVA: 0x31ADF90 Offset: 0x31AE091 VA: 0x31ADF90
	|-Nullable<Int32Enum>.get_Value
	|-Nullable<TokenType>.get_Value
	|-Nullable<Common.DispachFlag>.get_Value
	|
	|-RVA: 0x31AE4D0 Offset: 0x31AE5D1 VA: 0x31AE4D0
	|-Nullable<LocalDefinition>.get_Value
	|
	|-RVA: 0x31AEA10 Offset: 0x31AEB11 VA: 0x31AEA10
	|-Nullable<RenderQueueRange>.get_Value
	|
	|-RVA: 0x2B83000 Offset: 0x2B83101 VA: 0x2B83000
	|-Nullable<RenderStateBlock>.get_Value
	|
	|-RVA: 0x2B83760 Offset: 0x2B83861 VA: 0x2B83760
	|-Nullable<float>.get_Value
	|
	|-RVA: 0x2B83BF0 Offset: 0x2B83CF1 VA: 0x2B83BF0
	|-Nullable<TablePair>.get_Value
	|
	|-RVA: 0x2B841B0 Offset: 0x2B842B1 VA: 0x2B841B0
	|-Nullable<TimeSpan>.get_Value
	|
	|-RVA: 0x2B84650 Offset: 0x2B84751 VA: 0x2B84650
	|-Nullable<Vector3>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9F20 Offset: 0x31AA021 VA: 0x31A9F20
	|-Nullable<UniTask<ValueTuple<bool, bool>>>.Equals
	|
	|-RVA: 0x31AA4D0 Offset: 0x31AA5D1 VA: 0x31AA4D0
	|-Nullable<UniTask<ValueTuple<bool, int>>>.Equals
	|
	|-RVA: 0x31AAAA0 Offset: 0x31AABA1 VA: 0x31AAAA0
	|-Nullable<UniTask<ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x31AB0C0 Offset: 0x31AB1C1 VA: 0x31AB0C0
	|-Nullable<UniTask<ValueTuple<bool, float>>>.Equals
	|
	|-RVA: 0x31AB680 Offset: 0x31AB781 VA: 0x31AB680
	|-Nullable<UniTask<ValueTuple<bool, Vector2>>>.Equals
	|
	|-RVA: 0x31ABCA0 Offset: 0x31ABDA1 VA: 0x31ABCA0
	|-Nullable<UniTask<bool>>.Equals
	|
	|-RVA: 0x31AC270 Offset: 0x31AC371 VA: 0x31AC270
	|-Nullable<AnimatorStateInfo>.Equals
	|
	|-RVA: 0x31AC910 Offset: 0x31ACA11 VA: 0x31AC910
	|-Nullable<bool>.Equals
	|
	|-RVA: 0x31ACD90 Offset: 0x31ACE91 VA: 0x31ACD90
	|-Nullable<DateTime>.Equals
	|
	|-RVA: 0x31AD220 Offset: 0x31AD321 VA: 0x31AD220
	|-Nullable<DateTimeOffset>.Equals
	|
	|-RVA: 0x31AD6F0 Offset: 0x31AD7F1 VA: 0x31AD6F0
	|-Nullable<double>.Equals
	|
	|-RVA: 0x31ADB80 Offset: 0x31ADC81 VA: 0x31ADB80
	|-Nullable<int>.Equals
	|
	|-RVA: 0x31AE000 Offset: 0x31AE101 VA: 0x31AE000
	|-Nullable<Int32Enum>.Equals
	|
	|-RVA: 0x31AE540 Offset: 0x31AE641 VA: 0x31AE540
	|-Nullable<LocalDefinition>.Equals
	|
	|-RVA: 0x31AEA80 Offset: 0x31AEB81 VA: 0x31AEA80
	|-Nullable<RenderQueueRange>.Equals
	|
	|-RVA: 0x2B830B0 Offset: 0x2B831B1 VA: 0x2B830B0
	|-Nullable<RenderStateBlock>.Equals
	|
	|-RVA: 0x2B837D0 Offset: 0x2B838D1 VA: 0x2B837D0
	|-Nullable<float>.Equals
	|
	|-RVA: 0x2B83C60 Offset: 0x2B83D61 VA: 0x2B83C60
	|-Nullable<TablePair>.Equals
	|
	|-RVA: 0x2B84220 Offset: 0x2B84321 VA: 0x2B84220
	|-Nullable<TimeSpan>.Equals
	|
	|-RVA: 0x2B846C0 Offset: 0x2B847C1 VA: 0x2B846C0
	|-Nullable<Vector3>.Equals
	*/

	// RVA: -1 Offset: -1
	private bool Equals(Nullable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31AA060 Offset: 0x31AA161 VA: 0x31AA060
	|-Nullable<UniTask<ValueTuple<bool, bool>>>.Equals
	|
	|-RVA: 0x31AA610 Offset: 0x31AA711 VA: 0x31AA610
	|-Nullable<UniTask<ValueTuple<bool, int>>>.Equals
	|
	|-RVA: 0x31AABE0 Offset: 0x31AACE1 VA: 0x31AABE0
	|-Nullable<UniTask<ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x31AB200 Offset: 0x31AB301 VA: 0x31AB200
	|-Nullable<UniTask<ValueTuple<bool, float>>>.Equals
	|
	|-RVA: 0x31AB7C0 Offset: 0x31AB8C1 VA: 0x31AB7C0
	|-Nullable<UniTask<ValueTuple<bool, Vector2>>>.Equals
	|
	|-RVA: 0x31ABDE0 Offset: 0x31ABEE1 VA: 0x31ABDE0
	|-Nullable<UniTask<bool>>.Equals
	|
	|-RVA: 0x31AC3B0 Offset: 0x31AC4B1 VA: 0x31AC3B0
	|-Nullable<AnimatorStateInfo>.Equals
	|
	|-RVA: 0x31ACAB0 Offset: 0x31ACBB1 VA: 0x31ACAB0
	|-Nullable<bool>.Equals
	|
	|-RVA: 0x31ACF40 Offset: 0x31AD041 VA: 0x31ACF40
	|-Nullable<DateTime>.Equals
	|
	|-RVA: 0x31AD3C0 Offset: 0x31AD4C1 VA: 0x31AD3C0
	|-Nullable<DateTimeOffset>.Equals
	|
	|-RVA: 0x31AD8A0 Offset: 0x31AD9A1 VA: 0x31AD8A0
	|-Nullable<double>.Equals
	|
	|-RVA: 0x31ADD20 Offset: 0x31ADE21 VA: 0x31ADD20
	|-Nullable<int>.Equals
	|
	|-RVA: 0x31AE140 Offset: 0x31AE241 VA: 0x31AE140
	|-Nullable<Int32Enum>.Equals
	|
	|-RVA: 0x31AE6E0 Offset: 0x31AE7E1 VA: 0x31AE6E0
	|-Nullable<LocalDefinition>.Equals
	|
	|-RVA: 0x31AEC30 Offset: 0x31AED31 VA: 0x31AEC30
	|-Nullable<RenderQueueRange>.Equals
	|
	|-RVA: 0x2B832C0 Offset: 0x2B833C1 VA: 0x2B832C0
	|-Nullable<RenderStateBlock>.Equals
	|
	|-RVA: 0x2B83970 Offset: 0x2B83A71 VA: 0x2B83970
	|-Nullable<float>.Equals
	|
	|-RVA: 0x2B83DA0 Offset: 0x2B83EA1 VA: 0x2B83DA0
	|-Nullable<TablePair>.Equals
	|
	|-RVA: 0x2B843D0 Offset: 0x2B844D1 VA: 0x2B843D0
	|-Nullable<TimeSpan>.Equals
	|
	|-RVA: 0x2B847F0 Offset: 0x2B848F1 VA: 0x2B847F0
	|-Nullable<Vector3>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31AA170 Offset: 0x31AA271 VA: 0x31AA170
	|-Nullable<UniTask<ValueTuple<bool, bool>>>.GetHashCode
	|
	|-RVA: 0x31AA720 Offset: 0x31AA821 VA: 0x31AA720
	|-Nullable<UniTask<ValueTuple<bool, int>>>.GetHashCode
	|
	|-RVA: 0x31AAD00 Offset: 0x31AAE01 VA: 0x31AAD00
	|-Nullable<UniTask<ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x31AB310 Offset: 0x31AB411 VA: 0x31AB310
	|-Nullable<UniTask<ValueTuple<bool, float>>>.GetHashCode
	|
	|-RVA: 0x31AB8E0 Offset: 0x31AB9E1 VA: 0x31AB8E0
	|-Nullable<UniTask<ValueTuple<bool, Vector2>>>.GetHashCode
	|
	|-RVA: 0x31ABEF0 Offset: 0x31ABFF1 VA: 0x31ABEF0
	|-Nullable<UniTask<bool>>.GetHashCode
	|
	|-RVA: 0x31AC4F0 Offset: 0x31AC5F1 VA: 0x31AC4F0
	|-Nullable<AnimatorStateInfo>.GetHashCode
	|
	|-RVA: 0x31ACB50 Offset: 0x31ACC51 VA: 0x31ACB50
	|-Nullable<bool>.GetHashCode
	|
	|-RVA: 0x31ACFE0 Offset: 0x31AD0E1 VA: 0x31ACFE0
	|-Nullable<DateTime>.GetHashCode
	|
	|-RVA: 0x31AD470 Offset: 0x31AD571 VA: 0x31AD470
	|-Nullable<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x31AD940 Offset: 0x31ADA41 VA: 0x31AD940
	|-Nullable<double>.GetHashCode
	|
	|-RVA: 0x31ADDC0 Offset: 0x31ADEC1 VA: 0x31ADDC0
	|-Nullable<int>.GetHashCode
	|
	|-RVA: 0x31AE230 Offset: 0x31AE331 VA: 0x31AE230
	|-Nullable<Int32Enum>.GetHashCode
	|
	|-RVA: 0x31AE790 Offset: 0x31AE891 VA: 0x31AE790
	|-Nullable<LocalDefinition>.GetHashCode
	|
	|-RVA: 0x31AECE0 Offset: 0x31AEDE1 VA: 0x31AECE0
	|-Nullable<RenderQueueRange>.GetHashCode
	|
	|-RVA: 0x2B833A0 Offset: 0x2B834A1 VA: 0x2B833A0
	|-Nullable<RenderStateBlock>.GetHashCode
	|
	|-RVA: 0x2B83A10 Offset: 0x2B83B11 VA: 0x2B83A10
	|-Nullable<float>.GetHashCode
	|
	|-RVA: 0x2B83EB0 Offset: 0x2B83FB1 VA: 0x2B83EB0
	|-Nullable<TablePair>.GetHashCode
	|
	|-RVA: 0x2B84470 Offset: 0x2B84571 VA: 0x2B84470
	|-Nullable<TimeSpan>.GetHashCode
	|
	|-RVA: 0x2B848A0 Offset: 0x2B849A1 VA: 0x2B848A0
	|-Nullable<Vector3>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public T GetValueOrDefault() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31AA200 Offset: 0x31AA301 VA: 0x31AA200
	|-Nullable<UniTask<ValueTuple<bool, bool>>>.GetValueOrDefault
	|
	|-RVA: 0x31AA7B0 Offset: 0x31AA8B1 VA: 0x31AA7B0
	|-Nullable<UniTask<ValueTuple<bool, int>>>.GetValueOrDefault
	|
	|-RVA: 0x31AADA0 Offset: 0x31AAEA1 VA: 0x31AADA0
	|-Nullable<UniTask<ValueTuple<bool, object>>>.GetValueOrDefault
	|
	|-RVA: 0x31AB3A0 Offset: 0x31AB4A1 VA: 0x31AB3A0
	|-Nullable<UniTask<ValueTuple<bool, float>>>.GetValueOrDefault
	|
	|-RVA: 0x31AB980 Offset: 0x31ABA81 VA: 0x31AB980
	|-Nullable<UniTask<ValueTuple<bool, Vector2>>>.GetValueOrDefault
	|
	|-RVA: 0x31ABF80 Offset: 0x31AC081 VA: 0x31ABF80
	|-Nullable<UniTask<bool>>.GetValueOrDefault
	|
	|-RVA: 0x31AC5B0 Offset: 0x31AC6B1 VA: 0x31AC5B0
	|-Nullable<AnimatorStateInfo>.GetValueOrDefault
	|
	|-RVA: 0x31ACB70 Offset: 0x31ACC71 VA: 0x31ACB70
	|-Nullable<bool>.GetValueOrDefault
	|
	|-RVA: 0x31AD000 Offset: 0x31AD101 VA: 0x31AD000
	|-Nullable<DateTime>.GetValueOrDefault
	|
	|-RVA: 0x31AD490 Offset: 0x31AD591 VA: 0x31AD490
	|-Nullable<DateTimeOffset>.GetValueOrDefault
	|
	|-RVA: 0x31AE2C0 Offset: 0x31AE3C1 VA: 0x31AE2C0
	|-Nullable<Difficulty>.GetValueOrDefault
	|-Nullable<FinishStyle>.GetValueOrDefault
	|-Nullable<Int32Enum>.GetValueOrDefault
	|-Nullable<AccessoryData.Kinds>.GetValueOrDefault
	|-Nullable<BattleSide.Type>.GetValueOrDefault
	|-Nullable<Force.Type>.GetValueOrDefault
	|-Nullable<GameUserData.Sequences>.GetValueOrDefault
	|-Nullable<ItemData.Kinds>.GetValueOrDefault
	|-Nullable<ItemData.UseTypes>.GetValueOrDefault
	|
	|-RVA: 0x31AD960 Offset: 0x31ADA61 VA: 0x31AD960
	|-Nullable<double>.GetValueOrDefault
	|
	|-RVA: 0x31ADDE0 Offset: 0x31ADEE1 VA: 0x31ADDE0
	|-Nullable<int>.GetValueOrDefault
	|
	|-RVA: 0x31AE7B0 Offset: 0x31AE8B1 VA: 0x31AE7B0
	|-Nullable<LocalDefinition>.GetValueOrDefault
	|
	|-RVA: 0x31AED00 Offset: 0x31AEE01 VA: 0x31AED00
	|-Nullable<RenderQueueRange>.GetValueOrDefault
	|
	|-RVA: 0x2B833C0 Offset: 0x2B834C1 VA: 0x2B833C0
	|-Nullable<RenderStateBlock>.GetValueOrDefault
	|
	|-RVA: 0x2B83A30 Offset: 0x2B83B31 VA: 0x2B83A30
	|-Nullable<float>.GetValueOrDefault
	|
	|-RVA: 0x2B83F50 Offset: 0x2B84051 VA: 0x2B83F50
	|-Nullable<TablePair>.GetValueOrDefault
	|
	|-RVA: 0x2B84490 Offset: 0x2B84591 VA: 0x2B84490
	|-Nullable<TimeSpan>.GetValueOrDefault
	|
	|-RVA: 0x2B848C0 Offset: 0x2B849C1 VA: 0x2B848C0
	|-Nullable<Vector3>.GetValueOrDefault
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31AA210 Offset: 0x31AA311 VA: 0x31AA210
	|-Nullable<UniTask<ValueTuple<bool, bool>>>.ToString
	|
	|-RVA: 0x31AA7C0 Offset: 0x31AA8C1 VA: 0x31AA7C0
	|-Nullable<UniTask<ValueTuple<bool, int>>>.ToString
	|
	|-RVA: 0x31AADC0 Offset: 0x31AAEC1 VA: 0x31AADC0
	|-Nullable<UniTask<ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x31AB3B0 Offset: 0x31AB4B1 VA: 0x31AB3B0
	|-Nullable<UniTask<ValueTuple<bool, float>>>.ToString
	|
	|-RVA: 0x31AB9A0 Offset: 0x31ABAA1 VA: 0x31AB9A0
	|-Nullable<UniTask<ValueTuple<bool, Vector2>>>.ToString
	|
	|-RVA: 0x31ABF90 Offset: 0x31AC091 VA: 0x31ABF90
	|-Nullable<UniTask<bool>>.ToString
	|
	|-RVA: 0x31AC5E0 Offset: 0x31AC6E1 VA: 0x31AC5E0
	|-Nullable<AnimatorStateInfo>.ToString
	|
	|-RVA: 0x31ACB80 Offset: 0x31ACC81 VA: 0x31ACB80
	|-Nullable<bool>.ToString
	|
	|-RVA: 0x31AD010 Offset: 0x31AD111 VA: 0x31AD010
	|-Nullable<DateTime>.ToString
	|
	|-RVA: 0x31AD4A0 Offset: 0x31AD5A1 VA: 0x31AD4A0
	|-Nullable<DateTimeOffset>.ToString
	|
	|-RVA: 0x31AD970 Offset: 0x31ADA71 VA: 0x31AD970
	|-Nullable<double>.ToString
	|
	|-RVA: 0x31ADDF0 Offset: 0x31ADEF1 VA: 0x31ADDF0
	|-Nullable<int>.ToString
	|
	|-RVA: 0x31AE2D0 Offset: 0x31AE3D1 VA: 0x31AE2D0
	|-Nullable<Int32Enum>.ToString
	|
	|-RVA: 0x31AE7C0 Offset: 0x31AE8C1 VA: 0x31AE7C0
	|-Nullable<LocalDefinition>.ToString
	|
	|-RVA: 0x31AED10 Offset: 0x31AEE11 VA: 0x31AED10
	|-Nullable<RenderQueueRange>.ToString
	|
	|-RVA: 0x2B83410 Offset: 0x2B83511 VA: 0x2B83410
	|-Nullable<RenderStateBlock>.ToString
	|
	|-RVA: 0x2B83A40 Offset: 0x2B83B41 VA: 0x2B83A40
	|-Nullable<float>.ToString
	|
	|-RVA: 0x2B83F60 Offset: 0x2B84061 VA: 0x2B83F60
	|-Nullable<TablePair>.ToString
	|
	|-RVA: 0x2B844A0 Offset: 0x2B845A1 VA: 0x2B844A0
	|-Nullable<TimeSpan>.ToString
	|
	|-RVA: 0x2B848D0 Offset: 0x2B849D1 VA: 0x2B848D0
	|-Nullable<Vector3>.ToString
	*/

	// RVA: -1 Offset: -1
	private static object Box(Nullable<T> o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31AA2D0 Offset: 0x31AA3D1 VA: 0x31AA2D0
	|-Nullable<UniTask<ValueTuple<bool, bool>>>.Box
	|
	|-RVA: 0x31AA880 Offset: 0x31AA981 VA: 0x31AA880
	|-Nullable<UniTask<ValueTuple<bool, int>>>.Box
	|
	|-RVA: 0x31AAE90 Offset: 0x31AAF91 VA: 0x31AAE90
	|-Nullable<UniTask<ValueTuple<bool, object>>>.Box
	|
	|-RVA: 0x31AB470 Offset: 0x31AB571 VA: 0x31AB470
	|-Nullable<UniTask<ValueTuple<bool, float>>>.Box
	|
	|-RVA: 0x31ABA70 Offset: 0x31ABB71 VA: 0x31ABA70
	|-Nullable<UniTask<ValueTuple<bool, Vector2>>>.Box
	|
	|-RVA: 0x31AC050 Offset: 0x31AC151 VA: 0x31AC050
	|-Nullable<UniTask<bool>>.Box
	|
	|-RVA: 0x31AC6D0 Offset: 0x31AC7D1 VA: 0x31AC6D0
	|-Nullable<AnimatorStateInfo>.Box
	|
	|-RVA: 0x31ACBF0 Offset: 0x31ACCF1 VA: 0x31ACBF0
	|-Nullable<bool>.Box
	|
	|-RVA: 0x31AD080 Offset: 0x31AD181 VA: 0x31AD080
	|-Nullable<DateTime>.Box
	|
	|-RVA: 0x31AD510 Offset: 0x31AD611 VA: 0x31AD510
	|-Nullable<DateTimeOffset>.Box
	|
	|-RVA: 0x31AD9E0 Offset: 0x31ADAE1 VA: 0x31AD9E0
	|-Nullable<double>.Box
	|
	|-RVA: 0x31ADE60 Offset: 0x31ADF61 VA: 0x31ADE60
	|-Nullable<int>.Box
	|
	|-RVA: 0x31AE390 Offset: 0x31AE491 VA: 0x31AE390
	|-Nullable<Int32Enum>.Box
	|
	|-RVA: 0x31AE890 Offset: 0x31AE991 VA: 0x31AE890
	|-Nullable<LocalDefinition>.Box
	|
	|-RVA: 0x31AEDE0 Offset: 0x31AEEE1 VA: 0x31AEDE0
	|-Nullable<RenderQueueRange>.Box
	|
	|-RVA: 0x2B83520 Offset: 0x2B83621 VA: 0x2B83520
	|-Nullable<RenderStateBlock>.Box
	|
	|-RVA: 0x2B83AB0 Offset: 0x2B83BB1 VA: 0x2B83AB0
	|-Nullable<float>.Box
	|
	|-RVA: 0x2B84030 Offset: 0x2B84131 VA: 0x2B84030
	|-Nullable<TablePair>.Box
	|
	|-RVA: 0x2B84510 Offset: 0x2B84611 VA: 0x2B84510
	|-Nullable<TimeSpan>.Box
	|
	|-RVA: 0x2B84940 Offset: 0x2B84A41 VA: 0x2B84940
	|-Nullable<Vector3>.Box
	*/

	// RVA: -1 Offset: -1
	private static Nullable<T> Unbox(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31AA350 Offset: 0x31AA451 VA: 0x31AA350
	|-Nullable<UniTask<ValueTuple<bool, bool>>>.Unbox
	|
	|-RVA: 0x31AA900 Offset: 0x31AAA01 VA: 0x31AA900
	|-Nullable<UniTask<ValueTuple<bool, int>>>.Unbox
	|
	|-RVA: 0x31AAF20 Offset: 0x31AB021 VA: 0x31AAF20
	|-Nullable<UniTask<ValueTuple<bool, object>>>.Unbox
	|
	|-RVA: 0x31AB4F0 Offset: 0x31AB5F1 VA: 0x31AB4F0
	|-Nullable<UniTask<ValueTuple<bool, float>>>.Unbox
	|
	|-RVA: 0x31ABB00 Offset: 0x31ABC01 VA: 0x31ABB00
	|-Nullable<UniTask<ValueTuple<bool, Vector2>>>.Unbox
	|
	|-RVA: 0x31AC0D0 Offset: 0x31AC1D1 VA: 0x31AC0D0
	|-Nullable<UniTask<bool>>.Unbox
	|
	|-RVA: 0x31AC770 Offset: 0x31AC871 VA: 0x31AC770
	|-Nullable<AnimatorStateInfo>.Unbox
	|
	|-RVA: 0x31ACC60 Offset: 0x31ACD61 VA: 0x31ACC60
	|-Nullable<bool>.Unbox
	|
	|-RVA: 0x31AD0F0 Offset: 0x31AD1F1 VA: 0x31AD0F0
	|-Nullable<DateTime>.Unbox
	|
	|-RVA: 0x31AD590 Offset: 0x31AD691 VA: 0x31AD590
	|-Nullable<DateTimeOffset>.Unbox
	|
	|-RVA: 0x31ADA50 Offset: 0x31ADB51 VA: 0x31ADA50
	|-Nullable<double>.Unbox
	|
	|-RVA: 0x31ADED0 Offset: 0x31ADFD1 VA: 0x31ADED0
	|-Nullable<int>.Unbox
	|
	|-RVA: 0x31AE400 Offset: 0x31AE501 VA: 0x31AE400
	|-Nullable<Int32Enum>.Unbox
	|
	|-RVA: 0x31AE910 Offset: 0x31AEA11 VA: 0x31AE910
	|-Nullable<LocalDefinition>.Unbox
	|
	|-RVA: 0x31AEE50 Offset: 0x31AEF51 VA: 0x31AEE50
	|-Nullable<RenderQueueRange>.Unbox
	|
	|-RVA: 0x2B835E0 Offset: 0x2B836E1 VA: 0x2B835E0
	|-Nullable<RenderStateBlock>.Unbox
	|
	|-RVA: 0x2B83B20 Offset: 0x2B83C21 VA: 0x2B83B20
	|-Nullable<float>.Unbox
	|
	|-RVA: 0x2B840B0 Offset: 0x2B841B1 VA: 0x2B840B0
	|-Nullable<TablePair>.Unbox
	|
	|-RVA: 0x2B84580 Offset: 0x2B84681 VA: 0x2B84580
	|-Nullable<TimeSpan>.Unbox
	|
	|-RVA: 0x2B849C0 Offset: 0x2B84AC1 VA: 0x2B849C0
	|-Nullable<Vector3>.Unbox
	*/
}

