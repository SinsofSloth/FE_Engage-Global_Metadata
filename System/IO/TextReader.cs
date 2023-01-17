// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472BC0 Offset: 0x472CC1 VA: 0x472BC0
[Serializable]
public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 650
{
	// Fields
	private static Func<object, string> _ReadLineDelegate; // 0x0
	private static Func<object, int> _ReadDelegate; // 0x8
	public static readonly TextReader Null; // 0x10

	// Methods

	// RVA: 0x1B11C10 Offset: 0x1B11D11 VA: 0x1B11C10
	protected void .ctor() { }

	// RVA: 0x1B11C20 Offset: 0x1B11D21 VA: 0x1B11C20 Slot: 7
	public virtual void Close() { }

	// RVA: 0x1B11CA0 Offset: 0x1B11DA1 VA: 0x1B11CA0 Slot: 6
	public void Dispose() { }

	// RVA: 0x1B11D20 Offset: 0x1B11E21 VA: 0x1B11D20 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1B11D30 Offset: 0x1B11E31 VA: 0x1B11D30 Slot: 9
	public virtual int Peek() { }

	// RVA: 0x1B11D40 Offset: 0x1B11E41 VA: 0x1B11D40 Slot: 10
	public virtual int Read() { }

	// RVA: 0x1B11D50 Offset: 0x1B11E51 VA: 0x1B11D50 Slot: 11
	public virtual int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x1B11F30 Offset: 0x1B12031 VA: 0x1B11F30 Slot: 12
	public virtual string ReadToEnd() { }

	// RVA: 0x1B12020 Offset: 0x1B12121 VA: 0x1B12020 Slot: 13
	public virtual int ReadBlock([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x1B12090 Offset: 0x1B12191 VA: 0x1B12090 Slot: 14
	public virtual string ReadLine() { }

	// RVA: 0x1B12190 Offset: 0x1B12291 VA: 0x1B12190
	public static TextReader Synchronized(TextReader reader) { }

	// RVA: 0x1B12250 Offset: 0x1B12351 VA: 0x1B12250
	private static void .cctor() { }
}

