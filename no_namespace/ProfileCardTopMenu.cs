// Namespace: 
public enum ProfileCardTopMenu.Result2 // TypeDefIndex: 11652
{
	// Fields
	public int value__; // 0x0
	public const ProfileCardTopMenu.Result2 MyCard = 0;
	public const ProfileCardTopMenu.Result2 Album = 1;
	public const ProfileCardTopMenu.Result2 Photo = 2;
	public const ProfileCardTopMenu.Result2 PublicSetting = 3;
	public const ProfileCardTopMenu.Result2 StampVisibilitySetting = 4;
	public const ProfileCardTopMenu.Result2 End = 5;
}

// Namespace: 
private class ProfileCardTopMenu.MyCardMenuItem : BasicMenuItem // TypeDefIndex: 11654
{
	// Fields
	private ProfileCardTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F28F70 Offset: 0x1F29071 VA: 0x1F28F70
	public void .ctor(ProfileCardTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F28FB0 Offset: 0x1F290B1 VA: 0x1F28FB0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F29030 Offset: 0x1F29131 VA: 0x1F29030 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F29100 Offset: 0x1F29201 VA: 0x1F29100 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class ProfileCardTopMenu.PhotoMenuItem : BasicMenuItem // TypeDefIndex: 11656
{
	// Fields
	private bool m_Enabled; // 0x64
	private ProfileCardTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F29130 Offset: 0x1F29231 VA: 0x1F29130
	public void .ctor(bool enabled, ProfileCardTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F29180 Offset: 0x1F29281 VA: 0x1F29180 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F29200 Offset: 0x1F29301 VA: 0x1F29200 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F29220 Offset: 0x1F29321 VA: 0x1F29220 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F29360 Offset: 0x1F29461 VA: 0x1F29360 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class ProfileCardTopMenu.StampVisibilitySettingMenuItem : BasicMenuItem // TypeDefIndex: 11658
{
	// Fields
	private ProfileCardTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F29660 Offset: 0x1F29761 VA: 0x1F29660
	public void .ctor(ProfileCardTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F296A0 Offset: 0x1F297A1 VA: 0x1F296A0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F29720 Offset: 0x1F29821 VA: 0x1F29720 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F298D0 Offset: 0x1F299D1 VA: 0x1F298D0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

