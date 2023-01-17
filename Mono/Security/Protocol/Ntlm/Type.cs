// Namespace: Mono.Security.Protocol.Ntlm
public class Type1Message : MessageBase // TypeDefIndex: 1548
{
	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x1BD8410 Offset: 0x1BD8511 VA: 0x1BD8410
	public void .ctor() { }

	// RVA: 0x1BD84C0 Offset: 0x1BD85C1 VA: 0x1BD84C0
	public void set_Domain(string value) { }

	// RVA: 0x1BD8550 Offset: 0x1BD8651 VA: 0x1BD8550
	public void set_Host(string value) { }

	// RVA: 0x1BD85E0 Offset: 0x1BD86E1 VA: 0x1BD85E0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1BD86E0 Offset: 0x1BD87E1 VA: 0x1BD86E0 Slot: 5
	public override byte[] GetBytes() { }
}

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

// Namespace: Mono.Security.Protocol.Ntlm
public class Type3Message : MessageBase // TypeDefIndex: 1550
{
	// Fields
	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	// Properties
	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }

	// Methods

	// RVA: 0x1BD8CC0 Offset: 0x1BD8DC1 VA: 0x1BD8CC0
	public void .ctor(Type2Message type2) { }

	// RVA: 0x1BD8FB0 Offset: 0x1BD90B1 VA: 0x1BD8FB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1BD9070 Offset: 0x1BD9171 VA: 0x1BD9070
	public void set_Domain(string value) { }

	// RVA: 0x1BD9100 Offset: 0x1BD9201 VA: 0x1BD9100
	public void set_Password(string value) { }

	// RVA: 0x1BD9110 Offset: 0x1BD9211 VA: 0x1BD9110
	public void set_Username(string value) { }

	// RVA: 0x1BD9120 Offset: 0x1BD9221 VA: 0x1BD9120 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1BD9420 Offset: 0x1BD9521 VA: 0x1BD9420
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1BD9480 Offset: 0x1BD9581 VA: 0x1BD9480
	private byte[] EncodeString(string text) { }

	// RVA: 0x1BD9520 Offset: 0x1BD9621 VA: 0x1BD9520 Slot: 5
	public override byte[] GetBytes() { }
}

