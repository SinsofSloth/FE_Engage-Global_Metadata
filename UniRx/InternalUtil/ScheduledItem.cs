// Namespace: UniRx.InternalUtil
internal class ScheduledItem : IComparable<ScheduledItem> // TypeDefIndex: 7243
{
	// Fields
	private readonly BooleanDisposable _disposable; // 0x10
	private readonly TimeSpan _dueTime; // 0x18
	private readonly Action _action; // 0x20

	// Properties
	public TimeSpan DueTime { get; }
	public IDisposable Cancellation { get; }
	public bool IsCanceled { get; }

	// Methods

	// RVA: 0x1AF55C0 Offset: 0x1AF56C1 VA: 0x1AF55C0
	public void .ctor(Action action, TimeSpan dueTime) { }

	// RVA: 0x1AF5660 Offset: 0x1AF5761 VA: 0x1AF5660
	public TimeSpan get_DueTime() { }

	// RVA: 0x1AF5670 Offset: 0x1AF5771 VA: 0x1AF5670
	public void Invoke() { }

	// RVA: 0x1AF5690 Offset: 0x1AF5791 VA: 0x1AF5690 Slot: 4
	public int CompareTo(ScheduledItem other) { }

	// RVA: 0x1AF56E0 Offset: 0x1AF57E1 VA: 0x1AF56E0
	public static bool op_LessThan(ScheduledItem left, ScheduledItem right) { }

	// RVA: 0x1AF5730 Offset: 0x1AF5831 VA: 0x1AF5730
	public static bool op_LessThanOrEqual(ScheduledItem left, ScheduledItem right) { }

	// RVA: 0x1AF5780 Offset: 0x1AF5881 VA: 0x1AF5780
	public static bool op_GreaterThan(ScheduledItem left, ScheduledItem right) { }

	// RVA: 0x1AF57D0 Offset: 0x1AF58D1 VA: 0x1AF57D0
	public static bool op_GreaterThanOrEqual(ScheduledItem left, ScheduledItem right) { }

	// RVA: 0x1AF5820 Offset: 0x1AF5921 VA: 0x1AF5820
	public static bool op_Equality(ScheduledItem left, ScheduledItem right) { }

	// RVA: 0x1AF5830 Offset: 0x1AF5931 VA: 0x1AF5830
	public static bool op_Inequality(ScheduledItem left, ScheduledItem right) { }

	// RVA: 0x1AF5840 Offset: 0x1AF5941 VA: 0x1AF5840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AF5850 Offset: 0x1AF5951 VA: 0x1AF5850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AF5860 Offset: 0x1AF5961 VA: 0x1AF5860
	public IDisposable get_Cancellation() { }

	// RVA: 0x1AF5870 Offset: 0x1AF5971 VA: 0x1AF5870
	public bool get_IsCanceled() { }
}

