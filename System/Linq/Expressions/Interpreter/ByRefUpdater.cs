// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ByRefUpdater // TypeDefIndex: 3087
{
	// Fields
	public readonly int ArgumentIndex; // 0x10

	// Methods

	// RVA: 0x2E4BF70 Offset: 0x2E4C071 VA: 0x2E4BF70
	public void .ctor(int argumentIndex) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update(InterpretedFrame frame, object value);

	// RVA: 0x2E53890 Offset: 0x2E53991 VA: 0x2E53890 Slot: 5
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

