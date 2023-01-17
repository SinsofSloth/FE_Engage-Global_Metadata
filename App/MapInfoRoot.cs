// Namespace: App
public class MapInfoRoot : MonoBehaviour // TypeDefIndex: 9018
{
	// Fields
	private Canvas m_Canvas; // 0x18
	private CanvasGroup m_CanvasGroup; // 0x20
	private MapInfoUnitLocatorRoot m_MapInfoUnitLocatorRoot; // 0x28
	private MapInfoGaugeMainLocatorRoot m_MapInfoGaugeMainLocatorRoot; // 0x30
	private float m_OldAlpha; // 0x38
	private bool m_IsDisplayOutside; // 0x3C
	private bool m_IsInfoEnable; // 0x3D
	private MapInfoRoot.NextCanvasEnabled m_NextCanvasEnabled; // 0x40

	// Methods

	// RVA: 0x2490FB0 Offset: 0x24910B1 VA: 0x2490FB0
	public void Start() { }

	// RVA: 0x2490FC0 Offset: 0x24910C1 VA: 0x2490FC0
	public void Init(Unit unit) { }

	// RVA: 0x24911F0 Offset: 0x24912F1 VA: 0x24911F0
	public void Tick(Unit unit) { }

	// RVA: 0x24914F0 Offset: 0x24915F1 VA: 0x24914F0
	private void UpdatePosition(Unit unit) { }

	// RVA: 0x24912E0 Offset: 0x24913E1 VA: 0x24912E0
	private void UpdateCanvas(Unit unit) { }

	// RVA: 0x24916C0 Offset: 0x24917C1 VA: 0x24916C0
	private void UpdateParam(Unit unit) { }

	// RVA: 0x2491570 Offset: 0x2491671 VA: 0x2491570
	private void UpdateAlpha(Unit unit) { }

	// RVA: 0x2491770 Offset: 0x2491871 VA: 0x2491770
	private void UpdateSortOrder(Unit unit) { }

	// RVA: 0x2491890 Offset: 0x2491991 VA: 0x2491890
	public void ForceUpdate() { }

	// RVA: 0x24918B0 Offset: 0x24919B1 VA: 0x24918B0
	public void SetActive(bool enable) { }

	// RVA: 0x24918E0 Offset: 0x24919E1 VA: 0x24918E0
	public void PlayEngageEffect(Unit unit, int count) { }

	// RVA: 0x2491900 Offset: 0x2491A01 VA: 0x2491900
	public void PlayEngageTurnRecoveryEffect() { }

	// RVA: 0x2491920 Offset: 0x2491A21 VA: 0x2491920
	public bool IsPlayingEngageTurnRecoveryEffect() { }

	// RVA: 0x24919D0 Offset: 0x2491AD1 VA: 0x24919D0
	public float GetEngageTurnRecoveryEffectRate() { }

	// RVA: 0x2491A80 Offset: 0x2491B81 VA: 0x2491A80
	public void SetSuppressHpStock(bool enable) { }

	// RVA: 0x2491AA0 Offset: 0x2491BA1 VA: 0x2491AA0
	public void PlayHpStockEffect(Unit unit) { }

	// RVA: 0x2491AC0 Offset: 0x2491BC1 VA: 0x2491AC0
	public void PlayHpStockCreateEffect(Unit unit) { }

	// RVA: 0x2491AE0 Offset: 0x2491BE1 VA: 0x2491AE0
	public void SetHpStockAlpha(int stock, float alpha) { }

	// RVA: 0x2491B00 Offset: 0x2491C01 VA: 0x2491B00
	public bool IsPlayingHpStockEffect() { }

	// RVA: 0x2491BB0 Offset: 0x2491CB1 VA: 0x2491BB0
	public float GetHpStockEffectRate() { }

	// RVA: 0x2491C60 Offset: 0x2491D61 VA: 0x2491C60
	public void SetUnitScreenPosLocalScale(Vector3 pos) { }

	// RVA: 0x2491C80 Offset: 0x2491D81 VA: 0x2491C80
	public void SetScreenHalfSize(Vector2 screenHalf) { }

	// RVA: 0x2491CA0 Offset: 0x2491DA1 VA: 0x2491CA0
	public void InitHpForecast() { }

	// RVA: 0x2491CC0 Offset: 0x2491DC1 VA: 0x2491CC0
	public void SetHpForecast(int before, int after) { }

	// RVA: 0x2491CE0 Offset: 0x2491DE1 VA: 0x2491CE0
	public void InitBreak() { }

	// RVA: 0x2491D00 Offset: 0x2491E01 VA: 0x2491D00
	public void SetBreak(bool isBreak) { }

	// RVA: 0x2491D20 Offset: 0x2491E21 VA: 0x2491D20
	public bool IsCanvasVisibilityChanged() { }

	// RVA: 0x2491D30 Offset: 0x2491E31 VA: 0x2491D30
	public bool IsNextCanvasVisibilityEnable() { }

	// RVA: 0x2491D40 Offset: 0x2491E41 VA: 0x2491D40
	public bool IsNextCanvasVisibilityDisable() { }

	// RVA: 0x2491D50 Offset: 0x2491E51 VA: 0x2491D50
	public void CanvasVisibilityChange() { }

	// RVA: 0x2491810 Offset: 0x2491911 VA: 0x2491810
	private void SetInfoEnable(bool enable) { }

	// RVA: 0x2491D90 Offset: 0x2491E91 VA: 0x2491D90
	public void .ctor() { }
}

