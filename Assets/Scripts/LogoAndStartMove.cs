using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrimeTween;

public class LogoAndStartMove : MonoBehaviour
{
    [Header("初始坐标")]
    public Vector2 initPos;
    [Header("结束坐标")]
    public Vector2 endPos;
    [Header("动画时长")]
    public float animationDuration;
    
    void Start()
    {
        Sequence.Create()
            .ChainCallback(target: this, tarhet =>
            {
                transform.localPosition = initPos;
            })
            .Chain(Tween.LocalPosition(transform, endPos, animationDuration, ease:Ease.InOutSine));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveTo()
    {
        Sequence.Create()
            .ChainCallback(target: this, tarhet =>
            {
                transform.localPosition = initPos;
            })
            .Chain(Tween.LocalPosition(transform, endPos, animationDuration, ease:Ease.InOutSine));
    }
}
