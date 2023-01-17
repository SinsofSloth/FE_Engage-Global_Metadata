// Namespace: System.Linq.Expressions.Interpreter
internal sealed class PropertyByRefUpdater : ByRefUpdater // TypeDefIndex: 3091
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly PropertyInfo _property; // 0x30

	// Methods

	// RVA: 0x332D000 Offset: 0x332D101 VA: 0x332D000
	public void .ctor(Nullable<LocalDefinition> obj, PropertyInfo property, int argumentIndex) { }

	// RVA: 0x332D070 Offset: 0x332D171 VA: 0x332D070 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x332D1C0 Offset: 0x332D2C1 VA: 0x332D1C0 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

