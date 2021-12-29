using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CountDownAndDoSomething : MonoBehaviour
{
    #region ���P�ݩ�
    [Header("�˼Ʈɶ�"), Range(1, 5)]
    public float timeCounDown = 3;
    [Header("�˼ƫ�ƥ�")]
    public UnityEvent onTimeUp;
    [Header("����")]
    public Image imgBar;

    private float timeMax;
    /// <summary>
    /// �}�l�˼ơGtrue �}�l�Bfalse ����
    /// Unity Event �i�H�s��
    /// 1. ���骫��s�����󤺪� API
    /// 2. �s����k�ȭ��G�L�Ϊ̤@�ӰѼơD������������� (������)
    /// 3. �s�����}�ݩʡG������������� (������)
    /// </summary>
    public bool startCountDown { get; set; }
    #endregion
    #region �˼ƥ\��
    private void Awake()
    {
        timeMax = timeCounDown;
    }

    private void Update()
    {
        CountDown();
    }

    /// <summary>
    /// �p�ɾ�
    /// </summary>
    private float timer;

    /// <summary>
    /// �˼ƭp�ɥ\��
    /// </summary>
    private void CountDown()
    {
        if (startCountDown)//�p�G �}�l �˼�
        {
            if (timer < timeCounDown)//�p�G �p�ɾ� �p�� �˼Ʈɶ�
            {
                timer += Time.deltaTime;//�֥[�ɶ� (�� Update ���I�s)
            }
            else
            {
                onTimeUp.Invoke();//�_�h �p�ɾ� �j�󵥩� �˼Ʈɶ� �N �I�s�ƥ�
            }

            imgBar.fillAmount = timer / timeMax;//���� = ��e�ɶ� / �̤j�ɶ�
        }
        else//�_�h �S���ݵ۫��s �N����
        {
            print("12313213");
            timer = 0;//�p�ɾ��k�s
            imgBar.fillAmount = 0;//�����k�s
        }
    }
    #endregion
}
