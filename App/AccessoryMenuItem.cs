// Namespace: App
public class AccessoryMenuItem : BasicMenuItem // TypeDefIndex: 10880
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x295DC0 Offset: 0x295EC1 VA: 0x295DC0
	private AccessoryData <m_AccessoryData>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x295DD0 Offset: 0x295ED1 VA: 0x295DD0
	private AccessoryData.Kinds <m_AccessoryKind>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x295DE0 Offset: 0x295EE1 VA: 0x295DE0
	private bool <m_Decided>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x295DF0 Offset: 0x295EF1 VA: 0x295DF0
	private AccessoryShopUtility.Female <m_Female>k__BackingField; // 0x78
	private bool m_AlwaysActive; // 0x7C
	private AccessoryMenuItem.SelectEventHandler m_SelectEventHandler; // 0x80
	private AccessoryMenuItem.DecideEventHandler m_DecideEventHandler; // 0x88

	// Properties
	public AccessoryData m_AccessoryData { get; set; }
	public AccessoryData.Kinds m_AccessoryKind { get; set; }
	public bool m_Decided { get; set; }
	public AccessoryShopUtility.Female m_Female { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C2840 Offset: 0x2C2941 VA: 0x2C2840
	// RVA: 0x2B15A90 Offset: 0x2B15B91 VA: 0x2B15A90
	public AccessoryData get_m_AccessoryData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2850 Offset: 0x2C2951 VA: 0x2C2850
	// RVA: 0x2B15AA0 Offset: 0x2B15BA1 VA: 0x2B15AA0
	private void set_m_AccessoryData(AccessoryData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2860 Offset: 0x2C2961 VA: 0x2C2860
	// RVA: 0x2B15AB0 Offset: 0x2B15BB1 VA: 0x2B15AB0
	public AccessoryData.Kinds get_m_AccessoryKind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2870 Offset: 0x2C2971 VA: 0x2C2870
	// RVA: 0x2B15AC0 Offset: 0x2B15BC1 VA: 0x2B15AC0
	private void set_m_AccessoryKind(AccessoryData.Kinds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2880 Offset: 0x2C2981 VA: 0x2C2880
	// RVA: 0x2B15AD0 Offset: 0x2B15BD1 VA: 0x2B15AD0
	public bool get_m_Decided() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2890 Offset: 0x2C2991 VA: 0x2C2890
	// RVA: 0x2B15AE0 Offset: 0x2B15BE1 VA: 0x2B15AE0
	private void set_m_Decided(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C28A0 Offset: 0x2C29A1 VA: 0x2C28A0
	// RVA: 0x2B15AF0 Offset: 0x2B15BF1 VA: 0x2B15AF0
	public AccessoryShopUtility.Female get_m_Female() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C28B0 Offset: 0x2C29B1 VA: 0x2C28B0
	// RVA: 0x2B15B00 Offset: 0x2B15C01 VA: 0x2B15B00
	private void set_m_Female(AccessoryShopUtility.Female value) { }

	// RVA: 0x2B14880 Offset: 0x2B14981 VA: 0x2B14880
	public void .ctor(AccessoryData accessoryData, AccessoryData.Kinds accessoryKind, bool decided, bool alwaysActive, AccessoryShopUtility.Female female, AccessoryMenuItem.SelectEventHandler selectEventHandler, AccessoryMenuItem.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2B15B10 Offset: 0x2B15C11 VA: 0x2B15B10 Slot: 4
	public override string GetName() { }

	// RVA: 0x2B15B20 Offset: 0x2B15C21 VA: 0x2B15B20 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2B15B40 Offset: 0x2B15C41 VA: 0x2B15B40 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2B15B50 Offset: 0x2B15C51 VA: 0x2B15B50 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2B15100 Offset: 0x2B15201 VA: 0x2B15100
	public void SetData(AccessoryData accessoryData, AccessoryData.Kinds accessoryKind, AccessoryShopUtility.Female female) { }

	// RVA: 0x2B15B60 Offset: 0x2B15C61 VA: 0x2B15B60
	public void SetInitialColor() { }

	// RVA: 0x2B15620 Offset: 0x2B15721 VA: 0x2B15620
	public RectTransform GetRectTransform() { }

	// RVA: 0x2B15EB0 Offset: 0x2B15FB1 VA: 0x2B15EB0
	public void SetDecide() { }

	// RVA: 0x2B16070 Offset: 0x2B16171 VA: 0x2B16070
	public void UnsetDecide() { }

	// RVA: 0x2B162D0 Offset: 0x2B163D1 VA: 0x2B162D0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2B16330 Offset: 0x2B16431 VA: 0x2B16330 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x2B16380 Offset: 0x2B16481 VA: 0x2B16380 Slot: 18
	public override BasicMenu.Result ACall() { }
}

