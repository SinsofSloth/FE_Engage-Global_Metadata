// Namespace: RootMotion
public abstract class Singleton<T> : MonoBehaviour // TypeDefIndex: 14308
{
	// Fields
	private static T sInstance; // 0x0

	// Properties
	public static T instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440C20 Offset: 0x3440D21 VA: 0x3440C20
	|-Singleton<object>.get_instance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440D50 Offset: 0x3440E51 VA: 0x3440D50
	|-Singleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440EE0 Offset: 0x3440FE1 VA: 0x3440EE0
	|-Singleton<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440EF0 Offset: 0x3440FF1 VA: 0x3440EF0
	|-Singleton<object>..cctor
	*/
}

