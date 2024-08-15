namespace DesignPattern;

class Program
{
    static void Main(string[] args)
    {
        //int[] arrInput = {1,2,3,4,5,2,1,6,7,3};
        int[] arrInput = { 1,3,2,6,4,5,2,1,6,7,3 };
        int[] arrOuputSample = { 1, 2, 3, 2, 1, 3};

        List<int> lstExpOutput = new();
        List<int> lstExp = new();

        Dictionary<int, int> dctOut = new Dictionary<int, int>();
        foreach (int item in arrInput)
        {
            if(dctOut.ContainsKey(item))
            {
                dctOut[item]++;
                lstExp.Add(item);
            }
            else
            {
                dctOut.Add(item, 1);
            }
        }

        lstExpOutput = dctOut.Where(a => a.Value > 1).Select(a => a.Key).ToList();

        lstExpOutput.AddRange(lstExp);


        #region "Prince company Code"
        //List<ProductClass> lstFinalProduct = new List<ProductClass>();
        //List<ProductClass> lstProduct = new List<ProductClass>();

        //lstProduct.Add(new ProductClass()
        //{
        //   name = "saving account",
        //   price = "100",
        //   productCVarients = new List<ProductCVarient>()
        //   {
        //       new ProductCVarient()
        //   {
        //           varientId = 1,
        //           varientName = "test",

        //   },
        //    new ProductCVarient()
        //    {
        //        varientId = 2,
        //        varientName = "test2"
        //    }
        //    ,
        //    new ProductCVarient()
        //    {
        //        varientId = 7,
        //        varientName = "test2"
        //    }
        //    ,
        //    new ProductCVarient()
        //    {
        //        varientId = 10,
        //        varientName = "test2"
        //    }

        //   }
        //});

        //lstProduct.Add(new ProductClass()
        //{
        //    name = "insurance ",
        //    price = "100",
        //    productCVarients = new List<ProductCVarient>()
        //   {
        //       new ProductCVarient()
        //   {
        //           varientId = 3,
        //           varientName = "test",

        //   },
        //    new ProductCVarient()
        //    {
        //        varientId = 5,
        //        varientName = "test2"
        //    }

        //   }
        //});

        //List<int> lstVar = new List<int>();
        //lstVar.Add(1);
        //lstVar.Add(2);

        //foreach(var item in lstProduct)
        //{
        //    List<ProductCVarient> lstvarTemp = new List<ProductCVarient>();
        //    foreach(int varient in lstVar)
        //    {
        //        var result = item.productCVarients.Where(a => a.varientId == varient).ToList();
        //        if(result != null && result.Count > 0)
        //        {
        //            lstvarTemp.AddRange(result);
                    
        //        }
        //    }

        //    if(lstvarTemp != null && lstvarTemp.Count > 0)
        //    {
        //        lstFinalProduct.Add(new ProductClass()
        //        {
        //            name = item.name,
        //            price = item.price,
        //            productCVarients = lstvarTemp
        //        });
        //    }

        //    if(lstvarTemp.Count() == lstVar.Count())
        //    {
        //        break;
        //    }
        //}

        #endregion
        Testing testing = new Testing();
        //string[] words = { "apple", "banana", "apple", "orange", "banana", "apple" };
        //string mostFrequentWord = testing.FindMostFrequentWord(words);
        //Console.WriteLine("Most frequent word: " + mostFrequentWord);

        // Waiter waiter = new Waiter();
        // IPizza pizza = waiter.GetPizza("NonVeg");
        // Console.WriteLine(pizza.Eat());

        /*CallWaiter callWaiter = new CallWaiter("NonVeg");
        IPizza pizza = callWaiter.GetPizza();
        IBurger burger = callWaiter.GetBurger();
        Console.WriteLine(pizza.Eat());
        Console.WriteLine(burger.Eat());*/

        //OverLoading overLoading = new OverLoading();
        //overLoading.Call(1.222);
    }
}

