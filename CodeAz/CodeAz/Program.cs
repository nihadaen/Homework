using System;

namespace CodeAz
{
    class Program
    {
        static void Main(string[] args)
        {
            wantedName();
        }

        #region Class tasks
        
        static int Sum(int num1, int num2)
        {
            return num1+num2;
        }
        
        static bool isEven(int num)
        {
            return num % 2 == 0;
        }
        
        static int bigNum(int num1,int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
        }
        
        static void arrayWrite(int[] nums)
        {
            foreach (var i in nums)
            { 
                Console.WriteLine(nums[i]);
            }
        }
        
        static int findCount(int[] numbers,int n)
        {
            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == n)
                {
                    count++;
                }
            }
            return count;
        }
        
        static int average(int[] points)
        {
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < points.Length; i++)
            { 
                sum += points[i];
            }
            if(points.Length>0)
                avg = sum / points.Length;
            return avg;
        }
        
        static bool hasName(string[] names,string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return true;
            }
            return false;
        }
        
        #endregion

        #region Task2

        // - Verilmis adlar siyahisinda (string array) nece adin uzunlugunun 5-den boyuk oldugunu tapan proqram

        static int howMany(string[] names)
        {
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > 5)
                    count++;
            }

            return count;
        }

        #endregion

        #region Task3

        //Verilmis ededler siyahisindaki cut ededlerden ibraret yeni bir array qaytaran method.Misalcun
        //gonderilmis ededler siyahisinda {1,3,4,5,6} deyerleri varsa method geriye {4,6} deyerlerinden
        //ibaret bir array qaytarmalidir
        
        static int[] evenArr(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    count++;
                }
            }

            int[] newArr = {};

            if (count > 0)
            {
                newArr = new int[count];
                int a = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        newArr[a] = nums[i];
                        a++;
                    }
                }
            }
            // Array qaytarır sadəcə System.Int32[] olaraq. Çünki print etmədim arrayin olduğu adresi göstərir sadəcə. 
            // ToString methodu işlətmədim. Ama print etmək istəsək edə bilərəm sadəcə burda yalnız qaytar deyir. 
            return newArr;
        }

        #endregion
        
        #region additionalTask
        
        // - Layihe ise dusdukde sizden adlarin sayini istesin. Daha sonra o say qeder adlari daxil edin.
        // Daha sonra axtardiginiz adi istesin, onu da daxil etdikden sonra siyahida olub olmadigini qaytarsin
        static void wantedName()
        {
            Console.WriteLine("Adların sayını qeyd edin: ");
            string numStr = Console.ReadLine();
            int x = Convert.ToInt32(numStr);
            string[] names = new string[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Ad daxil edin: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("Axtardığınız adı daxil edin: ");
            string desiredName = Console.ReadLine();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(desiredName))
                {
                    Console.WriteLine("Daxil etdiyiniz ad siyahıda var.");
                    return;
                }
            }

            Console.WriteLine("Daxil etdiyiniz ad siyahıda yoxdur.");
        }

        #endregion
    }
}