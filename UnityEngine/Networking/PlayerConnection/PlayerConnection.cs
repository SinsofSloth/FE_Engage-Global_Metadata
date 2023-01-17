// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class PlayerConnection : ScriptableObject // TypeDefIndex: 3859
{
	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	[SerializeField] // RVA: 0x4445C0 Offset: 0x4446C1 VA: 0x4445C0
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	[SerializeField] // RVA: 0x4445D0 Offset: 0x4446D1 VA: 0x4445D0
	private List<int> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Properties
	public static PlayerConnection instance { get; }
	public bool isConnected { get; }

	// Methods

	// RVA: 0x3494230 Offset: 0x3494331 VA: 0x3494230
	public static PlayerConnection get_instance() { }

	// RVA: 0x34944E0 Offset: 0x34945E1 VA: 0x34944E0
	public bool get_isConnected() { }

	// RVA: 0x3494420 Offset: 0x3494521 VA: 0x3494420
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x3494690 Offset: 0x3494791 VA: 0x3494690
	public void OnEnable() { }

	// RVA: 0x34945F0 Offset: 0x34946F1 VA: 0x34945F0
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x34947C0 Offset: 0x34948C1 VA: 0x34947C0 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x3494C30 Offset: 0x3494D31 VA: 0x3494C30 Slot: 5
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x3494FE0 Offset: 0x34950E1 VA: 0x3494FE0 Slot: 6
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x3495150 Offset: 0x3495251 VA: 0x3495150 Slot: 7
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x34951B0 Offset: 0x34952B1 VA: 0x34951B0 Slot: 8
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x3495210 Offset: 0x3495311 VA: 0x3495210 Slot: 9
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x3495270 Offset: 0x3495371 VA: 0x3495270 Slot: 10
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x3495450 Offset: 0x3495551 VA: 0x3495450 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x3495630 Offset: 0x3495731 VA: 0x3495630
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x34958D0 Offset: 0x34959D1 VA: 0x34958D0 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x452EB0 Offset: 0x452FB1 VA: 0x452EB0
	// RVA: 0x34959E0 Offset: 0x3495AE1 VA: 0x34959E0
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x452EC0 Offset: 0x452FC1 VA: 0x452EC0
	// RVA: 0x3495F50 Offset: 0x3496051 VA: 0x3495F50
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x452ED0 Offset: 0x452FD1 VA: 0x452ED0
	// RVA: 0x3495FE0 Offset: 0x34960E1 VA: 0x3495FE0
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x3496070 Offset: 0x3496171 VA: 0x3496070
	public void .ctor() { }
}

