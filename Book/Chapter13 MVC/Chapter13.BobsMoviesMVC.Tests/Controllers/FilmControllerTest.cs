using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BobsMoviesMVC;
using Chapter13.BobsMoviesMVC.Controllers;
using Chapter13.BobsMoviesMVC.Models;

namespace BobsMoviesMVC.Tests.Controllers
{
    [TestClass]
    public class FilmControllerTest
    {

        [TestMethod]
        public void All_Action_Should_Return_All_View()
        {
            FilmController controller = new FilmController(GetFakeRepository());
            ViewResult result = controller.All() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Test_To_Show_What_Failed_Test_Looks_Like()
        {
            Assert.IsTrue(1 == 2);
        }

        [TestMethod]
        public void Detail_Action_Should_Return_Specific_Film_Matching_ID()
        {

            FilmController controller = new FilmController(GetFakeRepository());
            ViewResult result = controller.Detail(1) as ViewResult;
            Assert.IsTrue(result.ViewData["title"].ToString() == "Test film");
        }

        [TestMethod]
        public void Film_Should_NotValidate_With_No_Title()
        {
            Film Film= new Film();
            Film.Title = "";
            Assert.IsTrue(Film.IsValid() == false);
        }

        private BobsMoviesMVC.Support.FakeFilmRepository GetFakeRepository()
        {
            //Set up pretend repository 
            BobsMoviesMVC.Support.FakeFilmRepository PretendRepository = new BobsMoviesMVC.Support.FakeFilmRepository();

            //Add a film to pretend repository
            PretendRepository.Films.Add(new Film { FilmID = 1, Title = "Test film" });

            return PretendRepository;
        }
    }
}
