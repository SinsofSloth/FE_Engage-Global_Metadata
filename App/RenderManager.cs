// Namespace: App
public class RenderManager // TypeDefIndex: 9155
{
	// Fields
	private static Stack<float> s_ScaleStack; // 0x0
	private static Stack<float> s_ScaleStackOnGpuSaved; // 0x8
	private static Stack<float> s_LodBiasStack; // 0x10
	private static Stack<float> s_LodBiasStackOnGpuSaved; // 0x18
	private static Stack<int> s_BlurStack; // 0x20
	private static Stack<Color> s_ColorStack; // 0x28
	private static Stack<float> s_ColorRateStack; // 0x30
	private static Stack<float> s_CrossFadeAnimationDuration; // 0x38

	// Methods

	// RVA: 0x24CB310 Offset: 0x24CB411 VA: 0x24CB310
	public static void PushRenderScale(string name) { }

	// RVA: 0x24CB4E0 Offset: 0x24CB5E1 VA: 0x24CB4E0
	public static void PushRenderScale(float scale) { }

	// RVA: 0x24CB710 Offset: 0x24CB811 VA: 0x24CB710
	public static void PushRenderScale(string name, string nameOnGpuSave) { }

	// RVA: 0x24CB8A0 Offset: 0x24CB9A1 VA: 0x24CB8A0
	public static void PushRenderScale(float scale, float scaleOnGpuSave) { }

	// RVA: 0x24CB9B0 Offset: 0x24CBAB1 VA: 0x24CB9B0
	public static void PopRenderScale() { }

	// RVA: 0x24CBAA0 Offset: 0x24CBBA1 VA: 0x24CBAA0
	public static void PushLodBias(float lodBias) { }

	// RVA: 0x24CBB10 Offset: 0x24CBC11 VA: 0x24CBB10
	public static void PushLodBias(float lodBias, float lodBiasOnGpuSaved) { }

	// RVA: 0x24CBD10 Offset: 0x24CBE11 VA: 0x24CBD10
	public static void PopLodBias() { }

	// RVA: 0x24CBE00 Offset: 0x24CBF01 VA: 0x24CBE00
	public static void PushCrossFadeAnimationDuration(float duration) { }

	// RVA: 0x24CBFD0 Offset: 0x24CC0D1 VA: 0x24CBFD0
	public static void PopCrossFadeAnimationDuration() { }

	// RVA: 0x24CC100 Offset: 0x24CC201 VA: 0x24CC100
	public static void PushCustomBlur(string name) { }

	// RVA: 0x24CC2C0 Offset: 0x24CC3C1 VA: 0x24CC2C0
	public static void PushCustomBlur(int blur) { }

	// RVA: 0x24CC460 Offset: 0x24CC561 VA: 0x24CC460
	public static void PopCustomBlur() { }

	// RVA: 0x24CC520 Offset: 0x24CC621 VA: 0x24CC520
	public static void PushColorRate(string name) { }

	// RVA: 0x24CC620 Offset: 0x24CC721 VA: 0x24CC620
	public static void PushColorRate(float rate) { }

	// RVA: 0x24CC7C0 Offset: 0x24CC8C1 VA: 0x24CC7C0
	public static void PopColorRate() { }

	// RVA: 0x24CC880 Offset: 0x24CC981 VA: 0x24CC880
	public static void Reset() { }

	// RVA: 0x24CCBF0 Offset: 0x24CCCF1 VA: 0x24CCBF0
	public static void UpdateGpuPerformanceMode() { }

	// RVA: 0x24CB410 Offset: 0x24CB511 VA: 0x24CB410
	private static float GetFloat(string name, float def) { }

	// RVA: 0x24CC200 Offset: 0x24CC301 VA: 0x24CC200
	private static int GetInt(string name, int def) { }

	// RVA: -1 Offset: -1
	private static T GetStackPeek<T>(Stack<T> stack, T def) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20168B0 Offset: 0x20169B1 VA: 0x20168B0
	|-RenderManager.GetStackPeek<Color>
	|
	|-RVA: 0x2016940 Offset: 0x2016A41 VA: 0x2016940
	|-RenderManager.GetStackPeek<int>
	|
	|-RVA: 0x20169B0 Offset: 0x2016AB1 VA: 0x20169B0
	|-RenderManager.GetStackPeek<object>
	|
	|-RVA: 0x2016A20 Offset: 0x2016B21 VA: 0x2016A20
	|-RenderManager.GetStackPeek<float>
	*/

	// RVA: 0x24CB5F0 Offset: 0x24CB6F1 VA: 0x24CB5F0
	private static void CommitScale() { }

	// RVA: 0x24CBC20 Offset: 0x24CBD21 VA: 0x24CBC20
	private static void CommitLodBias() { }

	// RVA: 0x24CC390 Offset: 0x24CC491 VA: 0x24CC390
	private static void CommitBlur() { }

	// RVA: 0x24CCAF0 Offset: 0x24CCBF1 VA: 0x24CCAF0
	private static void CommitColor() { }

	// RVA: 0x24CC6F0 Offset: 0x24CC7F1 VA: 0x24CC6F0
	private static void CommitColorRate() { }

	// RVA: 0x24CBF40 Offset: 0x24CC041 VA: 0x24CBF40
	private static void CommitCrossFadeAnimationDuration() { }

	// RVA: 0x24CCC60 Offset: 0x24CCD61 VA: 0x24CCC60
	public void .ctor() { }

	// RVA: 0x24CCC70 Offset: 0x24CCD71 VA: 0x24CCC70
	private static void .cctor() { }
}

