// Namespace: System.Runtime.Remoting.Channels
[Serializable]
internal class CrossAppDomainData // TypeDefIndex: 1150
{
	// Fields
	private object _ContextID; // 0x10
	private int _DomainID; // 0x18
	private string _processGuid; // 0x20

	// Properties
	internal int DomainID { get; }
	internal string ProcessID { get; }

	// Methods

	// RVA: 0x37D5D20 Offset: 0x37D5E21 VA: 0x37D5D20
	internal void .ctor(int domainId) { }

	// RVA: 0x37D62D0 Offset: 0x37D63D1 VA: 0x37D62D0
	internal int get_DomainID() { }

	// RVA: 0x37D62E0 Offset: 0x37D63E1 VA: 0x37D62E0
	internal string get_ProcessID() { }
}

