using System;
using System.Collections.Generic;


// importing the class I wrote for KelvinToCelsius so I can use that class in my UI logic file


using TemperatureConverter.Models;
class Program
{
    static void Main()
    {

        // My appliction can perform 2 features; one is converting fahrenheit Temperature to celsius and vis a vis(vice-versa)
        // and the other is converting a temperature n Kelvin to celsius and vis a vis(vice-versa)
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Welcome to the Temperature-Converter App made by Dynasty");
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Input 'FC' to supply in a fahrenheit temperature and our app converts it to Celsius");
        Console.WriteLine();
        Console.WriteLine("Input 'CF' to supply in a Celsius temperature and our app converts it to Fahrenheit");
        Console.WriteLine();
        Console.WriteLine("Input 'KC' to supply in a Kelvin temperature and our app converts it to Celsius");
        Console.WriteLine();
        Console.WriteLine("Or input 'CK' to supply in a Celsius temperature and our app converts it to Kelvin :)");
        Console.WriteLine();
        Console.WriteLine("Or input 'KF' to supply in a Kelvin temperature and our app converts it to Fahrenheit :)");
        Console.WriteLine();
        Console.WriteLine("Or input 'FK' to supply in a Fahrenheit Temperature and our app converts it to Kelvin :)");
        Console.WriteLine();

        string userStarts = Console.ReadLine().ToUpper();

        // forFahrenheit to celsius
        if (userStarts == "FC")
        {
            Console.WriteLine("You selected the option for a conversion of Fahrenheit to Celsius");
            Console.WriteLine("We'll help you convert a fahrenheit Temperature into a Celsius one");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter in the fahrenheit value");

            string fahrenheitValue = Console.ReadLine();

            int fahrenheitValueInt = int.Parse(fahrenheitValue);

            Console.WriteLine(fahrenheitValueInt);

            double celsiusStandard = 32;

            FahrenheitToCelsius faht = new FahrenheitToCelsius(fahrenheitValueInt, celsiusStandard);

            // running a method to confirm or edit the value my user enterred for Celsius

            ConfirmOrEditFirstFahrenheit(faht);

            // code for method to confirm or edit fahrenheit value supplied by user.

            static void ConfirmOrEditFirstFahrenheit(FahrenheitToCelsius confirmFaht1)
            {
                Console.WriteLine("Please confirm that you enterred the correct value for Fahrenheit");

                Console.WriteLine($"You enterred '{confirmFaht1.StillConvertingFahrenheitToCelsius}' for the fahrenheit value");
                Console.WriteLine();
                Console.WriteLine("Is that correct, enter 'yes' to continue or 'no' to change that value");
                string userThirdAns = Console.ReadLine().ToUpper();

                // using a switch-case here
                switch (userThirdAns)
                {
                    case "YES":
                        Console.WriteLine("Great, Lets move on");
                        ConvertFahrenheitToCelsius(confirmFaht1);
                        break;
                    case "NO":
                        Console.WriteLine("Lets fix up your fahrenheit value");
                        Console.WriteLine("Enter a new value for your fahrenheit temperature");
                        string newFaht1Value = Console.ReadLine();
                        double newFaht1ValueInt = double.Parse(newFaht1Value);

                        double newKFahreheitStandard = 32;
                        confirmFaht1.ConvertingFahrenheitToCelsius = newFaht1ValueInt;
                        confirmFaht1.StillConvertingFahrenheitToCelsius = newKFahreheitStandard;


                        ConfirmOrEditFirstFahrenheit(confirmFaht1);

                        break;

                    default:
                        Console.WriteLine("Sorry I didnt get that");
                        Main();
                        break;

                }

                // the UI that works with the Fahrenheit to celsius method.
                // method has already been written in its own business logic file, nowits time for the UI logic to handle the business logic code

                static void ConvertFahrenheitToCelsius(FahrenheitToCelsius finalFaht1)
                {
                    double userFaht1Vakue = finalFaht1.ConvertingFahrenheitToCelsius;
                    double StandardFaht1Vakue = finalFaht1.StillConvertingFahrenheitToCelsius;

                    double faht1Result = finalFaht1.FahrenheitConverterMethod();

                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"Your result is {faht1Result}C");
                    Console.WriteLine("--------------------------------");

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Yay, your temperature value has been converted from fahrenheit to celsius");
                    Console.WriteLine("What's next?");
                    Console.WriteLine("Would you like to convert a (new) temperature");
                    Console.WriteLine();
                    Console.WriteLine("Please Enter 'new' to convert a new temperature, To exit, enter 'X'");
                    string userContinue3 = Console.ReadLine().ToUpper();

                    switch (userContinue3)
                    {
                        case "NEW":
                            Main();
                            break;


                        case "X":
                            Console.WriteLine("Goodbye My dear User");
                            break;


                        default:
                            Console.WriteLine("Sorry, I didn't get that; Lets try again");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Main();
                            break;
                    }

                }






            }


        }
        // for celsius to fahrenheit
        else if (userStarts == "CF")
        {

            Console.WriteLine("You selected the option for a conversion of Celsius to Fahrenheit");
            Console.WriteLine("We'll help you convert a celsius Temperature into a fahrenheit one");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter in the celsius value");

            string firstCelsius = Console.ReadLine();

            int firstCelsiusInt = int.Parse(firstCelsius);


            double fahrenheitStandard = 32;

            CelsiusToFahrenheit cel1 = new CelsiusToFahrenheit(firstCelsiusInt, fahrenheitStandard);

            ConfirmOrEditSecondFahrenheit(cel1);

            // code for method to confirm or edit fahrenheit value supplied by user.

            static void ConfirmOrEditSecondFahrenheit(CelsiusToFahrenheit confirmCel2)
            {
                Console.WriteLine("Please confirm that you enterred the correct value for Fahrenheit");

                Console.WriteLine($"You enterred '{confirmCel2.StillConvertingCelsiusToFahrenheit}' for the fahrenheit value");
                Console.WriteLine();
                Console.WriteLine("Is that correct, enter 'yes' to continue or 'no' to change that value");
                string userThirdAns = Console.ReadLine().ToUpper();

                // using a switch-case here
                switch (userThirdAns)
                {
                    case "YES":
                        Console.WriteLine("Great, Lets move on");
                        ConvertCelsiusToFahrenheit(confirmCel2);
                        break;

                    case "NO":
                        Console.WriteLine("Lets fix up your fahrenheit value");
                        Console.WriteLine("Enter a new value for your fahrenheit temperature");
                        string newFaht1Value = Console.ReadLine();
                        double newFaht1ValueInt = double.Parse(newFaht1Value);

                        double newCelsiusStandard = 32;
                        confirmCel2.ConvertingCelsiusToFahrenheit = newFaht1ValueInt;
                        confirmCel2.StillConvertingCelsiusToFahrenheit = newCelsiusStandard;


                        ConfirmOrEditSecondFahrenheit(confirmCel2);

                        break;

                    default:
                        Console.WriteLine("Sorry I didnt get that");
                        Main();
                        break;

                }

                // the UI that works with the Fahrenheit to celsius method.
                // method has already been written in its own business logic file, nowits time for the UI logic to handle the business logic code

                static void ConvertCelsiusToFahrenheit(CelsiusToFahrenheit finalCel1)
                {
                    double userFaht1Vakue = finalCel1.ConvertingCelsiusToFahrenheit;
                    double StandardFaht1Vakue = finalCel1.StillConvertingCelsiusToFahrenheit;

                    double cel1Result = finalCel1.SecondFahrenheitConverterMethod();

                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"Your result is {cel1Result}C");
                    Console.WriteLine("--------------------------------");

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Yay, your temperature value has been converted from fahrenheit to celsius");
                    Console.WriteLine("What's next?");
                    Console.WriteLine("Would you like to convert a (new) temperature");
                    Console.WriteLine();
                    Console.WriteLine("Please Enter 'new' to convert a new temperature, To exit, enter 'X'");
                    string userContinue2 = Console.ReadLine().ToUpper();

                    switch (userContinue2)
                    {
                        case "NEW":
                            Main();
                            break;


                        case "X":
                            Console.WriteLine("Goodbye My dear User");
                            break;


                        default:
                            Console.WriteLine("Sorry, I didn't get that; Lets try again");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Main();
                            break;
                    }

                }






            }

        }
        // for kelvin to celsius
        else if (userStarts == "KC")
        {
            Console.WriteLine("You selected the option for a conversion of Kelvin to Celsius");
            Console.WriteLine("We'll help you convert a Kelvin Temperature into a celsius one");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter in the kelvin value");
            string kelvinValue = Console.ReadLine();

            // converting that string into a integer

            int kelvinValueInt = int.Parse(kelvinValue);

            Console.WriteLine(kelvinValueInt);

            double celsiusStandard = -273.15;

            // instantiating a new KelvinToCelsius object so I can store user's value in it

            KelvinToCelsius kel = new KelvinToCelsius(kelvinValueInt, celsiusStandard);

            // running a method to confirm or edit the value my user enterred for kelvin

            ConfirmOrEditKelvin(kel);

            static void ConfirmOrEditKelvin(KelvinToCelsius confirmKel)
            {
                Console.WriteLine("Please confirm that you enterred the correct value for kelvin");

                // here is where I used my getter to get user information on their kelvin value
                // so they can choose to use my setter to set information on their kelvin value or not
                Console.WriteLine($"You enterred {confirmKel.StillConvertingKelvinToCelsius} for the kelvin value");
                Console.WriteLine();
                Console.WriteLine("Is that correct, enter 'yes' to continue or 'no' to change that value");
                string userAns = Console.ReadLine().ToUpper();

                // using a switch-case here
                switch (userAns)
                {
                    case "YES":
                        Console.WriteLine("Great, Lets move on");
                        ConvertKelvinValueToCelsius(confirmKel);
                        break;
                    case "NO":
                        Console.WriteLine("Lets fix up your kelvin value");
                        Console.WriteLine("Enter a new value for your kelvin temperature");
                        string newKelvinValue = Console.ReadLine();
                        double newKelvinValueInt = double.Parse(newKelvinValue);

                        double newCelsiusStandard = -273.15;

                        // no need to reinstantiate an instnace of my KelvinTOCelsius class, I have a setter property in it that can achieve that for me
                        // saving it up; and I used confirmKel this time around because thats the kelvinToCelsius object I instantiated for this method
                        confirmKel.ConvertingKelvinToCelsius = newKelvinValueInt;
                        confirmKel.StillConvertingKelvinToCelsius = newCelsiusStandard;


                        // Now inside our method, we run our method again so it keeps confirming if the kelvin value of my user is correct
                        // what we did here is looping, we keep asking our users questions on whether a certain value is correct before they proceed
                        // Again, the concept of calling methodA inside methodA is known as looping

                        ConfirmOrEditKelvin(confirmKel);

                        break;
                    // Always remember to add these break statements in a switch-case block so it knows you are donw with that case


                    default:
                        Console.WriteLine("Sorry I didnt get that");
                        Main();
                        break;
                }

            }


            // Console.WriteLine("Would you like to proceed('YES' or 'NO')");
            // string userProceed = Console.ReadLine().ToUpper();





            // if (userProceed == "YES")
            // {
            //     ConvertKelvinValueToCelsius();
            // }
            // else if (userProceed == "NO")
            // {
            //     Main();
            // }
            // else
            // {
            //     Console.WriteLine("Sorry, I didn't get that, lets try again");
            //     Main();
            // }

            // The first UI logic method to write will be on picking up a Kelvin temperature and converting it to a 
            // celsius temperature 

            static void ConvertKelvinValueToCelsius(KelvinToCelsius finalKel)
            {
                double userKelvinValue = finalKel.StillConvertingKelvinToCelsius;
                double standardCelsiusValue = finalKel.ConvertingKelvinToCelsius;


                double result = finalKel.KelConverterMethod();

                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Your result is {result}C");


                Console.WriteLine("--------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Yay, you now have your Temperature value in Celsius");
                Console.WriteLine("What's next?");
                Console.WriteLine("Would you like to convert a new temperature (new)?");
                Console.WriteLine();
                Console.WriteLine("Please enter 'new' to convert a new temperature, enter 'get' to get all kelvin temperatures you've converted. To exit, enter X.");
                string userContinue = Console.ReadLine().ToUpper();

                switch (userContinue)
                {
                    case "NEW":
                        Main();
                        break;

                    case "X":
                        Console.WriteLine("Goodbye My dear User");
                        break;


                    default:
                        Console.WriteLine("Sorry, I didn't get that; Lets try again");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Main();
                        break;
                }



                Console.WriteLine();

            }





        }

        // for celsius to kelvin
        else if (userStarts == "CK")
        {
            Console.WriteLine("You selected the option for a conversion of Celsius To Kelvin");
            Console.WriteLine("We'll help you convert a Kelvin Temperature into a celsius one");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter in the Celsius value");
            string celsiusValue = Console.ReadLine();

            int celsiusValueInt = int.Parse(celsiusValue);

            Console.WriteLine(celsiusValueInt);

            double celsiusStandard = 273.15;

            CelsiusToKelvin cel = new CelsiusToKelvin(celsiusValueInt, celsiusStandard);

            // running a method to confirm or edit the value my user enterred for kelvin

            ConfirmOrEditSecondCelsius(cel);

            static void ConfirmOrEditSecondCelsius(CelsiusToKelvin confirmCel)
            {
                Console.WriteLine("Please confirm that you enterred the correct value for celsius");

                // here is where I used my getter to get user information on their celsius value
                // so they can choose to use my setter to set information on their celsius value or not
                Console.WriteLine($"You enterred {confirmCel.StillConvertingCelsiusToKelvin} for the celsius value");
                Console.WriteLine();
                Console.WriteLine("Is that correct, enter 'yes' to continue or 'no' to change that value");
                string userSecondAns = Console.ReadLine().ToUpper();

                // using a switch-case here
                switch (userSecondAns)
                {
                    case "YES":
                        Console.WriteLine("Great, Lets move on");
                        ConvertCelsiusValueToKelvin(confirmCel);
                        break;
                    case "NO":
                        Console.WriteLine("Lets fix up your kelvin value");
                        Console.WriteLine("Enter a new value for your kelvin temperature");
                        string newCelsiusValue = Console.ReadLine();
                        double newCelsiusValueInt = double.Parse(newCelsiusValue);

                        double newKelvinStandard = -273.15;
                        confirmCel.ConvertingCelsiusToKelvin = newCelsiusValueInt;
                        confirmCel.StillConvertingCelsiusToKelvin = newKelvinStandard;


                        ConfirmOrEditSecondCelsius(confirmCel);

                        break;

                    default:
                        Console.WriteLine("Sorry I didnt get that");
                        Main();
                        break;

                }


                // Writing the ConvertCelsiusValueToKelvin() method

                static void ConvertCelsiusValueToKelvin(CelsiusToKelvin finalCel)
                {
                    double userCelsiusValue = finalCel.StillConvertingCelsiusToKelvin;
                    double standardKelvinValue = finalCel.ConvertingCelsiusToKelvin;

                    double celsiusResult = finalCel.CelConverterMethod();

                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"Your result is {celsiusResult}K");
                    Console.WriteLine("--------------------------------");

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Yay, your temperature value has been converted from celsius to Kelvin");
                    Console.WriteLine("What's next?");
                    Console.WriteLine("Would you like to convert a (new) temperature");
                    Console.WriteLine();
                    Console.WriteLine("Please Enter 'new' to convert a new temperature, To exit, enter 'X'");
                    string userContinue2 = Console.ReadLine().ToUpper();

                    switch (userContinue2)
                    {
                        case "NEW":
                            Main();
                            break;


                        case "X":
                            Console.WriteLine("Goodbye My dear User");
                            break;


                        default:
                            Console.WriteLine("Sorry, I didn't get that; Lets try again");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Main();
                            break;
                    }

                }




            }

        }

        // for kelvin to fahrenheit
        else if (userStarts == "KF")
        {

            Console.WriteLine("You selected the option for a conversion of Kelvin To Fahrenheit");
            Console.WriteLine("We'll help you convert a kelvin Temperature into a fahrenheit one");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter in the kelvin value");

            string secondKelvinValue = Console.ReadLine();

            int secondKelvinValueInt = int.Parse(secondKelvinValue);

            Console.WriteLine(secondKelvinValueInt);

            double secondKelvinStandard = 32;

            KelvinToFahrenheit myKel = new KelvinToFahrenheit(secondKelvinValueInt, secondKelvinStandard);

            ConfirmOrEditSecondKelvin(myKel);

            static void ConfirmOrEditSecondKelvin(KelvinToFahrenheit confirmKel2)
            {
                Console.WriteLine("Please confirm that you enterred the correct value for kelvin");

                Console.WriteLine($"You enterred '{confirmKel2.StillConvertingKelvinToFahrenheit}' for the kelvin value");
                Console.WriteLine();
                Console.WriteLine("Is that correct? enter 'yes' to continue or 'no' to change that value");
                string userThirdAns = Console.ReadLine().ToUpper();
            
               switch (userThirdAns)
               {
                case "YES":
                    Console.WriteLine("Great, Lets now move on to actually converting the Kelvin Temperature to Fahreheit");
                    // Calling the method that actually does the conversion
                    ConvertKelvinValueToFahrenheit(confirmKel2);
                    break;
                case "NO":
                    Console.WriteLine("Let's fix up the kelvin value you enterred");
                    Console.WriteLine("Enter a new value for the kelvin");
                    string newKelvinValue2 = Console.ReadLine();
                    double newKelvinValue2Int = double.Parse(newKelvinValue2);
                    break;
                    // double newKelvinStandard2 = 

                default:
                    Console.WriteLine("I am so sorry, I didn't get that, Please try again");
                    Main();
                    break;
              
              
               }

            //    Writing the ConvertKelvinValueToFahrenheit() method I hav ecalled in the past
            static void ConvertKelvinValueToFahrenheit(KelvinToFahrenheit finalKel2)
            {
                double userKelvinValue = finalKel2.StillConvertingKelvinToFahrenheit;
                double standardKelvin2Value = finalKel2.ConvertingKelvinToFahrenheit;

                double faht2Result = finalKel2.SecondKelvinToFahrenheitConverterMethod();
            
                 Console.WriteLine("--------------------------------");
                    Console.WriteLine($"Your result is {faht2Result}F");
                    Console.WriteLine("--------------------------------");

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Yay, your temperature value has been converted from kelvin to fahrenheit");
                   Console.WriteLine("What's next?");
                    Console.WriteLine("Would you like to convert a (new) temperature");
                    Console.WriteLine();
                    Console.WriteLine("Please Enter 'new' to convert a new temperature, To exit, enter 'X'");
                    string userContinue5 = Console.ReadLine().ToUpper();

                     switch (userContinue5)
                    {
                        case "NEW":
                            Main();
                            break;


                        case "X":
                            Console.WriteLine("Goodbye My dear User");
                            break;


                        default:
                            Console.WriteLine("Sorry, I didn't get that; Lets try again");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Main();
                            break;
                    }

            }

            
            }

            // Moving on from the bug now, now its time to ask users would like to get their result 


        }
        // for fahrenheit to kelvin
        else if (userStarts == "FK")
        {
            // Console.WriteLine("Fahrenheit TO Kelvin; I am already working on it");

            
            Console.WriteLine("You selected the option for a conversion of Fahrenheit to Kelvin");
            Console.WriteLine("We'll help you convert a fahrenheit Temperature into a kelvin one");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter in the fahrenheit value");

            string secondFahrenheitValue = Console.ReadLine();

            int secondFahrenheitValueInt = int.Parse(secondFahrenheitValue);

            Console.WriteLine(secondFahrenheitValueInt);

            double secondFahtStandard = 32;

            FahrenheitToKelvin myFaht2 = new FahrenheitToKelvin(secondFahrenheitValueInt, secondFahtStandard);

            ConfirmOrEditThirdFahrenheit(myFaht2);

            static void ConfirmOrEditThirdFahrenheit(FahrenheitToKelvin confirmedFaht2)
            {
                Console.WriteLine("Please confirm that you have enterred the right value for fahrenheit");

                Console.WriteLine($"You enterred '{confirmedFaht2.StillConvertingFahrenheitToKelvin}' for the fahrenheit Temperature");
                Console.WriteLine();
                Console.WriteLine("Is that correct?  enter 'yes' to continue or 'no' to change that value");
                string userSixthAns = Console.ReadLine().ToUpper();
            
                switch (userSixthAns)
                {
                    case "YES":
                        Console.WriteLine("Great, Lets now move to actually converting the Fahrenheit Temperature to Kelvin");
                        // Calling the method that converts Fahrenheit Temperature to a Kelvin one
                        ConvertFahrenheitToKelvin(confirmedFaht2);
                        break;
                    case "NO":
                        Console.WriteLine("Let's fix up the Fahrenheit value you enterred");
                        Console.WriteLine("Enter a new value for the fahrenheit temperature");
                        string newFahtValue2 = Console.ReadLine();
                        double newFahtValue2Int  = double.Parse(newFahtValue2);
                        break;
                    
                    default:
                        Console.WriteLine("I a so sorry, I didn't get that, Please try again");
                        Main();
                        break;

                }

                // Writing the ConvertFahrenheitToKelvin() I called under my YES case
                static void ConvertFahrenheitToKelvin(FahrenheitToKelvin finalFaht2)
                {
                    double userFahtValue = finalFaht2.StillConvertingFahrenheitToKelvin;
                    double standardFaht3Value = finalFaht2.ConvertingfahrenheitToKelvin;

                    double Kev3Result = finalFaht2.FahrenheitConverterMethod();

                      Console.WriteLine("--------------------------------");
                    Console.WriteLine($"Your result is {Kev3Result}K");
                    Console.WriteLine("--------------------------------");

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Yay, your temperature value has been converted from fahrenheit to kelvin");
                   Console.WriteLine("What's next?");

                   Console.WriteLine("Would you like to convert a (new) temperature");
                    Console.WriteLine();
                    Console.WriteLine("Please Enter 'new' to convert a new temperature, To exit, enter 'X'");
                    string userContinue6 = Console.ReadLine().ToUpper();

                    // using a switch case to determine my users answer
                    switch(userContinue6)
                    {
                        case "NEW":
                            Main();
                            break;
                        
                        case "X":
                            Console.WriteLine("Goodbye My Dear User");
                            break;

                        default:
                            Console.WriteLine("Sorry, I didnt get that, Please try again");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Main();
                            break;
                    }
                  

                }
            }




        }

        // the else branch if user inputs 
        else
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("I am sorry, I didn't get that; Please try again");
            Main();
        }

    }
}