// Namespace: 
[Serializable]
private sealed class TextReader.NullTextReader : TextReader // TypeDefIndex: 647
{
	// Methods

	// RVA: 0x1C07430 Offset: 0x1C07531 VA: 0x1C07430
	public void .ctor() { }

	// RVA: 0x1C074A0 Offset: 0x1C075A1 VA: 0x1C074A0 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x1C074B0 Offset: 0x1C075B1 VA: 0x1C074B0 Slot: 14
	public override string ReadLine() { }
}

// Namespace: 
[Serializable]
internal sealed class TextReader.SyncTextReader : TextReader // TypeDefIndex: 648
{
	// Fields
	internal TextReader _in; // 0x18

	// Methods

	// RVA: 0x1C074C0 Offset: 0x1C075C1 VA: 0x1C074C0
	internal void .ctor(TextReader t) { }

	// RVA: 0x1C07540 Offset: 0x1C07641 VA: 0x1C07540 Slot: 7
	public override void Close() { }

	// RVA: 0x1C07550 Offset: 0x1C07651 VA: 0x1C07550 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C07610 Offset: 0x1C07711 VA: 0x1C07610 Slot: 9
	public override int Peek() { }

	// RVA: 0x1C07620 Offset: 0x1C07721 VA: 0x1C07620 Slot: 10
	public override int Read() { }

	// RVA: 0x1C07630 Offset: 0x1C07731 VA: 0x1C07630 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x1C07640 Offset: 0x1C07741 VA: 0x1C07640 Slot: 13
	public override int ReadBlock([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x1C07660 Offset: 0x1C07761 VA: 0x1C07660 Slot: 14
	public override string ReadLine() { }

	// RVA: 0x1C07680 Offset: 0x1C07781 VA: 0x1C07680 Slot: 12
	public override string ReadToEnd() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x472BE0 Offset: 0x472CE1 VA: 0x472BE0
[Serializable]
private sealed class TextReader.<>c // TypeDefIndex: 649
{
	// Fields
	public static readonly TextReader.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1C07260 Offset: 0x1C07361 VA: 0x1C07260
	private static void .cctor() { }

	// RVA: 0x1C072D0 Offset: 0x1C073D1 VA: 0x1C072D0
	public void .ctor() { }

	// RVA: 0x1C072E0 Offset: 0x1C073E1 VA: 0x1C072E0
	internal string <.cctor>b__22_0(object state) { }

	// RVA: 0x1C07370 Offset: 0x1C07471 VA: 0x1C07370
	internal int <.cctor>b__22_1(object state) { }
}

