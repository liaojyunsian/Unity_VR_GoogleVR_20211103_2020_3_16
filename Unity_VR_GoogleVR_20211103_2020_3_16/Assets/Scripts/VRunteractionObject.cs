using UnityEngine;

/// <summary>
/// VR互動物件
/// 1. VR注視點看到此物件 Enter
/// 2. VR注視點看到後離開此物件 Exit
/// 3. VR注視點看到此物件並點選互動按鈕 Click
/// </summary>
public class VRunteractionObject : MonoBehaviour
{

    /// <summary>
    /// VR注視點看到此物件 Enter
    /// </summary>
    public void OnPointerEnter()
    {
        print("注視點看到");
    }

    /// <summary>
    /// VR注視點看到後離開此物件 Exit
    /// </summary>
    public void OnPointerExit()
    {
        print("注視點離開");

    }

    /// <summary>
    /// VR注視點看到此物件並點選互動按鈕 Click
    /// </summary>
    public void OnPointerClick()
    {
        print("注視點點擊");
    }







}
