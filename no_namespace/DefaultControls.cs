// Namespace: 
public interface DefaultControls.IFactoryControls // TypeDefIndex: 4254
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject CreateGameObject(string name, Type[] components);
}

// Namespace: 
private class DefaultControls.DefaultRuntimeFactory : DefaultControls.IFactoryControls // TypeDefIndex: 4255
{
	// Fields
	public static DefaultControls.IFactoryControls Default; // 0x0

	// Methods

	// RVA: 0x1BFC8F0 Offset: 0x1BFC9F1 VA: 0x1BFC8F0 Slot: 4
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x1BFC960 Offset: 0x1BFCA61 VA: 0x1BFC960
	public void .ctor() { }

	// RVA: 0x1BFC970 Offset: 0x1BFCA71 VA: 0x1BFC970
	private static void .cctor() { }
}

// Namespace: 
public struct DefaultControls.Resources // TypeDefIndex: 4256
{
	// Fields
	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30
}

