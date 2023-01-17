// Namespace: System.ComponentModel
[DesignerCategoryAttribute] // RVA: 0x2FF70 Offset: 0x30071 VA: 0x2FF70
[ClassInterfaceAttribute] // RVA: 0x2FF70 Offset: 0x30071 VA: 0x2FF70
[ComVisibleAttribute] // RVA: 0x2FF70 Offset: 0x30071 VA: 0x2FF70
public class Component : MarshalByRefObject, IComponent, IDisposable // TypeDefIndex: 2295
{
	// Fields
	private static readonly object EventDisposed; // 0x0
	private ISite site; // 0x18
	private EventHandlerList events; // 0x20

	// Properties
	protected virtual bool CanRaiseEvents { get; }
	internal bool CanRaiseEventsInternal { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x34290 Offset: 0x34391 VA: 0x34290
	[BrowsableAttribute] // RVA: 0x34290 Offset: 0x34391 VA: 0x34290
	public virtual ISite Site { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x342D0 Offset: 0x343D1 VA: 0x342D0
	[BrowsableAttribute] // RVA: 0x342D0 Offset: 0x343D1 VA: 0x342D0
	protected bool DesignMode { get; }

	// Methods

	// RVA: 0x1B4A380 Offset: 0x1B4A481 VA: 0x1B4A380 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1B4A400 Offset: 0x1B4A501 VA: 0x1B4A400 Slot: 7
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x1B4A410 Offset: 0x1B4A511 VA: 0x1B4A410
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x1B4A420 Offset: 0x1B4A521 VA: 0x1B4A420 Slot: 8
	public virtual ISite get_Site() { }

	// RVA: 0x1B4A430 Offset: 0x1B4A531 VA: 0x1B4A430 Slot: 6
	public void Dispose() { }

	// RVA: 0x1B4A4B0 Offset: 0x1B4A5B1 VA: 0x1B4A4B0 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1B4A7C0 Offset: 0x1B4A8C1 VA: 0x1B4A7C0 Slot: 10
	protected virtual object GetService(Type service) { }

	// RVA: 0x1B4A890 Offset: 0x1B4A991 VA: 0x1B4A890
	protected bool get_DesignMode() { }

	// RVA: 0x1B4A950 Offset: 0x1B4AA51 VA: 0x1B4A950 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B4AA90 Offset: 0x1B4AB91 VA: 0x1B4AA90
	public void .ctor() { }

	// RVA: 0x1B4AAA0 Offset: 0x1B4ABA1 VA: 0x1B4AAA0
	private static void .cctor() { }
}

