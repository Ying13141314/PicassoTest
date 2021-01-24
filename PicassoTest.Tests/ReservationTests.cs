using NUnit.Framework;

namespace PicassoTest.Tests
{
    public class ReservationTests   
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User()
            {
                IsAdmin = true
            });

            //Assert
        }
    }
}