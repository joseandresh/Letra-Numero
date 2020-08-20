using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numero_Letra.Controllers;

namespace UnitTestConversor
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestConvert1()
		{
			//Arrange
			LiteralController literalController = new LiteralController();
			int a = 0;
			string esperado = "CERO";

			//Act
			string resultado = literalController.LiteralGet(a);

			//Assert
			Assert.AreEqual(esperado, resultado);
		}
		[TestMethod]
		public void TestConvert2()
		{
			//Arrange
			LiteralController literalController = new LiteralController();
			int a = 13;
			string esperado = "TRECE";

			//Act
			string resultado = literalController.LiteralGet(a);

			//Assert
			Assert.AreEqual(esperado, resultado);
		}
		[TestMethod]
		public void TestConvert3()
		{
			//Arrange
			LiteralController literalController = new LiteralController();
			int a = 15;
			string esperado = "QUINCE";

			//Act
			string resultado = literalController.LiteralGet(a);

			//Assert
			Assert.AreEqual(esperado, resultado);
		}
		[TestMethod]
		public void TestConvert4()
		{
			//Arrange
			LiteralController literalController = new LiteralController();
			int a = 251;
			string esperado = "DOSCIENTOS CINCUENTA Y UNO";

			//Act
			string resultado = literalController.LiteralGet(a);

			//Assert
			Assert.AreEqual(esperado, resultado);
		}
		[TestMethod]
		public void TestConvert5()
		{
			//Arrange
			LiteralController literalController = new LiteralController();
			int a = 9117;
			string esperado = "NUEVE MIL CIENTO DIECISIETE";

			//Act
			string resultado = literalController.LiteralGet(a);

			//Assert
			Assert.AreEqual(esperado, resultado);
		}
		[TestMethod]
		public void TestConvert6()
		{
			//Arrange
			LiteralController literalController = new LiteralController();
			int a = 10684;
			string esperado = "DIEZ MIL SEISCIENTOS OCHENTA Y CUATRO";

			//Act
			string resultado = literalController.LiteralGet(a);

			//Assert
			Assert.AreEqual(esperado, resultado);
		}
		[TestMethod]
		public void TestConvert7()
		{
			//Arrange
			LiteralController literalController = new LiteralController();
			int a = 1001001;
			string esperado = "UN MILLON MIL UNO";

			//Act
			string resultado = literalController.LiteralGet(a);

			//Assert
			Assert.AreEqual(esperado, resultado);
		}
		[TestMethod]
		public void TestConvert8()
		{
			//Arrange
			LiteralController literalController = new LiteralController();
			int a = 1000000000;
			string esperado = "MIL MILLONES ";

			//Act
			string resultado = literalController.LiteralGet(a);

			//Assert
			Assert.AreEqual(esperado, resultado);
		}
	}
}
