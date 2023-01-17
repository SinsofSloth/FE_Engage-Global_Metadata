// Namespace: NexPlugin
public struct NpDateTime // TypeDefIndex: 14861
{
	// Fields
	public short year; // 0x0
	public byte month; // 0x2
	public byte day; // 0x3
	public byte hour; // 0x4
	public byte minute; // 0x5
	public byte second; // 0x6
	private byte isNotNever; // 0x7
	public static readonly NpDateTime INVALID_DATE_TIME; // 0x0
	public static readonly NpDateTime Future; // 0x8
	public static readonly NpDateTime PERMANENT_DATE_TIME; // 0x10
	public static readonly NpDateTime Never; // 0x18

	// Methods

	// RVA: 0x235EA70 Offset: 0x235EB71 VA: 0x235EA70
	public void .ctor(DateTime dt) { }

	// RVA: 0x235EB00 Offset: 0x235EC01 VA: 0x235EB00
	public void .ctor(short srcYear, byte srcMonth, byte srcDay, byte srcHour, byte srcMinute, byte srcSecond) { }

	// RVA: 0x235EB30 Offset: 0x235EC31 VA: 0x235EB30
	public void .ctor(IntPtr src) { }

	// RVA: 0x235EBC0 Offset: 0x235ECC1 VA: 0x235EBC0
	public void .ctor(bool notnever) { }

	// RVA: 0x235EBE0 Offset: 0x235ECE1 VA: 0x235EBE0
	public void Trace() { }

	// RVA: 0x235EBF0 Offset: 0x235ECF1 VA: 0x235EBF0
	internal string ToString() { }

	// RVA: 0x235EE80 Offset: 0x235EF81 VA: 0x235EE80
	private static void .cctor() { }
}

