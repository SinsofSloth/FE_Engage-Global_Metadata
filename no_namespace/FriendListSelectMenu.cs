// Namespace: 
public sealed class FriendListSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 13423
{
	// Methods

	// RVA: 0x22E0DE0 Offset: 0x22E0EE1 VA: 0x22E0DE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E0E00 Offset: 0x22E0F01 VA: 0x22E0E00 Slot: 13
	public virtual void Invoke(string pid) { }

	// RVA: 0x22E1160 Offset: 0x22E1261 VA: 0x22E1160 Slot: 14
	public virtual IAsyncResult BeginInvoke(string pid, AsyncCallback callback, object object) { }

	// RVA: 0x22E1190 Offset: 0x22E1291 VA: 0x22E1190 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class FriendListSelectMenu.FriendListSelectMenuItem : BasicMenuItem // TypeDefIndex: 13424
{
	// Fields
	private string m_Pid; // 0x68
	public FriendListSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x70

	// Methods

	// RVA: 0x22E11A0 Offset: 0x22E12A1 VA: 0x22E11A0
	public void .ctor(string pid, FriendListSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x22E11F0 Offset: 0x22E12F1 VA: 0x22E11F0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x22E1220 Offset: 0x22E1321 VA: 0x22E1220 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x22E1230 Offset: 0x22E1331 VA: 0x22E1230
	public string GetPID() { }
}

