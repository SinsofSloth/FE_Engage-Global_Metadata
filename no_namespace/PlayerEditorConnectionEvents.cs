// Namespace: 
[Serializable]
public class PlayerEditorConnectionEvents.MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 3860
{
	// Methods

	// RVA: 0x3855680 Offset: 0x3855781 VA: 0x3855680
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerEditorConnectionEvents.ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 3861
{
	// Methods

	// RVA: 0x3855620 Offset: 0x3855721 VA: 0x3855620
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerEditorConnectionEvents.MessageTypeSubscribers // TypeDefIndex: 3862
{
	// Fields
	[SerializeField] // RVA: 0x444610 Offset: 0x444711 VA: 0x444610
	private string m_messageTypeId; // 0x10
	public int subscriberCount; // 0x18
	public PlayerEditorConnectionEvents.MessageEvent messageCallback; // 0x20

	// Properties
	public Guid MessageTypeId { get; set; }

	// Methods

	// RVA: 0x38552D0 Offset: 0x38553D1 VA: 0x38552D0
	public Guid get_MessageTypeId() { }

	// RVA: 0x38556E0 Offset: 0x38557E1 VA: 0x38556E0
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x3855730 Offset: 0x3855831 VA: 0x3855730
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x440690 Offset: 0x440791 VA: 0x440690
private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass6_0 // TypeDefIndex: 3863
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x38553E0 Offset: 0x38554E1 VA: 0x38553E0
	public void .ctor() { }

	// RVA: 0x38553F0 Offset: 0x38554F1 VA: 0x38553F0
	internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4406A0 Offset: 0x4407A1 VA: 0x4406A0
private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass7_0 // TypeDefIndex: 3864
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x38554A0 Offset: 0x38555A1 VA: 0x38554A0
	public void .ctor() { }

	// RVA: 0x38554B0 Offset: 0x38555B1 VA: 0x38554B0
	internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4406B0 Offset: 0x4407B1 VA: 0x4406B0
private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass8_0 // TypeDefIndex: 3865
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x3855560 Offset: 0x3855661 VA: 0x3855560
	public void .ctor() { }

	// RVA: 0x3855570 Offset: 0x3855671 VA: 0x3855570
	internal bool <UnregisterManagedCallback>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
}

