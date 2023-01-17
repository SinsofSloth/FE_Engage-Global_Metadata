// Namespace: System.Runtime.Remoting.Messaging
internal class IllogicalCallContext // TypeDefIndex: 1178
{
	// Fields
	private Hashtable m_Datastore; // 0x10
	private object m_HostContext; // 0x18

	// Properties
	private Hashtable Datastore { get; }
	internal object HostContext { get; set; }
	internal bool HasUserData { get; }

	// Methods

	// RVA: 0x340E450 Offset: 0x340E551 VA: 0x340E450
	private Hashtable get_Datastore() { }

	// RVA: 0x340E4E0 Offset: 0x340E5E1 VA: 0x340E4E0
	internal object get_HostContext() { }

	// RVA: 0x340E4F0 Offset: 0x340E5F1 VA: 0x340E4F0
	internal void set_HostContext(object value) { }

	// RVA: 0x340E500 Offset: 0x340E601 VA: 0x340E500
	internal bool get_HasUserData() { }

	// RVA: 0x340E530 Offset: 0x340E631 VA: 0x340E530
	public IllogicalCallContext CreateCopy() { }

	// RVA: 0x340E810 Offset: 0x340E911 VA: 0x340E810
	public void .ctor() { }
}

