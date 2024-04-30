using RunningLine;

Print($"Enter the line of symbols: ");
var userInput = Console.ReadLine().ToLower();
Console.WriteLine($"your input is: {userInput}");

var patternToPrint = PaternToPrintContainer.GetPatternToPrint(userInput);
int delayTime = 30;


int rowsCount = patternToPrint.Length;
int[] rowsLettersCount = new int[rowsCount];
int[] rowsStartPositions = new int[rowsCount];

for (int i = 0; i < rowsCount; i++)
{
    rowsStartPositions[i] = Console.WindowWidth - 1;
    rowsLettersCount[i] = 1;
}

while (true)
{
    Console.Clear();
    for (int i = 0; i < rowsCount; i++)
    {
        if (rowsLettersCount[i] == patternToPrint[i].Length)
        {
            CursorPositioning(rowsStartPositions[i]);
            Print(patternToPrint[i]);
            rowsStartPositions[i]--;
        }
        if (rowsLettersCount[i] < patternToPrint[i].Length)
        {
            CursorPositioning(rowsStartPositions[i]);
            Print(patternToPrint[i].Substring(0, Math.Min(rowsLettersCount[i], patternToPrint[i].Length)));

            rowsLettersCount[i]++;
            rowsStartPositions[i]--;
        }
    }

    if (rowsStartPositions[patternToPrint.Length - 1] < 0)
    {
        int indexToStartPrintFrom = 1;
        while (indexToStartPrintFrom < patternToPrint.Max(p => p.Length))
        {
            Console.Clear();
            for (int i = 0; i < rowsCount; i++)
            {
                rowsStartPositions[i] = 0;
                // Ensure that substring does not exceed pattern length
                int endIndex = Math.Min(indexToStartPrintFrom + Console.WindowWidth, patternToPrint[i].Length);

                CursorPositioning(rowsStartPositions[i]);
                Print(patternToPrint[i].Substring(indexToStartPrintFrom, endIndex - indexToStartPrintFrom));
            }
            indexToStartPrintFrom++;
            Thread.Sleep(delayTime);
        }

        for (int i = 0; i < rowsCount; i++)
        {
            rowsStartPositions[i] = Console.WindowWidth - 1;
            rowsLettersCount[i] = 1;
        }
    }
    Thread.Sleep(delayTime);
}

static void CursorPositioning(int leftPosition)
{
    Console.SetCursorPosition(leftPosition, Console.CursorTop + 1);
}

static void Print (string valueToPrint)
{
    Console.Write(valueToPrint);
}

