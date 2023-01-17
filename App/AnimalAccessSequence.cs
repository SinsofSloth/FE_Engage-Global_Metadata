// Namespace: App
internal class AnimalAccessSequence : SingletonProcInst<AnimalAccessSequence> // TypeDefIndex: 10429
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28E030 Offset: 0x28E131 VA: 0x28E030
	private HubAccess <Access>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x28E040 Offset: 0x28E141 VA: 0x28E040
	private AnimalData <Animal>k__BackingField; // 0x80
	private AnimalAccessCamera m_AnimalCamera; // 0x88

	// Properties
	public HubAccess Access { get; set; }
	public AnimalData Animal { get; set; }
	public HubPlayerController Player { get; }
	public HubCamera Camera { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BDF70 Offset: 0x2BE071 VA: 0x2BDF70
	// RVA: 0x20F4CB0 Offset: 0x20F4DB1 VA: 0x20F4CB0
	public HubAccess get_Access() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDF80 Offset: 0x2BE081 VA: 0x2BDF80
	// RVA: 0x20F4CC0 Offset: 0x20F4DC1 VA: 0x20F4CC0
	public void set_Access(HubAccess value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDF90 Offset: 0x2BE091 VA: 0x2BDF90
	// RVA: 0x20F4CD0 Offset: 0x20F4DD1 VA: 0x20F4CD0
	public AnimalData get_Animal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDFA0 Offset: 0x2BE0A1 VA: 0x2BDFA0
	// RVA: 0x20F4CE0 Offset: 0x20F4DE1 VA: 0x20F4CE0
	public void set_Animal(AnimalData value) { }

	// RVA: 0x20F4CF0 Offset: 0x20F4DF1 VA: 0x20F4CF0
	public HubPlayerController get_Player() { }

	// RVA: 0x20F4D70 Offset: 0x20F4E71 VA: 0x20F4D70
	public HubCamera get_Camera() { }

	// RVA: 0x20F4DF0 Offset: 0x20F4EF1 VA: 0x20F4DF0
	public void .ctor(HubAccess access) { }

	// RVA: 0x20F4FE0 Offset: 0x20F50E1 VA: 0x20F4FE0
	private void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BDFB0 Offset: 0x2BE0B1 VA: 0x2BDFB0
	// RVA: 0x20F53F0 Offset: 0x20F54F1 VA: 0x20F53F0
	private IEnumerator Main() { }

	// RVA: 0x20F5470 Offset: 0x20F5571 VA: 0x20F5470
	private void End() { }

	// RVA: 0x20F5790 Offset: 0x20F5891 VA: 0x20F5790
	public static ProcInst CreateBind(ProcInst super, HubAccess access) { }
}

