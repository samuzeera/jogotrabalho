using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    public float speed = 2.0f; // Velocidade do inimigo
    public float distance = 5.0f; // Distância total que o inimigo vai percorrer

    private Vector3 startPos; // Posição inicial do inimigo
    private Vector3 endPos; // Posição final do inimigo
    private bool movingRight = true; // Verifica se o inimigo está se movendo para a direita
    private Vector3 originalScale; // Escala original do inimigo
    private bool restartPlayer;
    
    void Start()
    {
        startPos = transform.position; // Define a posição inicial como a posição atual do inimigo
        endPos = startPos + Vector3.right * distance; // Calcula a posição final com base na distância especificada
        originalScale = transform.localScale; // Salva a escala original do inimigo
    }

    void Update()
    {
        // Move o inimigo da posição inicial para a posição final e vice-versa
        if (movingRight)
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        else
            transform.position = Vector3.MoveTowards(transform.position, startPos, speed * Time.deltaTime);

        // Se o inimigo alcançar a posição final, muda a direção de movimento
        if (transform.position == endPos)
        {
            movingRight = false;
            FlipEnemyDirection(false); // Vira o inimigo para a esquerda
        }
        else if (transform.position == startPos)
        {
            movingRight = true;
            FlipEnemyDirection(true); // Vira o inimigo para a direita
        }
    }

    // Função para virar o inimigo
    void FlipEnemyDirection(bool faceRight)
    {
        if (faceRight)
            transform.localScale = originalScale; // Mantém a escala original
        else
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z); // Inverte a escala no eixo x
    }
    
    
void OnCollisionEnter2D(Collision2D collision) {
    
    if (collision.gameObject.CompareTag("inimigo")==true) {
        

    }
}









}
