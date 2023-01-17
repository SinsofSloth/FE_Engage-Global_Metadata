// Namespace: App
internal class AnimalCatchSequence : SingletonProcInst<AnimalCatchSequence> // TypeDefIndex: 10435
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28E050 Offset: 0x28E151 VA: 0x28E050
	private HubAccess <Access>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x28E060 Offset: 0x28E161 VA: 0x28E060
	private AnimalData <Animal>k__BackingField; // 0x80

	// Properties
	public HubAccess Access { get; set; }
	public AnimalData Animal { get; set; }
	public HubPlayerController Player { get; }
	public HubCamera Camera { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BE070 Offset: 0x2BE171 VA: 0x2BE070
	// RVA: 0x20F5D90 Offset: 0x20F5E91 VA: 0x20F5D90
	public HubAccess get_Access() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE080 Offset: 0x2BE181 VA: 0x2BE080
	// RVA: 0x20F5DA0 Offset: 0x20F5EA1 VA: 0x20F5DA0
	public void set_Access(HubAccess value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE090 Offset: 0x2BE191 VA: 0x2BE090
	// RVA: 0x20F5DB0 Offset: 0x20F5EB1 VA: 0x20F5DB0
	public AnimalData get_Animal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE0A0 Offset: 0x2BE1A1 VA: 0x2BE0A0
	// RVA: 0x20F5DC0 Offset: 0x20F5EC1 VA: 0x20F5DC0
	public void set_Animal(AnimalData value) { }

	// RVA: 0x20F5DD0 Offset: 0x20F5ED1 VA: 0x20F5DD0
	public HubPlayerController get_Player() { }

	// RVA: 0x20F5E50 Offset: 0x20F5F51 VA: 0x20F5E50
	public HubCamera get_Camera() { }

	// RVA: 0x20F5ED0 Offset: 0x20F5FD1 VA: 0x20F5ED0
	public void .ctor(HubAccess access) { }

	// RVA: 0x20F5F90 Offset: 0x20F6091 VA: 0x20F5F90
	private void Init() { }

	// RVA: 0x20F6030 Offset: 0x20F6131 VA: 0x20F6030
	private void Exit() { }

	// RVA: 0x20F60C0 Offset: 0x20F61C1 VA: 0x20F60C0
	private void StartCapture() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BE0B0 Offset: 0x2BE1B1 VA: 0x2BE0B0
	// RVA: 0x20F6520 Offset: 0x20F6621 VA: 0x20F6520
	private IEnumerator MainCapture() { }

	// RVA: 0x20F65A0 Offset: 0x20F66A1 VA: 0x20F65A0
	private void EndCapture() { }

	// RVA: 0x20F6830 Offset: 0x20F6931 VA: 0x20F6830
	private void FinishCapture() { }

	// RVA: 0x20F6950 Offset: 0x20F6A51 VA: 0x20F6950
	public static ProcInst CreateBind(ProcInst super, HubAccess access) { }
}

