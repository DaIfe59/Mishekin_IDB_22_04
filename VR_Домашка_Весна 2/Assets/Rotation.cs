using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator mAnimator;




    public void ActivateAnimation()
    {
        mAnimator.SetBool("Rotate", true);




    }

    public void DeactiveAnimation()
    {

        mAnimator.SetBool("Rotate", false);


    }
}
