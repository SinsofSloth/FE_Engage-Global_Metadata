// Namespace: UnityEngine.ResourceManagement.Exceptions
public class RemoteProviderException : ProviderException // TypeDefIndex: 5553
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x72600 Offset: 0x72701 VA: 0x72600
	private readonly UnityWebRequestResult <WebRequestResult>k__BackingField; // 0x90

	// Properties
	public UnityWebRequestResult WebRequestResult { get; }

	// Methods

	// RVA: 0x3625F70 Offset: 0x3626071 VA: 0x3625F70
	public void .ctor(string message, IResourceLocation location, UnityWebRequestResult uwrResult, Exception innerException) { }

	[CompilerGeneratedAttribute] // RVA: 0x72DE0 Offset: 0x72EE1 VA: 0x72DE0
	// RVA: 0x3630DB0 Offset: 0x3630EB1 VA: 0x3630DB0
	public UnityWebRequestResult get_WebRequestResult() { }

	// RVA: 0x3630DC0 Offset: 0x3630EC1 VA: 0x3630DC0 Slot: 3
	public override string ToString() { }
}

