// Namespace: System.Runtime.Remoting.Contexts
[ComVisibleAttribute] // RVA: 0x474C90 Offset: 0x474D91 VA: 0x474C90
public interface IContextAttribute // TypeDefIndex: 1140
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetPropertiesForNewContext(IConstructionCallMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsContextOK(Context ctx, IConstructionCallMessage msg);
}

