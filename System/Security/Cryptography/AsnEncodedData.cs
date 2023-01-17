// Namespace: System.Security.Cryptography
public class AsnEncodedData // TypeDefIndex: 2346
{
	// Fields
	internal Oid _oid; // 0x10
	internal byte[] _raw; // 0x18

	// Properties
	public Oid Oid { set; }
	public byte[] RawData { get; set; }

	// Methods

	// RVA: 0x1B3CB20 Offset: 0x1B3CC21 VA: 0x1B3CB20
	protected void .ctor() { }

	// RVA: 0x1B3CB30 Offset: 0x1B3CC31 VA: 0x1B3CB30
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x1B3CBD0 Offset: 0x1B3CCD1 VA: 0x1B3CBD0
	public void set_Oid(Oid value) { }

	// RVA: 0x1B3CD50 Offset: 0x1B3CE51 VA: 0x1B3CD50
	public byte[] get_RawData() { }

	// RVA: 0x1B3CC70 Offset: 0x1B3CD71 VA: 0x1B3CC70
	public void set_RawData(byte[] value) { }

	// RVA: 0x1B3CD60 Offset: 0x1B3CE61 VA: 0x1B3CD60 Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1B3CEB0 Offset: 0x1B3CFB1 VA: 0x1B3CEB0 Slot: 5
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x1B3DDC0 Offset: 0x1B3DEC1 VA: 0x1B3DDC0
	internal string Default(bool multiLine) { }

	// RVA: 0x1B3D080 Offset: 0x1B3D181 VA: 0x1B3D080
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x1B3D1A0 Offset: 0x1B3D2A1 VA: 0x1B3D1A0
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x1B3D2C0 Offset: 0x1B3D3C1 VA: 0x1B3D2C0
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x1B3D3E0 Offset: 0x1B3D4E1 VA: 0x1B3D3E0
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x1B3D500 Offset: 0x1B3D601 VA: 0x1B3D500
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x1B3D9F0 Offset: 0x1B3DAF1 VA: 0x1B3D9F0
	internal string NetscapeCertType(bool multiLine) { }
}

