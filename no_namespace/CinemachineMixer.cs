// Namespace: 
public sealed class CinemachineMixer.MasterDirectorDelegate : MulticastDelegate // TypeDefIndex: 5725
{
	// Methods

	// RVA: 0x1A8AB40 Offset: 0x1A8AC41 VA: 0x1A8AB40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A8AB60 Offset: 0x1A8AC61 VA: 0x1A8AB60 Slot: 13
	public virtual PlayableDirector Invoke() { }

	// RVA: 0x1A8AD70 Offset: 0x1A8AE71 VA: 0x1A8AD70 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1A8ADA0 Offset: 0x1A8AEA1 VA: 0x1A8ADA0 Slot: 15
	public virtual PlayableDirector EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal sealed class CinemachineMixer : PlayableBehaviour // TypeDefIndex: 5726
{
	// Fields
	public static CinemachineMixer.MasterDirectorDelegate GetMasterPlayableDirector; // 0x0
	private CinemachineBrain mBrain; // 0x10
	private int mBrainOverrideId; // 0x18
	private bool mPreviewPlay; // 0x1C

	// Methods

	// RVA: 0x1BA1360 Offset: 0x1BA1461 VA: 0x1BA1360 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x1BA1400 Offset: 0x1BA1501 VA: 0x1BA1400 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x1BA1410 Offset: 0x1BA1511 VA: 0x1BA1410 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x1BA1B90 Offset: 0x1BA1C91 VA: 0x1BA1B90
	private float GetDeltaTime(float deltaTime) { }

	// RVA: 0x1BA1CA0 Offset: 0x1BA1DA1 VA: 0x1BA1CA0
	public void .ctor() { }
}

