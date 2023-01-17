// Namespace: System.Linq.Expressions.Interpreter
internal sealed class FieldByRefUpdater : ByRefUpdater // TypeDefIndex: 3090
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly FieldInfo _field; // 0x30

	// Methods

	// RVA: 0x31B3580 Offset: 0x31B3681 VA: 0x31B3580
	public void .ctor(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex) { }

	// RVA: 0x31B35F0 Offset: 0x31B36F1 VA: 0x31B35F0 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x31B3690 Offset: 0x31B3791 VA: 0x31B3690 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

