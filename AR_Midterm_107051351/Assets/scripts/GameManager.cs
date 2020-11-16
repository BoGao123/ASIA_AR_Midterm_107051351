using UnityEngine;

public class GameManager : MonoBehaviour
{
    //[Header]("名稱")
    [Header("MAN")]
    public Transform man;
    [Header("MAN02")]
    public Transform man02;
    [Header("虛擬搖桿")]
    public FixedJoystick Joystick;
    [Header("旋轉速度"), Range(0f, 10f)]
    public float Speed = 1.5f;
    [Header("縮放"), Range(0.1f, 1f)]
    public float Size = 0f;
    [Header("MAN動畫元件")]
    public Animator animan;
    [Header("MAN02動畫元件")]
    public Animator animan02;

    private void Start()
    {
        
    }
    private void Update()
    {
        
        
        man.Rotate(0, Joystick.Horizontal * Speed, 0);
        man02.Rotate(0, Joystick.Horizontal * Speed, 0);
        man.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * Size;
        man.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(man.localScale.x, 0.5f, 2f);
        man02.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * Size;
        man02.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(man02.localScale.x, 0.5f, 2f);

    }


    
    public void PlayAnimation(string aniname)
    {
        
        animan.SetTrigger(aniname);
        animan02.SetTrigger(aniname);
    }
}
