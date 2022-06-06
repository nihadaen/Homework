using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Market bravo = new Market()
            {
                ProductLimit = 3,
            };
            string num;
            do
            {
                Console.WriteLine("1. Product əlavə et \n" +
                                  "2. Product sat \n" +
                                  "3. Productlara bax \n" +
                                  "4. Menudan çıx");
                num = Console.ReadLine();
                if (num == "1")
                {
                    try
                    {
                        Console.WriteLine("Product adını qeyd edin: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Product qiymətini daxil edin: ");
                        string numPr = Console.ReadLine();
                        double pr = Convert.ToDouble(numPr);
                        Console.WriteLine("Productın sayını qeyd edin: ");
                        string countStr = Console.ReadLine();
                        int x = Convert.ToInt32(countStr);
                        Console.WriteLine("Productın No dəyərini daxil edin: ");
                        string strNo = Console.ReadLine();
                        Product newPro = new Product
                        {
                            Name = name,
                            Price = pr,
                            No = strNo,
                            Count = x
                        };
                        bravo.AddProduct(newPro);
                    }
                    catch (ProductLimitIsFilledException exp)
                    {
                        Console.WriteLine(exp.Message);
                    }
                    catch (ProductIsExistException exp)
                    {
                        Console.WriteLine(exp.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bilinmədik bir xəta baş verdi.");
                    }
                }
                else if (num == "2")
                {
                    try
                    {
                        Console.WriteLine("No dəyəri daxil edin: ");
                        string noPro = Console.ReadLine();
                        bravo.SellProduct(noPro);
                    }
                    catch (ProductNotFoundException exp)
                    {
                        Console.WriteLine(exp.Message);
                    }
                    catch (ProductStockCountException exp)
                    {
                        Console.WriteLine(exp.Message);
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine("Bilinmədik bir xəta baş verdi.");
                    }
                }
                else if (num == "3")
                {
                    if (bravo.Products.Length == 0)
                    {
                        Console.WriteLine("Məhsul yoxdur!");
                    }
                    foreach (var i in bravo.Products)
                    {
                        i.ShowInfo();
                    }
                }
            } while (num != "4");

            Console.WriteLine("Marketdən çıxış edildi!");
        }
    }
}