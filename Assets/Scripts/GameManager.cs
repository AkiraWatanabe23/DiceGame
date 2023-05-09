using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("双六のマスの数")]
    [SerializeField] private int _gameSize = 30;

    private int[] _gameBoard = default;
    /// <summary> マスに分岐があるか </summary>
    private bool[] _isBranch = default;

    private static GameManager _instance = default;

    public static GameManager Instance => _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        _gameBoard = new int[_gameSize];
        _isBranch = new bool[_gameSize];
    }

    private void Update()
    {
        
    }
}
