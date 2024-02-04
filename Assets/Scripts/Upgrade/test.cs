/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private History history;
    private Program3 program3 = new Program3();
    [SerializeField]
    public List<Program3> list = new List<Program3>(); //List ������ Program3. �������� 4 ���������(string, string, string, int). ������ ����� ������� ��� ����� ���������. ������, this.list ������ ������ �������������� ����! �������� ����� ������� ��������� ����� 1 �������� ����, �� ���� ��� ��� �� �����(���� �������� ��� ����������� �������). � ���� �� history.list

    public void Save(string datapath) //����� ����������. ��������� ���� � �����.
    {
        list.Clear(); //������� ���� "���������"
        string[] data = new string[history.list.Count]; //������ ������ ������� � �������� ����
        for (int i = 0; i < history.list.Count; i++)
        {
            list.Add(new Program3(history.list[i].nameProgram, history.list[i].descriptionProgram, history.list[i].sellProgram, history.list[i].idProgram)); //������������ ���������� ��������� ���������
            data[i] = JsonUtility.ToJson(list[i]); //���������� Json � ������ �����
        }

        File.WriteAllLines(datapath, data); //������ � ����

    }

    public void Load(string datapath) //����� ��������
    {
        list.Clear();
        history.list.Clear();
        string[] data = File.ReadAllLines(datapath); //����� ����� ������, �� ����� ��������( �� ����, �������� �� ������ ������ �������). ���, ��������� ���� � ������ �����
        for (int i = 0; i < data.Length; i++)
        {
            program3 = JsonUtility.FromJson<Program3>(data[i]); //������������� �� JSON � ������

            history.list.Add(new Program(program3.nameProgram, program3.descriptionProgram, program3.sellProgram, program3.idProgram)); //� ���������� � �������� ���� ��� ���������. ������. ���� ���� ������� ��������!
        }
    }
}
*/