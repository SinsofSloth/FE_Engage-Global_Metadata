// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CallContextRemotingData : ICloneable // TypeDefIndex: 1182
{
	// Fields
	private string _logicalCallID; // 0x10

	// Properties
	internal string LogicalCallID { get; set; }
	internal bool HasInfo { get; }

	// Methods

	// RVA: 0x3515EF0 Offset: 0x3515FF1 VA: 0x3515EF0
	internal string get_LogicalCallID() { }

	// RVA: 0x3515F00 Offset: 0x3516001 VA: 0x3515F00
	internal void set_LogicalCallID(string value) { }

	// RVA: 0x3515F10 Offset: 0x3516011 VA: 0x3515F10
	internal bool get_HasInfo() { }

	// RVA: 0x3515F20 Offset: 0x3516021 VA: 0x3515F20 Slot: 4
	public object Clone() { }

	// RVA: 0x3515FA0 Offset: 0x35160A1 VA: 0x3515FA0
	public void .ctor() { }
}

