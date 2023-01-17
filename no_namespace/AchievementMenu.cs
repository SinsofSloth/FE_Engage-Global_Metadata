// Namespace: 
private class AchievementMenu.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 11411
{
	// Fields
	private Action m_YesEventHandler; // 0x70

	// Methods

	// RVA: 0x24ADCE0 Offset: 0x24ADDE1 VA: 0x24ADCE0
	public void .ctor(Action yesEventHandler) { }

	// RVA: 0x24ADD90 Offset: 0x24ADE91 VA: 0x24ADD90 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public class AchievementMenu.AchievementMenuItem : BasicMenuItem // TypeDefIndex: 11412
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x297DA0 Offset: 0x297EA1 VA: 0x297DA0
	private AchieveData <AchieveData>k__BackingField; // 0x68

	// Properties
	public AchieveData AchieveData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C5750 Offset: 0x2C5851 VA: 0x2C5750
	// RVA: 0x24AD5C0 Offset: 0x24AD6C1 VA: 0x24AD5C0
	public AchieveData get_AchieveData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5760 Offset: 0x2C5861 VA: 0x2C5760
	// RVA: 0x24AD5D0 Offset: 0x24AD6D1 VA: 0x24AD5D0
	private void set_AchieveData(AchieveData value) { }

	// RVA: 0x24AD5E0 Offset: 0x24AD6E1 VA: 0x24AD5E0
	public void .ctor(AchieveData achieveData) { }

	// RVA: 0x24AD620 Offset: 0x24AD721 VA: 0x24AD620 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x24AD680 Offset: 0x24AD781 VA: 0x24AD680 Slot: 4
	public override string GetName() { }

	// RVA: 0x24AD690 Offset: 0x24AD791 VA: 0x24AD690 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public class AchievementMenu.AchievementMenuNoneItem : BasicMenuItem // TypeDefIndex: 11413
{
	// Methods

	// RVA: 0x24ADC20 Offset: 0x24ADD21 VA: 0x24ADC20
	public void .ctor() { }

	// RVA: 0x24ADCC0 Offset: 0x24ADDC1 VA: 0x24ADCC0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }
}

// Namespace: 
private class AchievementMenu.GetBondsExchangeDialog : ExchangeYesNoDialog // TypeDefIndex: 11414
{
	// Methods

	// RVA: 0x24ADCD0 Offset: 0x24ADDD1 VA: 0x24ADCD0
	public void .ctor(List<BasicMenuItem> menuItemList, ExchangeDialogContent menuContent, string topMessage, string getItemTitle, List<ExchangeYesNoDialog.ItemParam> getItemParamList, ExchangeYesNoDialog.MoneyParam getMoneyParam, string costItemTitle, List<ExchangeYesNoDialog.ItemParam> costItemParamList, ExchangeYesNoDialog.MoneyParam costMoneyParam) { }

	// RVA: 0x24AD930 Offset: 0x24ADA31 VA: 0x24AD930
	public static void CreateBind(ProcInst super, string message, int bondsNum) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2778A0 Offset: 0x2779A1 VA: 0x2778A0
private sealed class AchievementMenu.<>c__DisplayClass18_0 // TypeDefIndex: 11415
{
	// Fields
	public AchieveData.Kinds kind; // 0x10

	// Methods

	// RVA: 0x24AD510 Offset: 0x24AD611 VA: 0x24AD510
	public void .ctor() { }

	// RVA: 0x24AD520 Offset: 0x24AD621 VA: 0x24AD520
	internal void <SetDisplayFromKind>b__0() { }
}

