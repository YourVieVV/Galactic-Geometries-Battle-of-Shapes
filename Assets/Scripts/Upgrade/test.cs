/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private History history;
    private Program3 program3 = new Program3();
    [SerializeField]
    public List<Program3> list = new List<Program3>(); //List класса Program3. Содержит 4 параметра(string, string, string, int). Аналог листа который мне нужно сохранить. Тоесть, this.list играет только посредническую роль! Наверное можно сделать используя всего 1 основной лист, но пока мне это не нужно(буду смотреть при оптимизации проэкта). У меня он history.list

    public void Save(string datapath) //метод сохранения. Принимает путь к файлу.
    {
        list.Clear(); //Очищаем лист "посредник"
        string[] data = new string[history.list.Count]; //Создаём массив длинной в основной лист
        for (int i = 0; i < history.list.Count; i++)
        {
            list.Add(new Program3(history.list[i].nameProgram, history.list[i].descriptionProgram, history.list[i].sellProgram, history.list[i].idProgram)); //присваивание посреднику параметры основного
            data[i] = JsonUtility.ToJson(list[i]); //записываем Json в массив строк
        }

        File.WriteAllLines(datapath, data); //Запись в файл

    }

    public void Load(string datapath) //метод загрузки
    {
        list.Clear();
        history.list.Clear();
        string[] data = File.ReadAllLines(datapath); //Сдеся может ошибка, но вроде работает( Не знаю, задастся ли длинна новому массиву). Крч, Считываем файл в массив строк
        for (int i = 0; i < data.Length; i++)
        {
            program3 = JsonUtility.FromJson<Program3>(data[i]); //Десериализуем из JSON в объект

            history.list.Add(new Program(program3.nameProgram, program3.descriptionProgram, program3.sellProgram, program3.idProgram)); //И записываем в основной лист все параметры. АЛИЛУЯ. Часы моих мучений окончены!
        }
    }
}
*/