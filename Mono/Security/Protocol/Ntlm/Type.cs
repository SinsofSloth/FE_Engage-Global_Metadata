// Namespace: Mono.Security.Protocol.Ntlm
public class Type2Message : MessageBase // TypeDefIndex: 1549
{
	// Fields
	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	// Properties
	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }

	// Methods

	// RVA: 0x1BD8920 Offset: 0x1BD8A21 VA: 0x1BD8920
	public void .ctor(byte[] message) { }

	// RVA: 0x1BD89E0 Offset: 0x1BD8AE1 VA: 0x1BD89E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1BC9C40 Offset: 0x1BC9D41 VA: 0x1BC9C40
	public byte[] get_Nonce() { }

	// RVA: 0x1BD8A60 Offset: 0x1BD8B61 VA: 0x1BD8A60
	public string get_TargetName() { }

	// RVA: 0x1BC9BC0 Offset: 0x1BC9CC1 VA: 0x1BC9BC0
	public byte[] get_TargetInfo() { }

	// RVA: 0x1BD8A70 Offset: 0x1BD8B71 VA: 0x1BD8A70 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1BD8C00 Offset: 0x1BD8D01 VA: 0x1BD8C00 Slot: 5
	public override byte[] GetBytes() { }
}

