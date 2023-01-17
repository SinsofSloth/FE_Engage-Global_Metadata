// Namespace: UniRx
public sealed class CompositeDisposable : ICollection<IDisposable>, IEnumerable<IDisposable>, IEnumerable, IDisposable, ICancelable // TypeDefIndex: 6474
{
	// Fields
	private readonly object _gate; // 0x10
	private bool _disposed; // 0x18
	private List<IDisposable> _disposables; // 0x20
	private int _count; // 0x28
	private const int SHRINK_THRESHOLD = 64;

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public bool IsDisposed { get; }

	// Methods

	// RVA: 0x19CE270 Offset: 0x19CE371 VA: 0x19CE270
	public void .ctor() { }

	// RVA: 0x19CE340 Offset: 0x19CE441 VA: 0x19CE340
	public void .ctor(int capacity) { }

	// RVA: 0x19CE460 Offset: 0x19CE561 VA: 0x19CE460
	public void .ctor(IDisposable[] disposables) { }

	// RVA: 0x19CE5A0 Offset: 0x19CE6A1 VA: 0x19CE5A0
	public void .ctor(IEnumerable<IDisposable> disposables) { }

	// RVA: 0x19CE6E0 Offset: 0x19CE7E1 VA: 0x19CE6E0 Slot: 4
	public int get_Count() { }

	// RVA: 0x19CE6F0 Offset: 0x19CE7F1 VA: 0x19CE6F0 Slot: 6
	public void Add(IDisposable item) { }

	// RVA: 0x19CE8E0 Offset: 0x19CE9E1 VA: 0x19CE8E0 Slot: 10
	public bool Remove(IDisposable item) { }

	// RVA: 0x19CED30 Offset: 0x19CEE31 VA: 0x19CED30 Slot: 13
	public void Dispose() { }

	// RVA: 0x19CEF30 Offset: 0x19CF031 VA: 0x19CEF30 Slot: 7
	public void Clear() { }

	// RVA: 0x19CF120 Offset: 0x19CF221 VA: 0x19CF120 Slot: 8
	public bool Contains(IDisposable item) { }

	// RVA: 0x19CF280 Offset: 0x19CF381 VA: 0x19CF280 Slot: 9
	public void CopyTo(IDisposable[] array, int arrayIndex) { }

	// RVA: 0x19CF620 Offset: 0x19CF721 VA: 0x19CF620 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x19CF630 Offset: 0x19CF731 VA: 0x19CF630 Slot: 11
	public IEnumerator<IDisposable> GetEnumerator() { }

	// RVA: 0x19CF8C0 Offset: 0x19CF9C1 VA: 0x19CF8C0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x19CF8D0 Offset: 0x19CF9D1 VA: 0x19CF8D0 Slot: 14
	public bool get_IsDisposed() { }
}

