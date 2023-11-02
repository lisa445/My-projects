// Данная прогрмма преднзначена для планирования пользователем задач
using System;

struct Task
{
    private string taskname;
    public int priority;
    public string date;
    public string description;

    public void output()
    {
        ;
        Console.WriteLine($"Задание: {taskname} Приоритет: {priority} Дедлайн: {date} Описание задания: {description}");
    }

}

class Person
{
    public string name;
    public string surname;
    public string contact;

    public void outputperson()
    {
        ;
        Console.WriteLine($"Имя: {name} Фамилия: {surname} Контакты: {contact}");
    }
}

public class PlaningTasks
{
    public static void Main(string[] args)
    {
        //Инициализация структур и классов
        Task by_Lisa = new Task();
        Task by_other_student = new Task();

        by_Lisa.taskname = "Laboratories";
        by_Lisa.priority= 1;
        by_Lisa.date = "12.03.2025";
        by_Lisa.description = "Trying to do works";
        
        by_other_student.taskname = "Homework";
        by_other_student.priority = 5;
        by_other_student.date = "24.05.2020";
        by_other_student.description = "note done";

        Person Lisa = new Person();
        Lisa.name = "Veta";
        Lisa.surname = "Egorova";
        Lisa.contact = "@japanesepotatos";

        Lisa.outputperson(); //Вывод информации до изменения
        by_Lisa.output();

        Person Somebody = new Person();
        Somebody.name = "Other";
        Somebody.surname = "Student";
        Somebody.contact = "@tgchanel";

        //Изменение информации
        by_Lisa.priority = 2;
        by_Lisa.date = "01.04.2024";
        by_Lisa.description = "Написание кода для лабораторной работы";


        //Конец третьего задания

        //Задание 4

    }
}