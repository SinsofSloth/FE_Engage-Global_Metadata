// Namespace: UnityEngine.ResourceManagement.Util
[ExecuteInEditMode] // RVA: 0x72330 Offset: 0x72431 VA: 0x72330
public abstract class ComponentSingleton<T> : MonoBehaviour // TypeDefIndex: 5554
{
	// Fields
	private static T s_Instance; // 0x0

	// Properties
	public static bool Exists { get; }
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_Exists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25017B0 Offset: 0x25018B1 VA: 0x25017B0
	|-ComponentSingleton<DelayedActionManager>.get_Exists
	|-ComponentSingleton<DiagnosticEventCollectorSingleton>.get_Exists
	|-ComponentSingleton<MonoBehaviourCallbackHooks>.get_Exists
	|-ComponentSingleton<object>.get_Exists
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2501850 Offset: 0x2501951 VA: 0x2501850
	|-ComponentSingleton<DelayedActionManager>.get_Instance
	|-ComponentSingleton<DiagnosticEventCollectorSingleton>.get_Instance
	|-ComponentSingleton<MonoBehaviourCallbackHooks>.get_Instance
	|-ComponentSingleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	private static T FindInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2501A40 Offset: 0x2501B41 VA: 0x2501A40
	|-ComponentSingleton<object>.FindInstance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual string GetGameObjectName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2501B00 Offset: 0x2501C01 VA: 0x2501B00
	|-ComponentSingleton<DelayedActionManager>.GetGameObjectName
	|-ComponentSingleton<object>.GetGameObjectName
	*/

	// RVA: -1 Offset: -1
	private static T CreateNewSingleton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2501B90 Offset: 0x2501C91 VA: 0x2501B90
	|-ComponentSingleton<object>.CreateNewSingleton
	*/

	// RVA: -1 Offset: -1
	private void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2501CC0 Offset: 0x2501DC1 VA: 0x2501CC0
	|-ComponentSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	public static void DestroySingleton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2501E90 Offset: 0x2501F91 VA: 0x2501E90
	|-ComponentSingleton<DiagnosticEventCollectorSingleton>.DestroySingleton
	|-ComponentSingleton<object>.DestroySingleton
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2502010 Offset: 0x2502111 VA: 0x2502010
	|-ComponentSingleton<DelayedActionManager>..ctor
	|-ComponentSingleton<DiagnosticEventCollectorSingleton>..ctor
	|-ComponentSingleton<MonoBehaviourCallbackHooks>..ctor
	|-ComponentSingleton<object>..ctor
	*/
}

