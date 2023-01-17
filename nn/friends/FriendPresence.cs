// Namespace: nn.friends
public struct FriendPresence // TypeDefIndex: 14753
{
	// Methods

	// RVA: 0x269E3D0 Offset: 0x269E4D1 VA: 0x269E3D0
	public string GetDescription() { }

	// RVA: 0x269E530 Offset: 0x269E631 VA: 0x269E530
	public ApplicationInfo GetLastPlayedApplication() { }

	// RVA: 0x269E590 Offset: 0x269E691 VA: 0x269E590
	public long GetLastUpdatePosixTime() { }

	// RVA: 0x269E5F0 Offset: 0x269E6F1 VA: 0x269E5F0
	public PresenceStatus GetStatus() { }

	// RVA: 0x269E650 Offset: 0x269E751 VA: 0x269E650
	public bool IsSamePresenceGroupApplication() { }

	// RVA: 0x269E4B0 Offset: 0x269E5B1 VA: 0x269E4B0
	private static extern void GetDescription(FriendPresence pFriendPresence, [In] [Out] StringBuilder description, long size) { }

	// RVA: 0x269E560 Offset: 0x269E661 VA: 0x269E560
	private static extern ApplicationInfo GetLastPlayedApplication(FriendPresence pFriendPresence) { }

	// RVA: 0x269E5C0 Offset: 0x269E6C1 VA: 0x269E5C0
	private static extern long GetLastUpdatePosixTime(FriendPresence pFriendPresence) { }

	// RVA: 0x269E620 Offset: 0x269E721 VA: 0x269E620
	private static extern PresenceStatus GetStatus(FriendPresence pFriendPresence) { }

	// RVA: 0x269E690 Offset: 0x269E791 VA: 0x269E690
	private static extern bool IsSamePresenceGroupApplication(FriendPresence pFriendPresence) { }
}

