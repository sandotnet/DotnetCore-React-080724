using MessageService.Repositories;
namespace MessageTest
{
    public class MessageRepoTest
    {
        [Fact]
        public void GreetTest()
        {
            //Act
            string expected = "Hi Virat";
            MessageRepository repository = new MessageRepository();
            //Arrange
            string actual = repository.Greet("Virat");
            Assert.Equal(expected, actual);

        }
    }
}