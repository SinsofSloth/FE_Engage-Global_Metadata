// Namespace: MoonSharp.Interpreter.CoreLib.IO
internal abstract class FileUserDataBase : RefIdObject // TypeDefIndex: 6256
{
	// Methods

	// RVA: 0x330FEB0 Offset: 0x330FFB1 VA: 0x330FEB0
	public DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x33100D0 Offset: 0x33101D1 VA: 0x33100D0
	public DynValue read(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x3310960 Offset: 0x3310A61 VA: 0x3310960
	public DynValue write(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x3310C50 Offset: 0x3310D51 VA: 0x3310C50
	public DynValue close(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x33107A0 Offset: 0x33108A1 VA: 0x33107A0
	private Nullable<double> ReadNumber() { }

	// RVA: 0x33110A0 Offset: 0x33111A1 VA: 0x33110A0
	private bool IsNumericChar(char c, string numAsFar) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract bool Eof();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract string ReadLine();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract string ReadBuffer(int p);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract string ReadToEnd();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract char Peek();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Write(string value);

	// RVA: -1 Offset: -1 Slot: 10
	protected internal abstract bool isopen();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract string Close();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool flush();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract long seek(string whence, long offset);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool setvbuf(string mode);

	// RVA: 0x33112E0 Offset: 0x33113E1 VA: 0x33112E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x33113A0 Offset: 0x33114A1 VA: 0x33113A0
	protected void .ctor() { }
}

