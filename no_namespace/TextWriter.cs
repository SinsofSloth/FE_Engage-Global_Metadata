// Namespace: 
[Serializable]
private sealed class TextWriter.NullTextWriter : TextWriter // TypeDefIndex: 651
{
	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x1C07BE0 Offset: 0x1C07CE1 VA: 0x1C07BE0
	internal void .ctor() { }

	// RVA: 0x1C07C90 Offset: 0x1C07D91 VA: 0x1C07C90 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x1C07CA0 Offset: 0x1C07DA1 VA: 0x1C07CA0 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1C07CB0 Offset: 0x1C07DB1 VA: 0x1C07CB0 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x1C07CC0 Offset: 0x1C07DC1 VA: 0x1C07CC0 Slot: 16
	public override void WriteLine() { }

	// RVA: 0x1C07CD0 Offset: 0x1C07DD1 VA: 0x1C07CD0 Slot: 19
	public override void WriteLine(string value) { }
}

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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x472C10 Offset: 0x472D11 VA: 0x472C10
[Serializable]
private sealed class TextWriter.<>c // TypeDefIndex: 653
{
	// Fields
	public static readonly TextWriter.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1C07690 Offset: 0x1C07791 VA: 0x1C07690
	private static void .cctor() { }

	// RVA: 0x1C07700 Offset: 0x1C07801 VA: 0x1C07700
	public void .ctor() { }

	// RVA: 0x1C07710 Offset: 0x1C07811 VA: 0x1C07710
	internal void <.cctor>b__73_0(object state) { }

	// RVA: 0x1C077C0 Offset: 0x1C078C1 VA: 0x1C077C0
	internal void <.cctor>b__73_1(object state) { }

	// RVA: 0x1C07870 Offset: 0x1C07971 VA: 0x1C07870
	internal void <.cctor>b__73_2(object state) { }

	// RVA: 0x1C07930 Offset: 0x1C07A31 VA: 0x1C07930
	internal void <.cctor>b__73_3(object state) { }

	// RVA: 0x1C079E0 Offset: 0x1C07AE1 VA: 0x1C079E0
	internal void <.cctor>b__73_4(object state) { }

	// RVA: 0x1C07A90 Offset: 0x1C07B91 VA: 0x1C07A90
	internal void <.cctor>b__73_5(object state) { }

	// RVA: 0x1C07B50 Offset: 0x1C07C51 VA: 0x1C07B50
	internal void <.cctor>b__73_6(object state) { }
}

