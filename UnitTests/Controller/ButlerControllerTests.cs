using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Project.Tests.Controller
{
    public class ButlerControllerTests
    {
        [Fact]
        public void WatchLoop_AssignsTableToClient_WhenClientArrives()
        {
            // Arrange
            var model = new Model
            {
                restaurationRoom = new RestaurationRoom
                {
                    clients = new List<Client>
                    {
                        new Client { state = Client.Etat.Arrive, numberClients = 2 }
                    },
                    squares = new List<Square>
                    {
                        new Square
                        {
                            ranks = new List<Rank>
                            {
                                new Rank
                                {
                                    tables = new List<Table>
                                    {
                                        new Table { avaible = true, numberOfPlace = 4, numberTable = 1 }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            var butlerController = new ButlerController(model);

            // Act
            Task.Delay(100).Wait(); // Attendre un peu pour laisser le temps à la tâche de s'exécuter

            // Assert
            Assert.Equal(Client.Etat.attente, model.restaurationRoom.clients[0].state);
            Assert.Equal(1, model.restaurationRoom.clients[0].tableNumber);
            Assert.False(model.restaurationRoom.squares[0].ranks[0].tables[0].avaible);
        }
    }

    // Classes simulées pour les tests
    public class Model
    {
        public RestaurationRoom restaurationRoom { get; set; }
    }

    public class RestaurationRoom
    {
        public List<Client> clients { get; set; }
        public List<Square> squares { get; set; }
    }

    public class Client
    {
        public enum Etat { Arrive, attente }
        public Etat state { get; set; }
        public int numberClients { get; set; }
        public int tableNumber { get; set; }
    }

    public class Square
    {
        public List<Rank> ranks { get; set; }
    }

    public class Rank
    {
        public List<Table> tables { get; set; }
    }

    public class Table
    {
        public bool avaible { get; set; }
        public int numberOfPlace { get; set; }
        public int numberTable { get; set; }
        public Client client { get; set; }
    }
}