// Namespace: 
private struct TimeNotificationBehaviour.NotificationEntry // TypeDefIndex: 5676
{
	// Fields
	public double time; // 0x0
	public INotification payload; // 0x8
	public bool notificationFired; // 0x10
	public NotificationFlags flags; // 0x12

	// Properties
	public bool triggerInEditor { get; }
	public bool prewarm { get; }
	public bool triggerOnce { get; }

	// Methods

	// RVA: 0x36AAA50 Offset: 0x36AAB51 VA: 0x36AAA50
	public bool get_triggerInEditor() { }

	// RVA: 0x36AAA40 Offset: 0x36AAB41 VA: 0x36AAA40
	public bool get_prewarm() { }

	// RVA: 0x36A9FC0 Offset: 0x36AA0C1 VA: 0x36A9FC0
	public bool get_triggerOnce() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x56D70 Offset: 0x56E71 VA: 0x56D70
[Serializable]
private sealed class TimeNotificationBehaviour.<>c // TypeDefIndex: 5677
{
	// Fields
	public static readonly TimeNotificationBehaviour.<>c <>9; // 0x0
	public static Comparison<TimeNotificationBehaviour.NotificationEntry> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x36B9510 Offset: 0x36B9611 VA: 0x36B9510
	private static void .cctor() { }

	// RVA: 0x36B9580 Offset: 0x36B9681 VA: 0x36B9580
	public void .ctor() { }

	// RVA: 0x36B9590 Offset: 0x36B9691 VA: 0x36B9590
	internal int <SortNotifications>b__12_0(TimeNotificationBehaviour.NotificationEntry x, TimeNotificationBehaviour.NotificationEntry y) { }
}

