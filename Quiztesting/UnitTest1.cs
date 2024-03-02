using NUnit.Framework;
using Onlinequiztest.Controllers;
using Onlinequiztest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace Onlinequiztest.Tests
{
    [TestFixture]
    public class Tests
    {
       

            private QuizController _controller;



            [SetUp]

            public void Setup()

            {

                _controller = new QuizController();

            }



            [Test]

            public async Task Get_ReturnsListOfModels()

            {

                // Act 

                var result = await _controller.Get();



                // Assert 

                Assert.IsNotNull(result);

                Assert.IsInstanceOf<List<Quiz>>(result);

            }



            [Test]

            public async Task Post_ReturnsOkResult()

            {

                // Arrange 

                var model = new Quiz { Id = 1, Title = "NewQuiz", Category="History",Numberofquestions=100,Maximummark=90,Totalmarks=100 };



                // Act 

                var result = await _controller.Post(model);



                // Assert 

                Assert.IsNotNull(result);

                Assert.IsInstanceOf<OkResult>(result);

            }

        }

    }
