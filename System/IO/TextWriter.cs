// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472BF0 Offset: 0x472CF1 VA: 0x472BF0
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 654
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	// Properties
	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }
	public abstract Encoding Encoding { get; }

	// Methods

	// RVA: 0x1B12410 Offset: 0x1B12511 VA: 0x1B12410
	private static string get_InitialNewLine() { }

	// RVA: 0x1B12420 Offset: 0x1B12521 VA: 0x1B12420
	protected void .ctor() { }

	// RVA: 0x1B124C0 Offset: 0x1B125C1 VA: 0x1B124C0
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x1B12560 Offset: 0x1B12661 VA: 0x1B12560 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x1B12660 Offset: 0x1B12761 VA: 0x1B12660 Slot: 8
	public virtual void Close() { }

	// RVA: 0x1B126E0 Offset: 0x1B127E1 VA: 0x1B126E0 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1B126F0 Offset: 0x1B127F1 VA: 0x1B126F0 Slot: 6
	public void Dispose() { }

	// RVA: 0x1B12770 Offset: 0x1B12871 VA: 0x1B12770 Slot: 10
	public virtual void Flush() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Encoding get_Encoding();

	// RVA: 0x1B12780 Offset: 0x1B12881 VA: 0x1B12780
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x1B12840 Offset: 0x1B12941 VA: 0x1B12840 Slot: 12
	public virtual void Write(char value) { }

	// RVA: 0x1B12850 Offset: 0x1B12951 VA: 0x1B12850 Slot: 13
	public virtual void Write(char[] buffer) { }

	// RVA: 0x1B12870 Offset: 0x1B12971 VA: 0x1B12870 Slot: 14
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1B12A50 Offset: 0x1B12B51 VA: 0x1B12A50 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x1B12AA0 Offset: 0x1B12BA1 VA: 0x1B12AA0 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x1B12AC0 Offset: 0x1B12BC1 VA: 0x1B12AC0 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x1B12B00 Offset: 0x1B12C01 VA: 0x1B12B00 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x1B12B40 Offset: 0x1B12C41 VA: 0x1B12B40 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x1B12CE0 Offset: 0x1B12DE1 VA: 0x1B12CE0 Slot: 20
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x1B12D40 Offset: 0x1B12E41 VA: 0x1B12D40 Slot: 21
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x1B12DB0 Offset: 0x1B12EB1 VA: 0x1B12DB0
	private static void .cctor() { }
}

