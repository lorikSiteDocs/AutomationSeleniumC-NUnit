using NUnit.Framework;
using AutomationSeleniumC_.driver;
using AutomationSeleniumC_.Implementation;


namespace AutomationSeleniumC_.Tests {
  
    public class Tests : InitializeUserDriver

    {
        String standardUser = "standard_user";
        String lockedOutUser = "locked_out_user";
        String problemUser = "problem_user";
        String glitchUser = "performance_glitch_user";


        [Test, Order(1), Description("This test case tests if standard user can log in!")]
        public void loginWithStandardUser()

        {
            LoginImpl loginImpl = new LoginImpl(driver);
            loginImpl.loginWithDifferentUsesrs(standardUser);

        }

        [Test, Order(2), Description("This test case tests if locked out user can log in!")]
        public void loginWithLockedOutUser()

        {
            LoginImpl loginImpl = new LoginImpl(driver);
            loginImpl.loginWithDifferentUsesrs(lockedOutUser);

        }

        [Test, Order(3), Description("This test case tests if problem user can log in!")]
        public void loginWithProblemUser()

        {
            LoginImpl loginImpl = new LoginImpl(driver);
            loginImpl.loginWithDifferentUsesrs(problemUser);

        }

        [Test, Order(4), Description("This test case tests if glitch user can log in!")]
        public void loginWithGlitchUser()

        {
            LoginImpl loginImpl = new LoginImpl(driver);
            loginImpl.loginWithDifferentUsesrs(glitchUser);

        }

    }

}
