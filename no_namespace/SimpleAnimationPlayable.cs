// Namespace: 
private class SimpleAnimationPlayable.StateEnumerable.StateEnumerator : IEnumerator<SimpleAnimationPlayable.IState>, IEnumerator, IDisposable // TypeDefIndex: 6322
{
	// Fields
	private int m_Index; // 0x10
	private int m_Version; // 0x14
	private SimpleAnimationPlayable m_Owner; // 0x18

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	private SimpleAnimationPlayable.IState System.Collections.Generic.IEnumerator<SimpleAnimationPlayable.IState>.Current { get; }

	// Methods

	// RVA: 0x1C46240 Offset: 0x1C46341 VA: 0x1C46240
	public void .ctor(SimpleAnimationPlayable owner) { }

	// RVA: 0x1C48110 Offset: 0x1C48211 VA: 0x1C48110
	private bool IsValid() { }

	// RVA: 0x1C48140 Offset: 0x1C48241 VA: 0x1C48140
	private SimpleAnimationPlayable.IState GetCurrentHandle(int index) { }

	// RVA: 0x1C482D0 Offset: 0x1C483D1 VA: 0x1C482D0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1C482E0 Offset: 0x1C483E1 VA: 0x1C482E0 Slot: 4
	private SimpleAnimationPlayable.IState System.Collections.Generic.IEnumerator<SimpleAnimationPlayable.IState>.get_Current() { }

	// RVA: 0x1C482F0 Offset: 0x1C483F1 VA: 0x1C482F0 Slot: 5
	public void Dispose() { }

	// RVA: 0x1C48300 Offset: 0x1C48401 VA: 0x1C48300 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1C48090 Offset: 0x1C48191 VA: 0x1C48090 Slot: 8
	public void Reset() { }
}

