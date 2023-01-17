// Namespace: UnityEngine.Timeline
public class TimeNotificationBehaviour : PlayableBehaviour // TypeDefIndex: 5678
{
	// Fields
	private readonly List<TimeNotificationBehaviour.NotificationEntry> m_Notifications; // 0x10
	private double m_PreviousTime; // 0x18
	private bool m_NeedSortNotifications; // 0x20
	private Playable m_TimeSource; // 0x28

	// Properties
	public Playable timeSource { set; }

	// Methods

	// RVA: 0x36A9CA0 Offset: 0x36A9DA1 VA: 0x36A9CA0
	public void set_timeSource(Playable value) { }

	// RVA: 0x36A7870 Offset: 0x36A7971 VA: 0x36A7870
	public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode) { }

	// RVA: 0x36A79A0 Offset: 0x36A7AA1 VA: 0x36A79A0
	public void AddNotification(double time, INotification payload, NotificationFlags flags = 2) { }

	// RVA: 0x36A9CB0 Offset: 0x36A9DB1 VA: 0x36A9CB0 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x36A9FD0 Offset: 0x36AA0D1 VA: 0x36A9FD0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x36AA290 Offset: 0x36AA391 VA: 0x36AA290 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x36A9E80 Offset: 0x36A9F81 VA: 0x36A9E80
	private void SortNotifications() { }

	// RVA: 0x36AA9B0 Offset: 0x36AAAB1 VA: 0x36AA9B0
	private static bool CanRestoreNotification(TimeNotificationBehaviour.NotificationEntry e, FrameData info, double currentTime, double previousTime) { }

	// RVA: 0x36AA760 Offset: 0x36AA861 VA: 0x36AA760
	private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState) { }

	// RVA: 0x36AA650 Offset: 0x36AA751 VA: 0x36AA650
	private void SyncDurationWithExternalSource(Playable playable) { }

	// RVA: 0x36AA1F0 Offset: 0x36AA2F1 VA: 0x36AA1F0
	private static void Trigger_internal(Playable playable, PlayableOutput output, ref TimeNotificationBehaviour.NotificationEntry e) { }

	// RVA: 0x36AAA30 Offset: 0x36AAB31 VA: 0x36AAA30
	private static void Restore_internal(ref TimeNotificationBehaviour.NotificationEntry e) { }

	// RVA: 0x36AAA60 Offset: 0x36AAB61 VA: 0x36AAA60
	public void .ctor() { }
}

