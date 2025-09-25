using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : InteractableObject
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();                                           //���� ��� ���� ��ŸƮ �Լ��� �ѹ� ���� ��Ų��. 
        objectName = "���";
        interactionText = "[E] ��� ����";
        interactionType = InteractionType.Machine;

    }
    protected override void OperateMachine()
    {
        StartCoroutine(DoOperateMachine());
    }
    IEnumerator DoOperateMachine()
    {
        for(int i = 0; i < 50; i++)
        {
            transform.Rotate(new Vector3(0, 1, 0), 30);
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(0.1f);
    }
}
