// Namespace: 
private class FromEventObservable.FromEvent<TDelegate> : IDisposable // TypeDefIndex: 6971
{
	// Fields
	private readonly FromEventObservable<TDelegate> parent; // 0x0
	private readonly IObserver<Unit> observer; // 0x0
	private TDelegate handler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FromEventObservable<TDelegate> parent, IObserver<Unit> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1B70 Offset: 0x33E1C71 VA: 0x33E1B70
	|-FromEventObservable.FromEvent<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1BC0 Offset: 0x33E1CC1 VA: 0x33E1BC0
	|-FromEventObservable.FromEvent<object>.Register
	*/

	// RVA: -1 Offset: -1
	private void OnNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1D90 Offset: 0x33E1E91 VA: 0x33E1D90
	|-FromEventObservable.FromEvent<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1EC0 Offset: 0x33E1FC1 VA: 0x33E1EC0
	|-FromEventObservable.FromEvent<object>.Dispose
	*/
}

// Namespace: 
private class FromEventObservable.FromEvent<TDelegate, TEventArgs> : IDisposable // TypeDefIndex: 6973
{
	// Fields
	private readonly FromEventObservable<TDelegate, TEventArgs> parent; // 0x0
	private readonly IObserver<TEventArgs> observer; // 0x0
	private TDelegate handler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FromEventObservable<TDelegate, TEventArgs> parent, IObserver<TEventArgs> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1F10 Offset: 0x33E2011 VA: 0x33E1F10
	|-FromEventObservable.FromEvent<object, bool>..ctor
	|
	|-RVA: 0x33E2220 Offset: 0x33E2321 VA: 0x33E2220
	|-FromEventObservable.FromEvent<object, int>..ctor
	|
	|-RVA: 0x33E2530 Offset: 0x33E2631 VA: 0x33E2530
	|-FromEventObservable.FromEvent<object, object>..ctor
	|
	|-RVA: 0x33E2840 Offset: 0x33E2941 VA: 0x33E2840
	|-FromEventObservable.FromEvent<object, float>..ctor
	|
	|-RVA: 0x33E2B50 Offset: 0x33E2C51 VA: 0x33E2B50
	|-FromEventObservable.FromEvent<object, Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1F60 Offset: 0x33E2061 VA: 0x33E1F60
	|-FromEventObservable.FromEvent<object, bool>.Register
	|
	|-RVA: 0x33E2270 Offset: 0x33E2371 VA: 0x33E2270
	|-FromEventObservable.FromEvent<object, int>.Register
	|
	|-RVA: 0x33E2580 Offset: 0x33E2681 VA: 0x33E2580
	|-FromEventObservable.FromEvent<object, object>.Register
	|
	|-RVA: 0x33E2890 Offset: 0x33E2991 VA: 0x33E2890
	|-FromEventObservable.FromEvent<object, float>.Register
	|
	|-RVA: 0x33E2BA0 Offset: 0x33E2CA1 VA: 0x33E2BA0
	|-FromEventObservable.FromEvent<object, Vector2>.Register
	*/

	// RVA: -1 Offset: -1
	private void OnNext(TEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E2130 Offset: 0x33E2231 VA: 0x33E2130
	|-FromEventObservable.FromEvent<object, bool>.OnNext
	|
	|-RVA: 0x33E2440 Offset: 0x33E2541 VA: 0x33E2440
	|-FromEventObservable.FromEvent<object, int>.OnNext
	|
	|-RVA: 0x33E2750 Offset: 0x33E2851 VA: 0x33E2750
	|-FromEventObservable.FromEvent<object, object>.OnNext
	|
	|-RVA: 0x33E2A60 Offset: 0x33E2B61 VA: 0x33E2A60
	|-FromEventObservable.FromEvent<object, float>.OnNext
	|
	|-RVA: 0x33E2D70 Offset: 0x33E2E71 VA: 0x33E2D70
	|-FromEventObservable.FromEvent<object, Vector2>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E21D0 Offset: 0x33E22D1 VA: 0x33E21D0
	|-FromEventObservable.FromEvent<object, bool>.Dispose
	|
	|-RVA: 0x33E24E0 Offset: 0x33E25E1 VA: 0x33E24E0
	|-FromEventObservable.FromEvent<object, int>.Dispose
	|
	|-RVA: 0x33E27F0 Offset: 0x33E28F1 VA: 0x33E27F0
	|-FromEventObservable.FromEvent<object, object>.Dispose
	|
	|-RVA: 0x33E2B00 Offset: 0x33E2C01 VA: 0x33E2B00
	|-FromEventObservable.FromEvent<object, float>.Dispose
	|
	|-RVA: 0x33E2E20 Offset: 0x33E2F21 VA: 0x33E2E20
	|-FromEventObservable.FromEvent<object, Vector2>.Dispose
	*/
}

// Namespace: 
private class FromEventObservable.FromEvent : IDisposable // TypeDefIndex: 6975
{
	// Fields
	private readonly FromEventObservable parent; // 0x10
	private readonly IObserver<Unit> observer; // 0x18
	private Action handler; // 0x20

	// Methods

	// RVA: 0x1AFDFB0 Offset: 0x1AFE0B1 VA: 0x1AFDFB0
	public void .ctor(FromEventObservable parent, IObserver<Unit> observer) { }

	// RVA: 0x1AFE080 Offset: 0x1AFE181 VA: 0x1AFE080
	public bool Register() { }

	// RVA: 0x1AFE1E0 Offset: 0x1AFE2E1 VA: 0x1AFE1E0
	private void OnNext() { }

	// RVA: 0x1AFE310 Offset: 0x1AFE411 VA: 0x1AFE310 Slot: 4
	public void Dispose() { }
}

// Namespace: 
private class FromEventObservable_.FromEvent<T> : IDisposable // TypeDefIndex: 6977
{
	// Fields
	private readonly FromEventObservable_<T> parent; // 0x0
	private readonly IObserver<T> observer; // 0x0
	private Action<T> handler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FromEventObservable_<T> parent, IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1860 Offset: 0x33E1961 VA: 0x33E1860
	|-FromEventObservable_.FromEvent<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1910 Offset: 0x33E1A11 VA: 0x33E1910
	|-FromEventObservable_.FromEvent<object>.Register
	*/

	// RVA: -1 Offset: -1
	private void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1A70 Offset: 0x33E1B71 VA: 0x33E1A70
	|-FromEventObservable_.FromEvent<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1B10 Offset: 0x33E1C11 VA: 0x33E1B10
	|-FromEventObservable_.FromEvent<object>.Dispose
	*/
}

