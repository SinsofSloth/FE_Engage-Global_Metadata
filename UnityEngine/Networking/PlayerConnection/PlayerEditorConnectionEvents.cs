// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
internal class PlayerEditorConnectionEvents // TypeDefIndex: 3866
{
	// Fields
	[SerializeField] // RVA: 0x4445E0 Offset: 0x4446E1 VA: 0x4445E0
	public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	[SerializeField] // RVA: 0x4445F0 Offset: 0x4446F1 VA: 0x4445F0
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x18
	[SerializeField] // RVA: 0x444600 Offset: 0x444701 VA: 0x444600
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x20

	// Methods

	// RVA: 0x3495B00 Offset: 0x3495C01 VA: 0x3495B00
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x3494A80 Offset: 0x3494B81 VA: 0x3494A80
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x3494E50 Offset: 0x3494F51 VA: 0x3494E50
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x3496140 Offset: 0x3496241 VA: 0x3496140
	public void .ctor() { }
}

