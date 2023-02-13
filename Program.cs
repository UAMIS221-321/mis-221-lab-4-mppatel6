// Start //
int userChoice = GetUserChoice();
while (userChoice != 3){ // condition check // pretest loop(testing before)
    RouteEm(userChoice);
    userChoice = GetUserChoice(); // update read
}

// End //

// Methods //
static int GetUserChoice(){
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if (IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput){
    if (userInput == "1" || userInput == "2" || userInput == "3"){
        return true;
    }
    return false;
}

static void SayInvalid(){
    System.Console.WriteLine("Invalid");
    PauseAction();
}

static void RouteEm(int menuChoice){
    if (menuChoice == 1){
        GetFull();
    }
    else if (menuChoice == 2){
        GetPartial();
    }
    else if (menuChoice != 3){
        SayInvalid();
    } 
}

static void GetFull(){
    Console.Clear();
    Random rnd = new Random();
    int rows = rnd.Next(3,10);
    int count = 0;
    for(int i = 0; i <= rows; i++){
        for(int x = 0; x <= count;x++){
            Console.Write("O");
        }
        Console.WriteLine("");
        count++;
    }
    PauseAction();
}

static void GetPartial(){
    Console.Clear();
    Random rnd = new Random();
    int rows = rnd.Next(3,10);
    int rndNumber = rnd.Next(0,100);
    int count = 0;
    for(int i = 0; i <= rows; i++){
        for(int x = 0; x <= count;x++){
            if (rndNumber > 20){
            Console.Write("O");
            }
            else {
            System.Console.Write(" ");
            }
            rndNumber = rnd.Next(0,100);
        }
    Console.WriteLine("");
    count++;
    }
    PauseAction();
}

static void PauseAction(){
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
