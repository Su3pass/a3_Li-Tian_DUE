using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    public Animator animator;      // Animator���
    public Button playButton;      // ���ڿ��Ƶİ�ť

    void Start()
    {
        // ȷ��Animator��Button�ѱ�����
        if (playButton != null)
        {
            // ��Ӱ�ť����¼�����
            playButton.onClick.AddListener(PlayAnimation);
        }
    }

    // ���Ż��л������ĺ���
    void PlayAnimation()
    {
        if (animator != null)
        {
            // ������������
            animator.SetTrigger("Play");  // ���趯��������һ�� "Play" ������
        }
    }
}
