// Namespace: App
public abstract class MapFadeManager : SingletonMonoBehaviour<MapFadeManager> // TypeDefIndex: 14030
{
	// Fields
	private const int Max = 256;
	private List<CharacterCollision> m_Transparents; // 0x20
	private List<CharacterCollision> m_Destructions; // 0x28
	private List<MapCollision> m_Transparented; // 0x30
	private List<MapCollision> m_TempCollisions; // 0x38
	private Dictionary<MapCollision, float> m_AlphaCollisions; // 0x40
	private List<MapObject> m_FadeObjects; // 0x48
	private Collider[] m_Colliders; // 0x50
	private int m_LayerDestructionMask; // 0x58
	private int m_LayerTransparentMask; // 0x5C
	private Vector3 m_CameraPosition; // 0x60
	private Quaternion m_CameraRotation; // 0x6C
	private float m_FadeSpeed; // 0x7C

	// Methods

	// RVA: 0x21BF1A0 Offset: 0x21BF2A1 VA: 0x21BF1A0
	private void OnEnable() { }

	// RVA: 0x21BF3F0 Offset: 0x21BF4F1 VA: 0x21BF3F0
	private void OnDisable() { }

	// RVA: 0x21BF2F0 Offset: 0x21BF3F1 VA: 0x21BF2F0
	private void SetupFadeObject() { }

	// RVA: 0x21BF5D0 Offset: 0x21BF6D1 VA: 0x21BF5D0
	private void ClearFadeObject() { }

	// RVA: 0x21BF630 Offset: 0x21BF731 VA: 0x21BF630
	private float GetRadiusScale() { }

	// RVA: 0x21BF450 Offset: 0x21BF551 VA: 0x21BF450
	private void ClearTransparent() { }

	// RVA: 0x21BF7C0 Offset: 0x21BF8C1 VA: 0x21BF7C0
	private void UpdateTransparentPoint(Vector3 pos, float radius, bool isCharacter, float alpha) { }

	// RVA: 0x21BFB60 Offset: 0x21BFC61 VA: 0x21BFB60
	private void UpdateTransparentBetween(Vector3 pos1, Vector3 pos2, float radius, bool isCharacter, float alpha) { }

	// RVA: 0x21BF860 Offset: 0x21BF961 VA: 0x21BF860
	private void UpdateTransparentImpl(bool isCharacter, float alpha, int count) { }

	// RVA: 0x21BFCB0 Offset: 0x21BFDB1 VA: 0x21BFCB0
	private static bool IsCutChange(Camera camera, Vector3 position, Quaternion rotation) { }

	// RVA: 0x21BFE10 Offset: 0x21BFF11 VA: 0x21BFE10
	private void UpdateFadeSpeed() { }

	// RVA: 0x21BFF70 Offset: 0x21C0071 VA: 0x21BFF70
	private void UpdateTransparent() { }

	// RVA: 0x21C0580 Offset: 0x21C0681 VA: 0x21C0580
	private void UpdateDestruction(Vector3 pos, float radius) { }

	// RVA: 0x21C0720 Offset: 0x21C0821 VA: 0x21C0720
	private void UpdateDestruction() { }

	// RVA: 0x21BF5C0 Offset: 0x21BF6C1 VA: 0x21BF5C0
	private void ClearDestruction() { }

	// RVA: 0x21C0830 Offset: 0x21C0931 VA: 0x21C0830
	private void UpdateFaderObject() { }

	// RVA: 0x21C0940 Offset: 0x21C0A41 VA: 0x21C0940
	private void LateUpdate() { }

	// RVA: 0x21C0980 Offset: 0x21C0A81 VA: 0x21C0980
	public static void Entry(CharacterCollision collision) { }

	// RVA: 0x21C0AE0 Offset: 0x21C0BE1 VA: 0x21C0AE0
	public static void Remove(CharacterCollision collision) { }

	// RVA: 0x21C0C40 Offset: 0x21C0D41 VA: 0x21C0C40
	protected void .ctor() { }
}

