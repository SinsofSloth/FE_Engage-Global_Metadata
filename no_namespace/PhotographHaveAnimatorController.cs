// Namespace: 
public sealed class PhotographHaveAnimatorController.UpdateAnime : MulticastDelegate // TypeDefIndex: 11483
{
	// Methods

	// RVA: 0x1F1DBA0 Offset: 0x1F1DCA1 VA: 0x1F1DBA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F1DBC0 Offset: 0x1F1DCC1 VA: 0x1F1DBC0 Slot: 13
	public virtual void Invoke(float time) { }

	// RVA: 0x1F1DDF0 Offset: 0x1F1DEF1 VA: 0x1F1DDF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(float time, AsyncCallback callback, object object) { }

	// RVA: 0x1F1DE80 Offset: 0x1F1DF81 VA: 0x1F1DE80 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PhotographHaveAnimatorController.UpdateFaceAnime : MulticastDelegate // TypeDefIndex: 11484
{
	// Methods

	// RVA: 0x1F1DE90 Offset: 0x1F1DF91 VA: 0x1F1DE90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F1DEB0 Offset: 0x1F1DFB1 VA: 0x1F1DEB0 Slot: 13
	public virtual void Invoke(string faceAnime) { }

	// RVA: 0x1F1E210 Offset: 0x1F1E311 VA: 0x1F1E210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string faceAnime, AsyncCallback callback, object object) { }

	// RVA: 0x1F1E240 Offset: 0x1F1E341 VA: 0x1F1E240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum PhotographHaveAnimatorController.FaceAnime // TypeDefIndex: 11485
{
	// Fields
	public int value__; // 0x0
	public const PhotographHaveAnimatorController.FaceAnime Angry = 0;
	public const PhotographHaveAnimatorController.FaceAnime Die = 1;
	public const PhotographHaveAnimatorController.FaceAnime Normal = 2;
	public const PhotographHaveAnimatorController.FaceAnime Pain = 3;
	public const PhotographHaveAnimatorController.FaceAnime Relax = 4;
	public const PhotographHaveAnimatorController.FaceAnime Sad = 5;
	public const PhotographHaveAnimatorController.FaceAnime Serious = 6;
	public const PhotographHaveAnimatorController.FaceAnime Shy = 7;
	public const PhotographHaveAnimatorController.FaceAnime Smile = 8;
	public const PhotographHaveAnimatorController.FaceAnime StandBy = 9;
	public const PhotographHaveAnimatorController.FaceAnime Status = 10;
	public const PhotographHaveAnimatorController.FaceAnime Strike = 11;
	public const PhotographHaveAnimatorController.FaceAnime Surprise = 12;
}

