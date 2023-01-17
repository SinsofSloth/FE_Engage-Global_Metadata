// Namespace: UniRx
internal interface ICustomYieldInstructionErrorHandler // TypeDefIndex: 6702
{
	// Properties
	public abstract bool HasError { get; }
	public abstract Exception Error { get; }
	public abstract bool IsReThrowOnError { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_HasError();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Exception get_Error();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsReThrowOnError();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ForceDisableRethrowOnError();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ForceEnableRethrowOnError();
}

