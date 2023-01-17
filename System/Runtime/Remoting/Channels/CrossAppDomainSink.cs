// Namespace: System.Runtime.Remoting.Channels
[MonoTODOAttribute] // RVA: 0x474DD0 Offset: 0x474ED1 VA: 0x474DD0
internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 1153
{
	// Fields
	private static Hashtable s_sinks; // 0x0
	private static MethodInfo processMessageMethod; // 0x8
	private int _domainID; // 0x10

	// Properties
	internal int TargetDomainId { get; }

	// Methods

	// RVA: 0x37D62F0 Offset: 0x37D63F1 VA: 0x37D62F0
	internal void .ctor(int domainID) { }

	// RVA: 0x37D5FA0 Offset: 0x37D60A1 VA: 0x37D5FA0
	internal static CrossAppDomainSink GetSink(int domainID) { }

	// RVA: 0x37D6320 Offset: 0x37D6421 VA: 0x37D6320
	internal int get_TargetDomainId() { }

	// RVA: 0x37D6330 Offset: 0x37D6431 VA: 0x37D6330
	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	// RVA: 0x37D6470 Offset: 0x37D6571 VA: 0x37D6470 Slot: 6
	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	// RVA: 0x37D68F0 Offset: 0x37D69F1 VA: 0x37D68F0 Slot: 7
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	// RVA: 0x37D69D0 Offset: 0x37D6AD1 VA: 0x37D69D0
	public void SendAsyncMessage(object data) { }

	// RVA: 0x37D6AE0 Offset: 0x37D6BE1 VA: 0x37D6AE0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x47D2A0 Offset: 0x47D3A1 VA: 0x47D2A0
	// RVA: 0x37D6BF0 Offset: 0x37D6CF1 VA: 0x37D6BF0
	private void <AsyncProcessMessage>b__10_0(object data) { }
}

