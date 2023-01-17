// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent : UnityEventBase // TypeDefIndex: 3696
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x452900 Offset: 0x452A01 VA: 0x452900
	// RVA: 0x384B0A0 Offset: 0x384B1A1 VA: 0x384B0A0
	public void .ctor() { }

	// RVA: 0x384B190 Offset: 0x384B291 VA: 0x384B190
	public void AddListener(UnityAction call) { }

	// RVA: 0x384B290 Offset: 0x384B391 VA: 0x384B290
	public void RemoveListener(UnityAction call) { }

	// RVA: 0x384B2E0 Offset: 0x384B3E1 VA: 0x384B2E0 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x384B500 Offset: 0x384B601 VA: 0x384B500 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x384B210 Offset: 0x384B311 VA: 0x384B210
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x384B570 Offset: 0x384B671 VA: 0x384B570
	public void Invoke() { }
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 3698
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x452910 Offset: 0x452A11 VA: 0x452910
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF6630 Offset: 0x2DF6731 VA: 0x2DF6630
	|-UnityEvent<BaseEventData>..ctor
	|-UnityEvent<CinemachineBrain>..ctor
	|-UnityEvent<MessageEventArgs>..ctor
	|-UnityEvent<object>..ctor
	|-UnityEvent<string>..ctor
	|
	|-RVA: 0x2DF50B0 Offset: 0x2DF51B1 VA: 0x2DF50B0
	|-UnityEvent<bool>..ctor
	|
	|-RVA: 0x2DF5610 Offset: 0x2DF5711 VA: 0x2DF5610
	|-UnityEvent<Color>..ctor
	|
	|-RVA: 0x2DF5B90 Offset: 0x2DF5C91 VA: 0x2DF5B90
	|-UnityEvent<int>..ctor
	|
	|-RVA: 0x2DF60E0 Offset: 0x2DF61E1 VA: 0x2DF60E0
	|-UnityEvent<Int32Enum>..ctor
	|-UnityEvent<TouchScreenKeyboard.Status>..ctor
	|
	|-RVA: 0x2DF6B60 Offset: 0x2DF6C61 VA: 0x2DF6B60
	|-UnityEvent<float>..ctor
	|
	|-RVA: 0x2DF70C0 Offset: 0x2DF71C1 VA: 0x2DF70C0
	|-UnityEvent<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF50E0 Offset: 0x2DF51E1 VA: 0x2DF50E0
	|-UnityEvent<bool>.AddListener
	|
	|-RVA: 0x2DF6660 Offset: 0x2DF6761 VA: 0x2DF6660
	|-UnityEvent<CinemachineBrain>.AddListener
	|-UnityEvent<MessageEventArgs>.AddListener
	|-UnityEvent<object>.AddListener
	|
	|-RVA: 0x2DF5640 Offset: 0x2DF5741 VA: 0x2DF5640
	|-UnityEvent<Color>.AddListener
	|
	|-RVA: 0x2DF5BC0 Offset: 0x2DF5CC1 VA: 0x2DF5BC0
	|-UnityEvent<int>.AddListener
	|
	|-RVA: 0x2DF6110 Offset: 0x2DF6211 VA: 0x2DF6110
	|-UnityEvent<Int32Enum>.AddListener
	|
	|-RVA: 0x2DF6B90 Offset: 0x2DF6C91 VA: 0x2DF6B90
	|-UnityEvent<float>.AddListener
	|
	|-RVA: 0x2DF70F0 Offset: 0x2DF71F1 VA: 0x2DF70F0
	|-UnityEvent<Vector2>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF5130 Offset: 0x2DF5231 VA: 0x2DF5130
	|-UnityEvent<bool>.RemoveListener
	|
	|-RVA: 0x2DF66B0 Offset: 0x2DF67B1 VA: 0x2DF66B0
	|-UnityEvent<CinemachineBrain>.RemoveListener
	|-UnityEvent<MessageEventArgs>.RemoveListener
	|-UnityEvent<object>.RemoveListener
	|
	|-RVA: 0x2DF5690 Offset: 0x2DF5791 VA: 0x2DF5690
	|-UnityEvent<Color>.RemoveListener
	|
	|-RVA: 0x2DF5C10 Offset: 0x2DF5D11 VA: 0x2DF5C10
	|-UnityEvent<int>.RemoveListener
	|
	|-RVA: 0x2DF6160 Offset: 0x2DF6261 VA: 0x2DF6160
	|-UnityEvent<Int32Enum>.RemoveListener
	|
	|-RVA: 0x2DF6BE0 Offset: 0x2DF6CE1 VA: 0x2DF6BE0
	|-UnityEvent<float>.RemoveListener
	|
	|-RVA: 0x2DF7140 Offset: 0x2DF7241 VA: 0x2DF7140
	|-UnityEvent<Vector2>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF66F0 Offset: 0x2DF67F1 VA: 0x2DF66F0
	|-UnityEvent<BaseEventData>.FindMethod_Impl
	|-UnityEvent<CinemachineBrain>.FindMethod_Impl
	|-UnityEvent<MessageEventArgs>.FindMethod_Impl
	|-UnityEvent<object>.FindMethod_Impl
	|-UnityEvent<string>.FindMethod_Impl
	|
	|-RVA: 0x2DF5170 Offset: 0x2DF5271 VA: 0x2DF5170
	|-UnityEvent<bool>.FindMethod_Impl
	|
	|-RVA: 0x2DF56D0 Offset: 0x2DF57D1 VA: 0x2DF56D0
	|-UnityEvent<Color>.FindMethod_Impl
	|
	|-RVA: 0x2DF5C50 Offset: 0x2DF5D51 VA: 0x2DF5C50
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-RVA: 0x2DF61A0 Offset: 0x2DF62A1 VA: 0x2DF61A0
	|-UnityEvent<Int32Enum>.FindMethod_Impl
	|-UnityEvent<TouchScreenKeyboard.Status>.FindMethod_Impl
	|
	|-RVA: 0x2DF6C20 Offset: 0x2DF6D21 VA: 0x2DF6C20
	|-UnityEvent<float>.FindMethod_Impl
	|
	|-RVA: 0x2DF7180 Offset: 0x2DF7281 VA: 0x2DF7180
	|-UnityEvent<Vector2>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF6800 Offset: 0x2DF6901 VA: 0x2DF6800
	|-UnityEvent<BaseEventData>.GetDelegate
	|-UnityEvent<CinemachineBrain>.GetDelegate
	|-UnityEvent<MessageEventArgs>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<string>.GetDelegate
	|
	|-RVA: 0x2DF5280 Offset: 0x2DF5381 VA: 0x2DF5280
	|-UnityEvent<bool>.GetDelegate
	|
	|-RVA: 0x2DF57E0 Offset: 0x2DF58E1 VA: 0x2DF57E0
	|-UnityEvent<Color>.GetDelegate
	|
	|-RVA: 0x2DF5D60 Offset: 0x2DF5E61 VA: 0x2DF5D60
	|-UnityEvent<int>.GetDelegate
	|
	|-RVA: 0x2DF62B0 Offset: 0x2DF63B1 VA: 0x2DF62B0
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<TouchScreenKeyboard.Status>.GetDelegate
	|
	|-RVA: 0x2DF6D30 Offset: 0x2DF6E31 VA: 0x2DF6D30
	|-UnityEvent<float>.GetDelegate
	|
	|-RVA: 0x2DF7290 Offset: 0x2DF7391 VA: 0x2DF7290
	|-UnityEvent<Vector2>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF5300 Offset: 0x2DF5401 VA: 0x2DF5300
	|-UnityEvent<bool>.GetDelegate
	|
	|-RVA: 0x2DF5860 Offset: 0x2DF5961 VA: 0x2DF5860
	|-UnityEvent<Color>.GetDelegate
	|
	|-RVA: 0x2DF5DE0 Offset: 0x2DF5EE1 VA: 0x2DF5DE0
	|-UnityEvent<int>.GetDelegate
	|
	|-RVA: 0x2DF6330 Offset: 0x2DF6431 VA: 0x2DF6330
	|-UnityEvent<Int32Enum>.GetDelegate
	|
	|-RVA: 0x2DF6880 Offset: 0x2DF6981 VA: 0x2DF6880
	|-UnityEvent<object>.GetDelegate
	|
	|-RVA: 0x2DF6DB0 Offset: 0x2DF6EB1 VA: 0x2DF6DB0
	|-UnityEvent<float>.GetDelegate
	|
	|-RVA: 0x2DF7310 Offset: 0x2DF7411 VA: 0x2DF7310
	|-UnityEvent<Vector2>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF6940 Offset: 0x2DF6A41 VA: 0x2DF6940
	|-UnityEvent<BaseEventData>.Invoke
	|-UnityEvent<CinemachineBrain>.Invoke
	|-UnityEvent<MessageEventArgs>.Invoke
	|-UnityEvent<object>.Invoke
	|-UnityEvent<string>.Invoke
	|
	|-RVA: 0x2DF53C0 Offset: 0x2DF54C1 VA: 0x2DF53C0
	|-UnityEvent<bool>.Invoke
	|
	|-RVA: 0x2DF5920 Offset: 0x2DF5A21 VA: 0x2DF5920
	|-UnityEvent<Color>.Invoke
	|
	|-RVA: 0x2DF5EA0 Offset: 0x2DF5FA1 VA: 0x2DF5EA0
	|-UnityEvent<int>.Invoke
	|
	|-RVA: 0x2DF63F0 Offset: 0x2DF64F1 VA: 0x2DF63F0
	|-UnityEvent<Int32Enum>.Invoke
	|-UnityEvent<TouchScreenKeyboard.Status>.Invoke
	|
	|-RVA: 0x2DF6E70 Offset: 0x2DF6F71 VA: 0x2DF6E70
	|-UnityEvent<float>.Invoke
	|
	|-RVA: 0x2DF73D0 Offset: 0x2DF74D1 VA: 0x2DF73D0
	|-UnityEvent<Vector2>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 3700
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x452920 Offset: 0x452A21 VA: 0x452920
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7620 Offset: 0x2DF7721 VA: 0x2DF7620
	|-UnityEvent<ICinemachineCamera, ICinemachineCamera>..ctor
	|-UnityEvent<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0, T1> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7650 Offset: 0x2DF7751 VA: 0x2DF7650
	|-UnityEvent<object, object>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0, T1> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF76A0 Offset: 0x2DF77A1 VA: 0x2DF76A0
	|-UnityEvent<object, object>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF76E0 Offset: 0x2DF77E1 VA: 0x2DF76E0
	|-UnityEvent<ICinemachineCamera, ICinemachineCamera>.FindMethod_Impl
	|-UnityEvent<object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7840 Offset: 0x2DF7941 VA: 0x2DF7840
	|-UnityEvent<ICinemachineCamera, ICinemachineCamera>.GetDelegate
	|-UnityEvent<object, object>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF78C0 Offset: 0x2DF79C1 VA: 0x2DF78C0
	|-UnityEvent<object, object>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7980 Offset: 0x2DF7A81 VA: 0x2DF7980
	|-UnityEvent<ICinemachineCamera, ICinemachineCamera>.Invoke
	|-UnityEvent<object, object>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 3702
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x452930 Offset: 0x452A31 VA: 0x452930
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7BF0 Offset: 0x2DF7CF1 VA: 0x2DF7BF0
	|-UnityEvent<object, int, int>..ctor
	|-UnityEvent<string, int, int>..ctor
	|
	|-RVA: 0x2DF82B0 Offset: 0x2DF83B1 VA: 0x2DF82B0
	|-UnityEvent<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0, T1, T2> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7C20 Offset: 0x2DF7D21 VA: 0x2DF7C20
	|-UnityEvent<object, int, int>.AddListener
	|
	|-RVA: 0x2DF82E0 Offset: 0x2DF83E1 VA: 0x2DF82E0
	|-UnityEvent<object, object, object>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0, T1, T2> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7C70 Offset: 0x2DF7D71 VA: 0x2DF7C70
	|-UnityEvent<object, int, int>.RemoveListener
	|
	|-RVA: 0x2DF8330 Offset: 0x2DF8431 VA: 0x2DF8330
	|-UnityEvent<object, object, object>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7CB0 Offset: 0x2DF7DB1 VA: 0x2DF7CB0
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|-UnityEvent<string, int, int>.FindMethod_Impl
	|
	|-RVA: 0x2DF8370 Offset: 0x2DF8471 VA: 0x2DF8370
	|-UnityEvent<object, object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7E60 Offset: 0x2DF7F61 VA: 0x2DF7E60
	|-UnityEvent<object, int, int>.GetDelegate
	|-UnityEvent<string, int, int>.GetDelegate
	|
	|-RVA: 0x2DF8520 Offset: 0x2DF8621 VA: 0x2DF8520
	|-UnityEvent<object, object, object>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7EE0 Offset: 0x2DF7FE1 VA: 0x2DF7EE0
	|-UnityEvent<object, int, int>.GetDelegate
	|
	|-RVA: 0x2DF85A0 Offset: 0x2DF86A1 VA: 0x2DF85A0
	|-UnityEvent<object, object, object>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF7FA0 Offset: 0x2DF80A1 VA: 0x2DF7FA0
	|-UnityEvent<object, int, int>.Invoke
	|-UnityEvent<string, int, int>.Invoke
	|
	|-RVA: 0x2DF8660 Offset: 0x2DF8761 VA: 0x2DF8660
	|-UnityEvent<object, object, object>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 3704
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x452940 Offset: 0x452A41 VA: 0x452940
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF8910 Offset: 0x2DF8A11 VA: 0x2DF8910
	|-UnityEvent<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0, T1, T2, T3> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF8940 Offset: 0x2DF8A41 VA: 0x2DF8940
	|-UnityEvent<object, object, object, object>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0, T1, T2, T3> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF8990 Offset: 0x2DF8A91 VA: 0x2DF8990
	|-UnityEvent<object, object, object, object>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF89D0 Offset: 0x2DF8AD1 VA: 0x2DF89D0
	|-UnityEvent<object, object, object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF8BC0 Offset: 0x2DF8CC1 VA: 0x2DF8BC0
	|-UnityEvent<object, object, object, object>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF8C40 Offset: 0x2DF8D41 VA: 0x2DF8C40
	|-UnityEvent<object, object, object, object>.GetDelegate
	*/
}

