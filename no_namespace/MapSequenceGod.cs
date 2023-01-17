// Namespace: 
private enum MapSequenceGod.Label // TypeDefIndex: 12412
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceGod.Label Detail = 0;
	public const MapSequenceGod.Label Simple = 1;
	public const MapSequenceGod.Label End = 2;
}

// Namespace: 
public enum MapSequenceGod.Kind // TypeDefIndex: 12413
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceGod.Kind EngageStart = 0;
	public const MapSequenceGod.Kind EngageLink = 1;
	public const MapSequenceGod.Kind GodChange = 2;
}

// Namespace: 
internal class MapSequenceGod.ProcEngage : ProcInst // TypeDefIndex: 12414
{
	// Methods

	// RVA: 0x2133030 Offset: 0x2133131 VA: 0x2133030
	protected bool IsUsableInfo() { }

	// RVA: 0x2133100 Offset: 0x2133201 VA: 0x2133100
	protected bool IsNeedToDeploy() { }

	// RVA: 0x21331D0 Offset: 0x21332D1 VA: 0x21331D0
	protected void MoveWait() { }

	// RVA: 0x2133290 Offset: 0x2133391 VA: 0x2133290
	protected void HideInfoUIForDetail() { }

	// RVA: 0x2133360 Offset: 0x2133461 VA: 0x2133360
	protected void HideInfoUIForSimple() { }

	// RVA: 0x2133410 Offset: 0x2133511 VA: 0x2133410
	protected void UpdateImage() { }

	// RVA: 0x21334F0 Offset: 0x21335F1 VA: 0x21334F0
	protected void UpdateInfoUI() { }

	// RVA: 0x21335D0 Offset: 0x21336D1 VA: 0x21335D0
	protected void ShowInfoUI() { }

	// RVA: 0x21336D0 Offset: 0x21337D1 VA: 0x21336D0
	protected void UpdateDeploy() { }

	// RVA: 0x2133770 Offset: 0x2133871 VA: 0x2133770
	protected void UpdateMapRoute() { }

	// RVA: 0x2133D80 Offset: 0x2133E81 VA: 0x2133D80
	protected void UpdateMapCursor() { }

	// RVA: 0x2133C10 Offset: 0x2133D11 VA: 0x2133C10
	private bool IsUpdateMapRoute() { }

	// RVA: 0x2133EA0 Offset: 0x2133FA1 VA: 0x2133EA0
	public void .ctor() { }
}

// Namespace: 
internal class MapSequenceGod.ProcEngageStart : MapSequenceGod.ProcEngage // TypeDefIndex: 12415
{
	// Fields
	private MapSequenceGod.Kind m_Kind; // 0x70
	private bool m_IsSimple; // 0x74

	// Methods

	// RVA: 0x2134480 Offset: 0x2134581 VA: 0x2134480
	private void .ctor(MapSequenceGod.Kind kind, bool isSimple) { }

	// RVA: 0x21344C0 Offset: 0x21345C1 VA: 0x21344C0
	private void PlayEffect(float wait) { }

	// RVA: 0x21345A0 Offset: 0x21346A1 VA: 0x21345A0
	private void PlayEffectSimple() { }

	// RVA: 0x21345B0 Offset: 0x21346B1 VA: 0x21345B0
	private void PlayEffectDetail() { }

	// RVA: 0x21345C0 Offset: 0x21346C1 VA: 0x21345C0
	private void Demo() { }

	// RVA: 0x21346F0 Offset: 0x21347F1 VA: 0x21346F0
	private void Apply() { }

	// RVA: 0x2134710 Offset: 0x2134811 VA: 0x2134710
	private void ApplyEngage() { }

	// RVA: 0x2134950 Offset: 0x2134A51 VA: 0x2134950
	private void ApplyGodChange() { }

	// RVA: 0x2134A20 Offset: 0x2134B21 VA: 0x2134A20
	private bool IsSimple() { }

	// RVA: 0x2134BB0 Offset: 0x2134CB1 VA: 0x2134BB0
	private void Branch() { }

	// RVA: 0x2134C40 Offset: 0x2134D41 VA: 0x2134C40
	public static void CreateBind(ProcInst super, MapSequenceGod.Kind kind, bool isSimple) { }
}

// Namespace: 
internal class MapSequenceGod.ProcEngageCancel : MapSequenceGod.ProcEngage // TypeDefIndex: 12416
{
	// Methods

	// RVA: 0x2133EB0 Offset: 0x2133FB1 VA: 0x2133EB0
	private void Cancel() { }

	// RVA: 0x2133F30 Offset: 0x2134031 VA: 0x2133F30
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2134470 Offset: 0x2134571 VA: 0x2134470
	public void .ctor() { }
}