// Namespace: 
public interface SimpleAnimationPlayable.IState // TypeDefIndex: 6324
{
	// Properties
	public abstract bool enabled { get; set; }
	public abstract float time { get; set; }
	public abstract float normalizedTime { get; set; }
	public abstract float speed { get; set; }
	public abstract string name { get; set; }
	public abstract float weight { get; set; }
	public abstract float length { get; }
	public abstract AnimationClip clip { get; }
	public abstract WrapMode wrapMode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsValid();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_enabled();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_enabled(bool value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_time();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_time(float value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_normalizedTime();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_normalizedTime(float value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_speed();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_speed(float value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_name(string value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float get_weight();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_weight(float value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float get_length();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract AnimationClip get_clip();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract WrapMode get_wrapMode();
}

// Namespace: 
private class SimpleAnimationPlayable.StateInfo // TypeDefIndex: 6326
{
	// Fields
	private bool m_Enabled; // 0x10
	private int m_Index; // 0x14
	private string m_StateName; // 0x18
	private bool m_Fading; // 0x20
	private float m_Time; // 0x24
	private float m_TargetWeight; // 0x28
	private float m_Weight; // 0x2C
	private float m_FadeSpeed; // 0x30
	private AnimationClip m_Clip; // 0x38
	private Playable m_Playable; // 0x40
	private WrapMode m_WrapMode; // 0x50
	private bool m_IsClone; // 0x54
	private bool m_ReadyForCleanup; // 0x55
	public SimpleAnimationPlayable.StateHandle m_ParentState; // 0x58
	private bool m_WeightDirty; // 0x60
	private bool m_EnabledDirty; // 0x61
	private bool m_TimeIsUpToDate; // 0x62

	// Properties
	public bool enabled { get; }
	public int index { get; set; }
	public string stateName { get; set; }
	public bool fading { get; }
	public float targetWeight { get; }
	public float weight { get; }
	public float fadeSpeed { get; }
	public float speed { get; set; }
	public float playableDuration { get; }
	public AnimationClip clip { get; }
	public bool isDone { get; }
	public Playable playable { get; }
	public WrapMode wrapMode { get; }
	public bool isClone { get; }
	public bool isReadyForCleanup { get; }
	public SimpleAnimationPlayable.StateHandle parentState { get; }
	public bool enabledDirty { get; }
	public bool weightDirty { get; }

	// Methods

	// RVA: 0x1C42620 Offset: 0x1C42721 VA: 0x1C42620
	public void Initialize(string name, AnimationClip clip, WrapMode wrapMode) { }

	// RVA: 0x1C447B0 Offset: 0x1C448B1 VA: 0x1C447B0
	public float GetTime() { }

	// RVA: 0x1C47930 Offset: 0x1C47A31 VA: 0x1C47930
	public void SetTime(float newTime) { }

	// RVA: 0x1C42C90 Offset: 0x1C42D91 VA: 0x1C42C90
	public void Enable() { }

	// RVA: 0x1C44890 Offset: 0x1C44991 VA: 0x1C44890
	public void Disable() { }

	// RVA: 0x1C42670 Offset: 0x1C42771 VA: 0x1C42670
	public void Pause() { }

	// RVA: 0x1C44690 Offset: 0x1C44791 VA: 0x1C44690
	public void Play() { }

	// RVA: 0x1C445F0 Offset: 0x1C446F1 VA: 0x1C445F0
	public void Stop() { }

	// RVA: 0x1C42CB0 Offset: 0x1C42DB1 VA: 0x1C42CB0
	public void ForceWeight(float weight) { }

	// RVA: 0x1C445E0 Offset: 0x1C446E1 VA: 0x1C445E0
	public void SetWeight(float weight) { }

	// RVA: 0x1C435A0 Offset: 0x1C436A1 VA: 0x1C435A0
	public void FadeTo(float weight, float speed) { }

	// RVA: 0x1C47A40 Offset: 0x1C47B41 VA: 0x1C47A40
	public void DestroyPlayable() { }

	// RVA: 0x1C438C0 Offset: 0x1C439C1 VA: 0x1C438C0
	public void SetAsCloneOf(SimpleAnimationPlayable.StateHandle handle) { }

	// RVA: 0x1C47AF0 Offset: 0x1C47BF1 VA: 0x1C47AF0
	public bool get_enabled() { }

	// RVA: 0x1C47B00 Offset: 0x1C47C01 VA: 0x1C47B00
	public int get_index() { }

	// RVA: 0x1C47B10 Offset: 0x1C47C11 VA: 0x1C47B10
	public void set_index(int value) { }

	// RVA: 0x1C47B20 Offset: 0x1C47C21 VA: 0x1C47B20
	public string get_stateName() { }

	// RVA: 0x1C47B30 Offset: 0x1C47C31 VA: 0x1C47B30
	public void set_stateName(string value) { }

	// RVA: 0x1C47B40 Offset: 0x1C47C41 VA: 0x1C47B40
	public bool get_fading() { }

	// RVA: 0x1C47B50 Offset: 0x1C47C51 VA: 0x1C47B50
	public float get_targetWeight() { }

	// RVA: 0x1C47B60 Offset: 0x1C47C61 VA: 0x1C47B60
	public float get_weight() { }

	// RVA: 0x1C47B70 Offset: 0x1C47C71 VA: 0x1C47B70
	public float get_fadeSpeed() { }

	// RVA: 0x1C44750 Offset: 0x1C44851 VA: 0x1C44750
	public float get_speed() { }

	// RVA: 0x1C45240 Offset: 0x1C45341 VA: 0x1C45240
	public void set_speed(float value) { }

	// RVA: 0x1C44830 Offset: 0x1C44931 VA: 0x1C44830
	public float get_playableDuration() { }

	// RVA: 0x1C47B80 Offset: 0x1C47C81 VA: 0x1C47B80
	public AnimationClip get_clip() { }

	// RVA: 0x1C47B90 Offset: 0x1C47C91 VA: 0x1C47B90
	public void SetPlayable(Playable playable) { }

	// RVA: 0x1C446F0 Offset: 0x1C447F1 VA: 0x1C446F0
	public bool get_isDone() { }

	// RVA: 0x1C47BA0 Offset: 0x1C47CA1 VA: 0x1C47BA0
	public Playable get_playable() { }

	// RVA: 0x1C47BB0 Offset: 0x1C47CB1 VA: 0x1C47BB0
	public WrapMode get_wrapMode() { }

	// RVA: 0x1C47BC0 Offset: 0x1C47CC1 VA: 0x1C47BC0
	public bool get_isClone() { }

	// RVA: 0x1C47BD0 Offset: 0x1C47CD1 VA: 0x1C47BD0
	public bool get_isReadyForCleanup() { }

	// RVA: 0x1C47BE0 Offset: 0x1C47CE1 VA: 0x1C47BE0
	public SimpleAnimationPlayable.StateHandle get_parentState() { }

	// RVA: 0x1C47BF0 Offset: 0x1C47CF1 VA: 0x1C47BF0
	public bool get_enabledDirty() { }

	// RVA: 0x1C47C00 Offset: 0x1C47D01 VA: 0x1C47C00
	public bool get_weightDirty() { }

	// RVA: 0x1C448B0 Offset: 0x1C449B1 VA: 0x1C448B0
	public void ResetDirtyFlags() { }

	// RVA: 0x1C44F80 Offset: 0x1C45081 VA: 0x1C44F80
	public void InvalidateTime() { }

	// RVA: 0x1C47C10 Offset: 0x1C47D11 VA: 0x1C47C10
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x8D280 Offset: 0x8D381 VA: 0x8D280
private sealed class SimpleAnimationPlayable.StateManagement.<>c__DisplayClass11_0 // TypeDefIndex: 6328
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x1C47C30 Offset: 0x1C47D31 VA: 0x1C47C30
	public void .ctor() { }

	// RVA: 0x1C48510 Offset: 0x1C48611 VA: 0x1C48510
	internal bool <FindState>b__0(SimpleAnimationPlayable.StateInfo s) { }
}

// Namespace: 
private struct SimpleAnimationPlayable.QueuedState // TypeDefIndex: 6330
{
	// Fields
	public SimpleAnimationPlayable.StateHandle state; // 0x0
	public float fadeTime; // 0x8

	// Methods

	// RVA: 0x1C43080 Offset: 0x1C43181 VA: 0x1C43080
	public void .ctor(SimpleAnimationPlayable.StateHandle s, float t) { }
}

