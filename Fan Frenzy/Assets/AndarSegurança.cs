using UnityEngine;

public class AndarSegurança : MonoBehaviour
{
    public float velocidade = 3.0f;
    public float tempoEspera = 2.0f; // Tempo que o NPC espera antes de voltar

    private bool indoParaDireita = true;
    private float tempoPassado = 0.0f;

    void Update()
    {
        // Move o NPC
        MoverNPC();

        // Verifica se é hora de mudar de direção
        VerificarMudancaDirecao();
    }

    void MoverNPC()
    {
        // Determina a direção do movimento
        Vector3 direcaoMovimento = indoParaDireita ? Vector3.right : Vector3.left;

        // Move o NPC na direção
        transform.Translate(direcaoMovimento * velocidade * Time.deltaTime);
    }

    void VerificarMudancaDirecao()
    {
        // Incrementa o tempo passado desde a última mudança de direção
        tempoPassado += Time.deltaTime;

        // Se o tempo passado for maior que o tempo de espera, inverte a direção
        if (tempoPassado >= tempoEspera)
        {
            indoParaDireita = !indoParaDireita;
            tempoPassado = 0.0f; // Reinicia o tempo passado
        }
    }
}