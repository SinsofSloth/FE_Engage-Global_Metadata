// Namespace: Nintendo.MessageStudio.Lib
public abstract class TagProcessorBase // TypeDefIndex: 15049
{
	// Fields
	private const char ShiftIn = '\xf';
	private const char ShiftOut = '\xe';

	// Methods

	// RVA: 0x2932820 Offset: 0x2932921 VA: 0x2932820
	public void Process(IntPtr p) { }

	// RVA: 0x2932B40 Offset: 0x2932C41 VA: 0x2932B40
	private void ProcessTag(ushort group, ushort tag, byte[] param) { }

	// RVA: 0x2932C00 Offset: 0x2932D01 VA: 0x2932C00
	private void ProcessSystemTag(ushort tag, byte[] param) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void ProcessChar(char c);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void ProcessRubyTag(RubyTagInfo rubyTagInfo);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void ProcessFontTag(FontTagInfo fontTagInfo);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void ProcessSizeTag(SizeTagInfo sizeTagInfo);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void ProcessColorTag(ColorTagInfo colorTagInfo);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void ProcessPageBreakTag(PageBreakTagInfo pageBreakTagInfo);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void ProcessCustomTag(CustomTagInfo tagInfo);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void ProcessEnd();

	// RVA: 0x2932A70 Offset: 0x2932B71 VA: 0x2932A70
	private char ReadChar(IntPtr p, int offset) { }

	// RVA: 0x2932E00 Offset: 0x2932F01 VA: 0x2932E00
	protected void .ctor() { }
}

