// Namespace: 
public class ConfigBasicMenuItem : BasicMenuItem // TypeDefIndex: 7665
{
	// Fields
	public ConfigBasicMenuItem.ConfigMethodKind m_ConfigMethod; // 0x64
	public string m_TitleText; // 0x68
	public string m_CommandText; // 0x70
	public string m_HelpText; // 0x78
	public bool m_IsArrow; // 0x80
	public bool m_IsCommandIcon; // 0x81
	public float m_GaugeRatio; // 0x84

	// Methods

	// RVA: 0x23B2B00 Offset: 0x23B2C01 VA: 0x23B2B00 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x23B2C20 Offset: 0x23B2D21 VA: 0x23B2C20 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x23B2C30 Offset: 0x23B2D31 VA: 0x23B2C30 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x23B2D50 Offset: 0x23B2E51 VA: 0x23B2D50 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x23B2D80 Offset: 0x23B2E81 VA: 0x23B2D80 Slot: 27
	public virtual void InitContent() { }

	// RVA: 0x23B2B10 Offset: 0x23B2C11 VA: 0x23B2B10
	private void InitColor() { }

	// RVA: 0x23B2D90 Offset: 0x23B2E91 VA: 0x23B2D90
	protected void SetTitleText(string text) { }

	// RVA: 0x23B2C60 Offset: 0x23B2D61 VA: 0x23B2C60
	protected void UpdateText() { }

	// RVA: 0x23B2DA0 Offset: 0x23B2EA1 VA: 0x23B2DA0
	public bool IsConfigMethod(ConfigBasicMenuItem.ConfigMethodKind configMethod) { }

	// RVA: 0x23B2DB0 Offset: 0x23B2EB1 VA: 0x23B2DB0
	private static double ChangeKeyValueImpl(double value, double min, double max, double step, bool isRepeat = True) { }

	// RVA: 0x23B3580 Offset: 0x23B3681 VA: 0x23B3580
	public static int ChangeKeyValue(int value, int min, int max, int step = 1) { }

	// RVA: 0x23B35D0 Offset: 0x23B36D1 VA: 0x23B35D0
	public static float ChangeKeyValue(float value, float min, float max, float step = 1) { }

	// RVA: 0x23B3600 Offset: 0x23B3701 VA: 0x23B3600
	public void .ctor() { }
}

