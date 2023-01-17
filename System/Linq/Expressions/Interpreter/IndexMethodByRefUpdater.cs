// Namespace: System.Linq.Expressions.Interpreter
internal sealed class IndexMethodByRefUpdater : ByRefUpdater // TypeDefIndex: 3092
{
	// Fields
	private readonly MethodInfo _indexer; // 0x18
	private readonly Nullable<LocalDefinition> _obj; // 0x20
	private readonly LocalDefinition[] _args; // 0x38

	// Methods

	// RVA: 0x31B5EF0 Offset: 0x31B5FF1 VA: 0x31B5EF0
	public void .ctor(Nullable<LocalDefinition> obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) { }

	// RVA: 0x31B5F70 Offset: 0x31B6071 VA: 0x31B5F70 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x31B61E0 Offset: 0x31B62E1 VA: 0x31B61E0 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

