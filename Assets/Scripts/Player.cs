using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    public static Vector2 movement;
  
    private Rigidbody2D rb;
    //Establishes the rigidbody variable


    private void  Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //gets the player's rigidbody component
        rb.gravityScale = 0;
        //sets gravity to zero on rigidbody2D
    }

    private void Update()
    {
        Input.GetKey("a");
    }

    public void PlantSeed ()
    {
        
    }
}
