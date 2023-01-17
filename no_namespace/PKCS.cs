// Namespace: 
public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 1575
{
	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x1C566C0 Offset: 0x1C567C1 VA: 0x1C566C0
	public void .ctor() { }

	// RVA: 0x1C566D0 Offset: 0x1C567D1 VA: 0x1C566D0
	public void .ctor(byte[] data) { }

	// RVA: 0x1C569A0 Offset: 0x1C56AA1 VA: 0x1C569A0
	public string get_Algorithm() { }

	// RVA: 0x1C569B0 Offset: 0x1C56AB1 VA: 0x1C569B0
	public byte[] get_EncryptedData() { }

	// RVA: 0x1C56A30 Offset: 0x1C56B31 VA: 0x1C56A30
	public byte[] get_Salt() { }

	// RVA: 0x1C56B10 Offset: 0x1C56C11 VA: 0x1C56B10
	public int get_IterationCount() { }

	// RVA: 0x1C56700 Offset: 0x1C56801 VA: 0x1C56700
	private void Decode(byte[] data) { }
}

