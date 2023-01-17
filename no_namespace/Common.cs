// Namespace: 
[FlagsAttribute] // RVA: 0x27AC80 Offset: 0x27AD81 VA: 0x27AC80
public enum Common.ThreadMode // TypeDefIndex: 14864
{
	// Fields
	public int value__; // 0x0
	public const Common.ThreadMode ThreadModeSafeTransportBuffer = 1;
	public const Common.ThreadMode ThreadModeUnsafeTransportBuffer = 2;
}

// Namespace: 
public enum Common.NotificationEvents // TypeDefIndex: 14866
{
	// Fields
	public int value__; // 0x0
	public const Common.NotificationEvents ParticipationEvent = 3;
	public const Common.NotificationEvents OwnershipChangeEvent = 4;
	public const Common.NotificationEvents GatheringUnregistered = 109;
	public const Common.NotificationEvents HostChangeEvent = 110;
	public const Common.NotificationEvents GameNotificationLogout = 111;
	public const Common.NotificationEvents SubscriptionEvent = 112;
	public const Common.NotificationEvents GameServerMaintenance = 113;
	public const Common.NotificationEvents MaintenanceAnnouncement = 114;
	public const Common.NotificationEvents RoundStarted = 116;
	public const Common.NotificationEvents FirstRoundReportReceived = 117;
	public const Common.NotificationEvents RoundSummarized = 118;
	public const Common.NotificationEvents MatchmakeSystemConfigurationNotification = 119;
	public const Common.NotificationEvents MatchmakeSessionSystemPasswordSet = 120;
	public const Common.NotificationEvents MatchmakeSessionSystemPasswordClear = 121;
	public const Common.NotificationEvents AddedToGathering = 122;
	public const Common.NotificationEvents UserStatusUpdatedEvent = 128;
}

