using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorShop.Pages.Learn_Blazor
{
    public class LearnBlazorBase: ComponentBase
    {
        protected string name = "Spark";
        protected string WelcomeText = "Time to learn Blazor!";

        protected void getName() {
            name="Blazor Learner";
        }
    }
}