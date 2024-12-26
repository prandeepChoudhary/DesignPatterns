using System;
namespace DesignPattern.Array
{
	public class InterfaceTest : IA, IB
	{
		void IA.GetTest()
		{
		}
		void IB.GetTest()
		{
		}
	}

	public interface IA
	{
		void GetTest();
	}

    public interface IB
    {
        void GetTest();
    }
}

