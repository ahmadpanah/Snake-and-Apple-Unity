using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private Snake snake;
    private LevelGrid levelGrid;
    void Start()
    {   
        levelGrid = new LevelGrid(20,20);

        snake.Setup(levelGrid);
        levelGrid.Setup(snake);
    }
    void Update()
    {
        
    }
}
