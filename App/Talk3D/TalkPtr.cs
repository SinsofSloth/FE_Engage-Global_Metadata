// Namespace: App.Talk3D
public class TalkPtr // TypeDefIndex: 14133
{
	// Fields
	public const int CharSize = 2;
	public const int GroupSize = 2;
	[CompilerGeneratedAttribute] // RVA: 0x29DA80 Offset: 0x29DB81 VA: 0x29DA80
	private IntPtr <OriginalPtr>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29DA90 Offset: 0x29DB91 VA: 0x29DA90
	private IntPtr <NowPtr>k__BackingField; // 0x18

	// Properties
	public IntPtr OriginalPtr { get; set; }
	public IntPtr NowPtr { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CDDC0 Offset: 0x2CDEC1 VA: 0x2CDDC0
	// RVA: 0x2C2F9F0 Offset: 0x2C2FAF1 VA: 0x2C2F9F0
	public IntPtr get_OriginalPtr() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDDD0 Offset: 0x2CDED1 VA: 0x2CDDD0
	// RVA: 0x2C2FA00 Offset: 0x2C2FB01 VA: 0x2C2FA00
	private void set_OriginalPtr(IntPtr value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDDE0 Offset: 0x2CDEE1 VA: 0x2CDDE0
	// RVA: 0x2C2FA10 Offset: 0x2C2FB11 VA: 0x2C2FA10
	public IntPtr get_NowPtr() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDDF0 Offset: 0x2CDEF1 VA: 0x2CDDF0
	// RVA: 0x2C2FA20 Offset: 0x2C2FB21 VA: 0x2C2FA20
	private void set_NowPtr(IntPtr value) { }

	// RVA: 0x2C28520 Offset: 0x2C28621 VA: 0x2C28520
	public void .ctor(IntPtr ptr) { }

	// RVA: 0x2C2FA30 Offset: 0x2C2FB31 VA: 0x2C2FA30
	public void .ctor(string mid) { }

	// RVA: 0x2C2FA80 Offset: 0x2C2FB81 VA: 0x2C2FA80
	public void ResetPosition() { }

	// RVA: 0x2C2FAE0 Offset: 0x2C2FBE1 VA: 0x2C2FAE0
	public void Forward(int size) { }

	// RVA: 0x2C2FB40 Offset: 0x2C2FC41 VA: 0x2C2FB40
	public Mess.TagGroup ReadTagGroup() { }

	// RVA: 0x2C2FC00 Offset: 0x2C2FD01 VA: 0x2C2FC00
	public int ReadInt32() { }

	// RVA: 0x2C2FCC0 Offset: 0x2C2FDC1 VA: 0x2C2FCC0
	public int ReadInt16() { }

	// RVA: 0x2C2FD80 Offset: 0x2C2FE81 VA: 0x2C2FD80
	public int ReadByte() { }

	// RVA: 0x2C2FE40 Offset: 0x2C2FF41 VA: 0x2C2FE40
	public char ReadChar() { }

	// RVA: 0x2C2FF50 Offset: 0x2C30051 VA: 0x2C2FF50
	public string ReadStringParam() { }

	// RVA: 0x2C30020 Offset: 0x2C30121 VA: 0x2C30020
	public string ReadPID() { }

	// RVA: 0x2C30030 Offset: 0x2C30131 VA: 0x2C30030
	public void WriteShiftIn() { }

	// RVA: 0x2C300E0 Offset: 0x2C301E1 VA: 0x2C300E0
	public void WriteShiftOut() { }

	// RVA: 0x2C30190 Offset: 0x2C30291 VA: 0x2C30190
	public void WriteTagGroup(Mess.TagGroup group) { }

	// RVA: 0x2C301A0 Offset: 0x2C302A1 VA: 0x2C301A0
	public void WriteInt16(short value) { }

	// RVA: 0x2C30260 Offset: 0x2C30361 VA: 0x2C30260
	public void WriteInt16(int value) { }

	// RVA: 0x2C30270 Offset: 0x2C30371 VA: 0x2C30270
	public void WriteString(string str) { }

	// RVA: 0x2C30370 Offset: 0x2C30471 VA: 0x2C30370
	public bool IsNull() { }
}

