using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// VR互動物件
/// 1. VR注視點看到此物件 Enter
/// 2. VR注視點看到後離開此物件 Exit
/// 3. VR注視點看到此物件並點選互動按鈕 Click
/// </summary>
public class VRunteractionObject : MonoBehaviour
{
    // unity 事件用法
    // 1. 引用 Events 命名空間
    // 2. 定義 Unity Events 類型欄位並設公開
    // 3. 想要執行此事件內容的地方呼叫 事件.Invoke();
    // 4. 屬性面板設定事件內容
    [Header("事件：看到、離開與點擊"), Space(10)]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent Click;

    /// <summary>
    /// VR注視點看到此物件 Enter
    /// </summary>
    public void OnPointerEnter()
    {
        print("注視點看到");
        onEnter.Invoke();
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
