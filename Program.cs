class Person
{
    public static void Main(string[] args)
    {
        int no_stud, no_sub;
        while (true)
        {
            Console.WriteLine("Enter the number of students :");
            if (int.TryParse(Console.ReadLine(), out no_stud) && no_stud > 0)
                break;

            Console.WriteLine("Invalid input. Enter a correct number.");
        }
        while (true)
        {
            Console.WriteLine("Enter the number of subjects :");
            if (int.TryParse(Console.ReadLine(), out no_sub) && no_sub > 0)
                break;

            Console.WriteLine("Invalid input. Enter a correct number.");
        }

        int[,] marks = new int[no_stud, no_sub];
        string[] subject = new string[no_sub];
        for (int i = 0; i < no_sub; i++)
        {
            while (true)
            {
                Console.WriteLine($"Enter subject {i + 1}: ");
                string? input = Console.ReadLine();

                int temp;

                if (string.IsNullOrWhiteSpace(input) || int.TryParse(input, out temp))
                {
                    Console.WriteLine("Invalid subject name!");
                    continue;
                }
                subject[i] = input;
                break;
            }
        }
        for (int i = 0; i < no_stud; i++)
        {
            Console.WriteLine($"Enter marks for student {i + 1}");

            for (int j = 0; j < no_sub; j++)
            {
                while (true)
                {
                    Console.WriteLine($"Enter mark for {subject[j]}:");
                    string? input = Console.ReadLine();

                    if (!int.TryParse(input, out marks[i, j]))
                    {
                        Console.WriteLine("Invalid input. Enter a number.");
                        continue;
                    }

                    if (marks[i, j] < 0 || marks[i, j] > 100)
                    {
                        Console.WriteLine("Marks must be between 0 and 100.");
                        continue;
                    }

                    break;
                }
            }
        }
        grad_calc(no_stud, no_sub, marks, subject);
    }
    public static void grad_calc(int no_stud, int no_sub, int[,] marks, string[] subject)
    {
        int total_class = 0;

        for (int i = 0; i < no_stud; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");
            int total_student = 0; 

            for (int j = 0; j < no_sub; j++)
            {
                int m = marks[i, j];

                if (m >= 90) Console.WriteLine($"{subject[j]} : A");
                else if (m >= 80) Console.WriteLine($"{subject[j]} : B");
                else if (m >= 70) Console.WriteLine($"{subject[j]} : C");
                else if (m >= 60) Console.WriteLine($"{subject[j]} : D");
                else Console.WriteLine($"{subject[j]} : E");

                total_student += m;
                total_class += m;
            }

            Console.WriteLine("Average: " + (total_student / (double)no_sub));
        }

        Console.WriteLine("\nClass Average: " + (total_class / (double)(no_stud * no_sub)));
        Console.WriteLine("\nSubject-wise Average:");
        for (int j = 0; j < no_sub; j++)
        {
            int sub_total = 0;

            for (int i = 0; i < no_stud; i++)
            {
                sub_total += marks[i, j];
            }
            Console.WriteLine($"{subject[j]} : {sub_total / (double)no_stud}");
        }
    }
}

// --------------------------------------------------------------------------------------------------------------
// class Person
// {
//     public static void Main(string[] args)
//     {
        
//         Console.WriteLine("Enter the number of students :");
//         int no_stud = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter the number of Subject :");
//         int no_sub = Convert.ToInt32(Console.ReadLine());
//         int[,] marks = new int[no_stud , no_sub];
//         String[] subject = new String[no_sub];
//         for(int i = 0 ; i < no_sub ; i++)
//         {
//             Console.WriteLine("Enter the Subjects " + i);
//             subject[i] = Console.ReadLine();
//         }
//         for(int i = 0 ; i <no_stud ; i++)
//         {
//             Console.WriteLine("Enter the marks for student "+i);
//             for(int j = 0 ; j <no_sub ; j++)
//             {
//                 Console.WriteLine("Enter the mark for subject " + subject[j]);
//                 marks[i,j] = Convert.ToInt32(Console.ReadLine());
//             }
//         }
//         grad_calc(no_stud , no_sub , marks , subject);

//     }

//     public static void grad_calc(int no_stud , int no_sub , int[,] marks , String[] subject)
//     {
//         int tot_fro_tot = 0;
//         int tot_per_stu = 0;
//         int[] sub_tot = new int[no_sub];
//         for(int i = 0 ; i < no_stud ; i++)
//         {
//             Console.WriteLine("The Grade and average for the student " + i);
//             sub_tot[i] = 0;
//             for(int j = 0 ; j < no_sub ; j++)
//             {
//                 int sin_mark = marks[i,j];
//                 if(sin_mark > 90){ Console.WriteLine("Grade in "+subject[j] + " is : A ");}
//                 else if (sin_mark > 80){ Console.WriteLine("Grade in "+subject[j] + " is : B ");}
//                 else if (sin_mark > 70){ Console.WriteLine("Grade in "+subject[j] + " is : C ");}
//                 else if (sin_mark > 60){ Console.WriteLine("Grade in "+subject[j] + " is : D ");}
//                 else{Console.WriteLine("Grade in "+subject[j] + " is : E ");}
//                 tot_per_stu += sin_mark;
//                 tot_fro_tot +=sin_mark;

//             }
//             Console.WriteLine("Average mark is : " + tot_per_stu/no_sub);
//         }
//         Console.WriteLine("The Average for the class is :" + tot_fro_tot/(no_stud*no_sub));

//         Console.WriteLine("The Average for each subjects are :");


//         int ite = 0;
//         for(int i = 0 ; i < no_sub ; i++)
//         {
//             sub_tot[i] = 0;
//             for(int j = 0 ; j < no_stud ; j++)
//             {
//                 sub_tot[i] += marks[j , ite];
//             }
//             ite++;
//             Console.WriteLine(subject[i] + " : " + sub_tot[i]/no_stud);
//         }
//     }
// }

// --------------------------------------------------------------------------------------------------------