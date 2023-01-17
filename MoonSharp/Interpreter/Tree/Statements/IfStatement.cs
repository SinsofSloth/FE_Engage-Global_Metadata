// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class IfStatement : Statement // TypeDefIndex: 6012
{
	// Fields
	private List<IfStatement.IfBlock> m_Ifs; // 0x20
	private IfStatement.IfBlock m_Else; // 0x28
	private SourceRef m_End; // 0x30

	// Methods

	// RVA: 0x33167A0 Offset: 0x33168A1 VA: 0x33167A0
	public void .ctor(ScriptLoadingContext lcontext) { }

	// RVA: 0x3316A00 Offset: 0x3316B01 VA: 0x3316A00
	private IfStatement.IfBlock CreateIfBlock(ScriptLoadingContext lcontext) { }

	// RVA: 0x3316B70 Offset: 0x3316C71 VA: 0x3316B70
	private IfStatement.IfBlock CreateElseBlock(ScriptLoadingContext lcontext) { }

	// RVA: 0x3316CA0 Offset: 0x3316DA1 VA: 0x3316CA0 Slot: 4
	public override void Compile(ByteCode bc) { }
}

