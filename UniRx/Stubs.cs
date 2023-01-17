// Namespace: UniRx
internal static class Stubs // TypeDefIndex: 6587
{
	// Fields
	public static readonly Action Nop; // 0x0
	public static readonly Action<Exception> Throw; // 0x8

	// Methods

	// RVA: -1 Offset: -1
	public static IObservable<TSource> CatchIgnore<TSource>(Exception ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023230 Offset: 0x2023331 VA: 0x2023230
	|-Stubs.CatchIgnore<object>
	*/

	// RVA: 0x1AF8360 Offset: 0x1AF8461 VA: 0x1AF8360
	private static void .cctor() { }
}

// Namespace: UniRx
internal static class Stubs<T> // TypeDefIndex: 6589
{
	// Fields
	public static readonly Action<T> Ignore; // 0x0
	public static readonly Func<T, T> Identity; // 0x0
	public static readonly Action<Exception, T> Throw; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D1BF0 Offset: 0x36D1CF1 VA: 0x36D1BF0
	|-Stubs<Pair<int>>..cctor
	|
	|-RVA: 0x36D2040 Offset: 0x36D2141 VA: 0x36D2040
	|-Stubs<ValueTuple<object, object>>..cctor
	|
	|-RVA: 0x36D2490 Offset: 0x36D2591 VA: 0x36D2490
	|-Stubs<ValueTuple<float, int>>..cctor
	|
	|-RVA: 0x36D28E0 Offset: 0x36D29E1 VA: 0x36D28E0
	|-Stubs<ValueTuple<float, Int32Enum>>..cctor
	|
	|-RVA: 0x36D2D30 Offset: 0x36D2E31 VA: 0x36D2D30
	|-Stubs<int>..cctor
	|
	|-RVA: 0x36D3180 Offset: 0x36D3281 VA: 0x36D3180
	|-Stubs<long>..cctor
	|
	|-RVA: 0x36D35D0 Offset: 0x36D36D1 VA: 0x36D35D0
	|-Stubs<object>..cctor
	|
	|-RVA: 0x36D3A20 Offset: 0x36D3B21 VA: 0x36D3A20
	|-Stubs<float>..cctor
	|
	|-RVA: 0x36D3E70 Offset: 0x36D3F71 VA: 0x36D3E70
	|-Stubs<Unit>..cctor
	*/
}

// Namespace: UniRx
internal static class Stubs<T1, T2> // TypeDefIndex: 6591
{
	// Fields
	public static readonly Action<T1, T2> Ignore; // 0x0
	public static readonly Action<Exception, T1, T2> Throw; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D42C0 Offset: 0x36D43C1 VA: 0x36D42C0
	|-Stubs<object, object>..cctor
	*/
}

// Namespace: UniRx
internal static class Stubs<T1, T2, T3> // TypeDefIndex: 6593
{
	// Fields
	public static readonly Action<T1, T2, T3> Ignore; // 0x0
	public static readonly Action<Exception, T1, T2, T3> Throw; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D4600 Offset: 0x36D4701 VA: 0x36D4600
	|-Stubs<object, object, object>..cctor
	*/
}

