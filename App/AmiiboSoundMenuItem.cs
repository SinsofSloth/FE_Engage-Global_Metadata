// Namespace: App
internal class AmiiboSoundMenuItem : BasicMenuItem // TypeDefIndex: 10406
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28DFE0 Offset: 0x28E0E1 VA: 0x28DFE0
	private bool <IsEmpty>k__BackingField; // 0x64
	private MusicData m_musicData; // 0x68

	// Properties
	public bool IsEmpty { get; set; }
	public bool IsNew { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BDE90 Offset: 0x2BDF91 VA: 0x2BDE90
	// RVA: 0x20EE970 Offset: 0x20EEA71 VA: 0x20EE970
	public bool get_IsEmpty() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDEA0 Offset: 0x2BDFA1 VA: 0x2BDEA0
	// RVA: 0x20EE980 Offset: 0x20EEA81 VA: 0x20EE980
	public void set_IsEmpty(bool value) { }

	// RVA: 0x20EE990 Offset: 0x20EEA91 VA: 0x20EE990
	public bool get_IsNew() { }

	// RVA: 0x20ED910 Offset: 0x20EDA11 VA: 0x20ED910
	public void .ctor(MusicData musicData, bool empty = False) { }

	// RVA: 0x20EDBD0 Offset: 0x20EDCD1 VA: 0x20EDBD0
	public void SawNewMusic() { }

	// RVA: 0x20EEAB0 Offset: 0x20EEBB1 VA: 0x20EEAB0 Slot: 4
	public override string GetName() { }

	// RVA: 0x20EEB90 Offset: 0x20EEC91 VA: 0x20EEB90 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x20EECB0 Offset: 0x20EEDB1 VA: 0x20EECB0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x20EEE20 Offset: 0x20EEF21 VA: 0x20EEE20 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x20EF430 Offset: 0x20EF531 VA: 0x20EF430 Slot: 19
	public override BasicMenu.Result BCall() { }
}

