// Namespace: App
public class ExchangeYesNoDialog : BasicDialog // TypeDefIndex: 12552
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29AB40 Offset: 0x29AC41 VA: 0x29AB40
	private string <m_GetItemTitle>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x29AB50 Offset: 0x29AC51 VA: 0x29AB50
	private List<ExchangeYesNoDialog.ItemParam> <m_GetItemParamList>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x29AB60 Offset: 0x29AC61 VA: 0x29AB60
	private ExchangeYesNoDialog.MoneyParam <m_GetMoneyParam>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x29AB70 Offset: 0x29AC71 VA: 0x29AB70
	private ExchangeYesNoDialog.ItemParam <m_GetItemBeforeParam>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x29AB80 Offset: 0x29AC81 VA: 0x29AB80
	private ExchangeYesNoDialog.ItemParam <m_GetItemAfterParam>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x29AB90 Offset: 0x29AC91 VA: 0x29AB90
	private string <m_CostItemTitle>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x29ABA0 Offset: 0x29ACA1 VA: 0x29ABA0
	private List<ExchangeYesNoDialog.ItemParam> <m_CostItemParamList>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x29ABB0 Offset: 0x29ACB1 VA: 0x29ABB0
	private ExchangeYesNoDialog.MoneyParam <m_CostMoneyParam>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x29ABC0 Offset: 0x29ACC1 VA: 0x29ABC0
	private bool <m_UsingGetItemList>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x29ABD0 Offset: 0x29ACD1 VA: 0x29ABD0
	private bool <m_UsingGetBeforeAfter>k__BackingField; // 0x119
	[CompilerGeneratedAttribute] // RVA: 0x29ABE0 Offset: 0x29ACE1 VA: 0x29ABE0
	private bool <m_UsingGetLongName>k__BackingField; // 0x11A
	[CompilerGeneratedAttribute] // RVA: 0x29ABF0 Offset: 0x29ACF1 VA: 0x29ABF0
	private bool <m_UsingGetNameOnly>k__BackingField; // 0x11B
	[CompilerGeneratedAttribute] // RVA: 0x29AC00 Offset: 0x29AD01 VA: 0x29AC00
	private bool <m_EnabledKeyWaitStyle>k__BackingField; // 0x11C
	private Action m_DisposeEventHandler; // 0x120
	private bool m_IsForWell; // 0x128

	// Properties
	public string m_GetItemTitle { get; set; }
	public List<ExchangeYesNoDialog.ItemParam> m_GetItemParamList { get; set; }
	public ExchangeYesNoDialog.MoneyParam m_GetMoneyParam { get; set; }
	public ExchangeYesNoDialog.ItemParam m_GetItemBeforeParam { get; set; }
	public ExchangeYesNoDialog.ItemParam m_GetItemAfterParam { get; set; }
	public string m_CostItemTitle { get; set; }
	public List<ExchangeYesNoDialog.ItemParam> m_CostItemParamList { get; set; }
	public ExchangeYesNoDialog.MoneyParam m_CostMoneyParam { get; set; }
	public bool m_UsingGetItemList { get; set; }
	public bool m_UsingGetBeforeAfter { get; set; }
	public bool m_UsingGetLongName { get; set; }
	public bool m_UsingGetNameOnly { get; set; }
	public bool m_EnabledKeyWaitStyle { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C97D0 Offset: 0x2C98D1 VA: 0x2C97D0
	// RVA: 0x27FE690 Offset: 0x27FE791 VA: 0x27FE690
	public string get_m_GetItemTitle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C97E0 Offset: 0x2C98E1 VA: 0x2C97E0
	// RVA: 0x27FE6A0 Offset: 0x27FE7A1 VA: 0x27FE6A0
	protected void set_m_GetItemTitle(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C97F0 Offset: 0x2C98F1 VA: 0x2C97F0
	// RVA: 0x27FE6B0 Offset: 0x27FE7B1 VA: 0x27FE6B0
	public List<ExchangeYesNoDialog.ItemParam> get_m_GetItemParamList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9800 Offset: 0x2C9901 VA: 0x2C9800
	// RVA: 0x27FE6C0 Offset: 0x27FE7C1 VA: 0x27FE6C0
	protected void set_m_GetItemParamList(List<ExchangeYesNoDialog.ItemParam> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9810 Offset: 0x2C9911 VA: 0x2C9810
	// RVA: 0x27FE6D0 Offset: 0x27FE7D1 VA: 0x27FE6D0
	public ExchangeYesNoDialog.MoneyParam get_m_GetMoneyParam() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9820 Offset: 0x2C9921 VA: 0x2C9820
	// RVA: 0x27FE6E0 Offset: 0x27FE7E1 VA: 0x27FE6E0
	protected void set_m_GetMoneyParam(ExchangeYesNoDialog.MoneyParam value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9830 Offset: 0x2C9931 VA: 0x2C9830
	// RVA: 0x27FE6F0 Offset: 0x27FE7F1 VA: 0x27FE6F0
	public ExchangeYesNoDialog.ItemParam get_m_GetItemBeforeParam() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9840 Offset: 0x2C9941 VA: 0x2C9840
	// RVA: 0x27FE700 Offset: 0x27FE801 VA: 0x27FE700
	protected void set_m_GetItemBeforeParam(ExchangeYesNoDialog.ItemParam value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9850 Offset: 0x2C9951 VA: 0x2C9850
	// RVA: 0x27FE710 Offset: 0x27FE811 VA: 0x27FE710
	public ExchangeYesNoDialog.ItemParam get_m_GetItemAfterParam() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9860 Offset: 0x2C9961 VA: 0x2C9860
	// RVA: 0x27FE720 Offset: 0x27FE821 VA: 0x27FE720
	protected void set_m_GetItemAfterParam(ExchangeYesNoDialog.ItemParam value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9870 Offset: 0x2C9971 VA: 0x2C9870
	// RVA: 0x27FE730 Offset: 0x27FE831 VA: 0x27FE730
	public string get_m_CostItemTitle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9880 Offset: 0x2C9981 VA: 0x2C9880
	// RVA: 0x27FE740 Offset: 0x27FE841 VA: 0x27FE740
	protected void set_m_CostItemTitle(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9890 Offset: 0x2C9991 VA: 0x2C9890
	// RVA: 0x27FE750 Offset: 0x27FE851 VA: 0x27FE750
	public List<ExchangeYesNoDialog.ItemParam> get_m_CostItemParamList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C98A0 Offset: 0x2C99A1 VA: 0x2C98A0
	// RVA: 0x27FE760 Offset: 0x27FE861 VA: 0x27FE760
	protected void set_m_CostItemParamList(List<ExchangeYesNoDialog.ItemParam> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C98B0 Offset: 0x2C99B1 VA: 0x2C98B0
	// RVA: 0x27FE770 Offset: 0x27FE871 VA: 0x27FE770
	public ExchangeYesNoDialog.MoneyParam get_m_CostMoneyParam() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C98C0 Offset: 0x2C99C1 VA: 0x2C98C0
	// RVA: 0x27FE780 Offset: 0x27FE881 VA: 0x27FE780
	protected void set_m_CostMoneyParam(ExchangeYesNoDialog.MoneyParam value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C98D0 Offset: 0x2C99D1 VA: 0x2C98D0
	// RVA: 0x27FE790 Offset: 0x27FE891 VA: 0x27FE790
	public bool get_m_UsingGetItemList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C98E0 Offset: 0x2C99E1 VA: 0x2C98E0
	// RVA: 0x27FE7A0 Offset: 0x27FE8A1 VA: 0x27FE7A0
	protected void set_m_UsingGetItemList(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C98F0 Offset: 0x2C99F1 VA: 0x2C98F0
	// RVA: 0x27FE7B0 Offset: 0x27FE8B1 VA: 0x27FE7B0
	public bool get_m_UsingGetBeforeAfter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9900 Offset: 0x2C9A01 VA: 0x2C9900
	// RVA: 0x27FE7C0 Offset: 0x27FE8C1 VA: 0x27FE7C0
	protected void set_m_UsingGetBeforeAfter(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9910 Offset: 0x2C9A11 VA: 0x2C9910
	// RVA: 0x27FE7D0 Offset: 0x27FE8D1 VA: 0x27FE7D0
	public bool get_m_UsingGetLongName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9920 Offset: 0x2C9A21 VA: 0x2C9920
	// RVA: 0x27FE7E0 Offset: 0x27FE8E1 VA: 0x27FE7E0
	protected void set_m_UsingGetLongName(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9930 Offset: 0x2C9A31 VA: 0x2C9930
	// RVA: 0x27FE7F0 Offset: 0x27FE8F1 VA: 0x27FE7F0
	public bool get_m_UsingGetNameOnly() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9940 Offset: 0x2C9A41 VA: 0x2C9940
	// RVA: 0x27FE800 Offset: 0x27FE901 VA: 0x27FE800
	protected void set_m_UsingGetNameOnly(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9950 Offset: 0x2C9A51 VA: 0x2C9950
	// RVA: 0x27FE810 Offset: 0x27FE911 VA: 0x27FE810
	public bool get_m_EnabledKeyWaitStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9960 Offset: 0x2C9A61 VA: 0x2C9960
	// RVA: 0x27FE820 Offset: 0x27FE921 VA: 0x27FE820
	protected void set_m_EnabledKeyWaitStyle(bool value) { }

	// RVA: 0x27FE830 Offset: 0x27FE931 VA: 0x27FE830
	public static ExchangeYesNoDialog CreateBind(ProcInst super, string topMessage, string getItemTitle, List<ExchangeYesNoDialog.ItemParam> getItemParamList, ExchangeYesNoDialog.MoneyParam getMoneyParam, string costItemTitle, List<ExchangeYesNoDialog.ItemParam> costItemParamList, ExchangeYesNoDialog.MoneyParam costMoneyParam, BasicDialogItemYes yesMenuItem, BasicDialogItemNo noMenuItem) { }

	// RVA: 0x27FEB10 Offset: 0x27FEC11 VA: 0x27FEB10
	public static ExchangeYesNoDialog CreateBind(ProcInst super, string topMessage, string getItemTitle, ExchangeYesNoDialog.ItemParam getBeforeItemParam, ExchangeYesNoDialog.ItemParam getAfterItemParam, string costItemTitle, List<ExchangeYesNoDialog.ItemParam> costItemParamList, ExchangeYesNoDialog.MoneyParam costMoneyParam, BasicDialogItemYes yesMenuItem, BasicDialogItemNo noMenuItem) { }

	// RVA: 0x27FEDF0 Offset: 0x27FEEF1 VA: 0x27FEDF0
	public static ExchangeYesNoDialog CreateBind(ProcInst super, string topMessage, string getItemTitle, ExchangeYesNoDialog.ItemParam getItemParam, string costItemTitle, List<ExchangeYesNoDialog.ItemParam> costItemParamList, ExchangeYesNoDialog.MoneyParam costMoneyParam, BasicDialogItemYes yesMenuItem, BasicDialogItemNo noMenuItem) { }

	// RVA: 0x27FF150 Offset: 0x27FF251 VA: 0x27FF150
	public static ExchangeYesNoDialog CreateBind(ProcInst super, string topMessage, string getItemTitle, string getItemName, string costItemTitle, string costItemName, BasicDialogItemYes yesMenuItem, BasicDialogItemNo noMenuItem) { }

	// RVA: 0x27FF540 Offset: 0x27FF641 VA: 0x27FF540
	public static ExchangeYesNoDialog CreateBindForWell(ProcInst super, string topMessage, string getItemTitle, List<ExchangeYesNoDialog.ItemParam> getItemList, string costItemTitle, string costItemName, BasicDialogItemYes yesMenuItem, BasicDialogItemNo noMenuItem) { }

	// RVA: 0x27FF8F0 Offset: 0x27FF9F1 VA: 0x27FF8F0
	public static ExchangeYesNoDialog CreateDifficultyChangeBind(ProcInst super, string nowDifficultyName, List<BasicMenuItem> menuItemList) { }

	// RVA: 0x27FEA20 Offset: 0x27FEB21 VA: 0x27FEA20
	public void .ctor(List<BasicMenuItem> menuItemList, ExchangeDialogContent menuContent, string topMessage, string getItemTitle, List<ExchangeYesNoDialog.ItemParam> getItemParamList, ExchangeYesNoDialog.MoneyParam getMoneyParam, string costItemTitle, List<ExchangeYesNoDialog.ItemParam> costItemParamList, ExchangeYesNoDialog.MoneyParam costMoneyParam) { }

	// RVA: 0x27FED00 Offset: 0x27FEE01 VA: 0x27FED00
	public void .ctor(List<BasicMenuItem> menuItemList, ExchangeDialogContent menuContent, string topMessage, string getItemTitle, ExchangeYesNoDialog.ItemParam getItemBeforeParam, ExchangeYesNoDialog.ItemParam getItemAfterParam, string costItemTitle, List<ExchangeYesNoDialog.ItemParam> costItemParamList, ExchangeYesNoDialog.MoneyParam costMoneyParam) { }

	// RVA: 0x27FEFE0 Offset: 0x27FF0E1 VA: 0x27FEFE0
	public void .ctor(List<BasicMenuItem> menuItemList, ExchangeDialogContent menuContent, string topMessage, string getItemTitle, ExchangeYesNoDialog.ItemParam getItemParam, string costItemTitle, List<ExchangeYesNoDialog.ItemParam> costItemParamList, ExchangeYesNoDialog.MoneyParam costMoneyParam) { }

	// RVA: 0x27FF340 Offset: 0x27FF441 VA: 0x27FF340
	public void .ctor(List<BasicMenuItem> menuItemList, ExchangeDialogContent menuContent, string topMessage, string getItemTitle, string getItemName, string costItemTitle, string costItemName) { }

	// RVA: 0x27FF730 Offset: 0x27FF831 VA: 0x27FF730
	public void .ctor(List<BasicMenuItem> menuItemList, ExchangeDialogContent menuContent, string topMessage, string getItemTitle, List<ExchangeYesNoDialog.ItemParam> getItemList, string costItemTitle, string costItemName) { }

	// RVA: 0x27FFB30 Offset: 0x27FFC31 VA: 0x27FFB30 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x27FFB70 Offset: 0x27FFC71 VA: 0x27FFB70 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x27FFC60 Offset: 0x27FFD61 VA: 0x27FFC60
	public void SetKeyWaitStyle(bool enabled) { }

	// RVA: 0x27FFD70 Offset: 0x27FFE71 VA: 0x27FFD70
	public static int GetGetItemParamMax() { }

	// RVA: 0x27FFD80 Offset: 0x27FFE81 VA: 0x27FFD80
	public static int GetCostItemParamMax() { }

	// RVA: 0x27FFD90 Offset: 0x27FFE91 VA: 0x27FFD90
	public void SetDisposeEventHandler(Action disposeEventHandler) { }
}

