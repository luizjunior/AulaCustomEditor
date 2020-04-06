using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CriaAluno : MonoBehaviour
{
    //-------------------------------------------------
    [MenuItem("GameLoot/Cria Aluno")]
    public static void ExecutaCriarAluno()
    {
        GameObject aluno = GameObject.CreatePrimitive(PrimitiveType.Cube);
        aluno.AddComponent<Aluno>();
    }

    //-------------------------------------------------
    [MenuItem("GameLoot/Apaga Aluno")]
    public static void DeletaAluno()
    {
        if (Selection.activeGameObject != null)
        {
            Aluno aluno = Selection.activeGameObject.GetComponent<Aluno>();
            if (aluno != null)
            {
                DestroyImmediate(aluno.gameObject);
            }
            else
            {
                Debug.LogWarning("Objeto selecionado nao eh aluno...");
            }
        }
        else
        {
            Debug.LogWarning("Nenhum aluno selecionado...");
        }
    }

    //-------------------------------------------------
    [MenuItem("GameLoot/Reseta Aluno")]
    public static void ResetaAluno()
    {
        if (Selection.activeGameObject != null)
        {
            Aluno aluno = Selection.activeGameObject.GetComponent<Aluno>();
            if (aluno != null)
            {
                aluno.ResetaDados();
            }
            else
            {
                Debug.LogWarning("Objeto selecionado nao eh aluno...");
            }
        }
        else
        {
            Debug.LogWarning("Nenhum aluno selecionado...");
        }
    }
}
