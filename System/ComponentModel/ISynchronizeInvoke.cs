// Namespace: System.ComponentModel
public interface ISynchronizeInvoke // TypeDefIndex: 2318
{
	// Properties
	public abstract bool InvokeRequired { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_InvokeRequired();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IAsyncResult BeginInvoke(Delegate method, object[] args);
}

