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
private class AchievementMenu.GetBondsExchangeDialog : ExchangeYesNoDialog // TypeDefIndex: 11414
{
	// Methods

	// RVA: 0x24ADCD0 Offset: 0x24ADDD1 VA: 0x24ADCD0
	public void .ctor(List<BasicMenuItem> menuItemList, ExchangeDialogContent menuContent, string topMessage, string getItemTitle, List<ExchangeYesNoDialog.ItemParam> getItemParamList, ExchangeYesNoDialog.MoneyParam getMoneyParam, string costItemTitle, List<ExchangeYesNoDialog.ItemParam> costItemParamList, ExchangeYesNoDialog.MoneyParam costMoneyParam) { }

	// RVA: 0x24AD930 Offset: 0x24ADA31 VA: 0x24AD930
	public static void CreateBind(ProcInst super, string message, int bondsNum) { }
}

