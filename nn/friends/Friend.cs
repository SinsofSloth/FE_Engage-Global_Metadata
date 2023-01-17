// Namespace: nn.friends
public struct Friend // TypeDefIndex: 14750
{
	// Methods

	// RVA: 0x2A080B0 Offset: 0x2A081B1 VA: 0x2A080B0
	public NetworkServiceAccountId GetAccountId() { }

	// RVA: 0x2A08130 Offset: 0x2A08231 VA: 0x2A08130
	public Nickname GetNickname() { }

	// RVA: 0x2A081F0 Offset: 0x2A082F1 VA: 0x2A081F0
	public FriendPresence GetPresence() { }

	// RVA: 0x2A082C0 Offset: 0x2A083C1 VA: 0x2A082C0
	public Result GetProfileImage(ref long outSize, byte[] buffer) { }

	// RVA: 0x2A083B0 Offset: 0x2A084B1 VA: 0x2A083B0
	public bool IsFavorite() { }

	// RVA: 0x2A08430 Offset: 0x2A08531 VA: 0x2A08430
	public bool IsNewly() { }

	// RVA: 0x2A084B0 Offset: 0x2A085B1 VA: 0x2A084B0
	public bool IsValid() { }

	// RVA: 0x2A08530 Offset: 0x2A08631 VA: 0x2A08530
	public Result Update() { }

	// RVA: 0x2A080F0 Offset: 0x2A081F1 VA: 0x2A080F0
	private static extern NetworkServiceAccountId GetAccountId(Friend friend) { }

	// RVA: 0x2A08190 Offset: 0x2A08291 VA: 0x2A08190
	private static extern Nickname GetNickname(Friend friend) { }

	// RVA: 0x2A08280 Offset: 0x2A08381 VA: 0x2A08280
	private static extern void GetPresence(Friend friend, ref FriendPresence outPresence) { }

	// RVA: 0x2A08340 Offset: 0x2A08441 VA: 0x2A08340
	private static extern Result GetProfileImage(Friend friend, ref long outSize, [In] [Out] byte[] outBuffer, long size) { }

	// RVA: 0x2A083F0 Offset: 0x2A084F1 VA: 0x2A083F0
	private static extern bool IsFavorite(Friend friend) { }

	// RVA: 0x2A08470 Offset: 0x2A08571 VA: 0x2A08470
	private static extern bool IsNewly(Friend friend) { }

	// RVA: 0x2A084F0 Offset: 0x2A085F1 VA: 0x2A084F0
	private static extern bool IsValid(Friend friend) { }

	// RVA: 0x2A08550 Offset: 0x2A08651 VA: 0x2A08550
	private static extern Result Update(ref Friend pFriend) { }
}

