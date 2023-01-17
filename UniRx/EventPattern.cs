// Namespace: UniRx
public class EventPattern<TSender, TEventArgs> : IEquatable<EventPattern<TSender, TEventArgs>>, IEventPattern<TSender, TEventArgs> // TypeDefIndex: 6548
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13B10 Offset: 0x13C11 VA: 0x13B10
	private TSender <Sender>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13B20 Offset: 0x13C21 VA: 0x13B20
	private TEventArgs <EventArgs>k__BackingField; // 0x0

	// Properties
	public TSender Sender { get; set; }
	public TEventArgs EventArgs { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSender sender, TEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCB60 Offset: 0x33CCC61 VA: 0x33CCB60
	|-EventPattern<object, object>..ctor
	*/

	[CompilerGeneratedAttribute] // RVA: 0x15770 Offset: 0x15871 VA: 0x15770
	// RVA: -1 Offset: -1 Slot: 5
	public TSender get_Sender() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCBD0 Offset: 0x33CCCD1 VA: 0x33CCBD0
	|-EventPattern<object, object>.get_Sender
	*/

	[CompilerGeneratedAttribute] // RVA: 0x15780 Offset: 0x15881 VA: 0x15780
	// RVA: -1 Offset: -1
	private void set_Sender(TSender value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCBE0 Offset: 0x33CCCE1 VA: 0x33CCBE0
	|-EventPattern<object, object>.set_Sender
	*/

	[CompilerGeneratedAttribute] // RVA: 0x15790 Offset: 0x15891 VA: 0x15790
	// RVA: -1 Offset: -1 Slot: 6
	public TEventArgs get_EventArgs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCBF0 Offset: 0x33CCCF1 VA: 0x33CCBF0
	|-EventPattern<object, object>.get_EventArgs
	*/

	[CompilerGeneratedAttribute] // RVA: 0x157A0 Offset: 0x158A1 VA: 0x157A0
	// RVA: -1 Offset: -1
	private void set_EventArgs(TEventArgs value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCC00 Offset: 0x33CCD01 VA: 0x33CCC00
	|-EventPattern<object, object>.set_EventArgs
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(EventPattern<TSender, TEventArgs> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCC10 Offset: 0x33CCD11 VA: 0x33CCC10
	|-EventPattern<object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCD40 Offset: 0x33CCE41 VA: 0x33CCD40
	|-EventPattern<object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCDC0 Offset: 0x33CCEC1 VA: 0x33CCDC0
	|-EventPattern<object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(EventPattern<TSender, TEventArgs> first, EventPattern<TSender, TEventArgs> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCE80 Offset: 0x33CCF81 VA: 0x33CCE80
	|-EventPattern<object, object>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(EventPattern<TSender, TEventArgs> first, EventPattern<TSender, TEventArgs> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCE90 Offset: 0x33CCF91 VA: 0x33CCE90
	|-EventPattern<object, object>.op_Inequality
	*/
}

