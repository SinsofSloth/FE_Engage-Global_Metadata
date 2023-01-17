// Namespace: nn.friends
public struct UserPresence // TypeDefIndex: 14752
{
	// Methods

	// RVA: 0x20AB440 Offset: 0x20AB541 VA: 0x20AB440
	public Result Initialize(Uid uid) { }

	// RVA: 0x20AB480 Offset: 0x20AB581 VA: 0x20AB480
	public Result Initialize() { }

	// RVA: 0x20AB4C0 Offset: 0x20AB5C1 VA: 0x20AB4C0
	public void Clear() { }

	// RVA: 0x20AB4E0 Offset: 0x20AB5E1 VA: 0x20AB4E0
	public Result Commit() { }

	// RVA: 0x20AB520 Offset: 0x20AB621 VA: 0x20AB520
	public void DeclareOpenOnlinePlaySession() { }

	// RVA: 0x20AB540 Offset: 0x20AB641 VA: 0x20AB540
	public void DeclareCloseOnlinePlaySession() { }

	// RVA: 0x20AB560 Offset: 0x20AB661 VA: 0x20AB560
	public Result SetDescription(string description) { }

	// RVA: 0x20AB460 Offset: 0x20AB561 VA: 0x20AB460
	private static extern Result Initialize(ref UserPresence pUserPresence, Uid uid) { }

	// RVA: 0x20AB4A0 Offset: 0x20AB5A1 VA: 0x20AB4A0
	private static extern Result Initialize(ref UserPresence pUserPresence) { }

	// RVA: 0x20AB4D0 Offset: 0x20AB5D1 VA: 0x20AB4D0
	private static extern void Clear(ref UserPresence pUserPresence) { }

	// RVA: 0x20AB500 Offset: 0x20AB601 VA: 0x20AB500
	private static extern Result Commit(ref UserPresence pUserPresence) { }

	// RVA: 0x20AB530 Offset: 0x20AB631 VA: 0x20AB530
	private static extern void DeclareOpenOnlinePlaySession(ref UserPresence pUserPresence) { }

	// RVA: 0x20AB550 Offset: 0x20AB651 VA: 0x20AB550
	private static extern void DeclareCloseOnlinePlaySession(ref UserPresence pUserPresence) { }

	// RVA: 0x20AB5B0 Offset: 0x20AB6B1 VA: 0x20AB5B0
	private static extern Result SetDescription(ref UserPresence pUserPresence, [In] string description) { }
}

