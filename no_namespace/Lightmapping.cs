// Namespace: 
public sealed class Lightmapping.RequestLightsDelegate : MulticastDelegate // TypeDefIndex: 4018
{
	// Methods

	// RVA: 0x3853C90 Offset: 0x3853D91 VA: 0x3853C90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3853CB0 Offset: 0x3853DB1 VA: 0x3853CB0 Slot: 13
	public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	// RVA: 0x3854050 Offset: 0x3854151 VA: 0x3854050 Slot: 14
	public virtual IAsyncResult BeginInvoke(Light[] requests, NativeArray<LightDataGI> lightsOutput, AsyncCallback callback, object object) { }

	// RVA: 0x38540F0 Offset: 0x38541F1 VA: 0x38540F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x441510 Offset: 0x441611 VA: 0x441510
[Serializable]
private sealed class Lightmapping.<>c // TypeDefIndex: 4019
{
	// Fields
	public static readonly Lightmapping.<>c <>9; // 0x0

	// Methods

	// RVA: 0x3853980 Offset: 0x3853A81 VA: 0x3853980
	private static void .cctor() { }

	// RVA: 0x38539F0 Offset: 0x3853AF1 VA: 0x38539F0
	public void .ctor() { }

	// RVA: 0x3853A00 Offset: 0x3853B01 VA: 0x3853A00
	internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }
}

