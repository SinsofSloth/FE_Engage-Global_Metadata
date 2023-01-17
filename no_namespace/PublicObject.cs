// Namespace: 
[Serializable]
public class PublicObject.Group // TypeDefIndex: 14049
{
	// Fields
	public string m_Name; // 0x10
	public Object[] m_Objects; // 0x18

	// Methods

	// RVA: 0x1F2A170 Offset: 0x1F2A271 VA: 0x1F2A170
	public void .ctor() { }
}

// Namespace: 
public sealed class PublicObject.Func<T> : MulticastDelegate // TypeDefIndex: 14050
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4CFA0 Offset: 0x1E4D0A1 VA: 0x1E4CFA0
	|-PublicObject.Func<object>..ctor
	|-PublicObject.Func<Object>..ctor
	|-PublicObject.Func<ShaderVariantCollection>..ctor
	|-PublicObject.Func<TMP_FontAsset>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(string group, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4CFC0 Offset: 0x1E4D0C1 VA: 0x1E4CFC0
	|-PublicObject.Func<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(string group, T obj, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4D330 Offset: 0x1E4D431 VA: 0x1E4D330
	|-PublicObject.Func<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4D360 Offset: 0x1E4D461 VA: 0x1E4D360
	|-PublicObject.Func<object>.EndInvoke
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2794F0 Offset: 0x2795F1 VA: 0x2794F0
[Serializable]
private sealed class PublicObject.<>c // TypeDefIndex: 14051
{
	// Fields
	public static readonly PublicObject.<>c <>9; // 0x0
	public static Action<GameObject> <>9__5_0; // 0x8
	public static PublicObject.Func<ShaderVariantCollection> <>9__8_0; // 0x10
	public static PublicObject.Func<Object> <>9__9_0; // 0x18

	// Methods

	// RVA: 0x1F29EB0 Offset: 0x1F29FB1 VA: 0x1F29EB0
	private static void .cctor() { }

	// RVA: 0x1F29F20 Offset: 0x1F2A021 VA: 0x1F29F20
	public void .ctor() { }

	// RVA: 0x1F29F30 Offset: 0x1F2A031 VA: 0x1F29F30
	internal void <LoadAsync>b__5_0(GameObject go) { }

	// RVA: 0x1F2A010 Offset: 0x1F2A111 VA: 0x1F2A010
	internal void <WarmUpImpl>b__8_0(string group, ShaderVariantCollection obj) { }

	// RVA: 0x1F2A020 Offset: 0x1F2A121 VA: 0x1F2A020
	internal void <TryCreateDictionary>b__9_0(string group, Object obj) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279500 Offset: 0x279601 VA: 0x279500
private sealed class PublicObject.<>c__DisplayClass11_0 // TypeDefIndex: 14052
{
	// Fields
	public long total; // 0x10

	// Methods

	// RVA: 0x1F2A120 Offset: 0x1F2A221 VA: 0x1F2A120
	public void .ctor() { }

	// RVA: 0x1F2A130 Offset: 0x1F2A231 VA: 0x1F2A130
	internal void <DumpImpl>b__0(string group, Object obj) { }
}

