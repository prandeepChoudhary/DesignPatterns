using System;
namespace DesignPattern
{
	/*public class MySingleton
	{
		private MySingleton() { }
		private static object locker = new object();
		private static MySingleton instance;

		public static MySingleton GetInstance()
		{
            if (instance == null)
			{
                lock (locker)
                {
                    if (instance == null)
                        instance = new MySingleton();
                }
            }
            return instance;
		}
	}*/

	public class MySingleton
	{
		private MySingleton() { }
		private static object locker = new object();
		private static MySingleton instance;

		public static MySingleton GetSingleton()
		{
			if(instance != null)
			{
				lock(locker)
				{
					if(instance == null)
					{
                        instance = new MySingleton();
                    }
				}
			}
			return instance;
		}
	}
}

