
namespace Excersizes
{
 /*   // ПО ДВУМЕРНЫМ МАССИВАМ

    int[] singleIntArray = new int[]
    {
                1, // Первый член
                2, // Второй член
                3, // Третий член
                4, // Четвертый член
                5  // Пятый член
    };

    int[,] doubleIntArray = new int[,]
    {
                { 1, 2, 3, 4, 5 },          // Первый член
                { 6, 7, 8, 9, 0 },          // Второй член
                {3, 7, 245, 412, -1 },      // Третий член
                { 4, -999, 1124, 536, 6 },  // Четвертый член
    };

            // Вывод одномерного массива
            for (int memberPosition = 0; memberPosition<singleIntArray.Length; memberPosition++)
            {
                Console.WriteLine(singleIntArray[memberPosition]);
            }

// Вывод двумерного массива одинарным перебором
for (int memberPosition = 0; memberPosition < doubleIntArray.GetLength(0); memberPosition++) // Метод Get.Length(0) возвращает вертикальныю длину двумерного массива (кол-во строк)
{
    Console.WriteLine
        (
        $"{doubleIntArray[memberPosition, 0]}, " +
        $"{doubleIntArray[memberPosition, 1]}, " +
        $"{doubleIntArray[memberPosition, 2]}, " +
        $"{doubleIntArray[memberPosition, 3]}, " +
        $"{doubleIntArray[memberPosition, 4]}"
        );
}

// Вывод двумерного массива двойным перебором
for (int memberPosition = 0; memberPosition < doubleIntArray.GetLength(0); memberPosition++) // Метод Get.Length(1) возвращает горизонтальную длину двумерного массива (кол-во столбцов)
{
    // Рисует строку
    for (int internalMemberPosition = 0; internalMemberPosition < doubleIntArray.GetLength(1); internalMemberPosition++)
    {
        Console.Write(doubleIntArray[memberPosition, internalMemberPosition] + " ");
    }

    // Переводит на следующую строку
    Console.WriteLine();
} */
}
