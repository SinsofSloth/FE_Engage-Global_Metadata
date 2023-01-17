// Namespace: 
[Serializable]
internal sealed class TextWriter.SyncTextWriter : TextWriter, IDisposable // TypeDefIndex: 652
{
	// Fields
	private TextWriter _out; // 0x28

	// Properties
	public override Encoding Encoding { get; }
	public override IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x1C07CE0 Offset: 0x1C07DE1 VA: 0x1C07CE0
	internal void .ctor(TextWriter t) { }

	// RVA: 0x1C07D80 Offset: 0x1C07E81 VA: 0x1C07D80 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x1C07D90 Offset: 0x1C07E91 VA: 0x1C07D90 Slot: 7
	public override IFormatProvider get_FormatProvider() { }

	// RVA: 0x1C07DA0 Offset: 0x1C07EA1 VA: 0x1C07DA0 Slot: 8
	public override void Close() { }

	// RVA: 0x1C07DB0 Offset: 0x1C07EB1 VA: 0x1C07DB0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C07E70 Offset: 0x1C07F71 VA: 0x1C07E70 Slot: 10
	public override void Flush() { }

	// RVA: 0x1C07E80 Offset: 0x1C07F81 VA: 0x1C07E80 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x1C07E90 Offset: 0x1C07F91 VA: 0x1C07E90 Slot: 13
	public override void Write(char[] buffer) { }

	// RVA: 0x1C07EB0 Offset: 0x1C07FB1 VA: 0x1C07EB0 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1C07ED0 Offset: 0x1C07FD1 VA: 0x1C07ED0 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x1C07EF0 Offset: 0x1C07FF1 VA: 0x1C07EF0 Slot: 16
	public override void WriteLine() { }

	// RVA: 0x1C07F10 Offset: 0x1C08011 VA: 0x1C07F10 Slot: 17
	public override void WriteLine(char value) { }

	// RVA: 0x1C07F30 Offset: 0x1C08031 VA: 0x1C07F30 Slot: 18
	public override void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x1C07F50 Offset: 0x1C08051 VA: 0x1C07F50 Slot: 19
	public override void WriteLine(string value) { }

	// RVA: 0x1C07F70 Offset: 0x1C08071 VA: 0x1C07F70 Slot: 20
	public override void WriteLine(string format, object arg0) { }

	// RVA: 0x1C07F90 Offset: 0x1C08091 VA: 0x1C07F90 Slot: 21
	public override void WriteLine(string format, object arg0, object arg1) { }
}

