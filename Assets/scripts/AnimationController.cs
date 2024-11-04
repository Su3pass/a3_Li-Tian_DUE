using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    public Animator animator;      // Animator组件
    public Button playButton;      // 用于控制的按钮

    void Start()
    {
        // 确保Animator和Button已被设置
        if (playButton != null)
        {
            // 添加按钮点击事件监听
            playButton.onClick.AddListener(PlayAnimation);
        }
    }

    // 播放或切换动画的函数
    void PlayAnimation()
    {
        if (animator != null)
        {
            // 触发动画播放
            animator.SetTrigger("Play");  // 假设动画设置了一个 "Play" 触发器
        }
    }
}
