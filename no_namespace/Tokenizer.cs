// Namespace: 
private enum Tokenizer.TokenSource // TypeDefIndex: 883
{
	// Fields
	public int value__; // 0x0
	public const Tokenizer.TokenSource UnicodeByteArray = 0;
	public const Tokenizer.TokenSource UTF8ByteArray = 1;
	public const Tokenizer.TokenSource ASCIIByteArray = 2;
	public const Tokenizer.TokenSource CharArray = 3;
	public const Tokenizer.TokenSource String = 4;
	public const Tokenizer.TokenSource NestedStrings = 5;
	public const Tokenizer.TokenSource Other = 6;
}

// Namespace: 
[Serializable]
internal sealed class Tokenizer.StringMaker // TypeDefIndex: 884
{
	// Fields
	private string[] aStrings; // 0x10
	private uint cStringsMax; // 0x18
	private uint cStringsUsed; // 0x1C
	public StringBuilder _outStringBuilder; // 0x20
	public char[] _outChars; // 0x28
	public int _outIndex; // 0x30

	// Methods

	// RVA: 0x1C0C970 Offset: 0x1C0CA71 VA: 0x1C0C970
	private static uint HashString(string str) { }

	// RVA: 0x1C0C9E0 Offset: 0x1C0CAE1 VA: 0x1C0C9E0
	private static uint HashCharArray(char[] a, int l) { }

	// RVA: 0x1C0CA40 Offset: 0x1C0CB41 VA: 0x1C0CA40
	public void .ctor() { }

	// RVA: 0x1C0CAF0 Offset: 0x1C0CBF1 VA: 0x1C0CAF0
	private bool CompareStringAndChars(string str, char[] a, int l) { }

	// RVA: 0x1C0CB90 Offset: 0x1C0CC91 VA: 0x1C0CB90
	public string MakeString() { }
}

// Namespace: 
internal interface Tokenizer.ITokenReader // TypeDefIndex: 885
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Read();
}

// Namespace: 
internal class Tokenizer.StreamTokenReader : Tokenizer.ITokenReader // TypeDefIndex: 886
{
	// Fields
	internal StreamReader _in; // 0x10
	internal int _numCharRead; // 0x18

	// Properties
	internal int NumCharEncountered { get; }

	// Methods

	// RVA: 0x1C0C8E0 Offset: 0x1C0C9E1 VA: 0x1C0C8E0
	internal void .ctor(StreamReader input) { }

	// RVA: 0x1C0C920 Offset: 0x1C0CA21 VA: 0x1C0C920 Slot: 5
	public virtual int Read() { }

	// RVA: 0x1C0C960 Offset: 0x1C0CA61 VA: 0x1C0C960
	internal int get_NumCharEncountered() { }
}

