using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    [SerializeField] Transform bg1;
    [SerializeField] Transform bg2;
    [SerializeField] float speed = 2f;

    float bg1Width;
    float bg2Width;

    void Start()
    {
        bg1Width = bg1.GetComponent<SpriteRenderer>().bounds.size.x;
        bg2Width = bg2.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        bg1.Translate(Vector3.left * speed * Time.deltaTime);
        bg2.Translate(Vector3.left * speed * Time.deltaTime);

        if (bg1.position.x < -bg1Width)
            bg1.position = new Vector3(bg2.position.x + bg2Width, bg1.position.y, bg1.position.z);

        if (bg2.position.x < -bg2Width)
            bg2.position = new Vector3(bg1.position.x + bg1Width, bg2.position.y, bg2.position.z);
    }
}
