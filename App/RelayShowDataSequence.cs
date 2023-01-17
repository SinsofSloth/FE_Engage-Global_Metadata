// Namespace: App
internal class RelayShowDataSequence : ProcInst // TypeDefIndex: 12964
{
	// Fields
	private RelayServerMetaData m_MetaData; // 0x70
	private RelayShowDataDialog.Mode m_Mode; // 0x78
	private bool m_IsNewPlay; // 0x7C

	// Methods

	// RVA: 0x24C4580 Offset: 0x24C4681 VA: 0x24C4580
	private void .ctor(RelayShowDataDialog.Mode mode, RelayServerMetaData metaData, bool isNewPlay) { }

	// RVA: 0x24C45E0 Offset: 0x24C46E1 VA: 0x24C45E0
	private bool IsSkipTutorial() { }

	// RVA: 0x24C4610 Offset: 0x24C4711 VA: 0x24C4610
	private void Show() { }

	// RVA: 0x24C46C0 Offset: 0x24C47C1 VA: 0x24C46C0
	private bool IsSetPublishMode() { }

	// RVA: 0x24C4700 Offset: 0x24C4801 VA: 0x24C4700
	private void SetPublishMode() { }

	// RVA: 0x24C4710 Offset: 0x24C4811 VA: 0x24C4710
	public static void CreateBindTakeOver(ProcInst super, RelayServerMetaData metaData) { }

	// RVA: 0x24C4BC0 Offset: 0x24C4CC1 VA: 0x24C4BC0
	public static void CreateBindUpload(ProcInst super, RelayServerMetaData metaData, bool isNewPlay) { }

	// RVA: 0x24C4720 Offset: 0x24C4821 VA: 0x24C4720
	private static void CreateBindImpl(ProcInst super, RelayShowDataDialog.Mode mode, RelayServerMetaData metaData, bool isNewPlay) { }
}

