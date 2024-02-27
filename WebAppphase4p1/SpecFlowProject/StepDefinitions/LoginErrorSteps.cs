﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class LoginErrorSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public LoginErrorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I enter incorrect username and password")]
        public void WhenIEnterIncorrectUsernameAndPassword()
        {

        }
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        { 


        }
        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {

        }


    }
}
