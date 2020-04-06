using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Aluno))]
public class AlunoEditor : Editor
{
    private Aluno component = null;

    public override void OnInspectorGUI()
    {
        //desenha o inspector com as variaveis globais
        base.OnInspectorGUI();

        //acessa o component da classe que estamos querendo usar
        component = (Aluno)target;

        //faz um espacamento de 20 pixels
        GUILayout.Space(20);

        //cria um botao no inspector
        if (GUILayout.Button("Reseta Aluno"))
        {
            //caso o botao seja clicado, acessa o aluno
            component.ResetaDados();
        }
    }
}
