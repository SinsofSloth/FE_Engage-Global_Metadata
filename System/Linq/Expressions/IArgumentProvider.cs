// Namespace: System.Linq.Expressions
public interface IArgumentProvider // TypeDefIndex: 2820
{
	// Properties
	public abstract int ArgumentCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Expression GetArgument(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ArgumentCount();
}

