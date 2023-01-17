// Namespace: 
private enum ConfigSequence.Label // TypeDefIndex: 7692
{
	// Fields
	public int value__; // 0x0
	public const ConfigSequence.Label Load = 0;
	public const ConfigSequence.Label Unload = 1;
	public const ConfigSequence.Label End = 2;
}

// Namespace: 
public class ConfigSequence : ProcInst // TypeDefIndex: 7693
{
	// Fields
	private GameObject m_ConfigObject; // 0x70

	// Methods

	// RVA: 0x23B5D70 Offset: 0x23B5E71 VA: 0x23B5D70
	private void LoadResources() { }

	// RVA: 0x23B5DF0 Offset: 0x23B5EF1 VA: 0x23B5DF0
	private void UnloadResources() { }

	// RVA: 0x23B5E70 Offset: 0x23B5F71 VA: 0x23B5E70
	private bool IsLoadingResources() { }

	// RVA: 0x23B5EF0 Offset: 0x23B5FF1 VA: 0x23B5EF0
	private void StartSequence() { }

	// RVA: 0x23B60D0 Offset: 0x23B61D1 VA: 0x23B60D0
	private void CreateConfigMenu() { }

	// RVA: 0x23B6100 Offset: 0x23B6201 VA: 0x23B6100
	private void EndSequence() { }

	// RVA: 0x23B6240 Offset: 0x23B6341 VA: 0x23B6240
	private void DestroyConfigMenu() { }

	// RVA: 0x23B62B0 Offset: 0x23B63B1 VA: 0x23B62B0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x23B6860 Offset: 0x23B6961 VA: 0x23B6860 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x23B6850 Offset: 0x23B6951 VA: 0x23B6850
	public void .ctor() { }
}

