// Namespace: UnityEngine.ResourceManagement.Util
internal class DelayedActionManager : ComponentSingleton<DelayedActionManager> // TypeDefIndex: 5556
{
	// Fields
	private List<DelayedActionManager.DelegateInfo>[] m_Actions; // 0x18
	private LinkedList<DelayedActionManager.DelegateInfo> m_DelayedActions; // 0x20
	private Stack<LinkedListNode<DelayedActionManager.DelegateInfo>> m_NodeCache; // 0x28
	private int m_CollectionIndex; // 0x30
	private bool m_DestroyOnCompletion; // 0x34

	// Properties
	public static bool IsActive { get; }

	// Methods

	// RVA: 0x36293E0 Offset: 0x36294E1 VA: 0x36293E0
	private LinkedListNode<DelayedActionManager.DelegateInfo> GetNode(ref DelayedActionManager.DelegateInfo del) { }

	// RVA: 0x3629500 Offset: 0x3629601 VA: 0x3629500
	public static void Clear() { }

	// RVA: 0x3629590 Offset: 0x3629691 VA: 0x3629590
	private void DestroyWhenComplete() { }

	// RVA: 0x36295A0 Offset: 0x36296A1 VA: 0x36295A0
	public static void AddAction(Delegate action, float delay = 0, object[] parameters) { }

	// RVA: 0x3629610 Offset: 0x3629711 VA: 0x3629610
	private void AddActionInternal(Delegate action, float delay, object[] parameters) { }

	// RVA: 0x36298F0 Offset: 0x36299F1 VA: 0x36298F0
	public static bool get_IsActive() { }

	// RVA: 0x3629A10 Offset: 0x3629B11 VA: 0x3629A10
	public static bool Wait(float timeout = 0, float timeAdvanceAmount = 0) { }

	// RVA: 0x3629EB0 Offset: 0x3629FB1 VA: 0x3629EB0
	private void LateUpdate() { }

	// RVA: 0x3629BE0 Offset: 0x3629CE1 VA: 0x3629BE0
	private void InternalLateUpdate(float t) { }

	// RVA: 0x362A0B0 Offset: 0x362A1B1 VA: 0x362A0B0
	private void OnApplicationQuit() { }

	// RVA: 0x362A170 Offset: 0x362A271 VA: 0x362A170
	public void .ctor() { }
}

