// Namespace: System.Reflection
internal struct MonoEventInfo // TypeDefIndex: 572
{
	// Fields
	public Type declaring_type; // 0x0
	public Type reflected_type; // 0x8
	public string name; // 0x10
	public MethodInfo add_method; // 0x18
	public MethodInfo remove_method; // 0x20
	public MethodInfo raise_method; // 0x28
	public EventAttributes attrs; // 0x30
	public MethodInfo[] other_methods; // 0x38

	// Methods

	// RVA: 0x34F71F0 Offset: 0x34F72F1 VA: 0x34F71F0
	private static void get_event_info(MonoEvent ev, out MonoEventInfo info) { }

	// RVA: 0x34F6D00 Offset: 0x34F6E01 VA: 0x34F6D00
	internal static MonoEventInfo GetEventInfo(MonoEvent ev) { }
}

