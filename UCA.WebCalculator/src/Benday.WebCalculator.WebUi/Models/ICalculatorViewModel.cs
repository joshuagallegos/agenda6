using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UCA.WebCalculator.Tests.Presentation
{
    public interface ICalculatorViewModel
    {
        bool IsResultValid { get; set; }
        string Message { get; set; }
        string Operator { get; set; }
        List<SelectListItem> Operators { get; set; }
        double ResultValue { get; set; }
        double Value1 { get; set; }
        double Value2 { get; set; }
    }
}