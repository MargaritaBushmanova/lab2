using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Catalog
{
    private List<Composition> compositions;
    private string menu;
    private uint part;
    string input2, input3;
    public Catalog()
    {
        compositions = new List<Composition>();
        menu = string.Empty;
        part = 0;
    }

    public string getRequest()
    {
        string request;
        
        if(menu=="search" && part==1)
            request = "Введите шаблон для поиска музыкальной композиции в каталоге: "; //search part 1
        else if (menu == "add" && part == 1)
            request = "Введите имя автора: "; //add part 1
        else if (menu == "add" && part == 2)
            request = "Введите название композиции: "; //add part 2
        else if (menu == "del" && part == 1)
            request = "Введите полное название композиции в каталоге: "; //del part 1
        else
        {
            part = 0;
            menu = string.Empty;
            request = "Введите команду: ";
        }
        return request; 
    }
    public string setResponse( string response )
    {
        string warning = string.Empty;
        part++;
        if (part==1)        menu   = response;
        else if(part==2)    input2 = response;
        if (part == 3)      input3 = response;
        
        switch (menu)
        {
            case "list":
                part = 0;       //Вывод каталога на печать
                foreach (Composition item in compositions)
                {
                    warning += item.ToString() + "\n";
                }
                break;
            case "search":
                if (part == 2)
                {
                    part = 0;       //Выполнение поиска по шаблону
                    foreach (Composition item in compositions)
                    {
                        if (item.ToString().Contains(input2))
                        {
                            warning += item.ToString() + "\n";
                        }
                    }
                }
                break;
            case "add":
                if (part == 3)
                {
                    part = 0;   //Добавление композиции
                    compositions.Add(new Composition(input2, input3));
                }
                break;
            case "del":
                if (part == 2)
                {
                    part = 0; //Выполнение поиска по полному названию и удаление
                    foreach (Composition item in compositions)
                    {
                        if (input2 == item.ToString())
                        {
                            compositions.Remove(item);
                            break;
                        }
                    }
                }
                break;
            default:
                menu = string.Empty;
                part= 0;
                warning = "Введена некорректная команда!!!";
                break;
        }

        return warning;
    }
 
/*
    public Calculator(double initialResult)
    {
        operations = new List<Operation>();
        result = initialResult;
    }

    public void Calculate()
    {
        foreach (var operation in operations)
        {
            switch (operation.Operator)
            {
                case '+':
                    result += operation.Operand;
                    break;
                case '-':
                    result -= operation.Operand;
                    break;
                case '*':
                    result *= operation.Operand;
                    break;
                case '/':
                    result /= operation.Operand;
                    break;
            }
        }
    }

    public void AddOperation(char op, double operand)
    {
        operations.Add(new Operation(op, operand));
        Console.WriteLine($"Промежуточный результат {operations.Count}: {result}");
    }

    public List<Operation> GetOperations()
    {
        return operations;
    }

    public double GetResult()
    {
        return result;
    }

    public void SetResult(double r)
    {
        result = r;
    }
*/
    public static void DisplayHelp()
    {
        Console.WriteLine("############################## Музыкальный каталог ##############################");
        Console.WriteLine("#\t\"list\"\t для отображения списка музыкальных композиций из каталога\t#");
        Console.WriteLine("#\t\"search\"\t для поиска музыкальной композиции в каталоге\t\t#");
        Console.WriteLine("#\t\"add\"\t для добавления музыкальной композиции в каталог\t\t#");
        Console.WriteLine("#\t\"del\"\t для удаления музыкальной композиции из каталога\t\t#");
        Console.WriteLine("#\t\"quit\"\t для выхода из программы\t\t\t\t\t#");
        Console.WriteLine("#################################################################################");
    }

}
