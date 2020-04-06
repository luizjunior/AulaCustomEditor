using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Campus
{
    [InspectorName("Campinas")] CAMPUS1,
    [InspectorName("Indaiatuba")] CAMPUS2,
    [InspectorName("Sorocaba")] CAMPUS3
}

public class Aluno : MonoBehaviour
{
    [Header("____________ DADOS CADASTRAIS ____________")]
    [Min(0)] public int ra;
    [Range(0.0f,10.0f)] public float nota;
    public Campus campus;
    public string nome;

    [Header("____________ COMPONENTES VISUAIS ____________")]
    public Material myMaterial = null;

    void Start()
    {
        
    }

    //-----------------------------------------------------
    public void ResetaDados()
    {
        nome = "Aluno";
        campus = Campus.CAMPUS1;
        nota = 0;
        ra = 0;
        AtualizaCor();
    }

    //-----------------------------------------------------
    //OnValidate executa toda vez que uma variavel publica
    //tem o seu valor modificado
    //nao eh executado durante a build/play
    //------------------------------
    private void OnValidate()
    {
        AtualizaCor();
    }

    //-----------------------------------------------------
    public void AtualizaCor()
    {
        Renderer renderer = GetComponent<Renderer>();
        gameObject.name = nome;

        if (myMaterial == null)
        {
            myMaterial = renderer.material;
        }

        switch (campus)
        {
            case Campus.CAMPUS1:
                myMaterial.color = Color.red;
                break;
            case Campus.CAMPUS2:
                myMaterial.color = Color.green;
                break;
            case Campus.CAMPUS3:
                myMaterial.color = Color.blue;
                break;
        }
    }
}
