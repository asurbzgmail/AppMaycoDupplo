// See https://aka.ms/new-console-template for more information
using AppMaycoDupplo.Controller;

try
{
    List<int> listNumbers = new();


    /***NOTE:***/
    /***If you need to do this dynamically, comment out the static and uncomment the dynamic or vice versa***/


    #region Dynamic

    //string msg;

    //var texts = PrintNumber.Texts();
    //for (int i = 0; i < texts.Count; i++)
    //{
    //    Console.WriteLine(string.Format("Write the {0} number:", texts[i].ToString()));
    //    string? readNumber = Console.ReadLine();

    //    if (!PrintNumber.ValidateNumber(readNumber, out msg))
    //    {
    //        Console.WriteLine(string.Format(msg, texts[i].ToString()));
    //        return;
    //    }

    //    listNumbers.Add(Convert.ToInt32(readNumber));
    //}

    //if (!PrintNumber.ValidateFirstvsLast(listNumbers[0], listNumbers[1], out msg))
    //{
    //    Console.WriteLine(msg);
    //    return;
    //}

    #endregion Dynamic

    #region Static

    listNumbers = PrintNumber.StaticNumbers();

    #endregion Static

    if (listNumbers.Count == 0)
        return;
    else
        Console.WriteLine("");

    /*Print the numbers*/
    for (int i = listNumbers[0]; i <= listNumbers[1]; i++)
    {
        Console.WriteLine(PrintNumber.PrintingNumber(i));
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}