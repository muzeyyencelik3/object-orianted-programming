//************************************************************************
//**                                                                    **
//**   STUDENT NAME................. :MÜZEYYEN ÇELİK                    **
//**   STUDENT NUMBER................. :B211202351                      **
//************************************************************************

using System;


namespace Homework1oop

{
    class Program
    {
        static void Main(string[] args)
        {
            CRYPT crypt = new CRYPT();

            while (crypt.control == false)
            {
                Console.Write("Enter a four-digit number: ");
                crypt.n = Console.ReadLine();  //Print the data received from the user from the crypt class to the screen
                crypt.inputNumber();
            }

            //Methods
            crypt.encryptNumber();
            crypt.printEncryptedNumber();
            crypt.decryptNumber();
            crypt.printDecryptedNumber();

            Console.ReadKey(); 
        }
    }

    //Add number data member and a related property for this class
    class CRYPT
    {
        int D1 , D2, D3, D4;
        public string n;
        public int n1;
        public bool control = false;
       

        public void inputNumber()
        {
           
            
                n1 = Convert.ToInt32(n); //conversion type
                int n2 = n1;
                int step = 0;

                while (n2 >0) //counting entered digits.Continue the loop until you get the correct answer
                {
                    n2 /= 10;
                    step++;
                }

                if(step==4)  //find out if the number of digits entered is equal to 4
                {
                    control = true;
                }
            
                else
                {
                control = false;
                }
        }

        public void encryptNumber()  //that returns the encrypted number
        {
            //find a digit
            /* D4 = n1 % 10; 
             D3 = (n1 / 10) % 10;
             D2 = (n1 / 100) % 10;
             D1 = (n1 / 1000) % 10;
            // replace each digit by (the sum of that digit plus 7) modulus 10
             D1 = (D1 + 7) % 10;
             D2 = (D2 + 7) % 10;
             D3 = (D3 + 7) % 10;
             D4 = (D4 + 7) % 10;*/

            //combination of the two shortcut

             D1 = ((n1 / 1000) + 7) % 10;
             D2 = ((n1 / 100) + 7) % 10;
             D3 = ((n1 / 10) + 7) % 10;
             D4 = ((n1 + 7) % 10);
        }

        public int decryptNumber()
        {
            // return to the first number received from the user

             D4 = n1 % 10;
             D3 = (n1 / 10) % 10;
             D2 = (n1 / 100) % 10;
             D1 = (n1 / 1000) % 10; 
            return n1;  //I didn't want to write a formula here again but I couldn't find it to call it with return.
        }

        public void printEncryptedNumber()  // method that prints the encrypted number on the screen
        {
            //swap the first digit with the third, and swap the second digit with the fourth.
            Console.WriteLine("Encrypted Message......: {0}{1}{2}{3}", D3, D4, D1, D2);

        }

        public void printDecryptedNumber()  //method that prints the decrypted number on the screen
        {
            // that inputs the encrypted number and returns the original number
            Console.Write("Decrypted Message......: {0}{1}{2}{3} ", D1, D2, D3, D4);
            
        }
    }
}