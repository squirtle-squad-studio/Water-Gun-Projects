// Rollcall:
// Benny here
// (Rainbow)David there
// Stan was here
// Gnarwhal here
// Chris here 
/*
    -------------------------
    This is a comment block
    -------------------------
*/

using System;
class main
{
    static void Main(string[] args)
    {
        
    /* Variables & Primary Data Types:
        variable names can only start with a letter or _, but can contain letters, numbers, or _.
    */
    
    // Commonly used primary data types
    // Initializing
    // (Data Type) (Whatever name you want for you variable) = (value you want)
    /*
    int boi;                            // uninitialized integer variable
    int inteniggers = 1;                // integers can only be whole numbers
    char letter = 'a';                       // Character (only one)
    string s = "hello";                 // a "string" of characters
    bool chrisIsAGodDamnG = false;      // true or false
    
    // Other primary data types
    float f = 0.5f;     // can be decimals (32bit) (stands for floating-point representation)
    double di = 2.0d;       //  can be decimals (64bit) (stands for double precision)
    decimal dee = 1.5m;  // 128 bit 
    
    // Constant data types (cannot be changed after initializing)
    const decimal pi = 3.14159m;
    // pi = 4;   this line will cause an error
    */
    
    /* Types of operators:
    Relational                          Arithmetic              Logical     
    ==  Equal to                        +   add                 &&  And     
    >   Greater than                    -   subtract            ||  Or     
    <   Less than                       *   multiply            !   Not     
    >=  Greater than or equal to        /   divide                          
    <=  Less than or equal to           %   modulus (remainder)
    !=  Not equal to
    +=  Increment by
    -=  Decrement by
    *=  Multiply by
    /=  Divide by
    
    Bitwise                             Unary
    ~   Bitwise complement              c++     increment value of c after running
    ^   Bitwise XOR (exclusive or)      c--     decrement value of c after running
    &   Bitwise AND                     ++c     increment value of c before running
    |   Bitwise OR                      --c     decrement value of c before running
    <<  Bitwise shift left
    >>  Bitwise shift right
    
    Ternary 
    ? :  If-else    ( condition ? execute if true : otherwise )
    Ex: n > 7 ? n - 2 : n + 1
    
    */
    
        // Algebra
        int a = 2;
        int b = 2;
        Console.WriteLine(a == b);      // 2 == 2   "equal to"          True
        a = 5;
        Console.WriteLine(a == b);      // 5 == 2                       False
        Console.WriteLine(a != b);      // 5 != 2   "not equal"         True
        Console.WriteLine(a < b);       // 5 < 2    "less than"         False
        Console.WriteLine(a > b);       // 5 > 2    "greater than"      True
        Console.WriteLine(a <= b);      // 5 <= 2   "less than equal"   False
        Console.WriteLine(a >= b);      // 5 >= 2 "greater than equal"  True
        
        // conditional statement (a == b) will either be true or false,
        // so can be assigned to boolean variable isA_Equal_To_B
        bool isA_Equal_To_B = (a == b);
        // Conditionals: If-else blocks
        Console.WriteLine("\n------If statement------");
        bool isRaining = true;
        if(isRaining == true)
        {
            Console.WriteLine("Bring an umbrella"); // Only runs when (isRaining == true)
        }
        else
        {
            Console.WriteLine("GTFO of your house"); //how about no.
        }
        
        a = 3; // int
        b = 4;
        
        Console.WriteLine("\n------If with Integers------");
        if(a > b)       // (3 > 4) == false
        {
            Console.WriteLine( a + ">" + b);
            Console.WriteLine("A is greater than B");
        }
        else if(a < b)  // (3 < 4) == true
        {
            Console.WriteLine( a + "<" + b);
            Console.WriteLine("A is less than B");
        }
        else            // Otherwise do this (3 == 4) == false
        {
            Console.WriteLine( a + "=" + b);
            Console.WriteLine("A is less than B");
        }
        
        // bool abcd = 1;
        
        
        // Quiz for Stanley
        Console.WriteLine("\n------Stanley's Quiz------");
        a = 5;
        b = 4;
        
        a = b; // a = 4
        
        Console.WriteLine(a);
        
        // Quiz for Anthony
        Console.WriteLine("\n------Anthony's Quiz------");
        if('a' == 'A')
        {
            Console.WriteLine("If will run");
        }
        else
        {
            Console.WriteLine("Else will run");
        }
        
        
        // Quiz for Chris
        // Will this run? or cause an error?
        // Comment out if error and correct it
        //string ayeAyeSarge = true;
        
        // Chris write the correct answer below
        
        // you forgot variable name
        Console.WriteLine("\n------Chris' Quiz------");
        string s = "ayeAyeSarge";
        Console.WriteLine(s);
        
        Console.WriteLine("What\nIs\nUp\nStanley.");
        Console.WriteLine("\\n tells the computer to \nprint\non\nnext\nl\ni\nn\ne");
        
        // Loops        
        Console.WriteLine("\n------While Loop------");
        int age = 1; // initial variable
        int drinking = 21;
        while(age < drinking) // condition 
        {
            Console.WriteLine("My age is " + age);
            Console.WriteLine("You too young you dumb fuck");
            age = age + 1; // steps aka (age += 1) aka (age++)
        }
        Console.WriteLine("You can finally (legally) drink you little bitch");
        
        
        Console.WriteLine("\n------For Loop------");
        // for( initial variable ; condition ; steps  )
        for( int childvar = 1; childvar < 10; childvar += 2 ) { Console.WriteLine("i is: " + childvar); }
        
        int notachildvar = 1;
        for( ;notachildvar < 3; ) {
            Console.WriteLine("Wazzzzzaaaap");
            notachildvar++;
        }
        
        
        
        Console.WriteLine("GetRekt. #ThisIsHowTheProsDoIt");
        
        Console.WriteLine("\n------Infinite Loop------"); // Don't do this! It will run forever
        /* Remember to check your loop conditions
        int weee = 10;
        while(!false) // This will never be false so it won't stop
        {
            Console.WriteLine(wee);
        }
        */
        
        
        Console.WriteLine("\n------Arrays------");
        string[] homies;
        int[] lottoNums = new int[5]{ 1, 2, 3, 4, 5 };
        //                      key { 0  1  2  3  4 }
        //
        Console.WriteLine("What is the first lottery number?: " + lottoNums[0]); 
        homies = new string[100];
        Console.WriteLine("\n------Homies Print------");
        homies[99] = "David";
        Console.WriteLine(homies[99]);
        //homies[0] = (homies[0]!="Sherman") ? "Sherman": "Still Sherman";
        
        // Example of 2D Arrays (array of arrays..)
        string [,] ChessBoard = new string[8,8];
        /*
          0 1 2 3 4 5 6 7
        0[][][][][][][][]
        1[][][][][][][][]
        2[][][][][][][][]
        3[][][][][][][][]
        4[][][][][][][][]
        5[][][][][][][][]
        6[][][][][][][][]
        7[][][][][][][][]
        */
        ChessBoard[0,0] = "Queen";
        
        
        Console.WriteLine("\n------Nested Loops------");
        Console.WriteLine("------& applying Arrays------");
        
        for(int row = 0; row < 8; row++)
        {
            for(int col = 0; col < 8; col++)
            {
                if(row == 1)
                {
                    ChessBoard[row,col] = "Pawn";
                }
                else
                {
                    ChessBoard[row,col] = "Nothing";
                }
                Console.Write("[{0}]", ChessBoard[row, col].Substring(0,1));
            }
            Console.WriteLine();
        }


     
        Console.WriteLine("\n------Functions/Methods------");
        Console.WriteLine("Did we hit the lotto jackpot?!?");
        string lottoStatus = checkLotto(lottoNums) ? "Yes! Jackpot!" : "Not even close.. ";
        Console.WriteLine(lottoStatus);
        
    }
    
    
    /**
     *  Simple function to check lotto guesses
     */
    public static bool checkLotto(int[] guess)
    {
        // Generate lottery pool (not random)
        int[] lottoPool = new int[5] { 23, 54, 33, 1, 3 };
        
        // foreach ( array element in array )
        foreach( int element in guess )
        {
            // Check if element is in array by checking if IndexOf will return
            // a valid index ; otherwise, it will return -1 and we know
            // it is not valid and thus not in the array
            if( Array.IndexOf(lottoPool, element) <= -1 )
            {
                return false;
            }
        }
        return true;
    }
    
}


/* Chris says: (say your shit here chris, like questions)
chris say something
"something"
do you have questions chris
do you understand the code coming out of my cursor
"yes"
chris take the Quiz
its a string why would it be true
answer the dayum question 
cause an error
good boi
now correct it show stanley how its done
boi correct it not comment it
no go correct the code not here bruh
JUST JOIN THE DAMN DISCORD

*/