using UnityEngine;

/// <summary>
/// VR���ʪ���
/// 1. VR�`���I�ݨ즹���� Enter
/// 2. VR�`���I�ݨ�����}������ Exit
/// 3. VR�`���I�ݨ즹������I�郎�ʫ��s Click
/// </summary>
public class VRunteractionObject : MonoBehaviour
{

    /// <summary>
    /// VR�`���I�ݨ즹���� Enter
    /// </summary>
    public void OnPointerEnter()
    {
        print("�`���I�ݨ�");
    }

    /// <summary>
    /// VR�`���I�ݨ�����}������ Exit
    /// </summary>
    public void OnPointerExit()
    {
        print("�`���I���}");

    }

    /// <summary>
    /// VR�`���I�ݨ즹������I�郎�ʫ��s Click
    /// </summary>
    public void OnPointerClick()
    {
        print("�`���I�I��");
    }







}
