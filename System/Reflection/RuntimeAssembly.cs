// Namespace: System.Reflection
internal abstract class RuntimeAssembly : Assembly // TypeDefIndex: 570
{
	// Methods

	// RVA: 0x322B5F0 Offset: 0x322B6F1 VA: 0x322B5F0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322B680 Offset: 0x322B781 VA: 0x322B680
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x322B720 Offset: 0x322B821 VA: 0x322B720
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x322B7C0 Offset: 0x322B8C1 VA: 0x322B7C0 Slot: 18
	public override AssemblyName GetName(bool copiedName) { }

	// RVA: 0x322B7D0 Offset: 0x322B8D1 VA: 0x322B7D0
	protected void .ctor() { }
}

