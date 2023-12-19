using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| Welcome to the Perfecio Medical Diagnosis Program |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|___________________________________________________|");
            Console.WriteLine("\nThis program will help you diagnose your illness and recommend the right medicine.");
            Console.Write("\nPlease enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 5 && age <= 17)
            {
                SymptomsForChildren();
            }
            else if (age >= 18)
            {
                SymptomsForAdults();
            }

            Console.WriteLine("\nDo you want to continue diagnosing? (yes/no)");
            string continueChoice = Console.ReadLine().ToLower();
            if (continueChoice != "yes" && continueChoice != "y")
            {
                Console.WriteLine("Exiting program...");    
                break;  
            }
        }
    }

    static void SymptomsForChildren()
    {
        Console.WriteLine("\nDIAGNOSIS FOR CHILDREN");
        Console.WriteLine("\nSYMPTOMS: \n(1) Cough | (2) headache | (3) mild fever" +
                          "\n(11) red or pink eyes | (12) swelling of eyelids | (13) excessive tears" +
                          "\n(21) fatigue and irritability | (22) muscle and/or joint pain | (23) spots");

        DiagnoseForChildren();
    }

    static void SymptomsForAdults()
    {
        Console.WriteLine("\nDIAGNOSIS FOR ADULTS");
        Console.WriteLine("\nSYMPTOMS: \n(1) Sneezing | (2) Coughing | (3) Sore throat" +
                          "\n(11) Belly cramps | (12) Bloating | (13) Nausea" +
                          "\n(21) Headache | (22) Tired legs | (23) Dizziness/difficulty in concentrating");

        DiagnoseForAdults();
    }

    static void DiagnoseForChildren()
    {
        Console.WriteLine("\nPlease select the number of three symptoms you are currently feeling (press enter before inputting another number): ");

       
        int symptom1 = Convert.ToInt32(Console.ReadLine());
        int symptom2 = Convert.ToInt32(Console.ReadLine());
        int symptom3 = Convert.ToInt32(Console.ReadLine());

        
        string diagnosis = "";
        string recommendedMedicine = "";
        double medicinePrice = 0.0;

     
        if ((symptom1 == symptom2) || (symptom1 == symptom3) || (symptom2 == symptom3))
        {
            switch (symptom1)
            {
                case 1:
                case 2:
                case 3:
                    diagnosis = "common cold";
                    recommendedMedicine = "ColdRelief";
                    medicinePrice = 10.99;
                    break;
                case 11:
                case 12:
                case 13:
                    diagnosis = "conjunctivitis";
                    recommendedMedicine = "EyeComfort";
                    medicinePrice = 9.99;
                    break;
                case 21:
                case 22:
                case 23:
                    diagnosis = "chicken pox";
                    recommendedMedicine = "ChickenPoxRelief";
                    medicinePrice = 15.99;
                    break;
            }
        }
        else
        {
           
            switch (symptom1)
            {
                case 1:
                case 2:
                case 3:
                    diagnosis = "common cold";
                    recommendedMedicine = "ColdRelief";
                    medicinePrice = 10.99;
                    break;
            }

            switch (symptom2)
            {
                case 1:
                case 2:
                case 3:
                    diagnosis = "common cold";
                    recommendedMedicine = "ColdRelief";
                    medicinePrice = 10.99;
                    break;
            }

            switch (symptom3)
            {
                case 1:
                case 2:
                case 3:
                    diagnosis = "common cold";
                    recommendedMedicine = "ColdRelief";
                    medicinePrice = 10.99;
                    break;
            }

            switch (symptom1)
            {
                case 11:
                case 12:
                case 13:
                    diagnosis = "conjunctivitis";
                    recommendedMedicine = "EyeComfort";
                    medicinePrice = 9.99;
                    break;
            }

            switch (symptom2)
            {
                case 11:
                case 12:
                case 13:
                    diagnosis = "conjunctivitis";
                    recommendedMedicine = "EyeComfort";
                    medicinePrice = 9.99;
                    break;
            }

            switch (symptom3)
            {
                case 11:
                case 12:
                case 13:
                    diagnosis = "conjunctivitis";
                    recommendedMedicine = "EyeComfort";
                    medicinePrice = 9.99;
                    break;
            }

            switch (symptom1)
            {
                case 21:
                case 22:
                case 23:
                    diagnosis = "chicken pox";
                    recommendedMedicine = "ChickenPoxRelief";
                    medicinePrice = 15.99;
                    break;
            }

            switch (symptom2)
            {
                case 21:
                case 22:
                case 23:
                    diagnosis = "chicken pox";
                    recommendedMedicine = "ChickenPoxRelief";
                    medicinePrice = 15.99;
                    break;
            }

            switch (symptom3)
            {
                case 21:
                case 22:
                case 23:
                    diagnosis = "chicken pox";
                    recommendedMedicine = "ChickenPoxRelief";
                    medicinePrice = 15.99;
                    break;
            }
        }
        
        Console.WriteLine($"You have {diagnosis}.");

        Console.Write("Would you like to order medicine? (yes/no): ");
        string orderChoice = Console.ReadLine().ToLower();

        if (orderChoice == "yes" || orderChoice == "y")
        { 
            Console.Write($"How many units of {recommendedMedicine} would you like to order?: ");
            int numberOfOrders = Convert.ToInt32(Console.ReadLine());

            double totalAmount = numberOfOrders * medicinePrice;

            Console.WriteLine("************************************************");
            Console.WriteLine($"\nORDER SUMMARY:\nDiagnosis: {diagnosis}\nMedicine: {recommendedMedicine}\nUnit Price: ${medicinePrice}\nNumber of Orders: {numberOfOrders}\nTotal Amount: ${totalAmount}");
            Console.WriteLine("\n************************************************");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("\nThank you for using Perfecio Medical Diagnosis Program. \n[Consult your doctor if symptoms persist.]");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("________________________________________________");
        }
        else
        {
            Console.WriteLine("Thank you for using Perfecio Medical Diagnosis Program. Consult your doctor if symptoms persist.");
        }
    }

    static void DiagnoseForAdults()
    {
        Console.WriteLine("\nPlease select the symptoms you are currently feeling: ");

        int symptom1 = Convert.ToInt32(Console.ReadLine());
        int symptom2 = Convert.ToInt32(Console.ReadLine());
        int symptom3 = Convert.ToInt32(Console.ReadLine());

        string diagnosis = "";
        string recommendedMedicine = "";
        double medicinePrice = 0.0;

        if ((symptom1 == symptom2) || (symptom1 == symptom3) || (symptom2 == symptom3))
        {
            switch (symptom1)
            {
                case 1:
                case 2:
                case 3:
                    diagnosis = "common cold";
                    recommendedMedicine = "ColdRelief";
                    medicinePrice = 10.99;
                    break;
                case 11:
                case 12:
                case 13:
                    diagnosis = "diarrhea";
                    recommendedMedicine = "AntiDiarrhea";
                    medicinePrice = 8.99;
                    break;
                case 21:
                case 22:
                case 23:
                    diagnosis = "fatigue";
                    recommendedMedicine = "EnergyBoost";
                    medicinePrice = 12.99;
                    break;
            }
        }
        else
        {
            switch (symptom1)
            {
                case 1:
                case 2:
                case 3:
                    diagnosis = "common cold";
                    recommendedMedicine = "ColdRelief";
                    medicinePrice = 10.99;
                    break;
            }

            switch (symptom2)
            {
                case 1:
                case 2:
                case 3:
                    diagnosis = "common cold";
                    recommendedMedicine = "ColdRelief";
                    medicinePrice = 10.99;
                    break;
            }

            switch (symptom3)
            {
                case 1:
                case 2:
                case 3:
                    diagnosis = "common cold";
                    recommendedMedicine = "ColdRelief";
                    medicinePrice = 10.99;
                    break;
            }

            switch (symptom1)
            {
                case 11:
                case 12:
                case 13:
                    diagnosis = "diarrhea";
                    recommendedMedicine = "AntiDiarrhea";
                    medicinePrice = 8.99;
                    break;
            }

            switch (symptom2)
            {
                case 11:
                case 12:
                case 13:
                    diagnosis = "diarrhea";
                    recommendedMedicine = "AntiDiarrhea";
                    medicinePrice = 8.99;
                    break;
            }

            switch (symptom3)
            {
                case 11:
                case 12:
                case 13:
                    diagnosis = "diarrhea";
                    recommendedMedicine = "AntiDiarrhea";
                    medicinePrice = 8.99;
                    break;
            }

            switch (symptom1)
            {
                case 21:
                case 22:
                case 23:
                    diagnosis = "fatigue";
                    recommendedMedicine = "EnergyBoost";
                    medicinePrice = 12.99;
                    break;
            }

            switch (symptom2)
            {
                case 21:
                case 22:
                case 23:
                    diagnosis = "fatigue";
                    recommendedMedicine = "EnergyBoost";
                    medicinePrice = 12.99;
                    break;
            }

            switch (symptom3)
            {
                case 21:
                case 22:
                case 23:
                    diagnosis = "fatigue";
                    recommendedMedicine = "EnergyBoost";
                    medicinePrice = 12.99;
                    break;
            }
        }

        Console.WriteLine($"You have {diagnosis}.");

        Console.Write("Would you like to order medicine? (yes/no): ");
        string orderChoice = Console.ReadLine().ToLower();

        if (orderChoice == "yes" || orderChoice == "y")
        {
            Console.Write($"How many units of {recommendedMedicine} would you like to order?: ");
            int numberOfOrders = Convert.ToInt32(Console.ReadLine());

            double totalAmount = numberOfOrders * medicinePrice;

            Console.WriteLine("************************************************");
            Console.WriteLine($"\nORDER SUMMARY:\nDiagnosis: {diagnosis}\nMedicine: {recommendedMedicine}\nUnit Price: ${medicinePrice}\nNumber of Orders: {numberOfOrders}\nTotal Amount: ${totalAmount}");
            Console.WriteLine("\n************************************************");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("\nThank you for using Perfecio Medical Diagnosis Program. \n[Consult your doctor if symptoms persist.]");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("________________________________________________");
        }
        else
        {
            Console.WriteLine("Thank you for using Perfecio Medical Diagnosis Program. Consult your doctor if symptoms persist.");
        }
    }
}
