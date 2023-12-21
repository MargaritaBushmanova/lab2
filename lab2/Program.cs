class Program
{
    static void Main()
    {
        Catalog myCatalog = new Catalog();
        Catalog.DisplayHelp();

        while (true)
        {
            string request = myCatalog.getRequest();
            Console.Write(request);
            string response = Console.ReadLine();
            if (response.ToLower() == "quit")
                break;
            Console.Write(myCatalog.setResponse(response));
        }
    }
}    
            /*    if (input.ToLower() == "q")
                {
                    break;
                }
                else if (input == "=")
                {
                    try
                    {                   
                        calculator = new Calculator(calculator.GetResult()); // Передаем текущий результат
                        calculator.Calculate();
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                /*else if (int.TryParse(input, out int index) && index > 0 && index <= calculator.GetOperations().Count)
                {
                    try
                    {
                        calculator.Calculate();
                        calculator = new Calculator(calculator.GetResult()); // Передаем текущий результат
                        calculator.AddOperation(calculator.GetOperations()[index - 1].Operator, calculator.GetOperations()[index - 1].Operand);
                    }
                    catch (ArithmeticException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }*/
            /*          else if (double.TryParse(input, out double operand))
                      {
                          Console.Write("Введите операцию (+, -, *, /): ");
                          char op = Console.ReadKey().KeyChar;
                          Console.WriteLine();

                          if (op == '/' && operand == 0)
                          {
                              Console.WriteLine("Ошибка: Деление на ноль.");
                          }
                          else
                          {                  
                              calculator.AddOperation(op, operand);
                              calculator.Calculate();

                          }
                      }
                      else
                      {
                          Console.WriteLine("Некорректный ввод. Повторите попытку.");
                      }*/
