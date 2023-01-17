// Namespace: MoonSharp.Interpreter.Tree
internal abstract class Statement : NodeBase // TypeDefIndex: 5998
{
	// Methods

	// RVA: 0x3013F80 Offset: 0x3014081 VA: 0x3013F80
	public void .ctor(ScriptLoadingContext lcontext) { }

	// RVA: 0x3026C00 Offset: 0x3026D01 VA: 0x3026C00
	protected static Statement CreateStatement(ScriptLoadingContext lcontext, out bool forceLast) { }

	// RVA: 0x3026FF0 Offset: 0x30270F1 VA: 0x3026FF0
	private static Statement DispatchForLoopStatement(ScriptLoadingContext lcontext) { }
}

