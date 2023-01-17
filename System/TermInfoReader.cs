// Namespace: System
internal class TermInfoReader // TypeDefIndex: 401
{
	// Fields
	private int boolSize; // 0x10
	private int numSize; // 0x14
	private int strOffsets; // 0x18
	private byte[] buffer; // 0x20
	private int booleansOffset; // 0x28
	private int intOffset; // 0x2C

	// Methods

	// RVA: 0x1B0EDA0 Offset: 0x1B0EEA1 VA: 0x1B0EDA0
	public void .ctor(string term, string filename) { }

	// RVA: 0x1B0F2D0 Offset: 0x1B0F3D1 VA: 0x1B0F2D0
	public void .ctor(string term, byte[] buffer) { }

	// RVA: 0x1B0F3F0 Offset: 0x1B0F4F1 VA: 0x1B0F3F0
	private void DetermineVersion(short magic) { }

	// RVA: 0x1B0F080 Offset: 0x1B0F181 VA: 0x1B0F080
	private void ReadHeader(byte[] buffer, ref int position) { }

	// RVA: 0x1B0F230 Offset: 0x1B0F331 VA: 0x1B0F230
	private void ReadNames(byte[] buffer, ref int position) { }

	// RVA: 0x1B0F5A0 Offset: 0x1B0F6A1 VA: 0x1B0F5A0
	public int Get(TermInfoNumbers number) { }

	// RVA: 0x1B0F6D0 Offset: 0x1B0F7D1 VA: 0x1B0F6D0
	public string Get(TermInfoStrings tstr) { }

	// RVA: 0x1B0F810 Offset: 0x1B0F911 VA: 0x1B0F810
	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	// RVA: 0x1B0F4B0 Offset: 0x1B0F5B1 VA: 0x1B0F4B0
	private short GetInt16(byte[] buffer, int offset) { }

	// RVA: 0x1B0FA60 Offset: 0x1B0FB61 VA: 0x1B0FA60
	private int GetInt32(byte[] buffer, int offset) { }

	// RVA: 0x1B0F660 Offset: 0x1B0F761 VA: 0x1B0F660
	private int GetInteger(byte[] buffer, int offset) { }

	// RVA: 0x1B0F510 Offset: 0x1B0F611 VA: 0x1B0F510
	private string GetString(byte[] buffer, int offset) { }

	// RVA: 0x1B0F9A0 Offset: 0x1B0FAA1 VA: 0x1B0F9A0
	private byte[] GetStringBytes(byte[] buffer, int offset) { }
}

