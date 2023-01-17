// Namespace: MoonSharp.Interpreter.Tree
internal abstract class Expression : NodeBase // TypeDefIndex: 5989
{
	// Methods

	// RVA: 0x3305370 Offset: 0x3305471 VA: 0x3305370
	public void .ctor(ScriptLoadingContext lcontext) { }

	// RVA: 0x330BCF0 Offset: 0x330BDF1 VA: 0x330BCF0 Slot: 5
	public virtual string GetFriendlyDebugName() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract DynValue Eval(ScriptExecutionContext context);

	// RVA: 0x330BD00 Offset: 0x330BE01 VA: 0x330BD00 Slot: 7
	public virtual SymbolRef FindDynamic(ScriptExecutionContext context) { }

	// RVA: 0x330BD10 Offset: 0x330BE11 VA: 0x330BD10
	internal static List<Expression> ExprListAfterFirstExpr(ScriptLoadingContext lcontext, Expression expr1) { }

	// RVA: 0x330BF30 Offset: 0x330C031 VA: 0x330BF30
	internal static List<Expression> ExprList(ScriptLoadingContext lcontext) { }

	// RVA: 0x330BEB0 Offset: 0x330BFB1 VA: 0x330BEB0
	internal static Expression Expr(ScriptLoadingContext lcontext) { }

	// RVA: 0x330C070 Offset: 0x330C171 VA: 0x330C070
	internal static Expression SubExpr(ScriptLoadingContext lcontext, bool isPrimary) { }

	// RVA: 0x330C540 Offset: 0x330C641 VA: 0x330C540
	internal static Expression SimpleExp(ScriptLoadingContext lcontext) { }

	// RVA: 0x330C7A0 Offset: 0x330C8A1 VA: 0x330C7A0
	internal static Expression PrimaryExp(ScriptLoadingContext lcontext) { }

	// RVA: 0x330CB60 Offset: 0x330CC61 VA: 0x330CB60
	private static Expression PrefixExp(ScriptLoadingContext lcontext) { }
}

