using LW3_OKR;
using MongoDB.Driver;
using Moq;

namespace TestProjec
{
    public class MongoDBPersonalTests
    {
        private readonly Mock<IMongoCollection<Personal>> mockCollection;
        private readonly MongoDBPersonal service;

        public MongoDBPersonalTests()
        {
            mockCollection = new Mock<IMongoCollection<Personal>>();
            service = new MongoDBPersonal(mockCollection.Object);
        }

        [Fact]
        public void AddPersonal_ShouldInsertItem()
        {
            // Arrange
            var newPerson = new Personal("Test", "User", "Manager", "Active");

            // Act
            service.AddPersonal(newPerson);

            // Assert
            mockCollection.Verify(c => c.InsertOne(newPerson, null, default), Times.Once);
        }

        [Fact]
        public void UpdatePersonal_ShouldCallReplaceOne()
        {
            // Arrange
            var updated = new Personal("A", "B", "C", "D");

            // Act
            service.UpdatePersonal("123", updated);

            // Assert
            mockCollection.Verify(c =>
                c.ReplaceOne(
                    It.IsAny<FilterDefinition<Personal>>(),
                    updated,
                    It.IsAny<ReplaceOptions>(),
                    default),
                Times.Once);
        }

        [Fact]
        public void DeletePersonal_ShouldCallDeleteOne()
        {
            // Act
            service.DeletePersonal("123");

            // Assert
            mockCollection.Verify(c =>
                c.DeleteOne(
                    It.IsAny<FilterDefinition<Personal>>(),
                    default),
                Times.Once);
        }

    }
}