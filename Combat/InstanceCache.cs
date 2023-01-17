// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2749D0 Offset: 0x274AD1 VA: 0x2749D0
internal sealed class InstanceCache : MonoBehaviour // TypeDefIndex: 8820
{
	// Fields
	private static InstanceCache s_this; // 0x0
	private const string FreeTreeName = "FreedEffects";
	private const string UsedTreeName = "AliveEffects";
	private Dictionary<GameObject, GameObject> usedDic; // 0x18
	private Dictionary<GameObject, Stack<GameObject>> freeDic; // 0x20
	private Transform usedNode; // 0x28
	private Transform freeNode; // 0x30

	// Properties
	public static InstanceCache Instance { get; }
	public Transform UsedEffectRoot { get; }

	// Methods

	// RVA: 0x2C4DEF0 Offset: 0x2C4DFF1 VA: 0x2C4DEF0
	public static InstanceCache get_Instance() { }

	// RVA: 0x2C4DF40 Offset: 0x2C4E041 VA: 0x2C4DF40
	public Transform get_UsedEffectRoot() { }

	// RVA: 0x2C4DF50 Offset: 0x2C4E051 VA: 0x2C4DF50
	private void Awake() { }

	// RVA: 0x2C4E230 Offset: 0x2C4E331 VA: 0x2C4E230
	private void OnDestroy() { }

	// RVA: 0x2C4E430 Offset: 0x2C4E531 VA: 0x2C4E430
	public void Cleanup() { }

	// RVA: 0x2C4E910 Offset: 0x2C4EA11 VA: 0x2C4E910
	public GameObject Create(GameObject prefab, Transform parent) { }

	// RVA: 0x2C4ECE0 Offset: 0x2C4EDE1 VA: 0x2C4ECE0
	public void Delete(GameObject go) { }

	// RVA: 0x2C4EC10 Offset: 0x2C4ED11 VA: 0x2C4EC10
	private void ReplayAwakeSound(GameObject go) { }

	// RVA: 0x2C4EE40 Offset: 0x2C4EF41 VA: 0x2C4EE40
	public void .ctor() { }
}

