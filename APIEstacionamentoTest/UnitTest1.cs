using API_Estacionamento;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppEstacionamento.controllers;
using AppEstacionamento.models;

namespace Teste_Estacionamento
{
	[TestClass]
	public class UnitTest1
	{
		Models.CheckIn checkin = new Models.CheckIn


		[TestInitialize]
	public void IniciarTestes
		{

		}


		///Criando testes para a classe Nome em entradas de veículos
		[TestMethod]
		public void testCreat()
		{
			Checkin novoCheckin = new Checkin();
			novoCheckin.Nome = "Dudu";
			var retorno = Models.CheckIn.Create(novoCheckin);
			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void testEdit()
		{
			Checkin novoCheckin = new Checkin();
			novoCheckin.Nome = "Dudu";
			var retorno = Models.CheckIn.Edit(novoCheckin);
			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void testDelete()
		{
			Checkin novoCheckin = new Checkin();
			novoCheckin.Nome = "Dudu";
			var retorno = Models.CheckIn.Delete(novoCheckin);
			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void testList()
		{
			List<Checkin> listaCheckin = Models.CheckIn.List();
			Assert.IsNotNull(listaCheckin);
		}

		[TestCleanup]
		public void FinalizarTest()
		{

		}

		///Criando testes para a classe Placa em entradas de veículos
		[TestMethod]
		public void testCreat()
		{
			Checkin novoCheckin = new Checkin();
			novoCheckin.Placa = "AZX8902";
			var retorno = Models.CheckIn.Create(novoCheckin);
			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void testEdit()
		{
			Checkin novoCheckin = new Checkin();
			novoCheckin.Placa = "AZX8902";
			var retorno = Models.CheckIn.Edit(novoCheckin);
			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void testDelete()
		{
			Checkin novoCheckin = new Checkin();
			novoCheckin.Placa = "AZX8902";
			var retorno = Models.CheckIn.Delete(novoCheckin);
			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void testList()
		{
			List<Checkin> listaCheckin = Models.CheckIn.List();
			Assert.IsNotNull(listaCheckin);
		}

		[TestCleanup]
		public void FinalizarTest()
		{

		}

		///Criando testes para a classe Veículo em entradas de veículos
		[TestMethod]
		public void testCreat()
		{
			Checkin novoCheckin = new Checkin();
			novoCheckin.Placa = "Prisma";
			var retorno = Models.CheckIn.Create(novoCheckin);
			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void testEdit()
		{
			Checkin novoCheckin = new Checkin();
			novoCheckin.Placa = "Prisma";
			var retorno = Models.CheckIn.Edit(novoCheckin);
			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void testDelete()
		{
			Checkin novoCheckin = new Checkin();
			novoCheckin.Placa = "Prisma";
			var retorno = Models.CheckIn.Delete(novoCheckin);
			Assert.AreEqual(true, resultado);
		}

		[TestMethod]
		public void testList()
		{
			List<Checkin> listaCheckin = Models.CheckIn.List();
			Assert.IsNotNull(listaCheckin);
		}

		[TestCleanup]
		public void FinalizarTest()
		{

		}
	}
}