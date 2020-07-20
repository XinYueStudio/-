 
 using UnityEngine;


[RequireComponent(typeof(Animation))]
public class AnimationFrame : MonoBehaviour
{
    Animation _animationTimeline;

    public Animation animationTimeline
    {
        get
        {
            if (_animationTimeline == null)
            {
                _animationTimeline = GetComponent<Animation>();
            }
            return _animationTimeline;
        }
    }
    public string AnimationName;

    public void SetFrame(float frame)
    {
        animationTimeline[AnimationName].speed = 0;
        animationTimeline[AnimationName].time = frame;
        animationTimeline.Play(AnimationName);
    }

    [Range(0.0f, 1.0f)]
    public float Frame = 0;
    float mFrame = 0;
    public void Update()
    {
        if (mFrame != Frame)
        {
            SetFrame(Frame);
            mFrame = Frame;
        }
    }
}
 