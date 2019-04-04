using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {

        public static void Main(string[] args)
        {         

            string[] reason = new string[100];
            double[,] array = new double[100, 100];// στην πρώτη στήλη αποθηκεύεται το amount 
                                                   // και στην δεύτερη το balance
            string [] date = new string[100];

            Random random = new Random();

            int[] iban = new int[6]; //{ 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i <= 5; i++)
            {
                iban[i] = random.Next(0, 10);
            }


            string IBAN;
            IBAN = iban[0].ToString();
            for (int i = 1; i <= 5; i++)
            { IBAN = IBAN + iban[i].ToString(); }

            //   Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine("ΔΩΣΕ ΤΟ ΟΝΟΜΑ ΣΟΥ ");
            string name = Console.ReadLine();

            Console.WriteLine("ΔΩΣΕ ΤΟ ΕΠΙΘΕΤΟ ΣΟΥ ");
            string lastname = Console.ReadLine();

            Console.WriteLine("ΠΑΤΑ 1 ΓΙΑ ΔΗΜΙΟΥΡΓΙΑ SAVINGSACCOUNT");
            Console.WriteLine("ΠΑΤΑ 2 ΓΙΑ CREDITACCOUNT");
          //  Console.WriteLine("ΠΑΤΑ 3 ΓΙΑ LOTTERYACCOUNT");

            string number = Console.ReadLine();

            while (number != "1" && number != "2" )
            {

                Console.WriteLine("ΠΑΤΑ 1 ΓΙΑ ΔΗΜΙΟΥΡΓΙΑ SAVINGSACCOUNT");
                Console.WriteLine("ΠΑΤΑ 2 ΓΙΑ ΔΗΜΙΟΥΡΓΙΑ CREDITACCOUNT");
                //Console.WriteLine("ΠΑΤΑ 3 ΓΙΑ LOTTERYACCOUNT");

                number = Console.ReadLine();

            }

            customer vasilis = new customer(name, lastname,IBAN);
            Console.WriteLine(vasilis.firstname);
            Console.WriteLine(vasilis.lastname);
            Console.WriteLine("ΤΟ IBAN ΣΟΥ ΕΙΝΑΙ " + vasilis.IBAN);



            int k = 0;

            if (number == "1")
            {
                Console.WriteLine(" ΠΟΙΟ ΕΙΝΑΙ ΤΟ ΠΟΣΟ ΠΟΥ ΕΧΕΙΣ ΣΤΗΝ ΤΡΑΠΕΖΑ ?");
                int initial_amount = Int32.Parse(Console.ReadLine());

                SavingsAccount sav = new SavingsAccount(initial_amount);
                Console.WriteLine("ΤΟ ΥΠΟΛΟΙΠΟ ΣΟΥ ΕΙΝΑΙ " + sav.balance);

               // int choice;
                Console.WriteLine("ΠΑΤΑ 1 ΓΙΑ ΑΝΑΛΗΨΗ , 2 ΓΙΑ ΚΑΤΑΘΕΣΗ , 3 ΓΙΑ INTEREST, quit ΓΙΑ ΝΑ ΦΥΓΕΙΣ ");
                string choice = Console.ReadLine();



                while (choice != "quit")
                {

                    if (choice == "1")
                    {
                        Console.WriteLine("ΠΟΙΟ ΕΙΝΑΙ ΤΟ ΠΟΣΟ ΑΝΑΛΗΨΗΣ ?");
                        int amount_withdraw = Int32.Parse(Console.ReadLine());
                        date[k] = DateTime.Now.ToString("MM/dd/yyyy");

                        sav.withdraw(amount_withdraw);
                        Console.WriteLine("ΤΟ ΥΠΟΛΟΙΠΟ ΣΟΥ ΕΙΝΑΙ " + sav.balance);

                        reason[k] = "WITHDRAW";


                        array[k, 0] = sav.poso_analipsis; //ammount_withdraw;
                        array[k, 1] = sav.balance;
                        k++;


                    }

                    else if (choice == "2")
                    {
                        Console.WriteLine("ΠΟΙΟ ΕΙΝΑΙ ΤΟ ΠΟΣΟ ΚΑΤΑΘΕΣΗΣ ?");
                        int amount_deposit = Int32.Parse(Console.ReadLine());
                        date[k] = DateTime.Now.ToString("MM/dd/yyyy");


                        sav.deposit(amount_deposit);
                        Console.WriteLine("ΤΟ ΥΠΟΛΟΙΠΟ ΣΟΥ ΕΙΝΑΙ " + sav.balance);

                        reason[k] = "DEPOSIT";

                        array[k, 0] = amount_deposit;
                        array[k, 1] = sav.balance;
                        k++;

                    }



                    else if (choice == "3")
                    {
                        sav.addinterest();
                        date[k] = DateTime.Now.ToString("MM/dd/yyyy");
                        Console.WriteLine("Ο ΤΟΚΟΣ ΕΙΝΑΙ " + sav.interest);
                        Console.WriteLine("ΤΟ ΥΠΟΛΟΙΠΟ ΣΟΥ ΕΙΝΑΙ " + sav.balance);
                        reason[k] = "INTEREST";
                        array[k, 0] = sav.interest;
                        array[k, 1] = sav.balance;
                        k++;

                    }

                    Console.WriteLine("ΠΑΤΑ 1 ΓΙΑ ΑΝΑΛΗΨΗ , 2 ΓΙΑ ΚΑΤΑΘΕΣΗ , 3 ΓΙΑ INTEREST, quit ΓΙΑ ΝΑ ΦΥΓΕΙΣ ");
                    choice = Console.ReadLine();

                }


                Console.WriteLine("DATE |        REASON  | AMMOUNT | BALANCE  ");
                for (int l = 0; l <= k; l++)
                {

                    Console.WriteLine(date[l] + "    " + reason[l] + "     " + array[l, 0] + "      " + array[l, 1]);

                }


            }


            else if (number == "2")
            {
                //double [,] ar = new double[100, 100];

                Console.WriteLine("ΠΟΙΟ ΕΙΝΑΙ ΤΟ ΠΟΣΟ ΠΟΥ ΕΧΕΙΣ ΣΤΗΝ ΤΡΑΠΕΖΑ ?");
                int initial_amount = Int32.Parse(Console.ReadLine());

                CreditAccount cr = new CreditAccount(initial_amount);
                Console.WriteLine("ΤΟ ΥΠΟΛΟΙΠΟ ΣΟΥ ΕΙΝΑΙ " + cr.balance);

                string choice;
                Console.WriteLine("ΠΑΤΑ 1 ΓΙΑ ΑΝΑΛΗΨΗ , 2 ΓΙΑ ΚΑΤΑΘΕΣΗ, 3 ΓΙΑ INTEREST , quit ΓΙΑ ΝΑ ΦΥΓΕΙΣ ");
                choice = Console.ReadLine();


                while (choice!="quit")
                {

                    if (choice == "1")
                    {
                        Console.WriteLine("ΠΟΙΟ ΕΙΝΑΙ ΤΟ ΠΟΣΟ ΑΝΑΛΗΨΗΣ ?");
                        int amount_withdraw = Int32.Parse(Console.ReadLine());
                        date[k] = DateTime.Now.ToString("MM/dd/yyyy");

                        cr.withdraw(amount_withdraw);
                        Console.WriteLine("ΤΟ ΥΠΟΛΟΙΠΟ ΣΟΥ ΕΙΝΑΙ " + cr.balance);

                        reason[k] = "WITHDRAW";

                        array[k, 0] = cr.poso_analipsis; //ammount_withdraw;
                        array[k, 1] = cr.balance;
                        k++;

                    }

                    else if (choice == "2")
                    {
                        Console.WriteLine("ΠΟΙΟ ΕΙΝΑΙ ΤΟ ΠΟΣΟ ΚΑΤΑΘΕΣΗΣ ?");
                        int amount_deposit = Int32.Parse(Console.ReadLine());
                        date[k] = DateTime.Now.ToString("MM/dd/yyyy");


                        cr.deposit(amount_deposit);
                        Console.WriteLine("ΤΟ ΥΠΟΛΟΙΠΟ ΣΟΥ ΕΙΝΑΙ " + cr.balance);

                        reason[k] = "DEPOSIT";

                        array[k, 0] = amount_deposit;
                        array[k, 1] = cr.balance;
                        k++;

                    }

                    else if (choice == "3")
                    {

                        cr.addinterest();
                        date[k] = DateTime.Now.ToString("MM/dd/yyyy");
                        Console.WriteLine("Ο ΤΟΚΟΣ ΕΙΝΑΙ " + cr.interest);
                        Console.WriteLine("ΤΟ ΥΠΟΛΟΙΠΟ ΣΟΥ ΕΙΝΑΙ " + cr.balance);
                        reason[k] = "INTEREST";
                        array[k, 0] = cr.interest;
                        array[k, 1] = cr.balance;
                        k++;

                    }

                    Console.WriteLine("ΠΑΤΑ 1 ΓΙΑ ΑΝΑΛΗΨΗ , 2 ΓΙΑ ΚΑΤΑΘΕΣΗ , 3 ΓΙΑ INTEREST, quit ΓΙΑ ΝΑ ΦΥΓΕΙΣ ");
                    choice = Console.ReadLine();

                }

                Console.WriteLine("DATE |        REASON  | AMMOUNT | BALANCE  ");
                for (int l = 0; l <= k; l++)
                {

                    Console.WriteLine(date[l] + "    " + reason[l] + "     " + array[l, 0] + "      " + array[l, 1]);
              

                }  

            }


            


            Console.ReadKey();


        }


            

        }


    }

