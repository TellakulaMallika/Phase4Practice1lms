﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
        
        }
        [When(@"I enter my username and password")]
        public void WhenIEnterMyUsernameAndPassword()
        {
            
        }

        [When(@"I click the login buttton")]
        public void WhenIClickTheLoginButtton()
        {
            
        }

        [Then(@"I should see the dashboard")]
        public void ThenIShouldSeeTheDashboard()
        {
            
        }
        
       

        
        

    }
}
    
    