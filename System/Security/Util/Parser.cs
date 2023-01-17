// Namespace: System.Security.Util
internal sealed class Parser // TypeDefIndex: 882
{
	// Fields
	private SecurityDocument _doc; // 0x10
	private Tokenizer _t; // 0x18

	// Methods

	// RVA: 0x381B560 Offset: 0x381B661 VA: 0x381B560
	internal SecurityElement GetTopElement() { }

	// RVA: 0x381B570 Offset: 0x381B671 VA: 0x381B570
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	// RVA: 0x381BB70 Offset: 0x381BC71 VA: 0x381BB70
	private int DetermineFormat(TokenizerStream stream) { }

	// RVA: 0x381BD40 Offset: 0x381BE41 VA: 0x381BD40
	private void ParseContents() { }

	// RVA: 0x381C050 Offset: 0x381C151 VA: 0x381C050
	private void .ctor(Tokenizer t) { }

	// RVA: 0x381C100 Offset: 0x381C201 VA: 0x381C100
	internal void .ctor(string input) { }
}

