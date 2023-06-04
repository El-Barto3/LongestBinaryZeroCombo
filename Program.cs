// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

char[] changeToBinary(int number) {

    char[] binaryTable = new char[1];
    int numberRest = number;
    int binaryDigit = 1;
    int powerOfDigit = 0;

    while(numberRest > 0)
    {
        if(binaryDigit*2 <= numberRest)
        {
            binaryDigit *= 2;
            powerOfDigit += 1;
        }
        else
        {
            if(number == numberRest)
            {
                binaryTable = new char[powerOfDigit+1];
            }
            numberRest = numberRest - binaryDigit;

            binaryTable[powerOfDigit] = '1';
            binaryDigit = 1;
            powerOfDigit = 0;

        }
    }
    for(int i=0;i<binaryTable.Length;i++){
        if(binaryTable[i] != '1'){
            binaryTable[i] = '0';
        }
    }
    //print
    Console.Write(number + ". ");
    for(int i=(binaryTable.Length);i>=0;i--)
        if(i>0)
            Console.Write(binaryTable[i-1]);
    Console.WriteLine("");

    return binaryTable;
}
int solution(int N) {
    char[] binaryNumber = changeToBinary(N);
    int highestCombo = 0;
    int zeroStreakCounter = 0;
    int start = -1, end = -1;
    for(int i =0;i<binaryNumber.Length;i++)
    {
        if(binaryNumber[i] == '1')
        {
            start = i;
            break;
        }
    }
    for(int i =binaryNumber.Length-1;i>=0;i--)
    {
        if(binaryNumber[i] == '1' && i > start)
        {
            end = i;
            break;
        }
    }
    if(start == -1 || end == -1)
        return 0;
    else
        for(int i =0;i<binaryNumber.Length;i++)
        {
            if(binaryNumber[i] != '1')
                zeroStreakCounter += 1;
            else
            {
                if(highestCombo < zeroStreakCounter)
                    highestCombo = zeroStreakCounter;
                zeroStreakCounter = 0;
            }
        }
    Console.WriteLine(" // highest streak = " + highestCombo);
    return highestCombo;
}

solution(15);
solution(1041);
solution(32);

