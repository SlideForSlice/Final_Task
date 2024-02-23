string[] array = {"1234", "bob", "shakira"};
int countForLength = 0;
int countForJ = 0;

for (int i = 0; i < array.Length; i++){
    int sumOfChars = array[i].Length;
    if (sumOfChars <= 3){
        countForLength += 1;
    }
}

string[] newArray = new string[countForLength];

for (int i = 0; i < array.Length; i++){
    int sumOfChars = array[i].Length;
    if (sumOfChars <= 3){
        newArray[countForJ] = array[i];
        countForJ += 1;
    }
}

Console.WriteLine(newArray);