// Namespace: 
private class HubPlayTalkAfter.TalkGiftMenu : BasicMenuItem // TypeDefIndex: 10754
{
	// Methods

	// RVA: 0x35F36E0 Offset: 0x35F37E1 VA: 0x35F36E0 Slot: 4
	public override string GetName() { }

	// RVA: 0x35F3760 Offset: 0x35F3861 VA: 0x35F3760 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x35F3790 Offset: 0x35F3891 VA: 0x35F3790 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x35F3650 Offset: 0x35F3751 VA: 0x35F3650
	public void .ctor() { }
}

// Namespace: 
private class HubPlayTalkAfter.GodRelianceMenu : BasicMenuItem // TypeDefIndex: 10756
{
	// Fields
	private HubAccess m_access; // 0x68

	// Methods

	// RVA: 0x1FB8110 Offset: 0x1FB8211 VA: 0x1FB8110
	public void .ctor(HubAccess access) { }

	// RVA: 0x1FB8150 Offset: 0x1FB8251 VA: 0x1FB8150 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x1FB81F0 Offset: 0x1FB82F1 VA: 0x1FB81F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FB8270 Offset: 0x1FB8371 VA: 0x1FB8270 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FB82A0 Offset: 0x1FB83A1 VA: 0x1FB82A0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class HubPlayTalkAfter.RingMenu.NoItem : BasicDialogItemNo // TypeDefIndex: 10758
{
	// Methods

	// RVA: 0x1DD0140 Offset: 0x1DD0241 VA: 0x1DD0140
	public void .ctor() { }
}

// Namespace: 
private class HubPlayTalkAfter.CookingMenu : BasicMenuItem // TypeDefIndex: 10760
{
	// Methods

	// RVA: 0x1FB5D70 Offset: 0x1FB5E71 VA: 0x1FB5D70
	public void .ctor() { }

	// RVA: 0x1FB5D80 Offset: 0x1FB5E81 VA: 0x1FB5D80 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FB5E00 Offset: 0x1FB5F01 VA: 0x1FB5E00 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FB5F00 Offset: 0x1FB6001 VA: 0x1FB5F00 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class HubPlayTalkAfter.FishingPictureBookMenu : BasicMenuItem // TypeDefIndex: 10762
{
	// Methods

	// RVA: 0x1FB7AE0 Offset: 0x1FB7BE1 VA: 0x1FB7AE0
	public void .ctor() { }

	// RVA: 0x1FB7AF0 Offset: 0x1FB7BF1 VA: 0x1FB7AF0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FB7B70 Offset: 0x1FB7C71 VA: 0x1FB7B70 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FB7B80 Offset: 0x1FB7C81 VA: 0x1FB7B80 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class HubPlayTalkAfter.MuscleMenu : BasicMenuItem // TypeDefIndex: 10764
{
	// Methods

	// RVA: 0x1FB8430 Offset: 0x1FB8531 VA: 0x1FB8430
	public void .ctor() { }

	// RVA: 0x1FB8440 Offset: 0x1FB8541 VA: 0x1FB8440 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FB84C0 Offset: 0x1FB85C1 VA: 0x1FB84C0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FB84D0 Offset: 0x1FB85D1 VA: 0x1FB84D0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class HubPlayTalkAfter.FortuneTellingMenu : BasicMenuItem // TypeDefIndex: 10766
{
	// Methods

	// RVA: 0x1FB7F10 Offset: 0x1FB8011 VA: 0x1FB7F10
	public void .ctor() { }

	// RVA: 0x1FB7F20 Offset: 0x1FB8021 VA: 0x1FB7F20 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FB7FA0 Offset: 0x1FB80A1 VA: 0x1FB7FA0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FB7FB0 Offset: 0x1FB80B1 VA: 0x1FB7FB0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public enum HubPlayTalkAfter.Label // TypeDefIndex: 10768
{
	// Fields
	public int value__; // 0x0
	public const HubPlayTalkAfter.Label Init = 0;
	public const HubPlayTalkAfter.Label SelectMenu = 1;
	public const HubPlayTalkAfter.Label SelectGift = 2;
	public const HubPlayTalkAfter.Label ReactionGift = 3;
	public const HubPlayTalkAfter.Label Reliance = 4;
	public const HubPlayTalkAfter.Label Cooking = 5;
	public const HubPlayTalkAfter.Label Fishing = 6;
	public const HubPlayTalkAfter.Label FishingPictureBook = 7;
	public const HubPlayTalkAfter.Label DragonRide = 8;
	public const HubPlayTalkAfter.Label Muscle = 9;
	public const HubPlayTalkAfter.Label FleaMarket = 10;
	public const HubPlayTalkAfter.Label FortuneTelling = 11;
	public const HubPlayTalkAfter.Label End = 12;
}

// Namespace: 
private class HubPlayTalkAfter.ReplacePerson : ProcInst // TypeDefIndex: 10770
{
	// Fields
	private int m_LoadingCharacterCount; // 0x70

	// Methods

	// RVA: 0x1FB8960 Offset: 0x1FB8A61 VA: 0x1FB8960
	public bool IsChangePerson() { }

	// RVA: 0x1FB89E0 Offset: 0x1FB8AE1 VA: 0x1FB89E0
	private void SetupUnit(GameObject locator, string pid) { }

	// RVA: 0x1FB8CC0 Offset: 0x1FB8DC1 VA: 0x1FB8CC0
	private void ResetUnit(string locatorName) { }

	// RVA: 0x1FB8D60 Offset: 0x1FB8E61 VA: 0x1FB8D60
	private bool IsLoading() { }

	// RVA: 0x1FB8D70 Offset: 0x1FB8E71 VA: 0x1FB8D70
	public void PrepareChangePerson() { }

	// RVA: 0x1FB9130 Offset: 0x1FB9231 VA: 0x1FB9130
	private void ChangePerson() { }

	// RVA: 0x1FB9340 Offset: 0x1FB9441 VA: 0x1FB9340
	private void ChangePersonAfter() { }

	// RVA: 0x1FB9420 Offset: 0x1FB9521 VA: 0x1FB9420
	private void CallPersonVoice() { }

	// RVA: 0x1FB9590 Offset: 0x1FB9691 VA: 0x1FB9590
	private void ResetPerson() { }

	// RVA: 0x1FB9850 Offset: 0x1FB9951 VA: 0x1FB9850
	public static void ChangePersonBind(ProcInst super) { }

	// RVA: 0x1FB9EA0 Offset: 0x1FB9FA1 VA: 0x1FB9EA0
	public static void ResetPersonBind(ProcInst super) { }

	// RVA: 0x1FBA400 Offset: 0x1FBA501 VA: 0x1FBA400
	public static void ChangePersonBindNoFade(ProcInst super) { }

	// RVA: 0x1FBA940 Offset: 0x1FBAA41 VA: 0x1FBA940
	public static void ResetPersonBindNoFade(ProcInst super) { }

	// RVA: 0x1FB9E90 Offset: 0x1FB9F91 VA: 0x1FB9E90
	public void .ctor() { }
}

