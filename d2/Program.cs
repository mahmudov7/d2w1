//task 1
// int a=Convert.ToInt32(Console.ReadLine());
// int[] ints = new int[a];
// for(int i=0; i<a; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int sumj=0;
// int sumt=0;
// for(int i=0; i<a; i++)
// {
//     if (i % 2 == 0)
//     {
//         sumj+=ints[i];
//     }
//     if (a % 2 != 0)
//     {
//         sumt+=ints[i];
//     }
// }
// if (sumj > sumt)
// {
//     System.Console.WriteLine("juftho buzurgtarand");
// }
// else
// {
//     System.Console.WriteLine("toqho buzurgtaran");
// }



//task 2
// int a=Convert.ToInt32(Console.ReadLine());
// int[] ints = new int[a];
// for(int i=0; i<a; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int mx=int.MinValue;
// int mxi=0;
// int mn=int.MaxValue;
// int mni=0;
// for(int i=0;i <a; i++)
// {
//     if (ints[i] > mx)
//     {
//         mx=ints[i];
//         mxi=i;
//     }

// }
// System.Console.WriteLine($"{mx}-{mxi}");


//task 3

// int a=Convert.ToInt32(Console.ReadLine());
// int[] ints = new int[a];
// for(int i=0; i<a; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int s=0;
// for(int i=1; i<a-1; i++)
// {
//     if (ints[i] > ints[i-1])
//     {
//         s++;
//     }
// }

// System.Console.WriteLine(s);



//task4

// int a=Convert.ToInt32(Console.ReadLine());
// int[] ints = new int[a];
// for(int i=0; i<a; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i=0; i<a; i++)
// {
//     if (ints[i] < 0)
//     {
//         System.Console.WriteLine(ints[i]-ints[i]-ints[i]+" ");;
//     }
//     else
//     {
//         System.Console.WriteLine(ints[i]+" ");
//     }
// }



//task 5
// int a=Convert.ToInt32(Console.ReadLine());
// int[] ints = new int[a];
// for(int i=0; i<a; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int s=0;
// for(int i=0; i<a; i++)
// {
//     if(ints[i]%2==0 && ints[i + 1] % 2 == 0)
//     {
//         s++;
//     }
// }


//task 6

// int a=Convert.ToInt32(Console.ReadLine());
// int rev=0;
// for(int i=a; i>0; i /= 10)
// {
//     rev=rev*10+i%10;
// }
// if (a == rev)
// {
//     System.Console.WriteLine("palindrome");
// }
// else
// {
//     System.Console.WriteLine("not palindrome");
// }

//Task 7



//task 8

// int a=Convert.ToInt32(Console.ReadLine());
// int[] ints = new int[a];
// for(int i=0; i<a; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i=1; i<a; i++)
// {
//    System.Console.WriteLine(ints[i]+" "); 
// }
// System.Console.WriteLine(ints[1]+" ");


//Task 9 

// int a=Convert.ToInt32(Console.ReadLine());
// int[] ints = new int[a];
// for(int i=0; i<a; i++)
// {
//     ints[i] = Convert.ToInt32(Console.ReadLine());
// }
// int s=0;
// int c=0;
// for(int i=0; i<a; i++)
// {
//     s+=ints[i];
//     c++;
// }
// int ma=s/c;
// int cnt=0;
// System.Console.Write(ma+"-");
// for(int i=0; i<a; i++){
//     if (ma < ints[i])
//     {
//         cnt++;
//         System.Console.Write(ints[i]+" ");
//     }
// }
// System.Console.WriteLine("-->"+cnt);



//Task 10
