// Namespace: Mono.Security.Protocol.Ntlm
[ObsoleteAttribute] // RVA: 0x85930 Offset: 0x85A31 VA: 0x85930
public class ChallengeResponse : IDisposable // TypeDefIndex: 1542
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x1BC79E0 Offset: 0x1BC7AE1 VA: 0x1BC79E0
	public void .ctor() { }

	// RVA: 0x1BC7A80 Offset: 0x1BC7B81 VA: 0x1BC7A80
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1BC80A0 Offset: 0x1BC81A1 VA: 0x1BC80A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1BC7B40 Offset: 0x1BC7C41 VA: 0x1BC7B40
	public void set_Password(string value) { }

	// RVA: 0x1BC7F80 Offset: 0x1BC8081 VA: 0x1BC7F80
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1BC83B0 Offset: 0x1BC84B1 VA: 0x1BC83B0
	public byte[] get_LM() { }

	// RVA: 0x1BC8700 Offset: 0x1BC8801 VA: 0x1BC8700
	public byte[] get_NT() { }

	// RVA: 0x1BC8120 Offset: 0x1BC8221 VA: 0x1BC8120 Slot: 4
	public void Dispose() { }

	// RVA: 0x1BC8770 Offset: 0x1BC8871 VA: 0x1BC8770
	private void Dispose(bool disposing) { }

	// RVA: 0x1BC8420 Offset: 0x1BC8521 VA: 0x1BC8420
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1BC87F0 Offset: 0x1BC88F1 VA: 0x1BC87F0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1BC8200 Offset: 0x1BC8301 VA: 0x1BC8200
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1BC89F0 Offset: 0x1BC8AF1 VA: 0x1BC89F0
	private static void .cctor() { }
}

