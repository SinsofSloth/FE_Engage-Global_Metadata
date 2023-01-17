// Namespace: UnityEngine.Timeline
public interface IPropertyCollector // TypeDefIndex: 5696
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PushActiveGameObject(GameObject gameObject);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PopActiveGameObject();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddFromClip(AnimationClip clip);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddFromName<T>(string name);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPropertyCollector.AddFromName<Camera>
	|-IPropertyCollector.AddFromName<object>
	|-IPropertyCollector.AddFromName<Transform>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddObjectProperties(Object obj, AnimationClip clip);
}

